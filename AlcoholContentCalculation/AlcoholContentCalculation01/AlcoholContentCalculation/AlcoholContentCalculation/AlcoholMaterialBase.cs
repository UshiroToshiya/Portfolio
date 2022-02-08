using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholContentCalculation
{
    class AlcoholMaterialBase
    {
        private int alcoholMaterial;
        private int amountMaterial;
        private int noAlcohol;
      

       
        public int NoAlcohol { get => noAlcohol; set => noAlcohol = value; }
        public int NoAlcohol1 { get => noAlcohol; set => noAlcohol = value; }
        public int AlcoholMaterial { get => alcoholMaterial; set => alcoholMaterial = value; }

        public AlcoholMaterialBase(int alcoholMaterial, int amountMaterial, int noAlcohol)
        {
            this.alcoholMaterial = alcoholMaterial;
            this.amountMaterial = amountMaterial;
            this.noAlcohol = noAlcohol;
        }
        //1杯分の量を計算するメソッド
        public int OneGlassAmountCalc(int amountMaterial, int noAlcohol)
        {
            int oneGlassAmount = (amountMaterial + noAlcohol);
            return oneGlassAmount;
        }

        //１杯分のアルコール度数を計算するメソッド
        public int OneGlassAlcoholCalc(int alcoholMaterial, int amountMaterial, int noAlcohol)
        {
            int oneGlassAlcohol = (alcoholMaterial * amountMaterial) / (amountMaterial + noAlcohol);
            return oneGlassAlcohol;
        }

        //1時間にアルコールが分解されるまでの時間wを求めるメソッド
        public double AlcoholDisassembledTimeCalc(int oneGlassAmount, int oneGlassAlcohol, int myWeight)
        {

            //アルコールの比重を初期化
            double alcoholSpecificGravity = 0.8;

            //人が１時間にアルコールを分解出来る量を初期化
            double humanAlcoholDisassembleAmmount = 0.1;

            //％を小数にする変数
            double persentChangeDoubleNum = 100;
            //①飲酒量×アルコール度数×アルコール比重=アルコール量
            double alcoholAmount = oneGlassAmount * oneGlassAlcohol * alcoholSpecificGravity / persentChangeDoubleNum;
            
            //②自分の体重×人が１時間にアルコールを分解出来る=1時間に分解できるアルコール量
            double hourAlcoholDisassembleAmount = myWeight * humanAlcoholDisassembleAmmount;
            //①÷②＝アルコールが分解されるまでの時間
            double hourAlcoholDisassembledTime = Math.Round(alcoholAmount / hourAlcoholDisassembleAmount, 2);

            return hourAlcoholDisassembledTime;
        }
    }
}
