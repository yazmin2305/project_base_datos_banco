
namespace Proyecto_Segundo_Corte_LabBD2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tbcGestionBanco = new System.Windows.Forms.TabControl();
            this.tbpRegistrarBanco = new System.Windows.Forms.TabPage();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarBanco = new System.Windows.Forms.Button();
            this.lbCreacionBan = new System.Windows.Forms.Label();
            this.txtNitBan = new System.Windows.Forms.TextBox();
            this.lbNitBan = new System.Windows.Forms.Label();
            this.txtNomBan = new System.Windows.Forms.TextBox();
            this.lbNomBan = new System.Windows.Forms.Label();
            this.tbpRegistrarSucursal = new System.Windows.Forms.TabPage();
            this.cmbUbiSuc = new System.Windows.Forms.ComboBox();
            this.btnGuardarSucursal = new System.Windows.Forms.Button();
            this.txtNitBanSuc = new System.Windows.Forms.TextBox();
            this.txtAnioSuc = new System.Windows.Forms.TextBox();
            this.txtNumEmpSuc = new System.Windows.Forms.TextBox();
            this.txtNomSuc = new System.Windows.Forms.TextBox();
            this.txtCodSuc = new System.Windows.Forms.TextBox();
            this.lbNitBanSuc = new System.Windows.Forms.Label();
            this.lbAnioSuc = new System.Windows.Forms.Label();
            this.lbNumEmpSuc = new System.Windows.Forms.Label();
            this.lbUbiSuc = new System.Windows.Forms.Label();
            this.lbNomSuc = new System.Windows.Forms.Label();
            this.lbCodSuc = new System.Windows.Forms.Label();
            this.tbpConsultarSuc = new System.Windows.Forms.TabPage();
            this.btnConsultarSucursales = new System.Windows.Forms.Button();
            this.txtNomBanConsult = new System.Windows.Forms.TextBox();
            this.cmbUbiSucConsult = new System.Windows.Forms.ComboBox();
            this.lbUbiSucConsult = new System.Windows.Forms.Label();
            this.lbNomBanConsult = new System.Windows.Forms.Label();
            this.dgvConsultSuc = new System.Windows.Forms.DataGridView();
            this.tbcGestionBanco.SuspendLayout();
            this.tbpRegistrarBanco.SuspendLayout();
            this.tbpRegistrarSucursal.SuspendLayout();
            this.tbpConsultarSuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(10, 6);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(677, 420);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // tbcGestionBanco
            // 
            this.tbcGestionBanco.Controls.Add(this.tbpRegistrarBanco);
            this.tbcGestionBanco.Controls.Add(this.tbpRegistrarSucursal);
            this.tbcGestionBanco.Controls.Add(this.tbpConsultarSuc);
            this.tbcGestionBanco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcGestionBanco.Location = new System.Drawing.Point(6, 6);
            this.tbcGestionBanco.Name = "tbcGestionBanco";
            this.tbcGestionBanco.SelectedIndex = 0;
            this.tbcGestionBanco.Size = new System.Drawing.Size(678, 420);
            this.tbcGestionBanco.TabIndex = 0;
            // 
            // tbpRegistrarBanco
            // 
            this.tbpRegistrarBanco.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpRegistrarBanco.Controls.Add(this.dtpFechaCreacion);
            this.tbpRegistrarBanco.Controls.Add(this.btnGuardarBanco);
            this.tbpRegistrarBanco.Controls.Add(this.lbCreacionBan);
            this.tbpRegistrarBanco.Controls.Add(this.txtNitBan);
            this.tbpRegistrarBanco.Controls.Add(this.lbNitBan);
            this.tbpRegistrarBanco.Controls.Add(this.txtNomBan);
            this.tbpRegistrarBanco.Controls.Add(this.lbNomBan);
            this.tbpRegistrarBanco.Location = new System.Drawing.Point(4, 27);
            this.tbpRegistrarBanco.Name = "tbpRegistrarBanco";
            this.tbpRegistrarBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarBanco.Size = new System.Drawing.Size(670, 389);
            this.tbpRegistrarBanco.TabIndex = 0;
            this.tbpRegistrarBanco.Text = "Registrar Banco";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(411, 198);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(156, 27);
            this.dtpFechaCreacion.TabIndex = 7;
            // 
            // btnGuardarBanco
            // 
            this.btnGuardarBanco.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarBanco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBanco.Location = new System.Drawing.Point(277, 276);
            this.btnGuardarBanco.Name = "btnGuardarBanco";
            this.btnGuardarBanco.Size = new System.Drawing.Size(110, 52);
            this.btnGuardarBanco.TabIndex = 6;
            this.btnGuardarBanco.Text = "Guardar";
            this.btnGuardarBanco.UseVisualStyleBackColor = false;
            this.btnGuardarBanco.Click += new System.EventHandler(this.btnGuardarBanco_Click);
            // 
            // lbCreacionBan
            // 
            this.lbCreacionBan.AutoSize = true;
            this.lbCreacionBan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreacionBan.Location = new System.Drawing.Point(77, 204);
            this.lbCreacionBan.Name = "lbCreacionBan";
            this.lbCreacionBan.Size = new System.Drawing.Size(319, 18);
            this.lbCreacionBan.TabIndex = 4;
            this.lbCreacionBan.Text = "Digite la fecha de creación del banco:";
            // 
            // txtNitBan
            // 
            this.txtNitBan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitBan.Location = new System.Drawing.Point(411, 93);
            this.txtNitBan.Name = "txtNitBan";
            this.txtNitBan.Size = new System.Drawing.Size(154, 27);
            this.txtNitBan.TabIndex = 3;
            // 
            // lbNitBan
            // 
            this.lbNitBan.AutoSize = true;
            this.lbNitBan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNitBan.Location = new System.Drawing.Point(77, 96);
            this.lbNitBan.Name = "lbNitBan";
            this.lbNitBan.Size = new System.Drawing.Size(198, 18);
            this.lbNitBan.TabIndex = 2;
            this.lbNitBan.Text = "Digite el nit del banco:";
            // 
            // txtNomBan
            // 
            this.txtNomBan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBan.Location = new System.Drawing.Point(411, 144);
            this.txtNomBan.Name = "txtNomBan";
            this.txtNomBan.Size = new System.Drawing.Size(156, 27);
            this.txtNomBan.TabIndex = 1;
            // 
            // lbNomBan
            // 
            this.lbNomBan.AutoSize = true;
            this.lbNomBan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomBan.Location = new System.Drawing.Point(75, 152);
            this.lbNomBan.Name = "lbNomBan";
            this.lbNomBan.Size = new System.Drawing.Size(237, 18);
            this.lbNomBan.TabIndex = 0;
            this.lbNomBan.Text = "Digite el nombre del banco:";
            // 
            // tbpRegistrarSucursal
            // 
            this.tbpRegistrarSucursal.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpRegistrarSucursal.Controls.Add(this.cmbUbiSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.btnGuardarSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNitBanSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.txtAnioSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNumEmpSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNomSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.txtCodSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNitBanSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbAnioSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNumEmpSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbUbiSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNomSuc);
            this.tbpRegistrarSucursal.Controls.Add(this.lbCodSuc);
            this.tbpRegistrarSucursal.Location = new System.Drawing.Point(4, 27);
            this.tbpRegistrarSucursal.Name = "tbpRegistrarSucursal";
            this.tbpRegistrarSucursal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarSucursal.Size = new System.Drawing.Size(670, 389);
            this.tbpRegistrarSucursal.TabIndex = 1;
            this.tbpRegistrarSucursal.Text = "Registrar Sucursal";
            // 
            // cmbUbiSuc
            // 
            this.cmbUbiSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbiSuc.FormattingEnabled = true;
            this.cmbUbiSuc.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Centro"});
            this.cmbUbiSuc.Location = new System.Drawing.Point(437, 140);
            this.cmbUbiSuc.Name = "cmbUbiSuc";
            this.cmbUbiSuc.Size = new System.Drawing.Size(170, 26);
            this.cmbUbiSuc.TabIndex = 13;
            // 
            // btnGuardarSucursal
            // 
            this.btnGuardarSucursal.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSucursal.Location = new System.Drawing.Point(278, 316);
            this.btnGuardarSucursal.Name = "btnGuardarSucursal";
            this.btnGuardarSucursal.Size = new System.Drawing.Size(128, 49);
            this.btnGuardarSucursal.TabIndex = 12;
            this.btnGuardarSucursal.Text = "Guardar";
            this.btnGuardarSucursal.UseVisualStyleBackColor = false;
            this.btnGuardarSucursal.Click += new System.EventHandler(this.btnGuardarSucursal_Click);
            // 
            // txtNitBanSuc
            // 
            this.txtNitBanSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitBanSuc.Location = new System.Drawing.Point(437, 261);
            this.txtNitBanSuc.Name = "txtNitBanSuc";
            this.txtNitBanSuc.Size = new System.Drawing.Size(170, 27);
            this.txtNitBanSuc.TabIndex = 11;
            // 
            // txtAnioSuc
            // 
            this.txtAnioSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioSuc.Location = new System.Drawing.Point(437, 216);
            this.txtAnioSuc.Name = "txtAnioSuc";
            this.txtAnioSuc.Size = new System.Drawing.Size(170, 27);
            this.txtAnioSuc.TabIndex = 10;
            // 
            // txtNumEmpSuc
            // 
            this.txtNumEmpSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEmpSuc.Location = new System.Drawing.Point(437, 179);
            this.txtNumEmpSuc.Name = "txtNumEmpSuc";
            this.txtNumEmpSuc.Size = new System.Drawing.Size(170, 27);
            this.txtNumEmpSuc.TabIndex = 9;
            // 
            // txtNomSuc
            // 
            this.txtNomSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSuc.Location = new System.Drawing.Point(437, 101);
            this.txtNomSuc.Name = "txtNomSuc";
            this.txtNomSuc.Size = new System.Drawing.Size(170, 27);
            this.txtNomSuc.TabIndex = 7;
            // 
            // txtCodSuc
            // 
            this.txtCodSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSuc.Location = new System.Drawing.Point(437, 56);
            this.txtCodSuc.Name = "txtCodSuc";
            this.txtCodSuc.Size = new System.Drawing.Size(170, 27);
            this.txtCodSuc.TabIndex = 6;
            // 
            // lbNitBanSuc
            // 
            this.lbNitBanSuc.AutoSize = true;
            this.lbNitBanSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNitBanSuc.Location = new System.Drawing.Point(52, 262);
            this.lbNitBanSuc.Name = "lbNitBanSuc";
            this.lbNitBanSuc.Size = new System.Drawing.Size(276, 18);
            this.lbNitBanSuc.TabIndex = 5;
            this.lbNitBanSuc.Text = "Digite el nit del banco asociado:";
            // 
            // lbAnioSuc
            // 
            this.lbAnioSuc.AutoSize = true;
            this.lbAnioSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnioSuc.Location = new System.Drawing.Point(52, 225);
            this.lbAnioSuc.Name = "lbAnioSuc";
            this.lbAnioSuc.Size = new System.Drawing.Size(362, 18);
            this.lbAnioSuc.TabIndex = 4;
            this.lbAnioSuc.Text = "Digite la antigüedad de la sucursal (años):";
            // 
            // lbNumEmpSuc
            // 
            this.lbNumEmpSuc.AutoSize = true;
            this.lbNumEmpSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumEmpSuc.Location = new System.Drawing.Point(52, 188);
            this.lbNumEmpSuc.Name = "lbNumEmpSuc";
            this.lbNumEmpSuc.Size = new System.Drawing.Size(273, 18);
            this.lbNumEmpSuc.TabIndex = 3;
            this.lbNumEmpSuc.Text = "Digite el numero de empleados:";
            // 
            // lbUbiSuc
            // 
            this.lbUbiSuc.AutoSize = true;
            this.lbUbiSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbiSuc.Location = new System.Drawing.Point(52, 149);
            this.lbUbiSuc.Name = "lbUbiSuc";
            this.lbUbiSuc.Size = new System.Drawing.Size(287, 18);
            this.lbUbiSuc.TabIndex = 2;
            this.lbUbiSuc.Text = "Digite la ubicación de la sucursal:";
            // 
            // lbNomSuc
            // 
            this.lbNomSuc.AutoSize = true;
            this.lbNomSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomSuc.Location = new System.Drawing.Point(52, 110);
            this.lbNomSuc.Name = "lbNomSuc";
            this.lbNomSuc.Size = new System.Drawing.Size(272, 18);
            this.lbNomSuc.TabIndex = 1;
            this.lbNomSuc.Text = "Digite el nombre de la sucursal:";
            // 
            // lbCodSuc
            // 
            this.lbCodSuc.AutoSize = true;
            this.lbCodSuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodSuc.Location = new System.Drawing.Point(52, 65);
            this.lbCodSuc.Name = "lbCodSuc";
            this.lbCodSuc.Size = new System.Drawing.Size(264, 18);
            this.lbCodSuc.TabIndex = 0;
            this.lbCodSuc.Text = "Digite el codigo de la sucursal:";
            // 
            // tbpConsultarSuc
            // 
            this.tbpConsultarSuc.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpConsultarSuc.Controls.Add(this.btnConsultarSucursales);
            this.tbpConsultarSuc.Controls.Add(this.txtNomBanConsult);
            this.tbpConsultarSuc.Controls.Add(this.cmbUbiSucConsult);
            this.tbpConsultarSuc.Controls.Add(this.lbUbiSucConsult);
            this.tbpConsultarSuc.Controls.Add(this.lbNomBanConsult);
            this.tbpConsultarSuc.Controls.Add(this.dgvConsultSuc);
            this.tbpConsultarSuc.Location = new System.Drawing.Point(4, 27);
            this.tbpConsultarSuc.Name = "tbpConsultarSuc";
            this.tbpConsultarSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarSuc.Size = new System.Drawing.Size(670, 389);
            this.tbpConsultarSuc.TabIndex = 2;
            this.tbpConsultarSuc.Text = "Consultar Sucursales";
            // 
            // btnConsultarSucursales
            // 
            this.btnConsultarSucursales.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultarSucursales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSucursales.Location = new System.Drawing.Point(530, 46);
            this.btnConsultarSucursales.Name = "btnConsultarSucursales";
            this.btnConsultarSucursales.Size = new System.Drawing.Size(111, 48);
            this.btnConsultarSucursales.TabIndex = 5;
            this.btnConsultarSucursales.Text = "Consultar";
            this.btnConsultarSucursales.UseVisualStyleBackColor = false;
            this.btnConsultarSucursales.Click += new System.EventHandler(this.btnConsultarSucursales_Click);
            // 
            // txtNomBanConsult
            // 
            this.txtNomBanConsult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBanConsult.Location = new System.Drawing.Point(368, 38);
            this.txtNomBanConsult.Name = "txtNomBanConsult";
            this.txtNomBanConsult.Size = new System.Drawing.Size(141, 27);
            this.txtNomBanConsult.TabIndex = 4;
            // 
            // cmbUbiSucConsult
            // 
            this.cmbUbiSucConsult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbiSucConsult.FormattingEnabled = true;
            this.cmbUbiSucConsult.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Centro"});
            this.cmbUbiSucConsult.Location = new System.Drawing.Point(368, 90);
            this.cmbUbiSucConsult.Name = "cmbUbiSucConsult";
            this.cmbUbiSucConsult.Size = new System.Drawing.Size(141, 26);
            this.cmbUbiSucConsult.TabIndex = 3;
            // 
            // lbUbiSucConsult
            // 
            this.lbUbiSucConsult.AutoSize = true;
            this.lbUbiSucConsult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbiSucConsult.Location = new System.Drawing.Point(15, 93);
            this.lbUbiSucConsult.Name = "lbUbiSucConsult";
            this.lbUbiSucConsult.Size = new System.Drawing.Size(300, 18);
            this.lbUbiSucConsult.TabIndex = 2;
            this.lbUbiSucConsult.Text = "Ingrese la ubicación de la sucursal:";
            // 
            // lbNomBanConsult
            // 
            this.lbNomBanConsult.AutoSize = true;
            this.lbNomBanConsult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomBanConsult.Location = new System.Drawing.Point(15, 46);
            this.lbNomBanConsult.Name = "lbNomBanConsult";
            this.lbNomBanConsult.Size = new System.Drawing.Size(347, 18);
            this.lbNomBanConsult.TabIndex = 1;
            this.lbNomBanConsult.Text = "Ingrese el nombre del banco a consultar:";
            // 
            // dgvConsultSuc
            // 
            this.dgvConsultSuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultSuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultSuc.Location = new System.Drawing.Point(129, 145);
            this.dgvConsultSuc.Name = "dgvConsultSuc";
            this.dgvConsultSuc.Size = new System.Drawing.Size(394, 219);
            this.dgvConsultSuc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 423);
            this.Controls.Add(this.tbcGestionBanco);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestionBanco.ResumeLayout(false);
            this.tbpRegistrarBanco.ResumeLayout(false);
            this.tbpRegistrarBanco.PerformLayout();
            this.tbpRegistrarSucursal.ResumeLayout(false);
            this.tbpRegistrarSucursal.PerformLayout();
            this.tbpConsultarSuc.ResumeLayout(false);
            this.tbpConsultarSuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultSuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TabControl tbcGestionBanco;
        private System.Windows.Forms.TabPage tbpRegistrarBanco;
        private System.Windows.Forms.TabPage tbpRegistrarSucursal;
        private System.Windows.Forms.TabPage tbpConsultarSuc;
        private System.Windows.Forms.TextBox txtNitBan;
        private System.Windows.Forms.Label lbNitBan;
        private System.Windows.Forms.TextBox txtNomBan;
        private System.Windows.Forms.Label lbNomBan;
        private System.Windows.Forms.Label lbCreacionBan;
        private System.Windows.Forms.Button btnGuardarBanco;
        private System.Windows.Forms.Label lbUbiSuc;
        private System.Windows.Forms.Label lbNomSuc;
        private System.Windows.Forms.Label lbCodSuc;
        private System.Windows.Forms.Label lbNitBanSuc;
        private System.Windows.Forms.Label lbAnioSuc;
        private System.Windows.Forms.Label lbNumEmpSuc;
        private System.Windows.Forms.TextBox txtNitBanSuc;
        private System.Windows.Forms.TextBox txtAnioSuc;
        private System.Windows.Forms.TextBox txtNumEmpSuc;
        private System.Windows.Forms.TextBox txtNomSuc;
        private System.Windows.Forms.TextBox txtCodSuc;
        private System.Windows.Forms.Button btnGuardarSucursal;
        private System.Windows.Forms.Label lbUbiSucConsult;
        private System.Windows.Forms.Label lbNomBanConsult;
        private System.Windows.Forms.DataGridView dgvConsultSuc;
        private System.Windows.Forms.TextBox txtNomBanConsult;
        private System.Windows.Forms.ComboBox cmbUbiSucConsult;
        private System.Windows.Forms.ComboBox cmbUbiSuc;
        private System.Windows.Forms.Button btnConsultarSucursales;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
    }
}

