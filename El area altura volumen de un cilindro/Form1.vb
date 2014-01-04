Public Class Form1
    Private Sub Cilindro()
        'Declaramos 5 variables de tipo double
        Dim altura, area, radio, radio2, volumen As Double
        'Condición que valida los TextBox si  estos están vacío 
        If TextBox_Altura.Text = "" Then
            MessageBox.Show("Ingrese una altura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Coloca el Focus en el TextBox_Altura
            TextBox_Altura.Focus()
        Else
            'Condición que valida los TextBox si  estos están vacío 
            If TextBox_Radio.Text = "" Then
                MessageBox.Show("Ingrese un radio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Coloca el Focus en el TextBox_Radio
                TextBox_Radio.Focus()
            Else
                'Funciones que convierte en un tipo double el valor que se ingrese por 
                'los TextBox y lo almacena en las variables altura, radio 
                altura = Convert.ToDouble(TextBox_Altura.Text)
                radio = Convert.ToDouble(TextBox_Radio.Text)
                'Método para calcular el area del cilindro
                area = (2 * Math.PI * radio * (altura + radio))
                ' Eleva al cuadrado el dato almacenado en las variable 
                ' radio y loa almacena  en la variable radio2
                radio2 = Math.Pow(radio, 2)
                'Método para calcular el volumen del cilindro
                volumen = (Math.PI * radio2 * altura)
                'Mostrar el resultado que esta en las variables area, volumen 
                Label_Area.Text = area.ToString()
                Label_Volumen.Text = volumen.ToString()
            End If
        End If

    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        'Restablecer los controles 
        TextBox_Altura.Text = ""
        TextBox_Radio.Text = ""
        Label_Area.Text = "0"
        Label_Volumen.Text = "0"
        TextBox_Altura.Focus()
    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        Cilindro()
    End Sub
End Class

