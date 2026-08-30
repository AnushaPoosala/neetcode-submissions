public class TimeMap 
{
    Dictionary<string,SortedList<int,string>> dic;

    public TimeMap() 
    {
        dic=new Dictionary<string,SortedList<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if(!dic.ContainsKey(key))
        {
            dic[key]=new SortedList<int,string>();
        }
        dic[key].Add(timestamp,value);
    }
    
    public string Get(string key, int timestamp) 
    {
        if(!dic.ContainsKey(key))
        {
            return "";
        }
        if(dic.ContainsKey(key))
        {
            //perform binarysearch on slist and give equal or less that val
            SortedList<int,string> slist2=dic[key];
            int l=0; int r=slist2.Count-1; 
            

            while(l<=r)
            {
                int mid=(l+r)/2;

                if(slist2.Keys[mid]==timestamp)
                return slist2.Values[mid];

                else if(slist2.Keys[mid]<timestamp)
                l=mid+1;

                else
                r=mid-1;
            }

            if(r>=0)
            return slist2.Values[r];
        }
         return "";
    }
}
