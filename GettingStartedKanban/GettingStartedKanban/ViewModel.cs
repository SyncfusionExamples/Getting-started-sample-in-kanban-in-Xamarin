using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GettingStartedKanban
{
    public class ViewModel
    {
        public ObservableCollection<KanbanModel> Cards { get; set; }
        public ViewModel()
        {
            Cards = new ObservableCollection<KanbanModel>();
            Cards.Add(new KanbanModel()
            {
                ID = 1,
                Title = "iOS - 1002",
                ImageURL = "People_Circle1.png",
                Category = "Open",
                Description = "Analyze customer requirements",
                ColorKey = "Red",
                Tags = new string[] { "Incident", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 6,
                Title = "Xamarin - 4576",
                ImageURL = "People_Circle2.png",
                Category = "Open",
                Description = "Show the retrieved data from the server in grid control",
                ColorKey = "Green",
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 13,
                Title = "UWP - 13",
                ImageURL = "People_Circle3.png",
                Category = "In Progress",
                Description = "Add responsive support to application",
                ColorKey = "Brown",
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 2543,
                Title = "Xamarin_iOS - 2543",
                Category = "Code Review",
                ImageURL = "People_Circle4.png",
                Description = "Check login page validation",
                ColorKey = "Brown",
                Tags = new string[] { "Story", "Customer" }
            });
        }
    }

}
