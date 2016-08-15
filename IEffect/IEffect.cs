using CUE.NET.Devices.Keyboard;
using System;

namespace MiKeyboard
{
    public interface IEffect
    {
        String Name { get; }
        String Description { get; }
        String Author { get; }
        String Version { get; }
        String BundleId { get; }
        long Build { get; }

        Boolean OnLoad();
        Boolean OnUnload();

        void LightingUpdate(ref CorsairKeyboard keyboard);
    }
}
