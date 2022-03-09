
namespace AgendaElectronica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLado = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscarUserC1 = new AgendaElectronica.BuscarUserC();
            this.modificarUserC1 = new AgendaElectronica.ModificarUserC();
            this.insertarUserC1 = new AgendaElectronica.InsertarUserC();
            this.eliminarUserC1 = new AgendaElectronica.EliminarUserC();
            this.panelLado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLado
            // 
            this.panelLado.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelLado.Controls.Add(this.button4);
            this.panelLado.Controls.Add(this.pictureBox1);
            this.panelLado.Controls.Add(this.button3);
            this.panelLado.Controls.Add(this.button1);
            this.panelLado.Controls.Add(this.button2);
            this.panelLado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLado.Location = new System.Drawing.Point(0, 0);
            this.panelLado.Name = "panelLado";
            this.panelLado.Size = new System.Drawing.Size(200, 678);
            this.panelLado.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::AgendaElectronica.Properties.Resources.Files_Cancel_File_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "       Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::AgendaElectronica.Properties.Resources.Users_User_Male_3_icon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::AgendaElectronica.Properties.Resources.Very_Basic_Search_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "     Buscar/Listar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AgendaElectronica.Properties.Resources.Programming_Add_Property_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insertar nuevo ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::AgendaElectronica.Properties.Resources.Users_Edit_User_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "          Modificar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buscarUserC1);
            this.panel1.Controls.Add(this.modificarUserC1);
            this.panel1.Controls.Add(this.insertarUserC1);
            this.panel1.Controls.Add(this.eliminarUserC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 678);
            this.panel1.TabIndex = 4;
            // 
            // buscarUserC1
            // 
            this.buscarUserC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarUserC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarUserC1.Location = new System.Drawing.Point(0, 0);
            this.buscarUserC1.Name = "buscarUserC1";
            this.buscarUserC1.Size = new System.Drawing.Size(978, 678);
            this.buscarUserC1.TabIndex = 2;
            this.buscarUserC1.Load += new System.EventHandler(this.buscarUserC1_Load);
            // 
            // modificarUserC1
            // 
            this.modificarUserC1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modificarUserC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificarUserC1.Location = new System.Drawing.Point(0, 0);
            this.modificarUserC1.Name = "modificarUserC1";
            this.modificarUserC1.Size = new System.Drawing.Size(978, 678);
            this.modificarUserC1.TabIndex = 1;
            // 
            // insertarUserC1
            // 
            this.insertarUserC1.BackColor = System.Drawing.Color.Orange;
            this.insertarUserC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertarUserC1.Location = new System.Drawing.Point(0, 0);
            this.insertarUserC1.Name = "insertarUserC1";
            this.insertarUserC1.Size = new System.Drawing.Size(978, 678);
            this.insertarUserC1.TabIndex = 0;
            // 
            // eliminarUserC1
            // 
            this.eliminarUserC1.BackColor = System.Drawing.Color.LightPink;
            this.eliminarUserC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eliminarUserC1.Location = new System.Drawing.Point(0, 0);
            this.eliminarUserC1.Name = "eliminarUserC1";
            this.eliminarUserC1.Size = new System.Drawing.Size(978, 678);
            this.eliminarUserC1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Electronica";
            this.panelLado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private BuscarUserC buscarUserC1;
        private ModificarUserC modificarUserC1;
        private InsertarUserC insertarUserC1;
        private EliminarUserC eliminarUserC1;
    }
}

