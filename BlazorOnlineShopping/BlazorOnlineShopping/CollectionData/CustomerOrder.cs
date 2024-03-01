namespace BlazorOnlineShopping.CollectionData
{
    public class CustomerOrder
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    public CustomerOrder(string name, string adress, string email, string phone)
        => (Name, Adress, Email, Phone)
        = (name, adress, email, phone);
    }   


}
