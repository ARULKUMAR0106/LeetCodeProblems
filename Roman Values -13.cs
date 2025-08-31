public class Solution {
    public int RomanToInt(string s) {
        
     int SumofRomans=0;
     char lastVisited='A';
        char [] romanArray= ['M','D','V','X','L','C'];

        foreach(char c  in s){
            int currentValue=0;    
                if(c=='I'){
                  currentValue=1;
                }
                if(c=='V'){
                    currentValue=5;
                }
                if(c=='X'){
                    currentValue=10;
                }
                if(c=='L'){
                    currentValue=50;
                }
                if(c=='C'){
                    currentValue=100;
                }
                if(c=='D'){
                    currentValue=500;
                }
                if(c=='M'){
                    currentValue=1000;
                }
            if( romanArray.Contains(c)){
                

                int value =GetLastVisited(lastVisited,c);

                if(value==0){
                      SumofRomans=SumofRomans+currentValue;  
                }
                else{
                    SumofRomans=SumofRomans+currentValue-value;
                }

            }
            else{
                SumofRomans=SumofRomans+currentValue;
            }
            lastVisited=c;
        }
     
        





        return SumofRomans;






    }

    private int GetLastVisited(char str,char curr){
        switch (str){
            case 'C':
                if(curr=='M' || curr=='D'){
                    return 200;
                }
                break;
            case 'I':
                 if(curr=='V' || curr=='X'){
                    return 2;
                 }
           
                 break;
            case 'X':
                 if(curr=='L' || curr=='C'){
                    return 20;
                 }
       
                 break;

        }
        return 0;
    }

}
