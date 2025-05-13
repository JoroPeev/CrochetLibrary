namespace CrochetLibrary.Models
{
    public class CustomerRequest
    {
        public int Id { get; set; }
        public string ToyName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Message { get; set; }
        public DateTime DueDate { get; set; }
    }
}
