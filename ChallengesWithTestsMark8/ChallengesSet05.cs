using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for(int x = 1; x < 100; x ++)
            {
                int result = startNumber + 1;
                if(result % n != 0) { result = result + x;}

                if (result % n == 0) { return result; }

            }
            
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            /*foreach(Business business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }*/

            for (var x = 0; x < businesses.Length; x++)
            {
                if (businesses[x].TotalRevenue == 0)
                {
                    businesses[x].Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null) { return false; }
            if(numbers.Length == 0) { return false; }

            /*
            
            var ascorder = numbers.OrderBy(x => x);
            int[] ascOrder = ascorder.ToArray();

            for (int x = 0; x < numbers.Length; x++)
            {
                bool isAsc = true;

                if (ascOrder[x] == numbers[x]) { isAsc = true; }

                else { return false; }
                
                return isAsc;
            }

            */

            bool answer = true;

            for (int x = 0; x < numbers.Length - 1; x++)
   
            {
                if (numbers[x] <= numbers[x + 1]) { answer = true; }
                else { answer = false; return false; }
            }

            return answer;

            throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {

            if(numbers == null) { return 0; }

            int total = 0;

            for(int x = 1; x < numbers.Length; x++)
            {
                int c = x + 1;

                if (numbers[x - 1] % 2 == 0)
                {
                    total += numbers[x];
                    
                }
            }

            return total;
            
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0) { return ""; }

            string sentence = "";

            foreach(string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            
            if(sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;

            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fours = new List<double>();
            if (elements == null) { return new double[0]; }
            if(elements.Count < 4) { return new double[0]; }

            for (int x = 3; x < elements.Count; x++) 
            {
                fours.Add(elements[x]);
                x = x + 3;
            }
            double[] foursConverted = fours.ToArray();
            return foursConverted;

            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i ++)
            {
                for(int j = i + 1; j < nums.Length; j ++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
            throw new NotImplementedException();
        }
    }
}
