var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var google = new Company("Google", 200000);
Random random = new Random();
int randomNumber = random.Next(0,101);

app.Run(async (context) =>
{
    await context.Response.WriteAsync($"name:{google.name}\nemployees: {google.employee}\n");
    await context.Response.WriteAsync($"random number:{randomNumber}");
} );
app.Run();
