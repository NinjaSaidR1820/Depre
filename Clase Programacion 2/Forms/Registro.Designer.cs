namespace Clase_Programacion_2
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.cbTipoActivo = new System.Windows.Forms.ComboBox();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.txtNombreActivo = new System.Windows.Forms.TextBox();
            this.txtValorActivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDeSalvamento = new System.Windows.Forms.TextBox();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIDS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDepreciaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTipoActivo
            // 
            this.cbTipoActivo.FormattingEnabled = true;
            this.cbTipoActivo.Items.AddRange(new object[] {
            "Activo Tangible",
            "Activo Intangible"});
            this.cbTipoActivo.Location = new System.Drawing.Point(23, 131);
            this.cbTipoActivo.Name = "cbTipoActivo";
            this.cbTipoActivo.Size = new System.Drawing.Size(159, 21);
            this.cbTipoActivo.TabIndex = 0;
            // 
            // dgvActivos
            // 
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Location = new System.Drawing.Point(23, 169);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.Size = new System.Drawing.Size(647, 219);
            this.dgvActivos.TabIndex = 1;
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.Location = new System.Drawing.Point(23, 76);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.Size = new System.Drawing.Size(159, 20);
            this.txtNombreActivo.TabIndex = 2;
            // 
            // txtValorActivo
            // 
            this.txtValorActivo.Location = new System.Drawing.Point(217, 76);
            this.txtValorActivo.Name = "txtValorActivo";
            this.txtValorActivo.Size = new System.Drawing.Size(159, 20);
            this.txtValorActivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Activo Fijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Activo Fijo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.BackgroundImage")));
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Agregar Registro";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Agregar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.BackgroundImage")));
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Cancelar Registro";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "Cancelar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.BackgroundImage")));
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Salir";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "Salir";
            this.toolStripLabel3.Click += new System.EventHandler(this.ToolStripLabel3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor de Salvamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vida Util";
            // 
            // txtValorDeSalvamento
            // 
            this.txtValorDeSalvamento.Location = new System.Drawing.Point(408, 76);
            this.txtValorDeSalvamento.Name = "txtValorDeSalvamento";
            this.txtValorDeSalvamento.Size = new System.Drawing.Size(159, 20);
            this.txtValorDeSalvamento.TabIndex = 11;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(217, 133);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(159, 20);
            this.txtVidaUtil.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Red;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(411, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(504, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 40);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(675, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Buscar por Id";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(697, 282);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(165, 106);
            this.txtConsulta.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIDS
            // 
            this.btnIDS.Location = new System.Drawing.Point(697, 241);
            this.btnIDS.Name = "btnIDS";
            this.btnIDS.Size = new System.Drawing.Size(133, 35);
            this.btnIDS.TabIndex = 20;
            this.btnIDS.Text = "Mostrar Id\'s";
            this.btnIDS.UseVisualStyleBackColor = true;
            this.btnIDS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nota: Si no Conoce los ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pulsar el Boton para";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mostrar";
            // 
            // btnDepreciaciones
            // 
            this.btnDepreciaciones.Location = new System.Drawing.Point(904, 129);
            this.btnDepreciaciones.Name = "btnDepreciaciones";
            this.btnDepreciaciones.Size = new System.Drawing.Size(85, 58);
            this.btnDepreciaciones.TabIndex = 25;
            this.btnDepreciaciones.Text = "Depreciacion";
            this.btnDepreciaciones.UseVisualStyleBackColor = true;
            this.btnDepreciaciones.Click += new System.EventHandler(this.btnDepreciaciones_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 451);
            this.Controls.Add(this.btnDepreciaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIDS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorDeSalvamento);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorActivo);
            this.Controls.Add(this.txtNombreActivo);
            this.Controls.Add(this.dgvActivos);
            this.Controls.Add(this.cbTipoActivo);
            this.Name = "FrmRegistro";
            this.Text = "Registro de Activos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoActivo;
        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.TextBox txtNombreActivo;
        private System.Windows.Forms.TextBox txtValorActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorDeSalvamento;
        private System.Windows.Forms.TextBox txtVidaUtil;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDepreciaciones;
    }
}

