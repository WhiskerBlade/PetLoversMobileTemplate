namespace PetLovers.Templates.UI;

public partial class RoundImage : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(RoundImage), default(ImageSource));

    public ImageSource ImageSource
    {
        get => (ImageSource)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }
    public RoundImage()
    {
        InitializeComponent();
        ImageSet.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSource), source: this));
    }
}