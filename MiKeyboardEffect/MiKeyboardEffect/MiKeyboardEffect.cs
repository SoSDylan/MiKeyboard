using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiKeyboard;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Keyboard.Enums;
using System.Drawing;
using System.IO;

namespace MiKeyboardEffect
{
    public class MiKeyboardEffect : IEffect
    {
        public string Name
        {
            get
            {
                return "MiKeyboardEffect";
            }
        }

        public string Description
        {
            get
            {
                return "Description...";
            }
        }

        public string Author
        {
            get
            {
                return "Author";
            }
        }

        public string Version
        {
            get
            {
                return "v1.0";
            }
        }

        public long Build
        {
            get
            {
                return 1;
            }
        }

        public bool OnLoad()
        {
            return true;
        }

        public bool OnUnload()
        {
            return true;
        }

        public void LightingUpdate(ref CorsairKeyboard keyboard)
        {
            keyboard['A'].Led.Color = Color.Red;
            keyboard[CorsairKeyboardKeyId.B].Led.Color = Color.Green;
        }
    }
}
