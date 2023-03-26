namespace OfficeControlGallery.Pages;

public partial class ContentPresenterPage : ContentPage
{
    public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(ContentPresenterPage), string.Empty);

    public string HeaderText
    {
        get => (string)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }
    public ContentPresenterPage()
	{
		InitializeComponent();
	}

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        var headerLabel =(Label)GetTemplateChild("headerLabel");
        headerLabel.Text = "MyApp";
        var themeLabel = (Label)GetTemplateChild("changeThemeLabel");
        themeLabel.Text = "Aqua Theme";
    }
}