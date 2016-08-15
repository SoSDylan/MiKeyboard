using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiKeyboard.Classes;
using MetroFramework.Forms;

namespace MiKeyboard
{
    public partial class Main : MetroForm
    {
        internal KeyboardController keyboardController;
        internal EffectController effectController;

        internal Main()
        {
            InitializeComponent();

            keyboardController = new KeyboardController(this);
            effectController = new EffectController(this);

            keyboardController.Setup();
            effectController.Setup();

            UpdateScreen();
        }

        private void UpdateScreen()
        {
            effectController.effects.ForEach(t => cb_effects.Items.Add(t.Name));

            if (Properties.Settings.Default.selectedEffectId != null)
            {
                for (int i = 0; i < effectController.effects.Count; i++)
                    if (effectController.effects[i].BundleId == Properties.Settings.Default.selectedEffectId)
                    {
                        cb_effects.SelectedIndex = i;
                    }
                    else
                    {
                        if (cb_effects.Items.Count > 0)
                            cb_effects.SelectedIndex = 0;
                    }
            }
            else
            {
                if (cb_effects.Items.Count > 0)
                    cb_effects.SelectedIndex = 0;
            }

            int top = 50;
            int left = 100;
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                this.Controls.Add(button);
                top += button.Height + 2;
                Console.WriteLine("Created button");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cb_effects_SelectedIndexChanged(object sender, EventArgs e)
        {
            effectController.selectedEffect = cb_effects.SelectedIndex;

            Properties.Settings.Default.selectedEffectId = effectController.effects[cb_effects.SelectedIndex].BundleId;
            Properties.Settings.Default.Save();
            Console.WriteLine(effectController.effects[cb_effects.SelectedIndex].BundleId);
            
            keyboardController = new KeyboardController(this);
            keyboardController.Setup();
        }
    }
}
