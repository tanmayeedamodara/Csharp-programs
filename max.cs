using System;

namespace Hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1,10,0,9,7,2,10,9,2};
            Program p = new Program();
            p.maxAndSecMax(arr);
        }
        public void maxAndSecMax(int[] a){
            int high = a[0];
            int secHigh = -1;
            for(int i=0; i<a.Length; i++){
                if(high < a[i]){
                    secHigh = high;
                    high = a[i];
                }
                else if(a[i] != high){
                    if(secHigh < a[i] || secHigh == high){
                        secHigh = a[i];
                    }
                }
            }
            Console.WriteLine($"Highest value = {high}");
            Console.WriteLine($"Second highest value = {secHigh}");
        }
    }
}
