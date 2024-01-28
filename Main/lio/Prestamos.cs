    public class Prestamos
    {
        public double IngresosMensuales { get; set; }
        public double OtrosIngresos { get; set; }
        public double DeudasActuales { get; set; }
        public double Monto { get; set; }
        public int PlazoMeses { get; set; }
        public double TasaInteres { get; set; }
        public string? Proposito { get; set; }
        public bool Aprobado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAprobacion { get; set; }

        public Prestamos()
        {
            Aprobado=false;
            FechaSolicitud = DateTime.Now;
        }
    }