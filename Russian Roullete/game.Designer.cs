namespace Russian_Roullete
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.loadbut = new System.Windows.Forms.Button();
            this.spinbut = new System.Windows.Forms.Button();
            this.shootbut = new System.Windows.Forms.Button();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadbut
            // 
            this.loadbut.BackColor = System.Drawing.Color.Black;
            this.loadbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbut.ForeColor = System.Drawing.Color.Red;
            this.loadbut.Location = new System.Drawing.Point(18, 168);
            this.loadbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadbut.Name = "loadbut";
            this.loadbut.Size = new System.Drawing.Size(190, 108);
            this.loadbut.TabIndex = 1;
            this.loadbut.Text = "Load";
            this.loadbut.UseVisualStyleBackColor = false;
            this.loadbut.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // spinbut
            // 
            this.spinbut.BackColor = System.Drawing.Color.Black;
            this.spinbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spinbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinbut.ForeColor = System.Drawing.Color.Red;
            this.spinbut.Location = new System.Drawing.Point(18, 549);
            this.spinbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinbut.Name = "spinbut";
            this.spinbut.Size = new System.Drawing.Size(190, 112);
            this.spinbut.TabIndex = 2;
            this.spinbut.Text = "Spin";
            this.spinbut.UseVisualStyleBackColor = false;
            this.spinbut.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // shootbut
            // 
            this.shootbut.BackColor = System.Drawing.Color.Black;
            this.shootbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shootbut.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootbut.ForeColor = System.Drawing.Color.Red;
            this.shootbut.Location = new System.Drawing.Point(530, 562);
            this.shootbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shootbut.Name = "shootbut";
            this.shootbut.Size = new System.Drawing.Size(197, 112);
            this.shootbut.TabIndex = 3;
            this.shootbut.Text = "Shoot";
            this.shootbut.UseVisualStyleBackColor = false;
            this.shootbut.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonRetry
            // 
            this.buttonRetry.BackColor = System.Drawing.Color.Black;
            this.buttonRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetry.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetry.ForeColor = System.Drawing.Color.Red;
            this.buttonRetry.Location = new System.Drawing.Point(1050, 549);
            this.buttonRetry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(198, 112);
            this.buttonRetry.TabIndex = 5;
            this.buttonRetry.Text = "Retry";
            this.buttonRetry.UseVisualStyleBackColor = false;
            this.buttonRetry.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(481, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 65);
            this.label2.TabIndex = 7;
            this.label2.Text = "Russian Roullete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1078, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 108);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.shootbut);
            this.Controls.Add(this.spinbut);
            this.Controls.Add(this.loadbut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "game";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadbut;
        private System.Windows.Forms.Button spinbut;
        private System.Windows.Forms.Button shootbut;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}