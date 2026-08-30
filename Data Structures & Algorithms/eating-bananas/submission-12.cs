public class Solution 
{
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int l=1; int r=piles.Max();
        int BpH=0;
        int MinBpH=r;
        

        while(l<=r)
        {
            BpH=l+(r-l)/2;
            Console.WriteLine("\nl:{0},r{1},midBPH{2}",l,r,BpH);
            long timeToFinish=0;
            for(int i=0;i<piles.Length;i++)
            {
                timeToFinish=timeToFinish+(long)Math.Ceiling((double)piles[i]/BpH);
            }
             Console.WriteLine("timeToFinish: {0}",timeToFinish);
            if(timeToFinish<=h)
            {                
                MinBpH=Math.Min(MinBpH,BpH);
                Console.WriteLine("MinBpH: {0}",MinBpH);
                r=BpH-1;
            }
            else
            {
                l=BpH+1;
            }
        }
        return MinBpH;
    }
}
