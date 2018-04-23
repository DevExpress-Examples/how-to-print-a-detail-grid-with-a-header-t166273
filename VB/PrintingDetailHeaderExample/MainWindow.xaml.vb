Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace PrintingDetailHeaderExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim printLink As New PrintableControlLink(TryCast(masterGrid.View, TableView), "New Document")
			PrintHelper.ShowPrintPreviewDialog(Me, printLink, "New Document")
		End Sub
	End Class
End Namespace
