using System;
using System.Collections.Generic;

namespace shoes_shop;

public partial class ProductType
{
    public int Id { get; set; }

    public string ProdType { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
