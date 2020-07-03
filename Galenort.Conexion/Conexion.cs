namespace Galenort.Conexion
{
    public static class Conexion
    {
        public const string DATABASE = "galenort";
        public const string SERVER = "127.0.0.1";
        public const string USER = "root";
        public const string PASSWORD = "";


        public static string ObtenerCadenaConexionSql => $"Server={SERVER};Database={DATABASE};Uid={USER};Pwd={PASSWORD};SslMode=Preferred;";
       
    }
}
