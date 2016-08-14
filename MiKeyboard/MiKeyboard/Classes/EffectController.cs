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
            Directory.CreateDirectory(".\\Effects\\");
            String[] files = Directory.GetFiles("Effects\\", "*.dll");
            foreach (var s in files)
                LoadEffect(Path.Combine(Environment.CurrentDirectory, s));
            effects.ForEach(t => Console.WriteLine("Loaded " + t.Name + " " + t.Version + " by " + t.Author));
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
                effectInfo = types[0];

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
