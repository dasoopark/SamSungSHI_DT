using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    //switch, case, break, default (switch)의 포멧
    // IF문과 함께 자주 사용되는 분기문
    // 많은 분기를 제어 할 경우 IF문 보다 깔끔하게 로직을 표현할 수 있다.
    public partial class Chap13_switch : Form
    {
        public Chap13_switch()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            //IF문으로 과일 이름, 가격 나타내기

            //1. 변수 설정
            string sFruitName = txtFruit.Text; //과일이름
            int iFruitPrice = 0; //과일가격

            if(sFruitName =="사과")
            {
                iFruitPrice = 2000;
            }
            else if(sFruitName =="복숭아")
            {
                iFruitPrice = 2000;
            }
            else if(sFruitName == "참외")
            {
                iFruitPrice = 2500;
            }
            else if(sFruitName == "딸기")
            {
                iFruitPrice = 18000;
            }
            else if(sFruitName =="수박")
            {
                iFruitPrice = 18000;
            }
            //iFruitPrice가 0으로 초기화 되어 진행 되므로 아래 else 구문은 구현 필요가 없다.
            //else
            //{
            //    //취급하는 과일을 입력하지 않은 경우
            //    iFruitPrice = 0;
            //}

            if(iFruitPrice ==0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iFruitPrice} 입니다.");
            }
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //switch를 통한 과일 이름과 가격 찾기.

            // 입력한 과일 이름 변수 등록하기.
            string sFruitName = txtFruit.Text;

            //과일의 가격 정수 변수,
            int iFruitPrice = 0;
            switch(sFruitName) //비교할 대상
            {
                case "복숭아": //가격이 같으면 묶어주면 break 안해줬기때문에 밑으로 흘러감
                case "사과":
                    iFruitPrice = 2000;
                    break;
                case "참외":
                    iFruitPrice = 2500;
                    break;
                case "수박":
                case "딸기":
                    iFruitPrice = 18000;
                    break;    
            }
            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iFruitPrice} 입니다.");
            }
        }
    }
}
