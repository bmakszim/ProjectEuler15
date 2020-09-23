using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler15
{
    class Algorithm
    {
        private const int size = 20;
        public double Counter { get; set; } = 0;

        public double Run()
        {
            VerrrrySlowRun(new Position { X = 1, Y = 0 });
            return Counter * 2;
        }

        public void VerrrrySlowRun(Position pos)
        {
            if (pos.X == size && pos.Y == size)
            {
                Counter++;
                return;
            }

            if (pos.X > size || pos.Y > size)
            {
                return;
            }

            VerrrrySlowRun(MoveRight(pos));
            VerrrrySlowRun(MoveDown(pos));
        }

        private Position MoveRight(Position pos)
        {
            pos.X++;
            return pos;
        }

        private Position MoveDown(Position pos)
        {
            pos.Y++;
            return pos;
        }
    }
}
