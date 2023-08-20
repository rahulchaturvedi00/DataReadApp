// See https://aka.ms/new-console-template for more information
using DataReadApp;



var command = Environment.GetCommandLineArgs()[1];
var clientName = Environment.GetCommandLineArgs()[2];
var clientPath = Environment.GetCommandLineArgs()[3];

if (command == "import")
{ 
    IClientService clientService = new ClientService();
    clientService.DataRetriever(clientName, clientPath);
}