public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        Stack<double> sk=new Stack<double>();
        int[][] cars=new int[position.Length][];
        for(int i=0;i<position.Length;i++)
        {
            cars[i]=new int[]{position[i],speed[i]};
        }

        Array.Sort(cars,(car1,car2)=>
        {
            int position1=car1[0];
            int position2=car2[0];
            return position2.CompareTo(position1);
        });

        for(int i=0;i<position.Length;i++)
        {
            double timeNeededToReachDest=(double)(target-cars[i][0])/cars[i][1];
            
            sk.Push(timeNeededToReachDest);
            
            if(sk.Count>=2 && sk.ElementAt(1)>=sk.Peek())
            sk.Pop();
        }
        return sk.Count;
    }
}
