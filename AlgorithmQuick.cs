using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler15
{
    class AlgorithmQuick
    {
        private const int InitialIdx = 0 + 1; //Add another one to avoid OutOfRangeException
        private const int Size = 21 + 1; //Add another one to avoid OutOfRangeException
        private ulong[,] matrix = new ulong[Size, Size];

        public ulong Run()
        {
            matrix[InitialIdx, InitialIdx] = 1;
            for (int y = InitialIdx; y < Size; y++)
            {
                for (int x = InitialIdx; x < Size; x++)
                {
                    matrix[x, y] += matrix[x - 1, y] + matrix[x, y - 1];
                }
            }

            return matrix[Size - 1, Size - 1];
        }
    }
}
