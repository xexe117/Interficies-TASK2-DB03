namespace productLibrary
{
    partial class Menu
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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.serchButt = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(3, 10);
            this.listBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(380, 20);
            this.listBoxInfo.TabIndex = 16;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(388, 77);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(324, 336);
            this.flowLayoutPanel.TabIndex = 15;
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(388, 41);
            this.findTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(149, 28);
            this.findTextBox.TabIndex = 14;
            // 
            // serchButt
            // 
            this.serchButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchButt.Location = new System.Drawing.Point(539, 41);
            this.serchButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serchButt.Name = "serchButt";
            this.serchButt.Size = new System.Drawing.Size(87, 31);
            this.serchButt.TabIndex = 13;
            this.serchButt.Text = "Buscar";
            this.serchButt.UseVisualStyleBackColor = true;
            this.serchButt.Click += new System.EventHandler(this.serchButt_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(3, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.serchButt);
            this.Controls.Add(this.pictureBox);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(759, 426);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button serchButt;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
