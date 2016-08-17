using CUE.NET.Devices.Keyboard;
using System;

namespace MiKeyboard
{
    public interface IEffect
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        string BundleId { get; }
        long Build { get; }

        string[] Tabs { get; }
        Item[] Items { get; }

        bool OnLoad();
        bool OnUnload();

        void LightingUpdate(ref CorsairKeyboard keyboard, EventArgs args);
    }
}
