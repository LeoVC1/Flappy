﻿namespace FlappyBird
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.pbGameTitle = new System.Windows.Forms.PictureBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Credits = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pb_Credits = new System.Windows.Forms.PictureBox();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Credits)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameTitle
            // 
            this.pbGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbGameTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbGameTitle.Image")));
            this.pbGameTitle.Location = new System.Drawing.Point(82, 50);
            this.pbGameTitle.Name = "pbGameTitle";
            this.pbGameTitle.Size = new System.Drawing.Size(609, 85);
            this.pbGameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameTitle.TabIndex = 18;
            this.pbGameTitle.TabStop = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(12, 536);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(294, 16);
            this.lbl_Info.TabIndex = 21;
            this.lbl_Info.Text = "DEVELOPED BY: PROCRASTINATORS © 2019";
            // 
            // btn_Credits
            // 
            this.btn_Credits.BackColor = System.Drawing.Color.Transparent;
            this.btn_Credits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Credits.BackgroundImage")));
            this.btn_Credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Credits.FlatAppearance.BorderSize = 0;
            this.btn_Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Credits.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credits.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Credits.Location = new System.Drawing.Point(260, 340);
            this.btn_Credits.Name = "btn_Credits";
            this.btn_Credits.Size = new System.Drawing.Size(233, 55);
            this.btn_Credits.TabIndex = 19;
            this.btn_Credits.UseVisualStyleBackColor = false;
            this.btn_Credits.Click += new System.EventHandler(this.btn_Credits_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Play.BackgroundImage")));
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(260, 251);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(233, 55);
            this.btn_Play.TabIndex = 17;
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(260, 427);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(233, 56);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pb_Credits
            // 
            this.pb_Credits.BackColor = System.Drawing.Color.Transparent;
            this.pb_Credits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Credits.BackgroundImage")));
            this.pb_Credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Credits.Enabled = false;
            this.pb_Credits.Location = new System.Drawing.Point(81, 111);
            this.pb_Credits.Name = "pb_Credits";
            this.pb_Credits.Size = new System.Drawing.Size(609, 284);
            this.pb_Credits.TabIndex = 23;
            this.pb_Credits.TabStop = false;
            this.pb_Credits.Visible = false;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Quit.BackgroundImage")));
            this.btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(260, 427);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(233, 56);
            this.btn_Quit.TabIndex = 20;
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("SmackyFormula", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Score.Location = new System.Drawing.Point(338, 27);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(82, 81);
            this.lbl_Score.TabIndex = 24;
            this.lbl_Score.Text = "0";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Score.Visible = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.pbGameTitle);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btn_Credits);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.pb_Credits);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBird";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Credits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameTitle;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button btn_Credits;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pb_Credits;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_Score;
    }
}
