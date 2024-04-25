﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace OhShot_Pos
{

    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
            TxtDate.Text = DateTime.Now.ToString("T");
        }

        #region 폼로드 이벤트 핸들러 : 로딩창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLoading frm = new FrmLoading();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();
        }
        #endregion

        #region '매출통계' 버튼 클릭 이벤트 핸들러 
        private void BtnStat_Click(object sender, EventArgs e)
        {
            FrmStat stat = new FrmStat();
            stat.StartPosition = FormStartPosition.CenterScreen;
            stat.Show();
        }
        #endregion

        #region '포스기 종료' 버튼 클릭 이벤트 핸들러
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region '테이블 클릭' 
        private void TxtTable1_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder(); 
            frm.StartPosition = FormStartPosition.CenterScreen; 
            frm.Show(); 
        }
        #endregion
    }
}

