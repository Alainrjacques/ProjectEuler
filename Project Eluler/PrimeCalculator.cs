using System;

namespace Project_Eluler
{
    class PrimeCalculator
    {
        public ulong FindNextPrime(ulong prime)
        {	
	        prime+=2;
            double test = Math.Sqrt(prime);
	        if(test % 2 ==0)
		        test--;
	        while(test > 1)
	        {
		        if( prime % test == 0)//If not prime
			        prime = FindNextPrime(prime);
		
		        else
			        test-=2;
	        }
	        //If its prime (divide by 1)
	        return prime;

        }
    }
}
