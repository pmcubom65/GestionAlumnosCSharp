﻿namespace AccesoDatos01
{
    partial class Form3
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
            this.alumnosnotasmidataset = new AccesoDatos01.alumnosnotasmidataset();
            this.talumnosnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.talumnosnotasTableAdapter = new AccesoDatos01.alumnosnotasmidatasetTableAdapters.talumnosnotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosnotasmidataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talumnosnotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ConjuntoDatos";
            reportDataSource1.Value = this.talumnosnotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccesoDatos01.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // alumnosnotasmidataset
            // 
            this.alumnosnotasmidataset.DataSetName = "alumnosnotasmidataset";
            this.alumnosnotasmidataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // talumnosnotasBindingSource
            // 
            this.talumnosnotasBindingSource.DataMember = "talumnosnotas";
            this.talumnosnotasBindingSource.DataSource = this.alumnosnotasmidataset;
            // 
            // talumnosnotasTableAdapter
            // 
            this.talumnosnotasTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosnotasmidataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talumnosnotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource talumnosnotasBindingSource;
        private alumnosnotasmidataset alumnosnotasmidataset;
        private alumnosnotasmidatasetTableAdapters.talumnosnotasTableAdapter talumnosnotasTableAdapter;
    }
}