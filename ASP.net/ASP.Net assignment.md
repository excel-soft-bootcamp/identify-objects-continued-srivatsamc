# Asp.net routing
 * ASP.NET introduced Routing to eliminate the needs of mapping each URL with a physical file. 
 * Routing enables us to define a URL pattern that maps to the request handler.
 * This request handler can be a file or class.
 * For example, http://accounts/login can be mapped to http://accounts/login.aspx in ASP.NET Webforms, and the same URL can be mapped to Accounts Controller and login action method in MVC.


       public class RouteConfig
       {
          public static void RegisterRoutes(RouteCollection routes)
          {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{message}"
            )
          }
        }

# Route Defaults     
 * The ASP.NET MVC framework comes with a default route. The template also displays the property names of the route attributes, so it is easier for a beginner's to understand. 
 * Every route has a unique name. The name of the default route is Default. The url attribute describes the pattern of the url. 
  
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        routes.MapRoute(
        name: "Default",
        url: "Controller/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },        
        );


# Route Contraints
 * We can apply restrictions on the value of the parameter by configuring route constraints. For example, the following route applies a limitation on the id parameter that the id's value must be numeric.
 
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        routes.MapRoute(
        name: "Student",
        url: "student/{id}/{name}/{standardId}",
        defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional },
        constraints: new { id = @"\d+" }
        );

# ViewData VS ViewBag
 *  ViewData and ViewBag are used for the same purpose ie, to transfer data from controller to view.

    | ViewData | ViewBag | 
    | -------- | ------- |
    | It is a type of dictionary object.| It is a type of dynamic object.| 
    | was introduced in MVC 1.0 version. | was introduced in MVC 3.0 version. |
    | Need to do type conversion of code while enumerating. | no need to do type conversion while enumerating. |

# ActionResults in asp.net mvc
 * Types of Action Results
  -  **View Result** :   is a basic view result. It returns basic results to view page. View result can return data to view the page through which class is defined in the model. 
        
         public ViewResult About() 
         { 
            ViewBag.Message = "Your application description page."; 
            return View();   
         }

  - **Partial View Result** : Partial View Result is returning the result to a Partial view page. Partial view is one of the views that we can call inside the Normal view page.

        public PartialViewResult Index() 
        { 
            return PartialView("_PartialView"); 
        }

  - **Redirect Result** : Redirect result is returning the result to the specific URL. It is rendered to the page by URL. If it gives the wrong URL, it will show 404-page errors.
 
        public RedirectResult Index() 
        { 
            return Redirect("Home/Login"); 
        }

  - **Redirect To Action Result** : Redirect to Action result is returning the result to a specified controller and action method. The controller name is optional in Redirect to the Action method. If not mentioned, Controller name redirects to a mentioned action method in the current Controller. 

        public ActionResult Index() 
        { 
            return RedirectToAction("Login", "Account"); 
        }

  - **Json Result** : Json result is a significant Action Result in MVC. It will return simple text file format and key-value pairs. If we call the action method, using Ajax, it should return Json result.

        public ActionResult Index() 
        { 
            var persons = new List<Person1> 
            { 
                new Person1{Id=1, FirstName="Harry", LastName="Potter"}, 
                new Person1{Id=2, FirstName="James", LastName="Raj"} 
            }; 
           return Json(persons, JsonRequestBehavior.AllowGet); 
        }

  - **File Result** : File Result returns different file format view page when we implement file download concept in MVC using file result. Simple examples for file result are shown below:
   
        public ActionResult Index() 
        { 
            return File("Web.Config", "text"); 
        }

  - **Content Result** : The content result returns different content's format to view. MVC returns different format using content return like HTML format, Java Script format, and any other format.

        public ActionResult Contact() 
        { 
            ViewBag.Message = "Your contact page.";       
            return View(); 
        }
 







