using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            CboAuthentication.Items.Clear();
            CboAuthentication.Items.Add("Windows Authentication");
            CboAuthentication.Items.Add("SQL Server Authentication");
            CboAuthentication.Text = CboAuthentication.Items[0].ToString();

            TxtUserID.Enabled = false;
            TxtPwd.Enabled = false;

        }

        private void CboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboAuthentication_Leave(object sender, EventArgs e)
        {
            //Use condition
            string str_auth = CboAuthentication.Text.ToString();

            switch (str_auth)
            {
                case "Windows Authentication":

                    TxtUserID.Enabled = false;
                    TxtPwd.Enabled = false;

                    break;
                case "SQL Server Authentication":
                    TxtUserID.Enabled = true;
                    TxtPwd.Enabled = true;
                    break;
                //return;
                default:
                    // code block
                    break;
            }
            ;

        }
        
        //Create Sqlserver Connection

        SqlConnection MyConn = new();

        private void ButCheckConnection_Click(object sender, EventArgs e)
        {
            
            string MyServer = CboServer.Text.ToString();
            string MyDb = CboDatabase.Text.ToString();
            string MyUserID = TxtUserID.Text.ToString();
            string MyPwd = TxtPwd.Text.ToString();
            
            string StrMyConn_WindAuth=
                $"Server={MyServer}; " +
                $"Database={MyDb}; " +
                "Integrated Security=True;" +
                "Encrypt=True; " +
                "TrustServerCertificate=True; ";
            
            string StrMyConn_SqlAuth =
                $"Server={MyServer}; " +
                $"Database={MyDb}; " +
                $"User id={MyUserID}; " +
                $"Password={MyPwd}; " +
                "Encrypt=True; " +
                "TrustServerCertificate=True; ";

            //AUB - PKM\\SQL2025

            string str_auth = CboAuthentication.Text.ToString();

            if(str_auth == "Windows Authentication")
            {
                //Do any thing

                //Alwasys use using statements to ensure connections are properly closed and disposed
                try
                {
                    using (MyConn = new SqlConnection(StrMyConn_WindAuth))
                    {
                        MyConn.Open();

                        MessageBox.Show(
                            "Your database is connected with Windows Authentication",
                            "Confirm message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Your database is not connected with Windows Authentication.\n\nError: " + ex.Message,
                        "Confirm message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
          
            }
            else
            {

                try
                {
                    using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
                    {
                        MyConn.Open();

                        MessageBox.Show(
                            "Your database is connected with Sqlserver Authentication",
                            "Confirm message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Your database is not connected with Sqlserver Authentication.\n\nError: " + ex.Message,
                        "Confirm message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

            }
            

            //switch (str_auth)
            //{
            //    case "Windows Authentication":

            //        TxtUserID.Enabled = false;
            //        TxtPwd.Enabled = false;

            //        break;
            //    case "SQL Server Authentication":
            //        TxtUserID.Enabled = true;
            //        TxtPwd.Enabled = true;
            //        break;
            //    //return;
            //    default:
            //        // code block
            //        break;
            //}
            //;

            //MyConn.Open();


        }
    }
}
