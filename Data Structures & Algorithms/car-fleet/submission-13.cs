public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        if(position.Length==1)
        return 1;
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

        Stack<double> stack=new Stack<double>();

        foreach(var car in cars)
        {
            var time=(double)(target-car[0])/car[1];
            stack.Push(time);

            if(stack.Count>=2 && stack.Peek()<=stack.ElementAt(1))
            {
                stack.Pop();
            }
        }
        return stack.Count;

    }
    
}
