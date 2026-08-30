public class TimeMap 
{
    Dictionary<string,SortedList<int,string>> dic;
    public TimeMap() {
        dic=new Dictionary<string,SortedList<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dic.ContainsKey(key))
        {
            dic[key]=new SortedList<int,string>();
        }
        dic[key][timestamp]=value;
    }
    
    public string Get(string key, int timestamp) {
        if(!dic.ContainsKey(key))
         return "";
        else
        {
            SortedList<int,string> sortedList=dic[key];
            int l=0; int r=sortedList.Count-1;
            while(l<=r)
            {
                int mid=l+((r-l)/2);
                if(sortedList.Keys[mid]==timestamp)
                return sortedList.Values[mid];
                if(sortedList.Keys[mid]>timestamp)
                r=mid-1;
                else
                l=mid+1;
            }
            if(r>=0)
            return sortedList.Values[r];
        }
        return "";
    }
}
