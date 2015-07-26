namespace CodeKata.Palindrome
{
    public class MutableRecursionDetector : IPalindromeDetector
    {
        public bool IsPalindrome(string sequence)
        {
            var length = sequence.Length;

            if (length == 0 || length == 1)
            {
                return true;
            }

            return sequence[0] == sequence[length - 1]
                && IsPalindrome(sequence.Substring(1, length - 2));
        }
    }
}
