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
            this.dtpDura = new System.Windows.Forms.DateTimePicker();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.txtIdPeli = new System.Windows.Forms.TextBox();
            this.lblIdPelicula = new System.Windows.Forms.Label();
            this.btnGuardarPelicula = new System.Windows.Forms.Button();
            this.btnEliminarPelicula = new System.Windows.Forms.Button();
            this.btnModificarPelicula = new System.Windows.Forms.Button();
            this.btnNuevoPelicula = new System.Windows.Forms.Button();
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
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblActor = new System.Windows.Forms.Label();
            this.txtIdActor = new System.Windows.Forms.TextBox();
            this.lblIdActores = new System.Windows.Forms.Label();
            this.txtNombreActor = new System.Windows.Forms.TextBox();
            this.lblNombreActor = new System.Windows.Forms.Label();
            this.btnGuardarActor = new System.Windows.Forms.Button();
            this.btnEliminarActor = new System.Windows.Forms.Button();
            this.btnModificarActor = new System.Windows.Forms.Button();
            this.btnNuevoActor = new System.Windows.Forms.Button();
            this.lblReseña = new System.Windows.Forms.Label();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.cboPais = new System.Windows.Forms.ComboBox();
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
            this.txtReseña = new System.Windows.Forms.TextBox();
            this.pnlPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
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
            this.pnlPelicula.Controls.Add(this.dtpDura);
            this.pnlPelicula.Controls.Add(this.dgvPeliculas);
            this.pnlPelicula.Controls.Add(this.txtIdPeli);
            this.pnlPelicula.Controls.Add(this.lblIdPelicula);
            this.pnlPelicula.Controls.Add(this.btnGuardarPelicula);
            this.pnlPelicula.Controls.Add(this.btnEliminarPelicula);
            this.pnlPelicula.Controls.Add(this.btnModificarPelicula);
            this.pnlPelicula.Controls.Add(this.btnNuevoPelicula);
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
            this.pnlPelicula.Location = new System.Drawing.Point(10, 14);
            this.pnlPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(1176, 515);
            this.pnlPelicula.TabIndex = 0;
            // 
            // dtpDura
            // 
            this.dtpDura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDura.Location = new System.Drawing.Point(165, 175);
            this.dtpDura.Name = "dtpDura";
            this.dtpDura.Size = new System.Drawing.Size(100, 26);
            this.dtpDura.TabIndex = 45;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(440, 71);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowTemplate.Height = 28;
            this.dgvPeliculas.Size = new System.Drawing.Size(733, 372);
            this.dgvPeliculas.TabIndex = 44;
            // 
            // txtIdPeli
            // 
            this.txtIdPeli.Location = new System.Drawing.Point(165, 72);
            this.txtIdPeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPeli.Name = "txtIdPeli";
            this.txtIdPeli.Size = new System.Drawing.Size(180, 26);
            this.txtIdPeli.TabIndex = 43;
            // 
            // lblIdPelicula
            // 
            this.lblIdPelicula.AutoSize = true;
            this.lblIdPelicula.Location = new System.Drawing.Point(51, 77);
            this.lblIdPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPelicula.Name = "lblIdPelicula";
            this.lblIdPelicula.Size = new System.Drawing.Size(84, 20);
            this.lblIdPelicula.TabIndex = 42;
            this.lblIdPelicula.Text = "id_Película";
            // 
            // btnGuardarPelicula
            // 
            this.btnGuardarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPelicula.Location = new System.Drawing.Point(644, 451);
            this.btnGuardarPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPelicula.Name = "btnGuardarPelicula";
            this.btnGuardarPelicula.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarPelicula.TabIndex = 41;
            this.btnGuardarPelicula.Text = "Guardar";
            this.btnGuardarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPelicula
            // 
            this.btnEliminarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPelicula.Location = new System.Drawing.Point(950, 451);
            this.btnEliminarPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPelicula.Name = "btnEliminarPelicula";
            this.btnEliminarPelicula.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarPelicula.TabIndex = 39;
            this.btnEliminarPelicula.Text = "Eliminar";
            this.btnEliminarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnModificarPelicula
            // 
            this.btnModificarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPelicula.Location = new System.Drawing.Point(802, 451);
            this.btnModificarPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarPelicula.Name = "btnModificarPelicula";
            this.btnModificarPelicula.Size = new System.Drawing.Size(112, 35);
            this.btnModificarPelicula.TabIndex = 38;
            this.btnModificarPelicula.Text = "Modificar";
            this.btnModificarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPelicula
            // 
            this.btnNuevoPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPelicula.Location = new System.Drawing.Point(494, 451);
            this.btnNuevoPelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoPelicula.Name = "btnNuevoPelicula";
            this.btnNuevoPelicula.Size = new System.Drawing.Size(112, 35);
            this.btnNuevoPelicula.TabIndex = 37;
            this.btnNuevoPelicula.Text = "Nuevo";
            this.btnNuevoPelicula.UseVisualStyleBackColor = true;
            // 
            // cboDirector
            // 
            this.cboDirector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirector.FormattingEnabled = true;
            this.cboDirector.Location = new System.Drawing.Point(165, 423);
            this.cboDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDirector.Name = "cboDirector";
            this.cboDirector.Size = new System.Drawing.Size(180, 28);
            this.cboDirector.TabIndex = 35;
            // 
            // cboSubtitulos
            // 
            this.cboSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSubtitulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubtitulos.FormattingEnabled = true;
            this.cboSubtitulos.Location = new System.Drawing.Point(165, 372);
            this.cboSubtitulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubtitulos.Name = "cboSubtitulos";
            this.cboSubtitulos.Size = new System.Drawing.Size(180, 28);
            this.cboSubtitulos.TabIndex = 34;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(165, 322);
            this.cboClasificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(180, 28);
            this.cboClasificacion.TabIndex = 33;
            // 
            // cboIdioma
            // 
            this.cboIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(165, 271);
            this.cboIdioma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(180, 28);
            this.cboIdioma.TabIndex = 32;
            // 
            // cboGenero
            // 
            this.cboGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(165, 220);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(180, 28);
            this.cboGenero.TabIndex = 31;
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(165, 126);
            this.txtNombrePelicula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(180, 26);
            this.txtNombrePelicula.TabIndex = 28;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(74, 435);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(65, 20);
            this.lblDirector.TabIndex = 27;
            this.lblDirector.Text = "Director";
            // 
            // lblSubtitulos
            // 
            this.lblSubtitulos.AutoSize = true;
            this.lblSubtitulos.Location = new System.Drawing.Point(60, 385);
            this.lblSubtitulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulos.Name = "lblSubtitulos";
            this.lblSubtitulos.Size = new System.Drawing.Size(80, 20);
            this.lblSubtitulos.TabIndex = 26;
            this.lblSubtitulos.Text = "Subtítulos";
            // 
            // lblClasificación
            // 
            this.lblClasificación.AutoSize = true;
            this.lblClasificación.Location = new System.Drawing.Point(40, 334);
            this.lblClasificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasificación.Name = "lblClasificación";
            this.lblClasificación.Size = new System.Drawing.Size(97, 20);
            this.lblClasificación.TabIndex = 25;
            this.lblClasificación.Text = "Clasificacion";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(82, 283);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(57, 20);
            this.lblIdioma.TabIndex = 24;
            this.lblIdioma.Text = "Idioma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Género";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(64, 182);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(73, 20);
            this.lblDuracion.TabIndex = 22;
            this.lblDuracion.Text = "Duración";
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Location = new System.Drawing.Point(74, 131);
            this.lblNombrePelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(65, 20);
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
            this.lblPeliculas.Location = new System.Drawing.Point(524, 3);
            this.lblPeliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeliculas.Name = "lblPeliculas";
            this.lblPeliculas.Size = new System.Drawing.Size(156, 31);
            this.lblPeliculas.TabIndex = 40;
            this.lblPeliculas.Text = "PELÍCULAS";
            // 
            // pnlActores
            // 
            this.pnlActores.Controls.Add(this.txtReseña);
            this.pnlActores.Controls.Add(this.dgvActores);
            this.pnlActores.Controls.Add(this.panel2);
            this.pnlActores.Controls.Add(this.txtIdActor);
            this.pnlActores.Controls.Add(this.lblIdActores);
            this.pnlActores.Controls.Add(this.txtNombreActor);
            this.pnlActores.Controls.Add(this.lblNombreActor);
            this.pnlActores.Controls.Add(this.btnGuardarActor);
            this.pnlActores.Controls.Add(this.btnEliminarActor);
            this.pnlActores.Controls.Add(this.btnModificarActor);
            this.pnlActores.Controls.Add(this.btnNuevoActor);
            this.pnlActores.Controls.Add(this.lblReseña);
            this.pnlActores.Controls.Add(this.dtpEdad);
            this.pnlActores.Controls.Add(this.cboPais);
            this.pnlActores.Controls.Add(this.lblEdad);
            this.pnlActores.Controls.Add(this.lblPais);
            this.pnlActores.Controls.Add(this.txtApellidoActor);
            this.pnlActores.Controls.Add(this.lblApellidoActor);
            this.pnlActores.Location = new System.Drawing.Point(10, 558);
            this.pnlActores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActores.Name = "pnlActores";
            this.pnlActores.Size = new System.Drawing.Size(1176, 543);
            this.pnlActores.TabIndex = 1;
            // 
            // dgvActores
            // 
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(419, 82);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.RowTemplate.Height = 28;
            this.dgvActores.Size = new System.Drawing.Size(733, 372);
            this.dgvActores.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblActor);
            this.panel2.Location = new System.Drawing.Point(0, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 40);
            this.panel2.TabIndex = 45;
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActor.Location = new System.Drawing.Point(524, 3);
            this.lblActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(137, 31);
            this.lblActor.TabIndex = 41;
            this.lblActor.Text = "ACTORES";
            // 
            // txtIdActor
            // 
            this.txtIdActor.Location = new System.Drawing.Point(164, 82);
            this.txtIdActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdActor.Name = "txtIdActor";
            this.txtIdActor.Size = new System.Drawing.Size(180, 26);
            this.txtIdActor.TabIndex = 55;
            // 
            // lblIdActores
            // 
            this.lblIdActores.AutoSize = true;
            this.lblIdActores.Location = new System.Drawing.Point(72, 86);
            this.lblIdActores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdActores.Name = "lblIdActores";
            this.lblIdActores.Size = new System.Drawing.Size(68, 20);
            this.lblIdActores.TabIndex = 54;
            this.lblIdActores.Text = "id_Actor";
            // 
            // txtNombreActor
            // 
            this.txtNombreActor.Location = new System.Drawing.Point(165, 138);
            this.txtNombreActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreActor.Name = "txtNombreActor";
            this.txtNombreActor.Size = new System.Drawing.Size(180, 26);
            this.txtNombreActor.TabIndex = 53;
            // 
            // lblNombreActor
            // 
            this.lblNombreActor.AutoSize = true;
            this.lblNombreActor.Location = new System.Drawing.Point(74, 143);
            this.lblNombreActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreActor.Name = "lblNombreActor";
            this.lblNombreActor.Size = new System.Drawing.Size(65, 20);
            this.lblNombreActor.TabIndex = 52;
            this.lblNombreActor.Text = "Nombre";
            // 
            // btnGuardarActor
            // 
            this.btnGuardarActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarActor.Location = new System.Drawing.Point(644, 471);
            this.btnGuardarActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarActor.Name = "btnGuardarActor";
            this.btnGuardarActor.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarActor.TabIndex = 45;
            this.btnGuardarActor.Text = "Guardar";
            this.btnGuardarActor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarActor
            // 
            this.btnEliminarActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarActor.Location = new System.Drawing.Point(950, 471);
            this.btnEliminarActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarActor.Name = "btnEliminarActor";
            this.btnEliminarActor.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarActor.TabIndex = 44;
            this.btnEliminarActor.Text = "Eliminar";
            this.btnEliminarActor.UseVisualStyleBackColor = true;
            // 
            // btnModificarActor
            // 
            this.btnModificarActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarActor.Location = new System.Drawing.Point(802, 471);
            this.btnModificarActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarActor.Name = "btnModificarActor";
            this.btnModificarActor.Size = new System.Drawing.Size(112, 35);
            this.btnModificarActor.TabIndex = 43;
            this.btnModificarActor.Text = "Modificar";
            this.btnModificarActor.UseVisualStyleBackColor = true;
            // 
            // btnNuevoActor
            // 
            this.btnNuevoActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoActor.Location = new System.Drawing.Point(494, 471);
            this.btnNuevoActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoActor.Name = "btnNuevoActor";
            this.btnNuevoActor.Size = new System.Drawing.Size(112, 35);
            this.btnNuevoActor.TabIndex = 42;
            this.btnNuevoActor.Text = "Nuevo";
            this.btnNuevoActor.UseVisualStyleBackColor = true;
            // 
            // lblReseña
            // 
            this.lblReseña.AutoSize = true;
            this.lblReseña.Location = new System.Drawing.Point(76, 374);
            this.lblReseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReseña.Name = "lblReseña";
            this.lblReseña.Size = new System.Drawing.Size(65, 20);
            this.lblReseña.TabIndex = 50;
            this.lblReseña.Text = "Reseña";
            // 
            // dtpEdad
            // 
            this.dtpEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEdad.Location = new System.Drawing.Point(165, 312);
            this.dtpEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(180, 26);
            this.dtpEdad.TabIndex = 48;
            // 
            // cboPais
            // 
            this.cboPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(165, 257);
            this.cboPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(180, 28);
            this.cboPais.TabIndex = 47;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(94, 322);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 45;
            this.lblEdad.Text = "Edad";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(99, 262);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 20);
            this.lblPais.TabIndex = 44;
            this.lblPais.Text = "País";
            // 
            // txtApellidoActor
            // 
            this.txtApellidoActor.Location = new System.Drawing.Point(164, 202);
            this.txtApellidoActor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoActor.Name = "txtApellidoActor";
            this.txtApellidoActor.Size = new System.Drawing.Size(180, 26);
            this.txtApellidoActor.TabIndex = 43;
            // 
            // lblApellidoActor
            // 
            this.lblApellidoActor.AutoSize = true;
            this.lblApellidoActor.Location = new System.Drawing.Point(72, 206);
            this.lblApellidoActor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoActor.Name = "lblApellidoActor";
            this.lblApellidoActor.Size = new System.Drawing.Size(65, 20);
            this.lblApellidoActor.TabIndex = 42;
            this.lblApellidoActor.Text = "Apellido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.lblPeliculas);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 40);
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
            // txtReseña
            // 
            this.txtReseña.Location = new System.Drawing.Point(164, 374);
            this.txtReseña.Multiline = true;
            this.txtReseña.Name = "txtReseña";
            this.txtReseña.Size = new System.Drawing.Size(181, 80);
            this.txtReseña.TabIndex = 56;
            // 
            // FrmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlActores);
            this.Controls.Add(this.pnlPelicula);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.FrmABM_Load);
            this.pnlPelicula.ResumeLayout(false);
            this.pnlPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
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
        private System.Windows.Forms.Button btnEliminarPelicula;
        private System.Windows.Forms.Button btnModificarPelicula;
        private System.Windows.Forms.Button btnNuevoPelicula;
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
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtApellidoActor;
        private System.Windows.Forms.Label lblApellidoActor;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Button btnGuardarPelicula;
        private System.Windows.Forms.Button btnGuardarActor;
        private System.Windows.Forms.Button btnEliminarActor;
        private System.Windows.Forms.Button btnModificarActor;
        private System.Windows.Forms.Button btnNuevoActor;
        private System.Windows.Forms.TextBox txtIdActor;
        private System.Windows.Forms.Label lblIdActores;
        private System.Windows.Forms.TextBox txtNombreActor;
        private System.Windows.Forms.Label lblNombreActor;
        private System.Windows.Forms.TextBox txtIdPeli;
        private System.Windows.Forms.Label lblIdPelicula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridView dgvActores;
        private CineMioDataSet cineMioDataSet;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private CineMioDataSetTableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private System.Windows.Forms.BindingSource actoresBindingSource;
        private CineMioDataSetTableAdapters.ActoresTableAdapter actoresTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDura;
        private System.Windows.Forms.TextBox txtReseña;
    }
}