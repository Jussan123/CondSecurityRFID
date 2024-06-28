using CondSecurityRFID.Store.Login;
using CondSecurityRFID.Store.Login.Dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondSecurityRFID
{
    public partial class LoginForm : Form
    {
        public string Token { get; set; }
        public string GetToken() { return Token; }

        public LoginForm()
        {
            InitializeComponent();
            //TB_PASS.Text = "jussan123";
            //TB_USER.Text = "jussan@meu3email.com";
        }                                            

      

        private async void Btn_Login_Click(object sender, EventArgs e)
        {
            LBL_ResultLogin.Text = "";
            if (ValidForm())
                await EnviaLogin();

        }

        public bool ValidForm()
        {
            var senha = TB_PASS.Text.Trim();
            var email = TB_USER.Text.Trim();
            bool valid = true;
            string message = "";

            if (string.IsNullOrEmpty(email))
            {
                message = "Informe o email!\n";
                valid = false;
            }

            if (string.IsNullOrEmpty(senha))
            {
                message = "Informe a senha!\n";
                valid = false;
            }

            if (!IsValidMail(email))
            {
                message = "Email inválido!";
                valid = false;
            }

            if (!valid)
                MessageBox.Show(message);

            return valid;
        }


        public async Task EnviaLogin()
        {
            GetLoginOutputDto loginOutput = new GetLoginOutputDto();
            loginOutput.Senha = TB_PASS.Text.Trim();
            loginOutput.Email = TB_USER.Text.Trim();

            var result = await LoginAppService.Login(loginOutput);

            if (result.Result != null)
            {
                Token = result.Result.Token;
                MessageBox.Show("Login efetuado com sucesso!");
                AbrirForm(new HomeForm(Token));
                // Abrir proximo Formulario
            }
            else
            {
                LBL_ResultLogin.Text = result.Message.Replace("\"", "").Replace(".", "");
            }
        }

        private void AbrirForm(object form)
        {
            this.Hide();
            Form fh = form as Form;
            fh.Closed += (s, args) => this.Close();
            fh.Show();
        }

        public bool IsValidMail(string address)
        {
            if (string.IsNullOrEmpty(address)) { return false; }

            EmailAddressAttribute e = new EmailAddressAttribute();
            return e.IsValid(address);
        }

        private void TB_USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_Header_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
