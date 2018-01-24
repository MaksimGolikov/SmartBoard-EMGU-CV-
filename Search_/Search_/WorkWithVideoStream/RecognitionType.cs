using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_.WorkWithVideoStream
{
    class RecognitionType
    {
        private Bitmap    gestureImage;
        private Rectangle gesturePosition;

        public Bitmap GestureImage { get => gestureImage; set => gestureImage = value; }
        public Rectangle GesturePosition { get => gesturePosition; set => gesturePosition = value; }
    }
}
