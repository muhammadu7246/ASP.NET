using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using Db_Insert.Models;

namespace Db_Insert.Controllers
{
    public class InsertController : Controller
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TestDbConnection"].ConnectionString;

        // GET: Insert
        public ActionResult DB_Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DB_Insert(Insert insert)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", insert.Name);
                    cmd.Parameters.AddWithValue("@Price", insert.Price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                return RedirectToAction("Index");
            }

            return View(insert);
        }
    }
}
