namespace FirstMVC.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }  
        public int Qty { get; set; }
        
        public DateTime EventDate { get; set; }
    }
}
