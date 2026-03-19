# (C# 코딩) 에코메신저
## 개요-C# 프로그래밍학습
- 1줄소개: 키보드 입력을 받아 출력하는 메신저
- 사용한플랫폼: -C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한컨트롤:-Label, TextBox, ListBox, Button
- 사용한기술과구현한기능:
- Label, TextBox, ListBox, Button를 사용해 UI 디자인
- Items.Add로 ListBox에 TextBox에 받은 string 값 추가
-txtMessage.Focus로 커서가 입력창에 자동으로 누르도록 구현
-if (e.KeyCode == Keys.Enter)로 엔터를 감지해 이벤트 실행
-string.IsNullOrWhiteSpace로 공백음 감지해 공백이 입력되는 것을 방지
- Trim()로 텍스트 앞 공백 제거
- {DateTime.Now:HH:mm:ss} 현재 시간을 받아와 시간,분,초를 두 자리 출력
- Count 속성을 통해 값을 가져와 텍스트 개수 확인
- 
## 실행화면(과제1)
- 과제1 코드의 실행 스크린샷
<img width="1713" height="920" alt="3주차 과제1" src="https://github.com/user-attachments/assets/3cc0e451-556f-4969-b851-5e54beeac194" />
- 과제 내용
- Label(표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치
- 전송 버튼 클릭시 TextBox의 텍스트를 ListBox의 항목(Items)으로 추가
- 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비
- 구현 내용과 기능 설명
- TextBox에 내용을 적고 전송 버튼을 누르면 ListBox에 내용이 출력
- 전송 후에 TextBox의 내용 초기화
-if (listMessage.SelectedIndex == -1)를 통해 예외값 지정
-.Items.RemoveAt로 리스트 삭제
## 실행화면(과제2)
-과제2 코드의 실행 스크린샷
<img width="1708" height="920" alt="3주차 과제 2" src="https://github.com/user-attachments/assets/74b7ceb4-01b9-4ea0-ab5a-e43c03b06e46" />

-과제 내용
-전송이 끝나면 입력 창에 남겨진 기존 메시지를 삭제
-전송 후에 마우스로 입력 창을 다시 클릭하지 않아도 되도록 커서를 자동으로 입력창에 위치
-마우스 클릭 대신 키보드의 Enter 키를 눌러도 메시지가 전송
-내용이 없는 빈문자열이나 공백(Space)만 있을 때는 메시지가 전송되지 않도록 방지
-구현 내용과 기능 설명
-전송 후에 커서가 입력창에 위치함
-키보드의 Enter키를 눌러도 전송함
-입력창에 공백을 입력하면 전송하지 않음

## 실행화면(과제3)
-과제3 코드의 실행 스크린샷
<img width="1702" height="921" alt="3주차 과제3-1" src="https://github.com/user-attachments/assets/ac545921-c5a5-4e32-a66f-5adeeaa51d5e" /><img width="1708" height="915" alt="3주차 과제3-2" src="https://github.com/user-attachments/assets/55d6e8b1-ca99-48a9-bb82-62e606f1bcde" />
-텍스트 공백 제거 전후

-과제 내용
-메시지 앞에 현재 시간을 자동으로 결합하여 리스트에 출력
-현재 리스트에 쌓인 총 메시지 개수를 계산하여 하단Label에 실시간으로 업데이트
-사용자가 입력한 메시지의 앞뒤 불필요한 공백을 Trim() 함수로 제거하여 저장
-구현 내용과 기능 설명
-ListBox에 전송한 메세지 수 표시
-현재 시간과 Text를 합쳐서 저장 후 출력함
-Trim()로 텍스트 앞 공백 제거

## 실행화면(과제4)

-과제4 코드의 실행 스크린샷

<img width="1706" height="915" alt="3주차 과제4" src="https://github.com/user-attachments/assets/12ff67dd-087c-463c-90e4-6b2b861411c3" />
<img width="1675" height="903" alt="3주차 과제4-3" src="https://github.com/user-attachments/assets/ae83151c-c37e-4cc3-a424-a1da1a916448" />
<img width="1682" height="912" alt="3주차 과제4-2" src="https://github.com/user-attachments/assets/d6a0632f-0ce1-4dfb-80f3-8e5922aad2b1" />


-과제 내용
- ListBox에서 특정메시지를 마우스로 클릭하고 '삭제' 버튼을 누르면 해당항목만 목록에서 제거 (단, 선택하지않고 삭제시 발생하는 에러를 예외처리)
- '대화 기록 삭제' 버튼을 클릭하면 리스트의 모든 내용을 한번에 지움
- 입력창에 글자 수를 50자로 제한하고, 초과 시 사용자에게 경고 메시지를 띄우거나 전송을 차단
-구현 내용과 기능 설명
-특정메시지를 마우스로 클릭하면 해당 목록 제거
-대화 기록 삭제를 누르면 모든 내용을지움
-글자수 50자 제한
