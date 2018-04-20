using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrSunao
{
    public class User: Person
    {
        private string secretQuestion;
        private string answer;
        private string message;
        private bool isBlocked;
        private List<User> contacts;

        public bool registeruser(string firstname, string lastname,string password, string email, string contact, string cnic, string secretq, string ans)
        {
            if (UserDl.orSunaoMembers != null)
            {
                foreach (User k in UserDl.orSunaoMembers)
                {
                    if (k.Email == email && k.Password == password)
                    {
                        return false;
                    }
                }
            }
          
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Password = password;
            this.Email = email;
            this.ContactNumber = contact;
            this.CNIC = cnic;
            this.SecretQuestion = secretq;
            this.Answer = ans;
            UserDl.orSunaoMembers.Add(this);
            return true;
        }
        public bool loginuser(string email, string password)
        {
            foreach (User u in UserDl.orSunaoMembers)
            {
                if (u.Password == password && u.Email == email)
                {
                    this.FirstName = u.FirstName;
                    this.LastName = u.LastName;
                    this.Password = u.Password;
                    this.Email = u.Email;
                    this.ContactNumber = u.ContactNumber;
                    this.CNIC = u.CNIC;
                    this.SecretQuestion = u.SecretQuestion;
                    this.Answer = u.Answer;
                    return true;
                }
            }
            return false;
        }
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