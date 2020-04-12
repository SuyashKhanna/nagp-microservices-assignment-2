using System.ComponentModel.DataAnnotations;

namespace User_Service.Controllers
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get;  set;}

        public string Email { get; set; }
    }
}