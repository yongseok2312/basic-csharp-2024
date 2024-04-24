using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace NewBookRentalShopAp
{
    public partial class FrmMain : MetroForm
    {
        private FrmLoginUser frmLoginUser = null;
        FrmBookDivision frmBookDivision = null;
        FrmBookinfo frmBookinfo = null;
        FrmMembers frmMembers = null;
        FrmBookRental frmBookRental = null;


        public FrmMain()
        {
            InitializeComponent();
        }

        // 폼로드 이벤트 핸들러 -> 로그인창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm =  new FrmLogin(); 
            //frm.Parent = this;  // FrmMain이 부모창 설정
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();

            LblLoginId.Text = Helper.Common.LoginId;
        }

        private void MnuLoginUsers_Click(object sender, EventArgs e)
        {
            frmLoginUser = ShowActiveForm(frmLoginUser, typeof(FrmLoginUser)) as FrmLoginUser;
        }

        // 책 장르관리 메뉴 클릭 이벤트
        private void MnuBookDivision_Click(object sender, EventArgs e)
        {
            frmBookDivision = (FrmBookDivision)ShowActiveForm(frmBookDivision, typeof(FrmBookDivision));
        }
        private void MnuBookInfo_Click(object sender, EventArgs e)
        {
            frmBookinfo = (FrmBookinfo)ShowActiveForm(frmBookinfo, typeof(FrmBookinfo));
        }
        private void MnuMembers_Click(object sender, EventArgs e)
        {
            frmMembers = ShowActiveForm(frmMembers, typeof(FrmMembers)) as FrmMembers;
        }
        private void MnuBookRental_Click(object sender, EventArgs e)
        {
            frmBookRental = ShowActiveForm(frmBookRental, typeof(FrmBookRental)) as FrmBookRental;
        }
        Form ShowActiveForm(Form form,Type type)
        {
            if(form == null)// 화면이 한번도 안열었으면
            {
                form = Activator.CreateInstance(type) as Form;  // 타입은 클래스 타입
                form.MdiParent = this; // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 창이 한번 닫혔으면 진행
                {
                    form = Activator.CreateInstance(type) as Form;  // 타입은 클래스 타입
                    form.MdiParent = this; // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 최소화 할시
                {
                    form.Activate();
                }
                
            }
            return form;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MetroMessageBox.Show(this,"종료하시겠습니까?","종료 여부",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout popup = new FrmAbout();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
    }
}
