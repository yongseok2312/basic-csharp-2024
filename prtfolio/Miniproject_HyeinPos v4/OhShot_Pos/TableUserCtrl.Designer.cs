namespace OhShot_Pos
{
    partial class TableUserCtrl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableNumbers = new System.Windows.Forms.Label();
            this.menuListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TableNumbers);
            this.panel1.Location = new System.Drawing.Point(22, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 0;
            // 
            // TableNumbers
            // 
            this.TableNumbers.AutoSize = true;
            this.TableNumbers.Location = new System.Drawing.Point(141, 13);
            this.TableNumbers.Name = "TableNumbers";
            this.TableNumbers.Size = new System.Drawing.Size(69, 12);
            this.TableNumbers.TabIndex = 0;
            this.TableNumbers.Text = "테이블 번호";
            // 
            // menuListBox
            // 
            this.menuListBox.FormattingEnabled = true;
            this.menuListBox.ItemHeight = 12;
            this.menuListBox.Location = new System.Drawing.Point(22, 60);
            this.menuListBox.Name = "menuListBox";
            this.menuListBox.Size = new System.Drawing.Size(350, 160);
            this.menuListBox.TabIndex = 1;
            // 
            // TableUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuListBox);
            this.Controls.Add(this.panel1);
            this.Name = "TableUserCtrl";
            this.Size = new System.Drawing.Size(397, 229);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox menuListBox;
        private System.Windows.Forms.Label TableNumbers;
    }
}
