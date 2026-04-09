# BurgerKiosk
🍔 C# WinForms 햄버거 키오스크 프로젝트
본 프로젝트는 C# Windows Forms를 활용하여 제작된 햄버거 주문 키오스크 시스템입니다. 사용자의 선택에 따른 실시간 금액 합산과 직관적인 예외 처리 기능을 포함하고 있습니다.

0️⃣ 프로젝트 개요
주요 기술: C#, WinForms UI, Git/GitHub

핵심 기능: 라디오버튼 및 체크박스를 이용한 메뉴 선택, 리스트박스를 활용한 주문 내역 누적, 라벨을 통한 동적 피드백 제공

1️⃣ 과제 1: 누적 주문 및 금액 계산 시스템
📸 실행 화면
<img width="594" height="436" alt="과제 1 ui " src="https://github.com/user-attachments/assets/aede2325-f337-4b14-9969-849bc5d524f6" />
<img width="593" height="441" alt="과제 1 주문하기 기능 1" src="https://github.com/user-attachments/assets/fe0a1bdb-1142-47e8-bc8a-69acd67d5320" />
<img width="592" height="438" alt="과제 1 주문하기 기능 2" src="https://github.com/user-attachments/assets/9ab88b3c-aef3-46e2-a0dc-4f330ac6dad4" />
<img width="597" height="436" alt="과제 1 주문하기 기능 3" src="https://github.com/user-attachments/assets/542692a6-0217-4e2d-9807-cfcca63fee2a" />
<img width="597" height="438" alt="과제 1 주문하기 기능 4" src="https://github.com/user-attachments/assets/e7aa9333-ec91-4665-85c8-bbba30f39205" />
<img width="597" height="438" alt="과제 1 초기화" src="https://github.com/user-attachments/assets/fb3b6ef6-8033-4378-8be3-e843c3bf3d17" />



📝 주요 구현 내용
주문 누적: ListOrder.Items.Add를 사용하여 이전 주문 내역을 유지한 채 새로운 메뉴를 추가할 수 있도록 구현했습니다.

실시간 합산: 전역 변수 totalCost를 활용하여 버튼 클릭 시마다 선택된 메뉴의 가격을 누적 계산합니다.

금액 가독성: ToString("N0") 형식을 적용하여 숫자를 천 단위 콤마(,)가 포함된 통화 형식으로 출력합니다.

2️⃣ 과제 2: 예외 처리 및 사용자 피드백 개선
📸 실행 화면
<img width="592" height="440" alt="과제 2 에러" src="https://github.com/user-attachments/assets/0b5281af-4cbc-49c2-aef5-371dcfdb4f73" />


📝 주요 구현 내용
메뉴 선택 검증: if 조건문을 통해 메인 메뉴(버거)가 선택되지 않았을 경우 주문이 진행되지 않도록 차단(return)합니다.

동적 라벨 피드백: 별도의 메시지 박스 대신, 하단의 **총 금액 라벨(lblTotal)**의 텍스트와 색상(ForeColor)을 직접 변경하여 오류 메시지를 출력합니다.

상태 복구: 오류 발생 후 메뉴를 다시 올바르게 선택하거나 [초기화] 버튼을 누르면 라벨의 색상과 텍스트가 정상 상태로 복원되도록 설계했습니다.
