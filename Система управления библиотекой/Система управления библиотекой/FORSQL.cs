using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    internal class ForSQL
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADCLG1; Initial catalog = УП_Buturlakin_Bogdan419/6; Integrated Security = True");
        /// <summary>
        /// Открытие связи с бд
        /// </summary>
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        /// <summary>
        /// Закрытие связи с бд
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        /// <summary>
        /// Возвращает строку подключения
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
        /// <summary>
        /// Введние запроса
        /// </summary>
        /// <returns></returns>
        public void SQLcommand(string queryString)
        {
            openConnection();
            SqlCommand command = new SqlCommand(queryString, getConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }
    }
}
