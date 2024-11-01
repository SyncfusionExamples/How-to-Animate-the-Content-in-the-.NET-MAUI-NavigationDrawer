namespace SfNavigationDrawerSample;

public partial class ToDoList : ContentPage
{
	public ToDoList()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Slide in from the right
        this.TranslationX = this.Width;
        this.TranslateTo(0, 0, 500, Easing.CubicOut);  // Slide in over 500ms
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // Slide out to the left
        this.TranslateTo(-this.Width, 0, 500, Easing.CubicIn);  // Slide out over 500ms
    }
}