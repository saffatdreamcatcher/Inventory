using System;

namespace Inventory.DLL.Entities
{
  public class Product : Entity
  {
    public Product()
    {

    }

    public Product(int id, DateTime createTime) : base(id, createTime)
    {

    }

    private string name;
    public string Name { get => name; set => name = value; }
  }
}
