﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
    Inherits System.Windows.Forms.Form

    'Dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EmojiLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SubtitleLabel = New System.Windows.Forms.Label()
        Me.InventoryBtn = New System.Windows.Forms.Button()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.SalesReportBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmojiLabel
        '
        Me.EmojiLabel.AutoSize = True
        Me.EmojiLabel.Font = New System.Drawing.Font("Segoe UI Emoji", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmojiLabel.Location = New System.Drawing.Point(-21, 14)
        Me.EmojiLabel.Name = "EmojiLabel"
        Me.EmojiLabel.Size = New System.Drawing.Size(130, 89)
        Me.EmojiLabel.TabIndex = 6
        Me.EmojiLabel.Text = "📦"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(123, 26)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(184, 37)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Mini Grocery"
        '
        'SubtitleLabel
        '
        Me.SubtitleLabel.AutoSize = True
        Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubtitleLabel.ForeColor = System.Drawing.Color.Gray
        Me.SubtitleLabel.Location = New System.Drawing.Point(124, 66)
        Me.SubtitleLabel.Name = "SubtitleLabel"
        Me.SubtitleLabel.Size = New System.Drawing.Size(189, 23)
        Me.SubtitleLabel.TabIndex = 4
        Me.SubtitleLabel.Text = "Inventory Management"
        '
        'InventoryBtn
        '
        Me.InventoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.InventoryBtn.FlatAppearance.BorderSize = 0
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InventoryBtn.ForeColor = System.Drawing.Color.Black
        Me.InventoryBtn.Location = New System.Drawing.Point(0, 186)
        Me.InventoryBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(329, 53)
        Me.InventoryBtn.TabIndex = 3
        Me.InventoryBtn.Text = "📦 Inventory"
        Me.InventoryBtn.UseVisualStyleBackColor = False
        '
        'SalesBtn
        '
        Me.SalesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SalesBtn.FlatAppearance.BorderSize = 0
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesBtn.ForeColor = System.Drawing.Color.Black
        Me.SalesBtn.Location = New System.Drawing.Point(3, 282)
        Me.SalesBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(329, 53)
        Me.SalesBtn.TabIndex = 2
        Me.SalesBtn.Text = "🛒 "
        Me.SalesBtn.UseVisualStyleBackColor = False
        '
        'SalesReportBtn
        '
        Me.SalesReportBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SalesReportBtn.FlatAppearance.BorderSize = 0
        Me.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesReportBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SalesReportBtn.ForeColor = System.Drawing.Color.Black
        Me.SalesReportBtn.Location = New System.Drawing.Point(3, 378)
        Me.SalesReportBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalesReportBtn.Name = "SalesReportBtn"
        Me.SalesReportBtn.Size = New System.Drawing.Size(329, 53)
        Me.SalesReportBtn.TabIndex = 1
        Me.SalesReportBtn.Text = "📜 Transanction History"
        Me.SalesReportBtn.UseVisualStyleBackColor = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.LogoutBtn.Location = New System.Drawing.Point(15, 591)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(85, 32)
        Me.LogoutBtn.TabIndex = 0
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.SalesReportBtn)
        Me.Panel2.Controls.Add(Me.SalesBtn)
        Me.Panel2.Controls.Add(Me.LogoutBtn)
        Me.Panel2.Controls.Add(Me.InventoryBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 688)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TitleLabel)
        Me.Panel3.Controls.Add(Me.SubtitleLabel)
        Me.Panel3.Controls.Add(Me.EmojiLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 110)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(331, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1376, 73)
        Me.Panel4.TabIndex = 9
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(4, 4)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1368, 607)
        Me.panelMain.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelMain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(331, 73)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1376, 615)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1707, 688)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmojiLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents SubtitleLabel As Label
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents SalesReportBtn As Button
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
