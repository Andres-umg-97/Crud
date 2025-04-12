namespace Formulario
{
    partial class FormFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormulario));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(83, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 21);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet.Location = new System.Drawing.Point(83, 137);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(61, 21);
            this.labelCarnet.TabIndex = 1;
            this.labelCarnet.Text = "Carnet";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeccion.Location = new System.Drawing.Point(83, 226);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(69, 21);
            this.labelSeccion.TabIndex = 2;
            this.labelSeccion.Text = "Seccion";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(83, 307);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(63, 21);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo";
            this.labelCorreo.Click += new System.EventHandler(this.labelCorreo_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(185, 60);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(519, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(185, 138);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(371, 22);
            this.textBoxCarnet.TabIndex = 5;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(185, 225);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(56, 22);
            this.textBoxSeccion.TabIndex = 6;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(185, 308);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(371, 22);
            this.textBoxCorreo.TabIndex = 7;
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaludar.Location = new System.Drawing.Point(185, 359);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(124, 65);
            this.buttonSaludar.TabIndex = 8;
            this.buttonSaludar.Text = "Saludar";
            this.buttonSaludar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(490, 361);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(124, 65);
            this.buttonRegistrar.TabIndex = 9;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // FormFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonSaludar);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.labelCarnet);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormFormulario";
            this.Text = "Formulario";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FormFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxSeccion;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.Button buttonRegistrar;
    }
}

