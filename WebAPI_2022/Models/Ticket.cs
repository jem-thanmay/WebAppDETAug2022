namespace WebAPI_2022.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string BookedBy { get; set; }    
        public string EventTitle { get; set; }  
        public int NofTickets { get; set; }
        public int Cost  { get; set; }
        public int Discount { get; set; }
    }
}
