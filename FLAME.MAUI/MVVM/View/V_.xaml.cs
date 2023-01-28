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

    public static readonly BindableProperty FooterLeftProperty = BindableProperty.Create(
       propertyName: nameof(FooterLeft),
       returnType: typeof(bool),
       declaringType: typeof(V_),
       defaultValue: false
       );

    public bool FooterLeft
    {
        get => (bool)GetValue(FooterLeftProperty);
        set => SetValue(FooterLeftProperty, value);
    }

    public static readonly BindableProperty FooterRightProperty = BindableProperty.Create(
       propertyName: nameof(FooterRight),
       returnType: typeof(bool),
       declaringType: typeof(V_),
       defaultValue: false
       );

    public bool FooterRight
    {
        get => (bool)GetValue(FooterRightProperty);
        set => SetValue(FooterRightProperty, value);
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