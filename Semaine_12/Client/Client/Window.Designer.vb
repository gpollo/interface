﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxOutput, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSend, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnection, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInput, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxAddress, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPort, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07122!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07122!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07355!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07355!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85522!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85522!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(282, 253)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOutput.Location = New System.Drawing.Point(3, 99)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(276, 42)
        Me.TextBoxOutput.TabIndex = 5
        '
        'ButtonSend
        '
        Me.ButtonSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSend.Location = New System.Drawing.Point(3, 147)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(276, 42)
        Me.ButtonSend.TabIndex = 2
        Me.ButtonSend.Text = "Envoyer"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonConnection.Location = New System.Drawing.Point(3, 3)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(276, 42)
        Me.ButtonConnection.TabIndex = 0
        Me.ButtonConnection.Text = "Connecter"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInput.Location = New System.Drawing.Point(3, 51)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.ReadOnly = True
        Me.TextBoxInput.Size = New System.Drawing.Size(276, 42)
        Me.TextBoxInput.TabIndex = 1
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxAddress.Location = New System.Drawing.Point(3, 195)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(276, 22)
        Me.TextBoxAddress.TabIndex = 3
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPort.Location = New System.Drawing.Point(3, 224)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(276, 22)
        Me.TextBoxPort.TabIndex = 4
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Window"
        Me.Text = "Client"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents ButtonSend As Button
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents TextBoxPort As TextBox
    Friend WithEvents TextBoxOutput As TextBox
End Class
