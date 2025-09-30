using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Kursach
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                FormGradientPainter fgp = new FormGradientPainter();
                Color color1 = Color.FromArgb(146, 99, 165);
                Color color2 = Color.FromArgb(125, 159, 207);
                Color color3 = Color.FromArgb(171, 206, 217);//166, 201, 212
                fgp.CreateLinearGradient(this, color1, color2, color3, e);
            }
            catch { }           
        }
        protected override void OnResize(EventArgs e)
        {//позволяет нормально работать градиенту при изменении размера формы
            try
            {
                base.OnResize(e);
                this.Invalidate();

            }
            catch { }
        }

        private void ToRegistrationlabel_MouseEnter(object sender, EventArgs e)
        {
            ToRegistrationlabel.ForeColor = Color.Blue;
        }

        private void ToRegistrationlabel_MouseLeave(object sender, EventArgs e)
        {
            ToRegistrationlabel.ForeColor = Color.Black;

        }

        private void ToRegistrationlabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            User user = new User(LogintextBox.Text, PasswordtextBox.Text);
            UserValidator userValidator = new UserValidator();
            if (userValidator.CheckValidation(user))
            {
                UserFileDB userFileDB = new UserFileDB();
                if (userFileDB.Exists(user))
                {
                    MessageBox.Show("Авторизация в качестве пользователя прошла успешно!");
                    MainForm mf = new MainForm(user);
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    Admin admin = new Admin(LogintextBox.Text, PasswordtextBox.Text);
                    if (userFileDB.Exists(admin))
                    {
                        MessageBox.Show("Авторизация в качестве администратора прошла успешно!");
                        MainForm mf = new MainForm(admin);
                        mf.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Пользователь не найден!");
                }
            }
            else MessageBox.Show("Некорректно введены поля!");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //создание и заполение БД пользователей 
            UserFileDB userDB = new UserFileDB();
            if (File.Exists(UserFileDB.name))//////////////////////////////////////////////////////////
            {
                userDB.CreateDB();
                var list = new StartUsers().GetStartUsers();
                foreach (User item in list)
                {
                    userDB.AddElement(item);
                }
            }
        }
    }
}
