namespace FormaProgram
{
    partial class Form2
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
            this.labelNameForm2 = new System.Windows.Forms.Label();
            this.labeldescForm2 = new System.Windows.Forms.Label();
            this.textBoxNameForm2 = new System.Windows.Forms.TextBox();
            this.textBoxDescriptonForm2 = new System.Windows.Forms.TextBox();
            this.button1Ok = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameForm2
            // 
            this.labelNameForm2.AutoSize = true;
            this.labelNameForm2.Location = new System.Drawing.Point(33, 16);
            this.labelNameForm2.Name = "labelNameForm2";
            this.labelNameForm2.Size = new System.Drawing.Size(78, 13);
            this.labelNameForm2.TabIndex = 0;
            this.labelNameForm2.Text = "Program name:";
            // 
            // labeldescForm2
            // 
            this.labeldescForm2.AutoSize = true;
            this.labeldescForm2.Location = new System.Drawing.Point(13, 82);
            this.labeldescForm2.Name = "labeldescForm2";
            this.labeldescForm2.Size = new System.Drawing.Size(98, 13);
            this.labeldescForm2.TabIndex = 1;
            this.labeldescForm2.Text = "Program descripton";
            // 
            // textBoxNameForm2
            // 
            this.textBoxNameForm2.Location = new System.Drawing.Point(117, 13);
            this.textBoxNameForm2.Name = "textBoxNameForm2";
            this.textBoxNameForm2.Size = new System.Drawing.Size(262, 20);
            this.textBoxNameForm2.TabIndex = 2;
            // 
            // textBoxDescriptonForm2
            // 
            this.textBoxDescriptonForm2.Location = new System.Drawing.Point(117, 79);
            this.textBoxDescriptonForm2.Multiline = true;
            this.textBoxDescriptonForm2.Name = "textBoxDescriptonForm2";
            this.textBoxDescriptonForm2.Size = new System.Drawing.Size(262, 134);
            this.textBoxDescriptonForm2.TabIndex = 3;
            // 
            // button1Ok
            // 
            this.button1Ok.Location = new System.Drawing.Point(13, 253);
            this.button1Ok.Name = "button1Ok";
            this.button1Ok.Size = new System.Drawing.Size(75, 23);
            this.button1Ok.TabIndex = 4;
            this.button1Ok.Text = "OK";
            this.button1Ok.UseVisualStyleBackColor = true;
            this.button1Ok.Click += new System.EventHandler(this.button1Ok_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(315, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 288);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1Ok);
            this.Controls.Add(this.textBoxDescriptonForm2);
            this.Controls.Add(this.textBoxNameForm2);
            this.Controls.Add(this.labeldescForm2);
            this.Controls.Add(this.labelNameForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameForm2;
        private System.Windows.Forms.Label labeldescForm2;
        private System.Windows.Forms.TextBox textBoxNameForm2;
        private System.Windows.Forms.TextBox textBoxDescriptonForm2;
        private System.Windows.Forms.Button button1Ok;
        private System.Windows.Forms.Button buttonCancel;
    }
}