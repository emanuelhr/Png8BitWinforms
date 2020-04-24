namespace Png8BitCadenas
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_convert = new System.Windows.Forms.Button();
            this.tbox_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_repotBug = new System.Windows.Forms.Label();
            this.chk_jpg = new System.Windows.Forms.CheckBox();
            this.chk_png = new System.Windows.Forms.CheckBox();
            this.chk_bmp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_removeFromList = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_additionalFormats = new System.Windows.Forms.TextBox();
            this.btn_addFormat = new System.Windows.Forms.Button();
            this.btn_removeFormat = new System.Windows.Forms.PictureBox();
            this.lst_foldersFiles = new System.Windows.Forms.ListBox();
            this.lbl_dropFiles = new System.Windows.Forms.Label();
            this.lst_formats = new System.Windows.Forms.ListBox();
            this.tbox_width = new System.Windows.Forms.TextBox();
            this.tbox_height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_deleteOriginal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeFromList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_convert.Location = new System.Drawing.Point(13, 345);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(279, 28);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // tbox_output
            // 
            this.tbox_output.Location = new System.Drawing.Point(401, 28);
            this.tbox_output.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_output.Name = "tbox_output";
            this.tbox_output.ReadOnly = true;
            this.tbox_output.Size = new System.Drawing.Size(383, 330);
            this.tbox_output.TabIndex = 2;
            this.tbox_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output";
            // 
            // lbl_repotBug
            // 
            this.lbl_repotBug.AutoSize = true;
            this.lbl_repotBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_repotBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repotBug.Location = new System.Drawing.Point(709, 362);
            this.lbl_repotBug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_repotBug.Name = "lbl_repotBug";
            this.lbl_repotBug.Size = new System.Drawing.Size(75, 16);
            this.lbl_repotBug.TabIndex = 4;
            this.lbl_repotBug.Text = "Report bug";
            this.lbl_repotBug.Click += new System.EventHandler(this.lbl_repotBug_Click);
            // 
            // chk_jpg
            // 
            this.chk_jpg.AutoSize = true;
            this.chk_jpg.Checked = true;
            this.chk_jpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_jpg.Location = new System.Drawing.Point(13, 52);
            this.chk_jpg.Margin = new System.Windows.Forms.Padding(4);
            this.chk_jpg.Name = "chk_jpg";
            this.chk_jpg.Size = new System.Drawing.Size(46, 20);
            this.chk_jpg.TabIndex = 5;
            this.chk_jpg.Text = "jpg";
            this.chk_jpg.UseVisualStyleBackColor = true;
            // 
            // chk_png
            // 
            this.chk_png.AutoSize = true;
            this.chk_png.Location = new System.Drawing.Point(65, 52);
            this.chk_png.Margin = new System.Windows.Forms.Padding(4);
            this.chk_png.Name = "chk_png";
            this.chk_png.Size = new System.Drawing.Size(50, 20);
            this.chk_png.TabIndex = 6;
            this.chk_png.Text = "png";
            this.chk_png.UseVisualStyleBackColor = true;
            // 
            // chk_bmp
            // 
            this.chk_bmp.AutoSize = true;
            this.chk_bmp.Location = new System.Drawing.Point(32, 73);
            this.chk_bmp.Margin = new System.Windows.Forms.Padding(4);
            this.chk_bmp.Name = "chk_bmp";
            this.chk_bmp.Size = new System.Drawing.Size(54, 20);
            this.chk_bmp.TabIndex = 7;
            this.chk_bmp.Text = "bmp";
            this.chk_bmp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select formats to convert from : ";
            // 
            // btn_removeFromList
            // 
            this.btn_removeFromList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeFromList.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeFromList.Image")));
            this.btn_removeFromList.Location = new System.Drawing.Point(295, 126);
            this.btn_removeFromList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeFromList.Name = "btn_removeFromList";
            this.btn_removeFromList.Size = new System.Drawing.Size(20, 21);
            this.btn_removeFromList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_removeFromList.TabIndex = 11;
            this.btn_removeFromList.TabStop = false;
            this.btn_removeFromList.Click += new System.EventHandler(this.btn_removeFromList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Additional formats: ";
            // 
            // tbox_additionalFormats
            // 
            this.tbox_additionalFormats.Location = new System.Drawing.Point(252, 6);
            this.tbox_additionalFormats.MaxLength = 6;
            this.tbox_additionalFormats.Name = "tbox_additionalFormats";
            this.tbox_additionalFormats.Size = new System.Drawing.Size(41, 22);
            this.tbox_additionalFormats.TabIndex = 13;
            // 
            // btn_addFormat
            // 
            this.btn_addFormat.AutoSize = true;
            this.btn_addFormat.BackColor = System.Drawing.Color.Lime;
            this.btn_addFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFormat.Location = new System.Drawing.Point(299, 4);
            this.btn_addFormat.Name = "btn_addFormat";
            this.btn_addFormat.Size = new System.Drawing.Size(25, 26);
            this.btn_addFormat.TabIndex = 14;
            this.btn_addFormat.Text = "+";
            this.btn_addFormat.UseVisualStyleBackColor = false;
            this.btn_addFormat.Click += new System.EventHandler(this.btn_addFormat_Click);
            // 
            // btn_removeFormat
            // 
            this.btn_removeFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeFormat.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeFormat.Image")));
            this.btn_removeFormat.Location = new System.Drawing.Point(302, 28);
            this.btn_removeFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeFormat.Name = "btn_removeFormat";
            this.btn_removeFormat.Size = new System.Drawing.Size(16, 20);
            this.btn_removeFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_removeFormat.TabIndex = 15;
            this.btn_removeFormat.TabStop = false;
            this.btn_removeFormat.Click += new System.EventHandler(this.btn_removeFormat_Click);
            // 
            // lst_foldersFiles
            // 
            this.lst_foldersFiles.AllowDrop = true;
            this.lst_foldersFiles.FormattingEnabled = true;
            this.lst_foldersFiles.ItemHeight = 16;
            this.lst_foldersFiles.Location = new System.Drawing.Point(13, 126);
            this.lst_foldersFiles.Name = "lst_foldersFiles";
            this.lst_foldersFiles.Size = new System.Drawing.Size(280, 212);
            this.lst_foldersFiles.TabIndex = 17;
            this.lst_foldersFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragDrop);
            this.lst_foldersFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            this.lst_foldersFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_foldersFiles_KeyDown);
            
            // 
            // lbl_dropFiles
            // 
            this.lbl_dropFiles.AllowDrop = true;
            this.lbl_dropFiles.AutoSize = true;
            this.lbl_dropFiles.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_dropFiles.Enabled = false;
            this.lbl_dropFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dropFiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dropFiles.Location = new System.Drawing.Point(87, 220);
            this.lbl_dropFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dropFiles.Name = "lbl_dropFiles";
            this.lbl_dropFiles.Size = new System.Drawing.Size(138, 20);
            this.lbl_dropFiles.TabIndex = 18;
            this.lbl_dropFiles.Text = "Drop files or folder";
            // 
            // lst_formats
            // 
            this.lst_formats.FormattingEnabled = true;
            this.lst_formats.ItemHeight = 16;
            this.lst_formats.Location = new System.Drawing.Point(252, 28);
            this.lst_formats.Name = "lst_formats";
            this.lst_formats.Size = new System.Drawing.Size(41, 68);
            this.lst_formats.TabIndex = 19;
            // 
            // tbox_width
            // 
            this.tbox_width.Location = new System.Drawing.Point(332, 186);
            this.tbox_width.Name = "tbox_width";
            this.tbox_width.Size = new System.Drawing.Size(43, 22);
            this.tbox_width.TabIndex = 21;
            this.tbox_width.Text = "400";
            this.tbox_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_width_KeyPress);
            // 
            // tbox_height
            // 
            this.tbox_height.Location = new System.Drawing.Point(332, 215);
            this.tbox_height.Name = "tbox_height";
            this.tbox_height.Size = new System.Drawing.Size(43, 22);
            this.tbox_height.TabIndex = 22;
            this.tbox_height.Text = "400";
            this.tbox_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_height_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "W: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "H: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Custom size :";
            // 
            // chk_deleteOriginal
            // 
            this.chk_deleteOriginal.AutoSize = true;
            this.chk_deleteOriginal.Location = new System.Drawing.Point(13, 100);
            this.chk_deleteOriginal.Name = "chk_deleteOriginal";
            this.chk_deleteOriginal.Size = new System.Drawing.Size(164, 20);
            this.chk_deleteOriginal.TabIndex = 26;
            this.chk_deleteOriginal.Text = "Delete original pictures";
            this.chk_deleteOriginal.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 386);
            this.Controls.Add(this.chk_deleteOriginal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_height);
            this.Controls.Add(this.tbox_width);
            this.Controls.Add(this.lst_formats);
            this.Controls.Add(this.lbl_dropFiles);
            this.Controls.Add(this.lst_foldersFiles);
            this.Controls.Add(this.btn_removeFormat);
            this.Controls.Add(this.btn_addFormat);
            this.Controls.Add(this.tbox_additionalFormats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_removeFromList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_bmp);
            this.Controls.Add(this.chk_png);
            this.Controls.Add(this.chk_jpg);
            this.Controls.Add(this.lbl_repotBug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_output);
            this.Controls.Add(this.btn_convert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Png8Bit";
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeFromList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeFormat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.RichTextBox tbox_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_repotBug;
        private System.Windows.Forms.CheckBox chk_jpg;
        private System.Windows.Forms.CheckBox chk_png;
        private System.Windows.Forms.CheckBox chk_bmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_removeFromList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_additionalFormats;
        private System.Windows.Forms.Button btn_addFormat;
        private System.Windows.Forms.PictureBox btn_removeFormat;
        private System.Windows.Forms.ListBox lst_foldersFiles;
        private System.Windows.Forms.Label lbl_dropFiles;
        private System.Windows.Forms.ListBox lst_formats;
        private System.Windows.Forms.TextBox tbox_width;
        private System.Windows.Forms.TextBox tbox_height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_deleteOriginal;
    }
}

