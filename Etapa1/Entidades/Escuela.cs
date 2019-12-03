namespace CoreEscuela.Entidades//CoreEscuela es el espacio de nombre mayor y entidades es este en espesifico
{
    class Escuela
    {

        string nombre;
        public string Nombre 
        {   
            get{return nombre;} 
            set{Nombre = value.ToUpper();} 
        }

        public string Ciudad { get; set; }


        public string Pais { get; set; }


        public int AnioDeCreacion { get; set; }


        public TiposEscuela TipoEscuela { get; set; }



        public Escuela(string nombre, int anio)
        {
            this.nombre = nombre;//this.nombre es el nombre de la clase que es igual al nombre de atributo
            AnioDeCreacion = anio;

        }

        // public Escuela(string nombre, int anio) =>(Nombre, AnioDeCreacion) = (nombre, anio);


        public Escuela(string nombre, int anio, 
                TiposEscuela tipo, 
                string pais = "", string ciudad = "")
        {
            (Nombre, AnioDeCreacion) = (nombre, anio); /* asignacion por medio de tuplas*/
            Pais = pais;
            Ciudad = ciudad;

        }


        public override string ToString() //Este metodo es para poder imprimir completamente la escuela y no poner escuela.something
        {
        return $"Nombre:{Nombre} Tipo: {TipoEscuela}Pais: {Pais}  Ciudad: {Ciudad}";
        }

        






    }
}