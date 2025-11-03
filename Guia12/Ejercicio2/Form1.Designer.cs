namespace Ejercicio2
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tbCapacidad = new TextBox();
            listBox1 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            listBox2 = new ListBox();
            button6 = new Button();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbCapacidad);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Lista de Autos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 42);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Capacidad";
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(281, 60);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(100, 23);
            tbCapacidad.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 349);
            listBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(281, 291);
            button4.Name = "button4";
            button4.Size = new Size(100, 63);
            button4.TabIndex = 3;
            button4.Text = "Cerrar Camion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(281, 229);
            button3.Name = "button3";
            button3.Size = new Size(100, 56);
            button3.TabIndex = 2;
            button3.Text = "Descargar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 167);
            button2.Name = "button2";
            button2.Size = new Size(100, 56);
            button2.TabIndex = 1;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(281, 104);
            button1.Name = "button1";
            button1.Size = new Size(100, 57);
            button1.TabIndex = 0;
            button1.Text = "Crear Camion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(448, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 39);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 7;
            label3.Text = "Lista de Recibidos";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 59);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(235, 349);
            listBox2.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(247, 126);
            button6.Name = "button6";
            button6.Size = new Size(75, 57);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(247, 59);
            button5.Name = "button5";
            button5.Size = new Size(75, 60);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        public DateTimePicker dateTimePicker1;
        public TextBox tbCapacidad;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
