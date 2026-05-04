namespace Phan4_CauTrucDieuKhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            var arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

        }
        static void SapXepNoiBot(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        // Hoán đổi arr[i] và arr[j]
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void SapXepChon(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Hoán đổi arr[i] và arr[minIndex]
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        static void SapXepChen(int[] arr, int n)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
