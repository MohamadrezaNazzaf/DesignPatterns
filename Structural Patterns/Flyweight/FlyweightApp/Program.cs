using FlyweightApp.UML;

FlyweightFactory factory = new FlyweightFactory();

var obj1 = factory.GetFlyweight("Test1");
var obj2 = factory.GetFlyweight("Test2");
var obj3 = factory.GetFlyweight("Test1");

obj1.Operation("sample 1 extrisic state.");
obj2.Operation("sample 2 extrisic state.");
obj3.Operation("sample 3 extrisic state.");

UnSharedConcreteFlyweight flyweights = new UnSharedConcreteFlyweight(new Flyweight[]
{
    factory.GetFlyweight("Test1"),
    factory.GetFlyweight("Test2"),
    factory.GetFlyweight("Test3"),
    factory.GetFlyweight("Test4"),
});

flyweights.Operation("extrinsic ---> UnSharedConcreteFlyweight");

Console.ReadKey();
