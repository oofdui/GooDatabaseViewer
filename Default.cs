using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GooDatabaseViewer
{
    public partial class Default : Form
    {
        #region GlobalVariable
        int timerCount = 0;
        #endregion
        public Default()
        {
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            #region DefaultBuilder
            this.Text = "GooDatabaseViewer v."+clsGlobalNative.ApplicationVersion();
            txtIPServer.Text = System.Configuration.ConfigurationManager.AppSettings["IPServer"];
            txtDatabase.Text = System.Configuration.ConfigurationManager.AppSettings["Database"];
            txtUsername.Text = System.Configuration.ConfigurationManager.AppSettings["Username"];
            txtPassword.Text = System.Configuration.ConfigurationManager.AppSettings["Password"];
            txtReload.Text = System.Configuration.ConfigurationManager.AppSettings["Reload"];
            txtSQLQuery.Text = System.Configuration.ConfigurationManager.AppSettings["Query"];
            ttDefault.SetToolTip(pbDefault, "Count Down");
            txtSQLQuery.Select();
            #endregion
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            if (txtSQLQuery.Text.Trim().Length > 0)
            {
                btStart.Enabled = false; btStop.Enabled = true;
                rbSQL.Enabled = false; rbODBC.Enabled = false;
                txtDNS.Enabled = false;
                txtIPServer.Enabled = false;
                txtDatabase.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                pbDefault.Value = 0;
                timerDefault.Start();
            }
            else
            {
                MessageBox.Show("โปรดกรอก Query ก่อน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Start()
        {
            #region Checker
            if (rbSQL.Checked) 
            { 
                if (txtIPServer.Text.Trim().Length == 0 ||
                    txtDatabase.Text.Trim().Length == 0 ||
                    txtUsername.Text.Trim().Length == 0 ||
                    txtSQLQuery.Text.Trim().Length == 0)
                {
                    MessageBox.Show("โปรดกรอกข้อมูลการเชื่อมต่อฐานข้อมูลให้ครบ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rbODBC.Checked)
            {
                if (txtDNS.Text.Trim().Length == 0 ||
                    txtUsername.Text.Trim().Length == 0 ||
                    txtSQLQuery.Text.Trim().Length == 0)
                {
                    MessageBox.Show("โปรดกรอกข้อมูลการเชื่อมต่อฐานข้อมูลให้ครบ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            #endregion
            #region Variable
            var dbType = clsSQLNative.DBType.SQLServer;
            var clsSQL = new clsSQLNative();
            var dt = new DataTable();
            var cs = "";
            var strSQL="";
            if (rbSQL.Checked)
            {
                dbType = clsSQLNative.DBType.SQLServer;
                cs = System.Configuration.ConfigurationManager.AppSettings["csSQL"];
                cs = string.Format(cs, txtIPServer.Text.Trim(), txtDatabase.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
            else if (rbODBC.Checked)
            {
                dbType = clsSQLNative.DBType.ODBC;
                cs = System.Configuration.ConfigurationManager.AppSettings["csODBC"];
                cs = string.Format(cs, txtDNS.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
            #endregion
            #region Procedure
            #region LastUpdate
            if (lblLastUpdate.InvokeRequired)
            {
                lblLastUpdate.Invoke(new MethodInvoker(delegate
                {
                    lblLastUpdate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }));
            }
            else
            {
                lblLastUpdate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            #endregion
            strSQL = txtSQLQuery.Text.Replace(Environment.NewLine," ");
            dt = clsSQL.Bind(strSQL, dbType, cs);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (lblDataCount.InvokeRequired)
                {
                    lblDataCount.Invoke(new MethodInvoker(delegate
                    {
                        lblDataCount.Text = dt.Rows.Count.ToString();
                    }));
                }
                else
                {
                    lblDataCount.Text = dt.Rows.Count.ToString();
                }
                if (gvDefault.InvokeRequired)
                {
                    gvDefault.Invoke(new MethodInvoker(delegate
                        {
                            gvDefault.Visible = true;
                            gvDefault.DataSource = dt;
                            gvDefault.Columns[gvDefault.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            #region HighlightValue
                            if (txtHighlightValue.Text.Trim().Length > 0)
                            {
                                for (int r = 0; r < gvDefault.Rows.Count; r++)
                                {
                                    for (int c = 0; c < gvDefault.Columns.Count; c++)
                                    {
                                        if (gvDefault.Rows[r].Cells[c].Value.ToString().Trim() == txtHighlightValue.Text.Trim())
                                        {
                                            gvDefault.Rows[r].Cells[c].Style.BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                            #endregion
                            gvDefault.Refresh();
                            gvDefault.ClearSelection();
                        }));
                }
            }
            else
            {
                if (lblDataCount.InvokeRequired)
                {
                    lblDataCount.Invoke(new MethodInvoker(delegate
                    {
                        lblDataCount.Text = "0";
                    }));
                }
                else
                {
                    lblDataCount.Text = "0";
                }
                if (gvDefault.InvokeRequired)
                {
                    gvDefault.Invoke(new MethodInvoker(delegate
                    {
                        gvDefault.Visible = false;
                        gvDefault.DataSource = null;
                        gvDefault.Refresh();
                    }));
                }
            }
            #endregion
        }
        private void timerDefault_Tick(object sender, EventArgs e)
        {
            if (timerCount == 0 || timerCount>= int.Parse(txtReload.Text.Trim()))
            {
                timerCount = 0;
                if (!backgroundWorkerDefault.IsBusy)
                {
                    backgroundWorkerDefault.RunWorkerAsync();
                }
            }
            timerCount += 1;
            //Write Text on ProgressBar
            //pbDefault.CreateGraphics().DrawString(
            //    timerCount + "/" + pbDefault.Maximum,
            //    new Font("Tahoma", (float)10, FontStyle.Bold),
            //    Brushes.White,
            //    new PointF(pbDefault.Width / 2 - 10, pbDefault.Height / 2 - 7)
            //);
            pbDefault.Maximum = int.Parse(txtReload.Text.Trim());
            pbDefault.Value = timerCount;
            lblTimer.Text = (timerCount - int.Parse(txtReload.Text.Trim())).ToString();
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            rbSQL.Enabled = true; rbODBC.Enabled = true;
            if (rbSQL.Checked)
            {
                txtDNS.Enabled = true;
            }
            else if (rbODBC.Checked)
            {
                txtIPServer.Enabled = true;
                txtDatabase.Enabled = true;
            }
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            timerDefault.Stop(); 
            lblTimer.Text = ""; 
            timerCount = 0; lblLastUpdate.Text = ""; lblDataCount.Text = ""; 
            gvDefault.DataSource = null; gvDefault.Refresh();
            btStart.Enabled = true; btStop.Enabled = false;
            pbDefault.Value = 0;
        }
        private void backgroundWorkerDefault_DoWork(object sender, DoWorkEventArgs e)
        {
            Start();
        }
        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            #region DisableControl
            txtDNS.Enabled = false;
            txtIPServer.Enabled = true;
            txtDatabase.Enabled = true;
            #endregion
        }
        private void rbODBC_CheckedChanged(object sender, EventArgs e)
        {
            #region DisableControl
            txtDNS.Enabled = true;
            txtIPServer.Enabled = false;
            txtDatabase.Enabled = false;
            #endregion
        }
    }
}