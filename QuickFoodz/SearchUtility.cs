using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class SearchUtility<Type>
    {
        public bool BinarySearch(CustomList<Type> list,string key,string propertyName,out Type element)
        {
            element=default(Type);
            int left=0;
            int right=list.Count-1;

            while(left<=right)
            {
                int mid=left+(right-left)/2;
                object middleValue= list[mid].GetType().GetProperty(propertyName).GetValue(list[mid]);
                int result=middleValue.ToString().CompareTo(key);

                if(result==0)
                {
                    element=list[mid];
                    return true;
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
            return false;
        }
    }
}