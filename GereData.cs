using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    class GereData
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        SqlConnection connection ;
        SqlCommand command ;
        internal IEnumerable<SqlDataReader> GetData(string query)
        {
            SqlDataReader reader=null;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                reader=command.ExecuteReader();
            }catch(SqlException e)
            {
                MessageBox.Show($"Error : {e.Message}");
               
            }
            if (reader != null)
            {
                while (reader.Read())
                {
                    yield return reader;
                }
                reader.Close();
            }
            connection.Close();
        }
        internal string Ajouter(string query)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }catch(SqlException e)
            {
                return $"Error : {e.Message}";
            }
            finally
            {
                connection.Close();
            }
            return "Ajout a ete effectuee";
        }
        internal string Supprimer(string query)
        {
            int nombreLigneEffecter = 0;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                nombreLigneEffecter = command.ExecuteNonQuery();
            }catch(SqlException e)
            {
                return $"Error : {e.Message}";
            }
            finally
            {
                connection.Close();
            }
            if (nombreLigneEffecter == 0)
                return "aucun ligne a ete suppreme";
            return "La suppression a ete effectuee";
        }
        internal string Modifier(string query)
        {
            int nombreLigneEffecter = 0;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                nombreLigneEffecter = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return $"Error : {e.Message}";
            }
            finally
            {
                connection.Close();
            }
            if (nombreLigneEffecter == 0)
                return "aucun ligne a ete Modifiee";
            return "La Modification a ete effectuee";
        }
    }
}
