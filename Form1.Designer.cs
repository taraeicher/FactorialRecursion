namespace FactorialRecursion
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxStart = new System.Windows.Forms.TextBox();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSteps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(117, 91);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // txtBxStart
            // 
            this.txtBxStart.Location = new System.Drawing.Point(101, 21);
            this.txtBxStart.Name = "txtBxStart";
            this.txtBxStart.Size = new System.Drawing.Size(100, 20);
            this.txtBxStart.TabIndex = 2;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(101, 56);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(100, 20);
            this.txtBxResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // txtBxSteps
            // 
            this.txtBxSteps.Location = new System.Drawing.Point(30, 132);
            this.txtBxSteps.Multiline = true;
            this.txtBxSteps.Name = "txtBxSteps";
            this.txtBxSteps.Size = new System.Drawing.Size(240, 129);
            this.txtBxSteps.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtBxSteps);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFactorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxStart;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSteps;
    }
}

