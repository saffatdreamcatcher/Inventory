﻿using System;

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

    private string supplierid;
    public string SupplierId { get => supplierid; set => supplierid = value; }

    private string categoryid;
    public string CategoryId { get => categoryid; set => categoryid = value; }

    private string quantity;
    public string Quantity { get => quantity; set => quantity = value; }

    private double unitprice;
    public double UnitPrice { get => unitprice; set => unitprice = value; }

    private int unitinstock;
    public int UnitInStock { get => unitinstock; set => unitinstock = value; }

    private int unitsonorder;
    public int UnitsOnOrder { get => unitsonorder; set => unitsonorder = value; }

    private int reorderlevel;
    public int ReorderLevel { get => reorderlevel; set => reorderlevel = value; }

    private bool discontinued;
    public bool Discontinued { get => discontinued; set => discontinued = value; }
    }
}
