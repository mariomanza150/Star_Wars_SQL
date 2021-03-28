Imports Entidades_2

Public Class Visualizer
    Private Sub limpiar()
        txt_id.Text = ""
        txt_nombre.Text = ""
        txt_faccion.Text = ""
        txt_poder.Text = ""
        txt_nacimiento.Text = ""
    End Sub
    Private Sub bttn_nuevo_Click(sender As Object, e As EventArgs) Handles bttn_nuevo.Click
        limpiar()
    End Sub

    Private Sub bttn_consultar_Click(sender As Object, e As EventArgs) Handles bttn_consultar.Click
        Dim consulta As New Personaje
        With consulta
            .Id = txt_id.Text
            Dim data = consulta.PersonajeConsulta
            If Not data(0).Equals("empty") Then
                txt_nombre.Text = data(0)
                txt_faccion.Text = data(1)
                txt_poder.Text = data(2)
                txt_nacimiento.Text = data(3)
            Else
                txt_nombre.Text = "Dato no existente"
            End If

        End With
    End Sub

    Private Sub bttn_modificar_Click(sender As Object, e As EventArgs) Handles bttn_modificar.Click
        Dim modificar As New Personaje
        With modificar
            .Id = txt_id.Text
            .Nombre = txt_nombre.Text
            .Faccion = txt_faccion.Text
            .Poder = txt_poder.Text
            .Nacimiento = txt_nacimiento.Text
            modificar.PersonajeCambio()
        End With
    End Sub

    Private Sub bttn_agregar_Click(sender As Object, e As EventArgs) Handles bttn_agregar.Click
        Dim agregar As New Personaje
        With agregar
            .Id = txt_id.Text
            .Nombre = txt_nombre.Text
            .Faccion = txt_faccion.Text
            .Poder = txt_poder.Text
            .Nacimiento = txt_nacimiento.Text
            agregar.PersonajeAlta()
        End With
    End Sub

    Private Sub bttn_salir_Click(sender As Object, e As EventArgs) Handles bttn_salir.Click
        End
    End Sub
End Class
