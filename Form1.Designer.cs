namespace tic_tac_toe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Turn = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pb_Background = new System.Windows.Forms.PictureBox();
            this.lb_Winner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(324, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tic Tac Toe Game";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(856, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 71);
            this.label10.TabIndex = 11;
            this.label10.Text = "Turn : ";
            // 
            // lb_Turn
            // 
            this.lb_Turn.AutoSize = true;
            this.lb_Turn.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Turn.ForeColor = System.Drawing.Color.Red;
            this.lb_Turn.Location = new System.Drawing.Point(950, 232);
            this.lb_Turn.Name = "lb_Turn";
            this.lb_Turn.Size = new System.Drawing.Size(164, 54);
            this.lb_Turn.TabIndex = 12;
            this.lb_Turn.Text = "player1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(856, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 71);
            this.label11.TabIndex = 13;
            this.label11.Text = "Winner : ";
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.Peru;
            this.btn_Restart.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btn_Restart.FlatAppearance.BorderSize = 4;
            this.btn_Restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Restart.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Restart.Location = new System.Drawing.Point(868, 502);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(277, 67);
            this.btn_Restart.TabIndex = 15;
            this.btn_Restart.Text = "Restart Game";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(146, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 157);
            this.button1.TabIndex = 1;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(615, 477);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 154);
            this.button9.TabIndex = 10;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(393, 474);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 157);
            this.button8.TabIndex = 9;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(162, 477);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 154);
            this.button7.TabIndex = 8;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(615, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 157);
            this.button6.TabIndex = 6;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(393, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 157);
            this.button5.TabIndex = 5;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(153, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 157);
            this.button4.TabIndex = 4;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(615, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 157);
            this.button3.TabIndex = 3;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(394, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 157);
            this.button2.TabIndex = 2;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // pb_Background
            // 
            this.pb_Background.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Background.Image = global::tic_tac_toe.Properties.Resources.v662_peipei_38_memphis;
            this.pb_Background.Location = new System.Drawing.Point(0, 0);
            this.pb_Background.Name = "pb_Background";
            this.pb_Background.Size = new System.Drawing.Size(1232, 610);
            this.pb_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Background.TabIndex = 0;
            this.pb_Background.TabStop = false;
            this.pb_Background.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lb_Winner
            // 
            this.lb_Winner.AutoSize = true;
            this.lb_Winner.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Winner.ForeColor = System.Drawing.Color.Red;
            this.lb_Winner.Location = new System.Drawing.Point(950, 392);
            this.lb_Winner.Name = "lb_Winner";
            this.lb_Winner.Size = new System.Drawing.Size(233, 54);
            this.lb_Winner.TabIndex = 34;
            this.lb_Winner.Text = "In Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 610);
            this.Controls.Add(this.lb_Winner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_Turn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_Turn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lb_Winner;
    }
}

