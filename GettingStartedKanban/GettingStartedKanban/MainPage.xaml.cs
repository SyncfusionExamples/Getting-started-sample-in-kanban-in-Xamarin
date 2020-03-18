using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStartedKanban
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            openColumn.Categories = new List<object>() { "Open" };
            progressColumn.Categories = new List<object>() { "In Progress" };
            codeColumn.Categories = new List<object>() { "Code Review" };
            doneColumn.Categories = new List<object>() { "Done" };
        }
    }
}
