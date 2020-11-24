using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace karusel
{
    public partial class MainPage : CarouselPage
    {

        public MainPage()
        {
            ImageButton btn1;
            ImageButton btn2;
            ImageButton btn3;
            ImageButton btn4;
            btn1 = new ImageButton
            {
                Source = "holerik.jpg"
            };
            btn1.Clicked += Btn1_Clicked;
            var redContentPage = new ContentPage
            {

                Content = new StackLayout
                {

                    BackgroundColor = Color.SkyBlue,
                    Children =
                    {
                        new Label
                        {
                        Text = "Holerik",
                         TextColor = Color.Yellow,
                            BackgroundColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        

                        new Label
                        {
                        Text = "Темпераментный, неуравновешенный человек, легко возбуждающийся под действием каких-н. впечатлений.",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        },
                        btn1


                    }
                }
            };
            btn2 = new ImageButton
            {
                Source = "sangvinik.jpg"
            };
            btn2.Clicked += Btn2_Clicked;
            var blueContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Yellow,
                    Children =
                    {
                        new Label
                        {
                        Text = "Sangvinik",
                        TextColor = Color.Yellow,
                            BackgroundColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                       
                        new Label
                        {
                        Text = "Сангвиник — это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи.",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        },
                        btn2

                    }
                }
            };
            btn3 = new ImageButton
            {
                Source = "flegmatik.jpg"
            };
            btn3.Clicked += Btn3_Clicked;
            var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.SeaGreen,
                    Children =
                    {
                        new Label
                        {
                        Text = "Flegmatik",
                         TextColor = Color.Yellow,
                            BackgroundColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        
                         new Label
                        {
                        Text = "У флегматика преобладает спокойное, ровное настроение; его чувства и эмоции обычно отличаются постоянством.",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        },
                         btn3

                    }
                }
            };
            btn4 = new ImageButton
            {
                Source = "melanholik.jpg"
            };
            btn4.Clicked += Btn4_Clicked;
            var yellowContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.RoyalBlue,
                    Children =
                    {
                        new Label
                        {
                        Text = "Melanholik",
                         TextColor = Color.Yellow,
                            BackgroundColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        
                         new Label
                        {
                        Text = "Человек, страдающий меланхолией, склонный к грусти, к мрачным мыслям...",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),

                        },
                         btn4

                    }

                }
            };
            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
            Children.Add(yellowContentPage);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
