// Peter Young
// itse 1430
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        private readonly string _connectionString;

        public SqlProductDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }
        protected override Product AddCore ( Product product )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("AddProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //@name, @price, @description, @isDiscontinued
                cmd.Parameters.AddWithValue ("@name", product.Name);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@isDiscontinued", product.IsDiscontinued);

                conn.Open ();
                var result = (decimal)cmd.ExecuteScalar ();
                product.Id = Convert.ToInt32 (result);

                return product;
            };
        }
        protected override IEnumerable<Product> GetAllCore ()
        {
            var ds = new DataSet ();


            using (var conn = CreateConnection ())
            {
                using (var cmd = conn.CreateCommand ())
                {
                    cmd.CommandText = "GetAllProducts";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter () {
                        SelectCommand = cmd
                    };

                    da.Fill (ds);
                };
            };

            var table = ds.Tables.OfType<DataTable> ().FirstOrDefault ();
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow> ())
                {
                    var product = new Product () {
                        Id = (int)row[0],
                        Name = row["Name"] as string,
                        Description = row.Field<string> ("Description"),
                        Price = row.Field<decimal> ("Price"),
                        IsDiscontinued = row.Field<bool> ("IsDiscontinued"),
                    };

                    yield return product;
                };
            };
        }
        protected override Product GetCore ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("AddProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@id", id);
                conn.Open ();
                using (var reader = cmd.ExecuteReader ())
                {
                    if (reader.Read ())
                    {

                        var product = new Product () {
                            Id = reader.GetInt32 (0),
                            Name = reader.GetString (1),
                            Description = !reader.IsDBNull (3) ? reader.GetString (3) : "",
                            Price = reader.GetDecimal (2),
                            IsDiscontinued = reader.GetBoolean (4),
                        };
                        return product;
                    }
                }               
            }
            return null;
        }
        protected override void RemoveCore ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("RemoveProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@id", id);
                conn.Open ();
                cmd.ExecuteNonQuery ();
            }
        }
        protected override Product UpdateCore ( Product existing, Product newItem ) 
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("UpdateProduct", conn))
            {
                newItem.Id = existing.Id;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@id", newItem.Id);
                cmd.Parameters.AddWithValue ("@name", newItem.Name);
                cmd.Parameters.AddWithValue ("@price", newItem.Price);
                cmd.Parameters.AddWithValue ("@description", newItem.Description);
                cmd.Parameters.AddWithValue ("@isDiscontinued", newItem.IsDiscontinued);

                conn.Open ();
                cmd.ExecuteNonQuery ();

                return newItem;
            }
        }
        private SqlConnection CreateConnection ()
        {
            SqlConnection conn = new SqlConnection (_connectionString);
            return conn;
        }
    }
}
