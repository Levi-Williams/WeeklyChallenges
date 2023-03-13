using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null) { return false; }
            bool comparedVariable = false;
            foreach (var v in vals)
            {
                if (comparedVariable == v)
                {
                    return true;
                }
            }
            { return false; }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }

            int total = 0;
            foreach (int v in numbers)
            {
                total += v;
            }

            if (total % 2 == 0) { return false; }

            return true;

            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) { return true; }

            return false;

            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];

            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            int lengthOfString = val.Length;

            return val[lengthOfString - 1];

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            return dividend / divisor;

            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null) { return 0; }
            int firstInArray = nums[0];
            int lastInArray = nums[nums.Length - 1];
            return lastInArray - firstInArray;

            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            int[] nums = new int[50];
            int x = 1;
            nums[0] = x;
            for(int i = 1; i < 50; i++) 
            {
                nums[i] = x += 2; 
            }
            return nums;

            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++) { words[i] = words[i].ToUpper(); }
        }
    }
}
