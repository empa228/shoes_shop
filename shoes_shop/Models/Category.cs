using System;
using System.Collections.Generic;

namespace shoes_shop;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
