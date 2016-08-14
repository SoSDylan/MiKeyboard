using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiKeyboard.Classes
{
    class EffectController
    {
        Main main;

        public List<IEffect> effects = new List<IEffect>();

        public EffectController(Main main)
        {
            this.main = main;

            LoadEffectList();
        }

        public void LoadEffectList()
        {
            Directory.CreateDirectory("./Effects/");
            String[] files = Directory.GetFiles("./Effects/", "*.dll");
            foreach (var s in files)
                LoadEffect(Path.Combine(Environment.CurrentDirectory, s));
            Console.WriteLine("Effects loaded:");
            effects.ForEach(t => Console.WriteLine(t.Name + " - " + t.Author + " - " + t.Version));
        }

        public void LoadEffect(String file)
        {
            if (!File.Exists(file) || !file.EndsWith(".dll", true, null))
                return;

            Assembly asm = null;

            try
            {
                asm = Assembly.LoadFile(file);
            }
            catch (Exception)
            {
                // unable to load
                return;
            }

            Type effectInfo = null;
            try
            {
                Type[] types = asm.GetTypes();
                Assembly core = AppDomain.CurrentDomain.GetAssemblies().Single(x => x.GetName().Name.Equals("Lab.Core"));
                Type type = core.GetType("Lab.Core.IEffect");
                foreach (var t in types)
                    if (type.IsAssignableFrom((Type)t))
                    {
                        effectInfo = t;
                        break;
                    }

                if (effectInfo != null)
                {
                    Object o = Activator.CreateInstance(effectInfo);
                    IEffect effect = (IEffect)o;
                    effects.Add(effect);
                    effect.OnLoad();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
