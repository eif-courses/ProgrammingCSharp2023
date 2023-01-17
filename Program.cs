// See https://aka.ms/new-console-template for more information

//https://methodpoet.com/liskov-substitution-principle/ 


// Barbara Liskov first introduced the Liskov Substitution Principle (LSP) in 1987.
// It says that in a hierarchy, if S, a subtype of T, is used in place of type T,
// then type S must be usable in every place where T is specified and behave in the same way.


//Subclass should implement all classes of the base class.
//This means there should be no methods that throw NotImplementedException.
//This was explained in more detail in the post about the Interface Segregation design principle.
//

//Overridden method of the parent class should accept the same parameters in the child class.
//For example, you have a method CalculateSquare in the parent class that takes an int as a parameter.
//This means you can’t specify the same method in the child class, override it with the keyword new, and create an additional rule that will check that the number is not negative.
//If you try to pass -3 in the client code but use the child class instead of the superclass, the client code will get the exception.
//And that’s not the behavior that was intended by the base class.

using ProgrammingCSharp2023.Composition;
using ProgrammingCSharp2023.LiskovSubstition.Example1;


class Program
{
    static void Main()
    {
        var bear = new Monster{ Name = "Bear"};
        bear.Walk();
        bear.Attack();

        var eagle = new FlyingMonster { Name = "Eagle"};
        eagle.Walk();
        eagle.Attack();
        eagle.Fly();

        var shark = new SwimmingMonster { Name = "Shark" };
        shark.Walk();
        shark.Attack();
        shark.Swim();

        //Rectangle rectangle = new Rectangle
        //{
        //    Width = 7,
        //    Height = 6
        //};
        //Console.WriteLine(rectangle.GetArea()); //output is 42

        //rectangle = new Square
        //{
        //    Width = 7,
        //    Height = 6
        //};
        //Console.WriteLine(rectangle.GetArea()); //output is 49

        //Shape rectangleFixed = new RectangleFixed
        //{
        //    Width = 7,
        //    Height = 6
        //};
        //Console.WriteLine(rectangleFixed.GetArea()); //output is 42

        //rectangleFixed = new SquareFixed
        //{
        //    Width = 7,
        //    Height = 6
        //};
        //Console.WriteLine(rectangleFixed.GetArea()); //output is 49

        //var duck = new Duck();
        //var penguin = new Penguin();

        //makeBirdFly(duck);
        //makeBirdFly(penguin);

    }
    static void makeBirdFly(Bird bird)
    {
        bird.Fly();
    }
}




