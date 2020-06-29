using CapaDeDominio.DTOs;
using CapaDeDominio.Queries;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace CapaAccesoDatos.Queries
{
    public class QueryVenta : IQueryVenta
    {
        private readonly Compiler compiler;
        private readonly IDbConnection connection;

        public QueryVenta(Compiler compiler, IDbConnection connection)
        {
            this.compiler = compiler;
            this.connection = connection;
        }

        public async Task<List<ClienteDTOs>> GetCliente()
        {
           
            var url = "https://localhost:44368/api/Cliente";
            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var get = JsonConvert.DeserializeObject<List<ClienteDTOs>>(response);
                return get;
            }
        }
    }
}
