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
            this.can_BackgroundColor = new System.Windows.Forms.Button();
            this.cannot_BackgroundColor = new System.Windows.Forms.Button();
            this.areaPlus = new System.Windows.Forms.Button();
            this.areaMinus = new System.Windows.Forms.Button();
            this.change_BackgroundColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // can_BackgroundColor
            // 
            this.can_BackgroundColor.Enabled = false;
            this.can_BackgroundColor.Location = new System.Drawing.Point(257, 340);
            this.can_BackgroundColor.Name = "can_BackgroundColor";
            this.can_BackgroundColor.Size = new System.Drawing.Size(125, 23);
            this.can_BackgroundColor.TabIndex = 0;
            this.can_BackgroundColor.Text = "배경색 변경 가능";
            this.can_BackgroundColor.UseVisualStyleBackColor = true;
            this.can_BackgroundColor.Click += new System.EventHandler(this.can_BackgroundColor_Click);
            // 
            // cannot_BackgroundColor
            // 
            this.cannot_BackgroundColor.Location = new System.Drawing.Point(388, 340);
            this.cannot_BackgroundColor.Name = "cannot_BackgroundColor";
            this.cannot_BackgroundColor.Size = new System.Drawing.Size(125, 23);
            this.cannot_BackgroundColor.TabIndex = 1;
            this.cannot_BackgroundColor.Text = "배경색 변경 불가";
            this.cannot_BackgroundColor.UseVisualStyleBackColor = true;
            this.cannot_BackgroundColor.Click += new System.EventHandler(this.cannot_BackgroundColor_Click);
            // 
            // areaPlus
            // 
            this.areaPlus.Location = new System.Drawing.Point(257, 369);
            this.areaPlus.Name = "areaPlus";
            this.areaPlus.Size = new System.Drawing.Size(125, 23);
            this.areaPlus.TabIndex = 2;
            this.areaPlus.Text = "영역확대";
            this.areaPlus.UseVisualStyleBackColor = true;
            // 
            // areaMinus
            // 
            this.areaMinus.Location = new System.Drawing.Point(388, 369);
            this.areaMinus.Name = "areaMinus";
            this.areaMinus.Size = new System.Drawing.Size(125, 23);
            this.areaMinus.TabIndex = 3;
            this.areaMinus.Text = "영역축소";
            this.areaMinus.UseVisualStyleBackColor = true;
            // 
            // change_BackgroundColor
            // 
            this.change_BackgroundColor.Location = new System.Drawing.Point(257, 311);
            this.change_BackgroundColor.Name = "change_BackgroundColor";
            this.change_BackgroundColor.Size = new System.Drawing.Size(256, 23);
            this.change_BackgroundColor.TabIndex = 4;
            this.change_BackgroundColor.Text = "배경색 변경";
            this.change_BackgroundColor.UseVisualStyleBackColor = true;
            this.change_BackgroundColor.Click += new System.EventHandler(this.change_BackgroundColor_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(286, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.change_BackgroundColor);
            this.Controls.Add(this.areaMinus);
            this.Controls.Add(this.areaPlus);
            this.Controls.Add(this.cannot_BackgroundColor);
            this.Controls.Add(this.can_BackgroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "함승우2019101009실습3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button can_BackgroundColor;
        private System.Windows.Forms.Button cannot_BackgroundColor;
        private System.Windows.Forms.Button areaPlus;
        private System.Windows.Forms.Button areaMinus;
        private System.Windows.Forms.Button change_BackgroundColor;
        private System.Windows.Forms.Panel panel1;
    }
}

