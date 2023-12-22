using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{

    //работа с игроком
    //сбор данных о "птичке"
    class Player
    {
        public float x;
        public float y;

        public int size;
        public int score;

        public float gravityValue;

        public Image birdImg;

        public bool isAlive;

        public Player(int x, int y)
        {
            birdImg = new Bitmap("C:\\Users\\Пользователь\\OneDrive\\Рабочий стол\\Дома\\bird2.png");
            this.x = x;
            this.y = y;
            size = 50;
            gravityValue = 0.1f;
            isAlive = true;
            score = 0;
        }
    }
}