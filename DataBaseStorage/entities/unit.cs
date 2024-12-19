namespace DataBaseStorage.entities
{
    public class unit
    {
        public unit(double F, double b, double Sigma0, double SigmaF0, double SigmaF, double C0,
                    double C1, double C2, double C3, double W, string MezOs, string Natyazh,
                    string Character, string TypeofMachine, string TypeofEngine, double A, double Crossectionalarea)
        {
            this.F = F;
            this.b = b;
            this.Sigma0 = Sigma0;
            this.SigmaF0 = SigmaF0;
            this.SigmaF = SigmaF;
            this.C0 = C0;
            this.C1 = C1;
            this.C2 = C2;
            this.C3 = C3;
            this.W = W;
            this.MezOs = MezOs;
            this.Natyazh = Natyazh;
            this.Character = Character;
            this.TypeofMachine = TypeofMachine;
            this.TypeofEngine = TypeofEngine;
            this.A = A;
            this.Crossectionalarea = Crossectionalarea;
        }

        public Guid Id { get; set; }

        public double F { get; set; }
        public double b { get; set; }
        public double Sigma0 { get; set; }
        public double SigmaF0 { get; set; }
        public double SigmaF { get; set; }
        public double C0 { get; set; }
        public double C1 { get; set; }
        public double C2 { get; set; }
        public double C3 { get; set; }
        public double W { get; set; }
        public string MezOs { get; set; }
        public string Natyazh { get; set; }
        public string Character { get; set; }
        public string TypeofMachine { get; set; }

        public string TypeofEngine { get; set; }
        public double A { get; set; }
        public double Crossectionalarea { get; set; }
    }

}
