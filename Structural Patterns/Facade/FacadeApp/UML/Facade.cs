using FacadeApp.UML.SubSystem1;
using FacadeApp.UML.SubSystem2;
using FacadeApp.UML.SubSystem3;

namespace FacadeApp.UML;

public class Facade
{
    public void DoSomething()
    {
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();
        Class3 class3 = new Class3();

        class1.Action1();
        class2.Action2();
        class3.Action3();
    }
}