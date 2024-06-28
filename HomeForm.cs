using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondSecurityRFID
{
    public partial class HomeForm : Form
    {
        public string Token { get; set; }
        public static IUHF uhf = null;
        public bool isRuning = false;
        public bool isConnected = false;
        public bool isSending = false;
        private Thread EPC;

        public string GetIp() { return "192.168.2.202"; }
        public uint GetPort() { return 8888; }

        public HomeForm(string token)
        {
            InitializeComponent();
            Token = token;

            isConnected = Connect();
            
            if (isConnected)
            {
                EPC = new Thread(new ThreadStart(delegate { ReadEPC(); }));
                EPC.Start();
            }
            else
            {
                MessageBox.Show("Erro ao tentar se conectar com a leitora");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Test_Conn_Click(object sender, EventArgs e)
        {
            RefreshConnection();
        }

        private async void ReadEPC()
        {
            if (!uhf.Inventory())
                uhf.Inventory();
            isRuning = true;
            try
            {
                while (isRuning)
                {
                    try
                    {
                        UHFTAGInfo info = uhf.uhfGetReceived();
                        if (info != null)
                        {
                            info.Epc = info.Epc.Substring(0, 18);
                            Console.WriteLine("tag:" + info);

                            LBL_TAG.Invoke((MethodInvoker)delegate { LBL_TAG.Text = info.Epc; });

                            await SendRfidAsync(info.Epc, Token);

                        }
                        Thread.Sleep(100);
                    }
                    catch (Exception ex)
                    {
                        RefreshConnection();
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na ReadEPC prob on uhfGetReceived \n" + ex.InnerException);
            }
        }

        private bool Connect()
        {
            try
            {
                var Ip = GetIp();
                var Port = GetPort();
                uhf = UHFAPI.getInstance();
                isConnected = (uhf as UHFAPI).TcpConnect(Ip, Port);
                return isConnected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar se reconectar com a leitora\n Connect()\n" + ex.Message + "\n" + ex.InnerException);
                return false;
            }
        }

        private bool RefreshConnection()
        {
            try
            {
                var Ip = GetIp();
                var Port = GetPort();
                if (isConnected)
                {
                    uhf.StopGet();
                    uhf.Close();
                }

                isConnected = (uhf as UHFAPI).TcpConnect(Ip, Port);

                if (!isConnected)
                    isConnected = (uhf as UHFAPI).TcpConnect(Ip, Port);

                return isConnected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar se reconectar com a leitora\n RefreshConnection()\n" + ex.InnerException);
                return false;
            }
        }

        private async Task SendRfidAsync(string rfid, string token)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var rfidNumber = new { Numero = rfid };
                var content = new StringContent(JsonConvert.SerializeObject(rfidNumber), Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("https://apicondsecurity.azurewebsites.net/api/AbrePortao/ReceberRfid", content);
                // salvar todas as tags lidas e não repetidas em um arquivo txt na pasta C:\Temp\Tags
                //var path = @"C:\Temp\Tags\Tags.txt";
                //System.IO.File.AppendAllText(path, rfid + Environment.NewLine);
                //Console.WriteLine("RFID salvo em " + path);

                LBL_TAG_ENVIO.Invoke((MethodInvoker)delegate { LBL_TAG_ENVIO.Text = rfid; });
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("RFID enviado com sucesso.");
                    LBL_ENVIO.Invoke((MethodInvoker)delegate { LBL_ENVIO.Text = "RFID enviado com sucesso."; });
                }
                else
                {
                    Console.WriteLine("Falha ao enviar o RFID. Status: " + response.StatusCode);
                    LBL_ENVIO.Invoke((MethodInvoker)delegate { LBL_ENVIO.Text = "Falha ao enviar o RFID. Status: " + response.StatusCode; });
                }
            }
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void PB_Logo_Click(object sender, EventArgs e)
        {

        }

        private void LBL_TAG_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LBL_ENVIO_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LBL_TAG_ENVIO_Click(object sender, EventArgs e)
        {

        }

        private void LBL_Conexao_Click(object sender, EventArgs e)
        {

        }
    }
}
