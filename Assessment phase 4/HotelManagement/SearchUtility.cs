using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class SearchUtility<Type>
    {
        public int BinarySearch(CustomList<Type> list,string key,string propertyName,out Type element)
        {
            element=default(Type);
            int left=0;
            int right=list.Count-1;

            while(left<=right)
            {
                int mid=left+(right-left)/2;

                var middleValue=list[mid].GetType().GetProperty(propertyName).GetValue(list[mid]);

                int result=middleValue.ToString().CompareTo(key);

                if(result==0)
                {
                    element=list[mid];
                    return mid;
                }
                else if(result>0)
                {
                    right=mid-1;
                }
                else
                {
                    left=mid+1;
                }
            }
            return -1;
        }
    }
}