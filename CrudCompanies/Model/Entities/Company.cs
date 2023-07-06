
namespace CrudCompanies.Model
{
    public class Company : Base
    {
        public string TaxId { get; set; }
        public string BusinessName { get; set; }
        public string Cep { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}