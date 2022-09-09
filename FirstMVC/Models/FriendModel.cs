using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class FriendModel
    {
        public int FriendID { get; set; }

        [Required]
        public string FName { get; set; }
        public string FPlace { get; set; }
        
    }
}

