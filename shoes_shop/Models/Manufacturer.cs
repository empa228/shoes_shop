using System;
using System.Collections.Generic;

namespace shoes_shop;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
