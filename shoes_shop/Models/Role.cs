using System;
using System.Collections.Generic;

namespace shoes_shop.Models;

public partial class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Users> Users { get; set; } = new List<Users>();
}
////s