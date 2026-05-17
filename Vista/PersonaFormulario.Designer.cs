namespace Examen.Vista;

partial class PersonaFormulario
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitulo;
    private Label lblNombre;
    private TextBox txtNombre;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnCrear;
    private Button btnVer;
    private Button btnActualizar;
    private TextBox txtApellidoPaterno;
    private TextBox txtApellidoMaterno;
    private Label lblApellidoPaterno;
    private Label lblApellidoMaterno;
    private DataGridView dgvPersonas;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colApellidoPaterno;
    private DataGridViewTextBoxColumn colApellidoMaterno;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblNombre = new Label();
        txtNombre = new TextBox();
        btnGuardar = new Button();
        btnEliminar = new Button();
        btnCrear = new Button();
        btnVer = new Button();
        btnActualizar = new Button();
        txtApellidoPaterno = new TextBox();
        txtApellidoMaterno = new TextBox();
        lblApellidoPaterno = new Label();
        lblApellidoMaterno = new Label();
        dgvPersonas = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colApellidoPaterno = new DataGridViewTextBoxColumn();
        colApellidoMaterno = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.Location = new Point(27, 29);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(254, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registro de personas";
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(32, 76);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(64, 20);
        lblNombre.TabIndex = 1;
        lblNombre.Text = "Nombre";
        // 
        // txtNombre
        // 
        txtNombre.BackColor = Color.LightGreen;
        txtNombre.Location = new Point(32, 100);
        txtNombre.Margin = new Padding(3, 4, 3, 4);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(319, 27);
        txtNombre.TabIndex = 2;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.Turquoise;
        btnGuardar.Location = new Point(374, 103);
        btnGuardar.Margin = new Padding(3, 4, 3, 4);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(114, 33);
        btnGuardar.TabIndex = 3;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = Color.Red;
        btnEliminar.Location = new Point(375, 265);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(113, 29);
        btnEliminar.TabIndex = 4;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnCrear
        // 
        btnCrear.BackColor = Color.Turquoise;
        btnCrear.Location = new Point(374, 67);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new Size(113, 29);
        btnCrear.TabIndex = 5;
        btnCrear.Text = "Crear";
        btnCrear.UseVisualStyleBackColor = false;
        btnCrear.Click += btnCrear_Click;
        // 
        // btnVer
        // 
        btnVer.BackColor = Color.Turquoise;
        btnVer.Location = new Point(373, 156);
        btnVer.Name = "btnVer";
        btnVer.Size = new Size(113, 29);
        btnVer.TabIndex = 6;
        btnVer.Text = "Ver";
        btnVer.UseVisualStyleBackColor = false;
        btnVer.Click += btnVer_Click;
        // 
        // btnActualizar
        // 
        btnActualizar.BackColor = Color.Aqua;
        btnActualizar.Location = new Point(375, 214);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(113, 29);
        btnActualizar.TabIndex = 7;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = false;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // txtApellidoPaterno
        // 
        txtApellidoPaterno.BackColor = Color.LightGreen;
        txtApellidoPaterno.Location = new Point(32, 156);
        txtApellidoPaterno.Name = "txtApellidoPaterno";
        txtApellidoPaterno.Size = new Size(319, 27);
        txtApellidoPaterno.TabIndex = 8;
        // 
        // txtApellidoMaterno
        // 
        txtApellidoMaterno.BackColor = Color.LightGreen;
        txtApellidoMaterno.Location = new Point(32, 214);
        txtApellidoMaterno.Name = "txtApellidoMaterno";
        txtApellidoMaterno.Size = new Size(319, 27);
        txtApellidoMaterno.TabIndex = 9;
        // 
        // lblApellidoPaterno
        // 
        lblApellidoPaterno.AutoSize = true;
        lblApellidoPaterno.Location = new Point(32, 131);
        lblApellidoPaterno.Name = "lblApellidoPaterno";
        lblApellidoPaterno.Size = new Size(120, 20);
        lblApellidoPaterno.TabIndex = 10;
        lblApellidoPaterno.Text = "Apellido Paterno";
        // 
        // lblApellidoMaterno
        // 
        lblApellidoMaterno.AutoSize = true;
        lblApellidoMaterno.Location = new Point(38, 192);
        lblApellidoMaterno.Name = "lblApellidoMaterno";
        lblApellidoMaterno.Size = new Size(126, 20);
        lblApellidoMaterno.TabIndex = 11;
        lblApellidoMaterno.Text = "Apellido Materno";
        // 
        // dgvPersonas
        // 
        dgvPersonas.AllowUserToAddRows = false;
        dgvPersonas.AllowUserToDeleteRows = false;
        dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPersonas.BackgroundColor = Color.Aquamarine;
        dgvPersonas.BorderStyle = BorderStyle.Fixed3D;
        dgvPersonas.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellidoPaterno, colApellidoMaterno });
        dgvPersonas.GridColor = SystemColors.HotTrack;
        dgvPersonas.Location = new Point(32, 300);
        dgvPersonas.MultiSelect = false;
        dgvPersonas.Name = "dgvPersonas";
        dgvPersonas.ReadOnly = true;
        dgvPersonas.RowHeadersWidth = 51;
        dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPersonas.Size = new Size(454, 244);
        dgvPersonas.TabIndex = 12;
        dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
        dgvPersonas.SelectionChanged += dgvPersonas_SelectionChanged;
        // 
        // colId
        // 
        colId.HeaderText = "Id";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colNombre
        // 
        colNombre.HeaderText = "Nombre";
        colNombre.MinimumWidth = 6;
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;
        // 
        // colApellidoPaterno
        // 
        colApellidoPaterno.HeaderText = "Apellido Paterno";
        colApellidoPaterno.MinimumWidth = 6;
        colApellidoPaterno.Name = "colApellidoPaterno";
        colApellidoPaterno.ReadOnly = true;
        // 
        // colApellidoMaterno
        // 
        colApellidoMaterno.HeaderText = "Apellido Materno";
        colApellidoMaterno.MinimumWidth = 6;
        colApellidoMaterno.Name = "colApellidoMaterno";
        colApellidoMaterno.ReadOnly = true;
        // 
        // PersonaFormulario
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(519, 566);
        Controls.Add(dgvPersonas);
        Controls.Add(lblApellidoMaterno);
        Controls.Add(lblApellidoPaterno);
        Controls.Add(txtApellidoMaterno);
        Controls.Add(txtApellidoPaterno);
        Controls.Add(btnActualizar);
        Controls.Add(btnVer);
        Controls.Add(btnCrear);
        Controls.Add(btnEliminar);
        Controls.Add(btnGuardar);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "PersonaFormulario";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Examen - MVP";
        ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
