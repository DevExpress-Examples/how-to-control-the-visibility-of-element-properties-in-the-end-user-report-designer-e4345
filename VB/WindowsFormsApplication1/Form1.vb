﻿Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Expressions
' ...

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' Create a new report instance.
            Dim report As New XtraReport1()

            ' Invoke the End-User Report Designer form.
            Dim designTool As New ReportDesignTool(report)
            designTool.ShowDesignerDialog()
        End Sub

    End Class
End Namespace
