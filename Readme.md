<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128625840/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2488)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - How to calculate a total summary based on other columns' summary values

The [GridView.CustomSummaryCalculate](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomSummaryCalculate) event does not allow you to obtaina total summaries calculated against another columns. This example handles the [GridView.CustomDrawFooterCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawFooterCell) and [GridView.CustomDrawGroupRowFooterCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawRowFooterCell) events to calculate total summary values based on other column's total summaries and display custom summaries within footer and group footer cells.


## Files to Review

* [Form1.cs](./CS/Q273845/Form1.cs) (VB: [Form1.vb](./VB/Q273845/Form1.vb))


## Documentation

* [Working with Summaries in Code - Custom Summaries](https://docs.devexpress.com/WindowsForms/701/controls-and-libraries/data-grid/summaries/working-with-summaries-in-code-custom-summaries)
* [Custom Painting Basics](https://docs.devexpress.com/WindowsForms/762/controls-and-libraries/data-grid/appearance-and-conditional-formatting/custom-painting/custom-painting-basics)


## See Also

* [WinForms Grid Video: Introduction to Summaries (YouTube)](https://youtu.be/3sc7ENaACVw?si=X70ObBxo7EfkeTLB)
