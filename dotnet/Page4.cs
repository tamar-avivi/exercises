class Page4 {
    // Exercise 1
    //=============
    public void exerciseP4_1() {
        int num;
        int num1;
        int num2;
        int num3;
        Console.WriteLine("enter a triple digit number:");
        num = int.Parse(Console.ReadLine());
        num1 = num / 100;
        num2 = num / 10;
        num3 = num % 10;
        if (num1 == num3) {
            Console.WriteLine("palindrom");
        }
        else {
            Console.WriteLine("not palindrom");
        }
    }


    // Exercise 10
    //==============
    public void exerciseP4_10() {
        string name1;
        string name2;
        int numT1;
        int numT2;
        Console.WriteLine("enter the name of first runner:");
        name1 = Console.ReadLine();
        Console.WriteLine("enter the name of second runner:");
        name2 = Console.ReadLine();
        Console.WriteLine($"enter {name1}'s running time:");
        numT1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"enter {name2}'s running time:");
        numT2 = int.Parse(Console.ReadLine());
        if (numT1 < numT2) {
            Console.WriteLine($"{numT1} {name1}");
        }
        if (numT1 > numT2) {
            Console.WriteLine($"{numT2} {name2}");
        }
        if (numT1 == numT2) {
            Console.WriteLine("same time");
        }
    }


    // Exercise 11
    //==============
    public void exerciseP4_11() {
        int num;
        int num2;
        char op;
        Console.WriteLine("enter a number:");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("enter another number:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter - or + :");
        op = char.Parse(Console.ReadLine());
        if (op == '-') {
            Console.WriteLine($"{num} - {num2} = {num - num2}");
        }
        else if (op == '+') {
            Console.WriteLine($"{num} + {num2} = {num + num2}");
        }
        else {
            Console.WriteLine("error - please enter - or +");
        }

    }
}