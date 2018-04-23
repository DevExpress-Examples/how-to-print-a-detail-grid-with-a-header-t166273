# How to print a detail grid with a header


This example demonstrates how to print a detail grid with a header.<br />Our detail grid with DataControlDetailDescriptor doesn't support printing its header. To provide this capability in this sample, we override the detail grid's TableView.PrintHeaderTemplate. We add ContentControl and bind its Content property to the DetailDescriptor.HeaderContent property and ContentTemplate to DetailDescriptor.HeaderContentTemplate.

<br/>


