using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int[] _array;
        private int _top;

        private bool IsEmpty => _top == 0;
        private bool IsFull => _top == N;
        public int N { get; }
        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }
            _array[_top] = number;
            _top++;
        }
        public void OneDimension(int N)
        {
            _array[_top] = N;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}