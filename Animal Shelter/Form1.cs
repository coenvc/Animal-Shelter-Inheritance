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
                Update();
                this.btnReserveCat.Enabled = true;
            }
            else if (this.cmbSpecies.Text == "Dog")
            {
                this.reservations.NewDog(txtName.Text, gender);
                Update();
                this.btnReserveDog.Enabled = true;
            }
        }

        private void btnReserveCat_Click(object sender, EventArgs e)
        {
            if (lbAnimals.SelectedItem is Cat)
            {
                Cat c = lbAnimals.SelectedItem as Cat;
                if (c != null)
                {
                    c.Reserve(txtReservor.Text);
                    Update();

                }
            }
            else
            {
                MessageBox.Show("Het door u gekozen dier is geen kat!");
            }
        }

        private void btnReserveDog_Click(object sender, EventArgs e)
        {
            if (lbAnimals.SelectedItem is Dog)
            {
                Dog d = lbAnimals.SelectedItem as Dog;
                if (d != null)
                {
                    d.Reserve(txtReservor.Text);
                    Update();

                }
            }
            else
            {
                MessageBox.Show("Het door u gekozen dier is geen Hond!");
            }
        }
        private void Update()
        {
            lbAnimals.Items.Clear();
            lbAnimals.Items.Clear();
            foreach (IAnimal animal in reservations.Animals)
            {
                if (animal is Cat)
                {
                    Cat cat = animal as Cat;
                    this.lbAnimals.Items.Add(cat);
                }
                if (animal is Dog)
                {
                    Dog dog = animal as Dog;

                    lbAnimals.Items.Add(dog);
                }
            }
        }
    }
}
