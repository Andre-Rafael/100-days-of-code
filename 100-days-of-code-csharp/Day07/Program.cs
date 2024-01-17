// See https://aka.ms/new-console-template for more information

using System.Collections;

int[] nums1 = {1,2,3,0,0,0};
int[] nums2 = {2,5,6};

MergeSortedArray mergeSortedArray = new MergeSortedArray();
ArrayList resultArray = mergeSortedArray.ToMerge(nums1, 3, nums2, 3);
Console.Write("[" + string.Join(", ", resultArray.ToArray()) + "]");
