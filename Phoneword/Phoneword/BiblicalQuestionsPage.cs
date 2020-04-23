using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Phoneword
{
    class BiblicalQuestionsPage : ContentPage
    {

        Button ans1Button;
        Button ans2Button;
        Button ans3Button;
        Button ans4Button;
        Button ans5Button;


        public BiblicalQuestionsPage()
        {
            this.Padding = new Thickness(20, 20, 20, 20);

            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label
            {
                Text = "Question No 1",
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.Center
            });

            panel.Children.Add(new Label
            {
                Text = "How many commandments did God give to Israel?",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.Center
            });

            panel.Children.Add(ans1Button = new Button
            {
                Text = "2",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ans2Button = new Button
            {
                Text = "12",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ans3Button = new Button
            {
                Text = "5",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ans4Button = new Button
            {
                Text = "10",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ans5Button = new Button
            {
                Text = "7",
                BackgroundColor = Color.FromHex("#8C644D")
            });



            this.BackgroundColor = Color.FromHex("#40281A");
            this.Content = panel;
        }
    }
}
