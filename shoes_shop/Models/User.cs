using System;
using System.Collections.Generic;

namespace shoes_shop.Models;

public partial class Users
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

    public string FullName => $"{LastName} {FirstName} {MiddleName}";
}
