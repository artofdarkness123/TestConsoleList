namespace ConsoleApp1
{
    public class HexagonHelper
    {
        /// <summary>
        /// The the area of a hgexagon given the diagonal
        /// </summary>
        /// <param name="diagonal">The distance from 1 120degree angle to another.</param>
        /// <returns></returns>
        public static decimal GetAreaGivenDiag(decimal diagonal)
        {
            return (3 * (decimal)Math.Sqrt(3) * (decimal)Math.Pow((double)diagonal, 2)) / 8;
        }

        /// <summary>
        /// The the area of a hgexagon given the side
        /// </summary>
        /// <param name="side">the length of 1 side</param>
        /// <returns></returns>
        public static decimal GetSquareGivenSide(decimal side)
        {
            return ((3 * (decimal)Math.Sqrt(3)) / 2) * (decimal)Math.Pow((double)side, 2);
        }

        public static decimal GetSideFromArea(decimal area)
        {
            double temp = (double)(2 * (area / 9));
            return (decimal)(Math.Pow(3, 0.25) * Math.Sqrt(temp));
        }

        //public static decimal GetSquare(decimal input)
        //{
        //    return input * input;
        //}
    }
}
