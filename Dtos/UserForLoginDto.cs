using System.ComponentModel.DataAnnotations;

namespace FINLOGIX.API.Dtos
{
    public class UserForLoginDto
    {

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}