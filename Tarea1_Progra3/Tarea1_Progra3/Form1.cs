namespace Tarea1_Progra3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ejecucion del boton
        private void Procesar_button_Click(object sender, EventArgs e)
        {
            int num = numero_textBox.Text.Length;
            MessageBox.Show(tipo_numero(num));
            MessageBox.Show(Definir_primo(num));


        }

        //funcion de definir par o impar
        public static string tipo_numero(int  num)
        {
            float type_num = num;
            string num_par_imp = "";

            if (type_num % 2 == 0)
            {
                num_par_imp = "par";
            }
            else//Ingeniero, no se si es error de logica, pero siempre da par en el formulario y se no se porque, si me dice en los comentarios de la tarea se lo agradeceria :D
            {
                num_par_imp = "Impar";
            }

            return num_par_imp;
        }



        //Segunda funcion para definir numero primo


        public static string Definir_primo(int num)
        {
            string num_primo = "";
            int cont = 0;
            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    cont++;
                }
            }
            if (cont > 2)
            {
                num_primo = "El numero es primo";
            }
            else
            {
                num_primo = "El numero no es primo";
            }
            return num_primo;
        }
    }
}

//Gerson David Garcia Calderon
//Seccion 1400 Lenguaje de Programacion III
//2019-1003-218