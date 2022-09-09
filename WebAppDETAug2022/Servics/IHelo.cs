namespace WebAppDETAug2022.Servics
{
    public interface IHelo
    {
        string SayHelo(string name);
    }

    public class Helo1 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Helo{name},welcome to ASP>Net";
        }

    }
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Hai,Helo{name},Howz the day!!!";
        }

    }
}
