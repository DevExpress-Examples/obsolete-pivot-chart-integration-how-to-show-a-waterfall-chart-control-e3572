<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# OBSOLETE - Pivot Chart Integration - How to show a waterfall chart control
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3572)**
<!-- run online end -->


<p><strong>This example is now obsolete. Refer to the <a href="https://www.devexpress.com/Support/Center/p/T155168">Pivot Chart Integration - How to show a waterfall chart control </a> </strong><strong> one instead.</strong><br /><br />This example demonstrates how to represent the pivot grid data as a waterfall chart. The XtraCharts control does not support this series view by default, however, it is possible to achieve the required result by using the <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument2985">Range Bar Series View</a>.  To customize point values, use the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_BoundDataChangedtopic">ChartControl.BoundDataChanged</a> event. Please refer to the <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument8695">Pivot Charting (Integration with the Pivot Grid Control) </a>help topic for additional information about the Pivot Chart integration.<br /><br />Starting with version 14.1, changing series points in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_BoundDataChangedtopic">BoundDataChanged</a> event handler is not allowed. As described in the help topic, this event should be used to change a series' DevExpress.XtraCharts.SeriesBase.Visible property, or to change any properties of series labels or a series view type. Thus, we have created the <a href="https://www.devexpress.com/Support/Center/p/T155168">Pivot Chart Integration - How to show a waterfall chart control</a>  example to illustrate how to achieve this goal with new versions.</p>

<br/>


