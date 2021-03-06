﻿using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        public string Animal { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public int Stock { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrecioDecimal { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Imagen { get; set; }
    }
}