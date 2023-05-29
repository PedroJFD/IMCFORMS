namespace IMC_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            mask_cpf.Clear();
            tx_idade.Clear();
            comb_sexo.ResetText();
            num_peso.ResetText();
            num_altura.ResetText();
            lb_resultado.ResetText();
            lb_resultado2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            string idade = tx_idade.Text;
            string sexo = comb_sexo.Text;
            double peso = Convert.ToDouble(num_peso.Text);
            double altura = Convert.ToDouble(num_altura.Text);


            Pessoa pedro = new Pessoa(nome, cpf, idade, sexo, peso, altura);

            (double imc, string classi, string grau) = pedro.CalcularIMC();

            lb_resultado.Text = $"O IMC é: {imc.ToString("0.00")} \n{classi} \n{grau}";

            lb_resultado2.Text = $"Cpf: {Validacoes.ValidaCPF(cpf)}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_resultado2_Click(object sender, EventArgs e)
        {

        }

        private void num_altura_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}