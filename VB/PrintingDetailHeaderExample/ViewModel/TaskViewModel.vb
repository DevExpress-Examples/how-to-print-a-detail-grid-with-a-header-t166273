Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PrintingDetailHeaderExample
	Friend Class TaskViewModel
		Private _List As ObservableCollection(Of TaskList)

		Public ReadOnly Property List() As ObservableCollection(Of TaskList)
			Get
				If _List Is Nothing Then
					_List = New ObservableCollection(Of TaskList)()
					For i As Integer = 0 To 9
						Dim taskList As New TaskList() With {.TaskGroup = "Group" & i, .GroupNumber = i, .List = New ObservableCollection(Of Task)()}
						For j As Integer = 0 To 9
							taskList.List.Add(New Task() With {.Name = "Task" & j, .Date = New DateTime(2014, 10, New Random().Next(1, 31)), .IsCompleted = j Mod 2 <> 0})
						Next j
						_List.Add(taskList)
					Next i
				End If
				Return _List
			End Get
		End Property

		Public Class Task
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
			Private privateDate As DateTime
            Public Property [Date]() As DateTime
                Get
                    Return privateDate
                End Get
                Set(ByVal value As DateTime)
                    privateDate = value
                End Set
            End Property
			Private privateIsCompleted As Boolean
			Public Property IsCompleted() As Boolean
				Get
					Return privateIsCompleted
				End Get
				Set(ByVal value As Boolean)
					privateIsCompleted = value
				End Set
			End Property
		End Class

		Public Class TaskList
			Private privateTaskGroup As String
			Public Property TaskGroup() As String
				Get
					Return privateTaskGroup
				End Get
				Set(ByVal value As String)
					privateTaskGroup = value
				End Set
			End Property
			Private privateGroupNumber As Integer
			Public Property GroupNumber() As Integer
				Get
					Return privateGroupNumber
				End Get
				Set(ByVal value As Integer)
					privateGroupNumber = value
				End Set
			End Property
			Private privateList As ObservableCollection(Of Task)
			Public Property List() As ObservableCollection(Of Task)
				Get
					Return privateList
				End Get
				Set(ByVal value As ObservableCollection(Of Task))
					privateList = value
				End Set
			End Property
		End Class
	End Class
End Namespace
