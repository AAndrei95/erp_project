using Digital_Shop_Software.Repositories;

namespace Digital_Shop_Software.Services
{
    internal class SupplierService
    {
        private readonly SupplierRepository supplierRepository;

        public SupplierService()
        {
            supplierRepository = new SupplierRepository();
        }

        public List<Dictionary<string, object>> GetSuppliers()
        {
            return supplierRepository.GetSuppliers();
        }

        public void AddSupplier(
            string supplierName,
            string description,
            string email,
            string phoneNumber,
            string representative)
        {
            supplierRepository.AddSupplier(
                supplierName,
                description,
                email,
                phoneNumber,
                representative);
        }

        public void RemoveSupplier(int supplierId)
        {
            supplierRepository.RemoveSupplier(supplierId);
        }

        public void ModifySupplier(
            int supplierId,
            object supplierName,
            object description,
            object email,
            object phoneNumber,
            object representative)
        {
            supplierRepository.ModifySupplier(
                supplierId,
                supplierName,
                description,
                email,
                phoneNumber,
                representative);
        }
    }
}
