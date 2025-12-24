

using DalApi;
using DO;

namespace Dal;

internal class ProductImplementation:IProduct
{
    public int Create(Product p)
    {
        Product product = p with { Id = DataSource.Config.ProductCode };
        if (product.Id == 200)
        {
            DataSource.Products.Add(product);
            return product.Id;
        }
        foreach (var item in DataSource.Products)
        {
            if (item.Id == product.Id)
                throw new Exception(" המוצר כבר קיים במערכת. ");
        }
        DataSource.Products.Add(product);
        return product.Id;
    }

    public Product Read(int id)
    {
        foreach (var item in DataSource.Products)
        {
            if (item.Id == id)
                return item;
        }
        throw new Exception("המוצר אינו קיים במערכת.");
    }

    public List<Product> ReadAll()
    {
        List<Product> list = new List<Product>(DataSource.Products);
        return list;
    }

    public void Delete(int id)
    {

        foreach (var item in DataSource.Products)
        {
            if (item.Id == id)
            {
                DataSource.Products.Remove(item);
                return;
            }

        }
        throw new Exception("המוצר אינו קיים במערכת.");
    }

    public void Update(Product s)
    {

        foreach (var item in DataSource.Products)
        {
            if (item.Id == s.Id)
            {
                DataSource.Products.Remove(item);
                DataSource.Products.Add(s);
                return;
            }

        }
        throw new Exception("המוצר אינו קיים במערכת.");
    }

}
