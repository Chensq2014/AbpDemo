using Microsoft.AspNetCore.Builder;
using Parakeet.Net;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<NetWebTestModule>();

public partial class Program
{
}
