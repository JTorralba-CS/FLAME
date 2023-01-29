using System.Windows.Input;

namespace FLAME.MAUI.MVVM.View;

public partial class V_ : ContentPage
{
    public V_()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(
        propertyName: nameof(HeaderText),
        returnType: typeof(string),
        declaringType: typeof(V_),
        defaultValue: ""
        );

    public string HeaderText
    {
        get => (string)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }

    public static readonly BindableProperty FooterTextProperty = BindableProperty.Create(
       propertyName: nameof(FooterText),
       returnType: typeof(string),
       declaringType: typeof(V_),
       defaultValue: ""
       );

    public string FooterText
    {
        get => (string)GetValue(FooterTextProperty);
        set => SetValue(FooterTextProperty, value);
    }

    public static readonly BindableProperty FooterPrevProperty = BindableProperty.Create(
       propertyName: nameof(FooterPrev),
       returnType: typeof(bool),
       declaringType: typeof(V_),
       defaultValue: false
       );

    public bool FooterPrev
    {
        get => (bool)GetValue(FooterPrevProperty);
        set => SetValue(FooterPrevProperty, value);
    }

    public static readonly BindableProperty FooterNextProperty = BindableProperty.Create(
       propertyName: nameof(FooterNext),
       returnType: typeof(bool),
       declaringType: typeof(V_),
       defaultValue: false
       );

    public bool FooterNext
    {
        get => (bool)GetValue(FooterNextProperty);
        set => SetValue(FooterNextProperty, value);
    }

    public static readonly BindableProperty OnClickCommandProperty = BindableProperty.Create(
        propertyName: nameof(OnClickCommand),
        returnType: typeof(ICommand),
        defaultBindingMode: BindingMode.TwoWay,
        declaringType: typeof(V_),
        defaultValue: null);

    public ICommand OnClickCommand
    {
        get => (Command)base.GetValue(OnClickCommandProperty);
        set => base.SetValue(OnClickCommandProperty, value);
    }
}