public class TimeMap 
{
    private Dictionary<string,SortedList<int,string>> dic;

    public TimeMap() 
    {
        dic=new Dictionary<string, SortedList<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if(!dic.ContainsKey(key))
        dic[key]=new SortedList<int,string>();
        dic[key][timestamp]=value;      
    }
    
    public string Get(string key, int timestamp) 
    {
        if(!dic.ContainsKey(key))
            return "";
        
        var sortedList=dic[key];
        int left=0;
        int right=sortedList.Count-1;

        while(left<=right)
        {
            int mid=left+((right-left)/2);

            if(sortedList.Keys[mid]==timestamp)
                return sortedList.Values[mid];
            else if(sortedList.Keys[mid]<timestamp)
                left=mid+1;
            else
                right=mid-1;
        }
        if(right>=0)
            return sortedList.Values[right];
        return "";
    }
}
