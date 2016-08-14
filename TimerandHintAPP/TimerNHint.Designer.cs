namespace TimerandHintAPP
{
    partial class TimerNhint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Time = new System.Windows.Forms.Label();
            this.richTextHint = new System.Windows.Forms.RichTextBox();
            this.BUT_timerSubmit = new System.Windows.Forms.Button();
            this.but_HIntSubmit = new System.Windows.Forms.Button();
            this.textAddsec = new System.Windows.Forms.TextBox();
            this.But_Stop = new System.Windows.Forms.Button();
            this.but_AddTime = new System.Windows.Forms.Button();
            this.textAddMin = new System.Windows.Forms.TextBox();
            this.lb_Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(51, 57);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(79, 36);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "Time";
            // 
            // richTextHint
            // 
            this.richTextHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextHint.Location = new System.Drawing.Point(7, 184);
            this.richTextHint.Margin = new System.Windows.Forms.Padding(2);
            this.richTextHint.Name = "richTextHint";
            this.richTextHint.Size = new System.Drawing.Size(321, 183);
            this.richTextHint.TabIndex = 1;
            this.richTextHint.Text = "";
            // 
            // BUT_timerSubmit
            // 
            this.BUT_timerSubmit.Location = new System.Drawing.Point(376, 58);
            this.BUT_timerSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BUT_timerSubmit.Name = "BUT_timerSubmit";
            this.BUT_timerSubmit.Size = new System.Drawing.Size(85, 42);
            this.BUT_timerSubmit.TabIndex = 2;
            this.BUT_timerSubmit.Text = "TimerSubmit";
            this.BUT_timerSubmit.UseVisualStyleBackColor = true;
            this.BUT_timerSubmit.Click += new System.EventHandler(this.BUT_timerSubmit_Click);
            // 
            // but_HIntSubmit
            // 
            this.but_HIntSubmit.Location = new System.Drawing.Point(376, 313);
            this.but_HIntSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.but_HIntSubmit.Name = "but_HIntSubmit";
            this.but_HIntSubmit.Size = new System.Drawing.Size(104, 44);
            this.but_HIntSubmit.TabIndex = 3;
            this.but_HIntSubmit.Text = "HintSubmit";
            this.but_HIntSubmit.UseVisualStyleBackColor = true;
            this.but_HIntSubmit.Click += new System.EventHandler(this.but_HIntSubmit_Click);
            // 
            // textAddsec
            // 
            this.textAddsec.Location = new System.Drawing.Point(149, 140);
            this.textAddsec.Margin = new System.Windows.Forms.Padding(2);
            this.textAddsec.Name = "textAddsec";
            this.textAddsec.Size = new System.Drawing.Size(52, 20);
            this.textAddsec.TabIndex = 4;
            // 
            // But_Stop
            // 
            this.But_Stop.Location = new System.Drawing.Point(376, 118);
            this.But_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.But_Stop.Name = "But_Stop";
            this.But_Stop.Size = new System.Drawing.Size(85, 42);
            this.But_Stop.TabIndex = 5;
            this.But_Stop.Text = "Stop";
            this.But_Stop.UseVisualStyleBackColor = true;
            this.But_Stop.Click += new System.EventHandler(this.But_STOPCLICK);
            // 
            // but_AddTime
            // 
            this.but_AddTime.Location = new System.Drawing.Point(240, 126);
            this.but_AddTime.Margin = new System.Windows.Forms.Padding(2);
            this.but_AddTime.Name = "but_AddTime";
            this.but_AddTime.Size = new System.Drawing.Size(74, 34);
            this.but_AddTime.TabIndex = 6;
            this.but_AddTime.Text = "Addtime";
            this.but_AddTime.UseVisualStyleBackColor = true;
            this.but_AddTime.Click += new System.EventHandler(this.but_AddTime_Click);
            // 
            // textAddMin
            // 
            this.textAddMin.Location = new System.Drawing.Point(57, 140);
            this.textAddMin.Margin = new System.Windows.Forms.Padding(2);
            this.textAddMin.Name = "textAddMin";
            this.textAddMin.Size = new System.Drawing.Size(52, 20);
            this.textAddMin.TabIndex = 7;
            // 
            // lb_Error
            // 
            this.lb_Error.AutoSize = true;
            this.lb_Error.Location = new System.Drawing.Point(11, 369);
            this.lb_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(43, 13);
            this.lb_Error.TabIndex = 8;
            this.lb_Error.Text = "lb_Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sec(1-59)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Min(1-59)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 423);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.But_Stop);
            this.tabPage1.Controls.Add(this.lb_Error);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lb_Time);
            this.tabPage1.Controls.Add(this.BUT_timerSubmit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextHint);
            this.tabPage1.Controls.Add(this.but_HIntSubmit);
            this.tabPage1.Controls.Add(this.textAddMin);
            this.tabPage1.Controls.Add(this.but_AddTime);
            this.tabPage1.Controls.Add(this.textAddsec);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(506, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(665, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TimerNhint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 423);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimerNhint";
            this.Text = "TimerNHint";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.RichTextBox richTextHint;
        private System.Windows.Forms.Button BUT_timerSubmit;
        private System.Windows.Forms.Button but_HIntSubmit;
        private System.Windows.Forms.TextBox textAddsec;
        private System.Windows.Forms.Button But_Stop;
        private System.Windows.Forms.Button but_AddTime;
        private System.Windows.Forms.TextBox textAddMin;
        private System.Windows.Forms.Label lb_Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

