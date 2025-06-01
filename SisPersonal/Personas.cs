namespace Personal
{
    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fnaciomiento;
        private char? estadocivil;
        private DateTime fingreso;
        private double sueldo;
        private Cargos cargo;
        public string? Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string? Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime Fnaciomiento
        {
            get => fnaciomiento;
            set => fnaciomiento = value;
        }
        public DateTime Fingreso
        {
            get => fingreso;
            set => fingreso = value;
        }

        public double Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }
        public char? Estadocivil
        {
            get => estadocivil;
            set => estadocivil = value;
        }
        public Cargos Cargo
        {
            get => cargo;
            set => cargo = value;
        }
        // Constructor Con los datos de Empleado
        public Empleado(string nombre , string apellido, DateTime fnacimiento, char estadocivil, DateTime fingreso, double sueldo, Cargos cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fnaciomiento = fnaciomiento;
            this.Estadocivil = estadocivil;
            this.Fingreso = fingreso;
            this.Sueldo = sueldo;
            this.Cargo = cargo;
        }
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
    }

}
