using Google.Api;
using Google.Api.Gax.Grpc;
using Google.Cloud.Logging.V2;

Console.WriteLine("Hello, World!");

// Log to the global log in GCP using Application Default Credentials.
var loggingClient = LoggingServiceV2Client.Create();
LogEntry logEntry = new()
{
    TextPayload = "Hello GCP!",
    Resource = MonitoredResourceBuilder.GlobalResource
};
WriteLogEntriesRequest logRequest = new()
{
    LogName = "projects/gcplearning-hellogcp/logs/hellogcp"
};
logRequest.Entries.Add(logEntry);
loggingClient.WriteLogEntries(logRequest);

Console.WriteLine("Done :)");