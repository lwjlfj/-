using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 停车场管理系统
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 关于事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void To_Click(object sender, EventArgs e)
        {
            FrmRegard frm = new FrmRegard();
            frm.ShowDialog();
        }
        /// <summary>
        /// 车辆进出记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Record_Click(object sender, EventArgs e)
        {
           FrmRecord frm = new FrmRecord();
            frm.ShowDialog();
        }
        /// <summary>
        /// 信息查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inquiry_Click(object sender, EventArgs e)
        {
            FrmIicense frm = new FrmIicense();
            frm.ShowDialog();
        }
        /// <summary>
        /// 当前车辆场信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Current_Click(object sender, EventArgs e)
        {
            FrmStall frm = new FrmStall();
            frm.ShowDialog();
        }
    }
}
