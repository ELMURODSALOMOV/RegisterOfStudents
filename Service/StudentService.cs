using RegisterOfStudents.Broker.Logging;
using RegisterOfStudents.Broker.Storeage;
using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Service
{
    internal class StudentService : IStudentService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        public StudentService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ListStoreageBroker();
        }

        public bool Check(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
