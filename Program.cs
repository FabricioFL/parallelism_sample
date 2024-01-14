Console.WriteLine("\n\nstarted! \n\n");


// ignore that, i was just testing the invoke feature

Parallel.Invoke(
    () => {
        Console.WriteLine("\n ok!");
    },
    () => {
        for(int i = 0; i <= 100; i++)
        {
            Console.WriteLine($"\n {i}");
        }
        Console.WriteLine("\n finished 1 \n");
    },
    () => {
        for(int i = 0; i <= 20; i++)
        {
            Console.WriteLine($"\n {i}");
        }
        Console.WriteLine("\n finished 2 \n");
    },
    () => {
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"\n {i}");
            Console.WriteLine("\n finished 3 \n");
        }
    }
);