namespace ProyectoDAM
{
    partial class Gestion
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
            btn_OPCIONES_USUARIO = new Button();
            btn_AJUSTES = new Button();
            btn_CREAR_USUARIO = new Button();
            btn_MODIFICAR_USUARIO = new Button();
            btn_BORRAR_USUARIO = new Button();
            SuspendLayout();
            // 
            // btn_OPCIONES_USUARIO
            // 
            btn_OPCIONES_USUARIO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_OPCIONES_USUARIO.Location = new Point(240, 177);
            btn_OPCIONES_USUARIO.Name = "btn_OPCIONES_USUARIO";
            btn_OPCIONES_USUARIO.Size = new Size(484, 126);
            btn_OPCIONES_USUARIO.TabIndex = 4;
            btn_OPCIONES_USUARIO.Text = "OPCIONES DE USUARIOS";
            btn_OPCIONES_USUARIO.UseVisualStyleBackColor = true;
            btn_OPCIONES_USUARIO.Click += btn_OPCIONES_USUARIO_Click;
            // 
            // btn_AJUSTES
            // 
            btn_AJUSTES.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AJUSTES.Location = new Point(240, 411);
            btn_AJUSTES.Name = "btn_AJUSTES";
            btn_AJUSTES.Size = new Size(484, 126);
            btn_AJUSTES.TabIndex = 6;
            btn_AJUSTES.Text = "AJUSTES";
            btn_AJUSTES.UseVisualStyleBackColor = true;
            btn_AJUSTES.Click += btn_AJUSTES_Click;
            // 
            // btn_CREAR_USUARIO
            // 
            btn_CREAR_USUARIO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CREAR_USUARIO.Location = new Point(1127, 269);
            btn_CREAR_USUARIO.Name = "btn_CREAR_USUARIO";
            btn_CREAR_USUARIO.Size = new Size(484, 126);
            btn_CREAR_USUARIO.TabIndex = 7;
            btn_CREAR_USUARIO.Text = "CREAR USUARIO";
            btn_CREAR_USUARIO.UseVisualStyleBackColor = true;
            btn_CREAR_USUARIO.Visible = false;
            // 
            // btn_MODIFICAR_USUARIO
            // 
            btn_MODIFICAR_USUARIO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_USUARIO.Location = new Point(1127, 445);
            btn_MODIFICAR_USUARIO.Name = "btn_MODIFICAR_USUARIO";
            btn_MODIFICAR_USUARIO.Size = new Size(484, 126);
            btn_MODIFICAR_USUARIO.TabIndex = 8;
            btn_MODIFICAR_USUARIO.Text = "MODIFICAR USUARIO";
            btn_MODIFICAR_USUARIO.UseVisualStyleBackColor = true;
            btn_MODIFICAR_USUARIO.Visible = false;
            // 
            // btn_BORRAR_USUARIO
            // 
            btn_BORRAR_USUARIO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BORRAR_USUARIO.Location = new Point(1127, 623);
            btn_BORRAR_USUARIO.Name = "btn_BORRAR_USUARIO";
            btn_BORRAR_USUARIO.Size = new Size(484, 126);
            btn_BORRAR_USUARIO.TabIndex = 9;
            btn_BORRAR_USUARIO.Text = "BORRAR USUARIO";
            btn_BORRAR_USUARIO.UseVisualStyleBackColor = true;
            btn_BORRAR_USUARIO.Visible = false;
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(btn_BORRAR_USUARIO);
            Controls.Add(btn_MODIFICAR_USUARIO);
            Controls.Add(btn_CREAR_USUARIO);
            Controls.Add(btn_AJUSTES);
            Controls.Add(btn_OPCIONES_USUARIO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gestion";
            Text = "Gestion";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_MENU_USUARIOS;
        private Button btn_OPCIONES_USUARIO;
        private Button btn_AJUSTES;
        private Button btn_CREAR_USUARIO;
        private Button btn_MODIFICAR_USUARIO;
        private Button btn_BORRAR_USUARIO;
    }
}