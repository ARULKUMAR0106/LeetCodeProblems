public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int[] value= new int[2];
        for(int i=1;i<n;i++){

            string  a=i.ToString();
            string  b=(n-i).ToString();
            if(a.Contains("0") || b.Contains("0")){
                    continue;
            }
            else{
                value[0]=int.Parse(a);
                value[1]=int.Parse(b);
            }
            
        }
        return value;


    }
}