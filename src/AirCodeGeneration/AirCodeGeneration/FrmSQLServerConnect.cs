using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirCodeGeneration
{
    public partial class FrmSQLServerConnect : Form
    {
        public FrmSQLServerConnect()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            Btn_Cancel.Click += Btn_Cancel_Click;
            Btn_Confirm.Click += Btn_Confirm_Click;
            Btn_Connection.Click += Btn_Connection_Click;

            cbbServerType.SelectedIndex = 0;
            cbbShenFenRZ.SelectedIndex = 0;
            cbbDatabase.SelectedIndex = 0;
        }

        private void Btn_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbServer.Text))
                {
                    MessageBox.Show("服务器不能为空!");
                    return;
                }

                if (cbbShenFenRZ.SelectedIndex == 1 && string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("登陆名不能为空!");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接数据库异常!原因:{ex.Message}");
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
