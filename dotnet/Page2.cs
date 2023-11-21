
class Page2 {

    // Exercise 1
    // =============
    public void exerciseP2_1() {
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
    public void exerciseP2_2() {
        int integer;
        Console.WriteLine("enter a two digit number:");
        integer = int.Parse(Console.ReadLine());
        int theNumOfUnits = integer % 10;
        int theNumOfTens = integer / 10;
        Console.WriteLine($"the sum of the digits of the number {integer} is {theNumOfUnits + theNumOfTens}.");
    }


    // Exercise 6
    //=============
    public void exerciseP2_6() {
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

}
