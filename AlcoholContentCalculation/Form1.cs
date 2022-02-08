using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlcoholContentCalculation
{
    public partial class Form1 : Form
    {
        //テキストボックス毎の変数を宣言
        private int alcoholMaterial;
        private int amountMaterial;
        private int noAlcohol;
        private int myWeight;
        private int SecondAlcoholMaterial;
        private int SecondAmountMaterial;
        private int SecondNoAlcohol;
        private int ThirdAlcoholMaterial;
        private int ThirdAmountMaterial;
        private int ThirdNoAlcohol;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void CalcButtonClicked(object sender, EventArgs e)
        {

            bool inputChangeWeight = int.TryParse(this.MyWeightBox.Text, out myWeight);

            bool changeSuccesses = ChangeSuccess();
            //もしChangeSuccess()がtrueなら
            if (changeSuccesses == true)
            {
                //1杯分の量を戻り値で返して、表示する
                int oneGlassAmount = OneGlassAmountCalc(amountMaterial,noAlcohol) + 
                                        OneGlassAmountCalc(SecondAmountMaterial,SecondNoAlcohol) +
                                            OneGlassAmountCalc(ThirdAmountMaterial,ThirdNoAlcohol);
                this.OneGlassAmountBox.Text = oneGlassAmount.ToString();

                //１杯分のアルコール度数を戻り値で返して、表示する
                double oneGlassAlcohol = OneGlassAlcoholCalc(alcoholMaterial,amountMaterial, noAlcohol ,
                                        SecondAlcoholMaterial,SecondAmountMaterial, SecondNoAlcohol,
                                        ThirdAlcoholMaterial, ThirdAmountMaterial,ThirdNoAlcohol);

                if (inputChangeWeight == true)
                {
                    //お酒が抜けるまでの時間を表示
                    this.AlcoholDisassembledTimeBox.Text = AlcoholDisassembledTimeCalc(oneGlassAmount,
                                                                oneGlassAlcohol, myWeight).ToString();
                }
            }
            else
            {
                InputErrorCheck(changeSuccesses);
            }
        }

        //テキストボックスの値がstring型からint型変数に代入出来ているか判定確認
        public bool ChangeSuccess()
        {
            bool changeSuccess = false;
            
           
            bool[] inputChangeSuccessArray = {int.TryParse(this.FirstAlcoholMaterialBox.Text, out alcoholMaterial),
                                            int.TryParse(this.FirstAmountMaterialBox.Text, out amountMaterial),
                                                int.TryParse(this.FirstNoAlcoholBox.Text, out noAlcohol)};

            bool[] SecondChangeSuccessArray = {int.TryParse(this.SecondAlcoholMaterialBox.Text, out SecondAlcoholMaterial),
                                             int.TryParse(this.SecondAmountMaterialBox.Text, out SecondAmountMaterial),
                                                 int.TryParse(this.SecondNoAlcoholBox.Text, out SecondNoAlcohol)};

            bool[] ThirdChangeSuccessArray = {int.TryParse(this.ThirdAlcoholMaterialBox.Text, out ThirdAlcoholMaterial),
                                            int.TryParse(this.ThirdAmountMaterialBox.Text, out ThirdAmountMaterial),
                                                int.TryParse(this.ThirdNoAlcoholBox.Text, out ThirdNoAlcohol)};

            
            
            if(inputChangeSuccessArray[0] == true && inputChangeSuccessArray[1] == true)
            {
                changeSuccess = true;
            }


            //もし材料の量のテキストボックスに「0」を入れるとメッセージボックスを表示
            if ((amountMaterial == 0 && this.FirstAmountMaterialBox.Text.Length == 1) ||
                    (SecondAmountMaterial == 0 && this.SecondAmountMaterialBox.Text.Length == 1) ||
                        (ThirdAmountMaterial == 0 && this.ThirdAmountMaterialBox.Text.Length == 1))
            {
                MessageBox.Show("amountの数値に0を入力しないでください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                changeSuccess = false;
            }

            return changeSuccess;
        }


        //1杯分の量を計算するメソッド
        public int OneGlassAmountCalc(int amountMaterial,int noAlcohol)
        {
            int oneGlassAmount = (amountMaterial + noAlcohol);
            return oneGlassAmount;
        }

        //１杯分のアルコール度数を計算するメソッド
        public double OneGlassAlcoholCalc(int alcoholMaterial, int amountMaterial,int noAlcohol,
                                        int SecondAlcoholMaterial,int SecondAmountMaterial , int SecondNoAlcohol,
                                            int ThirdAlcoholMaterial, int ThirdAmountMaterial, int ThirdNoAlcohol)
        {
            double oneGlassAlcohol = Math.Round((double)((alcoholMaterial * amountMaterial) + (SecondAlcoholMaterial * SecondAmountMaterial)
                                    + (ThirdAlcoholMaterial * ThirdAmountMaterial)) / (amountMaterial + SecondAmountMaterial + ThirdAmountMaterial 
                                        +  noAlcohol + SecondNoAlcohol + ThirdNoAlcohol),0);
            this.OneGlassAlcoholBox.Text = oneGlassAlcohol.ToString();
            return oneGlassAlcohol;
        }

        //1時間にアルコールが分解されるまでの時間wを求めるメソッド
        public double AlcoholDisassembledTimeCalc(int oneGlassAmount, double oneGlassAlcohol,int myWeight)
        {
           
            //アルコールの比重を初期化
            double alcoholSpecificGravity = 0.8;

            //人が１時間にアルコールを分解出来る量を初期化
            double humanAlcoholDisassembleAmmount = 0.1;

            //％を小数にする変数
            double persentChangeDoubleNum = 100;
            //①飲酒量×アルコール度数×アルコール比重=アルコール量
            double alcoholAmount = Math.Round((double)oneGlassAmount * oneGlassAlcohol * alcoholSpecificGravity / persentChangeDoubleNum,0);
            this.AlcoholAmountBox.Text = alcoholAmount.ToString();
            //②自分の体重×人が１時間にアルコールを分解出来る=1時間に分解できるアルコール量
            double hourAlcoholDisassembleAmount = myWeight * humanAlcoholDisassembleAmmount;
            //①÷②＝アルコールが分解されるまでの時間
            double hourAlcoholDisassembledTime = Math.Round(alcoholAmount / hourAlcoholDisassembleAmount,1);

            return hourAlcoholDisassembledTime;
        }

        //エラー確認メソッド
        public void InputErrorCheck(bool changeSuccesses)
        {
            if (!changeSuccesses == true)
            {
                //そうでなければエラーの吹き出しを表示
                MessageBox.Show("オレンジ色は全て入力してください", "エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        //メニューバーから終了するメソッド
        private void ExitApplicationClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        //データの"代表的なお酒"をクリック
        private void MajorRiquorClicked(object sender, EventArgs e)
        {
            MajorRiquor majorRiquor = new MajorRiquor();
            majorRiquor.Show();
        }

        //メニューバーのデータをクリックするとFormを表示するメソッド
        private void UsingCalcClicked(object sender, EventArgs e)
        {
            AlcoholCalculation alcoholCalculation = new AlcoholCalculation();
            alcoholCalculation.Show();
        }
        //終了確認をするメソッド
        private void endChecking(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了してもいいですか？", "確認",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
        //メニューバーのデータの”お酒について”をクリックした時
        private void RiquorAboutClicked(object sender, EventArgs e)
        {
            RiquorAbout riquorAbout = new RiquorAbout();
            riquorAbout.Show();
        }

        //Resetボタンを押した時、int型は「0」にstring型は「""」を代入
        private void ResetClicked(object sender, EventArgs e)
        {
            
            this.FirstAlcoholMaterialBox.Text = "";
            this.FirstAmountMaterialBox.Text = "";
            this.FirstNoAlcoholBox.Text = "";
            this.SecondAlcoholMaterialBox.Text = "";
            this.SecondAmountMaterialBox.Text = "";
            this.SecondNoAlcoholBox.Text = "";
            this.ThirdAlcoholMaterialBox.Text = "";
            this.ThirdAmountMaterialBox.Text = "";
            this.ThirdNoAlcoholBox.Text = "";
            this.MyWeightBox.Text = "";
            this.OneGlassAlcoholBox.Text = "";
            this.OneGlassAmountBox.Text = "";
            this.AlcoholAmountBox.Text = "";
            this.AlcoholDisassembledTimeBox.Text = "";
            //フィールド変数をint型の配列に格納し、全ての値を削除
            int[] allVariableArray = {this.alcoholMaterial,this.amountMaterial,this.noAlcohol,
                                    this.SecondAlcoholMaterial,this.SecondAmountMaterial,this.SecondNoAlcohol,
                                        this.ThirdAlcoholMaterial,this.ThirdAmountMaterial,this.ThirdNoAlcohol,this.myWeight};
            Array.Clear(allVariableArray, 0, 10);
            /*string[] allTextBox = {this.FirstAlcoholMaterialBox.Text,this.FirstAmountMaterialBox.Text,this.FirstNoAlcoholBox.Text,
                                    this.SecondAlcoholMaterialBox.Text,this.SecondAmountMaterialBox.Text,this.SecondNoAlcoholBox.Text,
                                        this.ThirdAlcoholMaterialBox.Text,this.ThirdAmountMaterialBox.Text,this.ThirdNoAlcoholBox.Text};
            for(int i = 0; i < allTextBox.Length; i++)
            {
                allTextBox[i] = "";
            }*/
        }

       
    }
}
