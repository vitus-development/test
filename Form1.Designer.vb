<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordVærdi = New System.Windows.Forms.TextBox()
        Me.BrugerTekstLabel = New System.Windows.Forms.Label()
        Me.BrugerIDTekst = New System.Windows.Forms.TextBox()
        Me.Inteiro_Financial_InsightDataSet = New Login.Inteiro_Financial_InsightDataSet()
        Me.FinansialInsightLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinansialInsightLoginTableAdapter = New Login.Inteiro_Financial_InsightDataSetTableAdapters.FinansialInsightLoginTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Inteiro_Financial_InsightDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinansialInsightLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.LoginLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 100)
        Me.Panel1.TabIndex = 1
        '
        'LoginLabel
        '
        Me.LoginLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.White
        Me.LoginLabel.Location = New System.Drawing.Point(131, 19)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(455, 50)
        Me.LoginLabel.TabIndex = 0
        Me.LoginLabel.Text = "Login til Financial Insigth"
        Me.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.PasswordLabel)
        Me.Panel2.Controls.Add(Me.PasswordVærdi)
        Me.Panel2.Controls.Add(Me.BrugerTekstLabel)
        Me.Panel2.Controls.Add(Me.BrugerIDTekst)
        Me.Panel2.Location = New System.Drawing.Point(6, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 349)
        Me.Panel2.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(27, 160)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 49
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordVærdi
        '
        Me.PasswordVærdi.Location = New System.Drawing.Point(22, 177)
        Me.PasswordVærdi.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordVærdi.Name = "PasswordVærdi"
        Me.PasswordVærdi.Size = New System.Drawing.Size(133, 20)
        Me.PasswordVærdi.TabIndex = 48
        '
        'BrugerTekstLabel
        '
        Me.BrugerTekstLabel.AutoSize = True
        Me.BrugerTekstLabel.Location = New System.Drawing.Point(19, 103)
        Me.BrugerTekstLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BrugerTekstLabel.Name = "BrugerTekstLabel"
        Me.BrugerTekstLabel.Size = New System.Drawing.Size(38, 13)
        Me.BrugerTekstLabel.TabIndex = 47
        Me.BrugerTekstLabel.Text = "Bruger"
        '
        'BrugerIDTekst
        '
        Me.BrugerIDTekst.Location = New System.Drawing.Point(22, 131)
        Me.BrugerIDTekst.Margin = New System.Windows.Forms.Padding(4)
        Me.BrugerIDTekst.Name = "BrugerIDTekst"
        Me.BrugerIDTekst.Size = New System.Drawing.Size(133, 20)
        Me.BrugerIDTekst.TabIndex = 46
        '
        'Inteiro_Financial_InsightDataSet
        '
        Me.Inteiro_Financial_InsightDataSet.DataSetName = "Inteiro_Financial_InsightDataSet"
        Me.Inteiro_Financial_InsightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinansialInsightLoginBindingSource
        '
        Me.FinansialInsightLoginBindingSource.DataMember = "FinansialInsightLogin"
        Me.FinansialInsightLoginBindingSource.DataSource = Me.Inteiro_Financial_InsightDataSet
        '
        'FinansialInsightLoginTableAdapter
        '
        Me.FinansialInsightLoginTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Inteiro_Financial_InsightDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinansialInsightLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordVærdi As TextBox
    Friend WithEvents BrugerTekstLabel As Label
    Friend WithEvents BrugerIDTekst As TextBox
    Friend WithEvents Inteiro_Financial_InsightDataSet As Inteiro_Financial_InsightDataSet
    Friend WithEvents FinansialInsightLoginBindingSource As BindingSource
    Friend WithEvents FinansialInsightLoginTableAdapter As Inteiro_Financial_InsightDataSetTableAdapters.FinansialInsightLoginTableAdapter
End Class
