﻿using Boolean.CSharp.Main.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float a, float b) => a + b;
        
        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double a, double b) => a + b;

        


        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float a, float b) => a - b;

        
        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string str, char c)
        {
            return Regex.Replace(str, @$"[{c}]", "");
        }


        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int a, int b) => a * b;

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string a, int b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Concat(Enumerable.Repeat(a + ',', b)));
            return stringBuilder.ToString().Substring(0,stringBuilder.ToString().Length-1);

        }
        //TODO: 7. multiply, which accepts an array of strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] a, int b)
        {
            int[] result = new int[a.Length];
            
            for(int i = 0; i <= a.Length - 1; i++)
            {
                result[i] = int.Parse(a[i]) * b;
            }

            return result;
        }

    }
}
