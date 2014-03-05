using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;

namespace Foxpro2Sqlite
{
    public class Foxpro2Sqlite : ConvertBase
    {
        public override void Convert(int branchId)
        {
            try
            {
                using (var fpConn = new OleDbConnection(FoxproConnStr))
                {
                    fpConn.Open();

                    var productTable = new DataTable();

                    using (var adapter = new OleDbDataAdapter("SELECT * FROM product", fpConn))
                    {
                        adapter.Fill(productTable);
                    }

                    using (var sqliteConn = new SQLiteConnection(""))
                    {
                        sqliteConn.Open();

                        sqliteConn.Clone();
                    }

                    fpConn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public override bool IsSetmeal(string prodNo)
        {
            throw new NotImplementedException();
        }
    }
}
