

//                                             EXERCISES
//==============================================================================================================

// Page 1:
//===================================================================

// Exercise 1
//=============
void exerciseP1_1() {
    Console.WriteLine("pleas enter number of products:");
    int? numProducts = int.Parse(Console.ReadLine());
    Console.WriteLine("please enter the price:");
    int? price = int.Parse(Console.ReadLine());
    Console.WriteLine($"number of products is {numProducts}");
    Console.WriteLine($"the price is {price}");
    Console.WriteLine($"the total price is: {numProducts*price}");
}


// Exercise 3
//=============
void exerciseP1_3() {
    double b;
    double h;
    Console.WriteLine("enter the base:");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("enter the height:");
    h = double.Parse(Console.ReadLine());
    double area = b*h/2;
    Console.WriteLine($"the area is: {area}");
    double scope = b*3;
    Console.WriteLine($"the scope is: {scope}");
}


// Exercise 4
// =============
void exerciseP1_4() {
    double price;
    int numOfStudents;
    Console.WriteLine("enter the price of one book:");
    price = double.Parse(Console.ReadLine());
    Console.WriteLine("enter the number of students:");
    numOfStudents = int.Parse(Console.ReadLine());
    double totalPrice = price * numOfStudents;
    Console.WriteLine($"the total price is {totalPrice}");
}
//==================================================================================================================


// Exercise 8
//==============
void exerciseP1_8() {
    double price;
    double num;
    Console.WriteLine("enter the tiket's price :");
    price = double.Parse(Console.ReadLine());
    num = (price * 0.9);
    Console.WriteLine("the price befor the sale : " + price);
    Console.WriteLine("the price after the sale : " + num);
}
// Page 2
//===================================================================

// Exercise 1
// =============
void exerciseP2_1() {
    int guests;
    int numOfPlacesAtTheTable;
    Console.WriteLine("enter the number of guests:");
    guests = int.Parse(Console.ReadLine());
    Console.WriteLine("enter the number of places at the table:");
    numOfPlacesAtTheTable = int.Parse(Console.ReadLine());
    int remainder = guests % numOfPlacesAtTheTable;
    int fullTables = guests / numOfPlacesAtTheTable;
    Console.WriteLine($"there are {fullTables} full tables and {remainder} guests left at the other table.");
}


// Exercise 2
//=============
void exerciseP2_2() {
    int integer;
    Console.WriteLine("enter a two digit number:");
    integer = int.Parse(Console.ReadLine());
    int theNumOfUnits = integer % 10;
    int theNumOfTens = integer / 10;
    Console.WriteLine($"the sum of the digits of the number {integer} is {theNumOfUnits + theNumOfTens}.");
}


// Exercise 6
//=============
void exerciseP2_6() {
    int integer;
    int num;
    int num2;
    int num3;
    Console.WriteLine("enter a two digit number:");
    integer = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a one digit number:");
    num = int.Parse(Console.ReadLine());
    num2 = integer % 10;
    num3 = integer / 10;
    Console.WriteLine($"{num3}{num}{num2}");
}


// Page 3
//===================================================================

// Exercise 1
//=============
void exerciseP3_1() {
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
void exerciseP3_2() {
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
void exerciseP3_4(){
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
    int uchar1 = (int) (char1);
    int uchar2 = (int) (char2);
    int uchar3 = (int) (char3);
    integer1 = uchar1 % 10;
    integer2 = uchar2 % 10;
    integer3 = uchar3 % 10;
    num = 5 * integer1 + 5 * integer2 + 5 * integer3;
    char unum = (char) (num);
    Console.WriteLine($"{unum}");
}

// Page 4
//===================================================================

// Exercise 1
//=============
void exerciseP4_1() {
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
    } else {
        Console.WriteLine("not palindrom");
    }
}


// Exercise 10
//==============
void exerciseP4_10() {
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
void exerciseP4_11() {
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
        Console.WriteLine($"{num} - {num2} = {num-num2}");
    } else if (op == '+') {
        Console.WriteLine($"{num} + {num2} = {num+num2}");
    } else {
        Console.WriteLine("error - please enter - or +");
    }

}
//==================================================================================================================


// Exercise 1
//==============
void exerciseP6_1() {
    int num;
    Console.WriteLine("enter your bank account balance:");
    string line = Console.ReadLine();
    //Todo: check if line is int
    num = int.Parse(line);
    if (num < 0) {
        Console.WriteLine("you have a deficit in the bank:");
    

    } else if (num > 0) { 
        Console.WriteLine("you have money in the bank");
    } else {
        Console.WriteLine("you have 0 money in the bank");
    }

}
//==================================================================================================================


// Exercise 2
//==============
void exerciseP6_2() {
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
    } else if (num2 > num1 && num2 > num3) {
        Console.WriteLine(num2);
    } else {
        Console.WriteLine(num3);
    }
}
//==================================================================================================================


// Exercise 3
//==============
void exerciseP6_3() {
    char ch;
    Console.WriteLine("enter a char :");
    ch = char.Parse(Console.ReadLine());
    if (ch >= 'A' && ch <= 'Z' ) {
        Console.WriteLine("the char is big");
    } else if (ch >= 'a' && ch <= 'z') {
        Console.WriteLine("the char is small");
    } else {
        Console.WriteLine("the char is not a letter");
    }

}
//==================================================================================================================


// Exercise 4
//==============
void exerciseP6_4() {
    int num1;
    int num2;
    Console.WriteLine("enter a number :");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter another number :");
    num2 = int.Parse(Console.ReadLine());
    if (num1 == num2) {
        Console.WriteLine(num1 + ", " + num2 +" are the same numbers");
    } else if (num1 >= num2) {
        Console.WriteLine(num1 + ", " + num2);
    } else {
        Console.WriteLine(num2 + ", " + num1);
    }


}
//==================================================================================================================


// Exercise 5
//==============
void exerciseP6_5() {
    int num1;
    int num2;
    int num3;
    Console.WriteLine("enter your test grade :");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter your average grade of assignments :");
    num2 = int.Parse(Console.ReadLine());
    if (num1 >= 70 && num2 == 100) {
        Console.WriteLine("you meet the requirements!");
    } else if (num1 >= 90 && num2 >= 70){
        Console.WriteLine("you meet the requirements!");
    } else {
        Console.WriteLine("you  do not meet the requirements");
    }
    num3 = (70 * num1) / 100 + (30 * num2) /100;
    Console.WriteLine("your total grade is " + num3);

}
//==================================================================================================================


// Exercise 6
//==============
void exerciseP6_6() {
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
    } else if (num1 == num2 && num1 != num3) {
        Console.WriteLine("the triangle is isosceles");
    } else if (num3 == num1 && num3 != num2) {
        Console.WriteLine("the triangle is isosceles");
    } else if (num2 == num3 && num2 != num1) {
        Console.WriteLine("the triangle is isosceles");
    } else {
        Console.WriteLine("a triangle has different sides");
    }
}
//==================================================================================================================


// Exercise 7
//==============
void exerciseP6_7() {
    int num;
    Console.WriteLine("enter the car speed:");
    num = int.Parse(Console.ReadLine());
    if (num >= 90 && num <= 120) {
        Console.WriteLine("you are driving at the right speedlimit");
    } else if (num < 90) {
        Console.WriteLine("you are driving under the right speedlimit");
    } else if (num > 120) {
        Console.WriteLine("you are driving over the right speedlimit");
    }
}
//==================================================================================================================


// Exercise 8
//==============
void exerciseP6_8() {
    int speed;
    int roadNum;
    Console.WriteLine("enter the car speed :");
    speed = int.Parse(Console.ReadLine());
    Console.WriteLine("enter the road's number :");
    roadNum = int.Parse(Console.ReadLine());
    if (roadNum == 1) {
        if (speed < 30) {
            Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
        } else if (speed > 60) {
            Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
        } else {
            Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
        }
    }     
    if (roadNum == 2) {
        if (speed < 60) {
            Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
        } else if (speed > 90) {
            Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
        } else {
            Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
        }
    }
    if (roadNum == 3) {
        if (speed < 90) {
            Console.WriteLine("you are driving in road number " + roadNum + " under the right speedlimit");
        } else if (speed > 120) {
            Console.WriteLine("you are driving in road number " + roadNum + " over the right speedlimit");
        } else {
            Console.WriteLine("you are driving in road number " + roadNum + " at the right speedlimit");
        }
    }
}



exerciseP6_8();