﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUE.NET;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Generic.Enums;
using CUE.NET.Devices.Generic.EventArgs;
using CUE.NET.Exceptions;

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
            keyboard = CueSDK.KeyboardSDK;

            if (keyboard == null)
                throw new WrapperException("No keyboard found...");

            keyboard.Updating += (sender, args) => UpdateKeyboard();
        }

        internal void Setup()
        {
            keyboard.UpdateMode = UpdateMode.Continuous;
        }

        private void UpdateKeyboard()
        {
            main.effectController.UpdateKeyboard();
            //keyboard.Update();
        }
    }
}
