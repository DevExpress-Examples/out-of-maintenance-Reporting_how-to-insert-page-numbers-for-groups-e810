using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace GroupsPaging {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report, and specify its data source.
            XtraReport report = new XtraReport();
            nwindDataSet ds = new nwindDataSet();
            new nwindDataSetTableAdapters.CategoryProductsTableAdapter().Fill(ds.CategoryProducts);
            report.DataSource = ds;
            report.DataMember = "CategoryProducts";

            // Add a detail band and define its contents.
            DetailBand detailBand = new DetailBand();
            detailBand.Height = 100;
            report.Bands.Add(detailBand);

            XRLabel detailLabel = new XRLabel();
            detailLabel.DataBindings.Add("Text", report.DataSource, "ProductName");
            detailLabel.Width = 200;
            detailBand.Controls.Add(detailLabel);

            // Add a group header band and define its contents.
            GroupHeaderBand ghBand = new GroupHeaderBand();
            ghBand.Height = 20;
            report.Bands.Add(ghBand);

            XRLabel ghLabel = new XRLabel();
            ghLabel.DataBindings.Add("Text", report.DataSource, "CategoryName");
            ghLabel.Width = 200;
            ghLabel.BackColor = Color.LightBlue;
            ghBand.Controls.Add(ghLabel);

            // Define a grouping criteria for the group header band.
            GroupField groupField = new GroupField();
            groupField.FieldName = "CategoryName";
            ghBand.GroupFields.Add(groupField);

            // Create a group footer band.
            GroupFooterBand gfBand = new GroupFooterBand();
            gfBand.Height = 20;
            // You can force the group header to be repeated on each page.
            gfBand.RepeatEveryPage = true;
            // It's important to set its Band.PageBreak property to AfterBand,
            // because the page numbers are displayed for the last group on a page.
            // So, if there are two distinct groups appearing on the same page, 
            // this will result in improper page numbering. 
            gfBand.PageBreak = PageBreak.AfterBand;
            report.Bands.Add(gfBand);

            // Create an instance of the XRPageInfo control.
            XRPageInfo pageInfo = new XRPageInfo();
            // Set the group header band as the running band for this control.
            pageInfo.RunningBand = ghBand;
            // Adjust other properties of XRPageInfo.
            pageInfo.Width = 200;
            pageInfo.BackColor = Color.LightBlue;
            pageInfo.PageInfo = PageInfo.NumberOfTotal;
            pageInfo.Format = "Pages in this Group: {0} of {1}";
            gfBand.Controls.Add(pageInfo);

            // Show the report's print preview.
            report.ShowPreview();
        }

    }
}