namespace WindowsFormsApplication6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rightplayerscore = new System.Windows.Forms.Label();
            this.leftplayerscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.Location = new System.Drawing.Point(12, 127);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(23, 114);
            this.left.TabIndex = 0;
            this.left.TabStop = false;
            // 
            // right
            // 
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.Location = new System.Drawing.Point(776, 364);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(23, 114);
            this.right.TabIndex = 1;
            this.right.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(68, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 16);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // rightplayerscore
            // 
            this.rightplayerscore.AutoSize = true;
            this.rightplayerscore.BackColor = System.Drawing.Color.Transparent;
            this.rightplayerscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightplayerscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightplayerscore.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightplayerscore.Location = new System.Drawing.Point(489, 9);
            this.rightplayerscore.Name = "rightplayerscore";
            this.rightplayerscore.Size = new System.Drawing.Size(38, 44);
            this.rightplayerscore.TabIndex = 4;
            this.rightplayerscore.Text = "0";
            // 
            // leftplayerscore
            // 
            this.leftplayerscore.AutoSize = true;
            this.leftplayerscore.BackColor = System.Drawing.Color.Transparent;
            this.leftplayerscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftplayerscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftplayerscore.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftplayerscore.Location = new System.Drawing.Point(268, 12);
            this.leftplayerscore.Name = "leftplayerscore";
            this.leftplayerscore.Size = new System.Drawing.Size(38, 44);
            this.leftplayerscore.TabIndex = 5;
            this.leftplayerscore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.leftplayerscore);
            this.Controls.Add(this.rightplayerscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PongPing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rightplayerscore;
        private System.Windows.Forms.Label leftplayerscore;
    }
}

