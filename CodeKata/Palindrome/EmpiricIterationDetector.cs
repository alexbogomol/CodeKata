namespace CodeKata.Palindrome
{
    public class EmpiricIterationDetector : IPalindromeDetector
    {
        public bool IsPalindrome(string sequence)
        {
            var length = sequence.Length;

            if (length == 0 || length == 1)
            {
                return true;
            }

            var steps = length / 2;

            for (int step = 0; step < steps; step++)
            {
                if (sequence[step] != sequence[length - 1 - step])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
