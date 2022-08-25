using InputUtilitys;
namespace Ex26_19_Takahashi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TriangularPrism trianglerprism = new TriangularPrism(0, 0, 0);

            Console.WriteLine("1、底面の底辺・高さから三角形の面積を求める");
            Console.WriteLine("2、底面の３辺の長さから三角形の面積を求める");

            int num = Check();

            if (num == 1)
            {
                    trianglerprism = new TriangularPrism(
                    InputUtility.InputFloat("底面の底辺の長さ"),
                    InputUtility.InputFloat("底面の高さ"),
                    InputUtility.InputFloat("柱の長さ"));
            }
            else if (num == 2){
                    trianglerprism = new TriangularPrism(
                    InputUtility.InputFloat("底面の辺の長さ1"),
                    InputUtility.InputFloat("底面の辺の長さ2"),
                    InputUtility.InputFloat("底面の辺の長さ3"),
                    InputUtility.InputFloat("柱の長さ"));
            }
            Console.WriteLine($"三角柱の表面積={trianglerprism.GetSurface()}\n三角柱の体積={trianglerprism.GetVlueme()}");
        }

        static int Check()   //入力数値チェック
        {
            while (true)
            {
                Console.WriteLine("1か2を選択してください。");

                try
                {
                    int i = int.Parse(Console.ReadLine());

                    if (i != 1 && i != 2)
                    {
                        Console.WriteLine("指定数値の範囲外です");
                        continue;
                    }
                    else
                    {
                        return i;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("入力エラー:例外の数値・文字列が入力されました。");

                }
            }
        }
    }

    class TriangularPrism
    {
        float BottomLength;
        float length1;
        float length2;
        float length3;
        float BottomHeight;
        float height;

        float keep;
        float bottom;
        float side;

        public TriangularPrism(float BottomLength, float BottomHeight, float height)
        {
            this.BottomLength = BottomLength;
            this.BottomHeight = BottomHeight;
            this.height = height;

            bottom = BottomLength * BottomHeight / 2;
            side = BottomLength + BottomHeight + (float)Math.Sqrt(BottomLength * BottomLength + BottomHeight * BottomHeight) * height;
        }

        public TriangularPrism(float length1, float length2, float length3, float height)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
            this.height = height;

            keep = (length1 + length2 + length3)/ 2;
            bottom = (float)Math.Sqrt(keep*((keep - length1)*(keep - length2)*(keep - length3)));
            side = (length1 + length2 + length3) * height;
        }

        public float GetSurface()
        {
            return bottom * 2 + side;
        }

        public float GetVlueme()
        {
            return bottom * height;
        }
    }
}