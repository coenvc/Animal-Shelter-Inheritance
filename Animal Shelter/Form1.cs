using System;
using System.Windows.Forms;
using Animal_Shelter.Animals;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        private Reservation reservations = new Reservation();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBadHabits.Enabled = this.cmbSpecies.Text == "Cat";
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Gender gender = radMale.Checked ? Gender.Male : Gender.Female;

            if (this.cmbSpecies.Text == "Cat")
            {
                this.reservations.NewCat(
                    txtName.Text, gender, txtBadHabits.Text);
                this.lblCat.Text = this.reservations.Cat.ToString();
                this.btnReserveCat.Enabled = true;
            }
            else if (this.cmbSpecies.Text == "Dog")
            {
                this.reservations.NewDog(txtName.Text, gender);
                this.lblDog.Text = this.reservations.Dog.ToString();
                this.btnReserveDog.Enabled = true;
            }
        }

        private void btnReserveCat_Click(object sender, EventArgs e)
        {
            if (this.reservations.Cat != null)
            {
                this.reservations.Cat.Reserve(txtReservor.Text);
                this.lblCat.Text = this.reservations.Cat.ToString();
                this.btnReserveCat.Enabled = false;
            }
        }

        private void btnReserveDog_Click(object sender, EventArgs e)
        {
            if (this.reservations.Dog != null)
            {
                this.reservations.Dog.Reserve(txtReservor.Text);
                this.lblDog.Text = this.reservations.Dog.ToString();
                this.btnReserveDog.Enabled = false;
            }
        }
    }
}
