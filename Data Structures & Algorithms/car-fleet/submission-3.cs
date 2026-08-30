public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
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

        Stack<double> sk=new Stack<double>();
        foreach(var car in cars)
        {
            // int position=car[0];
            // int speed=car[1];
            double timeNeeded=(double)(target-car[0])/car[1];
            sk.Push(timeNeeded);

            while(sk.Count>=2 && sk.Peek()<=sk.ElementAt(1))
            {
                sk.Pop();
            }
        }
       return sk.Count;
    }
}
