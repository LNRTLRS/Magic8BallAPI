using Magic8Ball.Models;

namespace Magic8Ball.Mappers
{
    public class Mapper
    {
        public static BallResult Map(string q, string a)
        {
            BallResult result = new BallResult
            {
                Question = q,
                Answer = a
            };
            return result;
        }
    }
}
