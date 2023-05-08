using System;
using System.Collections.Generic;

namespace CodeFirst.db;

public partial class Druzyna
{
    public int IdDruzyny { get; set; }

    public string Nazwa { get; set; } = null!;

    public int IdTrenera { get; set; }

    public virtual Trener IdTreneraNavigation { get; set; } = null!;

    public virtual ICollection<Ligi> Leagues { get; set; } = new List<Ligi>();

    public virtual ICollection<Pilkarze> Players { get; set; } = new List<Pilkarze>();
}
