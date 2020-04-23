using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Phoneword
{
    public class MenuPage : ContentPage
    {

        Button biblicalQButton;
        Button phoneTButton;

        string translatedNumber;


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

            panel.Children.Add(biblicalQButton = new Button
            {
                Text = "Biblical questions"
            });

            panel.Children.Add(phoneTButton = new Button
            {
                Text = "Phone translator"
            });

            panel.Children.Add(new Button
            {
                Text = "SOmething",
                BackgroundColor = Color.FromHex("#111111"),
                TextColor = Color.FromHex("#000000")
            });

            //biblicalQButton.Clicked += Ontranslate;
            phoneTButton.Clicked += GoToMain;
            this.BackgroundColor = Color.FromHex("#025951");
            this.Content = panel;
        }
        public void GoToMain(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
