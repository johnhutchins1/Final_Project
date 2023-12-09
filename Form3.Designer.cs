
namespace project_chap_6
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumVoters = new System.Windows.Forms.Button();
            this.txtNumVoters = new System.Windows.Forms.TextBox();
            this.lblLead = new System.Windows.Forms.Label();
            this.lblLead2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(156, 239);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(153, 53);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Vote Red!";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.Location = new System.Drawing.Point(156, 166);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(153, 53);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Vote Blue!";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(749, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.Location = new System.Drawing.Point(101, 351);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(183, 62);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Display Election Results!";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(329, 365);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(289, 30);
            this.txtResults.TabIndex = 4;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(371, 256);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(65, 22);
            this.txtRed.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(371, 182);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(65, 22);
            this.txtBlue.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(284, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 32);
            this.lblName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter total number of voters:";
            // 
            // btnNumVoters
            // 
            this.btnNumVoters.Location = new System.Drawing.Point(704, 218);
            this.btnNumVoters.Name = "btnNumVoters";
            this.btnNumVoters.Size = new System.Drawing.Size(75, 23);
            this.btnNumVoters.TabIndex = 9;
            this.btnNumVoters.Text = "button1";
            this.btnNumVoters.UseVisualStyleBackColor = true;
            this.btnNumVoters.Visible = false;
            this.btnNumVoters.Click += new System.EventHandler(this.btnNumVoters_Click);
            // 
            // txtNumVoters
            // 
            this.txtNumVoters.Location = new System.Drawing.Point(371, 102);
            this.txtNumVoters.Name = "txtNumVoters";
            this.txtNumVoters.Size = new System.Drawing.Size(65, 22);
            this.txtNumVoters.TabIndex = 10;
            this.txtNumVoters.TextChanged += new System.EventHandler(this.txtNumVoters_TextChanged);
            // 
            // lblLead
            // 
            this.lblLead.AutoSize = true;
            this.lblLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLead.Location = new System.Drawing.Point(275, 295);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(0, 17);
            this.lblLead.TabIndex = 12;
            // 
            // lblLead2
            // 
            this.lblLead2.AutoSize = true;
            this.lblLead2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLead2.Location = new System.Drawing.Point(377, 218);
            this.lblLead2.Name = "lblLead2";
            this.lblLead2.Size = new System.Drawing.Size(59, 20);
            this.lblLead2.TabIndex = 13;
            this.lblLead2.Text = "label2";
            this.lblLead2.Visible = false;
            this.lblLead2.Click += new System.EventHandler(this.lblLead2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLead2);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.txtNumVoters);
            this.Controls.Add(this.btnNumVoters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumVoters;
        private System.Windows.Forms.TextBox txtNumVoters;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Label lblLead2;
    }
}