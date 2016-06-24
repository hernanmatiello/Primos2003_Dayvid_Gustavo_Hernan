using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Primos
    {
        public int limit = 20000;
        public List<int> numbers = new List<int>();

        public int currentPosition = -1;

        public void initNumbers(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                //Console.WriteLine(i.ToString());
                numbers.Add(i);
            }

        }

        public void markAndDelete()
        {
            currentPosition++;
            if (numbers.Count > currentPosition)
            {
                int currentValue = numbers.ElementAt(currentPosition);
                for (int i = currentPosition + 1; i < numbers.Count; i++)
                {
                    if (numbers.ElementAt(i) % currentValue == 0) // não é primo
                    {
                        numbers.RemoveAt(i);
                    }
                }
                markAndDelete();
            }
        }
        public void numbersAsString()
        {
            foreach (var item in numbers)
            {
                Console.Write(item.ToString() + "; ");
            }
            Espera();
        }

        public void Espera()
        {
            Console.ReadKey();
        }

    }
}