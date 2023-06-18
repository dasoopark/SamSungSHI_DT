//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;
//using system.windows.forms;

//namespace myfirstcsharp
//{
  
//    {
//        // 기존 코드 유지
//        // ...

//        private void btnorderreceive_click(object sender, eventargs e)
//    {
//        bool any_orders_placed = checkanyorders();
//        dictionary<string, int> fruits = getlistoffruits();

//        if (!any_orders_placed)
//        {
//            messagebox.show("발주 내역이 없습니다.");
//            return;
//        }

//        double order_cost = calculateordercost();

//        if ((order_cost > ilmancash))
//        {
//            messagebox.show("가게금액이 부족합니다. 발주를 할 수 없습니다.");
//        }
//        else
//        {
//            processorder();
//        }
//        resetorderquantities();
//    }

//    private void btnresetorder_click(object sender, eventargs e)
//    {
//        resetorderquantities();
//    }

//    private void btnviewindividualmargin_click(object sender, eventargs e)
//    {
//        string fruit = getselectedfruit();
//        int margin = calculatemargin(fruit);
//        messagebox.show($"{fruit}의 마진금액은 {margin}원 입니다.");
//    }

//    private void btnviewtotalmargin_click(object sender, eventargs e)
//    {
//        int totalmargin = calculatetotalmargin();
//        messagebox.show($"총 마진 금액은 {totalmargin}원 입니다.");
//    }

//    // 기타 추가 된 메소드
//    //...

//    private bool checkanyorders()
//    {
//        // 주문 내역이 있는지 확인합니다.
//        return orderhistory.count > 0;
//    }

//    private dictionary<string, int> getlistoffruits()
//    {
//        // 과일 목록과 가격을 반환합니다.
//        return new dictionary<string, int>
//            {
//                {"사과", 2000},
//                {"참외", 2500},
//                {"수박", 18000}
//            };
//    }

//    private double calculateordercost()
//    {
//        // 주문 비용을 계산합니다.
//        double cost = 0;
//        foreach (var item in orderhistory)
//        {
//            cost += item.value;
//        }
//        return cost;
//    }

//    private void processorder()
//    {
//        // 주문 처리를 진행합니다.
//        messagebox.show("발주가 완료되었습니다.");
//        ilmancash -= (int)calculateordercost();
//        orderhistory.clear();
//    }

//    private void resetorderquantities()
//    {
//        // 주문 수량을 초기화합니다.
//        lblapplecount.text = "0";
//        lblmeloncount.text = "0";
//        lblwatermeloncount.text = "0";
//    }

//    private string getselectedfruit()
//    {
//        // 선택된 과일을 반환합니다.
//        if (rbtnapple.checked) return "사과";
//            if (rbtnmelon.checked) return "참외";
//                if (rbtnwatermelon.checked) return "수박";
//                    return "";
//                    }

//                private int calculatemargin(string fruit)
//                {
//                    // 특정 과일의 마진 금액을 계산합니다.
//                    if (purchasehistory.containskey(fruit) && orderhistory.containskey(fruit))
//                    {
//                        return orderhistory[fruit] - purchasehistory[fruit];
//                    }
//                    return 0;
//                }

//                private int calculatetotalmargin()
//                {
//                    // 총 마진 금액을 계산합니다.
//                    int totalmargin = 0;
//                    var fruits = getlistoffruits();
//                    foreach (var fruit in fruits.keys)
//                    {
//                        totalmargin += calculatemargin(fruit);
//                    }
//                    return totalmargin;
//                }
//                }
//            }
