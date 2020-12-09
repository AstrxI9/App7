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

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        async void OnQRButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage { });
        }

        async void OnConditionButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConditionForm { });
        }

        async void OnComplianceButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComplianceForm { });
        }

        async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var text = button.Text;
            Console.WriteLine(text);
            if (text == "Help")
            {
                await Navigation.PushAsync(new HelpPage { });
            } else if (text == "About")
            {
                await Navigation.PushAsync(new AboutPage { });
            }
        }
    }

    public class Menu
    {
        public string Name { get; set; }

        public string Icon { get; set; }
    }
}
