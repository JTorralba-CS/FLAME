using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR;

using FLAME.WASM.Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octest-stream" });
});

builder.Services.AddSignalR(HubOptions =>
{
    HubOptions.EnableDetailedErrors = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseBlazorFrameworkFiles();
//app.UseHttpsRedirection();
//app.UseRouting();
app.UseStaticFiles();

app.MapControllers();
app.MapHub<ChatHub>("/chathub");

app.MapFallbackToFile("index.html");
app.MapRazorPages();

app.Run();
