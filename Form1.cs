using static System.Net.Mime.MediaTypeNames;

namespace EchoMessenger
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // txtMessage_TextChanged 와 listMessage_SelectedIndexChanged 안쓰는 함수 삭제

        private void btnSend_Click(object sender, EventArgs e)
        {
            //메세지가 공백이면 ListBox에 추가 안함
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;
            //메세지를 50자까지 받음
            if (txtMessage.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자까지 입력 가능합니다.");
                return;
            }

            //변수 message에 현재 시간과 Text를 합쳐서 저장 후listMessage에 추가
            //Trim()로 텍스트 앞 공백 제거
            string message = $"[{DateTime.Now:HH:mm:ss}] {txtMessage.Text.Trim()}";
            listMessage.Items.Add(message);

            //ListBox에 전송한 메세지 수 표시
            lblCount.Text = "현재 대화: " + listMessage.Items.Count+ "개";

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
