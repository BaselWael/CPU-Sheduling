
namespace Cpu_scheduling_calculator
{
    partial class FCFSForm
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
            this.txtp1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtp2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtp4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.txtp5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.txtp3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.txtp6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.PSort = new System.Windows.Forms.Label();
            this.AvgRes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtB6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.txtB3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new System.Windows.Forms.Label();
            this.txtB5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label12 = new System.Windows.Forms.Label();
            this.txtB4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label13 = new System.Windows.Forms.Label();
            this.txtB2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.txtB1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtp1
            // 
            this.txtp1.Depth = 0;
            this.txtp1.Hint = "";
            this.txtp1.Location = new System.Drawing.Point(54, 126);
            this.txtp1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp1.Name = "txtp1";
            this.txtp1.PasswordChar = '\0';
            this.txtp1.SelectedText = "";
            this.txtp1.SelectionLength = 0;
            this.txtp1.SelectionStart = 0;
            this.txtp1.Size = new System.Drawing.Size(45, 28);
            this.txtp1.TabIndex = 0;
            this.txtp1.UseSystemPasswordChar = false;
            this.txtp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "P2";
            // 
            // txtp2
            // 
            this.txtp2.Depth = 0;
            this.txtp2.Hint = "";
            this.txtp2.Location = new System.Drawing.Point(207, 126);
            this.txtp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp2.Name = "txtp2";
            this.txtp2.PasswordChar = '\0';
            this.txtp2.SelectedText = "";
            this.txtp2.SelectionLength = 0;
            this.txtp2.SelectionStart = 0;
            this.txtp2.Size = new System.Drawing.Size(45, 28);
            this.txtp2.TabIndex = 2;
            this.txtp2.UseSystemPasswordChar = false;
            this.txtp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "P4";
            // 
            // txtp4
            // 
            this.txtp4.Depth = 0;
            this.txtp4.Hint = "";
            this.txtp4.Location = new System.Drawing.Point(54, 178);
            this.txtp4.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp4.Name = "txtp4";
            this.txtp4.PasswordChar = '\0';
            this.txtp4.SelectedText = "";
            this.txtp4.SelectionLength = 0;
            this.txtp4.SelectionStart = 0;
            this.txtp4.Size = new System.Drawing.Size(45, 28);
            this.txtp4.TabIndex = 4;
            this.txtp4.UseSystemPasswordChar = false;
            this.txtp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "P5";
            // 
            // txtp5
            // 
            this.txtp5.Depth = 0;
            this.txtp5.Hint = "";
            this.txtp5.Location = new System.Drawing.Point(207, 178);
            this.txtp5.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp5.Name = "txtp5";
            this.txtp5.PasswordChar = '\0';
            this.txtp5.SelectedText = "";
            this.txtp5.SelectionLength = 0;
            this.txtp5.SelectionStart = 0;
            this.txtp5.Size = new System.Drawing.Size(45, 28);
            this.txtp5.TabIndex = 6;
            this.txtp5.UseSystemPasswordChar = false;
            this.txtp5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "P3";
            // 
            // txtp3
            // 
            this.txtp3.Depth = 0;
            this.txtp3.Hint = "";
            this.txtp3.Location = new System.Drawing.Point(350, 126);
            this.txtp3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp3.Name = "txtp3";
            this.txtp3.PasswordChar = '\0';
            this.txtp3.SelectedText = "";
            this.txtp3.SelectionLength = 0;
            this.txtp3.SelectionStart = 0;
            this.txtp3.Size = new System.Drawing.Size(45, 28);
            this.txtp3.TabIndex = 8;
            this.txtp3.UseSystemPasswordChar = false;
            this.txtp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "P6";
            // 
            // txtp6
            // 
            this.txtp6.Depth = 0;
            this.txtp6.Hint = "";
            this.txtp6.Location = new System.Drawing.Point(350, 178);
            this.txtp6.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtp6.Name = "txtp6";
            this.txtp6.PasswordChar = '\0';
            this.txtp6.SelectedText = "";
            this.txtp6.SelectionLength = 0;
            this.txtp6.SelectionStart = 0;
            this.txtp6.Size = new System.Drawing.Size(45, 28);
            this.txtp6.TabIndex = 10;
            this.txtp6.UseSystemPasswordChar = false;
            this.txtp6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(165, 406);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(108, 36);
            this.materialFlatButton1.TabIndex = 12;
            this.materialFlatButton1.Text = "Calculate";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // PSort
            // 
            this.PSort.AutoSize = true;
            this.PSort.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSort.Location = new System.Drawing.Point(76, 462);
            this.PSort.Name = "PSort";
            this.PSort.Size = new System.Drawing.Size(163, 26);
            this.PSort.TabIndex = 13;
            this.PSort.Text = "Proccess Sort";
            this.PSort.Visible = false;
            // 
            // AvgRes
            // 
            this.AvgRes.AutoSize = true;
            this.AvgRes.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgRes.Location = new System.Drawing.Point(7, 509);
            this.AvgRes.Name = "AvgRes";
            this.AvgRes.Size = new System.Drawing.Size(108, 22);
            this.AvgRes.TabIndex = 14;
            this.AvgRes.Text = "AVG Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Arrival time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Burst time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "P6";
            // 
            // txtB6
            // 
            this.txtB6.Depth = 0;
            this.txtB6.Hint = "";
            this.txtB6.Location = new System.Drawing.Point(350, 329);
            this.txtB6.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB6.Name = "txtB6";
            this.txtB6.PasswordChar = '\0';
            this.txtB6.SelectedText = "";
            this.txtB6.SelectionLength = 0;
            this.txtB6.SelectionStart = 0;
            this.txtB6.Size = new System.Drawing.Size(45, 28);
            this.txtB6.TabIndex = 26;
            this.txtB6.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(308, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "P3";
            // 
            // txtB3
            // 
            this.txtB3.Depth = 0;
            this.txtB3.Hint = "";
            this.txtB3.Location = new System.Drawing.Point(350, 277);
            this.txtB3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB3.Name = "txtB3";
            this.txtB3.PasswordChar = '\0';
            this.txtB3.SelectedText = "";
            this.txtB3.SelectionLength = 0;
            this.txtB3.SelectionStart = 0;
            this.txtB3.Size = new System.Drawing.Size(45, 28);
            this.txtB3.TabIndex = 24;
            this.txtB3.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(165, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "P5";
            // 
            // txtB5
            // 
            this.txtB5.Depth = 0;
            this.txtB5.Hint = "";
            this.txtB5.Location = new System.Drawing.Point(207, 329);
            this.txtB5.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB5.Name = "txtB5";
            this.txtB5.PasswordChar = '\0';
            this.txtB5.SelectedText = "";
            this.txtB5.SelectionLength = 0;
            this.txtB5.SelectionStart = 0;
            this.txtB5.Size = new System.Drawing.Size(45, 28);
            this.txtB5.TabIndex = 22;
            this.txtB5.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "P4";
            // 
            // txtB4
            // 
            this.txtB4.Depth = 0;
            this.txtB4.Hint = "";
            this.txtB4.Location = new System.Drawing.Point(54, 329);
            this.txtB4.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB4.Name = "txtB4";
            this.txtB4.PasswordChar = '\0';
            this.txtB4.SelectedText = "";
            this.txtB4.SelectionLength = 0;
            this.txtB4.SelectionStart = 0;
            this.txtB4.Size = new System.Drawing.Size(45, 28);
            this.txtB4.TabIndex = 20;
            this.txtB4.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "P2";
            // 
            // txtB2
            // 
            this.txtB2.Depth = 0;
            this.txtB2.Hint = "";
            this.txtB2.Location = new System.Drawing.Point(207, 277);
            this.txtB2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB2.Name = "txtB2";
            this.txtB2.PasswordChar = '\0';
            this.txtB2.SelectedText = "";
            this.txtB2.SelectionLength = 0;
            this.txtB2.SelectionStart = 0;
            this.txtB2.Size = new System.Drawing.Size(45, 28);
            this.txtB2.TabIndex = 18;
            this.txtB2.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "P1";
            // 
            // txtB1
            // 
            this.txtB1.Depth = 0;
            this.txtB1.Hint = "";
            this.txtB1.Location = new System.Drawing.Point(54, 277);
            this.txtB1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB1.Name = "txtB1";
            this.txtB1.PasswordChar = '\0';
            this.txtB1.SelectedText = "";
            this.txtB1.SelectionLength = 0;
            this.txtB1.SelectionStart = 0;
            this.txtB1.Size = new System.Drawing.Size(45, 28);
            this.txtB1.TabIndex = 16;
            this.txtB1.UseSystemPasswordChar = false;
            // 
            // FCFSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 541);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtB6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtB5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtB4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AvgRes);
            this.Controls.Add(this.PSort);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtp6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtp3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtp5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtp4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtp2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtp1);
            this.Name = "FCFSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Come First Serve";
            this.Load += new System.EventHandler(this.FCFSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtp2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtp4;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtp5;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtp3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtp6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label PSort;
        private System.Windows.Forms.Label AvgRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB6;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB3;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB5;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB4;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB2;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB1;
    }
}