
using DalApi;
using DO;

namespace Dal;

internal class SaleImplementation:ISale
{
    public int Create(Sale s)
    {
        Sale sale = s with { Id = DataSource.Config.SaleCode };
        if (sale.Id == 100)
        {
            DataSource.Sales.Add(sale);
            return sale.Id; 
        }
        foreach (var item in DataSource.Sales)
        {
            if (item.Id == sale.Id)
                throw new Exception(" המבצע כבר קיים במערכת. ");
        }
        DataSource.Sales.Add(sale);
        return sale.Id;
    }

    public Sale Read(int id)
    {
        foreach (var item in DataSource.Sales)
        {
            if (item.Id == id)
               return item;
        }
        throw new Exception("המבצע אינו קיים במערכת.");
    }

    public List<Sale> ReadAll()
    {
        List<Sale> list = new List<Sale>(DataSource.Sales);
        return list;
    }

    public void Delete(int id)
    {
        
        foreach (var item in DataSource.Sales)
        {
            if (item.Id == id)
            {
                DataSource.Sales.Remove(item);
                return;
            }

        }
        throw new Exception("המבצע אינו קיים במערכת.");
    }

    public void Update(Sale s)
    {

        foreach (var item in DataSource.Sales)
        {
            if (item.Id == s.Id)
            {
                DataSource.Sales.Remove(item);
                DataSource.Sales.Add(s);
                return;
            }

        }
        throw new Exception("המבצע אינו קיים במערכת.");
    }


}
