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
        KeyboardController keyboard;
        PluginController plugins;

        public Main()
        {
            InitializeComponent();

            keyboard = new KeyboardController(this);
            plugins = new PluginController(this);
        }
    }
}
