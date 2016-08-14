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
        KeyboardController keyboardController;
        EffectController effectConstoller;

        public Main()
        {
            InitializeComponent();

            keyboardController = new KeyboardController(this);
            effectConstoller = new EffectController(this);

            UpdateScreen();
        }

        private void UpdateScreen()
        {
            effectConstoller.effects.ForEach(t => cb_effects.Items.Add(t.Name));
        }
    }
}
