using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using vanado.Models;

namespace vanado.DAO
{
    public class StrojRepository : IStrojRepository
    {
        public void AzurirajStroj(int strojId, Stroj stroj)
        {

            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=TimeManagement"))
            {
                connection.Open();
                string query = "update stroj set naziv=@naziv, opis=@opis, datoteka=@Datoteka, status=@Status, vrijemePrijave=@VrijemePrijave, stroj=@Stroj where id=strojId";


                connection.Execute(query);

            }
        }

        public IEnumerable<Stroj> DohvatiSveStrojeve()
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=TimeManagement"))
            {
                connection.Open();
                string query = "select id, naziv from stroj";
                IEnumerable<Stroj> strojevi = connection.Query<Stroj>(query).ToList();
                return strojevi; 


            }
        }

        public void IzbrisiStroj(int id)
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=TimeManagement"))
            {
                connection.Open();
                connection.Execute("delete from stroj where id = @id");
            }
        }
    }
}
