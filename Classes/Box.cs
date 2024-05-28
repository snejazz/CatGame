using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGame.Classes
{
    public class Box
    {
        public Transform transform;
        int srcX = 0;

        public Box(PointF pos, Size size)
        {
            transform = new Transform(pos, size);
            ChooseRandomPic();
        }
        public void ChooseRandomPic()
        {
            Random r = new Random();
            int rnd = r.Next(0, 3);
            switch (rnd)
            {
                case 0:
                    srcX = 567;
                    break;
                case 1:
                    srcX = 684;
                    break;
                case 2:
                    srcX = 790;
                    break;

            }
        }
        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 15, 90, 87, GraphicsUnit.Pixel);
        }
    }
}
