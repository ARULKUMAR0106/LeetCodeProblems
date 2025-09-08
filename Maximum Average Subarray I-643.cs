public class Solution {

    public double FindMaxAverage(int[] nums, int k) {       
      //Sliding algo
        int maxsum=0;
        int sum=0;
        for(int i=0;i<k;i++) maxsum += nums[i];

        sum=maxsum;

        for(int i=k;i<nums.Length;i++){

            sum += nums[i] - nums[i-k];

            maxsum=Math.Max(maxsum,sum);

        }
        return (double)maxsum/k;

    }
}