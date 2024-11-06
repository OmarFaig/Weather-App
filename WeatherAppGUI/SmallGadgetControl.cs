﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace WeatherAppGUI
{
    public class SmallGadgetControl : TemplatedControl
    {
        public static readonly StyledProperty<string> LabelProperty =
            AvaloniaProperty.Register<SmallGadgetControl, string>(nameof(Label));

        public static readonly StyledProperty<string> ValueProperty =
            AvaloniaProperty.Register<SmallGadgetControl, string>(nameof(Value));

        public string Label
        {
            get => GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public string Value
        {
            get => GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
