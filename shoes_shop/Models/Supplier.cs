using System;
using System.Collections.Generic;

namespace shoes_shop.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
