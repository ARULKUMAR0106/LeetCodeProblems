public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> Listvalues= new List<string>();
        string values="";
        for(int i=0;i<nums.Length;i++){

            if(i<nums.Length-1 && nums[i]==nums[i+1]-1){
               if(values!=""){
                continue;
               }
               else{
                  values+=nums[i];
               }
            }   
            else{
                if(values!=""){
                    values+="->"+nums[i];
                }
                else{
                    values+=nums[i];

                }
                Listvalues.Add(values);
                values="";

            } 

        }
        return Listvalues;
        

    }
}

