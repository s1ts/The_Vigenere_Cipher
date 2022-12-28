using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace protect_inf_LR1
{
    public partial class Form2 : Form
    {
        List<User> list = new List<User>();
        public Form2 ()
        {
            InitializeComponent();
            if (Serializer.IsFile("users.txt"))
            {
                list = Serializer.LoadFromFile("users.txt");
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form_Auth_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool user_is_existed = false;
            foreach (var user in list)
            {
                if (textBox1.Text == user.login && textBox2.Text == user.password)
                {
                    user_is_existed = true;
                    Form1 form1 = new Form1();
                    form1.Tag = this; // сохраняем ссылку в form2.Tag
                    this.Hide();
                    form1.Show();
                }
            }
            if (user_is_existed == false)
            {
                MessageBox.Show("Такого пользователя не существует, зарегистрируйтесь!");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit(); 
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
        User user = new User();

            foreach (var usr in list)
            {
                if (usr.login == textBox1.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    goto Marker1;
                }

            }
            user.login = textBox1.Text;
            user.password = textBox2.Text;
            list.Add(user);
            MessageBox.Show("Вы успешно зарегистрировались, используйте свой пароль и логин для входа в программу!");
        Marker1:
            textBox1.Text = "";
            textBox2.Text = "";

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveToFile("users.txt", list);
        }

        public void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
