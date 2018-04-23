using System;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
// ...

namespace GroupPageNumbers {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        string lastCategory = "";
        int pageNumber = 0;

        private void lbGroupPageNumber_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            string curCategory = ((XRLabel)sender).Tag.ToString();
            int pageCount = 0;

            foreach(Page page in this.Pages) {
                BrickEnumerator brickEnum = page.GetEnumerator();

                while(brickEnum.MoveNext()) {
                    VisualBrick brick = brickEnum.Current as VisualBrick;

                    if(brick != null && brick.BrickOwner == (XRLabel)sender) {
                        if(brick.Value.ToString() == curCategory)
                            pageCount++;
                    }
                }
            }

            if(curCategory == lastCategory)
                pageNumber++;
            else
                pageNumber = 1;

            lastCategory = curCategory;
            ((XRLabel)sender).Text = "Page " + pageNumber.ToString() + " of " + pageCount.ToString();
        }

    }
}
