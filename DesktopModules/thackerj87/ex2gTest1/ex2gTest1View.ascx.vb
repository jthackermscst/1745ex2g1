#Region "Copyright"

' 
' Copyright (c) 2015
' by thackerj87
' 

#End Region

#Region "Using Statements"

Imports System
Imports DotNetNuke.Entities.Modules

#End Region

Namespace thackerj87.ex2gTest1

    Partial Public Class ex2gTest1View
        Inherits PortalModuleBase

#Region "Event Handlers"

        Protected Overrides Sub OnInit(e As EventArgs)
            MyBase.OnInit(e)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            If Not Page.IsPostBack Then
                'txtField.Text = DirectCast(Settings("field"), String)
            End If
        End Sub

        Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
            'ModuleController.Instance.UpdateModuleSetting(ModuleId, "field", txtField.Text)
            ' Skins.Skin.AddModuleMessage(Me, "Update Successful", Skins.Controls.ModuleMessage.ModuleMessageType.GreenSuccess)
        End Sub

        Protected Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        End Sub

#End Region

        Protected Sub MessageButton_Click(sender As Object, e As EventArgs) Handles MessageButton.Click
            MessageLabel.Text = "Hello " & FirstNameTextBox.Text & " " & LastNameTextBox.Text

        End Sub
    End Class

End Namespace

