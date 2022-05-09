using System.Threading;

namespace BeeAnalyzer
{
    partial class frmMain
    {
        Thread thread;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.title = new System.Windows.Forms.Label();
            this.btn_abelhas = new System.Windows.Forms.Button();
            this.btn_caixas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.title, 2);
            this.title.Font = new System.Drawing.Font("Segoe Script", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Coral;
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(537, 94);
            this.title.TabIndex = 2;
            this.title.Text = "BeeAnalyzer";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_abelhas
            // 
            this.btn_abelhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abelhas.AutoSize = true;
            this.btn_abelhas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_abelhas.BackColor = System.Drawing.Color.White;
            this.btn_abelhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abelhas.Image = ((System.Drawing.Image)(resources.GetObject("btn_abelhas.Image")));
            this.btn_abelhas.Location = new System.Drawing.Point(274, 97);
            this.btn_abelhas.Name = "btn_abelhas";
            this.btn_abelhas.Size = new System.Drawing.Size(266, 86);
            this.btn_abelhas.TabIndex = 2;
            this.btn_abelhas.UseVisualStyleBackColor = false;
            this.btn_abelhas.Click += new System.EventHandler(this.btn_abelhas_Click);
            // 
            // btn_caixas
            // 
            this.btn_caixas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_caixas.AutoSize = true;
            this.btn_caixas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_caixas.BackColor = System.Drawing.Color.White;
            this.btn_caixas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caixas.Image = ((System.Drawing.Image)(resources.GetObject("btn_caixas.Image")));
            this.btn_caixas.Location = new System.Drawing.Point(3, 97);
            this.btn_caixas.Name = "btn_caixas";
            this.btn_caixas.Size = new System.Drawing.Size(265, 86);
            this.btn_caixas.TabIndex = 1;
            this.btn_caixas.UseVisualStyleBackColor = false;
            this.btn_caixas.Click += new System.EventHandler(this.btn_caixas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_caixas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_abelhas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 282);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeeAnalyzer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_abelhas;
        private System.Windows.Forms.Button btn_caixas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

