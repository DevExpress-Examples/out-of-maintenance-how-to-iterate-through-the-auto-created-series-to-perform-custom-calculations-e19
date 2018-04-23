using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraCharts;

namespace SeriesTemplateSample {
    public partial class Form1 : Form {
        Hashtable series = new Hashtable();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
            chartControl1.RefreshData();
            int count = 0;
            double value =0.0;
            foreach (string key in series.Keys) {
                foreach (SeriesPoint p in (series[key] as Series).Points) {
                    count++;
                    value += p.Values[0];
                }
            }
            if (count != 0) {
                Series average = new Series("Average", ViewType.Bar);
                average.Points.Add(new SeriesPoint("Average", value / count));
                chartControl1.Series.Add(average);
            }

        }

        private void chartControl1_BoundDataChanged(object sender, EventArgs e) {
            foreach (Series s in chartControl1.Series) {
                if (!series.Contains(s.Name)) {
                    series.Add(s.Name, s);
                }
            }
        }
    }
}