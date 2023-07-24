using System;

namespace CityInfo.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public UserDto() { }

        public UserDto(int id, string username, string password, bool isAdmin)
        {
            Id = id;
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
  
}
