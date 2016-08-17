using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CUE.NET.Devices.Generic.EventArgs;
using System.Drawing;
using CUE.NET.Devices.Keyboard.Enums;

namespace MiKeyboard.Classes
{
    internal class EffectController
    {
        Main main;

        internal List<IEffect> effects = new List<IEffect>();
        internal int selectedEffect = 0;

        internal EffectController(Main main)
        {
            this.main = main;

            LoadEffectList();
        }

        internal void Setup()
        {
        }

        internal void LoadEffectList()
        {
            Directory.CreateDirectory(".\\Effects\\");
            String[] files = Directory.GetFiles("Effects\\", "*.dll");
            foreach (var s in files)
                LoadEffect(Path.Combine(Environment.CurrentDirectory, s));
            effects.ForEach(t => Console.WriteLine("Loaded " + t.Name + " " + t.Version + " by " + t.Author));
        }

        internal void LoadEffect(String file)
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
                //Assembly core = AppDomain.CurrentDomain.GetAssemblies().Single(x => x.GetName().Name.Equals("MiKeyboard"));
                //for (int i = 0; i < core.GetTypes().Length; i++)
                //    Console.WriteLine(core.GetTypes()[i].FullName);
                Type type = typeof(IEffect);//core.GetType("MiKeyboard.Main");
                foreach (var t in types)
                    if (type.IsAssignableFrom((Type)t))
                    {
                        effectInfo = t;
                        break;
                    }

                if (effectInfo != null)
                {
                    object o = Activator.CreateInstance(effectInfo);
                    IEffect effect = (IEffect)o;
                    effects.Add(effect);
                    effect.OnLoad();
                }
            }
            catch (Exception)
            {
            }
        }

        private IEnumerable<Type> GetTypesWithSpecificAttribute<T>(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(typeof(T), true).Length > 0)
                {
                    yield return type;
                }
            }
        }

        internal void UpdateKeyboard(EventArgs args)
        {
            if (effects.Count > selectedEffect)
            {
                effects[selectedEffect].LightingUpdate(ref main.keyboardController.keyboard, args);
            }
        }
    }
}
