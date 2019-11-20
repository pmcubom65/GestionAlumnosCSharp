namespace AccesoDatos01
{
    partial class Form2
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
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.educacionDataSet = new AccesoDatos01.educacionDataSet();
            this.talumnosnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talumnosnotasTableAdapter = new AccesoDatos01.educacionDataSetTableAdapters.talumnosnotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talumnosnotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AlumnoBindingSource
            // 
            this.AlumnoBindingSource.DataSource = typeof(AccesoDatos01.Modelo.Alumno);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Alumnos";
            reportDataSource1.Value = this.AlumnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccesoDatos01.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // educacionDataSet
            // 
            this.educacionDataSet.DataSetName = "educacionDataSet";
            this.educacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talumnosnotasBindingSource
            // 
            this.talumnosnotasBindingSource.DataMember = "talumnosnotas";
            this.talumnosnotasBindingSource.DataSource = this.educacionDataSet;
            // 
            // talumnosnotasTableAdapter
            // 
            this.talumnosnotasTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talumnosnotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private System.Windows.Forms.BindingSource talumnosnotasBindingSource;
        private educacionDataSet educacionDataSet;
        private educacionDataSetTableAdapters.talumnosnotasTableAdapter talumnosnotasTableAdapter;
    }
}