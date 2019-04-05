<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PrintingDetailHeaderExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PrintingDetailHeaderExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/PrintingDetailHeaderExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PrintingDetailHeaderExample/MainWindow.xaml.vb))
* [TaskViewModel.cs](./CS/PrintingDetailHeaderExample/ViewModel/TaskViewModel.cs) (VB: [TaskViewModel.vb](./VB/PrintingDetailHeaderExample/ViewModel/TaskViewModel.vb))
<!-- default file list end -->
# How to print a detail grid with a header


This example demonstrates how to print a detail grid with a header.<br />Our detail grid with DataControlDetailDescriptor doesn't support printing its header. To provide this capability in this sample, we override the detail grid's TableView.PrintHeaderTemplate. We add ContentControl and bind its Content property to the DetailDescriptor.HeaderContent property and ContentTemplate to DetailDescriptor.HeaderContentTemplate.

<br/>


