var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// home page:             GET     /
// get all products:      GET     /products
// get one product:       GET     /products/1
// create new product:    POST    /products
// edit a product:        PUT     /products/1
// delete a product:      DELETE  /products/1

////////////////////Minimal APIs////////////////////////////
//app.MapGet("/", () => "Home page!");
//app.MapGet("/products", () => "Show all products!");
//app.MapGet("/products/{id}", (string id) => $"Product id is {id}");
//app.MapPost("/products", () => "Create a new product");
//app.MapPut("/products/{id}", (string id) => $"Edit product, id is {id}");
//app.MapDelete("/products/{id}", (string id) => $"Delete product, id is {id}");

//app.MapGet("/", (HttpContext context) =>
//{
//    //string path = context.Request.Path;
//    //string method = context.Request.Method;

//    //return "Request path: " + path + " Http Method: " + method;

//    //var Accept = "";
//    //if (context.Request.Headers.ContainsKey("Accept"))
//    //{
//    //    Accept = context.Request.Headers["Accept"];
//    //}
//    //return Accept;

//    //return "This is a response";

//    //context.Response.Headers["Content-Type"] = "text/html";
//    //return "<h2>This is a response</h2>";

//});

///////////////////////////Custom Middleware Routing/////////////////////
// home page:             GET     /
// get all products:      GET     /products
// get one product:       GET     /products?id=1
// create new product:    POST    /products
// edit a product:        PUT     /products?id=1
// delete a product:      DELETE  /products?id=1
app.Use(async(context, next) =>
{
    if (context.Request.Path == "/")
    {
        await context.Response.WriteAsync("Home page!");
    }
    else if (context.Request.Method == "GET" && context.Request.Path == "/products") 
    {
        if (context.Request.Query.ContainsKey("id"))
        {
            await context.Response.WriteAsync($"Product id is {context.Request.Query["id"]}");
        }
        else
        {
            await context.Response.WriteAsync("Show all products!");
        }
        
    }
    else if (context.Request.Method == "POST" && context.Request.Path == "/products")
    {
        await context.Response.WriteAsync("Create a new product!");
    }
    else
    {
        await next();
    }
});

app.Run();
