<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bpares = New System.Windows.Forms.Button()
        Me.Bimpares = New System.Windows.Forms.Button()
        Me.Bprimos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDesde = New System.Windows.Forms.TextBox()
        Me.TxtHasta = New System.Windows.Forms.TextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar funcion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bpares
        '
        Me.Bpares.Location = New System.Drawing.Point(68, 229)
        Me.Bpares.Name = "Bpares"
        Me.Bpares.Size = New System.Drawing.Size(146, 23)
        Me.Bpares.TabIndex = 1
        Me.Bpares.Text = "Numeros pares"
        Me.Bpares.UseVisualStyleBackColor = True
        '
        'Bimpares
        '
        Me.Bimpares.Location = New System.Drawing.Point(68, 258)
        Me.Bimpares.Name = "Bimpares"
        Me.Bimpares.Size = New System.Drawing.Size(146, 23)
        Me.Bimpares.TabIndex = 2
        Me.Bimpares.Text = "Numeros impares"
        Me.Bimpares.UseVisualStyleBackColor = True
        '
        'Bprimos
        '
        Me.Bprimos.Location = New System.Drawing.Point(68, 287)
        Me.Bprimos.Name = "Bprimos"
        Me.Bprimos.Size = New System.Drawing.Size(146, 23)
        Me.Bprimos.TabIndex = 3
        Me.Bprimos.Text = "Numeros primos"
        Me.Bprimos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta"
        '
        'TxtDesde
        '
        Me.TxtDesde.Location = New System.Drawing.Point(114, 78)
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.Size = New System.Drawing.Size(100, 20)
        Me.TxtDesde.TabIndex = 6
        '
        'TxtHasta
        '
        Me.TxtHasta.Location = New System.Drawing.Point(114, 119)
        Me.TxtHasta.Name = "TxtHasta"
        Me.TxtHasta.Size = New System.Drawing.Size(100, 20)
        Me.TxtHasta.TabIndex = 7
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(312, 12)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(203, 147)
        Me.ListBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(177, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lista de números"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Chart)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListBox)
        Me.Panel1.Controls.Add(Me.TxtDesde)
        Me.Panel1.Controls.Add(Me.Bprimos)
        Me.Panel1.Controls.Add(Me.TxtHasta)
        Me.Panel1.Controls.Add(Me.Bimpares)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Bpares)
        Me.Panel1.Location = New System.Drawing.Point(44, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 376)
        Me.Panel1.TabIndex = 10
        '
        'Chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(293, 165)
        Me.Chart.Name = "Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(239, 208)
        Me.Chart.TabIndex = 9
        Me.Chart.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 483)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Formulario 4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Bpares As Button
    Friend WithEvents Bimpares As Button
    Friend WithEvents Bprimos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDesde As TextBox
    Friend WithEvents TxtHasta As TextBox
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart As DataVisualization.Charting.Chart
End Class
