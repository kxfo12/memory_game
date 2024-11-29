using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace memory_game
{
    internal class Card
    {
        public ImageSource source;
        public bool onReverse;

        public Card(ImageSource source)
        {
            this.source = source;
            this.onReverse = true;
        }
        public ImageSource Reverse()
        {
            if (onReverse)
            {
                return source;
            }
            else
            {
                ImageSource odwrot = new BitmapImage(new Uri("carlotta.png", UriKind.Relative));
                return odwrot;
            }
        }
    }
}
