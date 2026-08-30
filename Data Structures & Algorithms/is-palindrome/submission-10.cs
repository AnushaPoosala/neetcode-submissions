public class Solution {
    public bool IsPalindrome(string s) 
    {
        int l=0; int r=s.Length-1;
        while(l<r)
        {
          char leftChar=s[l];
          char rightChar=s[r];
          while(l<r && !IsAlphanumeric(leftChar)) 
          {
            l++;
            leftChar=s[l];
          }
          while(l<r && !IsAlphanumeric(rightChar)) 
          {
            r--;
            rightChar=s[r];
          }
          if(IsAlphanumeric(leftChar) && IsAlphanumeric(rightChar))
          {
            if(char.ToUpper(leftChar)!=char.ToUpper(rightChar))
            return false;
          }
          l++;r--;
          //Console.WriteLine("left: {0},right: {1}",s[l],s[r]);
        }
        return true;
    }
    public bool IsAlphanumeric(char ch)
    {
      if(char.IsLetterOrDigit(ch))
      {
        return true;
      }
      return false;
    }
}
