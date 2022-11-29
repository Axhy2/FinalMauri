Public Class frmConsultas
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0 '3.1
                query_read = "
select patente Patente,t.desc_tarea Tarea
from presupuestos p
inner join presupuestos_Tareas pt on p.id_presupuesto=pt.id_presupuesto 
inner join tareas t on pt.id_tarea=t.id_tarea
where patente=1 --X
"
                llenar(query_read, DataGridView1)
            Case 1 '3.2
                query_read = "
SELECT * from automoviles where id_propietario=1 --X
"
                llenar(query_read, DataGridView1)
            Case 2 '3.3
                query_read = "
SELECT nombre_propietario Nombre,sum(p.importe_total) [Total gastado]
FROM propietarios
inner join presupuestos p on propietarios.id_propietario=p.id_propietario
where fecha_prometida between '2022-11-28' and '2022-11-30'
group by nombre_propietario
"
                llenar(query_read, DataGridView1)
            Case 3 '3.4
                query_read = "
select pt.id_presupuesto ID,p.desc_presupuesto [Descripcion presupuesto],t.desc_tarea[Descripcion tarea],horas_estandar_tarea [Hs. Estandar],horas_reales [Hs. Finales] from presupuestos_Tareas pt 
inner join tareas t on pt.id_tarea=t.id_tarea
inner join presupuestos p on pt.id_presupuesto=p.id_presupuesto
where horas_reales>t.horas_estandar_tarea
"
                llenar(query_read, DataGridView1)
            Case 4 '3.5
                query_read = "
select e.desc_esp as Especialidad,count(t.id_especialidad) as Incidencias from presupuestos_Tareas pt
inner join tareas t on pt.id_tarea=t.id_tarea
inner join especialidades e on t.id_especialidad=e.id_especialidad
group by e.desc_esp
"
                llenar(query_read, DataGridView1)
        End Select
    End Sub

    Private Sub frmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class