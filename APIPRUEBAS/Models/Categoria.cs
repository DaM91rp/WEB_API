using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIPRUEBAS.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }

        //Con JsonIgnore, al momento de enviar los datos, el campo de producto se ignora para mejorar la vista en lo que son referencias ciclicas
        [JsonIgnore]
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
