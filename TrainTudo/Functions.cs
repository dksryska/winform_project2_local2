using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainTudo
{
    // 데이터베이스 연결 코드
    internal class Functions
    {
        //Con: SQL 서버와의 연결을 관리하는 SqlConnection 객체.Sda: 데이터베이스에서 데이터를 검색할 때 사용하는 SqlDataAdapter.
        //dt: 데이터를 저장하는 DataTable 객체.
        //Cmd: SQL 명령어를 관리하는 SqlCommand 객체.
        //ConStr: 데이터베이스에 연결하기 위한 연결 문자열.
        SqlConnection Con;
        SqlDataAdapter Sda;
        DataTable dt;
        SqlCommand Cmd;
        string ConStr;

        public Functions() {
            // 1.서버 탐색기 -> 생성한 DB -> 우클릭->속성->연결 문자열(Connection String)->복붙
            // 2.생성자에서는 ConStr을 통해 데이터베이스 연결 문자열을 설정하고,
            //  ㄴCon과 Cmd 객체를 초기화합니다.
            //  ㄴConStr은 로컬 데이터베이스 파일에 연결하기 위해 설정되었습니다.
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\test\Documents\TrainTutoDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(String Quary)
        {
            //1.GetData 메소드는 Quary라는 SQL 쿼리를 사용하여
            // ㄴ데이터베이스에서 데이터를 가져옵니다.
            //2.SqlDataAdapter는 연결된 데이터베이스에서 Quary에 따라
            // ㄴ데이터를 가져와 DataTable 객체 dt에 채웁니다.
            dt = new DataTable();
            Sda = new SqlDataAdapter(Quary, ConStr);
            Sda.Fill(dt);

            //3.데이터를 포함한 DataTable 객체를 반환합니다.
            return dt;
        }

        //1.setData 메소드는 데이터베이스에 데이터를 삽입, 수정, 삭제하는 데 사용됩니다.
        public int setData(string Query)
        {
           
            //2.Query 매개변수로 전달된 SQL 명령어를 Cmd 객체에 설정하고,
            //  ㄴExecuteNonQuery를 호출하여 변경된 레코드 수를 반환합니다.
            int cnt = 0;

            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            //3.데이터 변경 작업이 완료되면 연결을 닫습니다.
            Con.Close();

            return cnt;

        }
    }
}
