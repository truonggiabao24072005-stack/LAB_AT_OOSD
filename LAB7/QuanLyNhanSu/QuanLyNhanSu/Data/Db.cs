using System; using System.Data; using System.Data.SqlClient; using System.Configuration;
namespace QuanLyNhanSu.Data {
 public sealed class Db {
  readonly string connection; public Db():this(ConfigurationManager.ConnectionStrings["NhanSu"].ConnectionString){} public Db(string value){connection=value;}
  public static SqlParameter P(string name,object value){return new SqlParameter(name,value??DBNull.Value);}
  public T Tx<T>(Func<Session,T> work){using(var c=new SqlConnection(connection)){c.Open();using(var t=c.BeginTransaction(IsolationLevel.Serializable)){try{var result=work(new Session(c,t));t.Commit();return result;}catch{t.Rollback();throw;}}}}
  public DataTable Query(string sql,params SqlParameter[] p){return Tx(s=>s.Query(sql,p));}
 }
 public sealed class Session {
  readonly SqlConnection c; readonly SqlTransaction t; public Session(SqlConnection a,SqlTransaction b){c=a;t=b;}
  SqlCommand Cmd(string sql,SqlParameter[] p){var q=new SqlCommand(sql,c,t);q.CommandTimeout=20;q.Parameters.AddRange(p);return q;}
  public int Exec(string sql,params SqlParameter[] p){using(var q=Cmd(sql,p))return q.ExecuteNonQuery();}
  public object Scalar(string sql,params SqlParameter[] p){using(var q=Cmd(sql,p))return q.ExecuteScalar();}
  public DataTable Query(string sql,params SqlParameter[] p){using(var q=Cmd(sql,p)){var d=new DataTable();using(var a=new SqlDataAdapter(q))a.Fill(d);return d;}}
 }
}
