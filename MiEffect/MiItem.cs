using System;

namespace MiKeyboard
{
    public class MiItem
    {
        public MiItem(ItemType type, string text, int tabIndex, bool selected, string[] items, int left, int top, int width, int height, EventHandler evnt)
        {
            Type = type;
            Text = text;
            TabIndex = tabIndex;
            Selected = selected;
            Items = items;
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            Event = evnt;
        }

        public MiItem(ItemType type, string text, int tabIndex, bool selected, int left, int top, EventHandler evnt)
        {
            Type = type;
            Text = text;
            TabIndex = tabIndex;
            Selected = selected;
            Left = left;
            Top = top;
            Event = evnt;
        }

        public MiItem(ItemType type, string text, int tabIndex, int left, int top, EventHandler evnt)
        {
            Type = type;
            Text = text;
            TabIndex = tabIndex;
            Left = left;
            Top = top;
            Event = evnt;
        }

        public ItemType Type
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public int TabIndex
        {
            get;
            private set;
        }

        public bool Selected
        {
            get;
            private set;
        }

        public string[] Items
        {
            get;
            private set;
        }

        public int Left
        {
            get;
            private set;
        }

        public int Top
        {
            get;
            private set;
        }

        public int Width
        {
            get;
            private set;
        }

        public int Height
        {
            get;
            private set;
        }

        public EventHandler Event
        {
            get;
            private set;
        }
    }

    public enum ItemType
    {
        Button,
        TextBox,
        ComboBox,
        Label,
        RadioButton,
        ToggleButton,
    }
}
