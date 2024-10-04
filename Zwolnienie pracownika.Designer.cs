namespace HomeWorkTydzien5Lekcja27
{
    partial class Zwolnienie_pracownika
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSalaryAmount = new System.Windows.Forms.TextBox();
            this.tbDateOfEmployment = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz datę zwolnienia:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(52, 95);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(363, 24);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(10, 20);
            this.tbId.TabIndex = 24;
            this.tbId.Visible = false;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(363, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(10, 20);
            this.tbLastName.TabIndex = 25;
            this.tbLastName.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(363, 76);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(10, 20);
            this.tbFirstName.TabIndex = 26;
            this.tbFirstName.Visible = false;
            // 
            // tbSalaryAmount
            // 
            this.tbSalaryAmount.Location = new System.Drawing.Point(363, 102);
            this.tbSalaryAmount.Name = "tbSalaryAmount";
            this.tbSalaryAmount.Size = new System.Drawing.Size(10, 20);
            this.tbSalaryAmount.TabIndex = 27;
            this.tbSalaryAmount.Visible = false;
            // 
            // tbDateOfEmployment
            // 
            this.tbDateOfEmployment.Location = new System.Drawing.Point(363, 128);
            this.tbDateOfEmployment.Name = "tbDateOfEmployment";
            this.tbDateOfEmployment.Size = new System.Drawing.Size(10, 20);
            this.tbDateOfEmployment.TabIndex = 28;
            this.tbDateOfEmployment.Visible = false;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(347, 21);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(10, 132);
            this.rtbComments.TabIndex = 29;
            this.rtbComments.Text = "";
            this.rtbComments.Visible = false;
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.Location = new System.Drawing.Point(331, 76);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(10, 20);
            this.tbReleaseDate.TabIndex = 18;
            this.tbReleaseDate.Visible = false;
            // 
            // Zwolnienie_pracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 131);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbDateOfEmployment);
            this.Controls.Add(this.tbSalaryAmount);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbReleaseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximumSize = new System.Drawing.Size(304, 170);
            this.Name = "Zwolnienie_pracownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zwolnienie_pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSalaryAmount;
        private System.Windows.Forms.TextBox tbDateOfEmployment;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TextBox tbReleaseDate;
    }
}