namespace ComputingProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.tool = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ParenLogin = new System.Windows.Forms.Button();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Login Option";
            // 
            // ParenLogin
            // 
            this.ParenLogin.BackColor = System.Drawing.Color.Silver;
            this.ParenLogin.Location = new System.Drawing.Point(31, 29);
            this.ParenLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParenLogin.Name = "ParenLogin";
            this.ParenLogin.Size = new System.Drawing.Size(58, 47);
            this.ParenLogin.TabIndex = 4;
            this.ParenLogin.Text = "Parent Login";
            this.ParenLogin.UseVisualStyleBackColor = false;
            this.ParenLogin.Click += new System.EventHandler(this.ParenLogin_Click);
            // 
            // StudentLogin
            // 
            this.StudentLogin.BackColor = System.Drawing.Color.Silver;
            this.StudentLogin.Location = new System.Drawing.Point(95, 29);
            this.StudentLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(59, 47);
            this.StudentLogin.TabIndex = 5;
            this.StudentLogin.Text = "Student Login";
            this.StudentLogin.UseVisualStyleBackColor = false;
            this.StudentLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Silver;
            this.Create.Location = new System.Drawing.Point(31, 84);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(123, 32);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create Your Account";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(195, 132);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.StudentLogin);
            this.Controls.Add(this.ParenLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ParenLogin;
        private System.Windows.Forms.Button StudentLogin;
        private System.Windows.Forms.Button Create;
    }
}

