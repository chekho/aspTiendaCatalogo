using System;
using System.Collections.Generic;

namespace examen2.Models;

public partial class Producto
{
    public Guid Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? Dimensionx { get; set; }

    public int? Dimensiony { get; set; }

    public string? Material { get; set; }

    public int? Relleno { get; set; }

    public bool? Lowpolly { get; set; }
}
