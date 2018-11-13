namespace PracticoIntegrador2018
{
    partial class FrmABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.dgvPelis = new System.Windows.Forms.DataGridView();
            this.cboPaisP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDura = new System.Windows.Forms.DateTimePicker();
            this.txtIdPeli = new System.Windows.Forms.TextBox();
            this.lblIdPelicula = new System.Windows.Forms.Label();
            this.cboDirector = new System.Windows.Forms.ComboBox();
            this.cboSubtitulos = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblSubtitulos = new System.Windows.Forms.Label();
            this.lblClasificación = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
            this.lblPeliculas = new System.Windows.Forms.Label();
            this.pnlActores = new System.Windows.Forms.Panel();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtReseña = new System.Windows.Forms.TextBox();
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblActor = new System.Windows.Forms.Label();
            this.txtIdActor = new System.Windows.Forms.TextBox();
            this.lblIdActores = new System.Windows.Forms.Label();
            this.txtNombreActor = new System.Windows.Forms.TextBox();
            this.lblNombreActor = new System.Windows.Forms.Label();
            this.lblReseña = new System.Windows.Forms.Label();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtApellidoActor = new System.Windows.Forms.TextBox();
            this.lblApellidoActor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cineMioDataSet = new PracticoIntegrador2018.CineMioDataSet();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculaTableAdapter = new PracticoIntegrador2018.CineMioDataSetTableAdapters.PeliculaTableAdapter();
            this.actoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actoresTableAdapter = new PracticoIntegrador2018.CineMioDataSetTableAdapters.ActoresTableAdapter();
            this.btnNuevoPeli = new System.Windows.Forms.Button();
            this.btnGuardarPeli = new System.Windows.Forms.Button();
            this.btnModificarPeli = new System.Windows.Forms.Button();
            this.btnBorrarPeli = new System.Windows.Forms.Button();
            this.btnBorrarAct = new System.Windows.Forms.Button();
            this.btnModificarAct = new System.Windows.Forms.Button();
            this.btnGuardarAct = new System.Windows.Forms.Button();
            this.btnNuevoAct = new System.Windows.Forms.Button();
            this.btnCancelarPeli = new System.Windows.Forms.Button();
            this.btnAceptarMod = new System.Windows.Forms.Button();
            this.btnModAct = new System.Windows.Forms.Button();
            this.btnCancelarAct = new System.Windows.Forms.Button();
            this.pnlPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).BeginInit();
            this.pnlActores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cineMioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.Controls.Add(this.dgvPelis);
            this.pnlPelicula.Controls.Add(this.cboPaisP);
            this.pnlPelicula.Controls.Add(this.label1);
            this.pnlPelicula.Controls.Add(this.dtpDura);
            this.pnlPelicula.Controls.Add(this.txtIdPeli);
            this.pnlPelicula.Controls.Add(this.lblIdPelicula);
            this.pnlPelicula.Controls.Add(this.cboDirector);
            this.pnlPelicula.Controls.Add(this.cboSubtitulos);
            this.pnlPelicula.Controls.Add(this.cboClasificacion);
            this.pnlPelicula.Controls.Add(this.cboIdioma);
            this.pnlPelicula.Controls.Add(this.cboGenero);
            this.pnlPelicula.Controls.Add(this.txtNombrePelicula);
            this.pnlPelicula.Controls.Add(this.lblDirector);
            this.pnlPelicula.Controls.Add(this.lblSubtitulos);
            this.pnlPelicula.Controls.Add(this.lblClasificación);
            this.pnlPelicula.Controls.Add(this.lblIdioma);
            this.pnlPelicula.Controls.Add(this.label3);
            this.pnlPelicula.Controls.Add(this.lblDuracion);
            this.pnlPelicula.Controls.Add(this.lblNombrePelicula);
            this.pnlPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPelicula.Location = new System.Drawing.Point(7, 9);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(1277, 274);
            this.pnlPelicula.TabIndex = 0;
            this.pnlPelicula.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPelicula_Paint);
            // 
            // dgvPelis
            // 
            this.dgvPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelis.Location = new System.Drawing.Point(301, 50);
            this.dgvPelis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPelis.Name = "dgvPelis";
            this.dgvPelis.RowTemplate.Height = 28;
            this.dgvPelis.Size = new System.Drawing.Size(973, 204);
            this.dgvPelis.TabIndex = 48;
            this.dgvPelis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPelis_CellContentClick);
            // 
            // cboPaisP
            // 
            this.cboPaisP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPaisP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaisP.FormattingEnabled = true;
            this.cboPaisP.Location = new System.Drawing.Point(109, 252);
            this.cboPaisP.Name = "cboPaisP";
            this.cboPaisP.Size = new System.Drawing.Size(121, 21);
            this.cboPaisP.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pais";
            // 
            // dtpDura
            // 
            this.dtpDura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDura.Location = new System.Drawing.Point(110, 94);
            this.dtpDura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDura.Name = "dtpDura";
            this.dtpDura.Size = new System.Drawing.Size(101, 20);
            this.dtpDura.TabIndex = 45;
            // 
            // txtIdPeli
            // 
            this.txtIdPeli.Location = new System.Drawing.Point(110, 47);
            this.txtIdPeli.Name = "txtIdPeli";
            this.txtIdPeli.Size = new System.Drawing.Size(121, 20);
            this.txtIdPeli.TabIndex = 43;
            // 
            // lblIdPelicula
            // 
            this.lblIdPelicula.AutoSize = true;
            this.lblIdPelicula.Location = new System.Drawing.Point(34, 50);
            this.lblIdPelicula.Name = "lblIdPelicula";
            this.lblIdPelicula.Size = new System.Drawing.Size(60, 13);
            this.lblIdPelicula.TabIndex = 42;
            this.lblIdPelicula.Text = "id_Película";
            // 
            // cboDirector
            // 
            this.cboDirector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirector.FormattingEnabled = true;
            this.cboDirector.Location = new System.Drawing.Point(110, 226);
            this.cboDirector.Name = "cboDirector";
            this.cboDirector.Size = new System.Drawing.Size(121, 21);
            this.cboDirector.TabIndex = 35;
            // 
            // cboSubtitulos
            // 
            this.cboSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSubtitulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubtitulos.FormattingEnabled = true;
            this.cboSubtitulos.Location = new System.Drawing.Point(109, 199);
            this.cboSubtitulos.Name = "cboSubtitulos";
            this.cboSubtitulos.Size = new System.Drawing.Size(121, 21);
            this.cboSubtitulos.TabIndex = 34;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(110, 169);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cboClasificacion.TabIndex = 33;
            // 
            // cboIdioma
            // 
            this.cboIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(110, 144);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(121, 21);
            this.cboIdioma.TabIndex = 32;
            // 
            // cboGenero
            // 
            this.cboGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(110, 119);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 31;
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(110, 72);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePelicula.TabIndex = 28;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(47, 231);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 27;
            this.lblDirector.Text = "Director";
            // 
            // lblSubtitulos
            // 
            this.lblSubtitulos.AutoSize = true;
            this.lblSubtitulos.Location = new System.Drawing.Point(37, 201);
            this.lblSubtitulos.Name = "lblSubtitulos";
            this.lblSubtitulos.Size = new System.Drawing.Size(55, 13);
            this.lblSubtitulos.TabIndex = 26;
            this.lblSubtitulos.Text = "Subtítulos";
            // 
            // lblClasificación
            // 
            this.lblClasificación.AutoSize = true;
            this.lblClasificación.Location = new System.Drawing.Point(25, 170);
            this.lblClasificación.Name = "lblClasificación";
            this.lblClasificación.Size = new System.Drawing.Size(66, 13);
            this.lblClasificación.TabIndex = 25;
            this.lblClasificación.Text = "Clasificacion";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(52, 145);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 24;
            this.lblIdioma.Text = "Idioma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Género";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(41, 98);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 22;
            this.lblDuracion.Text = "Duración";
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Location = new System.Drawing.Point(47, 74);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePelicula.TabIndex = 21;
            this.lblNombrePelicula.Text = "Nombre";
            // 
            // lblPeliculas
            // 
            this.lblPeliculas.AutoSize = true;
            this.lblPeliculas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPeliculas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculas.Location = new System.Drawing.Point(571, 3);
            this.lblPeliculas.Name = "lblPeliculas";
            this.lblPeliculas.Size = new System.Drawing.Size(109, 22);
            this.lblPeliculas.TabIndex = 40;
            this.lblPeliculas.Text = "PELÍCULAS";
            // 
            // pnlActores
            // 
            this.pnlActores.Controls.Add(this.txtNacionalidad);
            this.pnlActores.Controls.Add(this.txtReseña);
            this.pnlActores.Controls.Add(this.dgvActores);
            this.pnlActores.Controls.Add(this.panel2);
            this.pnlActores.Controls.Add(this.txtIdActor);
            this.pnlActores.Controls.Add(this.lblIdActores);
            this.pnlActores.Controls.Add(this.txtNombreActor);
            this.pnlActores.Controls.Add(this.lblNombreActor);
            this.pnlActores.Controls.Add(this.lblReseña);
            this.pnlActores.Controls.Add(this.dtpEdad);
            this.pnlActores.Controls.Add(this.lblEdad);
            this.pnlActores.Controls.Add(this.lblPais);
            this.pnlActores.Controls.Add(this.txtApellidoActor);
            this.pnlActores.Controls.Add(this.lblApellidoActor);
            this.pnlActores.Location = new System.Drawing.Point(7, 328);
            this.pnlActores.Name = "pnlActores";
            this.pnlActores.Size = new System.Drawing.Size(1026, 248);
            this.pnlActores.TabIndex = 1;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(109, 127);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(121, 20);
            this.txtNacionalidad.TabIndex = 57;
            // 
            // txtReseña
            // 
            this.txtReseña.Location = new System.Drawing.Point(110, 183);
            this.txtReseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReseña.Multiline = true;
            this.txtReseña.Name = "txtReseña";
            this.txtReseña.Size = new System.Drawing.Size(122, 53);
            this.txtReseña.TabIndex = 56;
            // 
            // dgvActores
            // 
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(279, 53);
            this.dgvActores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.RowTemplate.Height = 28;
            this.dgvActores.Size = new System.Drawing.Size(745, 182);
            this.dgvActores.TabIndex = 45;
            this.dgvActores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActores_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblActor);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 26);
            this.panel2.TabIndex = 45;
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActor.Location = new System.Drawing.Point(349, 2);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(94, 22);
            this.lblActor.TabIndex = 41;
            this.lblActor.Text = "ACTORES";
            // 
            // txtIdActor
            // 
            this.txtIdActor.Location = new System.Drawing.Point(109, 53);
            this.txtIdActor.Name = "txtIdActor";
            this.txtIdActor.Size = new System.Drawing.Size(121, 20);
            this.txtIdActor.TabIndex = 55;
            // 
            // lblIdActores
            // 
            this.lblIdActores.AutoSize = true;
            this.lblIdActores.Location = new System.Drawing.Point(48, 56);
            this.lblIdActores.Name = "lblIdActores";
            this.lblIdActores.Size = new System.Drawing.Size(46, 13);
            this.lblIdActores.TabIndex = 54;
            this.lblIdActores.Text = "id_Actor";
            // 
            // txtNombreActor
            // 
            this.txtNombreActor.Location = new System.Drawing.Point(110, 77);
            this.txtNombreActor.Name = "txtNombreActor";
            this.txtNombreActor.Size = new System.Drawing.Size(121, 20);
            this.txtNombreActor.TabIndex = 53;
            // 
            // lblNombreActor
            // 
            this.lblNombreActor.AutoSize = true;
            this.lblNombreActor.Location = new System.Drawing.Point(49, 80);
            this.lblNombreActor.Name = "lblNombreActor";
            this.lblNombreActor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreActor.TabIndex = 52;
            this.lblNombreActor.Text = "Nombre";
            // 
            // lblReseña
            // 
            this.lblReseña.AutoSize = true;
            this.lblReseña.Location = new System.Drawing.Point(50, 183);
            this.lblReseña.Name = "lblReseña";
            this.lblReseña.Size = new System.Drawing.Size(44, 13);
            this.lblReseña.TabIndex = 50;
            this.lblReseña.Text = "Reseña";
            // 
            // dtpEdad
            // 
            this.dtpEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEdad.Location = new System.Drawing.Point(110, 148);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(121, 20);
            this.dtpEdad.TabIndex = 48;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(59, 152);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 45;
            this.lblEdad.Text = "Edad";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(66, 127);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 44;
            this.lblPais.Text = "País";
            // 
            // txtApellidoActor
            // 
            this.txtApellidoActor.Location = new System.Drawing.Point(110, 100);
            this.txtApellidoActor.Name = "txtApellidoActor";
            this.txtApellidoActor.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoActor.TabIndex = 43;
            // 
            // lblApellidoActor
            // 
            this.lblApellidoActor.AutoSize = true;
            this.lblApellidoActor.Location = new System.Drawing.Point(49, 103);
            this.lblApellidoActor.Name = "lblApellidoActor";
            this.lblApellidoActor.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoActor.TabIndex = 42;
            this.lblApellidoActor.Text = "Apellido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.lblPeliculas);
            this.panel1.Location = new System.Drawing.Point(7, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 26);
            this.panel1.TabIndex = 44;
            // 
            // cineMioDataSet
            // 
            this.cineMioDataSet.DataSetName = "CineMioDataSet";
            this.cineMioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataMember = "Pelicula";
            this.peliculaBindingSource.DataSource = this.cineMioDataSet;
            // 
            // peliculaTableAdapter
            // 
            this.peliculaTableAdapter.ClearBeforeFill = true;
            // 
            // actoresBindingSource
            // 
            this.actoresBindingSource.DataMember = "Actores";
            this.actoresBindingSource.DataSource = this.cineMioDataSet;
            // 
            // actoresTableAdapter
            // 
            this.actoresTableAdapter.ClearBeforeFill = true;
            // 
            // btnNuevoPeli
            // 
            this.btnNuevoPeli.Location = new System.Drawing.Point(300, 296);
            this.btnNuevoPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoPeli.Name = "btnNuevoPeli";
            this.btnNuevoPeli.Size = new System.Drawing.Size(65, 27);
            this.btnNuevoPeli.TabIndex = 45;
            this.btnNuevoPeli.Text = "Nuevo";
            this.btnNuevoPeli.UseVisualStyleBackColor = true;
            this.btnNuevoPeli.Click += new System.EventHandler(this.btnNuevoPeli_Click);
            // 
            // btnGuardarPeli
            // 
            this.btnGuardarPeli.Location = new System.Drawing.Point(369, 296);
            this.btnGuardarPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarPeli.Name = "btnGuardarPeli";
            this.btnGuardarPeli.Size = new System.Drawing.Size(65, 27);
            this.btnGuardarPeli.TabIndex = 46;
            this.btnGuardarPeli.Text = "Guardar";
            this.btnGuardarPeli.UseVisualStyleBackColor = true;
            this.btnGuardarPeli.Click += new System.EventHandler(this.btnGuardarPeli_Click);
            // 
            // btnModificarPeli
            // 
            this.btnModificarPeli.Location = new System.Drawing.Point(439, 296);
            this.btnModificarPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarPeli.Name = "btnModificarPeli";
            this.btnModificarPeli.Size = new System.Drawing.Size(65, 27);
            this.btnModificarPeli.TabIndex = 47;
            this.btnModificarPeli.Text = "Modificar";
            this.btnModificarPeli.UseVisualStyleBackColor = true;
            this.btnModificarPeli.Click += new System.EventHandler(this.btnModificarPeli_Click);
            // 
            // btnBorrarPeli
            // 
            this.btnBorrarPeli.Location = new System.Drawing.Point(508, 296);
            this.btnBorrarPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarPeli.Name = "btnBorrarPeli";
            this.btnBorrarPeli.Size = new System.Drawing.Size(65, 27);
            this.btnBorrarPeli.TabIndex = 48;
            this.btnBorrarPeli.Text = "Borrar";
            this.btnBorrarPeli.UseVisualStyleBackColor = true;
            this.btnBorrarPeli.Click += new System.EventHandler(this.btnBorrarPeli_Click);
            // 
            // btnBorrarAct
            // 
            this.btnBorrarAct.Location = new System.Drawing.Point(516, 580);
            this.btnBorrarAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarAct.Name = "btnBorrarAct";
            this.btnBorrarAct.Size = new System.Drawing.Size(65, 27);
            this.btnBorrarAct.TabIndex = 52;
            this.btnBorrarAct.Text = "Borrar";
            this.btnBorrarAct.UseVisualStyleBackColor = true;
            // 
            // btnModificarAct
            // 
            this.btnModificarAct.Location = new System.Drawing.Point(447, 580);
            this.btnModificarAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarAct.Name = "btnModificarAct";
            this.btnModificarAct.Size = new System.Drawing.Size(65, 27);
            this.btnModificarAct.TabIndex = 51;
            this.btnModificarAct.Text = "Modificar";
            this.btnModificarAct.UseVisualStyleBackColor = true;
            this.btnModificarAct.Click += new System.EventHandler(this.btnModificarAct_Click);
            // 
            // btnGuardarAct
            // 
            this.btnGuardarAct.Location = new System.Drawing.Point(377, 580);
            this.btnGuardarAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarAct.Name = "btnGuardarAct";
            this.btnGuardarAct.Size = new System.Drawing.Size(65, 27);
            this.btnGuardarAct.TabIndex = 50;
            this.btnGuardarAct.Text = "Guardar";
            this.btnGuardarAct.UseVisualStyleBackColor = true;
            this.btnGuardarAct.Click += new System.EventHandler(this.btnGuardarAct_Click);
            // 
            // btnNuevoAct
            // 
            this.btnNuevoAct.Location = new System.Drawing.Point(308, 580);
            this.btnNuevoAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoAct.Name = "btnNuevoAct";
            this.btnNuevoAct.Size = new System.Drawing.Size(65, 27);
            this.btnNuevoAct.TabIndex = 49;
            this.btnNuevoAct.Text = "Nuevo";
            this.btnNuevoAct.UseVisualStyleBackColor = true;
            this.btnNuevoAct.Click += new System.EventHandler(this.btnNuevoAct_Click);
            // 
            // btnCancelarPeli
            // 
            this.btnCancelarPeli.Location = new System.Drawing.Point(577, 296);
            this.btnCancelarPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarPeli.Name = "btnCancelarPeli";
            this.btnCancelarPeli.Size = new System.Drawing.Size(65, 27);
            this.btnCancelarPeli.TabIndex = 53;
            this.btnCancelarPeli.Text = "Cancelar";
            this.btnCancelarPeli.UseVisualStyleBackColor = true;
            this.btnCancelarPeli.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarMod
            // 
            this.btnAceptarMod.Location = new System.Drawing.Point(8, 288);
            this.btnAceptarMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarMod.Name = "btnAceptarMod";
            this.btnAceptarMod.Size = new System.Drawing.Size(125, 27);
            this.btnAceptarMod.TabIndex = 54;
            this.btnAceptarMod.Text = "Aceptar Modificacion";
            this.btnAceptarMod.UseVisualStyleBackColor = true;
            this.btnAceptarMod.Click += new System.EventHandler(this.btnAceptarMod_Click);
            // 
            // btnModAct
            // 
            this.btnModAct.Location = new System.Drawing.Point(35, 581);
            this.btnModAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModAct.Name = "btnModAct";
            this.btnModAct.Size = new System.Drawing.Size(143, 26);
            this.btnModAct.TabIndex = 55;
            this.btnModAct.Text = "Aceptar Modificacion";
            this.btnModAct.UseVisualStyleBackColor = true;
            this.btnModAct.Click += new System.EventHandler(this.btnModAct_Click);
            // 
            // btnCancelarAct
            // 
            this.btnCancelarAct.Location = new System.Drawing.Point(585, 580);
            this.btnCancelarAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarAct.Name = "btnCancelarAct";
            this.btnCancelarAct.Size = new System.Drawing.Size(65, 27);
            this.btnCancelarAct.TabIndex = 56;
            this.btnCancelarAct.Text = "Cancelar";
            this.btnCancelarAct.UseVisualStyleBackColor = true;
            this.btnCancelarAct.Click += new System.EventHandler(this.btnCancelarAct_Click);
            // 
            // FrmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 610);
            this.Controls.Add(this.btnCancelarAct);
            this.Controls.Add(this.btnModAct);
            this.Controls.Add(this.btnAceptarMod);
            this.Controls.Add(this.btnCancelarPeli);
            this.Controls.Add(this.btnBorrarAct);
            this.Controls.Add(this.btnModificarAct);
            this.Controls.Add(this.btnGuardarAct);
            this.Controls.Add(this.btnNuevoAct);
            this.Controls.Add(this.btnBorrarPeli);
            this.Controls.Add(this.btnModificarPeli);
            this.Controls.Add(this.btnGuardarPeli);
            this.Controls.Add(this.btnNuevoPeli);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlActores);
            this.Controls.Add(this.pnlPelicula);
            this.Name = "FrmABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.FrmABM_Load);
            this.pnlPelicula.ResumeLayout(false);
            this.pnlPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).EndInit();
            this.pnlActores.ResumeLayout(false);
            this.pnlActores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cineMioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPelicula;
        private System.Windows.Forms.Label lblPeliculas;
        private System.Windows.Forms.ComboBox cboDirector;
        private System.Windows.Forms.ComboBox cboSubtitulos;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblSubtitulos;
        private System.Windows.Forms.Label lblClasificación;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblNombrePelicula;
        private System.Windows.Forms.Panel pnlActores;
        private System.Windows.Forms.Label lblReseña;
        private System.Windows.Forms.DateTimePicker dtpEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtApellidoActor;
        private System.Windows.Forms.Label lblApellidoActor;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.TextBox txtIdActor;
        private System.Windows.Forms.Label lblIdActores;
        private System.Windows.Forms.TextBox txtNombreActor;
        private System.Windows.Forms.Label lblNombreActor;
        private System.Windows.Forms.TextBox txtIdPeli;
        private System.Windows.Forms.Label lblIdPelicula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvActores;
        private CineMioDataSet cineMioDataSet;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private CineMioDataSetTableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private System.Windows.Forms.BindingSource actoresBindingSource;
        private CineMioDataSetTableAdapters.ActoresTableAdapter actoresTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDura;
        private System.Windows.Forms.TextBox txtReseña;
        private System.Windows.Forms.Button btnNuevoPeli;
        private System.Windows.Forms.Button btnGuardarPeli;
        private System.Windows.Forms.Button btnModificarPeli;
        private System.Windows.Forms.Button btnBorrarPeli;
        private System.Windows.Forms.ComboBox cboPaisP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarAct;
        private System.Windows.Forms.Button btnModificarAct;
        private System.Windows.Forms.Button btnGuardarAct;
        private System.Windows.Forms.Button btnNuevoAct;
        private System.Windows.Forms.DataGridView dgvPelis;
        private System.Windows.Forms.Button btnCancelarPeli;
        private System.Windows.Forms.Button btnAceptarMod;
        private System.Windows.Forms.Button btnModAct;
        private System.Windows.Forms.Button btnCancelarAct;
        private System.Windows.Forms.TextBox txtNacionalidad;
    }
}