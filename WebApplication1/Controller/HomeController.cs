using Microsoft.AspNetCore.Mvc;
using RoutingTVH.Http;
using RoutingTVH.Router;


namespace WebApplication1.Controller;

public class HomeController:ControllerBasic
{
    public View Index()
    {
        return new View("Index");
    }
    
}