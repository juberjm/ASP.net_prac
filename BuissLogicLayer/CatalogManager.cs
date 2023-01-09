namespace BuissLogicLayer;
using BuissObjLayer;
using DataAccessLayer;

public class CatalogManager
{
    public List<prod> getAllProduct(){
        List<prod> AllProds = new List<prod>();
        AllProds=new DatabaseManager.getAllProduct();
        return AllProds;
    }

    public prod GetProduct(int id){
        List<prod> allProducts=getAllProducts();
        prod foundProd=allProducts.Find((prod)=>prod.productId == id);
        return foundProd;

    }

}
