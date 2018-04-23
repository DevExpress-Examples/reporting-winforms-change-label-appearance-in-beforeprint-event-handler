using System;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace BeforePrintEvent {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            // Obtain the current label.
            XRLabel label = (XRLabel)sender;
            
            // Get the total value.
            double total = Convert.ToDouble(GetCurrentColumnValue("Total"));
            
            // Customize the label's appearance.
            if (total < 100) {
                label.ForeColor = Color.White;
                label.BackColor = Color.Red;
            }
            else if (total > 1000) {
                label.ForeColor = Color.White;
                label.BackColor = Color.Green;
            }
            else {
                label.ForeColor = Color.Black;
                label.BackColor = Color.Transparent;
            }
        }

    }
}
