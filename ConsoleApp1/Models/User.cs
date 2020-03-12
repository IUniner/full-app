using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class User
    {
        public int Id { get; set; }
        [Unique]
        public string Login { get; set; }
        public string Email { get; set; }
        public UserProfile Profile { get; set; }
    }
}
