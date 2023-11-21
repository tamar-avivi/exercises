class Page3 {
    // Exercise 1
    //=============
    public void exerciseP3_1() {
        char ch1 = 'a';
        char ch2 = 'z';
        int num = ch1 - ch2;
        Console.WriteLine(num);
        int num2 = (int)5.8;
        Console.WriteLine(num2);
        double num3 = 78;
        int num4 = 'a';
        char ch3 = (char)97;
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(ch3);
        int num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        double avg1 = (num1 + num2) / 2;
        double avg2 = (double)(num1 + num2) / 2;
        Console.WriteLine(avg1);
        Console.WriteLine(avg2);
    }

    // Exercise 2
    //=============
    public void exerciseP3_2() {
        int char1;
        int char2;
        int char3;
        Console.WriteLine("enter a char:");
        char1 = char.Parse(Console.ReadLine());
        char2 = char1 - 1;
        char3 = char1 + 1;
        Console.WriteLine($"{char2} {char1} {char3}");
    }


    //Exercise 4
    //============
    public void exerciseP3_4() {
        char char1;
        char char2;
        char char3;
        int integer1;
        int integer2;
        int integer3;
        int num;
        Console.WriteLine("enter a char:");
        char1 = char.Parse(Console.ReadLine());
        Console.WriteLine("enter a char:");
        char2 = char.Parse(Console.ReadLine());
        Console.WriteLine("enter a char:");
        char3 = char.Parse(Console.ReadLine());
        int uchar1 = (int)(char1);
        int uchar2 = (int)(char2);
        int uchar3 = (int)(char3);
        integer1 = uchar1 % 10;
        integer2 = uchar2 % 10;
        integer3 = uchar3 % 10;
        num = 5 * integer1 + 5 * integer2 + 5 * integer3;
        char unum = (char)(num);
        Console.WriteLine($"{unum}");
    }
}