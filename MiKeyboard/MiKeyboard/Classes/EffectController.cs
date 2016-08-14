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
                effectInfo = types[0];

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

        internal void UpdateKeyboard()
        {
            if (effects.Count > selectedEffect)
            {
                effects[selectedEffect].LightingUpdate(ref main.keyboardController.keyboard);
            }
        }
    }
}
