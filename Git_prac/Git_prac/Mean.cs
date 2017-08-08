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

        public void Rand(int x)  {
            numbers = new int[x];
            Random rand = new Random();
            for(int k = 0; k <= x; k++) {
                numbers[k] = rand.Next();
            }
            
        }

        public int mean(int x) {
            int sum = 0;
            for(int l = 0; l < x; l++) {
                sum += numbers[l];

            }

            return (sum / x);
        


        }



    }
}
