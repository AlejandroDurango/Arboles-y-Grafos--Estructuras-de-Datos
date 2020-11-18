namespace Arboles_y_Grafos__Estructuras_de_Datos
{
    partial class Creador_Arboles
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearConDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_directorio = new System.Windows.Forms.TextBox();
            this.lbl_lecturaJson = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grupoJson = new System.Windows.Forms.GroupBox();
            this.GrupoNodo = new System.Windows.Forms.TabPage();
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregarDato = new System.Windows.Forms.Button();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.Grupo_creacion = new System.Windows.Forms.TabControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grupoJson.SuspendLayout();
            this.GrupoNodo.SuspendLayout();
            this.Grupo_creacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.arbolToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem});
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.arbolToolStripMenuItem.Text = "Arbol";
            this.arbolToolStripMenuItem.Click += new System.EventHandler(this.arbolToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.crearConDatosToolStripMenuItem});
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.crearToolStripMenuItem1.Text = "Crear desde JSON";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // crearConDatosToolStripMenuItem
            // 
            this.crearConDatosToolStripMenuItem.Name = "crearConDatosToolStripMenuItem";
            this.crearConDatosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.crearConDatosToolStripMenuItem.Text = "Crear con datos";
            // 
            // txt_directorio
            // 
            this.txt_directorio.Location = new System.Drawing.Point(69, 12);
            this.txt_directorio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_directorio.Name = "txt_directorio";
            this.txt_directorio.Size = new System.Drawing.Size(868, 20);
            this.txt_directorio.TabIndex = 3;
            this.txt_directorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_lecturaJson
            // 
            this.lbl_lecturaJson.AutoSize = true;
            this.lbl_lecturaJson.Location = new System.Drawing.Point(4, 15);
            this.lbl_lecturaJson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lecturaJson.Name = "lbl_lecturaJson";
            this.lbl_lecturaJson.Size = new System.Drawing.Size(61, 13);
            this.lbl_lecturaJson.TabIndex = 4;
            this.lbl_lecturaJson.Text = "Ruta JSON";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(941, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Directorio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grupoJson
            // 
            this.grupoJson.Controls.Add(this.txt_directorio);
            this.grupoJson.Controls.Add(this.button1);
            this.grupoJson.Controls.Add(this.lbl_lecturaJson);
            this.grupoJson.Location = new System.Drawing.Point(7, 440);
            this.grupoJson.Margin = new System.Windows.Forms.Padding(2);
            this.grupoJson.Name = "grupoJson";
            this.grupoJson.Padding = new System.Windows.Forms.Padding(2);
            this.grupoJson.Size = new System.Drawing.Size(1048, 45);
            this.grupoJson.TabIndex = 7;
            this.grupoJson.TabStop = false;
            this.grupoJson.Visible = false;
            // 
            // GrupoNodo
            // 
            this.GrupoNodo.Controls.Add(this.txt_dato);
            this.GrupoNodo.Controls.Add(this.btn_eliminar);
            this.GrupoNodo.Controls.Add(this.btn_agregarDato);
            this.GrupoNodo.Controls.Add(this.lbl_Valor);
            this.GrupoNodo.Location = new System.Drawing.Point(4, 22);
            this.GrupoNodo.Margin = new System.Windows.Forms.Padding(2);
            this.GrupoNodo.Name = "GrupoNodo";
            this.GrupoNodo.Padding = new System.Windows.Forms.Padding(2);
            this.GrupoNodo.Size = new System.Drawing.Size(137, 120);
            this.GrupoNodo.TabIndex = 0;
            this.GrupoNodo.Text = "Nodo";
            this.GrupoNodo.UseVisualStyleBackColor = true;
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(2, 23);
            this.txt_dato.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(135, 20);
            this.txt_dato.TabIndex = 7;
            this.txt_dato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.Location = new System.Drawing.Point(34, 73);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(82, 23);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar Nodo";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregarDato
            // 
            this.btn_agregarDato.AutoSize = true;
            this.btn_agregarDato.Location = new System.Drawing.Point(34, 49);
            this.btn_agregarDato.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarDato.Name = "btn_agregarDato";
            this.btn_agregarDato.Size = new System.Drawing.Size(83, 23);
            this.btn_agregarDato.TabIndex = 10;
            this.btn_agregarDato.Text = "Agregar Nodo";
            this.btn_agregarDato.UseVisualStyleBackColor = true;
            this.btn_agregarDato.Click += new System.EventHandler(this.btn_agregarDato_Click);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(47, 8);
            this.lbl_Valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(35, 13);
            this.lbl_Valor.TabIndex = 9;
            this.lbl_Valor.Text = "Datos";
            // 
            // Grupo_creacion
            // 
            this.Grupo_creacion.Controls.Add(this.GrupoNodo);
            this.Grupo_creacion.Location = new System.Drawing.Point(914, 32);
            this.Grupo_creacion.Margin = new System.Windows.Forms.Padding(2);
            this.Grupo_creacion.Name = "Grupo_creacion";
            this.Grupo_creacion.SelectedIndex = 0;
            this.Grupo_creacion.Size = new System.Drawing.Size(145, 146);
            this.Grupo_creacion.TabIndex = 5;
            this.Grupo_creacion.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(915, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(145, 129);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(915, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(145, 129);
            this.dataGridView1.TabIndex = 11;
            // 
            // Creador_Arboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1072, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grupoJson);
            this.Controls.Add(this.Grupo_creacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Creador_Arboles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Creador de Arboles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grupoJson.ResumeLayout(false);
            this.grupoJson.PerformLayout();
            this.GrupoNodo.ResumeLayout(false);
            this.GrupoNodo.PerformLayout();
            this.Grupo_creacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_directorio;
        private System.Windows.Forms.Label lbl_lecturaJson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grupoJson;
        private System.Windows.Forms.ToolStripMenuItem arbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearConDatosToolStripMenuItem;
        private System.Windows.Forms.TabPage GrupoNodo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregarDato;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TabControl Grupo_creacion;
        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

