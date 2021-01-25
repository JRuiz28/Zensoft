namespace Presentation
{
    partial class Boleta_PrestamoActivos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetBoletas = new Presentation.DataSetBoletas();
            this.SP_CNS_BOLETA_PACTIVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CNS_BOLETA_PACTIVOTableAdapter = new Presentation.DataSetBoletasTableAdapters.SP_CNS_BOLETA_PACTIVOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBoletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CNS_BOLETA_PACTIVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CNS_BOLETA_PACTIVOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reporte_PrestamoActivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBoletas
            // 
            this.DataSetBoletas.DataSetName = "DataSetBoletas";
            this.DataSetBoletas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CNS_BOLETA_PACTIVOBindingSource
            // 
            this.SP_CNS_BOLETA_PACTIVOBindingSource.DataMember = "SP_CNS_BOLETA_PACTIVO";
            this.SP_CNS_BOLETA_PACTIVOBindingSource.DataSource = this.DataSetBoletas;
            // 
            // SP_CNS_BOLETA_PACTIVOTableAdapter
            // 
            this.SP_CNS_BOLETA_PACTIVOTableAdapter.ClearBeforeFill = true;
            // 
            // Boleta_PrestamoActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Boleta_PrestamoActivos";
            this.Text = "Boleta_PrestamoActivos";
            this.Load += new System.EventHandler(this.Boleta_PrestamoActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBoletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CNS_BOLETA_PACTIVOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CNS_BOLETA_PACTIVOBindingSource;
        private DataSetBoletas DataSetBoletas;
        private DataSetBoletasTableAdapters.SP_CNS_BOLETA_PACTIVOTableAdapter SP_CNS_BOLETA_PACTIVOTableAdapter;
    }
}