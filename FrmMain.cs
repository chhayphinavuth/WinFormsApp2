using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiBtnCommit_Click(object sender, EventArgs e)
        {
            string str_id = uiTxtSupID.Text;
            string str_name = uiTxtSubName.Text;
            string str_contactPerson = uiTxtContactPerson.Text;
            string str_phone = uiTxtPhone.Text;
            string str_email = uiTxtEmail.Text;
            string str_address = uiTxtAddress.Text;
            string str_lst =
                "1. ID:" + str_id.ToString() + Environment.NewLine +
                "2. Name:" + str_name.ToString() + Environment.NewLine +
                "3. Contact Person:" + str_contactPerson.ToString() + Environment.NewLine +
                "4. Phone:" + str_phone.ToString() + Environment.NewLine +
                "5. Email:" + str_email.ToString() + Environment.NewLine +
                "6. Address:" + str_address.ToString() + Environment.NewLine;

            uiListBox1.Items.Add($"{str_lst}");

            //listBoxView.Items.Add($"Line {i}: {str_tmp}");
        }

        string MyServer = "AUB-PKM\\SQL2025";
        string MyDb = "test1";
        string MyUserID = "sa2025";
        string MyPwd = "SQL@2025";

        SqlConnection MyConn = new();       //establis connect
        SqlCommand cmd;                    //establis command (Parameter/ExecuteNonQuery)
        SqlDataReader MyReader;
        string sql;                         //establis query string

        private void ButInsert_Click(object sender, EventArgs e)
        {

            //Input
            string StrMyConn_SqlAuth =
            $"Server={MyServer}; " +
            $"Database={MyDb}; " +
            $"User id={MyUserID}; Password={MyPwd}; " +
            "Encrypt=True; " +
            "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                MyConn.Open();      //Start connect to sqlserver
                //Insert data to table database
                try
                {
                    sql =
                        "Insert into [USER_LST] ([USER_ID], [USER_NAME], [USER_PWD], [USER_EMAIL],[USER_PROFILE])" +
                        " Values(@userid,@username,@pwd,@email,@Profile);";
                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtUserID.Text));
                    cmd.Parameters.AddWithValue("@username", TxtUserName.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtUserPwd.Text);
                    cmd.Parameters.AddWithValue("@email", TxtUserEmail.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboProFile.Text);
                    //Process                
                    int x = cmd.ExecuteNonQuery();
                    //Output 
                    if (x == 1)
                    {
                        //Data one row is inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is inserted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        //Data is not inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is not inserted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Confirm message..",
                        "Error:" + ex.Message);
                }
            }


        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            CboProFile.Items.Clear();
            CboProFile.Items.Add("Administrator");
            CboProFile.Items.Add("User");
            CboProFile.Text = CboProFile.Items[0].ToString();
        }

        private void ButView_Click(object sender, EventArgs e)
        {
            //Input
            string StrMyConn_SqlAuth =
            $"Server={MyServer}; " +
            $"Database={MyDb}; " +
            $"User id={MyUserID}; Password={MyPwd}; " +
            "Encrypt=True; " +
            "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                MyConn.Open();      //Start connect to sqlserver
                //Insert data to table database
                try
                {
                    sql =
                        "SELECT [USER_ID], [USER_NAME], [USER_PWD], [USER_EMAIL],[USER_PROFILE] " +
                        "FROM [USER_LST] WHERE [USER_ID]=@userid ";
                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtUserID.Text));
                    //Process                
                    MyReader = cmd.ExecuteReader();

                    //Output 

                    if (MyReader.HasRows)
                    {   //Output
                        while (MyReader.Read())
                        {
                            TxtUserID.Text = MyReader.GetValue(0).ToString();       //USER_ID
                            TxtUserName.Text = MyReader.GetValue(1).ToString();     //USER_NAME
                            TxtUserPwd.Text = MyReader.GetValue(2).ToString();      //USER_PWD
                            TxtUserEmail.Text = MyReader.GetValue(3).ToString();    //USER_EMAIL
                            CboProFile.Text = MyReader.GetValue(4).ToString();      //USER_PROFIL
                        }
                    }
                    else
                    {
                        //Data is not Found!
                        MessageBox.Show("Confirm message..",
                            "Data is not Found", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }


                    //MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Confirm message..",
                        "Error:" + ex.Message);
                }
            }

        }

        private void ButUpdate_Click(object sender, EventArgs e)
        {
            //Input
            string StrMyConn_SqlAuth =
            $"Server={MyServer}; " +
            $"Database={MyDb}; " +
            $"User id={MyUserID}; Password={MyPwd}; " +
            "Encrypt=True; " +
            "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                MyConn.Open();      //Start connect to sqlserver
                //Insert data to table database
                try
                {
                    sql =
                        "UPDATE [USER_LST] SET " +
                        "[USER_NAME]=@username, " +
                        "[USER_PWD]=@pwd, " +
                        "[USER_EMAIL]=@email," +
                        "[USER_PROFILE]=@Profile " +
                        " WHERE [USER_ID]=@userid ";
                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtUserID.Text));
                    cmd.Parameters.AddWithValue("@username", TxtUserName.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtUserPwd.Text);
                    cmd.Parameters.AddWithValue("@email", TxtUserEmail.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboProFile.Text);
                    //Process                
                    int x = cmd.ExecuteNonQuery();
                    //Output 
                    if (x == 1)
                    {
                        //Data one row is inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is Updated", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        //Data is not inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is not Updated", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    // MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Confirm message..",
                        "Error:" + ex.Message);
                }
            }
        }

        private void ButDel_Click(object sender, EventArgs e)
        {
            //Input
            string StrMyConn_SqlAuth =
            $"Server={MyServer}; " +
            $"Database={MyDb}; " +
            $"User id={MyUserID}; Password={MyPwd}; " +
            "Encrypt=True; " +
            "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                MyConn.Open();      //Start connect to sqlserver
                //Insert data to table database
                try
                {
                    sql =
                        "DELETE FROM [USER_LST] " +                        
                        " WHERE [USER_ID]=@userid ";
                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtUserID.Text));
                    //cmd.Parameters.AddWithValue("@username", TxtUserName.Text);
                    //cmd.Parameters.AddWithValue("@pwd", TxtUserPwd.Text);
                    //cmd.Parameters.AddWithValue("@email", TxtUserEmail.Text);
                    //cmd.Parameters.AddWithValue("@Profile", CboProFile.Text);
                    //Process                
                    int x = cmd.ExecuteNonQuery();
                    //Output 
                    if (x == 1)
                    {
                        //Data one row is inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is Deleted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        //Data is not inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is not Deleted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    // MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Confirm message..",
                        "Error:" + ex.Message);
                }
            }
        }
    }
}
