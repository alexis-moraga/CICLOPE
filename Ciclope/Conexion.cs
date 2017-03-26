using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
namespace Ciclope
{
    class Conexion
    {
        MySqlConnecion Con = new MySqlConnecion("server=localhost; database=ciclope; uid=root; pwd=");
    public void Cone(){

            try
            {
                Con.Open();
                MessageBox.Show("Conexion Realizada con exito");
            }
            catch (MySqlExeption ex)
            {
                MessageBox.Show("Error de Conexion");
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
