class Result
{
    public static void plusMinus(List<int> arr,int n)
    {
        if (arr is null)
        {
            throw new ArgumentNullException(nameof(arr));
        }

        List<int> arr1=new List<int>();
        List<int> arr2=new List<int>();
        List<int> arr3=new List<int>();
        double pos,neg,zero;
        
        for(int i=0;i<arr.Capacity;i++){
            if(arr[i]>0){
                arr1.Add(arr[i]);
            }else if(arr[i]<0){
                arr2.Add(arr[i]);
            }else if(arr[i]==0){
                arr3.Add(arr[i]);
            }
        } 
        
        pos=(double)arr1.Count/n;
        neg=(double)arr2.Count/n;
        zero=(double)arr3.Count/n;
        
        Console.WriteLine(pos);  
        Console.WriteLine(neg);  
        Console.WriteLine(zero);  
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        
        int n = Convert.ToInt32(value: Console.Read());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Console.Clear();
        Result.plusMinus(arr,n);
    }
}
