namespace DreamLens
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBirthHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBirthHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 정보 입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과 보기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일입력(예:20070526)";
            // 
            // tbBirthHour
            // 
            this.tbBirthHour.Font = new System.Drawing.Font("굴림", 11F);
            this.tbBirthHour.Location = new System.Drawing.Point(22, 78);
            this.tbBirthHour.Name = "tbBirthHour";
            this.tbBirthHour.Size = new System.Drawing.Size(149, 24);
            this.tbBirthHour.TabIndex = 1;
            this.tbBirthHour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "태어난 시각(예:3시15분 -> 03)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBirthday
            // 
            this.tbBirthday.Font = new System.Drawing.Font("굴림", 11F);
            this.tbBirthday.Location = new System.Drawing.Point(22, 170);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(77, 24);
            this.tbBirthday.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(51, 317);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(256, 36);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "사주팔자 보기";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(19, 36);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(350, 372);
            this.tbResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "드림렌즈: 3204 박수민";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBirthHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

