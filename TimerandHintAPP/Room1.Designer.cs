namespace TimerandHintAPP
{
    partial class Room1
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
            this.lb_room1timer = new System.Windows.Forms.Label();
            this.lb_HintRoom1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_room1timer
            // 
            this.lb_room1timer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_room1timer.AutoSize = true;
            this.lb_room1timer.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_room1timer.Location = new System.Drawing.Point(694, 161);
            this.lb_room1timer.Name = "lb_room1timer";
            this.lb_room1timer.Size = new System.Drawing.Size(326, 106);
            this.lb_room1timer.TabIndex = 0;
            this.lb_room1timer.Text = "Timer";
            // 
            // lb_HintRoom1
            // 
            this.lb_HintRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HintRoom1.AutoSize = true;
            this.lb_HintRoom1.Font = new System.Drawing.Font("Perpetua Titling MT", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintRoom1.Location = new System.Drawing.Point(67, 428);
            this.lb_HintRoom1.Name = "lb_HintRoom1";
            this.lb_HintRoom1.Size = new System.Drawing.Size(71, 64);
            this.lb_HintRoom1.TabIndex = 1;
            this.lb_HintRoom1.Text = "k";
            // 
            // Room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 643);
            this.Controls.Add(this.lb_HintRoom1);
            this.Controls.Add(this.lb_room1timer);
            this.Name = "Room1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_room1timer;
        private System.Windows.Forms.Label lb_HintRoom1;
    }
}