using Microsoft.AspNetCore.Mvc;
using RoutingTVH.Http;
using RoutingTVH.Router;


namespace WebApplication1.Controller;

public class Test: ControllerBasic
{

    public JsonData a(object data = null)
    {
        return new JsonData(new {a="1"});
       
    }
    public View b(object data = null)
    {
        return new View("Index");
    }
}