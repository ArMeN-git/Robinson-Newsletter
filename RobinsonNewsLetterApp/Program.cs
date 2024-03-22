using RobinsonNewsletter.Core.Models;
using RobinsonNewsletter.Core.ServiceExtensions;
using RobinsonNewsLetterApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpContextAccessor();
builder.Services.AddEmail(builder.Configuration);
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });


builder.Services.Configure<RubriqueImageOptions>(builder.Configuration.GetSection(nameof(RubriqueImageOptions)));
builder.Services.Configure<AdminOptions>(builder.Configuration.GetSection(nameof(AdminOptions)));
builder.Services.Configure<EmailContentOptions>(builder.Configuration.GetSection(nameof(EmailContentOptions)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
