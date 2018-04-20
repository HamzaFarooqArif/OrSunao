using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrSunao
{
    public class Admin : Person
    {
        public bool SuspendUser(User u)
        {
            return false;
        }

        public bool ApproveRegistration(User u)
        {
            return false;
        }

        public bool ApproveToChat(User u)
        {
            return false;
        }
        public bool ViewRecord(User u)
        {
            return false;
        }

        public bool UpdateRecord(User u)
        {
            return false;
        }










    }
}