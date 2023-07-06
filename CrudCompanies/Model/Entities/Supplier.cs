namespace CrudCompanies.Model
{
    public class Supplier : Base
    {
        public string TaxId { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public List<Company> Companies { get; set; }
    }
}