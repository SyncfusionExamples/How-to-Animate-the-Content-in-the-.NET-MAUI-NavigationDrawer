using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SfNavigationDrawerSample;

public class ViewModel : INotifyPropertyChanged
{
    
    public ObservableCollection<Model> List
    {
        get
        {
            return this.list;
        }
        set
        {          
                this.list = value;
                NotifyPropertyChanged();           
        }
    }
    private ObservableCollection<Model> list;
    
    public ViewModel()
	{
        List = new ObservableCollection<Model>();
        List.Add(new Model { ProfileName="M",Name= "Microsoft",Image= "bluecircle.png",Subject = "Dev Essentials: Learn about the future of .NET and celebrate Visual Studio's 25th anniversary", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "MV", Name = "Microsoft Viva", Image = "greencircle.png", Subject = "Your daily briefing", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "MV", Name = "Microsoft Viva", Image = "lightbluecircle.png", Subject = "Your digest email", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "T", Name = "Twitter", Image = "redcircle.png", Subject = "Be more recognizable", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "L", Name = "LinkedIn", Image = "violetcircle.png", Subject = "You have two new messages", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "SO", Name = "Stack Overflow", Image = "bluecircle.png", Subject = "Your friendly, fear-free guide to getting started", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "MO", Name = "Microsoft Outlook", Image = "greencircle.png", Subject = "Get to know what's new in Outlook", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "BT", Name = "Blog Team Site", Image = "redcircle.png", Subject = "Dev Essentials: Learn about the future of .NET and celebrate Visual Studio's 25th anniversary", Description = "Developer news, updates, and training resources." });
        List.Add(new Model { ProfileName = "M", Name = "Microsoft", Image = "lightbluecircle.png", Subject = "Dev Essentials: Learn about the future of .NET and celebrate Visual Studio's 25th anniversary", Description = "Developer news, updates, and training resources." });
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    
    private void NotifyPropertyChanged([CallerMemberName] string propertyName ="")
    {
        if(PropertyChanged != null)
        {
            PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Model
    {
        #region Fields

        private string? profileName;
        private string? name;
        private string? subject;
        private string? description;
        private DateTime date;
        private string? image;
        private bool isAttached;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Name and notifies user when collection value gets changed.
        /// </summary>
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Gets or sets the ProfileName and notifies user when collection value gets changed.
        /// </summary>
        public string? ProfileName
        {
            get { return profileName; }
            set
            {
                profileName = value;
                OnPropertyChanged("ProfileName");
            }
        }

        /// <summary>
        /// Gets or sets the Subject and notifies user when collection value gets changed.
        /// </summary>
        public string? Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
                OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Gets or sets the Description and notifies user when collection value gets changed.
        /// </summary>
        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets or sets the Date and notifies user when collection value gets changed.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Gets or sets the Image and notifies user when collection value gets changed.
        /// </summary>
        public string? Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }



        #endregion

        #region Interface Member

        /// <summary>
        /// Represents the method that will handle the <see cref="System.ComponentModel.INotifyPropertyChanged.PropertyChanged"></see> event raised when a property is changed on a component
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Triggers when Items Collections Changed.
        /// </summary>
        /// <param name="name">string type parameter represent propertyName as name</param>
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }

}