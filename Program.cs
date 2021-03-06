﻿using System;
using System.Linq;

namespace LINQ
{
    class IntroToLINQ
{        
    static void Main()
    {
        // The Three Parts of a LINQ Query:
        //  1. Data source.
        int[] numbers = new int[30] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 
                                    18, 19, 20, 21, 22, 23, 24, 26, 27, 28, 29, 30};

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
        
        Console.ReadLine();

        string[] cars = {"Camaro", "BMW", "Mercedes", "Bentley", "Hummer", "i8", "RangeRover", "Beamer","Cadillac",
                        "Rolls Royce","Nissan","Volkswagen","Camry","Hummer"};
		
      //Get only short words or long words
    //   var carNames = from car in cars where car.Length >= 3 select car;
    // using Lambda Expression Syntax
    var carNames = cars.Where( w => w.Length > 4);
	    
      //Print each word out
      foreach (var car in carNames) {
         Console.WriteLine("Car selection:"+car);
      }	 
		
      Console.ReadLine();

      string[] Friends = {"Glenn","Terrence","Nicole","Kenny","Ericka","Trevor","Tobias","Amber","Lola","David","CeeJay",
                            "Cesar","Jurnell","Jerome","Kazadi","Teriq","Kenisha","Tony","Vincent"};

    var myFriends = Friends.Where( w => w.Length > 3);

        foreach(var Friend in myFriends) {
            Console.Write(Friend +",");
        }
        }
    }
}


