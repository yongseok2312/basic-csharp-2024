using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OhShot_Pos
{
    public partial class FrmLoading : Form
    {
        public const int min = 0;
        public const int value = 0;
        public const int step = 20;
        public const int max = 100;

        public FrmLoading()
        {
            InitializeComponent();
            InitProgressBar();
        }

        #region '로딩바' 프로그레스바 컨트롤 
        private void InitProgressBar()
        {
            PrgLoading.Style = ProgressBarStyle.Continuous;
            PrgLoading.Minimum = min;
            PrgLoading.Maximum = max;
            PrgLoading.Value = value;
            StepUpAsync();
        }

        // 천천히 로딩바 차오르도록 설정 
        private async Task StepUpAsync()
        {
            for (int i = 0; i <= max; i++)
            {
                PrgLoading.Value = i;
                await Task.Delay(5); // 5ms 대기

                if (i == max)
                {
                    Close();// 프로그레스바가 최대 값에 도달하면 폼을 닫기
                }
            }
        }
        #endregion
    }
}

