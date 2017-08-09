using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_prac
{
    class Mean
    {
        public int[] numbers;
        public string nrhold;
        public void Rand(int x)  {
            numbers = new int[x];
            Random rand = new Random();
            for(int k = 0; k < x; k++) {
                numbers[k] = rand.Next(1, 50);
                nrhold +=  Convert.ToString(numbers[k]) + " ";
            }
            
        }

        public float mean(int x) {
            int sum = 0;
            for(int l = 0; l < x; l++) {
                sum += numbers[l];

            }

            return (sum/x);
        


        }



    }
}
