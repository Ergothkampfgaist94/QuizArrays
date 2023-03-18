using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _array;
        public int M { get;}
        public int N { get;}

        public int TwoDimensions(int M, int N) 
        {
            return _array[M, N];
        }
        public void Fill()
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                _array[i,i] = random.Next(1, 100);
            }                  
        }
        public int ToOneDimension() 
        { 
            
        }
    }
}
