namespace SeriesTemplateSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gspDataSet = new SeriesTemplateSample.gspDataSet();
            this.gSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSPTableAdapter = new SeriesTemplateSample.gspDataSetTableAdapters.GSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.gSPTableAdapter;
            this.chartControl1.DataSource = this.gSPBindingSource;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Year";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Year";
            this.chartControl1.SeriesTemplate.SummaryFunction = "SUM([GSP])";
            this.chartControl1.Size = new System.Drawing.Size(771, 414);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chartControl1_BoundDataChanged);
            // 
            // gspDataSet
            // 
            this.gspDataSet.DataSetName = "gspDataSet";
            this.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gSPBindingSource
            // 
            this.gSPBindingSource.DataMember = "GSP";
            this.gSPBindingSource.DataSource = this.gspDataSet;
            // 
            // gSPTableAdapter
            // 
            this.gSPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 414);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private SeriesTemplateSample.gspDataSetTableAdapters.GSPTableAdapter gSPTableAdapter;
        private gspDataSet gspDataSet;
        private System.Windows.Forms.BindingSource gSPBindingSource;
    }
}

