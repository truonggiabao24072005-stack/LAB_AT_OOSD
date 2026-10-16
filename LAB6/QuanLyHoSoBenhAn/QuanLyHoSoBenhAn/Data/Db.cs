using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyHoSoBenhAn.Data {
 public sealed class Db {
  private readonly string connection;
  public Db():this(ConfigurationManager.ConnectionStrings["BenhAn"]==null?"Data Source=.;Initial Catalog=HoSoBenhAn_LAB6;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=5":ConfigurationManager.ConnectionStrings["BenhAn"].ConnectionString){}
  public Db(string value){connection=value;}
  public static SqlParameter P(string name,object value){return new SqlParameter(name,value??DBNull.Value);}
  public DataTable Query(string sql,params SqlParameter[] args){return Run(sql,CommandType.Text,args);}
  public DataTable Procedure(string name,params SqlParameter[] args){return Run(name,CommandType.StoredProcedure,args);}
  private DataTable Run(string text,CommandType type,SqlParameter[] args){
   using(var c=new SqlConnection(connection))using(var q=new SqlCommand(text,c)){
    q.CommandType=type;q.CommandTimeout=20;q.Parameters.AddRange(args);
    var t=new DataTable();using(var a=new SqlDataAdapter(q)){c.Open();
     using(var settings=new SqlCommand("SET ANSI_NULLS ON;SET ANSI_PADDING ON;SET ANSI_WARNINGS ON;SET ARITHABORT ON;SET CONCAT_NULL_YIELDS_NULL ON;SET QUOTED_IDENTIFIER ON;SET NUMERIC_ROUNDABORT OFF;",c))settings.ExecuteNonQuery();
     a.Fill(t);}return t;
   }
  }
 }
}
