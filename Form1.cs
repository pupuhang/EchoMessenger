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
            //메세지가 공백이면 ListBox에 추가 안함
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;
            //Text를 ListBox에 추가
            listMessage.Items.Add(txtMessage.Text);
            //전송 후 TextBox 초기화
            txtMessage.Clear();
            //전송 후 TextBox에 커서 위치
            txtMessage.Focus();

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter키를 누르면 전송(btnSend_Click 발생)
            if (e.KeyCode == Keys.Enter){ 
                btnSend_Click(sender, e); 
            }
        }
    }
}
