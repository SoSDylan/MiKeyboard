using MiKeyboard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Keyboard.Enums;
using CUE.NET.Brushes;
using CUE.NET.Gradients;
using MetroFramework.Controls;

namespace RainbowEffect
{
    public class RainbowEffect : MiEffect
    {
        public string Name
        {
            get
            {
                return "Rainbow Effect";
            }
        }

        public string Description
        {
            get
            {
                return "A rainbow effect";
            }
        }

        public string Author
        {
            get
            {
                return "SoSDylan";
            }
        }

        public string Version
        {
            get
            {
                return "v1.0";
            }
        }

        public string BundleId
        {
            get
            {
                return "me.sosdylan.rainboweffect";
            }
        }

        public long Build
        {
            get
            {
                return 1;
            }
        }

        public int UpdatesPerSecond
        {
            get
            {
                return 15;
            }
        }

        public string[] Tabs
        {
            get
            {
                return new string[] { "General" };
            }
        }

        public MiItem[] Items
        {
            get
            {
                return new MiItem[] { new MiItem(ItemType.ToggleButton, "Moving", 0, 8, 8, new EventHandler(FastToggleClick)) };
            }
        }

        private void FastToggleClick(object sender, EventArgs e)
        {
        }

        public bool OnLoad()
        {
            return true;
        }

        public bool OnUnload()
        {
            return true;
        }

        public void LightingUpdate(CorsairKeyboard keyboard, EventArgs args)
        {
            keyboard.Brush = new LinearGradientBrush(new RainbowGradient(0, 360));
        }
    }
}
