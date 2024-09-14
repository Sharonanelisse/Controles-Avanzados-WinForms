namespace ControlesAvanzados
{
    partial class Archivo
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
            label1 = new Label();
            listadoVentas = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            selectorDepartamento = new ListBox();
            comboBoxAnios = new ComboBox();
            comboBoxMeses = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 31);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Nuevo Archivo";
            // 
            // listadoVentas
            // 
            listadoVentas.AutoScroll = true;
            listadoVentas.Location = new Point(407, 58);
            listadoVentas.Name = "listadoVentas";
            listadoVentas.Size = new Size(827, 768);
            listadoVentas.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(271, 519);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 2;
            // 
            // selectorDepartamento
            // 
            selectorDepartamento.FormattingEnabled = true;
            selectorDepartamento.Location = new Point(32, 276);
            selectorDepartamento.Name = "selectorDepartamento";
            selectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            selectorDepartamento.Size = new Size(316, 164);
            selectorDepartamento.TabIndex = 3;
            selectorDepartamento.SelectedValueChanged += selectorDepartamento_SelectedValueChanged;
            // 
            // comboBoxAnios
            // 
            comboBoxAnios.FormattingEnabled = true;
            comboBoxAnios.Location = new Point(32, 100);
            comboBoxAnios.Name = "comboBoxAnios";
            comboBoxAnios.Size = new Size(315, 28);
            comboBoxAnios.TabIndex = 4;
            comboBoxAnios.SelectedValueChanged += comboBoxAnios_SelectedValueChanged;
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(35, 188);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(312, 28);
            comboBoxMeses.TabIndex = 5;
            comboBoxMeses.SelectedValueChanged += comboBoxMeses_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 241);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 6;
            label2.Text = "Seleccionar Depatamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 72);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 7;
            label3.Text = "Seleccionar Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 156);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 8;
            label4.Text = "Seleccionar Mes";
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 928);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeses);
            Controls.Add(comboBoxAnios);
            Controls.Add(selectorDepartamento);
            Controls.Add(checkedListBox1);
            Controls.Add(listadoVentas);
            Controls.Add(label1);
            Name = "Archivo";
            Text = "Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel listadoVentas;
        private CheckedListBox checkedListBox1;
        private ListBox selectorDepartamento;
        private ComboBox comboBoxAnios;
        private ComboBox comboBoxMeses;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}