using System;
using System.Collections.Generic;

namespace CodeFirst.db;

public partial class Ligi
{
    public int IdLigi { get; set; }

    public string Nazwa { get; set; } = null!;

    public int IdDruzyny { get; set; }

    public virtual Druzyna IdDruzynyNavigation { get; set; } = null!;
}
