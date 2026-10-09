using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDuLich.Data
{
    public sealed class Db
    {
        public string ConnectionString { get; private set; }
        public Db() : this(ConfigurationManager.ConnectionStrings["DuLich"] == null ? "Data Source=.;Initial Catalog=QuanLyDuLich_LAB5;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=5" : ConfigurationManager.ConnectionStrings["DuLich"].ConnectionString) { }
        public Db(string connectionString) { ConnectionString = connectionString; }
        public SqlConnection Open()
        {
            var c = new SqlConnection(ConnectionString);
            try { c.Open(); using (var q = new SqlCommand("SET ANSI_NULLS ON; SET ANSI_PADDING ON; SET ANSI_WARNINGS ON; SET ARITHABORT ON; SET CONCAT_NULL_YIELDS_NULL ON; SET QUOTED_IDENTIFIER ON; SET NUMERIC_ROUNDABORT OFF;",c)) q.ExecuteNonQuery(); return c; } catch { c.Dispose(); throw; }
        }
        public static SqlParameter P(string name, object value) { return new SqlParameter(name, value ?? DBNull.Value); }
        public static SqlCommand Command(SqlConnection c, SqlTransaction tx, string sql, params SqlParameter[] parameters)
        {
            var q = new SqlCommand(sql, c, tx) { CommandTimeout = 15 };
            q.Parameters.AddRange(parameters); return q;
        }
        public DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var c = Open()) using (var q = Command(c, null, sql, parameters))
            using (var a = new SqlDataAdapter(q)) { var t = new DataTable(); a.Fill(t); return t; }
        }
        public int Execute(string sql, params SqlParameter[] parameters)
        { using (var c = Open()) using (var q = Command(c, null, sql, parameters)) return q.ExecuteNonQuery(); }
        public DataTable Procedure(string name, params SqlParameter[] parameters)
        {
            using (var c = Open()) using (var q = Command(c, null, name, parameters))
            {
                q.CommandType = CommandType.StoredProcedure;
                using (var a = new SqlDataAdapter(q)) { var t = new DataTable(); a.Fill(t); return t; }
            }
        }
        public T Transaction<T>(Func<SqlConnection, SqlTransaction, T> work)
        {
            using (var c = Open()) using (var tx = c.BeginTransaction(IsolationLevel.Serializable))
            { try { var result = work(c, tx); tx.Commit(); return result; } catch { try { tx.Rollback(); } catch { } throw; } }
        }
    }
}
