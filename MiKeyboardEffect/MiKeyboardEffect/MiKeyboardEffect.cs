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
using System.Windows.Forms;

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

        public string BundleId
        {
            get
            {
                return "com.test.mikeyboardeffect";
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
                return new string[] { "General", "Advanced" };
            }
        }

        public Item[] Items
        {
            get
            {
                return new Item[] { new Item(ItemType.Button, "Click Me", 0, 8, 8, new EventHandler(ButtonClick)), new Item(ItemType.ToggleButton, "Fast", 1, 8, 8, new EventHandler(FastToggleClick)) };
            }
        }

        private void FastToggleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Fast toggle was turned " + (sender as CheckBox).Checked, "MiKeyboard", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("The button was clicked", "MiKeyboard", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public bool OnLoad()
        {
            return true;
        }

        public bool OnUnload()
        {
            return true;
        }

        public void LightingUpdate(ref CorsairKeyboard keyboard, EventArgs args)
        {
            keyboard['A'].Led.Color = Color.Red;
            keyboard[CorsairKeyboardKeyId.B].Led.Color = Color.Green;
        }
    }
}
