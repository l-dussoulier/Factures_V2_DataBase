using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Facturation_V2.Shared;
using Dapper;

namespace Facturation_V2.Server.Models
{
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private SqlConnection sql;

        public BusinessDataSql(string connectionString)
        {
            sql = new SqlConnection(connectionString);
        }
        public IEnumerable<Facture> lesFactures => sql.Query<Facture>("SELECT * FROM Facture ORDER BY DateReglement DESC");

        public void Add(Facture facture)
        {
            var query = @"INSERT INTO 
                Facture(Client, Numero, DateEmission, DateReglement, MontantDu, MontantRegle)
                VALUES(@Client, @Numero, @DateEmission, @DateReglement, @MontantDu, @MontantRegle);
                SELECT CAST(SCOPE_IDENTITY() as int);";
            sql.ExecuteScalar<int>(query, facture);
        }

        public void Dispose()
        {
            sql.Dispose();
        }

        public Facture GetByNumero(string numero)
        {
            var query = "SELECT * FROM Facture WHERE Numero = @numero";
            return sql.QueryFirstOrDefault<Facture>(query, new { numero = numero });
        }
    }
}
