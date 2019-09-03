using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Responses
{
    public struct ValidationMessage
    {
        public string Message { get; private set; }
        public int MessageId { get; private set; }

        public ValidationMessage(string message, int messageId)
        {
            this.Message = message;
            this.MessageId = messageId;
        }
    }
}
