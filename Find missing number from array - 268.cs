public class Solution {
    public int MissingNumber(int[] nums) {
        
    //     Array.Sort(nums);

    //     if(nums[0]!=0){
    //         return 0;
    //     }

    //     for(int i=0;i<nums.Length;i++){
    //         if(i==nums.Length-1){
    //              return nums[nums.Length-1]+1;
    //         }
    //         if(nums[i]!=nums[i+1]-1){
    //             return nums[i]+1;
    //         }
           
    //     }
    //    return nums[nums.Length-1]+1;
    // }

   // Above code is built with logic not with DSA

   // Here is what we can


   //Algo name is Sum of n


    int len=nums.Length;

    int formulavalue= len *(len+1)/2;
    int sum=0;

    foreach(int i in nums){
            sum+=i;
    }
    return formulavalue-sum;
    
    
    }

}