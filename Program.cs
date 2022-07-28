using InputUtilitys;
namespace Ex26_19_Takahashi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Box box = new Box(
                    InputUtility.InputFloat("幅"),
                    InputUtility.InputFloat("高さ"),
                    InputUtility.InputFloat("奥行"));
                
                /*
                 * 別バージョン
                var width = InputUtility.InputFloat("幅");
                var height = InputUtility.InputFloat("高さ");
                var depth = InputUtility.InputFloat("奥行");
                Box box = new Box(width, height, depth);
                */

                Console.WriteLine($"Boxの表面積={box.GetSurface()}\nBoxの体積={box.GetVlueme()}");

        }
    }

    class Box
    {
        float width;
        float height;
        float depth;

        public Box(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

        }

        public float GetSurface()
        {
            return (width * height + depth * height + width * depth) * 2;
        }

        public float GetVlueme()
        {
            return width * height * depth;
        }
    }
}