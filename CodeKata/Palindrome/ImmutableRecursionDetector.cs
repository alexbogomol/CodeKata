namespace CodeKata.Palindrome
{
    public class ImmutableRecursionDetector : IPalindromeDetector
    {
        public bool IsPalindrome(string sequence)
        {
            return IsPalindromeInternal(sequence, 0, sequence.Length - 1);
        }

        private bool IsPalindromeInternal(string sequence, int start, int stop)
        {
            if (stop - start <= 1) return true;

            return sequence[start] == sequence[stop]
                && IsPalindromeInternal(sequence, start + 1, stop - 1);
        }
    }
}
