namespace IMC_FORMS
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tx_nome = new TextBox();
            tx_idade = new TextBox();
            mask_cpf = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            num_peso = new NumericUpDown();
            num_altura = new NumericUpDown();
            comb_sexo = new ComboBox();
            lb_resultado = new Label();
            lb_resultado2 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_peso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_altura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 150);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 175);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 219);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 244);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 292);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "Altura(em m):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 268);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Peso(em kg):";
            label6.Click += label6_Click;
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(134, 147);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(177, 23);
            tx_nome.TabIndex = 6;
            tx_nome.TextChanged += tx_nome_TextChanged;
            // 
            // tx_idade
            // 
            tx_idade.Location = new Point(134, 216);
            tx_idade.Name = "tx_idade";
            tx_idade.Size = new Size(177, 23);
            tx_idade.TabIndex = 8;
            // 
            // mask_cpf
            // 
            mask_cpf.Location = new Point(134, 172);
            mask_cpf.Mask = "000,000,000-00";
            mask_cpf.Name = "mask_cpf";
            mask_cpf.Size = new Size(177, 23);
            mask_cpf.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(134, 383);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 383);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(198, 75);
            label7.Name = "label7";
            label7.Size = new Size(53, 30);
            label7.TabIndex = 15;
            label7.Text = "IMC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(149, 105);
            label8.Name = "label8";
            label8.Size = new Size(144, 17);
            label8.TabIndex = 16;
            label8.Text = "Índice de massa corporal";
            // 
            // num_peso
            // 
            num_peso.DecimalPlaces = 2;
            num_peso.Location = new Point(134, 266);
            num_peso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_peso.Name = "num_peso";
            num_peso.Size = new Size(177, 23);
            num_peso.TabIndex = 17;
            num_peso.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // num_altura
            // 
            num_altura.DecimalPlaces = 2;
            num_altura.Location = new Point(134, 290);
            num_altura.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_altura.Name = "num_altura";
            num_altura.Size = new Size(177, 23);
            num_altura.TabIndex = 18;
            num_altura.ValueChanged += num_altura_ValueChanged;
            // 
            // comb_sexo
            // 
            comb_sexo.FormattingEnabled = true;
            comb_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            comb_sexo.Location = new Point(134, 241);
            comb_sexo.Name = "comb_sexo";
            comb_sexo.Size = new Size(177, 23);
            comb_sexo.TabIndex = 19;
            comb_sexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(134, 316);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(62, 15);
            lb_resultado.TabIndex = 20;
            lb_resultado.Text = "Resultado:";
            // 
            // lb_resultado2
            // 
            lb_resultado2.AutoSize = true;
            lb_resultado2.Location = new Point(134, 198);
            lb_resultado2.Name = "lb_resultado2";
            lb_resultado2.Size = new Size(70, 15);
            lb_resultado2.TabIndex = 21;
            lb_resultado2.Text = "Verificação: ";
            lb_resultado2.Click += lb_resultado2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(lb_resultado2);
            Controls.Add(lb_resultado);
            Controls.Add(comb_sexo);
            Controls.Add(num_altura);
            Controls.Add(num_peso);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mask_cpf);
            Controls.Add(tx_idade);
            Controls.Add(tx_nome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "IMC";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)num_peso).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_altura).EndInit();
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
        private TextBox tx_nome;
        private TextBox tx_idade;
        private TextBox tx_sexo;
        private MaskedTextBox mask_cpf;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private NumericUpDown num_peso;
        private NumericUpDown num_altura;
        private ComboBox comb_sexo;
        private Label lb_resultado;
        private Label lb_resultado2;
    }
}