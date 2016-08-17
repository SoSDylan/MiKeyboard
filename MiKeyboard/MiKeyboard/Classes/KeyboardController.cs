using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUE.NET;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Generic.Enums;
using CUE.NET.Devices.Generic.EventArgs;
using CUE.NET.Exceptions;
using CUE.NET.Brushes;
using System.Drawing;

namespace MiKeyboard.Classes
{
    internal class KeyboardController
    {
        internal Main main;

        internal CorsairKeyboard keyboard;

        internal KeyboardController(Main main)
        {
            this.main = main;

            if (!CueSDK.IsInitialized)
                CueSDK.Initialize();
            else
                CueSDK.Reinitialize();
            keyboard = CueSDK.KeyboardSDK;

            if (keyboard == null)
                throw new WrapperException("No keyboard found...");

            keyboard.Updating += (sender, args) => UpdateKeyboard(args);
        }

        internal void Setup()
        {
            keyboard.UpdateMode = UpdateMode.Continuous;
            keyboard.UpdateFrequency = 1f / main.effectController.effects[main.effectController.selectedEffect].UpdatesPerSecond;
            keyboard.Brush = new SolidColorBrush(Color.Black);
        }

        private void UpdateKeyboard(EventArgs args)
        {
            main.effectController.UpdateKeyboard(args);
            //keyboard.Update();
        }
    }
}
