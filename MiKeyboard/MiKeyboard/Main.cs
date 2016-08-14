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

namespace MiKeyboard
{
    public partial class Main : Form
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
            cb_effects.SelectedIndex = 0;
        }

        private void cb_effects_SelectedIndexChanged(object sender, EventArgs e)
        {
            effectController.selectedEffect = cb_effects.SelectedIndex;
        }
    }
}
