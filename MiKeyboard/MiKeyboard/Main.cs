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
using MetroFramework.Controls;
using MetroFramework;
using System.Diagnostics;
using System.IO;

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

            GotFocus += new EventHandler(FormGotFocus);
            cb_effects.SelectedIndexChanged += new EventHandler(cb_effects_SelectedIndexChanged);

            UpdateScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (e.CloseReason != CloseReason.UserClosing) return;

            e.Cancel = true;
            Hide();
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

            SetupEffectInterface();
        }

        private void SetupEffectInterface()
        {
            ResetInterface();

            if (effectController.selectedEffect < 0 || effectController.selectedEffect >= effectController.effects.Count)
                return;

            IEffect selectedEffect = effectController.effects[effectController.selectedEffect];
            for (int i = 0; i < selectedEffect.Tabs.Length; i++)
            {
                panel.TabPages.Add(selectedEffect.Tabs[i]);
            }

            for (int i = 0; i < selectedEffect.Items.Length; i++)
            {
                Item item = selectedEffect.Items[i];
                switch (item.Type)
                {
                    case ItemType.Button:
                        MetroButton button = new MetroButton();
                        button.Left = item.Left;
                        button.Top = item.Top;
                        if (item.Width != 0)
                            button.Width = item.Width;
                        if (item.Height != 0)
                            button.Height = item.Height;
                        button.Text = item.Text;
                        if (item.Event != null)
                            button.Click += item.Event;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(button);
                        break;
                    case ItemType.ComboBox:
                        MetroComboBox comboBox = new MetroComboBox();
                        comboBox.Left = item.Left;
                        comboBox.Top = item.Top;
                        comboBox.Text = item.Text;
                        comboBox.Items.AddRange(item.Items);
                        comboBox.SelectedIndex = 0;
                        if (item.Event != null)
                            comboBox.SelectedIndexChanged += item.Event;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(comboBox);
                        break;
                    case ItemType.Label:
                        MetroLabel label = new MetroLabel();
                        label.Left = item.Left;
                        label.Top = item.Top;
                        label.Text = item.Text;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(label);
                        break;
                    case ItemType.RadioButton:
                        MetroRadioButton radioButton = new MetroRadioButton();
                        radioButton.Left = item.Left;
                        radioButton.Top = item.Top;
                        radioButton.Text = item.Text;
                        radioButton.Checked = item.Selected;
                        if (item.Event != null)
                            radioButton.CheckedChanged += item.Event;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(radioButton);
                        break;
                    case ItemType.TextBox:
                        MetroTextBox textBox = new MetroTextBox();
                        textBox.Left = item.Left;
                        textBox.Top = item.Top;
                        if (item.Width != 0)
                            textBox.Width = item.Width;
                        if (item.Height != 0)
                            textBox.Height = item.Height;
                        textBox.Text = item.Text;
                        if (item.Event != null)
                            textBox.TextChanged += item.Event;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(textBox);
                        break;
                    case ItemType.ToggleButton:
                        MetroToggle toggleButton = new MetroToggle();
                        toggleButton.Left = item.Left;
                        toggleButton.Top = item.Top;
                        toggleButton.Text = item.Text;
                        toggleButton.Checked = item.Selected;
                        if (item.Event != null)
                            toggleButton.CheckedChanged += item.Event;
                        //button.Theme = MetroThemeStyle.Dark;
                        panel.TabPages[item.TabIndex].Controls.Add(toggleButton);
                        break;
                }
            }
        }

        private void ResetInterface()
        {
            for (int i = panel.TabCount - 1; i >= 0; i--)
            {
                panel.TabPages.RemoveAt(i);
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

            SetupEffectInterface();
        }

        private void FormGotFocus(object sender, EventArgs e)
        {
            //effectController.LoadEffectList();
            //UpdateScreen();
        }

        private void csmi_show_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void csmi_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\Effects\\");
        }
    }
}
