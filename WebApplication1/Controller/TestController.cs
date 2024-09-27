using Microsoft.AspNetCore.Mvc;
using RoutingTVH.Http;
using RoutingTVH.Method;
using RoutingTVH.Router;

namespace WebApplication1.Controller;

public class TestController: ControllerBasic
{
    [Post]
    public JsonData a(string param1, int num )
    {
        var result = new JsonData(new { a = param1, num = num },201);
        return result;
    }
  
    public View b(string objec = null)
    {
        return new View("Index");
    }
    
}