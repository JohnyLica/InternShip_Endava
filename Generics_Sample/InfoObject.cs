namespace Generics_Sample
{
    public class InfoObject
    {
        public static string Info<T>(T obj)
            where T : AllInfoUser
        {
            return obj.ToString();
        } 
    }
}