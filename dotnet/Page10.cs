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
}