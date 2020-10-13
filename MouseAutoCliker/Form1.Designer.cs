namespace MouseAutoCliker
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
            this.components = new System.ComponentModel.Container();
            this.button_Set_and_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Set_X = new System.Windows.Forms.TextBox();
            this.textBox_Set_Y = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Read_Y = new System.Windows.Forms.TextBox();
            this.textBox_Read_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Set_and_Click
            // 
            this.button_Set_and_Click.Location = new System.Drawing.Point(6, 19);
            this.button_Set_and_Click.Name = "button_Set_and_Click";
            this.button_Set_and_Click.Size = new System.Drawing.Size(75, 39);
            this.button_Set_and_Click.TabIndex = 0;
            this.button_Set_and_Click.Text = "Set && Click";
            this.button_Set_and_Click.UseVisualStyleBackColor = true;
            this.button_Set_and_Click.Click += new System.EventHandler(this.button_Set_and_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Set_Y);
            this.groupBox1.Controls.Add(this.textBox_Set_X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Set_and_Click);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set MouseCursor and Click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "x : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "y : ";
            // 
            // textBox_Set_X
            // 
            this.textBox_Set_X.Location = new System.Drawing.Point(108, 16);
            this.textBox_Set_X.Name = "textBox_Set_X";
            this.textBox_Set_X.Size = new System.Drawing.Size(61, 20);
            this.textBox_Set_X.TabIndex = 3;
            this.textBox_Set_X.Text = "200";
            this.textBox_Set_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Set_Y
            // 
            this.textBox_Set_Y.Location = new System.Drawing.Point(108, 38);
            this.textBox_Set_Y.Name = "textBox_Set_Y";
            this.textBox_Set_Y.Size = new System.Drawing.Size(61, 20);
            this.textBox_Set_Y.TabIndex = 4;
            this.textBox_Set_Y.Text = "400";
            this.textBox_Set_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Read_Y);
            this.groupBox2.Controls.Add(this.textBox_Read_X);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show MouseCursor Position";
            // 
            // textBox_Read_Y
            // 
            this.textBox_Read_Y.Location = new System.Drawing.Point(114, 19);
            this.textBox_Read_Y.Name = "textBox_Read_Y";
            this.textBox_Read_Y.ReadOnly = true;
            this.textBox_Read_Y.Size = new System.Drawing.Size(61, 20);
            this.textBox_Read_Y.TabIndex = 4;
            this.textBox_Read_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Read_X
            // 
            this.textBox_Read_X.Location = new System.Drawing.Point(27, 19);
            this.textBox_Read_X.Name = "textBox_Read_X";
            this.textBox_Read_X.ReadOnly = true;
            this.textBox_Read_X.Size = new System.Drawing.Size(61, 20);
            this.textBox_Read_X.TabIndex = 3;
            this.textBox_Read_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "y : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "x : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 144);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Set_and_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Set_Y;
        private System.Windows.Forms.TextBox textBox_Set_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Read_Y;
        private System.Windows.Forms.TextBox textBox_Read_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

