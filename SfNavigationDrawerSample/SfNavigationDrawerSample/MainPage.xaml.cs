using System.Collections.ObjectModel;
using SfNavigationDrawerSample;
using Syncfusion.Maui.ListView;


namespace SfNavigationDrawerSample
{
    public partial class MainPage : ContentPage
    {
        private Inbox inbox;
        private Remainders remainders;
        private ToDoList toDoList;
        private Contacts contacts;
        
        public MainPage()
        {
            InitializeComponent();
            inbox = new Inbox();
            remainders = new Remainders();
            contacts = new Contacts();
            toDoList = new ToDoList();
            Initialize();           
        }
        private void OnHandleClicked(object sender, TappedEventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private async void AnimateContentChange(View newContent)
        {
            // Slide out current content to the left
            if (navigationDrawer.ContentView != null)
            {
                await navigationDrawer.ContentView.TranslateTo(-this.Width, 0, 250);  // Slide out over 250ms
            }

            // Set the new content
            navigationDrawer.ContentView = newContent;

            // Slide in the new content from the right
            navigationDrawer.ContentView.TranslationX = this.Width;
            await navigationDrawer.ContentView.TranslateTo(0, 0, 250);  // Slide in over 250ms
        }


        [Obsolete]
        private void Initialize()
        {
            AnimateContentChange(inbox.Content);
            headerLabel.Text = "Inbox";
            inboxEffectsBorder.Background = Color.FromHex("#f2daf7");
            inboxTitle.FontAttributes = FontAttributes.Bold;
        }

        private void ResetSelection()
        {
            inboxEffectsBorder.Background = Colors.Transparent;
            inboxTitle.FontAttributes = FontAttributes.None;
            contactsEffectsBorder.Background = Colors.Transparent;
            contactsTitle.FontAttributes = FontAttributes.None;
            remaindersEffectsBorder.Background = Colors.Transparent;
            remaindersTitle.FontAttributes = FontAttributes.None;
            toDoListEffectsBorder.Background = Colors.Transparent;
            toDolistTitle.FontAttributes = FontAttributes.None;
        }

        [Obsolete]
        private void OnInboxTapGestureRecognizerTapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();
            inboxEffectsBorder.Background = Color.FromHex("#f2daf7");
            inboxTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Inbox";     
            AnimateContentChange(inbox.Content);
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void OnContactsTapGestureRecognizerTapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();           
            contactsEffectsBorder.Background = Color.FromHex("#f2daf7");
            contactsTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Contacts";          
            AnimateContentChange(contacts.Content);
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void OnRemaindersTapGestureRecognizerTapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();
            remaindersEffectsBorder.Background = Color.FromHex("#f2daf7");
            remaindersTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Remainders";
            AnimateContentChange(remainders.Content);
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void OnToDoListTapGestureRecognizerTapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();           
            toDoListEffectsBorder.Background = Color.FromHex("#f2daf7");
            toDolistTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "ToDoList";
            AnimateContentChange(toDoList.Content);
            this.navigationDrawer!.ToggleDrawer();
        }
    }

}
