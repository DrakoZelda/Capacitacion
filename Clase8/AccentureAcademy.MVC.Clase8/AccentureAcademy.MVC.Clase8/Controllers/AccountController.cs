using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccentureAcademy.MVC.Clase8.Controllers
{
    public class AccountController : Controller
    {
       public string Create(int customerId, int balanceInicial)
        {
            string cbu = Guid.NewGuid().ToString().Substring(1, 21);
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademyBank;Integrated Security=True"))
            {
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = sqlConnection;
                sql.Parameters.AddWithValue("customerId", customerId);
                sql.Parameters.AddWithValue("cbu", cbu);
                sql.Parameters.AddWithValue("balance", balanceInicial);
                sql.CommandText = $"INSERT INTO Account(CustomerID, CBU,Balance) VALUES(@customerId, @cbu, @balance)";
                sql.ExecuteNonQuery();
            }

            return $"la account se creo, su CBU es: {cbu}";

        }

        public string Transferir(string cbuOrigen, string cbuDestino, double monto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademyBank;Integrated Security=True"))
            {
                sqlConnection.Open();
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {

                    SqlCommand sqlExtraer = new SqlCommand();

                    sqlExtraer.Connection = sqlConnection;
                    sqlExtraer.Parameters.AddWithValue("cbuOrigen", cbuOrigen);
                    sqlExtraer.Parameters.AddWithValue("monto", monto);
                    sqlExtraer.CommandText = "UPDATE Account SET Balance=Balance - @monto where cbu=@cbuOrigen";
                    sqlExtraer.Transaction = tran;
                    sqlExtraer.ExecuteNonQuery();

                    SqlCommand sqlDepositar = new SqlCommand("UPDATE Account SET Balance=balance + @monto where cbu=@cbuDestino", sqlConnection, tran);

                    sqlDepositar.Parameters.AddWithValue("cbuDestino", cbuDestino);
                    sqlDepositar.Parameters.AddWithValue("monto", monto);
                    sqlDepositar.ExecuteNonQuery();

                    tran.Commit();

                    return "Money transfered Successfuly";
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    return $"Error {e.Message}";
                }
            } 

        }
    }
}