using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTudo
{
    public partial class Condructers : Form
    {
        Functions Con;

        public Condructers()
        {
            InitializeComponent();
            Con = new Functions();
            ShowConducters();
        }

        private void ShowConducters()
        {
            string Query = "select * from ConducterTbl";
            ConducterDGV.DataSource = Con.GetData(Query);
        }

        private void Clear()
        {
            CNameTb.Text = "";
            GenderTb.Text = "";
            MobileTb.Text = "";
            AdressTb.Text = "";

        }



        private void Condructers_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || AdressTb.Text == "" ||
              ExpTb.Text == "" || MobileTb.Text == "" || GenderTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!!");
            }
            else
            {
                try
                {
                    string CName = CNameTb.Text;
                    string GName = GenderTb.Text;
                    int Experience = Convert.ToInt32(ExpTb.Text);
                    string Phone = MobileTb.Text;
                    string Adress = AdressTb.Text;
                    string Query = "insert into ConducterTbl values('{0}', '{1}', '{2}', '{3}', '{4}', {5})";
                    Query = string.Format(Query, CName, GName, CDOBTb.Value.Date.ToString("yyyy-MM-dd"), Phone, Adress, Experience);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Added!!!");
                    ShowConducters();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Train Obj = new Train();
            Obj.Show();
            this.Hide();
        }

        private void CNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void ConducterDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = ConducterDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderTb.Text = ConducterDGV.SelectedRows[0].Cells[2].Value.ToString();
            //TCapacityTb.Text = ConducterDGV.SelectedRows[0].Cells[3].Value.ToString();
            MobileTb.Text = ConducterDGV.SelectedRows[0].Cells[4].Value.ToString();
            AdressTb.Text = ConducterDGV.SelectedRows[0].Cells[5].Value.ToString();
            ExpTb.Text = ConducterDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (CNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                // (오른쪽)에 추가된 내용 중 TCode를 클릭하면 왼쪽에 자동으로 써짐
                key = Convert.ToInt32(ConducterDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || AdressTb.Text == "" ||
              ExpTb.Text == "" || MobileTb.Text == "" || GenderTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!!");
            }
            else
            {
                try
                {
                    string CName = CNameTb.Text;
                    string GName = GenderTb.Text;
                    int Experience = Convert.ToInt32(ExpTb.Text);
                    string Phone = MobileTb.Text;
                    string Adress = AdressTb.Text;
                    string Query = "update ConducterTbl set CName ='{0}', CGender = '{1}', CDOB = '{2}', CPhone = '{3}', CAdress = '{4}',  CExp = {5} where CCode = {6} ";
                    Query = string.Format(Query, CName, GName, CDOBTb.Value.Date.ToString("yyyy-MM-dd"), Phone, Adress, Experience, key);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Uodate!!!");
                    ShowConducters();
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
                MessageBox.Show("Select a Condructers!!!!");
            }
            else
            {
                try
                {

                    string Query = "delete from ConducterTbl where CCode = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Deleted!!!");
                    ShowConducters();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Train Obj = new Train();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
