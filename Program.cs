using System;

namespace CSharpStudy
{ 
    class Study1
    {
        public static void TestArrays1()
        {
            //声明交错数组a（数组里面套数组）
            int[][] a = [[1, 2, 3 ],[31]]; //最外层可以改为{}，意为初始化一个一维数组
            //a = [[1, 10, 3], [3, 331]]; //可重新赋值
            a[0][2] = 100;
            a[1] = [31,331];
            //int[][] a1 = new int[2][]{[1, 2, 3], [31] }; //这里前面的new int[2][] 是可以省略的，这里里面那层不能用{}
            //{}只能在初始化时使用
            //声明二维数组b
            int[,] b = { { 1, 2, 3}, {1, 2, 4} };
            b[1, 1] = 100;
            int[,] c = new int[2, 3]; // now c is [[0,0,0],[0,0,0]]
            int[,] d = new int[2, 3] { { 1, 2, 3 } ,{ 1, 4, 5 } };
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a[i].Length; j++)
                    Console.WriteLine($"a:{a[i][j]}");
            Console.WriteLine(b.Length);
            Console.WriteLine("=========\nb:");
            for (int i = 0;i < b.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                    Console.WriteLine(b[i,j]);
            Console.WriteLine("==========");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Console.WriteLine($"c:{c[i, j]},d:{d[i,j]}");
        }

        public static void TestArray2()
        {
            // Use generic type
            List<List<int>> a = [[1],[1,2]];
            List<int>[] b = a.ToArray();
            // 等价于：List<int>[] b = [..a];
            for (int i = 0;b.Length > i; i++)
                for (int j = 0; j < b[i].Count; j++)
                    Console.WriteLine(b[i][j]);
        }
    }
    
    class Program
    {
        public static void Main()
        {
            //Study1.TestArrays1();
            //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            //Study1.TestArray2 ();

            Console.WriteLine(InheritanceAndInterface.A.Method1());
            Console.WriteLine("===");
            InheritanceAndInterface.A a0 = new(); // i.e. new A()
            a0.LevelUp();
            InheritanceAndInterface.Base1[] list1 = [a0]; // Base1 v = new A()
            foreach (InheritanceAndInterface.Base1 i in list1)
            {
                Console.WriteLine(i.Method0());
                //int a1 = i.Method3(); //这里不能直接调用A类的方法，需要从Base1转成A类
                if (i is InheritanceAndInterface.A a1)
                {
                    Console.WriteLine(a1.Method3());
                }
            }
        }
    }
}