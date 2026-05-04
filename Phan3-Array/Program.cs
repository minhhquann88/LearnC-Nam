namespace Phan3_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arr1chieu();
            arr2chieu();
            arr3chieu();
        }

        static void arr1chieu()
        {
            int[] mang1 = new int[3] { 1, 2, 3 };
            int[] mang2 = new int[] { 1, 2, 3 };
            int[] mang3 = [1, 2, 3];


            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
            }
        }
        static void arr2chieu()
        {
            int[,] mang2chieu =
            {
                {1,  2,3,4,5 },
                  {6,7,8,9,10},
            };
            Console.WriteLine(mang2chieu[0, 3]);
        }

        static void arr3chieu()
        {
            int[,,] mang3chieu =
            {
                {
                    {1,2,3 },
                    {4,5,6 },
                },
                {
                    {7,8,9 },
                    {10,11,12 },
                }
            };
            Console.WriteLine(mang3chieu[0, 1, 2]);
        }
        static void arrJagged()
        {
            int[][] mangJagged = new int[2][];
            mangJagged[0] = new int[] { 1, 2, 3 };
            mangJagged[1] = new int[] { 4, 5 };
            Console.WriteLine(mangJagged[0][2]);
        }
    }
