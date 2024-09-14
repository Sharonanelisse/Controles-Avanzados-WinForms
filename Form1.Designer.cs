namespace ControlesAvanzados
{
    partial class Contenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            nuevoArchivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoProyectoToolStripMenuItem = new ToolStripMenuItem();
            nuevaTareaToolStripMenuItem = new ToolStripMenuItem();
            vistaToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, inicioToolStripMenuItem, vistaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1276, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 24);
            toolStripMenuItem1.Text = "Inicio";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoArchivoToolStripMenuItem, nuevoProyectoToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(66, 24);
            inicioToolStripMenuItem.Text = "Nuevo";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            nuevoArchivoToolStripMenuItem.Size = new Size(197, 26);
            nuevoArchivoToolStripMenuItem.Text = "Nuevo Archivo";
            nuevoArchivoToolStripMenuItem.Click += nuevoArchivoToolStripMenuItem_Click;
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            nuevoProyectoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaTareaToolStripMenuItem });
            nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            nuevoProyectoToolStripMenuItem.Size = new Size(197, 26);
            nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            nuevoProyectoToolStripMenuItem.Click += nuevoProyectoToolStripMenuItem_Click;
            // 
            // nuevaTareaToolStripMenuItem
            // 
            nuevaTareaToolStripMenuItem.Name = "nuevaTareaToolStripMenuItem";
            nuevaTareaToolStripMenuItem.Size = new Size(173, 26);
            nuevaTareaToolStripMenuItem.Text = "Nueva Tarea";
            // 
            // vistaToolStripMenuItem
            // 
            vistaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horizontalToolStripMenuItem, verticalToolStripMenuItem });
            vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            vistaToolStripMenuItem.Size = new Size(55, 24);
            vistaToolStripMenuItem.Text = "Vista";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(162, 26);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(162, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // Contenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 567);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Contenedor";
            Text = "Contenedor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem nuevoArchivoToolStripMenuItem;
        private ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private ToolStripMenuItem vistaToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem nuevaTareaToolStripMenuItem;
    }
}
