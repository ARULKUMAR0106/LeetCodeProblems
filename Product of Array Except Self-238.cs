public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n= nums.Length;
        int[] l_ar=new int[n];
        int [] r_ar=new int[n];


        int l=1;
        int r=n-2;
        l_ar[0]=1;
        for(int j=l;j<n;j++){
            l_ar[j]=nums[j-1]*l_ar[j-1];
            
        }
        r_ar[n-1]=1;
        for(int j=r;j>=0;j--){

            r_ar[j]=nums[j+1]*r_ar[j+1];

        }

        for(int i=0;i<n;i++){
            l_ar[i]=l_ar[i]*r_ar[i];

        }
        return l_ar;



        

        



    }
}