public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {//[50,50,10,50,50] h=210; 
    //return min k(bPHr) which is too closer to h
    //50 bPHr we finish in 5hrs
    //10 bPHr we finish eating in 21hrs
    //1 bPHr we finish eating in 210hrs
    //approach min+max/2; (1+50)/2

    int minBpHr=1;
    int maxBprHr=piles.Max();
    int res=1000000000;
    while(minBpHr<=maxBprHr)
    {
        int totalTime=0;
        int avgBpHr=minBpHr+(maxBprHr-minBpHr)/2;

        foreach(var pile in piles)
        {
            totalTime=totalTime+(int)Math.Ceiling((double)pile/avgBpHr);
        }

        if(totalTime<=h)
        {
            res=avgBpHr;
            maxBprHr=avgBpHr-1;
        }
        else
        {
            minBpHr=avgBpHr+1;
        }

    }
    return res;                  
    }
}
