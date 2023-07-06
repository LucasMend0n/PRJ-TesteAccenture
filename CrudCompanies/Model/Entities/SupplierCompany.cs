namespace CrudCompanies.Model
{
    public class SupplierCompany
    {
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
    }
}