namespace CrudCompanies.Model
{
    public class SupplierCompanies
    {
        public int SupplierId { get; set; }
        public Supplier Suppliers { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
    }
}