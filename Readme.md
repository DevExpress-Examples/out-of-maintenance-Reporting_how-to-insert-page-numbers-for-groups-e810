# How to insert page numbers for groups


<p>This example demonstrates how to implement page numbering for groups.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1763">How to sort groups by number of records in the group</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1650">How to group data</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1282">How to count the number of groups in a report</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1290">How to group (sort) a report by days of week</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E787">How to implement custom grouping (group by Year and Month)</a>.</p>


<h3>Description</h3>

<p>To achieve this, you needed to drop an <strong>XRLabel</strong> onto the band where you want page numbers to be shown (for instance, <strong>Page Footer</strong>), then handle its <strong>PrintOnPage</strong> event and use the following code. Note that here the <strong>lastID</strong> variable  serves as an indicator for the value by which the report&#39;s data is grouped. In your scenario you should use another variable, which implements your variant of grouping. Note also that for this example to work in earlier versions of XtraReports, you should bind the label&#39;s <strong>Tag</strong> property to a data field, which serves as a group field.</p>

<br/>


