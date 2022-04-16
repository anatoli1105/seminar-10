  Console.WriteLine($"введите число");
 
 int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];
 
            for(int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }
 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1) Console.WriteLine(array[i]);
               for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] != 0 && array[j] % array[i] != 0)
                    {
                        Console.Write($"{array[j]} ");
                        array[j] = 0;
                    }
                 }
                Console.WriteLine($":");
             }
