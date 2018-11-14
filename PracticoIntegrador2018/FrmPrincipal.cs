﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticoIntegrador2018
{
    public partial class Form1 : Form
    {
        AccesoDatos acceso = new AccesoDatos(@"Data Source=DESKTOP-FRANCO\SQLEXPRESS;Initial Catalog=Cine;User ID=sa; password=110254");
        string consulta;
        string consultaParametrizada;
        int deprueba;

        //Enumeracion para verificar que consulta se debe ejecutar
        public enum Consultero {
            C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,none
        }
        //se instancia la enumeracion en none
        Consultero consultero = Consultero.none;
        //----------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //cargarCombo(cboConsulta2, "paises");
        }
        //----------------------------------------------------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        //----------------------------------------------------------------------------------------
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = acceso.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        //----------------------------------------------------------------------------------------
        private void btnABM_Click(object sender, EventArgs e)
        {
            Form abm = new FrmABM();
            abm.Show();

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta1_Click_1(object sender, EventArgs e)//SE PARAMETRIZAN LOS NOMBRES DEL PRIMER SELECT
        {
            MessageBox.Show("Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                           "'[C-H]%' and edad between 30 and 50 UNION Select id_director, Nombre, " +
                           "Nacionalidad from Directores where nombre not like '[J-Q]%' and edad " +
                           "between 50 and 60 Order By 3 desc ..........se puede parametrizar el " +
                           "rango de edad", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                            "'[C-H]%' and fecha_nacimiento between '2000/1/1' and '2018/1/1' UNION Select id_director, Nombre, " +
                            "Nacionalidad from Directores where nombre not like '[J-Q]%' and fecha_nacimiento " +
                            "between '2000/1/1' and '2018/1/1' Order By 3 desc";
            consultero = Consultero.C1;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta1.Checked == true)
            {
                consultaParametrizada =  "Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                            "'["+txtConsulta1.Text+"-"+txtConsulta1C2.Text+"]%' and fecha_nacimiento between '2000/1/1' and '2018/1/1' UNION Select id_director, Nombre, " +
                            "Nacionalidad from Directores where nombre not like '[J-Q]%' and fecha_nacimiento " +
                            "between '2000/1/1' and '2018/1/1' Order By 3 desc";
                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros

            }
        }
        //----------------------------------------------------------------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            limpiarColumnas(dgrvConsultas);
            //limpiarRadioBtn();
            if (radioBtnVacios())//Metodo que comprueba que ningun btn este seleccionado
            {

                switch (consultero)
                {
                    case Consultero.C1:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C2:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C3:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C4:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C5:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C6:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C7:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C8:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C9:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.C10:
                        acceso.putInGrid(dgrvConsultas, consulta);
                        break;
                    case Consultero.none:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    default:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
            }
            else
            {
                switch (consultero)
                {
                    case Consultero.C1:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C2:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C3:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C4:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C5:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C6:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                          
                    case Consultero.C7:                 
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                         
                    case Consultero.C8:                 
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                          
                    case Consultero.C9:                
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                         
                    case Consultero.C10:                
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.none:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    default:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
            }
            
        }
        //----------------------------------------------------------------------------------------
        private void limpiarColumnas(DataGridView dgrvConsultas)
        {
            for (int i = 0; i < dgrvConsultas.ColumnCount; i++)
            {
                int v = i;
                dgrvConsultas.Columns.RemoveAt(i);
            }
        }
        //----------------------------------------------------------------------------------------
        private bool radioBtnVacios()
        {
            if (rbtnConsulta1.Checked == false && rbtnConsulta2.Checked == false && rbtnConsulta3.Checked == false && rbtnConsulta4.Checked == false && rbtnConsulta5.Checked == false
                && rbtnConsulta6.Checked == false && rbtnConsulta7.Checked == false && rbtnConsulta8.Checked == false && rbtnConsulta9.Checked == false && rbtnConsulta10.Checked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta2_Click(object sender, EventArgs e)//SE PARAMETRIZA LA NACIONALIDAD DE LA PRIMER CONSULTA
        {
            MessageBox.Show("Select id_actor, nombre, nacionalidad From actores a Where a.nacionalidad in ('Argentina') and nombre not like '[A - F]%' and fecha_nacimiento > '1990/1/1' UNION Select id_pelicula, nombre, idioma " +
                            "From pelicula p join idiomas i  on p.id_idioma = i.id_idiomas join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion join generos g  on  g.id_genero = p.id_genero " +
                            "Where i.idioma in ('Ingles') and C.clasificacion like '+16'  and g.descripcion like 'Terror' or g.descripcion like 'Accion' Order by 2",
                            "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta = "Select id_actor, nombre, nacionalidad From actores a Where a.nacionalidad in ('Argentina') and nombre not like '[A - F]%' and fecha_nacimiento > '1990/1/1' UNION Select id_pelicula, nombre, idioma " +
                            "From pelicula p join idiomas i  on p.id_idioma = i.id_idiomas join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion join generos g  on  g.id_genero = p.id_genero " +
                            "Where i.idioma in ('Ingles') and C.clasificacion like '+16'  and g.descripcion like 'Terror' or g.descripcion like 'Accion' Order by 2";

            consultero = Consultero.C2;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta2.Checked == true)
            { 
   
                consultaParametrizada = "Select id_actor, nombre, nacionalidad From actores a Where a.nacionalidad in ('"+txtConsulta2.Text+"') and nombre not like '[A - F]%' and fecha_nacimiento > '1990/1/1' UNION Select id_pelicula, nombre, idioma " +
                            "From pelicula p join idiomas i  on p.id_idioma = i.id_idiomas join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion join generos g  on  g.id_genero = p.id_genero " +
                            "Where i.idioma in ('Ingles') and C.clasificacion like '+16'  and g.descripcion like 'Terror' or g.descripcion like 'Accion' Order by 2";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta6_Click(object sender, EventArgs e) //SE PARAMETRIZA LOS TRES AÑOS QUE SE BRINDAN POR LA CONSULTA
        {
            MessageBox.Show("Select year(c.fecha)'Fecha', sum(cantidad)'Cantidad total', avg(precio)'Precio Promedio', sum(precio*cantidad)'Importe total' From comprobante c join detalle_comprobantes d " +
                "on c.id_comprobante = d.id_comprobante Where year(fecha) in (2013, 2016, 2017) Group by year(c.fecha) having sum(precio * cantidad) < 2500 order by 4 desc",
                                "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta = "Select year(c.fecha)'Fecha', sum(cantidad)'Cantidad total', avg(precio)'Precio Promedio', sum(precio * cantidad)'Importe total' From comprobante c join detalle_comprobantes d " +
                "on c.id_comprobante = d.id_comprobante Where year(fecha) in (2013, 2016, 2017) Group by year(c.fecha) having sum(precio * cantidad) < 2500 order by 4 desc";

            consultero = Consultero.C6;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta6.Checked == true)
            {
                consultaParametrizada = "Select year(c.fecha)'Fecha', sum(cantidad)'Cantidad total', avg(precio)'Precio Promedio', sum(precio * cantidad)'Importe total' From comprobante c join detalle_comprobantes d " +
                "on c.id_comprobante = d.id_comprobante Where year(fecha) in (" + txtC1c1.Text + ", " + txtC1c2.Text + ", " + txtC1c3.Text + ") Group by year(c.fecha) having sum(precio * cantidad) < 2500 order by 4 desc";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
        //----------------------------------------------------------------------------------------
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta3_Click(object sender, EventArgs e)//SE PARAMETRIZARA EL AÑO Y  EL COUNT DEL HAVING
        {
            MessageBox.Show("select p.nombre, count(id_entrada) 'Cantidad de entradas vendidas' from pelicula p, funciones f, Detalle_Comprobantes d, entradas e, comprobante c where e.id_detalle = d.id_detalle " +
                                        "and d.id_funcion = f.id_funcion and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and year(c.fecha) = 2016 group by p.nombre having 50 > (select count(e1.id_entrada)From entradas e1)",
                           "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "select p.nombre, count(id_entrada) 'Cantidad de entradas vendidas' from pelicula p, funciones f, Detalle_Comprobantes d, entradas e, comprobante c where e.id_detalle = d.id_detalle " +
                                        "and d.id_funcion = f.id_funcion and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and year(c.fecha) = 2016 group by p.nombre having 50 > (select count(e1.id_entrada)From entradas e1)";

            consultero = Consultero.C3;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta3.Checked == true)
            {
                consultaParametrizada = "select p.nombre, count(id_entrada) 'Cantidad de entradas vendidas' from pelicula p, funciones f, Detalle_Comprobantes d, entradas e, comprobante c where e.id_detalle = d.id_detalle " +
                                        "and d.id_funcion = f.id_funcion and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and year(c.fecha) = " + txtConsulta3.Text + " group by p.nombre having " + txtConsulta3c2.Text + " > (select count(e1.id_entrada)From entradas e1)";
                
                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta7_Click(object sender, EventArgs e)//SE PARAMETRIZA EL VALOR DE COMPARACIÓN
        {
            
                MessageBox.Show("Select id_Comprobante 'ID COMPROBANTE', fecha 'FECHA' From comprobante c where 350 < " +
                    "(Select sum(cantidad * precio) From Detalle_Comprobantes dc Where dc.id_comprobante = c.id_comprobante)", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                consulta = "Select id_Comprobante 'ID COMPROBANTE', fecha 'FECHA' From comprobante c where 350 < " +
                    "(Select sum(cantidad * precio) From Detalle_Comprobantes dc Where dc.id_comprobante = c.id_comprobante)";

                consultero = Consultero.C7;

                //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

                if (rbtnConsulta7.Checked == true)
                {
                    consultaParametrizada = "Select id_Comprobante 'ID COMPROBANTE', fecha 'FECHA' From comprobante c where " + txtConsulta7.Text + " < " +
                    "(Select sum(cantidad * precio) From Detalle_Comprobantes dc Where dc.id_comprobante = c.id_comprobante)";

                    //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
                }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta8_Click(object sender, EventArgs e)//SE PARAMETRIZA LA CANTIDAD DE AÑOS ANTERIORES DEL CUAL QUEREMOS CONOCER EL DETALLE
        {

            MessageBox.Show("Select c.id_comprobante 'Nro comprobante', f.rangoHorario 'Horario de la funcion',f.id_pelicula 'Nro de pelicula' " +
                "From Comprobante c join Detalle_Comprobantes dc on c.id_comprobante = dc.id_comprobante join Funciones f on f.id_funcion = dc.id_funcion Where year(c.fecha) = year(getdate()) - 1" +
                "and 200 < any(Select avg(precio * cantidad) From detalle_comprobantes dc1 Where dc1.id_comprobante = c.id_comprobante and dc1.id_funcion = f.id_funcion)", "Instrucciones",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "Select c.id_comprobante 'Nro comprobante', f.rangoHorario 'Horario de la funcion',f.id_pelicula 'Nro de pelicula' " +
                "From Comprobante c join Detalle_Comprobantes dc on c.id_comprobante = dc.id_comprobante join Funciones f on f.id_funcion = dc.id_funcion Where year(c.fecha) = year(getdate()) - 1" +
                "and 200 < any(Select avg(precio * cantidad) From detalle_comprobantes dc1 Where dc1.id_comprobante = c.id_comprobante and dc1.id_funcion = f.id_funcion)";

            consultero = Consultero.C8;
            //" + txtConsulta8.Text + "

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta8.Checked == true)
            {
                consultaParametrizada = "Select c.id_comprobante 'Nro comprobante', f.rangoHorario 'Horario de la funcion',f.id_pelicula 'Nro de pelicula' " +
                "From Comprobante c join Detalle_Comprobantes dc on c.id_comprobante = dc.id_comprobante join Funciones f on f.id_funcion = dc.id_funcion Where year(c.fecha) = year(getdate()) - " + txtConsulta8.Text + " " +
                "and 200 < any(Select avg(precio * cantidad) From detalle_comprobantes dc1 Where dc1.id_comprobante = c.id_comprobante and dc1.id_funcion = f.id_funcion)";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }
        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta9_Click(object sender, EventArgs e) //SE PARAMETRIZA LA FORMA DE PAGO Y DESCRIPCION DE FORMA DE COMPRA
        {

            MessageBox.Show("Select sum (cantidad*precio)'Cantidad Ganada' from detalle_comprobantes dc, comprobante c, formaDePagos fp, formaCompras Fc " +
                "where fp.id_formadePago = c.id_formaPago and fc.id_formaCompra = c.id_formaCompra and c.id_comprobante = dc.id_comprobante " +
                "and year(fecha) = year(getdate()) - 1 and   formaPago like 'Debito' and descripcion like 'Boleteria'", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "Select sum (cantidad*precio)'Cantidad Ganada' from detalle_comprobantes dc, comprobante c, formaDePagos fp, formaCompras Fc " +
                "where fp.id_formadePago = c.id_formaPago and fc.id_formaCompra = c.id_formaCompra and c.id_comprobante = dc.id_comprobante " +
                "and year(fecha) = year(getdate()) - 1 and   formaPago like 'Debito' and descripcion like 'Boleteria'";

            consultero = Consultero.C9;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta9.Checked == true)
            {
                consultaParametrizada = "Select sum (cantidad*precio)'Cantidad Ganada' from detalle_comprobantes dc, comprobante c, formaDePagos fp, formaCompras Fc " +
                "where fp.id_formadePago = c.id_formaPago and fc.id_formaCompra = c.id_formaCompra and c.id_comprobante = dc.id_comprobante " +
                "and year(fecha) = year(getdate()) - 1 and   formaPago like " + txtConsulta9.Text + " and descripcion like " + txtConsulta9c2.Text + "";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta10_Click(object sender, EventArgs e) //SE PARAMETRIZA LA COMPARACIÓN DE FECHA DE NACIMIENTO
        {

            MessageBox.Show("Select d.nombre 'Nombre Director', p.nombre 'Pais Director', d.fecha_nacimiento 'Fecha Nacimiento', pe.nombre 'Nombre Pelicula',i.Idioma 'Idioma' " +
                "From pelicula pe join directores d on pe.id_director = d.id_director join paises p on pe.id_pais = p.id_pais join idiomas i on pe.id_idioma = i.id_idiomas " +
                "Where fecha_nacimiento > 1950 and reseña like '%óscar%' and i.Idioma in ('ingles') Order by d.nombre", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "Select d.nombre 'Nombre Director', p.nombre 'Pais Director', d.fecha_nacimiento 'Fecha Nacimiento', pe.nombre 'Nombre Pelicula',i.Idioma 'Idioma' " +
                "From pelicula pe join directores d on pe.id_director = d.id_director join paises p on pe.id_pais = p.id_pais join idiomas i on pe.id_idioma = i.id_idiomas " +
                "Where fecha_nacimiento > 1950 and reseña like '%óscar%' and i.Idioma in ('ingles') Order by d.nombre";

            consultero = Consultero.C10;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta10.Checked == true)
            {
                consultaParametrizada = "Select d.nombre 'Nombre Director', p.nombre 'Pais Director', d.fecha_nacimiento 'Fecha Nacimiento', pe.nombre 'Nombre Pelicula',i.Idioma 'Idioma' " +
                "From pelicula pe join directores d on pe.id_director = d.id_director join paises p on pe.id_pais = p.id_pais join idiomas i on pe.id_idioma = i.id_idiomas " +
                "Where fecha_nacimiento > " + txtConsulta10.Text + " and reseña like '%óscar%' and i.Idioma in ('ingles') Order by d.nombre";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta4_Click(object sender, EventArgs e) //SE PARAMETRIZA EL SEGUNDO ID Y EL HAVING
        {
         //   MessageBox.Show("Select p.nombre, avg(e.id_entrada) 'Venta de entradas promedio' From pelicula p, funciones f, detalle_comprobanteS d, entradas e, comprobante c    Where e.id_detalle = d.id_detalle " +
         //       "and d.id_funcion = f.id_funcion and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and p.id_pelicula not in (1, 4) group by p.nombre " +
         //       "having avg(e.id_entrada) < (Select count(id_entrada) / count(p1.id_pelicula) From entradas e1, pelicula p1)", "Instrucciones", MessageBoxButtons.OK,MessageBoxIcon.Information);
         //
         //   consulta = "Select p.nombre, avg(e.id_entrada) 'Venta de entradas promedio' From pelicula p, funciones f, detalle_comprobanteS d, entradas e, comprobante c    Where e.id_detalle = d.id_detalle " +
         //       "and d.id_funcion = f.id_funcion and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and p.id_pelicula not in (1, 4) group by p.nombre " +
         //       "having avg(e.id_entrada) < (Select count(id_entrada) / count(p1.id_pelicula) From entradas e1, pelicula p1)";
         //
         //   consultero = Consultero.C4;
         //
         //   //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas
         //
         //   if (rbtnConsulta4.Checked == true)
         //   {
         //       consultaParametrizada = "select p.nombre, avg(e.id_entrada) 'Venta de entradas promedio'" +
         //       "from peliculas p, funciones f, detalle_comprobante d, entradas e" +
         //       "where e.id_detalle = d.id_detalle and d.id_funcion = f.id_funciond and f.id_pelicula = p.id_pelicula and d.id_comprobante = c.id_comprobante and p.id_pelicula not in (1,"+ txtConsulta4c2 +" )" +
         //       "group by p.nombre" +
         //       "having"+ txtConsulta4 +" < (select count(e1.id_entrada) / count(p1.id_pelicula))" +
         //       "from entradas e1, peliculas p1)";
         //
         //       //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
         //   }
        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta5_Click(object sender, EventArgs e) //SE PARAMETRIZA LAS LETRAS
        {
            MessageBox.Show("select p.id_pelicula 'Código de Película', p.nombre 'Película', g.id_genero 'Código de Genero', nombre, sum(cantidad * d.precio) 'Importe', sum(cantidad)'Cantidad total', "+
                            "avg(d.precio) 'Precio promedio' from pelicula p join generos g on p.id_genero = g.id_genero join funciones f on f.id_pelicula = p.id_pelicula join detalle_comprobantes d on d.id_funcion = f.id_funcion "+
                            " join comprobante c on c.id_comprobante = d.id_comprobante where p.nombre like '[g-p]%' or g.descripcion in ('thriller', 'terror', 'horror') group by p.id_pelicula, p.nombre, g.id_genero, nombre order by 2, 4 desc", 
                            "INSTRUCIONES", MessageBoxButtons.OK,MessageBoxIcon.Information);

            consulta = "select p.id_pelicula 'Código de Película', p.nombre 'Película', g.id_genero 'Código de Genero', nombre, sum(cantidad * d.precio) 'Importe', sum(cantidad)'Cantidad total', " +
                            "avg(d.precio) 'Precio promedio' from pelicula p join generos g on p.id_genero = g.id_genero join funciones f on f.id_pelicula = p.id_pelicula join detalle_comprobantes d on d.id_funcion = f.id_funcion " +
                            " join comprobante c on c.id_comprobante = d.id_comprobante where p.nombre like '[g-p]%' or g.descripcion in ('thriller', 'terror', 'horror') group by p.id_pelicula, p.nombre, g.id_genero, nombre order by 2, 4 desc";

            consultero = Consultero.C5;
            //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros

            if (rbtnConsulta5.Checked == true)
            {
                consultaParametrizada = "select p.id_pelicula 'Código de Película', p.nombre 'Película', g.id_genero 'Código de Genero', nombre, sum(cantidad * d.precio) 'Importe', sum(cantidad)'Cantidad total', " +
                            "avg(d.precio) 'Precio promedio' from pelicula p join generos g on p.id_genero = g.id_genero join funciones f on f.id_pelicula = p.id_pelicula join detalle_comprobantes d on d.id_funcion = f.id_funcion " +
                            " join comprobante c on c.id_comprobante = d.id_comprobante where p.nombre like '["+txtConsulta5.Text+"-"+txtConsulta5c2+"]%' or g.descripcion in ('thriller', 'terror', 'horror') group by p.id_pelicula, p.nombre, g.id_genero, nombre order by 2, 4 desc";

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }

        }
    }
}

