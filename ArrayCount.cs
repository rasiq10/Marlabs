class ArrayCount {
    static void Main() {
        int[] ip = {1,1,2,2,2,3,3,3,3,5,5,6,7,8};
        
        int prev = ip[0], counter = 1;
        string res = "";
        
        for(int i = 1; i < ip.Length; i++){
            if(ip[i] == prev){
                counter++;
            }
            else{
                res += prev+"="+counter+",";
                prev = ip[i];
                counter = 1;    
            }
        }
        Console.Write(res+prev+"="+counter);
    }
}
