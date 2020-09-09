namespace WindowsFormsApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_and = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3_avg = new System.Windows.Forms.Button();
            this.btn_OR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button_constrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 230);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_and
            // 
            this.button_and.Location = new System.Drawing.Point(12, 294);
            this.button_and.Name = "button_and";
            this.button_and.Size = new System.Drawing.Size(75, 23);
            this.button_and.TabIndex = 4;
            this.button_and.Text = "And";
            this.button_and.UseVisualStyleBackColor = true;
            this.button_and.Click += new System.EventHandler(this.button_and_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "sum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_avg
            // 
            this.button3_avg.Location = new System.Drawing.Point(179, 294);
            this.button3_avg.Name = "button3_avg";
            this.button3_avg.Size = new System.Drawing.Size(75, 23);
            this.button3_avg.TabIndex = 6;
            this.button3_avg.Text = "avrage";
            this.button3_avg.UseVisualStyleBackColor = true;
            this.button3_avg.Click += new System.EventHandler(this.button3_avg_Click);
            // 
            // btn_OR
            // 
            this.btn_OR.Location = new System.Drawing.Point(260, 294);
            this.btn_OR.Name = "btn_OR";
            this.btn_OR.Size = new System.Drawing.Size(75, 23);
            this.btn_OR.TabIndex = 7;
            this.btn_OR.Text = "done";
            this.btn_OR.UseVisualStyleBackColor = true;
            this.btn_OR.Click += new System.EventHandler(this.btn_OR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "the table";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(731, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 31);
            this.button6.TabIndex = 16;
            this.button6.Text = "display";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_constrain
            // 
            this.button_constrain.Location = new System.Drawing.Point(194, 231);
            this.button_constrain.Name = "button_constrain";
            this.button_constrain.Size = new System.Drawing.Size(75, 23);
            this.button_constrain.TabIndex = 18;
            this.button_constrain.Text = "Constrains";
            this.button_constrain.UseVisualStyleBackColor = true;
            this.button_constrain.Click += new System.EventHandler(this.button_constrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 420);
            this.Controls.Add(this.button_constrain);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_OR);
            this.Controls.Add(this.button3_avg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_and);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_and;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3_avg;
        private System.Windows.Forms.Button btn_OR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_constrain;
    }
}

