
using DalApi;
using DO;

namespace Dal;

internal class CustomerImplementation:ICustomer
{
    public int Create(Customer cus)
    {
      
        foreach (var c in DataSource.customers)
        {
            if (c.Id == cus.Id)
                throw new Exception(" הלקוח כבר קיים במערכת. ");
        }
        DataSource.customers.Add(cus);
        return cus.Id;
    }

    public Customer Read(int id)
    {
        foreach (var c in DataSource.customers)
        {
            if (c.Id == id)
                return c;
        }
        throw new Exception("הלקוח אינו קיים במערכת.");
    }

    public List<Customer> ReadAll()
    {
        List<Customer> list = new List<Customer>(DataSource.customers);
        return list;
    }

    public void Delete(int id)
    {

        foreach (var c in DataSource.customers)
        {
            if (c.Id == id)
            {
                DataSource.customers.Remove(c);
                return;
            }

        }
        throw new Exception("הלקוח אינו קיים במערכת.");
    }

    public void Update(Customer cus)
    {

        foreach (var c in DataSource.customers)
        {
            if (c.Id == cus.Id)
            {
                DataSource.customers.Remove(c);
                DataSource.customers.Add(cus);
                return;
            }

        }
        throw new Exception("הלקוח אינו קיים במערכת.");
    }

}
