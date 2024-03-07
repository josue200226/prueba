namespace AportePrimerParcialB

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            btn_Calcular = new Button();
            txtNombreproducto = new TextBox();
            txtCodigo = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtCliente = new TextBox();
            txtEdadCliente = new TextBox();
            txtFechaVenta = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(48, 83);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre del libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(489, 76);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(64, 137);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 2;
            label3.Text = "Categoria ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(494, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(64, 187);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 4;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(489, 193);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(48, 234);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 6;
            label7.Text = "Edad Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(489, 247);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 7;
            label8.Text = "Fecha Venta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 555);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 9;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Calcular.ForeColor = Color.Indigo;
            btn_Calcular.Location = new Point(581, 342);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(214, 41);
            btn_Calcular.TabIndex = 10;
            btn_Calcular.Text = "TOTAL A PAGAR";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // txtNombreproducto
            // 
            txtNombreproducto.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreproducto.ForeColor = Color.Olive;
            txtNombreproducto.Location = new Point(260, 76);
            txtNombreproducto.Name = "txtNombreproducto";
            txtNombreproducto.Size = new Size(149, 33);
            txtNombreproducto.TabIndex = 11;
            txtNombreproducto.TextChanged += txtNombreproducto_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.Olive;
            txtCodigo.Location = new Point(626, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(149, 33);
            txtCodigo.TabIndex = 12;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategoria.ForeColor = Color.Olive;
            txtCategoria.Location = new Point(260, 124);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(149, 33);
            txtCategoria.TabIndex = 13;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.Olive;
            txtPrecio.Location = new Point(626, 124);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(149, 33);
            txtPrecio.TabIndex = 14;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.ForeColor = Color.Olive;
            txtCantidad.Location = new Point(260, 180);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(149, 33);
            txtCantidad.TabIndex = 15;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCliente.ForeColor = Color.Olive;
            txtCliente.Location = new Point(626, 186);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(149, 33);
            txtCliente.TabIndex = 16;
            // 
            // txtEdadCliente
            // 
            txtEdadCliente.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEdadCliente.ForeColor = Color.Olive;
            txtEdadCliente.Location = new Point(260, 234);
            txtEdadCliente.Name = "txtEdadCliente";
            txtEdadCliente.Size = new Size(149, 33);
            txtEdadCliente.TabIndex = 17;
            // 
            // txtFechaVenta
            // 
            txtFechaVenta.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtFechaVenta.ForeColor = Color.Olive;
            txtFechaVenta.Location = new Point(626, 247);
            txtFechaVenta.Name = "txtFechaVenta";
            txtFechaVenta.Size = new Size(149, 33);
            txtFechaVenta.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Goudy Stout", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SlateBlue;
            label9.Location = new Point(194, 9);
            label9.Name = "label9";
            label9.Size = new Size(513, 40);
            label9.TabIndex = 19;
            label9.Text = "LIBRERIA WENDY";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(841, 471);
            Controls.Add(label9);
            Controls.Add(txtFechaVenta);
            Controls.Add(txtEdadCliente);
            Controls.Add(txtCliente);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreproducto);
            Controls.Add(btn_Calcular);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button btn_Calcular;
        private TextBox txtNombreproducto;
        private TextBox txtCodigo;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtCliente;
        private TextBox txtEdadCliente;
        private TextBox txtFechaVenta;
        private Label label9;
    }
}