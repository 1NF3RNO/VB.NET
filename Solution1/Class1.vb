Imports Microsoft.VisualBasic

Public Class Class1

    'A record for holding Employee Data
    Private Structure Employee
        Dim strFirstName As String
        Dim strSurname As String
    End Structure

    'Array to hold all of the Employees
    Dim Employees(100) As Employee
    Dim intEmployeeCount As Integer

End Class
