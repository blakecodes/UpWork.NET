using Microsoft.Extensions.Configuration;
using UpWork.NET.Tests.Models;

namespace UpWork.NET.Tests;

public class TestsBase
{
    private static IConfiguration Configuration { get; set; }
    public static UnitTestConfig Config { get; set; }

    protected TestsBase()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

        Configuration = builder.Build();
        
        Config = new UnitTestConfig();
        
        Configuration.GetSection("UpWorkNET").Bind(Config);
    }
}