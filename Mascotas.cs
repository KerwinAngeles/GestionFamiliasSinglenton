
    public class Mascotas
    {
        public string Nombre {get; set;}
        public string Especies {get; set;}
        private static Mascotas mascotas;

        private Mascotas(string nombre, string especies)
        {
            Nombre = nombre;
            Especies = especies;
        }

        public static Mascotas getMascotas(string nombre, string especies)
        {
            if(mascotas == null)
            {
                mascotas = new Mascotas(nombre, especies);
                return mascotas;
            }
            else
            {
                mascotas = new Mascotas(nombre, especies);
                return mascotas;
            }
        }

    public override string ToString()
    {
        return "Animal: " + Nombre + " Especies: " + Especies;
    }
}
