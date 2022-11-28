Module Functions
    Public dgv As String
    Public wfrm As Int16 = 0
    Public query_read As String
    Public query_delete As String
    Public query_update As String
    Public query_create As String
    ''' <summary>
    ''' CONEXION
    ''' </summary>
    ''' 

    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-FFNOTC4; Initial Catalog=FinalMauri2022;Integrated Security=True") 'IZO-> LAB-L03\SQLEXPRESS \\ Casa->DESKTOP-10PSI9B \\ Notebook-> DESKTOP-FFNOTC4
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Comodidades
    Public Sub Cambio(frm_Nuevo, frm_Original)
        Dim frm As New Form
        frm = frm_Nuevo
        dgv = $"{frm_Nuevo.name.replace("frm", "")}"
        frm.Show()
        frm_Original.Close()
    End Sub
    Public Sub ocultarID(dgv As DataGridView, INDEX As Integer)
        dgv.Columns(INDEX).Visible = False
    End Sub


    'Conclusión no es necesario nombrar siempre los datasets, igual te dejo la otra manera por si necesitaras
    'llamar a las tablas de los datasets, pavo.
    '(Sobre todo si tiene que ver en el mismo form)
    'Public Sub llenar(query_select As String, dgv As DataGridView, table_name As String)
    '    Dim ds As New DataSet
    '    Dim adp As New SqlClient.SqlDataAdapter(query_select, conexion)
    '    ds.Tables.Add(table_name)
    '    adp.Fill(ds.Tables(table_name))
    '    dgv.DataSource = ds.Tables(table_name)
    'End Sub
    Public Sub llenar(query_select As String, dgv As DataGridView)
        Dim ds As New DataSet
        Dim table_name As String = "nombre_apropiado_de_una_tabla_de_un_dataset"
        Dim adp As New SqlClient.SqlDataAdapter(query_select, conexion)
        ds.Tables.Add(table_name)
        adp.Fill(ds.Tables(table_name))
        dgv.DataSource = ds.Tables(table_name)
    End Sub

    ''' <summary>
    '''fufufufunciones
    ''' </summary>
    ''' 

    Public Sub crear(query_insert As String, query_select As String, dgv As DataGridView)
        conectar()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query_insert
        Try
            cmd.ExecuteNonQuery()
            llenar(query_select, dgv) ', table_name)
            desconectar()

        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectar()
        End Try
    End Sub
    Public Sub borrar(query_delete As String, query_select As String, dgv As DataGridView)
        conectar()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query_delete
        Try
            cmd.ExecuteNonQuery()
            llenar(query_select, dgv) ', table_name)
            desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectar()
        End Try
    End Sub
    Public Sub actualizar(query_update As String, query_select As String, dgv As DataGridView)
        conectar()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query_update
        Try
            cmd.ExecuteNonQuery()
            llenar(query_select, dgv) ', table_name)
            desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectar()
        End Try
    End Sub
    Public Sub borrartxtbox(frm As Form)

        For Each box As TextBox In frm.Controls.OfType(Of TextBox)
            box.Clear()
        Next
    End Sub

    'Crear variable
    'Public wfrm As Integer = 0

    'frm Autos
    '    Private Sub buscarPropietario()
    '        LlenarDT("select * from propietarios where id_propietario = '" & Me.txtIDpropietario.Text & "'")
    '    End Sub

    '    Private Sub txtIDpropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDpropietario.KeyDown
    '        If e.KeyData = Keys.Enter Then
    '            wfrm = 1
    '            Dim frm As New frmPropietarios
    '            AddOwnedForm(frm)
    '            frm.ShowDialog()
    '            buscarPropietario()
    '        End If
    '    End Sub

    'frm Propietarios
    '    If wfrm = 1 Then
    '    If e.KeyData = Keys.Enter Then
    '    Dim frm As frmAutos = CType(Owner, frmAutos)
    '                frm.txtIDpropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
    '                wfrm = 0
    '                Me.Close()
    '    End If
End Module
