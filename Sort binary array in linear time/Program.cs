using System;

namespace Sort_binary_array_in_linear_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, 1, 1, 1, 0, 1 };
            sort(arr);
            Console.WriteLine(string.Join(",",arr));
        }

        public static void sort(int[] A)
        {
            int i = 0;
            int j = A.Length-1;
            while (i<j)
            {
                if (A[i] == 0)
                    i++;
                else
                {
                    while (A[j] == 1)
                        j--;
                    if(j>i)
                        Swap(A,i, j);
                }

            }
            Console.WriteLine("stop");
        }

        public static void Swap(int[] arr, int X, int Y)
        {
            int temp = arr[X];
            arr[X] = arr[Y];
            arr[Y] = temp;
        }
    }
}
