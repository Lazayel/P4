using System;
using System.Collections.Generic;

namespace CodeFirst.db;

public partial class Pilkarze
{
   
    public int IdPilkarza { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public int IdDruzyny { get; set; }

    public virtual Druzyna IdDruzynyNavigation { get; set; } = null!;
}
