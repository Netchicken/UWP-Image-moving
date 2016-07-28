using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Image_moving
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Player[] myPlayer = new Player[2]; //make an array that has two objects, you can have as many objects as you like

        Image Igor;
        private Image Ogor;
        //https://msdn.microsoft.com/en-us/windows/uwp/graphics/transforms-overview
        public MainPage()
        {
            this.InitializeComponent();

            LoadData();
        }
        //Assets/s6vste3a.bmp
        private void LoadData()
        {

            //https://msdn.microsoft.com/library/windows/apps/br242760
            //Image Igor = new Image();
            //Igor.Source =
            //new BitmapImage(new Uri("ms-appx:///Assets/euj4lu2h.bmp", UriKind.Absolute));

            // Image.Source = new BitmapImage(
            //   new Uri("http://yourdomain.com/image.jpg", UriKind.Absolute));

            //Image Ogor = new Image();
            //Ogor.Source =
            //new BitmapImage(new Uri("ms-appx:///Assets/o0qnwxzn.bmp", UriKind.Absolute));

            myPlayer[0] = new Player() { Name = "Igor", Image = Igor, Position = 0, movePlayer = MovePlayer1 };
            myPlayer[1] = new Player() { Name = "Ogor", Image = Ogor, Position = 0, movePlayer = MovePlayer2 };

            //Image img = new Image();
            //   img.Source = new BitmapImage(new Uri("ms-appx:///Assets/euj4lu2h.bmp"));
        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {

                myPlayer[i].movePlayer.X += 4;
            }


        }
        //load the top image using the Load event of the image
        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Igor = sender as Image;
            if (Igor != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                Igor.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/euj4lu2h.bmp");
                Igor.Source = bitmapImage;
            }
        }
        //load the bottom image
        private void LowerImage_Loaded(object sender, RoutedEventArgs e)
        {
            Ogor = sender as Image;
            if (Ogor != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                Ogor.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/o0qnwxzn.bmp");
                Ogor.Source = bitmapImage;
            }
        }
    }
}
