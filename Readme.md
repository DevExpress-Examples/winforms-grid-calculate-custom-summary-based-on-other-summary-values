<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q273845/Form1.cs) (VB: [Form1.vb](./VB/Q273845/Form1.vb))
<!-- default file list end -->
# How to calculate summary using summary values calculated by other columns


<p>Within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomSummaryCalculatetopic">GridView.CustomSummaryCalculate</a> event handler, it's impossible to access  a total summary calculated against another column. The total summary can be obtained within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawFooterCelltopic">GridView.CustomDrawFooterCell</a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawRowFooterCelltopic">GridView.CustomDrawGroupRowFooterCell</a> event handlers. Here, you can obtain a total summary value using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridSummaryItem_SummaryValuetopic">GridSummaryItem.SummaryValue</a> property, and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_GetGroupSummaryValuetopic">GridView.GetGroupSummaryValue</a> method. For convenience, we suggest that you set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridSummaryItem_Tagtopic">GridGroupSummaryItem.Tag</a> property of group summary items to user friendly values. So, you can use these values to easily obtain a necessary GridGroupSummaryItem from the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_GroupSummarytopic">GridView.GroupSummary</a> collection.</p>

<br/>


