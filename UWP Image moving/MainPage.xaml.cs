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


        //https://msdn.microsoft.com/en-us/windows/uwp/graphics/transforms-overview
        public MainPage()
        {
            this.InitializeComponent();

            LoadData();
        }
        //Assets/s6vste3a.bmp
        private void LoadData()
        {
            myPlayer[0] = new Player() { Name = "Igor", Image = "ms-appx:///Assets/euj4lu2h.bmp", Position = 0, movePlayer = MovePlayer1 };
            myPlayer[1] = new Player() { Name = "Ogor", Image = "ms-appx:///Assets/o0qnwxzn.bmp", Position = 0, movePlayer = MovePlayer2 };


        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                myPlayer[i].movePlayer.X += 4;
            }


        }
    }
}
