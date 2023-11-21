class Page6 {

    // Exercise 1
    //==============
    public void exerciseP6_1() {
        int num;
        Console.WriteLine("enter your bank account balance:");
        string line = Console.ReadLine();
        //Todo: check if line is int
        num = int.Parse(line);
        if (num < 0) {
            Console.WriteLine("you have a deficit in the bank:");


        }
        else if (num > 0) {
            Console.WriteLine("you have money in the bank");
        }
        else {
            Console.WriteLine("you have 0 money in the bank");
        }

    }
    //==================================================================================================================


    // Exercise 2
    //==============
    public void exerciseP6_2() {
        int num1;
        int num2;
        int num3;
        Console.WriteLine("enter a number :");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter a number :");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter a number :");
        num3 = int.Parse(Console.ReadLine());
        if (num1 > num2 && num1 > num3) {
            Console.WriteLine(num1);
        }
        else if (num2 > num1 && num2 > num3) {
            Console.WriteLine(num2);
        }
        else {
            Console.WriteLine(num3);
        }
    }
    //==================================================================================================================


    // Exercise 3
    //==============
    public void exerciseP6_3() {
        char ch;
        Console.WriteLine("enter a char :");
        ch = char.Parse(Console.ReadLine());
        if (ch >= 'A' && ch <= 'Z') {
            Console.WriteLine("the char is big");
        }
        else if (ch >= 'a' && ch <= 'z') {
            Console.WriteLine("the char is small");
        }
        else {
            Console.WriteLine("the char is not a letter");
        }

    }
    //==================================================================================================================


    // Exercise 4
    //==============
    public void exerciseP6_4() {
        int num1;
        int num2;
        Console.WriteLine("enter a number :");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter another number :");
        num2 = int.Parse(Console.ReadLine());
        if (num1 == num2) {
            Console.WriteLine(num1 + ", " + num2 + " are the same numbers");
        }
        else if (num1 >= num2) {
            Console.WriteLine(num1 + ", " + num2);
        }
        else {
            Console.WriteLine(num2 + ", " + num1);
        }


    }
    //==================================================================================================================


    // Exercise 5
    //==============
    public void exerciseP6_5() {
        int num1;
        int num2;
        int num3;
        Console.WriteLine("enter your test grade :");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your average grade of assignments :");
        num2 = int.Parse(Console.ReadLine());
        if (num1 >= 70 && num2 == 100) {
            Console.WriteLine("you meet the requirements!");
        }
        else if (num1 >= 90 && num2 >= 70) {
            Console.WriteLine("you meet the requirements!");
        }
        else {
            Console.WriteLine("you  do not meet the requirements");
        }
        num3 = (70 * num1) / 100 + (30 * num2) / 100;
        Console.WriteLine("your total grade is " + num3);

    }
    //==================================================================================================================


    // Exercise 6
    //==============
    public void exerciseP6_6() {
        int num1;
        int num2;
        int num3;
        Console.WriteLine("enter the length of the first side of a triangle :");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the length of the second side of a triangle :");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the length of the third side of a triangle :");
        num3 = int.Parse(Console.ReadLine());
        if (num1 == num2 && num1 == num3) {
            Console.WriteLine("the triangle is equilateral");
        }
        else if (num1 == num2 && num1 != num3) {
            Console.WriteLine("the triangle is isosceles");
        }
        else if (num3 == num1 && num3 != num2) {
            Console.WriteLine("the triangle is isosceles");
        }
        else if (num2 == num3 && num2 != num1) {
            Console.WriteLine("the triangle is isosceles");
        }
        else {
            Console.WriteLine("a triangle has different sides");
        }
    }
    //==================================================================================================================


    // Exercise 7
    //==============
    public void exerciseP6_7() {
        int num;
        Console.WriteLine("enter the car speed:");
        num = int.Parse(Console.ReadLine());
        if (num >= 90 && num <= 120) {
            Console.WriteLine("you are driving at the right speedlimit");
        }
        else if (num < 90) {
            Console.WriteLine("you are driving under the right speedlimit");
        }
        else if (num > 120) {
            Console.WriteLine("you are driving over the right speedlimit");
        }
    }
    //==================================================================================================================


    // Exercise 8
    //==============
    public void exerciseP6_8() {
        int speed;
        int roadNum;
        Console.WriteLine("enter the car speed :");
        speed = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the road's number :");
        roadNum = int.Parse(Console.ReadLine());
        if (roadNum == 1) {
            if (speed < 30) {
                Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
            }
            else if (speed > 60) {
                Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
            }
            else {
                Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
            }
        }
        if (roadNum == 2) {
            if (speed < 60) {
                Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
            }
            else if (speed > 90) {
                Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
            }
            else {
                Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
            }
        }
        if (roadNum == 3) {
            if (speed < 90) {
                Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
            }
            else if (speed > 120) {
                Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
            }
            else {
                Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
            }
        }
    }

}