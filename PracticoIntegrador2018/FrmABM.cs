using System;
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
    public partial class FrmABM : Form
    {
        const int tam = 25;
        int idPeli,idActor;
        Pelicula[] peliculas = new Pelicula[tam];
        AccesoDatos datos = new AccesoDatos(@"Data source=DESKTOP-FRANCO\SQLEXPRESS;Initial Catalog=Cine;  user id = sa; password = 110254");
        public FrmABM()
        {

            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        private void FrmABM_Load(object sender, EventArgs e)
        {
            btnModAct.Visible = false;
            btnAceptarMod.Visible = false;
            dtpEdad.Text = "01/01/1991";
            dtpDura.Text = "00:00:00";
            bloqueoPelis(false);
            bloqueoActores(false);
            cargarCombo(cboGenero, "Generos");
            cargarCombo(cboIdioma, "Idiomas");
            cargarCombo(cboClasificacion, "ClasificacionesPelicula");
            cargarCombo(cboSubtitulos, "subtitulos");
            cargarCombo(cboDirector, "Directores");
            //cargarCombo(cboPaisA, "paises");
            cargarCombo(cboPaisP, "paises");
            //----------------------------------------------------------
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
            datos.putInGrid(dgvActores, "Select * from Actores");

        }
        //---------METODOS-------------------------------------------------
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        //----------------------------------------------------------------       
        private void bloqueoPelis(bool x)
        {
            txtIdPeli.Enabled = false;
            txtNombrePelicula.Enabled = x;
            dtpDura.Enabled = x;
            cboGenero.Enabled = x;
            cboIdioma.Enabled = x;
            cboClasificacion.Enabled = x;
            cboSubtitulos.Enabled = x;
            cboDirector.Enabled = x;
            cboPaisP.Enabled = x;

        }
        //----------------------------------------------------------------
        private void bloqueoActores(bool x)
        {
            txtIdActor.Enabled = x;
            txtNombreActor.Enabled = x;
            txtApellidoActor.Enabled = x;
            txtNacionalidad.Enabled = x;
           // cboPaisA.Enabled = x;
            dtpEdad.Enabled = x;
            txtReseña.Enabled = x;
            
        }
        //---------------------------------------------------------------
        private void limpiarTxtPelis()
        {
            txtIdPeli.Text = "";
            txtNombrePelicula.Text = "";
            dtpDura.Text = "00:00:00";
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            cboSubtitulos.SelectedIndex = -1;
            cboDirector.SelectedIndex = -1;
            cboPaisP.SelectedIndex = -1;

        }
        //---------------------------------------------------------------
        private void limpiarTxtActores()
        {
            txtIdActor.Text = "";
            txtNombreActor.Text = "";
            txtApellidoActor.Text = "";
            txtNacionalidad.Text = "";
            //cboPaisA.SelectedIndex = -1;
            dtpEdad.Text = "01/01/1990";
            txtReseña.Text = "";
        }

        //-------------------BOTONES PELICULA--------------------------------------------------
        private void btnNuevoPeli_Click(object sender, EventArgs e)
        {
            bloqueoPelis(true);
            txtIdPeli.Enabled = true;
            limpiarTxtPelis();
        }
        //------------------------------------------------------------------------------------
        private void btnGuardarPeli_Click(object sender, EventArgs e)
        {
            try
            {


                Pelicula peli = new Pelicula();
                peli.Id = Convert.ToInt32(txtIdPeli.Text);
                peli.Nombre = Convert.ToString(txtNombrePelicula.Text);
                peli.Duracion = Convert.ToDateTime(dtpDura.Value);
                peli.Genero = Convert.ToInt32(cboGenero.SelectedValue);
                peli.Idioma = Convert.ToInt32(cboIdioma.SelectedValue);
                peli.Clasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
                peli.Subtitulos = Convert.ToInt32(cboSubtitulos.SelectedValue);
                peli.Director = Convert.ToInt32(cboDirector.SelectedValue);
                peli.Pais = Convert.ToInt32(cboPaisP.SelectedValue);




                string agregar = "Insert into Pelicula (    " +
                                                                "id_pelicula," +
                                                               "nombre," +
                                                               "duracion," +
                                                               "id_genero," +
                                                               "id_idioma," +
                                                               "id_clasificacion," +
                                                               "id_subtitulos," +
                                                               "id_director," +
                                                               "id_pais)" +
                                                " values ( " +
                                                                  txtIdPeli.Text + "," +
                                                          " ' " + txtNombrePelicula.Text +
                                                          "','" + dtpDura.Text + "',"
                                                            + cboGenero.SelectedValue + ","
                                                            + cboIdioma.SelectedValue + ","
                                                            + cboClasificacion.SelectedValue + ","
                                                            + cboSubtitulos.SelectedValue + ","
                                                            + cboDirector.SelectedValue + ","
                                                            + cboPaisP.SelectedValue + ")";

                datos.actualizarBD(agregar);




                MessageBox.Show("LA PELICULA SE GUARDO CORRECTAMENTE");

            }
            catch (Exception x)
            {

                MessageBox.Show("ERROR al guardar la pelicula!!  \n " + x.Message);
            }

            datos.putInGrid(dgvPelis, "Select * from Pelicula");
            limpiarTxtPelis();
            bloqueoPelis(false);
        }

        //----------DE DATA GRID A TXT BOX--------------------
        private void dgvPelis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvPelis.Rows[e.RowIndex];
                txtIdPeli.Text = fila.Cells["id_Pelicula"].Value.ToString();
                //SET INT CON ID DE PELICULA---------------------------------------------------- 
                idPeli = Convert.ToInt32(fila.Cells["id_Pelicula"].Value.ToString());
                //----------------------------------------------------
                txtNombrePelicula.Text = fila.Cells["nombre"].Value.ToString();
                dtpDura.Text = fila.Cells["duracion"].Value.ToString();
                cboGenero.SelectedIndex = Convert.ToInt32(fila.Cells["id_genero"].Value.ToString()) - 1;
                cboIdioma.SelectedIndex = Convert.ToInt32(fila.Cells["id_idioma"].Value.ToString()) - 1;
                cboClasificacion.SelectedIndex = Convert.ToInt32(fila.Cells["id_clasificacion"].Value.ToString()) - 1;
                cboSubtitulos.SelectedIndex = Convert.ToInt32(fila.Cells["id_subtitulos"].Value.ToString()) - 1;
                cboDirector.SelectedIndex = Convert.ToInt32(fila.Cells["id_director"].Value.ToString()) - 1;
                cboPaisP.SelectedIndex = Convert.ToInt32(fila.Cells["id_pais"].Value.ToString()) - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show("ALGO PASO AL CLIKEAR PELICULA" + x.Message);


            }
        }
        //------------BOTON PREVIO A LA MODIFICACION------------------
        private void btnModificarPeli_Click(object sender, EventArgs e)
        {


            if (idPeli > 0)
            {
               
                btnBorrarPeli.Enabled = false;
                btnAceptarMod.Visible = true;
                btnGuardarPeli.Enabled = false;
                btnNuevoPeli.Enabled = false;
                dgvPelis.Enabled = false;
                btnModificarPeli.Enabled = false;
                bloqueoPelis(true);
            }
            else
            {
                MessageBox.Show("NINGUNA PELICULA ASIGNADA AL CAMBIO");
            }

        }
        //------------CANCELAR(CAMPOS RESTABLECIDOS)------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnBorrarPeli.Enabled = true;
            btnNuevoPeli.Enabled = true;
            btnModificarPeli.Enabled = true;
            btnGuardarPeli.Enabled = true;
            limpiarTxtPelis();
            bloqueoPelis(false);
            dgvPelis.Enabled = true;
            btnAceptarMod.Visible = false;
        }
        //------------ELIMINAR PELICULA------------------
        private void btnBorrarPeli_Click(object sender, EventArgs e)
        {
            string eliminarP = "Delete pelicula where id_pelicula =" + idPeli;

            datos.actualizarBD(eliminarP);
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
        }

        //-------------ACEPTAR LA MODIFICACION(BOTON FANTASMA :O)-----------------
        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            
            try
            {
                String modificar = "UPDATE Pelicula SET " +
                                                        "nombre ='" + txtNombrePelicula.Text + "'," +
                                                        "duracion='" + dtpDura.Text + "'," +
                                                        "id_genero=" + cboGenero.SelectedValue + "," +
                                                        "id_idioma=" + cboIdioma.SelectedValue + "," +
                                                        "id_clasificacion=" + cboClasificacion.SelectedValue + "," +
                                                        "id_subtitulos=" + cboSubtitulos.SelectedValue + "," +
                                                        "id_director=" + cboDirector.SelectedValue + "," +
                                                        "id_pais=" + cboPaisP.SelectedValue + "  " +
                                                        "WHERE id_pelicula =" + idPeli;
                MessageBox.Show(modificar);


                datos.actualizarBD(modificar);

                MessageBox.Show("La pelicula con el id [" + idPeli + "] HA SIDO ACTUALIZADA CORRECTAMENTE");
                btnAceptarMod.Visible = false;
                bloqueoPelis(false);
                btnNuevoPeli.Enabled = true;
                btnModificarPeli.Enabled = true;
                btnGuardarPeli.Enabled = true;
                btnBorrarPeli.Enabled = true;
                dgvPelis.Enabled = true;


            }
            catch (Exception x)
            {
                MessageBox.Show("La PELICULA NO SE PUDO ACTUALIZAR" + x.Message);

            }
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
        }

        //------------------------------BOTONES ACTORES-----------------------------------------------------
     
        private void btnNuevoAct_Click(object sender, EventArgs e)
        {
            limpiarTxtActores();
            bloqueoActores(true);
        }
        //------------------------------------------------------------------------------------
        private void btnGuardarAct_Click(object sender, EventArgs e)
        {
            try
            {
                Actores ac = new Actores();
                ac.Id = Convert.ToInt32(txtIdActor.Text);
                ac.Nombre = Convert.ToString(txtNombreActor);
                ac.Apellido = Convert.ToString(txtApellidoActor);
                ac.Pais = Convert.ToString(txtNacionalidad.Text);
                ac.FechaN = Convert.ToDateTime(dtpEdad.Value.Date);
                ac.Reseña = Convert.ToString(txtReseña.Text);

                string agregar = "INSERT INTO ACTORES("

                                 + "id_actor,nombre,nacionalidad,fecha_nacimiento,reseña,apellido)"
                                 + "values( "
                                              + txtIdActor.Text + "," +
                                             "'" + txtNombreActor.Text + "','"
                                             + txtNacionalidad.Text + "','"
                                             + dtpEdad.Text + "','"
                                             + txtReseña.Text + "','"
                                             + txtApellidoActor.Text + "')";
                MessageBox.Show(agregar);

                datos.actualizarBD(agregar);


            }
            catch (Exception x)
            {

                MessageBox.Show("Error al cargar actor" + x.Message);
            }
            limpiarTxtActores();
            bloqueoActores(false);
            btnNuevoAct.Enabled = true;
            btnGuardarAct.Enabled = true;
            btnModificarAct.Enabled = true;
            btnBorrarAct.Enabled = true;
            btnModAct.Visible = false;
            dgvActores.Enabled = true;
            datos.putInGrid(dgvActores, "Select * from Actores");
        }
        //---------------------------------------------------------------------------------------------------------
        //NOTA CAMBIAR LA BASE DE DATOS NACIONALIDADES DE STRING A INT O NO ANDA EL GRID 
        private void dgvActores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow fila = this.dgvActores.Rows[e.RowIndex];
                txtIdActor.Text = fila.Cells["id_actor"].Value.ToString();
                idActor = Convert.ToInt32(fila.Cells["id_actor"].Value.ToString());
                txtNombreActor.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidoActor.Text = fila.Cells["apellido"].Value.ToString();
                //cambiado a txt al no poder usar int para buscar en combobox
                txtNacionalidad.Text = fila.Cells["nacionalidad"].Value.ToString();

               // paisActor = fila.Cells["nacionalidad"].Value.ToString();
                txtReseña.Text = fila.Cells["reseña"].Value.ToString();
                dtpEdad.Text = fila.Cells["fecha_nacimiento"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show("ALGO PASO AL SELECCIONAR EL ACTOR" + x.Message);

            }


        }
        //---------------------------------------------------------------------------------------------------------
        private void btnModAct_Click(object sender, EventArgs e)
        {
            try
            {
                String modificarAct = "UPDATE actores SET " +
                                                        "nombre='" + txtNombreActor.Text + "'," +
                                                        "apellido='" + txtApellidoActor.Text + "'," +
                                                        "nacionalidad=" + txtNacionalidad.Text + "," +
                                                        "reseña= '" + txtReseña.Text + "'," +
                                                        "fecha_nacimiento='" + dtpEdad.Text + "'" +
                                                        "WHERE id_actor=" + idActor;

                MessageBox.Show(modificarAct);
                datos.actualizarBD(modificarAct);
                MessageBox.Show("EL ACTOR FUE MODIFICADO CON EXITO");
            }
            catch (Exception x)
            {

                MessageBox.Show("ERROR AL MODIFICAR AL ACTOR " + x.Message);

            }
            datos.putInGrid(dgvActores, "Select * from Actores");
            dgvActores.Enabled = true;
            btnModAct.Visible = false;
            limpiarTxtActores();
            bloqueoActores(false);
            btnNuevoAct.Enabled = true;
            btnGuardarAct.Enabled = true;
            btnModificarAct.Enabled = true;
            btnBorrarAct.Enabled = true;
        }
        //---------------------------------------------------------------------------------------------------------
        private void btnCancelarAct_Click(object sender, EventArgs e)
        {

            limpiarTxtActores();
            bloqueoActores(false);
            btnNuevoAct.Enabled = true;
            btnGuardarAct.Enabled = true;
            btnModificarAct.Enabled = true;
            btnBorrarAct.Enabled = true;
            btnModAct.Visible = false;
            dgvActores.Enabled = true;
        }
        //---------------------------------------------------------------------------------------------------------
        private void pnlPelicula_Paint(object sender, PaintEventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------------------
        private void btnModificarAct_Click(object sender, EventArgs e)
        {

            if (idActor > 0)
            {
                dgvActores.Enabled = false;
                btnGuardarAct.Enabled = false;
                btnNuevoAct.Enabled = false;
                btnBorrarAct.Enabled = false;
                btnModAct.Visible = true;
                bloqueoActores(true);
                txtIdActor.Enabled = false;
                btnModificarAct.Enabled = false;
            }
            else
            {
                MessageBox.Show("NINGUN ACTOR ASIGNADO AL CAMBIO");
            }

        }

        private bool ValidarActor()
        {
            if (txtIdActor.Text == "")
            {
                MessageBox.Show("El id es obligatorio");
                txtIdActor.Focus();
                return false;
            }
            else if (txtNombreActor.Text == "")
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombreActor.Focus();
                return false;
            }
            else if (txtApellidoActor.Text == "")
            {
                MessageBox.Show("El apellido es obligatorio");
                txtApellidoActor.Focus();
                return false;
            }
            else if (txtNacionalidad.Text == "")
            {
                MessageBox.Show("La nacionalidad es obligatoria");
                txtNacionalidad.Focus();
                return false;
            }
            else if (txtReseña.Text == "")
            {
                MessageBox.Show("La reseñ es obligatoria");
                txtReseña.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool ValidarPelicula()
        {
            if (txtIdPeli.Text == "")
            {
                MessageBox.Show("El id es obligatorio");
                txtIdPeli.Focus();
                return false;
            }
            else if (txtNombrePelicula.Text == "")
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombrePelicula.Focus();
                return false;
            }
            else if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un genero");
                cboGenero.Focus();
                return false;
            }
            else if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un idioma");
                cboIdioma.Focus();
                return false;
            }
            else if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un clasificacion");
                cboClasificacion.Focus();
                return false;
            }
            else if (cboSubtitulos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione subtitulos");
                cboSubtitulos.Focus();
                return false;
            }
            else if (cboDirector.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un director");
                cboDirector.Focus();
                return false;
            }
            else if (cboPaisP.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un pais");
                cboPaisP.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}