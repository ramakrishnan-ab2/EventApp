using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EVENT_MANAGEMENT.Model
{
   public class UserLogin
    {
        [Key]
        public int Id { get;set; }
        public string Name { get;set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type {  get; set; }
    }
}
