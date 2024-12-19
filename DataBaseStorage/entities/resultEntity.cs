namespace DataBaseStorage.entities
{
    public class resultEntity
    {

        public resultEntity(double Sigma, double F, double Sigma0, double SigmaF, double crossectionalarea)
        {

            this.Sigma = Sigma;
            this.F = F;
            this.Sigma0 = Sigma0;
            this.SigmaF = SigmaF;
            this.Crossectionalarea = crossectionalarea;

        }

        public Guid Id { get; set; }


        public Guid detailId { get; set; }
        public detail detail { get; set; }
        public Guid unitId { get; set; }
        public unit unit { get; set; }


        public double Sigma { get; set; }
        public double F { get; set; }
        public double Sigma0 { get; set; }
        public double SigmaF { get; set; }
        public double Crossectionalarea { get; set; }
    }
}

