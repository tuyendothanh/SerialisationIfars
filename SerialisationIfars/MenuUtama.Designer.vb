﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoneksiDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregasiToolStripMenuItem, Me.KoneksiDatabaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(656, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregasiToolStripMenuItem
        '
        Me.AgregasiToolStripMenuItem.Name = "AgregasiToolStripMenuItem"
        Me.AgregasiToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AgregasiToolStripMenuItem.Text = "Agregasi"
        '
        'KoneksiDatabaseToolStripMenuItem
        '
        Me.KoneksiDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConnectionToolStripMenuItem})
        Me.KoneksiDatabaseToolStripMenuItem.Name = "KoneksiDatabaseToolStripMenuItem"
        Me.KoneksiDatabaseToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoneksiDatabaseToolStripMenuItem.Text = "Setting"
        '
        'DatabaseConnectionToolStripMenuItem
        '
        Me.DatabaseConnectionToolStripMenuItem.Name = "DatabaseConnectionToolStripMenuItem"
        Me.DatabaseConnectionToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DatabaseConnectionToolStripMenuItem.Text = "Database Connection"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 371)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoneksiDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregasiToolStripMenuItem As ToolStripMenuItem
End Class
