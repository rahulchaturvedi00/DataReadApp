// See https://aka.ms/new-console-template for more information
using DataReadApp.ClientServices;
using Microsoft.Extensions.DependencyInjection;

// Create a service collection
var services = new ServiceCollection();

// Register services
services.AddScoped<IClientService, ClientService>();

// Build the service provider
var serviceProvider = services.BuildServiceProvider();

// Get command-line arguments
var command = args.Length > 0 ? args[0] : string.Empty;
var clientName = args.Length > 1 ? args[1] : string.Empty;
var clientPath = args.Length > 2 ? args[2] : string.Empty;

if (command == "import")
{
    // Use dependency injection to resolve the service
    var clientService = serviceProvider.GetRequiredService<IClientService>();
    clientService.DataRetriever(clientName, clientPath);
}
else
{
    Console.WriteLine("Invalid command.");
}