
namespace UserMaintenance
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 20;
            this.listUsers.Location = new System.Drawing.Point(30, 86);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(292, 344);
            this.listUsers.TabIndex = 0;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(454, 154);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(51, 20);
            this.labelFN.TabIndex = 1;
            this.labelFN.Text = "label1";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(511, 154);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(192, 26);
            this.textBoxFN.TabIndex = 3;
            this.textBoxFN.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(458, 252);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(245, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(458, 323);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(245, 31);
            this.buttonFile.TabIndex = 6;
            this.buttonFile.Text = "button";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(458, 289);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(245, 31);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "button";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonDel;
    }
}

