using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPOO
{
    public partial class Form1 : Form
    {
        Personaje jugador;
        Personaje enemigo;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPersonaje.Items.Add("Guerrero");
            cmbPersonaje.Items.Add("Mago");
            cmbPersonaje.Items.Add("Arquero");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (cmbPersonaje.Text)
            {
                case "Guerrero":
                    jugador = new Guerrero();
                    picPersonaje.Image = Image.FromFile("Images/guerrero.png");
                    break;
                case "Mago":
                    jugador = new Mago();
                    picPersonaje.Image = Image.FromFile("Images/mago.png");
                    break;
                case "Arquero":
                    jugador = new Arquero();
                    picPersonaje.Image = Image.FromFile("Images/arquero.png");
                    break;
            }
            enemigo = new Personaje("Enemigo", 100, 16);
            picEnemigo.Image = Image.FromFile("Images/enemigo.png");


            pbVidaJugador.Maximum = jugador.Vida;
            pbVidaJugador.Value = jugador.Vida;

            pbVidaEnemigo.Maximum = enemigo.Vida;
            pbVidaEnemigo.Value = enemigo.Vida;

            lblJugador.Text = $"Jugador: {jugador.Nombre}";
            lblVidaJugador.Text = $"Vida: {jugador.Vida}";
            lblVidaEnemigo.Text = $"Vida: {enemigo.Vida}";

            btnAtacar.Enabled = true;
            btnEspecial.Enabled = true;

            txtLog.Clear();
            txtLog.AppendText("¡Nueva partida iniciada!\n");


        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            int daño = jugador.Atacar();
            enemigo.Vida -= daño;
            txtLog.AppendText($"Jugador hizo {daño} de daño\n");

            pbVidaEnemigo.Value = Math.Max(0, enemigo.Vida);
            lblVidaEnemigo.Text = $"Vida: {enemigo.Vida}";


            int contra = rnd.Next(5, 30);
            jugador.Vida -= contra;
            txtLog.AppendText($"Enemigo hizo {contra} de daño\n");

            pbVidaJugador.Value = Math.Max(0, jugador.Vida);
            lblVidaJugador.Text = $"Vida: {jugador.Vida}";


            if (enemigo.Vida <= 0)
            {
                MessageBox.Show("¡Ganaste!");
                btnAtacar.Enabled = false;
                btnEspecial.Enabled = false;
            }
            else if (jugador.Vida <= 0)
            {
                MessageBox.Show("Perdiste...");
                btnAtacar.Enabled = false;
                btnEspecial.Enabled = false;
            }


        }

        private void btnEspecial_Click(object sender, EventArgs e)
        {
            int daño = jugador.Ataque * 2;
            enemigo.Vida -= daño;
            txtLog.AppendText($"Jugador usó ataque especial e hizo {daño} de daño\n");
            
            int contra = rnd.Next(5, 30)*2;
            jugador.Vida -= contra;
            txtLog.AppendText($"Enemigo hizo {contra} de daño\n");

            pbVidaEnemigo.Value = Math.Max(0, enemigo.Vida);
            lblVidaEnemigo.Text = $"Vida: {enemigo.Vida}";

            pbVidaJugador.Value = Math.Max(0, jugador.Vida);
            lblVidaJugador.Text = $"Vida: {jugador.Vida}";

            if (enemigo.Vida <= 0) 
            { 
            
                MessageBox.Show("¡Ganaste con ataque especial!");
            btnAtacar.Enabled = false;
            btnEspecial.Enabled = false;
            }
            else if (jugador.Vida <= 0)
            {
                MessageBox.Show("Perdiste de manera humillante...");
                btnAtacar.Enabled = false;
                btnEspecial.Enabled = false;
            }

        }
    }
}
