using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteJuegos.Models
{
    public class ListaPedidos
    {
        [JsonProperty("IDPEDIDO")]
        public int IdPedido { get; set; }
        [JsonProperty("PRECIO")]
        public int Precio { get; set; }
        [JsonProperty("FECHA")]
        public DateTime Fecha { get; set; }
        [JsonProperty("IDCLIENTE")]
        public int IdCliente { get; set; }
        [JsonProperty("TITULO")]
        public string Titulo { get; set; }
        [JsonProperty("IDJUEGO")]
        public int IdJuego { get; set; }
        [JsonProperty("TOTAL")]
        public int Total { get; set; }
    }
}





 
 





