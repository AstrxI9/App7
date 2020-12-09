using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMenu = GetMenus();
            this.BindingContext = this;
        }

        public List<Menu> MyMenu { get; set; }

        private List<Menu> GetMenus()
        {
            return new List<Menu>
            {
                new Menu{Name = "Home", Icon= "logoengie.png"},
                new Menu{Name = "Help", Icon= "logoengie.png"},
                new Menu{Name = "About", Icon= "logoengie.png"},
            };
        }


        private void OpenSwipe(object sender, EventArgs e)
        {
        }

        private void CloseSwipe(object sender, EventArgs e)
        {
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Button Clicked";
        }
    }

    public class Menu
    {
        public string Name { get; set; }

        public string Icon { get; set; }
    }
}
