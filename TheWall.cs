using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;
        //описание и работа труб
        public Image wallImg;

        public TheWall(int x, int y, bool isRotatedImage = false)
        {
            wallImg = new Bitmap("C:\\Users\\Пользователь\\OneDrive\\Рабочий стол\\Дома\\Tube2.png");
            this.x = x;
            this.y = y;
            sizeX = 50;
            sizeY = 250;
            if (isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}
//#include <iostream>
//#include <string>
//#include <vector>
//#include <fstream>

//class TheWall
//{
   // private:
    //int x;
   // int y;
   // int sizeX;
   // int sizeY;
   // bool isRotatedImage;
   // std::string wallImg;

    //public:
    //TheWall(int x, int y, bool isRotatedImage = false)
    //{
      //  wallImg = "C:\\Users\\Пользователь\\OneDrive\\Рабочий стол\\Дома\\Tube2.png";
       // this->x = x;
      //  this->y = y;
      //  sizeX = 50;
        //sizeY = 250;
       // if (isRotatedImage)
         //   rotateImage();
    //}

   // void rotateImage()
    //{
       
    //}
//};

//int main()
//{
  //  TheWall wall(0, 0, true);
//return 0;
//}