Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TxtDesde.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtHasta.Text) Then
            Dim desde As Integer = Val(TxtDesde.Text)
            Dim hasta As Integer = Val(TxtHasta.Text)

            If desde >= hasta Then
                MessageBox.Show("El valor inicial debe ser menor que el valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ListBox.Items.Clear()

                ' Generar la lista de números usando un bucle for
                For i As Integer = desde To hasta
                    ListBox.Items.Add(i)
                Next
            End If
        Else
            MessageBox.Show("Por favor, ingrese valores numéricos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TxtDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesde.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Evitar que el carácter sea ingresado en el TextBox
        End If
    End Sub



    Private Sub TxtHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHasta.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Evitar que el carácter sea ingresado en el TextBox
        End If
    End Sub

    Private Sub Bpares_Click(sender As Object, e As EventArgs) Handles Bpares.Click

        ListBox.Items.Clear()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(TxtDesde.Text) Or String.IsNullOrEmpty(TxtHasta.Text) Then
            MsgBox("Por favor, ingrese valores en ambos campos.", MsgBoxStyle.Exclamation, "Campos vacíos")
            Return
        End If

        ' Validar que los campos contengan números válidos
        Dim desde As Integer
        Dim hasta As Integer

        If Not Integer.TryParse(TxtDesde.Text, desde) Or Not Integer.TryParse(TxtHasta.Text, hasta) Then
            MsgBox("Por favor, ingrese números válidos en ambos campos.", MsgBoxStyle.Exclamation, "Valores inválidos")
            Return
        End If

        ' Generar y agregar los números pares al ListBox
        For i As Integer = desde To hasta
            If i Mod 2 = 0 Then
                ListBox.Items.Add(i)
            End If
        Next
        Chart.Series.Clear()

        ' Crear una nueva serie para los números pares
        Dim serieNumerosPares As New DataVisualization.Charting.Series("Números Pares")
        serieNumerosPares.ChartType = DataVisualization.Charting.SeriesChartType.Line

        ' Agregar los puntos al gráfico desde el ListBox
        For Each numero As Integer In ListBox.Items
            serieNumerosPares.Points.AddXY(numero, numero)
        Next

        ' Agregar la serie al gráfico
        Chart.Series.Add(serieNumerosPares)

    End Sub

    Private Sub Bimpares_Click(sender As Object, e As EventArgs) Handles Bimpares.Click
        ListBox.Items.Clear()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(TxtDesde.Text) Or String.IsNullOrEmpty(TxtHasta.Text) Then
            MsgBox("Por favor, ingrese valores en ambos campos.", MsgBoxStyle.Exclamation, "Campos vacíos")
            Return
        End If

        ' Validar que los campos contengan números válidos
        Dim desde As Integer
        Dim hasta As Integer

        If Not Integer.TryParse(TxtDesde.Text, desde) Or Not Integer.TryParse(TxtHasta.Text, hasta) Then
            MsgBox("Por favor, ingrese números válidos en ambos campos.", MsgBoxStyle.Exclamation, "Valores inválidos")
            Return
        End If

        ' Generar y agregar los números impares al ListBox
        For i As Integer = desde To hasta
            If i Mod 2 <> 0 Then
                ListBox.Items.Add(i)
            End If
        Next
        Chart.Series.Clear()

        ' Crear una nueva serie para los números pares
        Dim serieNumerosImpares As New DataVisualization.Charting.Series("Números impares")
        serieNumerosImpares.ChartType = DataVisualization.Charting.SeriesChartType.Line

        ' Agregar los puntos al gráfico desde el ListBox
        For Each numero As Integer In ListBox.Items
            serieNumerosImpares.Points.AddXY(numero, numero)
        Next

        ' Agregar la serie al gráfico
        Chart.Series.Add(serieNumerosImpares)
    End Sub

    Private Sub Bprimos_Click(sender As Object, e As EventArgs) Handles Bprimos.Click
        ' Limpiar el ListBox antes de agregar nuevos elementos
        ListBox.Items.Clear()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(TxtDesde.Text) Or String.IsNullOrEmpty(TxtHasta.Text) Then
            MsgBox("Por favor, ingrese valores en ambos campos.", MsgBoxStyle.Exclamation, "Campos vacíos")
            Return
        End If

        ' Validar que los campos contengan números válidos
        Dim desde As Integer
        Dim hasta As Integer

        If Not Integer.TryParse(TxtDesde.Text, desde) Or Not Integer.TryParse(TxtHasta.Text, hasta) Then
            MsgBox("Por favor, ingrese números válidos en ambos campos.", MsgBoxStyle.Exclamation, "Valores inválidos")
            Return
        End If

        ' Generar y agregar los números primos al ListBox
        For i As Integer = desde To hasta
            Dim esPrimo As Boolean = True
            For j As Integer = 2 To Math.Sqrt(i)
                If i Mod j = 0 Then
                    esPrimo = False
                    Exit For
                End If
            Next
            If esPrimo Then
                ListBox.Items.Add(i)
            End If
        Next
        Chart.Series.Clear()

        ' Crear una nueva serie para los números pares
        Dim serieNumerosPrimos As New DataVisualization.Charting.Series("Números Primos")
        serieNumerosPrimos.ChartType = DataVisualization.Charting.SeriesChartType.Line

        ' Agregar los puntos al gráfico desde el ListBox
        For Each numero As Integer In ListBox.Items
            serieNumerosPrimos.Points.AddXY(numero, numero)
        Next

        ' Agregar la serie al gráfico
        Chart.Series.Add(serieNumerosPrimos)
    End Sub
End Class
