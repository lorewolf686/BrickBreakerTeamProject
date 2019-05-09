using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class PowerUp
    {
        public int powerValue;
        public int x, y, powerSpeed, size;
        public int ballTimer, paddleTimer, scoreTimer = 0;
        public Color colour;

        // create a random number generator 


        public PowerUp(int _x, int _y, int _powerSpeed, int _size, int _powerValue)
        {
            x = _x;
            y = _y;
            powerSpeed = _powerSpeed;
            size = _size;
            powerValue = _powerValue;
            
            switch (powerValue)
            {
                case 1:
                    colour = Color.Cyan;
                    break;
                case 2:
                    colour = Color.Lime;
                    break;
                case 3:
                    colour = Color.Red;
                    break;
                case 4:
                    colour = Color.Fuchsia;
                    break;
                case 5:
                    colour = Color.White;
                    break;
                default:
                    colour = Color.Yellow;
                    break;
            }
        }

        public Boolean PowerUpCollision(Paddle p)
        {
            Rectangle powerUpRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            return (powerUpRec.IntersectsWith(paddleRec));
        }

        public void UpdatePowerUp()
        {
            switch (powerValue)
            {
                case 1:
                    GameScreen.bSpeedMult++;
                    break;
                case 2:
                    GameScreen.pSpeedMult++;
                    break;
                case 3:
                    GameScreen.scoreMult++;
                    break;
                case 4:
                    GameScreen.score+= 2000;
                    break;
                case 5:
                    GameScreen.lives++;
                    break;
                default:
                    break;
            }
        }

        //move the power up down the screen
        public void Move()
        {
            y = y + powerSpeed;
        }
    }
}
