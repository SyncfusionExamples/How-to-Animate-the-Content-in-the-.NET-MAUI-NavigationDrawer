This article guides you on how to animate the content when switching between pages in the [.NET MAUI NavigationDrawer](https://www.syncfusion.com/maui-controls/maui-navigationdrawer). 

By using built-in MAUI animation methods such as [FadeTo](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/animation/basic?view=net-maui-8.0#fading), [TranslateTo](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/animation/basic?view=net-maui-8.0#fading), and [ScaleTo](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/animation/basic?view=net-maui-8.0#fading), you can create smooth transitions for content when navigating between different pages.

Here’s a code snippet showcasing how to implement slide animation with the `TranslateTo` method for the navigation drawer content:

**XAML**

```
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <!-- DrawerSettings Configuration -->
        <navigationdrawer:DrawerSettings >
            <!-- Drawer Header View -->
            <!-- ... -->
            <!-- Drawer Content View -->
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <!-- ScrollView with VerticalStackLayout for menu items -->
                <ScrollView>
                    <VerticalStackLayout Spacing="10" Padding="5,0">
                        <Border StrokeThickness="0" x:Name="inboxEffectsBorder">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="30"/>
                            </Border.StrokeShape>
                            <core:SfEffectsView x:Name="inboxEffects" RippleBackground="#ab56e3">
                                <core:SfEffectsView.GestureRecognizers>
                                    <TapGestureRecognizer 
                                    Tapped="OnInboxTapGestureRecognizerTapped"/>
                                </core:SfEffectsView.GestureRecognizers>
                                <Grid Padding="20,5,10,5" HeightRequest="48">
                                    <!-- ... -->
                                </Grid>
                            </core:SfEffectsView>
                        </Border>
                        <!-- ... -->                        
                    </VerticalStackLayout>
                </ScrollView>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>
```

**C#**

```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Initialize();           
    }  

    private async void AnimateContentChange(View newContent)
    {
        // Slide out current content to the left
        if (navigationDrawer.ContentView != null)
        {
            // Slide out over 250ms
            await navigationDrawer.ContentView.TranslateTo(-this.Width, 0, 250);  
        }
    
        // Set the new content
        navigationDrawer.ContentView = newContent;
    
        // Slide in the new content from the right
        navigationDrawer.ContentView.TranslationX = this.Width;
        
        // Slide in over 250ms
        await navigationDrawer.ContentView.TranslateTo(0, 0, 250);  
    }
    
    private void Initialize()
    {
        AnimateContentChange(new Inbox().Content);
        // Additional initialization logic
    }

    private void OnInboxTapGestureRecognizerTapped(object? sender, TappedEventArgs e)
    {
        AnimateContentChange(new Inbox().Content);
    }

    // Additional tap handlers for other menu items
}
```

- **Slide Out Current Content:** The existing content slides out to the left using the TranslateTo method.
- **Set New Content:** The ContentView of the navigationDrawer is updated with the new page content.
- **Slide In New Content:** The new content slides in from the right using the TranslateTo method.

This approach provides a visually appealing transition between pages.

To learn more about .NET MAUI Animations, please refer to the below blog:
[Learn Performing Animation in .NET MAUI](https://www.syncfusion.com/blogs/post/learn-performing-animation-in-net-maui-part-1) 

**Output**

![Animation_Demo.gif](https://support.syncfusion.com/kb/agent/attachment/article/17401/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI5Mzc0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.t0i-ekQTUJ7ofU8NQo_r-3y2Bnf3hX7X_IKkKZdm-uI)

**Requirements to run the demo**
 
To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)
 
**Troubleshooting:**

**Path too long exception** 

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.