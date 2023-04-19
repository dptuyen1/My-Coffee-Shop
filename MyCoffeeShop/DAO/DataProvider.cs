using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MyCoffeeShop.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private DataProvider() { }

        private string path = "Data Source=.;Initial Catalog=MyCoffeeShopDB;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] objects = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(path))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (objects != null)
                {
                    string[] parameters = query.Split(' ');
                    int i = 0;

                    foreach (string param in parameters)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, objects[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                conn.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] objects = null)
        {
            int dt = 0;

            using (SqlConnection conn = new SqlConnection(path))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (objects != null)
                {
                    string[] parameters = query.Split(' ');
                    int i = 0;

                    foreach (string param in parameters)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, objects[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteNonQuery();

                conn.Close();
            }

            return dt;
        }

        public object ExecuteScalar(string query, object[] objects = null)
        {
            object dt = null;

            using (SqlConnection conn = new SqlConnection(path))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (objects != null)
                {
                    string[] parameters = query.Split(' ');
                    int i = 0;

                    foreach (string param in parameters)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, objects[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteScalar();

                conn.Close();
            }

            return dt;
        }
    }
}
