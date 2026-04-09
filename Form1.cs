namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // [변수 선언]
        int totalCost = 0;

        // [가격표]
        int priceHam = 5000;
        int priceBulgogi = 4000;
        int priceChicken = 3000;
        int priceFries = 3500;
        int priceCoke = 2500;
        int priceCheese = 1500;
        int priceSource = 500; // 소스값은 300원으로 정했소!

        public Form1()
        {
            InitializeComponent();
            rbHam.AutoCheck = false;      // 잠시 자동 체크 기능을 끄고
            rbHam.Checked = false;       // 체크를 푼 다음에
            rbHam.AutoCheck = true;       // 다시 기능을 켜주는 것이제!

            rbBulgogi.Checked = false;
            rbChicken.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // 1. [과제 2] 버거 선택 검사
            if (rbHam.Checked)
            {
                totalCost += priceHam;
                listOrder.Items.Add("햄버거 추가: " + priceHam.ToString("N0") + "원");
            }
            else if (rbBulgogi.Checked)
            {
                totalCost += priceBulgogi;
                listOrder.Items.Add("불고기버거 추가: " + priceBulgogi.ToString("N0") + "원");
            }
            else if (rbChicken.Checked)
            {
                totalCost += priceChicken;
                listOrder.Items.Add("치킨버거 추가: " + priceChicken.ToString("N0") + "원");
            }
            else
            {
                lblError.Text = "메뉴를 선택하세요!";
                lblError.ForeColor = Color.Red;
                return;
            }

            // 2. 옵션 검사 (체크된 것만 누적)
            if (cbFries.Checked)
            {
                totalCost += priceFries;
                listOrder.Items.Add(" -> 감자튀김 추가: " + priceFries.ToString("N0") + "원");
            }
            if (cbCoke.Checked)
            {
                totalCost += priceCoke;
                listOrder.Items.Add(" -> 콜라 추가: " + priceCoke.ToString("N0") + "원");
            }
            if (cbCheese.Checked)
            {
                totalCost += priceCheese;
                listOrder.Items.Add(" -> 치즈 추가: " + priceCheese.ToString("N0") + "원");
            }
            // ⭐ 소스 추가 (새로 들어간 놈!)
            if (cbSource.Checked)
            {
                totalCost += priceSource;
                listOrder.Items.Add(" -> 소스 추가: " + priceSource.ToString("N0") + "원");
            }

            // 3. 합계 금액 업데이트
            lblTotal.Text = "총 금액 : " + totalCost.ToString("N0") + "원";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            totalCost = 0;
            listOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
            lblError.Text = "";

            rbHam.Checked = false;
            rbBulgogi.Checked = false;
            rbChicken.Checked = false;
            cbFries.Checked = false;
            cbCoke.Checked = false;
            cbCheese.Checked = false;
            cbSource.Checked = false; // 소스도 싹 꺼버리기!
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
