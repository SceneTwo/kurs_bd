using DataBaseLogic.Repositories;
using DataBaseStorage;

namespace бд
{
    public partial class Form2 : Form
    {
        private detailRepository _detailRepository;
        private resultEntityRepository _resultEntityRepository;
        private unitRepository _unitRepository;
        private context _context;
        public Form2()
        {
            context _context = new context();
            _detailRepository = new detailRepository(_context);
            _resultEntityRepository = new resultEntityRepository(_context);
            _unitRepository = new unitRepository(_context);
            InitializeComponent();
        }


        private async void calcBtn_Click(object sender, EventArgs e)
        {


            if (!CheckAngle()) return;

            // Проверка значения скорости
            if (!CheckSpeed()) return;
            //проверка на пустые текстбоксы
            checkempty();


            // считываю данные с интерфейса
            //детали
            double C1 = 0.0;
            double Alpha1 = Convert.ToDouble(comboBox1.Text);
            if (Alpha1 == 110) { C1 = 0.79; }
            if (Alpha1 == 120) { C1 = 0.82; }
            if (Alpha1 == 130) { C1 = 0.85; }
            if (Alpha1 == 140) { C1 = 0.88; }
            if (Alpha1 == 150) { C1 = 0.91; }
            if (Alpha1 == 160) { C1 = 0.94; }
            if (Alpha1 == 170) { C1 = 0.97; }
            if (Alpha1 == 180) { C1 = 1.0; }





            double D1 = Convert.ToDouble(textBoxD1.Text);
            string Material = Convert.ToString(textBoxMaterial.Text);
            string Material_P = Convert.ToString(textBoxKhb.Text);
            string Proverka = Convert.ToString(textBoxSigma.Text);
            double Dmin_Sigma = 0;

            // Проверка, чтобы убедиться, что текстовая метка не пустая
            if (string.IsNullOrEmpty(Material))
            {
                MessageBox.Show("Пожалуйста, выберите материал.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка, чтобы убедиться, что текстовая метка не пустая
            if (string.IsNullOrEmpty(Material_P))
            {
                MessageBox.Show("Пожалуйста, выберите покрытие.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Material == "Тканевый прорезиненный")
            {
                if (Proverka == "Допускаемое")
                {
                    Dmin_Sigma = 30.0;
                }
                else if (Proverka == "Рекомендуемое")
                {
                    Dmin_Sigma = 40.0;
                }
            }
            else if (Material == "Синтетический капроновый")
            {
                if (Proverka == "Допускаемое")
                {
                    Dmin_Sigma = 60.0;
                }
                else if (Proverka == "Рекомендуемое")
                {
                    Dmin_Sigma = 125.0;
                }
            }
            double Sigma = D1 / Dmin_Sigma;


            double Sigma0 = 0.0;
            //Сбор единицы
            string Natyazh = Convert.ToString(textBoxTensionType.Text);
            string MezOs = Convert.ToString(textBoxInterAxleDistance.Text);

            if (Material == "Тканевый прорезиненный")
            {

                if ((Natyazh == "Постоянное") && (MezOs == "Малое постоянное"))
                { Sigma0 = 1.6; }
                else if ((Natyazh == "Постоянное") && (MezOs == "Постоянное, достаточное"))
                {
                    Sigma0 = 1.8;
                }
                else if ((Natyazh == "Периодическое") && (MezOs == "Регулируемое"))
                {
                    Sigma0 = 1.8;
                }
                else if ((Natyazh == "Постоянное") && (MezOs == "Автоматически регулируемое"))
                {
                    Sigma0 = 2.0;
                }
                else if ((Natyazh == "Переменное") && (MezOs == "Автоматически регулируемое"))
                {
                    Sigma0 = 2.4;
                }
            }


            else if (Material == "Синтетический капроновый")
            {
                if ((Natyazh == "Периодическое") && (D1 / Sigma <= 80))
                {
                    Sigma0 = 4.0;
                }
                else if ((Natyazh == "Периодическое") && (D1 / Sigma > 80))
                {
                    Sigma0 = 4.5;
                }
                else if ((Natyazh == "Постоянное") && (D1 / Sigma > 80))
                {
                    Sigma0 = 7.5;
                }
                else if ((Natyazh == "Переменное") && (D1 / Sigma > 100))
                {
                    Sigma0 = 10.0;
                }
                else
                {

                }
            }


            double W = 0.0;
            double A = 0.0;

            if (Material == "Тканевый прорезиненный")
            {
                if (Sigma0 == 1.6)
                {
                    A = 2.3;
                    W = 9.0;
                }
                else if (Sigma0 == 1.8)
                {
                    A = 2.5;
                    W = 10.0;
                }
                else if (Sigma0 == 2.0)
                {
                    A = 2.7;
                    W = 11.0;
                }
                else if (Sigma0 == 2.4)
                {
                    A = 3.05;
                    W = 13.5;
                }
            }
            else if (Material == "Синтетический капроновый")
            {
                if (Material_P == "Из полиамида С6 в соединении с каучуком СКН-40")
                {
                    if (Sigma0 == 4.0)
                    {
                        A = 5.75;
                        W = 176;
                    }
                    else if (Sigma0 == 5.0)
                    {
                        A = 7.0;
                        W = 220;
                    }
                    else if (Sigma0 == 7.5)
                    {
                        A = 9.6;
                        W = 330;
                    }
                    else if (Sigma0 == 10.0)
                    {
                        A = 11.6;
                        W = 440;
                    }
                }
                else if (Material_P == "Из наиритового латекса")
                {
                    if (Sigma0 == 4.0)
                    {
                        A = 6.55;
                        W = 124;
                    }
                    else if (Sigma0 == 5.0)
                    {
                        A = 8.0;
                        W = 156;
                    }
                    else if (Sigma0 == 7.5)
                    {
                        A = 11.4;
                        W = 233;
                    }
                    else if (Sigma0 == 10.0)
                    {
                        A = 14.3;
                        W = 311;
                    }
                }
            }




            double C0 = 1.0;
            double beta = Convert.ToDouble(textBoxAngle.Text);
            if (Material == "Тканевый прорезиненный")
            {
                {
                    if (beta >= 0 && beta <= 60)
                    {
                        C0 = 1.0;
                    }
                    else if (beta > 60 && beta <= 80)
                    {
                        C0 = 0.9;
                    }
                    else if (beta > 80 && beta <= 90)
                    {
                        C0 = 0.8;
                    }
                }
            }

            double u = Convert.ToDouble(textBoxSpeed.Text);
            double C2 = 0.0;

            if (Material == "Тканевый прорезиненный")
            {

                switch (u)
                {
                    case 5:
                        C2 = 1.03;
                        break;
                    case 10:
                        C2 = 1.0;
                        break;
                    case 15:
                        C2 = 0.95;
                        break;
                    case 20:
                        C2 = 0.88;
                        break;
                    case 25:
                        C2 = 0.79;
                        break;
                    case 30:
                        C2 = 0.68;
                        break;

                }
            }
            if (Material == "Синтетический капроновый")
            {

                switch (u)
                {
                    case 5:
                        C2 = 1.01;
                        break;
                    case 10:
                        C2 = 1.00;
                        break;
                    case 15:
                        C2 = 0.99;
                        break;
                    case 20:
                        C2 = 0.97;
                        break;
                    case 25:
                        C2 = 0.95;
                        break;
                    case 30:
                        C2 = 0.92;
                        break;
                }
            }


            double C3 = 0.0;
            string TypeofEngine = Convert.ToString(textBoxMotorType.Text);
            string Character = Convert.ToString(textBoxLoadType.Text);
            string TypeofMachine = Convert.ToString(textBoxMachineType.Text);


            if (TypeofEngine == "Электродвигатель постоянного тока")
            {
                if (Character == "Спокойная" && TypeofMachine == "Ленточные транспортеры")
                {
                    C3 = 1.0;
                }
                else if (Character == "Умеренные колебания" && TypeofMachine == "Пластинчатые транспортеры")
                {
                    C3 = 1.1;
                }
                else if (Character == "Значительные колебания" && TypeofMachine == "Реверсивные приводы")
                {
                    C3 = 1.2;
                }
                else if (Character == "Неравномерная и ударная" && TypeofMachine == "Подъемники")
                {
                    C3 = 1.3;
                }
            }

            if (TypeofEngine == "Электродвигатель переменного тока")
            {
                if (Character == "Спокойная" && TypeofMachine == "Ленточные транспортеры")
                {
                    C3 = 1.05;
                }
                else if (Character == "Умеренные колебания" && TypeofMachine == "Пластинчатые транспортеры")
                {
                    C3 = 1.15;
                }
                else if (Character == "Значительные колебания" && TypeofMachine == "Реверсивные приводы")
                {
                    C3 = 1.25;
                }
                else if (Character == "Неравномерная и ударная" && TypeofMachine == "Подъемники")
                {
                    C3 = 1.35;
                }
            }



            Random random = new Random();
            double N = random.Next(20, 101);


            double N_V = N / u;



            //промежут

            double SigmaF0 = A - (W * Sigma / D1);
            double F = (10 ^ 3) * N_V;
            double SigmaF = SigmaF0 * C0 * C1 * C2 * C3;
            double b = F / (Sigma * SigmaF);
            textBoxPermTension.Text = SigmaF.ToString("F4");
            textBoxInitialTension.Text = F.ToString("F4");
            textBoxCircumForce.Text = SigmaF0.ToString("F4");
            textBoxBeltThickness.Text = b.ToString("F4");
            double Crossectionalarea = 0.0;


            //результы

            string intermediateResults =
                     $"b (Толщина): {b.ToString("F4")}\n" +
                    $"SigmaF (допускаемое полезное напряжение): {SigmaF.ToString("F4")}\n" +
                    $"SigmaF0 (Начальное напряжение): {SigmaF0.ToString("F4")}\n" +
                       $"F (Окружная сила): {F.ToString("F4")}\n";

            DialogResult result = MessageBox.Show(
                "Правильны ли следующие промежуточные значения?\n\n" + intermediateResults,
                "Подтвердите промежуточные данные",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                Crossectionalarea = b * Sigma;
                textBoxResult.Text = Crossectionalarea.ToString("F4");
            }
            else
            {

                MessageBox.Show("Пожалуйста, исправьте входные значения и попробуйте снова.");
            }


            if (Crossectionalarea > 0.0)
            {
                var detailId = await _detailRepository.Create(
                 Alpha1, Sigma, D1, N, u, Dmin_Sigma,
           N_V, beta, Material, Material_P);


                var unitId = await _unitRepository.Create(
                    F, b, Sigma0, SigmaF0, SigmaF, C0, C1, C2,
                    C3, W, MezOs, Natyazh, Character, TypeofMachine,
                    TypeofEngine, A, Crossectionalarea);


                _resultEntityRepository.Create(
                     Sigma, F, Sigma0, SigmaF, Crossectionalarea, detailId, unitId);


                await Task.WhenAll();
            }




        }
        private void checkempty()
        {
            TextBox[] textBoxes = { textBoxAngle, textBoxSpeed, textBoxD1, textBoxAngle };
            const string default_value = "5,00";

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = default_value;
                }

            }

            ComboBox[] comboBoxes = { comboBox1, textBoxMachineType, textBoxLoadType, textBoxMotorType, textBoxInterAxleDistance, textBoxTensionType, textBoxSigma, textBoxKhb, textBoxMaterial };

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem == null)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }
        private bool CheckAngle()
        {
            double angle;
            bool isAngleValid = double.TryParse(textBoxAngle.Text, out angle);

            if (!isAngleValid)
            {
                MessageBox.Show("Введите корректное числовое значение для угла.");
                return false;
            }

            if (angle >= 0 && angle <= 60)
            {
                MessageBox.Show("Угол находится в диапазоне от 0 до 60 включительно.");
            }
            else if (angle > 60 && angle <= 80)
            {
                MessageBox.Show("Угол находится в диапазоне от 60 не включая до 80 включительно.");
            }
            else if (angle > 80 && angle <= 90)
            {
                MessageBox.Show("Угол находится в диапазоне от 80 не включая до 90 включительно.");
            }
            else
            {
                MessageBox.Show("Угол вне допустимого диапазона (0-90).");
                return false;
            }

            return true;
        }

        // Функция для проверки скорости
        private bool CheckSpeed()
        {
            double speed;
            bool isSpeedValid = double.TryParse(textBoxSpeed.Text, out speed);

            if (isSpeedValid && speed >= 5 && speed <= 30 && speed % 5 == 0)
            {
                MessageBox.Show("Скорость введена корректно.");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка! Скорость должна быть в диапазоне от 0 до 30 с шагом 5.");
                return false;
            }
        }


    }

}
