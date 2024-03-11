namespace Abstract
{
    public partial class Form1 : Form
    {
        Triangle myTriangle = new Triangle(0, 0);
        Rectangle myRectangle = new Rectangle(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
           
            double baseValue = Convert.ToDouble(txtBaseTriangle.Text);
            double heightValue = Convert.ToDouble(txtHeightTriangle.Text);

            // Actualiza los valores de base y altura del triángulo
            myTriangle.Base = baseValue;
            myTriangle.Height = heightValue;

            // Calcula el área y muestra el resultado en el TextBox correspondiente
            txtAreaTriangle.Text = myTriangle.Area(myTriangle.Base, myTriangle.Height).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double baseValue = Convert.ToDouble(txtBaseRectangle.Text);
            double heightValue = Convert.ToDouble(txtHeightRectangle.Text);

           
            myRectangle.Base = baseValue;
            myRectangle.Height = heightValue;

            
            txtAreaRectangle.Text = myRectangle.Area(myRectangle.Base, myRectangle.Height).ToString();
        }
    }
}
