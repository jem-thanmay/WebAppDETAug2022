using System.ComponentModel.DataAnnotations;

namespace WebAPI_2022.Models
{

    
        public class Pizza
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public bool IsGlutenFree { get; set; }
        }
       
}


