namespace conversor2PDF
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.btAbrirOrigen = new System.Windows.Forms.Button();
            this.btAbrirDestino = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbOtros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPowerP = new System.Windows.Forms.Label();
            this.lbExel = new System.Windows.Forms.Label();
            this.lbWorld = new System.Windows.Forms.Label();
            this.chkPowerPoint = new System.Windows.Forms.CheckBox();
            this.chkExel = new System.Windows.Forms.CheckBox();
            this.chkWorld = new System.Windows.Forms.CheckBox();
            this.txConsola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConvertir = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAbrirOrigen
            // 
            this.btAbrirOrigen.Location = new System.Drawing.Point(410, 119);
            this.btAbrirOrigen.Name = "btAbrirOrigen";
            this.btAbrirOrigen.Size = new System.Drawing.Size(75, 23);
            this.btAbrirOrigen.TabIndex = 1;
            this.btAbrirOrigen.Text = "Cargar";
            this.btAbrirOrigen.UseVisualStyleBackColor = true;
            this.btAbrirOrigen.Click += new System.EventHandler(this.btAbrirOrigen_Click);
            // 
            // btAbrirDestino
            // 
            this.btAbrirDestino.Location = new System.Drawing.Point(410, 156);
            this.btAbrirDestino.Name = "btAbrirDestino";
            this.btAbrirDestino.Size = new System.Drawing.Size(75, 23);
            this.btAbrirDestino.TabIndex = 3;
            this.btAbrirDestino.Text = "Destino";
            this.btAbrirDestino.UseVisualStyleBackColor = true;
            this.btAbrirDestino.Click += new System.EventHandler(this.btAbrirDestino_Click);
            // 
            // txSalida
            // 
            this.txSalida.BackColor = System.Drawing.SystemColors.Window;
            this.txSalida.Location = new System.Drawing.Point(25, 158);
            this.txSalida.Name = "txSalida";
            this.txSalida.ReadOnly = true;
            this.txSalida.Size = new System.Drawing.Size(367, 20);
            this.txSalida.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbOtros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbPowerP);
            this.groupBox1.Controls.Add(this.lbExel);
            this.groupBox1.Controls.Add(this.lbWorld);
            this.groupBox1.Controls.Add(this.chkPowerPoint);
            this.groupBox1.Controls.Add(this.chkExel);
            this.groupBox1.Controls.Add(this.chkWorld);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elige los tipos de archivos que deses convertir";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::conversor2PDF.Properties.Resources.powerp;
            this.pictureBox4.Location = new System.Drawing.Point(190, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::conversor2PDF.Properties.Resources.interr;
            this.pictureBox3.Location = new System.Drawing.Point(293, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::conversor2PDF.Properties.Resources.excel;
            this.pictureBox2.Location = new System.Drawing.Point(102, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::conversor2PDF.Properties.Resources.word;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbOtros
            // 
            this.lbOtros.AutoSize = true;
            this.lbOtros.Location = new System.Drawing.Point(308, 101);
            this.lbOtros.Name = "lbOtros";
            this.lbOtros.Size = new System.Drawing.Size(13, 13);
            this.lbOtros.TabIndex = 8;
            this.lbOtros.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Otros";
            // 
            // lbPowerP
            // 
            this.lbPowerP.AutoSize = true;
            this.lbPowerP.Location = new System.Drawing.Point(207, 104);
            this.lbPowerP.Name = "lbPowerP";
            this.lbPowerP.Size = new System.Drawing.Size(13, 13);
            this.lbPowerP.TabIndex = 6;
            this.lbPowerP.Text = "0";
            // 
            // lbExel
            // 
            this.lbExel.AutoSize = true;
            this.lbExel.Location = new System.Drawing.Point(120, 104);
            this.lbExel.Name = "lbExel";
            this.lbExel.Size = new System.Drawing.Size(13, 13);
            this.lbExel.TabIndex = 5;
            this.lbExel.Text = "0";
            // 
            // lbWorld
            // 
            this.lbWorld.AutoSize = true;
            this.lbWorld.Location = new System.Drawing.Point(36, 104);
            this.lbWorld.Name = "lbWorld";
            this.lbWorld.Size = new System.Drawing.Size(13, 13);
            this.lbWorld.TabIndex = 4;
            this.lbWorld.Text = "0";
            // 
            // chkPowerPoint
            // 
            this.chkPowerPoint.AutoSize = true;
            this.chkPowerPoint.Location = new System.Drawing.Point(190, 84);
            this.chkPowerPoint.Name = "chkPowerPoint";
            this.chkPowerPoint.Size = new System.Drawing.Size(83, 17);
            this.chkPowerPoint.TabIndex = 2;
            this.chkPowerPoint.Text = "Power Point";
            this.chkPowerPoint.UseVisualStyleBackColor = true;
            // 
            // chkExel
            // 
            this.chkExel.AutoSize = true;
            this.chkExel.Location = new System.Drawing.Point(104, 84);
            this.chkExel.Name = "chkExel";
            this.chkExel.Size = new System.Drawing.Size(46, 17);
            this.chkExel.TabIndex = 1;
            this.chkExel.Text = "Exel";
            this.chkExel.UseVisualStyleBackColor = true;
            // 
            // chkWorld
            // 
            this.chkWorld.AutoSize = true;
            this.chkWorld.Location = new System.Drawing.Point(20, 84);
            this.chkWorld.Name = "chkWorld";
            this.chkWorld.Size = new System.Drawing.Size(54, 17);
            this.chkWorld.TabIndex = 0;
            this.chkWorld.Text = "World";
            this.chkWorld.UseVisualStyleBackColor = true;
            // 
            // txConsola
            // 
            this.txConsola.BackColor = System.Drawing.SystemColors.Window;
            this.txConsola.Location = new System.Drawing.Point(25, 238);
            this.txConsola.Multiline = true;
            this.txConsola.Name = "txConsola";
            this.txConsola.ReadOnly = true;
            this.txConsola.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txConsola.Size = new System.Drawing.Size(460, 103);
            this.txConsola.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consola";
            // 
            // btConvertir
            // 
            this.btConvertir.Location = new System.Drawing.Point(25, 184);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(141, 31);
            this.btConvertir.TabIndex = 7;
            this.btConvertir.Text = "Convertir";
            this.btConvertir.UseVisualStyleBackColor = true;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(251, 184);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(141, 31);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Word, Excel y PowerPoint a PDF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 9);
            this.label4.TabIndex = 10;
            this.label4.Text = "E.A.M.D";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txConsola);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAbrirDestino);
            this.Controls.Add(this.txSalida);
            this.Controls.Add(this.btAbrirOrigen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSOffice a PDF (Camanica - Pescanova)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrirOrigen;
        private System.Windows.Forms.Button btAbrirDestino;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPowerPoint;
        private System.Windows.Forms.CheckBox chkExel;
        private System.Windows.Forms.CheckBox chkWorld;
        private System.Windows.Forms.Label lbPowerP;
        private System.Windows.Forms.Label lbExel;
        private System.Windows.Forms.Label lbWorld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConvertir;
        private System.Windows.Forms.TextBox txConsola;
        private System.Windows.Forms.Label lbOtros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

