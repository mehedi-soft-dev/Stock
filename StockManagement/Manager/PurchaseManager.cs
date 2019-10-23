using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public bool AddPurchase(List<Purchase> purchases)
        {
            bool isAdded=false;
            foreach (Purchase purchase in purchases)
            {
                isAdded = _purchaseRepository.AddPurchase(purchase);
            }

            return isAdded;
        }

        public Purchase LastPurchaseInfo(int productId)
        {
            return _purchaseRepository.LastPurchaseInfo(productId);
        }

        public int AvailableQuantity(int productId)
        {
            return _purchaseRepository.AvailableQuantity(productId);
        }
    }
}
