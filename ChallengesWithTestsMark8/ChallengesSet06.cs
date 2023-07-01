using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null)) { return false; }

            if(words == null) { return false; }

            if(ignoreCase) 
            { 
                word= word.ToLower(); 
                
                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            
            }
            
            if(!ignoreCase)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;

            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            bool answer = true;

            if (num < 0) { return false; }

            if (num == 1 || num == 0) { return false; }

            for(int x = 2; x <= num - 1; x++)
            {   

                if (num % x == 0) return false;

                if (num % x != 0) answer = true;

            }

            return answer;
            
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int answer = -1;
            bool isUnique;

            char[] strArr = str.ToCharArray();

            for (int y = 0; y < strArr.Length; y++)
            {

                isUnique = true;

                for (int x = 0; x < strArr.Length; x ++)
                {
                    if (strArr[y] == strArr[x] && y != x) { isUnique = false; }
                }

                if(isUnique == true) { answer = y; }
            }

            return answer;

            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int x = 0; x < numbers.Length; x ++) 
            {
                int currentCount = 1;

                for(int y = x + 1; y < numbers.Length; y ++)
                {
                    if (numbers[x] != numbers[y]) { break; }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
            
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var everyNth = new List<double>();

            if(elements == null || n <= 0 || n > elements.Count) { return everyNth.ToArray(); }

            for(int x = n - 1; x < elements.Count; x += n)
            {
                everyNth.Add(elements[x]);

            }

            return everyNth.ToArray();


            throw new NotImplementedException();
        }
    }
}
