namespace Project_Alpha
{
    partial class Games
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.personal_game_ls1 = new Project_Alpha.Custom_List_File.personal_game_ls();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.personal_game_ls1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 684);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // personal_game_ls1
            // 
            this.personal_game_ls1.gamePic = null;
            this.personal_game_ls1.Location = new System.Drawing.Point(3, 3);
            this.personal_game_ls1.Name = "personal_game_ls1";
            this.personal_game_ls1.Size = new System.Drawing.Size(277, 150);
            this.personal_game_ls1.TabIndex = 0;
            this.personal_game_ls1.Visible = false;
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(1020, 684);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Custom_List_File.personal_game_ls personal_game_ls1;
    }
}
