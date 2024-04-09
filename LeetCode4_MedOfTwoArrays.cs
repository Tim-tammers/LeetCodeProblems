public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int nums1Index = 0;
        int nums2Index = 0;
       int totalLength = nums1.Length + nums2.Length;
       bool isOdd = totalLength%2 == 0 ? false : true;
       int midIndex = totalLength/2;
       int[] halfpoint = new int[midIndex+1];

      for(int i = 0; i<= midIndex; i++){
        if(nums1Index < nums1.Length && nums2Index < nums2.Length){
            if(nums1[nums1Index] <= nums2[nums2Index]){
                halfpoint[i] = nums1[nums1Index];
                nums1Index++;
            }else{
                halfpoint[i] = nums2[nums2Index];
                nums2Index++;
            }
            
        }
       else if(nums1Index < nums1.Length && nums2Index >= nums2.Length){
            halfpoint[i] = nums1[nums1Index];
            nums1Index++;
        }
        else if(nums1Index >= nums1.Length && nums2Index < nums2.Length){
                halfpoint[i] = nums2[nums2Index];
                nums2Index++;
        }
      }
       if(isOdd){
        return(halfpoint[midIndex]);
       }else{
        return(((double)halfpoint[midIndex] +(double)halfpoint[midIndex-1])/2);
       }
    }
}