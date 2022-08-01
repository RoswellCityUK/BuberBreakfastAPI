using BuberBreakfastAPI.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    //builder.Services.AddSingleton<IBreakfastService, BreakfastService>();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    //builder.Services.AddTransient<IBreakfastService, BreakfastService>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

