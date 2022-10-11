        
            int[] a = { 2, 3, 1,6, 5,7,8,9 };
            var list = a.ToList();
            list.Sort();

            var n = a.Length;
                       
           for (int i = list[0], j = 0; i < n&& j < n; i++,j++)
            {
                if (  i != list[j] )
                {
                    Console.WriteLine($"{i}");
                    break;
                }                          

            }

            


     
    