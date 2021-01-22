﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_Pruebas.Modelos
{
    public partial class DatosFiscales
    {
        [JsonProperty("Identificador")]
        public long Identificador { get; set; }

        [JsonProperty("Id_Fiscal")]
        public long IdFiscal { get; set; }

        [JsonProperty("RFC")]
        public string RFC { get; set; }

        [JsonProperty("RazonSocial")]
        public string RazonSocial { get; set; }

        [JsonProperty("UsoCFDI")]
        public string UsoCFDI { get; set; }

        [JsonProperty("CP")]
        public string CP { get; set; }

        public static List<DatosFiscales> FromJson(string json) => JsonConvert.DeserializeObject<List<DatosFiscales>>(json, Converter.Settings);
    }
}
