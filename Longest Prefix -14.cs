public class Solution {
    public string LongestCommonPrefix(string[] strs) {


   // Horizaontal algo

    string prefix= strs[0];

    for(int i =1 ; i<strs.Length;i++){

        while(!strs[i].StartsWith(prefix)){
            prefix=prefix.Substring(0,prefix.Length-1);
            if(prefix==""){
                return "";
            }
        }
        
    }
    return prefix;

    }
}