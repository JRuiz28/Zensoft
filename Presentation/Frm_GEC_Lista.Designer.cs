namespace Presentation
{
    partial class Frm_GEC_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GEC_Lista));
            this.timeHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDesde = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvConsumible = new System.Windows.Forms.DataGridView();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumible)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeHasta
            // 
            this.timeHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHasta.Location = new System.Drawing.Point(200, 162);
            this.timeHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeHasta.Name = "timeHasta";
            this.timeHasta.Size = new System.Drawing.Size(528, 30);
            this.timeHasta.TabIndex = 84;
            this.timeHasta.ValueChanged += new System.EventHandler(this.timeHasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Hasta:";
            // 
            // timeDesde
            // 
            this.timeDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDesde.Location = new System.Drawing.Point(200, 94);
            this.timeDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeDesde.Name = "timeDesde";
            this.timeDesde.Size = new System.Drawing.Size(528, 30);
            this.timeDesde.TabIndex = 82;
            this.timeDesde.Value = new System.DateTime(2019, 12, 13, 0, 0, 0, 0);
            this.timeDesde.ValueChanged += new System.EventHandler(this.timeDeste_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Fecha desde:";
            // 
            // dgvConsumible
            // 
            this.dgvConsumible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumible.Location = new System.Drawing.Point(24, 217);
            this.dgvConsumible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsumible.Name = "dgvConsumible";
            this.dgvConsumible.RowHeadersWidth = 51;
            this.dgvConsumible.RowTemplate.Height = 24;
            this.dgvConsumible.Size = new System.Drawing.Size(1249, 462);
            this.dgvConsumible.TabIndex = 80;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRealizar.Location = new System.Drawing.Point(835, 94);
            this.btnRealizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(289, 50);
            this.btnRealizar.TabIndex = 86;
            this.btnRealizar.Text = "Realizar entregar";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnRealizar);
            this.groupBox1.Controls.Add(this.dgvConsumible);
            this.groupBox1.Controls.Add(this.timeDesde);
            this.groupBox1.Controls.Add(this.timeHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1310, 706);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de entrega de consumible";
            // 
            // Frm_GEC_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.Fondo_A1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 750);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_GEC_Lista";
            this.Text = "Lista de entregas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumible)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timeHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timeDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvConsumible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRealizar;
    }
}