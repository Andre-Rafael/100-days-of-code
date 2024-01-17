using System.Collections;

class MergeSortedArray
{
    public ArrayList ToMerge(int[] nums1, int m, int[] nums2, int n)
    {
        // nums1 = [1,2,3,0,0,0], m = 3
        // nums2 = [2,5,6],       n = 3
        ArrayList newArray = new ArrayList();
        for (int i = 0; i < m; i++)
        {
            newArray.Add(nums1[i]);
        }
        for (int i = 0; i < n; i++)
        {
            newArray.Add(nums2[i]);
        }
        newArray.Sort();
        return newArray;
    }
}