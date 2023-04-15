using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) return 0;
            
            var evenCount = numbers.Where(x => x % 2 == 0).Sum();
            var oddCount = numbers.Where(x => x % 2 != 0).Sum();

           return evenCount - oddCount;
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return stringList.Min();
            
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberList = new List<int> { number1, number2,number3, number4 }.OrderBy(x => x);
            return numberList.First();
            
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sideLengths = new List<int>() { sideLength1, sideLength2, sideLength3}.ToArray();
            var orgSideLengths = sideLengths.OrderByDescending(x => x);
            int bigLength = orgSideLengths.First();
            int otherSide1 = orgSideLengths.ElementAt(1);
            int otherSide2 = orgSideLengths.ElementAt(2);

            if(bigLength < (otherSide1 + otherSide2)) { return true; }
            return false;


            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var numbOfNull = 0;
            var numbOfObj = 0;

            foreach(var obj in objs)
            {
                numbOfObj++;
                if(obj == null) { numbOfNull++; };
            }

            if (numbOfNull > (numbOfObj - numbOfNull)) return true;
            return false;
            
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null) return 0;
            var evens = numbers.Where(x => x % 2 == 0);
            if (evens.Count() == 0 ) return 0;
            return evens.Average(x => x);
            
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            int fac = 1;
            if(number < 0) throw new ArgumentOutOfRangeException();   

           for (int x = number; x > 0; x--)
            {
                fac *= x;
            }
            return fac;
            
            throw new NotImplementedException();
        }
    }
}
