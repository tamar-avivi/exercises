class Page10 {
    public static Random rnd = new Random();
    //=====================================================
    public void exerciseP10_1() {
        int counter = 0;
        int counter1 = 0;
        int x = int.Parse(Console.ReadLine());
        int min = x;
        while (x != 0) {
            if (x > 0)
                counter++;
            else {
                counter1++;
            }
            if (x < min)
                min = x;
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0},{1},{2}", counter, counter1, min);
    }
    //=====================================================
    public void exerciseP10_2() {
        int counter = 0;
        int sum = 0;
        int x = int.Parse(Console.ReadLine());
        while (x != -1) {
            counter++;
            sum += x;
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0} {1} {2}", counter, sum, (double)sum / counter);
    }
    //=====================================================
    public void exerciseP10_3() {
        int max = 0;
        int x = int.Parse(Console.ReadLine());
        while (x > 9 && x < 100) {
            if ((x % 10 != x / 10) && max < x)
                max = x;
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(max);
    }
    //=====================================================
    public void exerciseP10_4() {
        int counter = 0;
        int x = int.Parse(Console.ReadLine());
        while (x > 0) {
            counter++;
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(counter);
    }
    //=====================================================
    public void exerciseP10_5() {
        char answer;
        int yes = 0, no = 0;
        answer = char.Parse(Console.ReadLine());
        while (answer == 'y' || answer == 'n') {
            if (answer == 'y')
                yes++;
            else
                no++;
            answer = char.Parse(Console.ReadLine());
        }
        double pyes = (double)yes / (yes + no) * 100;
        double pno = (double)no / (yes + no) * 100;
        Console.WriteLine(pyes);
        Console.WriteLine(pno);
    }
    //=====================================================
    public void exerciseP10_6() {
        int counter = 0;
        int num = int.Parse(Console.ReadLine());
        int rna = rnd.Next(10, 100);
        while (rna != num) {
            counter++;
            rna = rnd.Next(10, 100);
        }
        Console.WriteLine(counter);
    }
    //=====================================================
    public void exerciseP10_7() {
        int counter = 0;
        int num = int.Parse(Console.ReadLine());
        while (num != 0) {
            counter++;
            num /= 10;
        }
        Console.WriteLine(counter);
    }
    //=====================================================
    public void exerciseP10_8() {
        int counter = 0;
        int sum = 0;
        int num = int.Parse(Console.ReadLine());
        while (num > 0) {
            sum = sum + num % 10;
            counter++;
            num = num / 10;
        }
        Console.WriteLine(sum);
    }
    //=====================================================
    public void exerciseP10_9() {
        int odd = 0;
        int even = 0;
        int digit = 0;
        int num = int.Parse(Console.ReadLine());
        while (num != 0) {
            digit = num % 10;
            if (digit % 2 == 0) {
                even++;
            }
            else {
                odd++;
            }
            num /= 10;
        }
        Console.WriteLine("even = {0} odd = {1}", even, odd);
    }
    //=====================================================
    public void exerciseP10_10() {
        int counter = 0;
        int sum = 0;
        int num = int.Parse(Console.ReadLine());
        while (sum < 4999) {
            sum += num;
            counter++;
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number of buyers who made a purchase is {0}", counter);
    }
    //============================================================
    public void exerciseP10_11() {
        Console.WriteLine("enter a number");
        int num = int.Parse(Console.ReadLine());
        int counter = 0;
        int countereven = 0;
        while (countereven < num) {
            counter++;
            Console.WriteLine("enter a number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                countereven++;
            }
        }
        Console.WriteLine("{0}, {1}", countereven, counter);
    }
    //=====================================================
    public void exerciseP10_12() {
        int sum = 0;
        int counter = 0;
        int digit = 0;
        int num = int.Parse(Console.ReadLine());
        while (sum == num) {
            counter++;
            digit = num % 10;
            if (digit == num % counter) {
                Console.WriteLine("its =");
            }
            else {
                Console.WriteLine("its !=");
            }
        }
    }
    //============================================================
    public void exerciseP10_13() {
        int num = int.Parse(Console.ReadLine());
        int finel = 0;
        while (num > 0) {
            finel = finel * 10 + num % 10;
            num /= 10;
        }
        Console.WriteLine(finel);
    }
    //============================================================
    public void exerciseP10_14() {
        int an = 0;
        int an_1 = 1;
        int an_2 = 0;
        Console.Write("{0} {1}", an_2, an_1);
        while (an_1 + an_2 < 120) {
            an = an_1 + an_2;
            Console.Write(" {0}", an);
            an_2 = an_1;
            an_1 = an;
        }
    }
    //============================================================
    public void exerciseP10_B_1() {
        int num = int.Parse(Console.ReadLine());
        int finel = 0;
        int x = num;
        while (num > 0) {
            finel = finel * 10 + num % 10;
            num /= 10;
        }
        if (finel == x) {
            Console.WriteLine("polinom");
        }
        else {
            Console.WriteLine("not polinom");
        }
    }
    //============================================================
    public void exerciseP10_B_3() {
        int num = int.Parse(Console.ReadLine());
        int limit = (int)Math.Sqrt(num);
        bool flag = true;
        int i = 2;
        while (i < limit && flag) {
            if (limit % i == 0 && i != limit) {
                flag = false;
                i++;
            }
        }
        Console.WriteLine(flag);
    }

}