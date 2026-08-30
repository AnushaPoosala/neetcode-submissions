public class Solution
{
    public bool IsPalindrome(string s)
    {
        int length = s.Length / 2;
        int backLetterCount = s.Length - 1;
        int frontLetterCount = 0;

        while (frontLetterCount < backLetterCount)
        {
            while (frontLetterCount < backLetterCount && InvalidChars(s[frontLetterCount]))
                frontLetterCount++;

            while (frontLetterCount < backLetterCount && InvalidChars(s[backLetterCount]))
                backLetterCount--;

            var front = s[frontLetterCount];
            var back = s[backLetterCount];

            if (char.ToLower(s[frontLetterCount]) != char.ToLower(s[backLetterCount]))
                return false;

            frontLetterCount++;
            backLetterCount--;
        }
        return true;
    }

    /*"
    W 0
    a 1
    s 2
      3
    i 4
    t 5
      6
    a 7
      8
    c 9
    a 10
    r 11
      12
    o 13
    r 14
      15
    a 16 
      17
    c 18
    a 19
    t 20
      21
    I 22
      23
    s 24
    a 25
    w 26
    ? 27

     */
    public bool InvalidChars(char c)
    {
        if (!char.IsLetterOrDigit(c))
            return true;
        return false;
    }
}