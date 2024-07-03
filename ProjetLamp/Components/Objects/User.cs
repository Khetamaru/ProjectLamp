using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Objects
{
    public class User
    {
        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
            IsEmailConfirmed = false;
            Created = DateTime.Now;
            IsAdmin = false;
        }
        /// <summary>
        /// User Name
        /// </summary>
        private string Name { get; set; }
        public string GetName => Name;

        /// <summary>
        /// User Hashed password
        /// </summary>
        private string Password { get; set; }
        public string GetPassword => Password;

        /// <summary>
        /// User email
        /// </summary>
        private string Email { get; set; }
        public string GetEmail => Email;

        /// <summary>
        /// Is User email confirmed
        /// </summary>
        private bool IsEmailConfirmed { get; set; }
        public bool GetIsEmailConfirmed => IsEmailConfirmed;

        /// <summary>
        /// User creation date
        /// </summary>
        private DateTime Created { get; set; }
        public DateTime GetCreated => Created;

        /// <summary>
        /// Is User an admin
        /// </summary>
        private bool IsAdmin { get; set; }
        public bool GetIsAdmin => IsAdmin;
    }
}
