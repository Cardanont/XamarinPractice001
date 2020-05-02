using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Phoneword
{
    class BiblicalQuestionsPage : ContentPage
    {

        Button ansButton0;
        Button ansButton1;
        Button ansButton2;
        Button ansButton3;
        Button ansButton4;

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

            panel.Children.Add(ansButton0 = new Button
            {
                Text = "2",
                BackgroundColor = Color.FromHex("#8C644D"),
            });

            panel.Children.Add(ansButton1 = new Button
            {
                Text = "12",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ansButton2 = new Button
            {
                Text = "5",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ansButton3 = new Button
            {
                Text = "7",
                BackgroundColor = Color.FromHex("#8C644D")
            });

            panel.Children.Add(ansButton4 = new Button
            {
                Text = "10",
                BackgroundColor = Color.FromHex("#8C644D")
            });


            ansButton0.Clicked += Answer;
            ansButton1.Clicked += Answer;
            ansButton2.Clicked += Answer;
            ansButton3.Clicked += Answer;
            ansButton4.Clicked += Answer;
            this.BackgroundColor = Color.FromHex("#40281A");
            this.Content = panel;
        }

        async void Answer(object sender, EventArgs e)
        {
            if (ansButton0.Text == "10")
            {
                await this.DisplayAlert(
                    "Answer for question 1: ",
                    "That's correct!",
                    "Ok");
            }
            else
            {
                await this.DisplayAlert(
                    "Answer for question 1: ",
                    "That's incorrect try again.",
                    "Ok");
            }
        }
    }
}
