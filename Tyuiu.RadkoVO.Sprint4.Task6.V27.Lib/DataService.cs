using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RadkoVO.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 7);
            return mas.Length;
        }
    }
}
