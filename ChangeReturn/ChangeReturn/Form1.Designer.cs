namespace ChangeReturn
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
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.txtBoxPaid = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxChange = new System.Windows.Forms.TextBox();
            this.txtBoxQuarters = new System.Windows.Forms.TextBox();
            this.txtBoxNickles = new System.Windows.Forms.TextBox();
            this.txtBoxDimes = new System.Windows.Forms.TextBox();
            this.txtBoxPennies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(97, 19);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCost.TabIndex = 0;
            // 
            // txtBoxPaid
            // 
            this.txtBoxPaid.Location = new System.Drawing.Point(97, 57);
            this.txtBoxPaid.Name = "txtBoxPaid";
            this.txtBoxPaid.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPaid.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(25, 22);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(66, 13);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost of Item:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(25, 60);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(70, 13);
            this.lblPaid.TabIndex = 3;
            this.lblPaid.Text = "Amount Paid:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(28, 83);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(169, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate Change";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(25, 134);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(47, 13);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "Change:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quarters: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dimes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nickles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pennies:";
            // 
            // txtBoxChange
            // 
            this.txtBoxChange.Location = new System.Drawing.Point(97, 131);
            this.txtBoxChange.Name = "txtBoxChange";
            this.txtBoxChange.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChange.TabIndex = 10;
            // 
            // txtBoxQuarters
            // 
            this.txtBoxQuarters.Location = new System.Drawing.Point(97, 157);
            this.txtBoxQuarters.Name = "txtBoxQuarters";
            this.txtBoxQuarters.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuarters.TabIndex = 11;
            // 
            // txtBoxNickles
            // 
            this.txtBoxNickles.Location = new System.Drawing.Point(97, 209);
            this.txtBoxNickles.Name = "txtBoxNickles";
            this.txtBoxNickles.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNickles.TabIndex = 12;
            // 
            // txtBoxDimes
            // 
            this.txtBoxDimes.Location = new System.Drawing.Point(97, 183);
            this.txtBoxDimes.Name = "txtBoxDimes";
            this.txtBoxDimes.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDimes.TabIndex = 13;
            // 
            // txtBoxPennies
            // 
            this.txtBoxPennies.Location = new System.Drawing.Point(97, 235);
            this.txtBoxPennies.Name = "txtBoxPennies";
            this.txtBoxPennies.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPennies.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 279);
            this.Controls.Add(this.txtBoxPennies);
            this.Controls.Add(this.txtBoxDimes);
            this.Controls.Add(this.txtBoxNickles);
            this.Controls.Add(this.txtBoxQuarters);
            this.Controls.Add(this.txtBoxChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtBoxPaid);
            this.Controls.Add(this.txtBoxCost);
            this.Name = "Form1";
            this.Text = "Change Return";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.TextBox txtBoxPaid;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxChange;
        private System.Windows.Forms.TextBox txtBoxQuarters;
        private System.Windows.Forms.TextBox txtBoxNickles;
        private System.Windows.Forms.TextBox txtBoxDimes;
        private System.Windows.Forms.TextBox txtBoxPennies;
    }
}

