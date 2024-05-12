//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace RegisterOfStudents.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string message);
    }
}
