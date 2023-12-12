using ChainOfResponsibilitiApp.SnapExample;

CreateOrder createOrder = new CreateOrder();
SendOrderToDrivers sendOrderToDrivers = new SendOrderToDrivers();
CheckUserActivity checkUserActivity = new CheckUserActivity();

checkUserActivity
    .SetSuccessor(createOrder)
    .SetSuccessor(sendOrderToDrivers);

checkUserActivity.Handle(new RequestContext
{
    UserId = 1,
    Origin = new Point { Lat = 51.365, Lng = 25.145},
    Destination = new Point { Lat = 14.658, Lng = 780}
});

Console.Read();