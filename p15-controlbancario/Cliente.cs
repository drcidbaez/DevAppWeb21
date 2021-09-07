namespace p15_controlbancario
{
    public class Cliente {
        public Cliente(string nombre, string apedillo) {
            this.nombre=nombre;
            this.apellido=apellido;
        }
        public string nombre {get; private set;}
        public string apellido {get; private set;}
        public CuentaBancaria cuenta {get; set;}
    }

}