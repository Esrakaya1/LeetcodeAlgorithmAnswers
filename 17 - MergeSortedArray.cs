public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // two pointers method
        // start from the end of the arrays

        int k = m + n - 1; // last index of nums1
        int i = m - 1;
        int j = n - 1;
        
        // Compare the largest remaining elements in both arrays and place the larger one at position k.
        while (j >= 0) {
            if (i >= 0 && nums1[i] > nums2[j]) {
                // If nums1[i] > nums2[j], place nums1[i] at nums1[k] and move i and k backward.
                nums1[k] = nums1[i];
                i--;
            } else { // Otherwise, place nums2[j] at nums1[k] and move j and k backward.
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}

// time complexity: O(m + n) The loop processes each element of nums1 and nums2 exactly once.

// space complexity: O(1) The algorithm operates directly on the nums1 array, and no additional data structures or memory is used. All operations are done in place.