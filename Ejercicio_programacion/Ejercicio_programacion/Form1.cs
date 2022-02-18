namespace Ejercicio_programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String[] arreglo_name = new string[1];
        public int[] arreglo_edad = new int[1];
        private void agregar_button_Click(object sender, EventArgs e)
        {

            
            String name = name_textBox.Text;
            int edad = Convert.ToInt32(age_textBox.Text);
           

            for (int i = 0; i < arreglo_edad.Length; i++)
            {
                arreglo_name[i] = name;
                arreglo_edad[i] = edad;
            }
            for (int i = 0; i < arreglo_edad.Length; i++)
            {
                registro_estudiantes_listBox.Items.Add(" Estudiante " + arreglo_name[i] + " con la edad : " + arreglo_edad[i]);
            }
        }

       
    }
}