namespace Product_of_Array_Except_Self;


public class Solution
{
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        int L_product = 1, R_product = 1;

        for (
            int L = 0, R = n - 1;
            L < n && R >= 0;
            L++, R--
        ) {
            if (L <= R) {
                answer[L] = 1;
                answer[R] = 1; 
            }
            answer[L] *= L_product; 
            L_product *= nums[L];
            answer[R] *= R_product; 
            R_product *= nums[R];
        }

        return answer;
    }
}
