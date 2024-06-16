using System;
using System.Collections.Generic;

namespace VendedoresMVC.Models;

public partial class Vendedores
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public string? Estado { get; set; }
}
