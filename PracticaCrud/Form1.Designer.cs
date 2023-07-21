namespace PracticaCrud
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
            this.grp_personas = new System.Windows.Forms.GroupBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_apMaterno = new System.Windows.Forms.TextBox();
            this.txt_apPaterno = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_opciones = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.grp_personas.SuspendLayout();
            this.grp_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_personas
            // 
            this.grp_personas.Controls.Add(this.txt_edad);
            this.grp_personas.Controls.Add(this.label5);
            this.grp_personas.Controls.Add(this.dtp_fecha_nac);
            this.grp_personas.Controls.Add(this.button2);
            this.grp_personas.Controls.Add(this.btn_guardar);
            this.grp_personas.Controls.Add(this.txt_apMaterno);
            this.grp_personas.Controls.Add(this.txt_apPaterno);
            this.grp_personas.Controls.Add(this.txt_nombre);
            this.grp_personas.Controls.Add(this.label4);
            this.grp_personas.Controls.Add(this.label3);
            this.grp_personas.Controls.Add(this.label2);
            this.grp_personas.Controls.Add(this.label1);
            this.grp_personas.Enabled = false;
            this.grp_personas.Location = new System.Drawing.Point(27, 27);
            this.grp_personas.Name = "grp_personas";
            this.grp_personas.Size = new System.Drawing.Size(873, 311);
            this.grp_personas.TabIndex = 0;
            this.grp_personas.TabStop = false;
            this.grp_personas.Text = "Modulo de personas";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(484, 67);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(111, 22);
            this.txt_edad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "*Edad";
            // 
            // dtp_fecha_nac
            // 
            this.dtp_fecha_nac.Location = new System.Drawing.Point(621, 67);
            this.dtp_fecha_nac.Name = "dtp_fecha_nac";
            this.dtp_fecha_nac.Size = new System.Drawing.Size(200, 22);
            this.dtp_fecha_nac.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(21, 130);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 65);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_apMaterno
            // 
            this.txt_apMaterno.Location = new System.Drawing.Point(349, 67);
            this.txt_apMaterno.Name = "txt_apMaterno";
            this.txt_apMaterno.Size = new System.Drawing.Size(111, 22);
            this.txt_apMaterno.TabIndex = 6;
            // 
            // txt_apPaterno
            // 
            this.txt_apPaterno.Location = new System.Drawing.Point(175, 68);
            this.txt_apPaterno.Name = "txt_apPaterno";
            this.txt_apPaterno.Size = new System.Drawing.Size(108, 22);
            this.txt_apPaterno.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(21, 68);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nombre";
            // 
            // grp_opciones
            // 
            this.grp_opciones.Controls.Add(this.btn_eliminar);
            this.grp_opciones.Controls.Add(this.btn_limpiar);
            this.grp_opciones.Controls.Add(this.btn_actualizar);
            this.grp_opciones.Controls.Add(this.btn_nuevo);
            this.grp_opciones.Location = new System.Drawing.Point(27, 606);
            this.grp_opciones.Name = "grp_opciones";
            this.grp_opciones.Size = new System.Drawing.Size(605, 105);
            this.grp_opciones.TabIndex = 1;
            this.grp_opciones.TabStop = false;
            this.grp_opciones.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(292, 21);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 65);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(153, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 65);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(21, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 65);
            this.btn_nuevo.TabIndex = 12;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(27, 419);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(873, 169);
            this.dgv_datos.TabIndex = 2;
            this.dgv_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datos_CellClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(27, 348);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 65);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(134, 370);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(766, 22);
            this.txt_buscar.TabIndex = 14;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(426, 21);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 65);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 745);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.grp_opciones);
            this.Controls.Add(this.grp_personas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_personas.ResumeLayout(false);
            this.grp_personas.PerformLayout();
            this.grp_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_personas;
        private System.Windows.Forms.GroupBox grp_opciones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_apMaterno;
        private System.Windows.Forms.TextBox txt_apPaterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nac;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

