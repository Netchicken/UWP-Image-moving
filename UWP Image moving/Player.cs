using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP_Image_moving
{
    public class Player
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public int Position { get; set; }

        public TranslateTransform movePlayer { get; set; }
        public Player()
        {

        }
    }

}
