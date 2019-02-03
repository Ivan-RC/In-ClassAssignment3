namespace In_ClassAssignment3
{
    partial class HumanWeightToCancri55e
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
            this.Label_Earth = new System.Windows.Forms.Label();
            this.Label_Cancri55e = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.txtbox_WeightOnEarth = new System.Windows.Forms.TextBox();
            this.txtbox_WeightOnCancri55e = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Earth
            // 
            this.Label_Earth.AutoSize = true;
            this.Label_Earth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Earth.Location = new System.Drawing.Point(237, 21);
            this.Label_Earth.Name = "Label_Earth";
            this.Label_Earth.Size = new System.Drawing.Size(155, 38);
            this.Label_Earth.TabIndex = 0;
            this.Label_Earth.Text = "Enter your weight on \r\nEarth";
            // 
            // Label_Cancri55e
            // 
            this.Label_Cancri55e.AutoSize = true;
            this.Label_Cancri55e.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cancri55e.Location = new System.Drawing.Point(237, 78);
            this.Label_Cancri55e.Name = "Label_Cancri55e";
            this.Label_Cancri55e.Size = new System.Drawing.Size(115, 38);
            this.Label_Cancri55e.TabIndex = 1;
            this.Label_Cancri55e.Text = "Your weight on \r\nCancri 55 e";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.Location = new System.Drawing.Point(326, 145);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(105, 52);
            this.btn_Convert.TabIndex = 2;
            this.btn_Convert.Text = "Convert weight!";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // txtbox_WeightOnEarth
            // 
            this.txtbox_WeightOnEarth.Location = new System.Drawing.Point(407, 37);
            this.txtbox_WeightOnEarth.Name = "txtbox_WeightOnEarth";
            this.txtbox_WeightOnEarth.Size = new System.Drawing.Size(100, 22);
            this.txtbox_WeightOnEarth.TabIndex = 3;
            // 
            // txtbox_WeightOnCancri55e
            // 
            this.txtbox_WeightOnCancri55e.Location = new System.Drawing.Point(407, 94);
            this.txtbox_WeightOnCancri55e.Name = "txtbox_WeightOnCancri55e";
            this.txtbox_WeightOnCancri55e.Size = new System.Drawing.Size(100, 22);
            this.txtbox_WeightOnCancri55e.TabIndex = 4;
            // 
            // HumanWeightToCancri55e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_WeightOnCancri55e);
            this.Controls.Add(this.txtbox_WeightOnEarth);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.Label_Cancri55e);
            this.Controls.Add(this.Label_Earth);
            this.Name = "HumanWeightToCancri55e";
            this.Text = " HumanWeightToCancri55e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Earth;
        private System.Windows.Forms.Label Label_Cancri55e;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox txtbox_WeightOnEarth;
        private System.Windows.Forms.TextBox txtbox_WeightOnCancri55e;
    }
}

