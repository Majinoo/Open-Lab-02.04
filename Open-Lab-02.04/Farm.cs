using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            var kury = 2 * chickens;
            var kravy = 4 * cows;
            var prasa = 4 * pigs;
            return kury + kravy + prasa; 
        }
    }
}
