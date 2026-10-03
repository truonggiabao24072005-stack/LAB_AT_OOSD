using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace QuanLyBanHang {
 public class Db {
  public readonly string ConnectionString;
  public Db(){ConnectionString=ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;}
  public SqlConnection Open(){
   var c=new SqlConnection(ConnectionString);
   try { c.Open(); using(var q=new SqlCommand("SET ANSI_NULLS ON; SET ANSI_PADDING ON; SET ANSI_WARNINGS ON; SET ARITHABORT ON; SET CONCAT_NULL_YIELDS_NULL ON; SET QUOTED_IDENTIFIER ON; SET NUMERIC_ROUNDABORT OFF;",c))q.ExecuteNonQuery(); return c; }
   catch { c.Dispose(); throw; }
  }
  public static SqlParameter P(string n,object v){return new SqlParameter(n,v??DBNull.Value);}
  public static SqlCommand Cmd(SqlConnection c,SqlTransaction t,string sql,params SqlParameter[] ps){
   var q=new SqlCommand(sql,c,t);q.Parameters.AddRange(ps);return q;}
  public DataTable Query(string sql,params SqlParameter[] ps){
   using(var c=Open())using(var q=Cmd(c,null,sql,ps))using(var a=new SqlDataAdapter(q)){
    var t=new DataTable();a.Fill(t);return t;}}
  public int Execute(string sql,params SqlParameter[] ps){
   using(var c=Open())using(var q=Cmd(c,null,sql,ps))return q.ExecuteNonQuery();}
 }
}
