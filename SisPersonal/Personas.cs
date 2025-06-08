namespace Personal
{
    public class Empleado  // Creacion de Clase
    {
        private string? nombre;
        private string? apellido;
        private DateTime fnacimiento;
        private char? estadocivil;  // C = Casado, S = Soltero
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
        public DateTime Fnacimiento
        {
            get => fnacimiento;
            set => fnacimiento = value;
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
        public Empleado(string nombre, string apellido, DateTime fnacimiento, char estadocivil, DateTime fingreso, double sueldo, Cargos cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fnacimiento = fnacimiento;
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
        /* public int Antiguedad
        {
            get
            {
                int antiguedad = DateTime.Now.Year - Fingreso.Year;
                if (DateTime.Now < Fingreso.AddYears(antiguedad)) antiguedad--;
                return antiguedad;
            }
        } */
        /* public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - Fnacimiento.Year;
                if (DateTime.Now < Fnacimiento.AddYears(edad)) edad--;
                return edad;
            }
        } */
        public int AniosJubilarse => Math.Max(0, 65 - (DateTime.Now.Year - Fingreso.Year));

        public double Salario
        {
            get
            {
                int antiguedad = DateTime.Now.Year - Fingreso.Year;
            if(DateTime.Now<Fingreso.AddYears(antiguedad)) antiguedad --;

                double adicional = 0;
                if (antiguedad <= 20) // Cargo por Antiguedad
                {
                    adicional += Sueldo * (antiguedad * 0.01);
                }
                else
                {
                    adicional += Sueldo * 0.25;
                }
                if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero) // Cargo por Puesto de Trabajo
                {
                    adicional += adicional * 1.5;
                }
                if (Estadocivil == 'C')     // Cargo por Estado Civil
                {
                    adicional *= 150000;
                }
                return Sueldo + adicional;
            }
        }
        public void MostrarDetalles() // Mostrar Datos
        {
            // Calcular Antiguedad
            int antiguedad = DateTime.Now.Year - Fingreso.Year;
            if(DateTime.Now<Fingreso.AddYears(antiguedad)) antiguedad --;
            // Calcular Edad
            int edad = DateTime.Now.Year - Fnacimiento.Year;
            if(DateTime.Now<Fingreso.AddYears(edad)) edad --;

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {Fnacimiento.ToShortDateString()} (Edad: {edad} Años)");
            Console.WriteLine($"Estado Civil: {Estadocivil}");
            Console.WriteLine($"Fecha de Ingreso: {Fingreso.ToShortDateString()} (Antiguedad: {antiguedad} Años)");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Sueldo Basico: ${Sueldo}");
            Console.WriteLine($"Años Para Jubilarse: {AniosJubilarse} años");
            Console.WriteLine($"Sueldo Total: ${Salario}");
            Console.WriteLine(new string('-', 40));
        }
    }

}
