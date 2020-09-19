namespace One
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
            this.Can_BackgroundColor = new System.Windows.Forms.Button();
            this.Cannot_BackgroundColor = new System.Windows.Forms.Button();
            this.AreaPlus = new System.Windows.Forms.Button();
            this.AreaMinus = new System.Windows.Forms.Button();
            this.Change_BackgroundColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Can_BackgroundColor
            // 
            this.Can_BackgroundColor.Enabled = false;
            this.Can_BackgroundColor.Location = new System.Drawing.Point(268, 345);
            this.Can_BackgroundColor.Name = "Can_BackgroundColor";
            this.Can_BackgroundColor.Size = new System.Drawing.Size(125, 23);
            this.Can_BackgroundColor.TabIndex = 0;
            this.Can_BackgroundColor.Text = "배경색 변경 가능";
            this.Can_BackgroundColor.UseVisualStyleBackColor = true;
            this.Can_BackgroundColor.Click += new System.EventHandler(this.Can_BackgroundColor_Click);
            // 
            // Cannot_BackgroundColor
            // 
            this.Cannot_BackgroundColor.Location = new System.Drawing.Point(399, 345);
            this.Cannot_BackgroundColor.Name = "Cannot_BackgroundColor";
            this.Cannot_BackgroundColor.Size = new System.Drawing.Size(125, 23);
            this.Cannot_BackgroundColor.TabIndex = 1;
            this.Cannot_BackgroundColor.Text = "배경색 변경 불가";
            this.Cannot_BackgroundColor.UseVisualStyleBackColor = true;
            this.Cannot_BackgroundColor.Click += new System.EventHandler(this.Cannot_BackgroundColor_Click);
            // 
            // AreaPlus
            // 
            this.AreaPlus.Location = new System.Drawing.Point(268, 374);
            this.AreaPlus.Name = "AreaPlus";
            this.AreaPlus.Size = new System.Drawing.Size(125, 23);
            this.AreaPlus.TabIndex = 2;
            this.AreaPlus.Text = "영역확대";
            this.AreaPlus.UseVisualStyleBackColor = true;
            this.AreaPlus.Click += new System.EventHandler(this.AreaPlus_Click);
            // 
            // AreaMinus
            // 
            this.AreaMinus.Location = new System.Drawing.Point(399, 374);
            this.AreaMinus.Name = "AreaMinus";
            this.AreaMinus.Size = new System.Drawing.Size(125, 23);
            this.AreaMinus.TabIndex = 3;
            this.AreaMinus.Text = "영역축소";
            this.AreaMinus.UseVisualStyleBackColor = true;
            this.AreaMinus.Click += new System.EventHandler(this.AreaMinus_Click);
            // 
            // Change_BackgroundColor
            // 
            this.Change_BackgroundColor.Location = new System.Drawing.Point(268, 316);
            this.Change_BackgroundColor.Name = "Change_BackgroundColor";
            this.Change_BackgroundColor.Size = new System.Drawing.Size(256, 23);
            this.Change_BackgroundColor.TabIndex = 4;
            this.Change_BackgroundColor.Text = "배경색 변경";
            this.Change_BackgroundColor.UseVisualStyleBackColor = true;
            this.Change_BackgroundColor.Click += new System.EventHandler(this.Change_BackgroundColor_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(303, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Change_BackgroundColor);
            this.Controls.Add(this.AreaMinus);
            this.Controls.Add(this.AreaPlus);
            this.Controls.Add(this.Cannot_BackgroundColor);
            this.Controls.Add(this.Can_BackgroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "함승우2019101009실습3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Can_BackgroundColor;
        private System.Windows.Forms.Button Cannot_BackgroundColor;
        private System.Windows.Forms.Button AreaPlus;
        private System.Windows.Forms.Button AreaMinus;
        private System.Windows.Forms.Button Change_BackgroundColor;
        private System.Windows.Forms.Panel panel1;
    }
}

