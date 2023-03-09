using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using TelerikExpander.Models;

namespace TelerikExpander.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<Person> Person1Collection { get; set; }

    public ObservableCollection<Person> Person2Collection { get; set; }

    public ObservableCollection<Person> Person3Collection { get; set; }

    public ObservableCollection<Person> Person4Collection { get; set; }

    public ObservableCollection<Person> Person5Collection { get; set; }

    [ObservableProperty] int person1Count;
    [ObservableProperty] int person2Count;
    [ObservableProperty] int person3Count;
    [ObservableProperty] int person4Count;
    [ObservableProperty] int person5Count;

    public MainPageViewModel() 
    {
        Person1Collection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };

        Person2Collection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };

        Person3Collection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };

        Person4Collection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };

        Person5Collection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };
    }
}
