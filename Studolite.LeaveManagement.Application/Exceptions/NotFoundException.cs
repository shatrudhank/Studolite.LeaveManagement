using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Exceptions
{
    public class NotFoundException: Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message,Exception exception):base(message, exception) { }

        public NotFoundException(string name,int key):base($"{key} not found for {name}") { }

    }
}
 