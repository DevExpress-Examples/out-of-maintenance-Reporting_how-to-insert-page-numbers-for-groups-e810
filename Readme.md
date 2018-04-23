# How to insert page numbers for groups


<p>This example demonstrates how to implement page numbering for groups.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1763">How to sort groups by number of records in the group</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1650">How to group data</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1282">How to count the number of groups in a report</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1290">How to group (sort) a report by days of week</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E787">How to implement custom grouping (group by Year and Month)</a>.</p>


<h3>Description</h3>

<p>Since the v2009 vol 2 version of the XtraReports you can easily implement this via a new <strong>RunningBand</strong> property of the <strong>XRPageInfo</strong> control. Simply add this control onto a group header or footer, and set this property to this group header&#39;s name. Note that it&#39;s required to set the group header&#39;s <strong>PageBreak</strong> property to <strong>AfterBand</strong>, because group paging is applied to the last group within a page. So, ignoring this property will cause an improper page numbering.</p>

<br/>


