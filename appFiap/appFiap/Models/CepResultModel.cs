using System;
using Newtonsoft.Json;

namespace appFiap
{
	public class CepResultModel
	{
		public CepResultModel()
		{
		}

		public string cep { get; set; }

		[JsonProperty("logradouro")]
		public string rua { get; set; }

		public string complemento { get; set; }

		public string bairro { get; set; }

		[JsonProperty("localidade")]
		public string cidade { get; set; }

		[JsonProperty("uf")]
		public string estado { get; set; }
	}
}

