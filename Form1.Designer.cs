namespace DoThanhTan
{
    partial class Pictures
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
            this.components = new System.ComponentModel.Container();
            this.linkavartar = new System.Windows.Forms.LinkLabel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // linkavartar
            // 
            this.linkavartar.AutoSize = true;
            this.linkavartar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkavartar.Location = new System.Drawing.Point(400, 379);
            this.linkavartar.Name = "linkavartar";
            this.linkavartar.Size = new System.Drawing.Size(112, 19);
            this.linkavartar.TabIndex = 1;
            this.linkavartar.TabStop = true;
            this.linkavartar.Text = "Choose image";
            this.linkavartar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkavartar_LinkClicked);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Image = global::DoThanhTan.Properties.Resources.anh_bia_facebook_hacker_anonymous_kem_status_doc_dao_9;
            this.picture.Location = new System.Drawing.Point(24, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(859, 308);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.linkavartar);
            this.Controls.Add(this.picture);
            this.Name = "Pictures";
            this.Text = "Thông tin về ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.LinkLabel linkavartar;
        private System.Windows.Forms.Timer timer;
    }
}

