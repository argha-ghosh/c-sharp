using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACrudQ
{
    public partial class FormDashboard : Form
    {
        public DataAccess Da { get; set; }

        public FormDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Movie;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Movie where Genre = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Movie where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from Movie where Id = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if(ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update Movie
                                set Title = '" + this.txtTitle.Text + @"',
                                IMDB = " + this.txtIMDB.Text + @",
                                Income = " + this.txtIncome.Text + @",
                                ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                Genre = '" + this.cmbGenre.Text + @"'
                                where Id = '" + this.txtID.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
                else
                {
                    //insert
                    var sql = "insert into Movie values('" + this.txtID.Text + "', '" + this.txtTitle.Text + "', " + this.txtIMDB.Text + ", " + this.txtIncome.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "'); ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }                

                this.PopulateGridView();
                this.ClearAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }            
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtID.Text) || string.IsNullOrEmpty(this.txtTitle.Text) ||
                string.IsNullOrEmpty(this.txtIMDB.Text) || string.IsNullOrEmpty(this.txtIncome.Text) ||
                string.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this.AutoIdGenerate();
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtTitle.Clear();
            this.txtIMDB.Clear();
            this.txtIncome.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;

            this.txtSearch.Text = "";
            this.txtAutoSearch.Clear();

            this.dgvMovie.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                if(this.dgvMovie.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvMovie.CurrentRow.Cells["Id"].Value.ToString();
                var title = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from Movie where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.dgvMovie.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
            this.txtTitle.Text = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["IMDB"].Value.ToString();
            this.txtIncome.Text = this.dgvMovie.CurrentRow.Cells["Income"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells[4].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["Genre"].Value.ToString();
        }

        private void AutoIdGenerate()
        {
            var sql = "select max(Id) from Movie;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "m-" + (++num).ToString("d3");
            this.txtID.Text = currentId;
        }
    }
}
