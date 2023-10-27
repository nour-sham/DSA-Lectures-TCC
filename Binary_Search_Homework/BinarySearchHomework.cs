using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
              if (end >= start) {
 
           
            int mid1 = start + (end- start) / 3;
            int mid2 = start - (end - start) / 3;
 
            
            if (arr[mid1] == key) {
                return mid1;
            }
            if (arr[mid2] == key) {
                return mid2;
            }
 
            if (key < arr[mid1]) {
 
                return TernarySearch(arr,key,start, mid1 - 1 );
            }
            else if (key > arr[mid2]) {
 
                
                return TernarySearch(arr,key,mid2 + 1, end);
            }
            else {
 
                
                return TernarySearch(arr,key,mid1 + 1, mid2 - 1);
            }
        }
 
        
        return -1;
    }
        

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
              if (end < start)
            return -1;
 
        int mid = start+ (end - start) / 2;
 
        if (arr[mid] == key)
            return mid;
 

        if (arr[mid] > key)
            return BinarySearchForCalculatingRepeated(arr, key, true,start, mid - 1);
 
        return BinarySearchForCalculatingRepeated(arr, key, true,mid+1,end);
 
                                   
    }
        

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
               int ind =  BinarySearchForCalculatingRepeated(arr,key,true,0,arr.Length - 1);

        if (ind == -1)
            return 0;
 
        int count = 1;
        int left = ind - 1;
        while (left >= 0 &&  arr[left] == key)
        {
            count++;
            left--;
        }
 
        int right = ind + 1;
        while (right < arr.Length &&  arr[right] == key)
        {
            count++;
            right++;
        }
 
        return count;
    
        }
    }
}
