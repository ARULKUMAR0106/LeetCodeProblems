public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> finalValue= new List<string>();
        if(nums.Length<1){
           return finalValue ;
        }
        int start=nums[0];
        int i=0;
        
       while(i<nums.Length){
        if( i<nums.Length-1 && nums[i]+1==nums[i+1]){
            i++;
        }
        else{
            if(start==nums[i]){
                string value= start.ToString();
                finalValue.Add(value);
            }
            else{
                string value=start.ToString()+"->"+nums[i].ToString();
                finalValue.Add(value);
            }
            if( i<nums.Length-1 ){
                i++;
                start=nums[i];
            }
            else{
                i++;
            }
        }
        
       }
       return finalValue;








    }
}

