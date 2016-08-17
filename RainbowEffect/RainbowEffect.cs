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
    public class RainbowEffect : IEffect
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

        public string[] Tabs
        {
            get
            {
                return new string[] { "General" };
            }
        }

        public Item[] Items
        {
            get
            {
                return new Item[] { new Item(ItemType.ToggleButton, "Moving", 0, 8, 8, new EventHandler(FastToggleClick)) };
            }
        }

        private void FastToggleClick(object sender, EventArgs e)
        {
            speed = (sender as MetroToggle).Checked ? 1 : 0;
        }

        public bool OnLoad()
        {
            return true;
        }

        public bool OnUnload()
        {
            return true;
        }

        float position = 0;
        float speed = 0;

        public void LightingUpdate(ref CorsairKeyboard keyboard, EventArgs args)
        {
            position += speed;
            float start = position % 360f;
            float end = (position - 1) % 360f;
            keyboard.Brush = new LinearGradientBrush(new RainbowGradient(start, end));
        }
    }
}
