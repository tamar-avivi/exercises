class Page11 {
    public static Random rnd = new Random();

    //=====================================================
    public void exerciseP11_6() {
        int sum, limit;
        int x;
        bool y;
        for (int i = 1; i < 10000; i++) {
            limit = (int)Math.Sqrt(i);
            sum = 1;
            x = 1;
            y = true;
            while (x <= limit && y == true) {
                x++;
                if (i % x == 0) {
                    sum += x;
                    if (x * x != i)
                        sum += i / x;
                }
                if (sum > i) {
                    y = false;
                }
            }
            if (sum == i && y == true) {
                Console.WriteLine(sum);
            }
        }
    }

    //=====================================================
    public void exerciseP11_7() {
        int limit;
        bool prime;

        int n = int.Parse(Console.ReadLine());
        for (int i = 10; i <= 99; i++) {
            limit = (int)Math.Sqrt(i);
            prime = true;
            for (int j = 2; j <= limit && prime; j++) {
                if (i % j == 0)
                    prime = false;
            }
            if (prime)
                Console.WriteLine(i);
        }
    }

    //=====================================================
    public void exerciseP11_8() {
        double avg = 0;
        double sum = 0;
        double hour = 0;
        int i;
        for (i = 1; i <= 30; i++) {
            int sahar = int.Parse(Console.ReadLine());
            while (sahar != -1) {
                hour = int.Parse(Console.ReadLine());
                sum = sahar * hour;
                Console.WriteLine(sum);
            }
            avg = +sum;
        }
        Console.WriteLine(avg);
    }

    //=====================================================
    public void exerciseP11_9() {
        int sumzugi = 0;
        int sumEzugi = 0;
        int x = 0;
        for (int i = 1; i <= 10; i++) {
            int num = int.Parse(Console.ReadLine());
            while (num > 0) {
                int a = num % 10;
                if (a % 2 == 0) {
                    sumzugi += a;
                }
                else {
                    sumEzugi += a;

                }
                num /= 10;
            }
            if (sumzugi == sumEzugi) {
                Console.WriteLine("perfect number");
                x++;
            }
        }
        Console.WriteLine(x);
    }

    //=====================================================
    public void exerciseP11_10() {
        int max = 0;
        for (int i = 1; i <= 30; i++) {
            int rna = rnd.Next(10, 10000);
            int sum = 0;
            Console.Write("{0} -> ", rna);
            while (rna > 0) {
                int digit = rna % 10;
                if (digit % 2 != 0) {
                    sum = sum + digit;
                }
                rna /= 10;
            }
            Console.WriteLine(sum);
            if (sum > max) {
                max = sum;
            }
        }
        Console.WriteLine("the max is {0}", max);
    }
    //===================================================== 
    public void exerciseP11_11() {
        int prevDigit = -1;
        bool bFast = true;
        int counter = 0;
        int num = 0;
        for (int i = 1; num != -1 && i <= 1000; i++) {
            num = int.Parse(Console.ReadLine());
            while (num != -1 || (num > 0 && bFast)) {
                int digit = num % 10;
                if (digit >= prevDigit) {
                    prevDigit = digit;
                }
                else {
                    bFast = false;
                }
                num /= 10;
            }
            if (bFast) {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    //====================================================
                //17
            int month;
            int day;
            int year=20;
            int limit;
            bool pitagoras = false;
            while (!pitagoras)
            {
                year++;
                month = 1;
                while (month<=12 && !pitagoras)
                {
                    day = 1;
                    limit = 31;
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                        limit = 30;
                    if (month == 2)
                    {
                        limit = 28;
                        if (year % 4 == 0 && year % 100 != 0)
                            limit = 28;
                    }
                        while (day<=limit && !pitagoras)
                        {
                            if (Math.Pow(day * day + month, 2) + Math.Pow(month, 2) == Math.Pow(year, 2))
                            {
                                Console.WriteLine("{0}/{1}/{2}", day, month, year);
                                pitagoras = true;
                            }
                            else
                                day++;
                        }
                        month++;
                    }
                    year++;
                }
            }


}

