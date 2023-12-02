class Page9c {
    public static Random rnd = new Random();

    public void exercise_1() {
        int rna;
        int max = 0;
        for (int i = 1; i <= 20; i++) {
            rna = rnd.Next(59, 100);
            Console.Write("{0} ", rna);
            if (rna > max) {
                max = rna;

            }

        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(max);


    }

    public void exercise_2() {
        int rna;
        int min = rnd.Next(59, 100); ;
        for (int i = 2; i <= 50; i++) {
            rna = rnd.Next(59, 100);
            Console.Write("{0} ", rna);
            if (rna < min) {
                min = rna;

            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(min);

    }

    public void exercise_3() {
        int max = 0;
        for (int i = 1000; i <= 9999; i++) {
            int num1 = i % 100;
            int num2 = i / 100;
            int sum = (num1 + num2) * (num1 + num2);
            if (sum == i && sum % 5 == 0) {
                max = i;
            }
        }
        Console.WriteLine(" the max is {0}", max);
    }

    public void exercise_4() {
        int rna;
        int max = 0;
        for (int i = 1; i <= 30; i++) {
            rna = rnd.Next(11, 100);
            Console.Write("{0} ", rna);
            if (rna > max) {
                max = rna;
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(max);
    }

    public void exercise_5() {
        int rna;
        int max = 0;
        int counter = 0;
        for (int i = 1; i <= 12; i++) {
            rna = rnd.Next(1, 1000);
            if (rna > max) {
                max = rna;
                counter = i;
            }

        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("{0},{1}", max, counter);
    }

    public void exercise_6() {
        int rna;
        int max = 0;
        int sum = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) {
            rna = rnd.Next(10, 500);
            sum += rna;
            Console.WriteLine(rna);

            if (rna > max) {
                max = rna;

            }

        }
        Console.WriteLine(sum / n);
        Console.WriteLine(max);

    }

    public void exercise_7() {
        int rna;
        int min = 100;
        int max = 0;
        for (int i = 1; i <= 10; i++) {
            rna = rnd.Next(100, 1000);
            if (rna > max && rna % 7 == 0) {
                max = rna;

            }
            if (rna > min && rna % 3 == 0) {
                min = rna;

            }

        }
        Console.WriteLine(max / 7);
        Console.WriteLine(min / 3);

    }

    public void exercise_8() {
        int num = -1;
        int nextNum = -1;
        int min = 999999;
        for (int i = 1; i <= 5; i++) {
            Console.WriteLine("enter a number:");
            if (i >= 2) {
                num = nextNum;
            }
            nextNum = int.Parse(Console.ReadLine());
            if (i >= 2) {
                int hefresh = (nextNum - num);
                min = Math.Min(hefresh, min);
            }
        }
        Console.WriteLine("the minimum number is {0}", min);
    }
}


