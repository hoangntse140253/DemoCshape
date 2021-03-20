
namespace Workshop_4
{
    partial class frmBookReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.btnOrderByPrice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvReport);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 326);
            this.panel1.TabIndex = 0;
            // 
            // dtgvReport
            // 
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(3, 3);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.Size = new System.Drawing.Size(471, 319);
            this.dtgvReport.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrderByPrice);
            this.panel2.Controls.Add(this.btnOrderByName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 58);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giảm dần theo";
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Location = new System.Drawing.Point(301, 17);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(75, 25);
            this.btnOrderByName.TabIndex = 1;
            this.btnOrderByName.Text = "Tên Sách";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            this.btnOrderByName.Click += new System.EventHandler(this.btnOrderByName_Click);
            // 
            // btnOrderByPrice
            // 
            this.btnOrderByPrice.Location = new System.Drawing.Point(399, 17);
            this.btnOrderByPrice.Name = "btnOrderByPrice";
            this.btnOrderByPrice.Size = new System.Drawing.Size(75, 25);
            this.btnOrderByPrice.TabIndex = 2;
            this.btnOrderByPrice.Text = "Đơn Giá";
            this.btnOrderByPrice.UseVisualStyleBackColor = true;
            this.btnOrderByPrice.Click += new System.EventHandler(this.btnOrderByPrice_Click);
            // 
            // frmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Report";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderByPrice;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.Label label1;
    }
}