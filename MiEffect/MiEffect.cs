using CUE.NET.Devices.Keyboard;
using System;

namespace MiKeyboard
{
    public interface MiEffect
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        string BundleId { get; }
        long Build { get; }
        int UpdatesPerSecond { get; }

        string[] Tabs { get; }
        MiItem[] Items { get; }

        bool OnLoad();
        bool OnUnload();

        void LightingUpdate(CorsairKeyboard keyboard, EventArgs args);
    }
}
