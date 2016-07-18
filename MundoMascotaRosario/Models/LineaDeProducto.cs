﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class LineaDeProducto
    {
        public LineaDeProducto()
        {
            LineaDeProductoId = Guid.NewGuid().ToString();
        }
        [Key]
        public string LineaDeProductoId { get; set; }

        public int Cantidad { get; set; }

        public string ProductoId { get; set; }

        public decimal SubtotalDecimal { get; set; }

        public virtual Producto Producto { get; set; }
    }
}