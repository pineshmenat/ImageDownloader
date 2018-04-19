namespace ImageDownloader
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlImages = new System.Windows.Forms.TabControl();
            this.tabPageInstagram = new System.Windows.Forms.TabPage();
            this.tabPageBing = new System.Windows.Forms.TabPage();
            this.buttonSetAsWallpaper = new System.Windows.Forms.Button();
            this.buttonSaveInstagram = new System.Windows.Forms.Button();
            this.textBoxInstagramUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(774, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 473);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlImages
            // 
            this.tabControlImages.Controls.Add(this.tabPageInstagram);
            this.tabControlImages.Controls.Add(this.tabPageBing);
            this.tabControlImages.Location = new System.Drawing.Point(21, 32);
            this.tabControlImages.Name = "tabControlImages";
            this.tabControlImages.SelectedIndex = 0;
            this.tabControlImages.Size = new System.Drawing.Size(731, 650);
            this.tabControlImages.TabIndex = 2;
            // 
            // tabPageInstagram
            // 
            this.tabPageInstagram.AutoScroll = true;
            this.tabPageInstagram.Location = new System.Drawing.Point(4, 25);
            this.tabPageInstagram.Name = "tabPageInstagram";
            this.tabPageInstagram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstagram.Size = new System.Drawing.Size(723, 621);
            this.tabPageInstagram.TabIndex = 0;
            this.tabPageInstagram.Text = "Instagram";
            this.tabPageInstagram.UseVisualStyleBackColor = true;
            // 
            // tabPageBing
            // 
            this.tabPageBing.AutoScroll = true;
            this.tabPageBing.Location = new System.Drawing.Point(4, 25);
            this.tabPageBing.Name = "tabPageBing";
            this.tabPageBing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBing.Size = new System.Drawing.Size(723, 621);
            this.tabPageBing.TabIndex = 1;
            this.tabPageBing.Text = "Bing";
            this.tabPageBing.UseVisualStyleBackColor = true;
            // 
            // buttonSetAsWallpaper
            // 
            this.buttonSetAsWallpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAsWallpaper.Location = new System.Drawing.Point(774, 609);
            this.buttonSetAsWallpaper.Name = "buttonSetAsWallpaper";
            this.buttonSetAsWallpaper.Size = new System.Drawing.Size(684, 69);
            this.buttonSetAsWallpaper.TabIndex = 3;
            this.buttonSetAsWallpaper.Text = "Set as wallpaper";
            this.buttonSetAsWallpaper.UseVisualStyleBackColor = true;
            this.buttonSetAsWallpaper.Click += new System.EventHandler(this.buttonSetAsWallpaper_Click);
            // 
            // buttonSaveInstagram
            // 
            this.buttonSaveInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveInstagram.Location = new System.Drawing.Point(1348, 62);
            this.buttonSaveInstagram.Name = "buttonSaveInstagram";
            this.buttonSaveInstagram.Size = new System.Drawing.Size(110, 24);
            this.buttonSaveInstagram.TabIndex = 4;
            this.buttonSaveInstagram.Text = "Save";
            this.buttonSaveInstagram.UseVisualStyleBackColor = true;
            this.buttonSaveInstagram.Click += new System.EventHandler(this.buttonSaveInstagram_Click);
            // 
            // textBoxInstagramUrl
            // 
            this.textBoxInstagramUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxInstagramUrl.Location = new System.Drawing.Point(899, 62);
            this.textBoxInstagramUrl.Name = "textBoxInstagramUrl";
            this.textBoxInstagramUrl.Size = new System.Drawing.Size(434, 24);
            this.textBoxInstagramUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(769, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instagram URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInstagramUrl);
            this.Controls.Add(this.buttonSaveInstagram);
            this.Controls.Add(this.buttonSetAsWallpaper);
            this.Controls.Add(this.tabControlImages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlImages;
        private System.Windows.Forms.TabPage tabPageInstagram;
        private System.Windows.Forms.TabPage tabPageBing;
        private System.Windows.Forms.Button buttonSetAsWallpaper;
        private System.Windows.Forms.Button buttonSaveInstagram;
        private System.Windows.Forms.TextBox textBoxInstagramUrl;
        private System.Windows.Forms.Label label2;
    }
}

