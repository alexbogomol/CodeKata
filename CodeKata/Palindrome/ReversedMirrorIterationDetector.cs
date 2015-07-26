using System;

namespace CodeKata.Palindrome
{
    public class ReversedMirrorIterationDetector : IPalindromeDetector
    {
        public bool IsPalindrome(string sequence)
        {
            string reversed = ReverseString(sequence);

            var maxIdx = sequence.Length - 1;

            for (int i = 0; i <= maxIdx ; i++)
            {
                if (sequence[i] != reversed[i])
                    return false;
            }

            return true;
        }

        private string ReverseString(string sequence)
        {
            char[] chararr = sequence.ToCharArray();

            Array.Reverse(chararr);

            return new string(chararr);
        }
    }
}
