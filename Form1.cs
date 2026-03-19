using static System.Net.Mime.MediaTypeNames;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Text를 ListBox에 추가
            listMessage.Items.Add(txtMessage.Text);
            //TextBox 초기화
            txtMessage.Clear();
        }
    }
}
