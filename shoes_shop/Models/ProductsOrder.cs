using System;
using System.Collections.Generic;

namespace shoes_shop;

public partial class ProductsOrder
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Products Product { get; set; } = null!;
}
