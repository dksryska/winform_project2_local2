namespace TrainTudo
{
    public partial class Train : Form
    {
        // DB 연결 코드 담긴 Functions.cs 파일 호출
        Functions Con;

        public Train()
        {
            InitializeComponent();
            //Train.cs 파일이 불러지면 Functions.cs 파일을 불러냄.
            Con = new Functions();
            //Train.cs 파일이 불러지면서 ShowTrains()도 실행 함
            ShowTrains();
        }

        private void ShowTrains()
        {
            string Query = "select * from TrainTbl";
            TrainsDGV.DataSource = Con.GetData(Query);
        }

        private void Clear()
        {
            TNameTb.Text = "";
            TNumberTb.Text = "";
            TCapacityTb.Text = "";
            TConditionTb.Text = "";
            TColorTb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TNumberTb.Text == "" ||
               TCapacityTb.Text == "" || TConditionTb.Text == "" || TColorTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!!");
            }
            else
            {
                try
                {
                    string TName = TNameTb.Text;
                    string TNumber = TNumberTb.Text;
                    int Capacity = Convert.ToInt32(TCapacityTb.Text);
                    string Condition = TConditionTb.Text;
                    string Color = TColorTb.Text;
                    string Query = "insert into TrainTbl values('{0}', '{1}', {2}, '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, TName, TNumber, Capacity, InDateTb.Value.Date.ToString("yyyy-MM-dd"), Condition, Color);
                    Con.setData(Query);
                    MessageBox.Show("Train Added!!!");
                    ShowTrains();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TrainsDGV_Click(object sender, EventArgs e)
        {

        }

        private void TNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void TrainsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNameTb.Text = TrainsDGV.SelectedRows[0].Cells[1].Value.ToString();
            TNumberTb.Text = TrainsDGV.SelectedRows[0].Cells[2].Value.ToString();
            TCapacityTb.Text = TrainsDGV.SelectedRows[0].Cells[3].Value.ToString();
            //TNameTb.Text = TrainsDGV.SelectedRows[0].Cells[4].Value.ToString();
            TConditionTb.Text = TrainsDGV.SelectedRows[0].Cells[5].Value.ToString();
            TColorTb.Text = TrainsDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (TNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                // (오른쪽)에 추가된 내용 중 TCode를 클릭하면 왼쪽에 자동으로 써짐
                key = Convert.ToInt32(TrainsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TNumberTb.Text == "" ||
             TCapacityTb.Text == "" || TConditionTb.Text == "" || TColorTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!!");
            }
            else
            {
                try
                {
                    string TName = TNameTb.Text;
                    string TNumber = TNumberTb.Text;
                    int Capacity = Convert.ToInt32(TCapacityTb.Text);
                    string Condition = TConditionTb.Text;
                    string Color = TColorTb.Text;
                    string Query = "update TrainTbl set TName = '{0}', TNumber = '{1}', Capacity = {2}, InDate = '{3}', Condition = '{4}', Color = '{5}' where TCode = {6}";
                    Query = string.Format(Query, TName, TNumber, Capacity, InDateTb.Value.Date.ToString("yyyy-MM-dd"), Condition, Color, key);
                    Con.setData(Query);
                    MessageBox.Show("Train Updated!!!");
                    ShowTrains();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Train!!!!");
            }
            else
            {
                try
                {

                    string Query = "delete from TrainTbl where TCode = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);
                    MessageBox.Show("Train Deleted!!!");
                    ShowTrains();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Condructers Obj = new Condructers();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Condructers Obj = new Condructers();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
