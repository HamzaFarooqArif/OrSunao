using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrSunao
{
    public class User
    {
        private string secretQuestion;
        private string answer;
        private string message;
        private bool isBlocked;
        private List<User> contacts;

        public string SecretQuestion
        {
            get
            {
                return secretQuestion;
            }

            set
            {
                secretQuestion = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public bool IsBlocked
        {
            get
            {
                return isBlocked;
            }

            set
            {
                isBlocked = value;
            }
        }

        public List<User> Contacts
        {
            get
            {
                return contacts;
            }

            set
            {
                contacts = value;
            }
        }
    }
}