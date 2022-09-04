int[] FillArray(int size)
            {
            int[]array = new int[size];
            for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(0, 30);
                    if (i!=array.Length-1) Console.Write($"{array[i]}, ");
                    else Console.WriteLine($"{array[i]}");
                        
                }
            return array;
            }    
            int[] mas=FillArray(8);