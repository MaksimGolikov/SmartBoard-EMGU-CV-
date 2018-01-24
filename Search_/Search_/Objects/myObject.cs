using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_.Objects
{
    class myObject
    {
        private int       id;
        private Bitmap    image;
        private Rectangle position;
        private Size      originalSize;
        private float     scale;

        public int Id { get => id;}
        public Bitmap Pictire { get => image; set => image = value; }
        public Rectangle Position { get => position; }     
      


        public myObject(int newID, Bitmap newImage, Point startPosition)
        {
            id = newID;
            image = newImage;
            scale = 1.0f;
            position = new Rectangle(startPosition,image.Size);
            originalSize = image.Size;
        }

        

        public void Move(Point newPosition)
        {
            position.X = newPosition.X - position.Width / 2;
            position.Y = newPosition.Y - position.Height / 2;
        }

        public void Scale(float delta)
        {
            scale = delta;

            if (scale < 0.5)
            {
                scale = 0.5f;
            }
            if (scale > 2){
                scale = 2f;
            }

            position = new Rectangle(position.Location, new Size((int)(originalSize.Width * scale), (int)(originalSize.Height*scale)) );
            image    = new Bitmap(image,
                                  new Size((int)(originalSize.Width * scale),
                                           (int)(originalSize.Height * scale)));

        }


    }
}
