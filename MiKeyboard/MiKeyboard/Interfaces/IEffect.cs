using System;

namespace MiKeyboard.Classes
{
    internal interface IEffect
    {
        String Name { get; }
        String Description { get; }
        String Version { get; }
        String Author { get; }

        Boolean OnLoad();
        Boolean OnUnload();

        void LightingUpdate();
    }
}
