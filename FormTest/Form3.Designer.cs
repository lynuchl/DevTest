namespace FormTest
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("wqeq", new object[] {
            ((object)(222D))});
            this.hisProPublicDataSet = new FormTest.HisProPublicDataSet();
            this.dMDWXXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_DWXXBTableAdapter = new FormTest.HisProPublicDataSetTableAdapters.DM_DWXXBTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.hisProPublicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDWXXBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // hisProPublicDataSet
            // 
            this.hisProPublicDataSet.DataSetName = "HisProPublicDataSet";
            this.hisProPublicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMDWXXBBindingSource
            // 
            this.dMDWXXBBindingSource.DataMember = "DM_DWXXB";
            this.dMDWXXBBindingSource.DataSource = this.hisProPublicDataSet;
            // 
            // dM_DWXXBTableAdapter
            // 
            this.dM_DWXXBTableAdapter.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.dMDWXXBBindingSource;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(61, 21);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            seriesPoint1.ColorSerializable = "#FFFF00";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(201, 196);
            this.chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(402, 118);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Series 1";
            seriesPoint2.ColorSerializable = "#FFC000";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint2});
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(300, 200);
            this.chartControl2.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hisProPublicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMDWXXBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HisProPublicDataSetTableAdapters.DM_DWXXBTableAdapter dM_DWXXBTableAdapter;
        private HisProPublicDataSet hisProPublicDataSet;
        private System.Windows.Forms.BindingSource dMDWXXBBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}