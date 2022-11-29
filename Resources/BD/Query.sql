
/* Plantear: 
3.1 INGRESANDO NRO PATENTE DEL AUTO MOSTRAR TODAS LAS TAREAS
REALIZADAS AL MISMO
3.2 INGRESANDO ID DEL PROPIETARIO, MOSTRAR TODOS LOS AUTOS QUE
TIENE
3.3 CUANTO DINERO GASTO UN PROPIETARIO DADO EN TAREAS Y EN
REPUESTOS EN UN RANGO DE FECHAS SIN IMPORTAR EL AUTO
*/
--3.1
select patente Patente,t.desc_tarea Tarea
from presupuestos p
inner join presupuestos_Tareas pt on p.id_presupuesto=pt.id_presupuesto 
inner join tareas t on pt.id_tarea=t.id_tarea
where patente=X

--3.2
SELECT * from automoviles where id_propietario=X

--3.3

SELECT nombre_propietario,sum(p.importe_total)
FROM propietarios
inner join presupuestos p on propietarios.id_propietario=p.id_propietario
where fecha_prometida between '2022-11-28' and '2022-11-30'
group by nombre_propietario

/* Ignorar

                SELECT id_presupuesto,pt.id_tarea,nombre_operario [Nombre operario],t.desc_tarea [Descripción tarea],horas_reales [Horas finales],importe_final [Importe]
				FROM presupuestos_Tareas as pt
                INNER JOIN tareas as t
                ON  pt.id_tarea = t.id_tarea
				INNER JOIN operarios as o
                ON  pt.id_operario = o.id_operario

				INSERT INTO presupuestos_Tareas  
				SELECT  {txtbox1.Text},{txtbox2.Text},{txtbox3.Text}, {txtbox4.Text},{txtbox3.Text}*o.importe_hora
				FROM operarios as o 
				where id_operario={txtbox3.Text}

				DELETE FROM presupuestos_Tareas WHERE id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} and presupuestos_Tareas.id_tarea={dgvPresupuestos.CurrentRow.Cells(1).Value};
update presupuestos_Tareas
SET presupuestos_Tareas.id_operario={txtbox3.Text},presupuestos_Tareas.importe_final={txtbox4.Text}*o.importe_hora
FROM operarios as o 
where o.id_operario={txtbox3.Text}

update presupuestos_Tareas
SET id_presupuesto={txtbox1.Text},id_tarea={txtbox2.Text},presupuestos_Tareas.id_operario={txtbox3.Text},presupuestos_Tareas.importe_final={txtbox4.Text}*o.importe_hora
FROM operarios as o 
where id_operario={txtbox3.Text}

update presupuestos_Tareas
SET id_presupuesto={txtbox1.Text},presupuestos_Tareas.id_operario={txtbox3.Text},presupuestos_Tareas.importe_final={txtbox4.Text}*o.importe_hora
FROM operarios as o 
where o.id_operario={txtbox3.Text}

update presupuestos_Tareas
SET presupuestos_Tareas.id_operario=2,presupuestos_Tareas.importe_final=999*o.importe_hora
FROM operarios as o 
where o.id_operario=3
select * from presupuestos_Tareas

update presupuestos_Repuestos
SET cant_repuestos={txtbox3.Text},presupuestos_Repuestos.importe_final={txtbox3.Text}*r.

FROM
    repuestos as r
WHERE
    r.id_repuesto ={dgvPresupuestos.CurrentRow.Cells(1).Value} and id_presupuesto={dgvPresupuestos.CurrentRow.Cells(0).Value} And presupuestos_Repuestos.id_repuesto={dgvPresupuestos.CurrentRow.Cells(1).Value}
                
            query_create = $"
				INSERT INTO presupuestos_Tareas  
				SELECT  {txtbox1.Text},{txtbox2.Text},{txtbox3.Text},{txtbox4.Text},{txtbox3.Text}*o.importe_hora
				FROM operarios as o 
				where id_operario = {txtbox3.Text} and id_especialidad={dgvPresupuestos.CurrentRow.Cells(6).Value}
                "
                SELECT id_presupuesto,pt.id_tarea,nombre_operario [Nombre operario],t.desc_tarea [Descripción tarea],horas_reales [Horas finales],importe_final [Importe],o.id_especialidad
				FROM presupuestos_Tareas as pt
                INNER JOIN tareas as t
                ON  pt.id_tarea = t.id_tarea
				INNER JOIN operarios as o
                ON  pt.id_operario = o.id_operario
                SELECT id_presupuesto,pt.id_tarea,nombre_operario [Nombre operario],t.desc_tarea [Descripción tarea],horas_reales [Horas finales],importe_final [Importe],o.id_especialidad
				FROM presupuestos_Tareas as pt
                INNER JOIN tareas as t
                ON  pt.id_tarea = t.id_tarea
				INNER JOIN operarios as o
                ON  pt.id_operario = o.id_operario
*/