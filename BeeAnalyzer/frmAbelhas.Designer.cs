
namespace BeeAnalyzer
{
    partial class frmAbelhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbelhas));
            this.listView_abelhas = new System.Windows.Forms.ListView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.textBox_especie = new System.Windows.Forms.TextBox();
            this.textBox_regiao = new System.Windows.Forms.TextBox();
            this.textBox_nomeCientifico = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_abelhas
            // 
            this.listView_abelhas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_abelhas.HideSelection = false;
            this.listView_abelhas.Location = new System.Drawing.Point(3, 3);
            this.listView_abelhas.Name = "listView_abelhas";
            this.listView_abelhas.Size = new System.Drawing.Size(654, 286);
            this.listView_abelhas.TabIndex = 1;
            this.listView_abelhas.UseCompatibleStateImageBehavior = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.Location = new System.Drawing.Point(531, 3);
            this.btn_editar.Name = "btn_editar";
            this.tableLayoutPanel1.SetRowSpan(this.btn_editar, 2);
            this.btn_editar.Size = new System.Drawing.Size(126, 52);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "EDITAR\r\nADICIONAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // textBox_pesquisar
            // 
            this.textBox_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_pesquisar, 2);
            this.textBox_pesquisar.Location = new System.Drawing.Point(3, 61);
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.PlaceholderText = "Pesquisar por espécie...";
            this.textBox_pesquisar.Size = new System.Drawing.Size(522, 23);
            this.textBox_pesquisar.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar.Location = new System.Drawing.Point(531, 61);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(126, 23);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "PESQUISAR";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox_especie
            // 
            this.textBox_especie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_especie, 2);
            this.textBox_especie.Location = new System.Drawing.Point(3, 3);
            this.textBox_especie.Name = "textBox_especie";
            this.textBox_especie.PlaceholderText = "Digite a espécie...";
            this.textBox_especie.Size = new System.Drawing.Size(522, 23);
            this.textBox_especie.TabIndex = 5;
            // 
            // textBox_regiao
            // 
            this.textBox_regiao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_regiao.Location = new System.Drawing.Point(3, 32);
            this.textBox_regiao.Name = "textBox_regiao";
            this.textBox_regiao.PlaceholderText = "Digite a região...";
            this.textBox_regiao.Size = new System.Drawing.Size(258, 23);
            this.textBox_regiao.TabIndex = 6;
            // 
            // textBox_nomeCientifico
            // 
            this.textBox_nomeCientifico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nomeCientifico.Location = new System.Drawing.Point(267, 32);
            this.textBox_nomeCientifico.Name = "textBox_nomeCientifico";
            this.textBox_nomeCientifico.PlaceholderText = "Digite o nome científico...";
            this.textBox_nomeCientifico.Size = new System.Drawing.Size(258, 23);
            this.textBox_nomeCientifico.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_especie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_nomeCientifico, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_pesquisar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_regiao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_editar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_pesquisar, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 87);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listView_abelhas, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 292);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // frmAbelhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 406);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbelhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abelhas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_abelhas;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox textBox_pesquisar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox textBox_especie;
        private System.Windows.Forms.TextBox textBox_regiao;
        private System.Windows.Forms.TextBox textBox_nomeCientifico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}