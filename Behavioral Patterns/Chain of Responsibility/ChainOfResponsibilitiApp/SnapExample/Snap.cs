
using System.Security.Principal;

namespace ChainOfResponsibilitiApp.SnapExample;


public class RequestContext
{
    public int UserId { get; set; }
    public Point Origin { get; set; }
    public Point Destination { get; set; }
}

public class Point
{
    public double Lat { get; set; }
    public double Lng { get; set; }
}

public class ResponseContext
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}

public interface IHandler
{
    IHandler SetSuccessor(IHandler handler);

    ResponseContext Handle(RequestContext request);
}

public abstract class TakeATaxiHandler : IHandler
{
    protected IHandler successor; // it is next step.

    public abstract ResponseContext Handle(RequestContext request);

    public IHandler SetSuccessor(IHandler handler)
    {
        this.successor = handler;
        return successor;
    }
}

public class CreateOrder : TakeATaxiHandler
{
    public override ResponseContext Handle(RequestContext request)
    {
        bool orderCreated = true;
        if (orderCreated)
        {
            Console.WriteLine("order created.");

            if (successor != null)
                return successor.Handle(request); //send request to next step;
        }

        return new ResponseContext()
        {
            IsSuccess = false,
            Message = "error eccurred in order create."
        };
    }
}

public class SendOrderToDrivers : TakeATaxiHandler
{
    public override ResponseContext Handle(RequestContext request)
    {
        Console.WriteLine("sended to drivers.");
        if(successor != null)
            return successor.Handle(request); //send request to next step;

        return new ResponseContext()
        {
            IsSuccess = true,
            Message = "order created and sended to drivers."
        };
    }
}

public class CheckUserActivity : TakeATaxiHandler
{
    public override ResponseContext Handle(RequestContext request)
    {
        if(request.UserId != 1)
        {
            Console.WriteLine("user not active");
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "user not active"
            };
        }
        else if(successor != null)
        {
            Console.WriteLine("user is active.");
            return successor.Handle(request);
        }
        else
        {
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "There is no step for continue."
            };
        }
    }
}