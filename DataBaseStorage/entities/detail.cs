namespace DataBaseStorage.entities
{
    public class detail
    {

        public detail(double alpha1, double sigma, double d1, double n,
                      double u, double dmin_Sigma, double n_V, double beta, string material, string Material_P)
        {
            Alpha1 = alpha1;
            Sigma = sigma;
            D1 = d1;
            N = n;
            U = u;
            Dmin_Sigma = dmin_Sigma;
            N_V = n_V;
            Beta = beta;
            Material = material;
            this.Material_P = Material_P;
        }

        public Guid Id { get; set; }


        public double Alpha1 { get; set; }
        public double Sigma { get; set; }
        public double D1 { get; set; }

        public double N { get; set; }
        public double U { get; set; }
        public double Dmin_Sigma { get; set; }
        public double N_V { get; set; }
        public double Beta { get; set; }
        public string Material { get; set; }

        public string Material_P { get; set; }
    }
}

