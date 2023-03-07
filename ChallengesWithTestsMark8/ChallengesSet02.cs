using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool answer;
            string allLetters = "abcdefghijklmnopqrstuvwxyz, ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if(allLetters.Contains(c)) { answer = true; }
            else {  answer = false; }
            return answer;
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int totalElements = vals.Length;
            bool answer;

            if(totalElements % 2 == 0) { answer = true; }
            else { answer = false; }

            return answer;

            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0) { return true; }
            else { return false; }
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0) { return false; }
            else { return true; }
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            
            return numbers.Min() + numbers.Max();
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           if(str1.Length < str2.Length) { return str1.Length; }
           else { return str2.Length; }

            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null) { return 0; }
            int total = 0;
            foreach(var number in numbers) { total = total + number; }
            return total;
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int evenTotal = 0;

            if (numbers == null) { return 0; }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) { evenTotal = evenTotal + numbers[i]; }
            }

            return evenTotal;
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null) { return false; }
            int total = 0;
            foreach (var number in numbers) { total = total + number; }
            if(total % 2 == 0) { return false;} else { return true; }
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long numberOdds = number / 2;
            if (number  <= 0) { numberOdds = 0;}
            return numberOdds;
            throw new NotImplementedException();
        }
    }
}
