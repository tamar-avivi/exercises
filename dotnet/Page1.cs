
class Page1 {
    // Exercise 1
    //=============
    public void exerciseP1_1() {
        Console.WriteLine("pleas enter number of products:");
        int? numProducts = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter the price:");
        int? price = int.Parse(Console.ReadLine());
        Console.WriteLine($"number of products is {numProducts}");
        Console.WriteLine($"the price is {price}");
        Console.WriteLine($"the total price is: {numProducts * price}");
    }


    // Exercise 3
    //=============
    public void exerciseP1_3() {
        double b;
        double h;
        Console.WriteLine("enter the base:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the height:");
        h = double.Parse(Console.ReadLine());
        double area = b * h / 2;
        Console.WriteLine($"the area is: {area}");
        double scope = b * 3;
        Console.WriteLine($"the scope is: {scope}");
    }


    // Exercise 4
    // =============
    public void exerciseP1_4() {
        double price;
        int numOfStudents;
        Console.WriteLine("enter the price of one book:");
        price = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of students:");
        numOfStudents = int.Parse(Console.ReadLine());
        double totalPrice = price * numOfStudents;
        Console.WriteLine($"the total price is {totalPrice}");
    }

    // Exercise 8
    //==============
    public void exerciseP1_8() {
        double price;
        double num;
        Console.WriteLine("enter the tiket's price :");
        price = double.Parse(Console.ReadLine());
        num = (price * 0.9);
        Console.WriteLine("the price befor the sale : " + price);
        Console.WriteLine("the price after the sale : " + num);
    }
}
