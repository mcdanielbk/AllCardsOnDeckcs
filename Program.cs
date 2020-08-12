using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckcs
{
  class Program
  {
    static void Main(string[] args)
    {
      var deck = new List <string>(){"AC","2C","3C","4C","5C","6C","7C","8C","9C","10C","JC","QC","KC","AS","2S","3S","4S","5S","6S","7S","8S","9S","10S","JS","QS","KS",
                              "AD","2D","3D","4D","5D","6D","7D","8D","9D","10D","JD","QD","KD","AH","2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH"};

            
        

            var r = new Random();
            var n = deck.Count(); 

            for (int i = 0; i < n; i++)
            {
              var randNumb = r.Next(0,n);
              var placeHolder = deck[randNumb];
              deck[randNumb] = deck[i]; 
              deck[i] = placeHolder; 

                
            }
              Console.WriteLine (deck[0]); 
              Console.WriteLine (deck[1]);

		
		
		

     }
            
    }
  }

