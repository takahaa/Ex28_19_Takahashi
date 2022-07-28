using InputUtilitys;
namespace Ex26_19_Takahashi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("28だよ");
            TriangularPrism trianglerprism = new TriangularPrism(
                InputUtility.InputFloat("辺1の長さ"),
                InputUtility.InputFloat("辺2の長さ"),
                InputUtility.InputFloat("辺3の長さ"));

            /*
             * 別バージョン
            var width = InputUtility.InputFloat("幅");
            var height = InputUtility.InputFloat("高さ");
            var depth = InputUtility.InputFloat("奥行");
            Box box = new Box(width, height, depth);
            */

            Console.WriteLine($"Boxの表面積={trianglerprism.GetSurface()}\nBoxの体積={trianglerprism.GetVlueme()}");

        }
    }

    /*class TriangularPrism
    {
        float bottom;
        float triangleHeigth;
        float height;

        public TriangularPrism(float edge1, float edge2, float edge3)
        {
            this.bottom = bottom;
            this.triangleHeigth = triangleHeight;
            this.height = height;
        }

        public TriangularPrism(float edge1, float edge2, int angle)
        {
            this.bottom = bottom;
            this.triangleHeigth = triangleHeight;
            this.height = height;
        }

        public TriangularPrism(float edge1, int angle1, int angle2)
        {
            this.bottom = bottom;
            this.triangleHeigth = triangleHeight;
            this.height = height;
        }


        public float GetSurface()
        {
            return bottom * triangleHeigth + (bottom + triangleHeigth + (float)Math.Sqrt(bottom * bottom + triangleHeigth * triangleHeigth)) * height;
        }

        public float GetVlueme()
        {
            return bottom * triangleHeigth / 2 * height;
        }
    }*/

}