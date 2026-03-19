namespace EchoMessenger
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listMessage = new ListBox();
            lblName = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // listMessage
            // 
            listMessage.FormattingEnabled = true;
            listMessage.Location = new Point(12, 74);
            listMessage.Name = "listMessage";
            listMessage.Size = new Size(776, 304);
            listMessage.TabIndex = 0;
            listMessage.SelectedIndexChanged += listMessage_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblName.ForeColor = SystemColors.Highlight;
            lblName.Location = new Point(12, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(251, 41);
            lblName.TabIndex = 1;
            lblName.Text = "Echo Messenger";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 398);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(607, 27);
            txtMessage.TabIndex = 2;
            txtMessage.TextChanged += txtMessage_TextChanged;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.GreenYellow;
            btnSend.Location = new Point(625, 384);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(163, 54);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(lblName);
            Controls.Add(listMessage);
            Name = "Form";
            Text = "Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMessage;
        private Label lblName;
        private TextBox txtMessage;
        private Button btnSend;
    }
}
