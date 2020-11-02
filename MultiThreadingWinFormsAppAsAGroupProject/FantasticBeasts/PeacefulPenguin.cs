/*
 * Christopher J Negron
 * negroncj@uc.mail.edu
 * Due: November 5th, 2020
 * Assignment #7
 * 
 * Resourses:
 * Casio Calculator
 * What is a prime factor:
 * https://www.mathsisfun.com/prime-factorization.html
 * 
 */
using System;
using System.Threading;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class PeacefulPenguin : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            msg = "Hello from PeacefulPengin.RunThread()";
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            long calculate = maxfactor(num); //I send the num variable to the maxfactor method
            response = Convert.ToString(calculate);
        }
        static private long maxfactor(long request)
        {
            long n = 2;
            while (n * n <= request) //start a while loop with the request
            {
                if (request % n == 0) //If the request is % n is equal to 0 we have finised looping and will return the result below
                {
                    request /= n;
                }
                else //Is not it will just add 1 and keep on looping
                {
                    ++n;
                }
            }

            return request;
        }
    }
}
