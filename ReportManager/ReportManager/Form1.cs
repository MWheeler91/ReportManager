using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReportManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\ReportsDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        int testID = 0;


        // ---------------------- buttons ---------------------- //


        // Submit button //  THIS BUTTON IS WORKING AS INTENDED AT THIS TIME.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string span = cbSpan.Text;
            string reportData = tbReportInput.Text;
            DateTime timeStamp = DateTime.Now;

            if (tbReportInput.Text == string.Empty)
            {
                MessageBox.Show("Report must have text!!!!");
            }
            else
            {
                try
                {
                    string sqlQuery = "INSERT INTO Reports(TimeSpan, ReportData, TimeStamp) VALUES (@TimeSpan, @ReportData, @Date)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@TimeSpan", span);
                    cmd.Parameters.AddWithValue("@ReportData", reportData);
                    cmd.Parameters.AddWithValue("@Date", timeStamp);

                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Report Saved Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        tbReportInput.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    DisplayData();
                    ClearData();
                }
            }
            CheckDataRows();
            EnableButtons();
            lblNoEdit.Visible = false;
        }
        
        
        // Clear button // 
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReportInput.Clear();
            tbReportInput.Focus();
            ID = 0;
            EnableButtons();
        }

        // Edit button // 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            tbReportInput.Focus();

            if (reportsDataGridView.Visible == false)
            {
                lblNoEdit.Visible = true;
                lblNoRecordsFound.Visible = false;
            }
            else
            {
                ChangeBtnVisibility();
                int selectedrowIndex = reportsDataGridView.SelectedCells[0].RowIndex;
                testID = (int)reportsDataGridView.Rows[selectedrowIndex].Cells[0].Value;
                tbReportInput.Text = reportsDataGridView.Rows[selectedrowIndex].Cells[2].Value.ToString();
                string selectedSpanAtIndex = reportsDataGridView.Rows[selectedrowIndex].Cells[1].Value.ToString();
                lblTimeSpan.Text = selectedSpanAtIndex;
                cbSpan.SelectedIndex = cbSpan.FindStringExact(lblTimeSpan.Text.Trim());
                DisableButtons();
            }
            
        }
        // delete button // THIS BUTTON IS WORKING.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0 && reportsDataGridView.Visible == true)
            {
                try
                {
                    cmd = new SqlCommand("delete from Reports where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    DisplayData();
                    ClearData();
                }

            }
            else if (reportsDataGridView.Visible == false)
            {
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            CheckDataRows();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string span = cbSpan.Text;
            string reportData = tbReportInput.Text;
            DateTime timeStamp = DateTime.Now;

            try
            {
                if (tbReportInput.Text != "")
                {
                    cmd = new SqlCommand("update Reports set TimeSpan=@TimeSpan, reportData=@ReportData, timeStamp=@Date where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", testID);
                    cmd.Parameters.AddWithValue("@TimeSpan", span);
                    cmd.Parameters.AddWithValue("@ReportData", reportData);
                    cmd.Parameters.AddWithValue("@Date", timeStamp);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                    tbReportInput.Focus();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                DisplayData();
                ClearData();
            }
            ChangeBtnVisibility();
            EnableButtons();
        }

        // this button is working.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbReportInput.Text = "";
            ChangeBtnVisibility(); 
            EnableButtons();

        }



        // ---------------------- Onload methods ----------------------//



        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'reportsDBDataSet.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.reportsDBDataSet.Reports);
            cbSpan.SelectedIndex = 0;


        }


        private void reportsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            ID = Convert.ToInt32(reportsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }


        // ---------------------- Custom methods ----------------------//

        private void ChangeBtnVisibility()
        {
            if (btnSubmit.Visible == true)
            {
                btnSubmit.Visible = false;
                btnClear.Visible = false;

                btnUpdate.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                btnSubmit.Visible = true;
                btnClear.Visible = true;

                btnUpdate.Visible = false;
                btnCancel.Visible = false;
            }
            
        }
        private void CheckDataRows()
        {
            if (reportsDataGridView.Rows.Count == 0)
            {
                reportsDataGridView.Visible = false;
                lblNoRecordsFound.Visible = true;
            }
            else
            {
                reportsDataGridView.Visible = true;
                lblNoRecordsFound.Visible = false;
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from reports", con);
            adapt.Fill(dt);
            reportsDataGridView.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            tbReportInput.Text = string.Empty;
            cbSpan.SelectedIndex = 0;
        }

        private void DisableButtons()
        {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                reportsDataGridView.Enabled = false;
        }
        private void EnableButtons()
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            reportsDataGridView.Enabled = true;
        }
    }
}
