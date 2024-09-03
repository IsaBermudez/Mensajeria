using System;


namespace Mensajeria_Instantanea.SMS
{
    public class Estados
    {
        //atribustos privados
        private int id = 0;
        private string nombre = "";
        //constructores
        public Estados()
        {
        }
        public Estados(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }

  

    }

    public class Grupos
    {
        //atributos privados
        private int id = 0;
        private string nombre = "";
        //constructores
        public Grupos()
        {
        }
        public Grupos(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }

    }

    public class Usuarios
    {
        //atributos privados
        private int id = 0;
        private string codigo = "";
        private string nombre = "";
        //constructores
            public Usuarios(){ }
            public Usuarios(int id,string codigo ,string nombre)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
        }
        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public string Codigo { get => this.codigo; set => this.codigo = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        //metodos
        public void  EnviarMensaje() { 
            
        }
        public void RecibirMensaje()
        {

        }

    }
    public class Usuarios_Grupos
    {
        //atributos privados
        private int id = 0;
        private Usuarios? usuario = null;
        private Grupos? grupo = null;
        //constructores
        public Usuarios_Grupos() { }
        public Usuarios_Grupos(int id, Usuarios usuario,Grupos grupo) 
        {
            this.id = id;
            this.usuario = usuario;
            this.grupo = grupo;
        }

        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public Usuarios? Usuario { get => this.usuario; set => this.usuario = value; }
        public Grupos? Grupo { get => this.grupo; set => this.grupo= value; }
    }
    public class Detalles
    {
        //atributos privados
        private int id = 0;
        private Usuarios?para= null;
        private Mensajes? mensaje = null;
        private Estados? estado = null;

        //constructores
        public Detalles(int id, Usuarios para,Mensajes mensaje,Estados estado)
        {
            this.id = id;
            this.para = para;
            this.mensaje = mensaje;
        }
        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public Usuarios? Para { get => this.para; set => this.para = value; }
        public Mensajes? Mensaje { get => this.mensaje; set => this.mensaje = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
        //metodos
        public void actualizarEstado() { }
    }
    public class Mensajes
    {
        //atributos privados
        private int id = 0;
        private string contenido = "";
        private DateTime? fecha=null;
        private Usuarios? de = null;
        private Usuarios? para = null;
        private Grupos? grupo = null;
        private string adjunto ="";
        private Estados? estado = null;
        private bool borrado = false;
        //constructores
        public Mensajes()
        {
        }
        public Mensajes(int id,string contenido,DateTime fecha,Usuarios de,Usuarios para,Grupos grupo,string adjunto, Estados estado,bool borrado)
        {
            this.id = id;
            this.contenido = contenido;
            this.fecha = fecha;
            this.de = de;
            this.para = para;
            this.grupo = grupo;
            this.adjunto = adjunto;
            this.estado = estado;
            this.borrado = borrado;
        }
        //get y set
        public int Id { get => this.id; set => this.id = value; }
        public string Contenido { get => this.contenido; set => this.contenido = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public Usuarios? De { get => this.de; set => this.de = value; }
        public Usuarios? Para { get => this.para; set => this.para = value; }
        public Grupos? Grupo { get => this.grupo; set => this.grupo = value; }
        public string Adjunto { get => this.adjunto; set => this.adjunto = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
        public bool Borrado { get => this.borrado; set => this.borrado = value; }
        //metodos
        public void actualizarEstado() { }
        public void marcarComoBorrado() { }

    }

}