using MiKeyboard;
using System;
using System.Drawing;
using CUE.NET.Brushes;
using CUE.NET.Devices.Keyboard;

namespace DesktopEffect
{
    public class DesktopEffect : MiEffect
    {
        public string Name
        {
            get
            {
                return "Desktop Effect";
            }
        }

        public string Description
        {
            get
            {
                return "A desktop effect";
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
                return "me.sosdylan.desktopeffect";
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
                return 60;
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
            keyboard.Brush = new SolidColorBrush(Color.White);
        }
    }
}
