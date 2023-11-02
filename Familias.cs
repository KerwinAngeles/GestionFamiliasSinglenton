
    public class Familias
    {
        public string Apellidos {get; set;}
        public Mascotas Mascotas {get; set;}

        public Familias(string Apellidos, Mascotas mascotas)
        {
            this.Apellidos = Apellidos;
            Mascotas = mascotas;
        }

        public override string ToString()
        {
            return "Apellidos: " + Apellidos + " Mascotas: " + Mascotas;
        }

}