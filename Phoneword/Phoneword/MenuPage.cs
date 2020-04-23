using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Phoneword
{
    public class MenuPage : ContentPage
    {

        Button biblicalQ;
        Button phoneT;

        public MenuPage()
        {
            this.Padding = new Thickness(20, 20, 20, 20);

            
            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label
            {
                Text = "Cardanont Phone App",
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.Center
            });

            panel.Children.Add(biblicalQ = new Button
            {
                Text = "Biblical questions"
            });

            panel.Children.Add(phoneT = new Button
            {
                Text = "Phone translator"
            });

            panel.Children.Add(new Button
            {
                Text = "SOmething",
                BackgroundColor = Color.FromHex("#111111"),
                TextColor = Color.FromHex("#000000")
            });

            this.BackgroundColor = Color.FromHex("#025951");

            //biblicalQ.Clicked += new NavigationPage(new );
            //phoneT.Clicked += GoToMain;
        }

        //public void GoToMain(object sender, EventArgs e)
        //{
        //    Application.Current.MainPage = new NavigationPage(new MainPage());
        //}
    }
}
