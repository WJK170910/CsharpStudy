using System;

namespace OOP
{
    class MathFunction<T>
    {
        private T num1;
        private T num2;

        public MathFunction(T a, T b)
        {
            this.num1 = a;
            this.num2 = b;
        }

        public T Add()
        {
            dynamic a = num1;
            dynamic b = num2;
            var result = (T)(a + b);
            Console.WriteLine(result);
            return result;
        }
    }
}
