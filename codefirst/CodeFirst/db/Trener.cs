using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst.db;

public partial class Trener
{
    
    public int IdTrenera { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public virtual ICollection<Druzyna> Teams { get; set; } = new List<Druzyna>();
}
