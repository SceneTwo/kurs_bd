namespace бд
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {


            calcBtn = new Button();
            labelInput = new Label();
            labelOutput = new Label();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxMaterial = new ComboBox();
            textBoxKhb = new ComboBox();
            textBoxSigma = new ComboBox();
            textBoxTensionType = new ComboBox();
            textBoxInterAxleDistance = new ComboBox();
            textBoxAngle = new TextBox();
            textBoxSpeed = new TextBox();
            textBoxMotorType = new ComboBox();
            textBoxLoadType = new ComboBox();
            textBoxMachineType = new ComboBox();
            textBoxResult = new TextBox();
            textBoxD1 = new TextBox();
            textBoxBeltThickness = new TextBox();
            textBoxCircumForce = new TextBox();
            textBoxInitialTension = new TextBox();
            textBoxPermTension = new TextBox();
            panelBackground = new Panel();
            label18 = new Label();
            comboBox1 = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panelBackground.SuspendLayout();
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.Font = new Font("Arial", 14F, FontStyle.Bold);
            calcBtn.Location = new Point(1500, 674);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(370, 60);
            calcBtn.TabIndex = 28;
            calcBtn.Text = "Рассчитать";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // labelInput
            // 
            labelInput.AutoSize = false;
            labelInput.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelInput.ForeColor = Color.DarkSlateBlue;
            labelInput.Location = new Point(12, 93);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(343, 45);
            labelInput.TabIndex = 0;
            labelInput.Text = "Входные данные";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = false;
            labelOutput.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelOutput.ForeColor = Color.DarkSlateBlue;
            labelOutput.Location = new Point(1580, 121);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(376, 45);
            labelOutput.TabIndex = 1;
            labelOutput.Text = "Выходные данные";
            // 
            // labelResult
            // 
            labelResult.AutoSize = false;
            labelResult.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelResult.ForeColor = Color.DarkSlateBlue;
            labelResult.Location = new Point(1300, 674);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(201, 45);
            labelResult.TabIndex = 2;
            labelResult.Text = "Результат";
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(-2, 227);
            label1.Name = "label1";
            label1.Size = new Size(450, 37);
            label1.TabIndex = 3;
            label1.Text = "Выберите материал ремня:";
            // 
            // label2
            // 
            label2.AutoSize = false;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(7, 309);
            label2.Name = "label2";
            label2.Size = new Size(452, 37);
            label2.TabIndex = 5;
            label2.Text = "Выберите покрытие ремня:";
            // 
            // label3
            // 
            label3.AutoSize = false;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(7, 388);
            label3.Name = "label3";
            label3.Size = new Size(1277, 37);
            label3.TabIndex = 7;
            label3.Text = "Выберите отношение диаметра меньшего шкива к толщине ремня (Dmin/delta):";
            // 
            // label4
            // 
            label4.AutoSize = false;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(3, 519);
            label4.Name = "label4";
            label4.Size = new Size(530, 37);
            label4.TabIndex = 9;
            label4.Text = "Выберите тип натяжения ремня:";
            // 
            // label5
            // 
            label5.AutoSize = false;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(-7, 628);
            label5.Name = "label5";
            label5.Size = new Size(635, 37);
            label5.TabIndex = 11;
            label5.Text = "Выберите тип межосевого расстояния:";
            // 
            // label6
            // 
            label6.AutoSize = false;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(-5, 709);
            label6.Name = "label6";
            label6.Size = new Size(973, 37);
            label6.TabIndex = 13;
            label6.Text = "Укажите угол наклона оси передачи к горизонту (От 0 до 90):";
            // 
            // label7
            // 
            label7.AutoSize = false;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(3, 903);
            label7.Name = "label7";
            label7.Size = new Size(658, 37);
            label7.TabIndex = 15;
            label7.Text = "Введите скорость (от 5 до 30 с шагом 5):";
            // 
            // label8
            // 
            label8.AutoSize = false;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(-2, 767);
            label8.Name = "label8";
            label8.Size = new Size(417, 37);
            label8.TabIndex = 17;
            label8.Text = "Выберите тип двигателя:";
            // 
            // label9
            // 
            label9.AutoSize = false;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(-5, 837);
            label9.Name = "label9";
            label9.Size = new Size(480, 37);
            label9.TabIndex = 19;
            label9.Text = "Выберите характер нагрузки:";
            // 
            // label10
            // 
            label10.AutoSize = false;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold);
            label10.Location = new Point(-2, 982);
            label10.Name = "label10";
            label10.Size = new Size(390, 37);
            label10.TabIndex = 21;
            label10.Text = "Выберите тип машины:";
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Items.AddRange(new object[] { "Тканевый прорезиненный", "Синтетический капроновый" });
            textBoxMaterial.Location = new Point(526, 228);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(656, 40);
            textBoxMaterial.TabIndex = 4;
            // 
            // textBoxKhb
            // 
            textBoxKhb.Items.AddRange(new object[] { "Из полиамида С6 в соединении с каучуком СКН-40", "Из наиритового латекса" });
            textBoxKhb.Location = new Point(526, 310);
            textBoxKhb.Name = "textBoxKhb";
            textBoxKhb.Size = new Size(656, 40);
            textBoxKhb.TabIndex = 6;
            // 
            // textBoxSigma
            // 
            textBoxSigma.Items.AddRange(new object[] { "Допускаемое", "Рекомендуемое" });
            textBoxSigma.Location = new Point(526, 428);
            textBoxSigma.Name = "textBoxSigma";
            textBoxSigma.Size = new Size(730, 40);
            textBoxSigma.TabIndex = 8;
            // 
            // textBoxTensionType
            // 
            textBoxTensionType.Items.AddRange(new object[] { "Постоянное", "Периодическое", "Переменное" });
            textBoxTensionType.Location = new Point(631, 516);
            textBoxTensionType.Name = "textBoxTensionType";
            textBoxTensionType.Size = new Size(640, 40);
            textBoxTensionType.TabIndex = 10;
            // 
            // textBoxInterAxleDistance
            // 
            textBoxInterAxleDistance.Items.AddRange(new object[] { "Малое постоянное", "Постоянное, достаточное", "Регулируемое", "Автоматически регулируемое" });
            textBoxInterAxleDistance.Location = new Point(720, 628);
            textBoxInterAxleDistance.Name = "textBoxInterAxleDistance";
            textBoxInterAxleDistance.Size = new Size(536, 40);
            textBoxInterAxleDistance.TabIndex = 12;
            // 
            // textBoxAngle
            // 
            textBoxAngle.Location = new Point(997, 710);
            textBoxAngle.Name = "textBoxAngle";
            textBoxAngle.Size = new Size(274, 39);
            textBoxAngle.TabIndex = 14;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(696, 904);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(222, 39);
            textBoxSpeed.TabIndex = 16;
            // 
            // textBoxMotorType
            // 
            textBoxMotorType.Items.AddRange(new object[] { "Электродвигатель постоянного тока", "Электродвигатель переменного тока" });
            textBoxMotorType.Location = new Point(526, 768);
            textBoxMotorType.Name = "textBoxMotorType";
            textBoxMotorType.Size = new Size(566, 40);
            textBoxMotorType.TabIndex = 18;
            // 
            // textBoxLoadType
            // 
            textBoxLoadType.Items.AddRange(new object[] { "Спокойная", "Умеренные колебания", "Значительные колебания", "Неравномерная и ударная" });
            textBoxLoadType.Location = new Point(526, 834);
            textBoxLoadType.Name = "textBoxLoadType";
            textBoxLoadType.Size = new Size(566, 40);
            textBoxLoadType.TabIndex = 20;
            // 
            // textBoxMachineType
            // 
            textBoxMachineType.Items.AddRange(new object[] { "Ленточные транспортеры", "Пластинчатые транспортеры", "Реверсивные приводы", "Подъемники" });
            textBoxMachineType.Location = new Point(557, 983);
            textBoxMachineType.Name = "textBoxMachineType";
            textBoxMachineType.Size = new Size(535, 40);
            textBoxMachineType.TabIndex = 22;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Arial", 14F, FontStyle.Bold);
            textBoxResult.Location = new Point(1600, 803);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(231, 50);
            textBoxResult.TabIndex = 29;
            // 
            // textBoxD1
            // 
            textBoxD1.Location = new Point(526, 162);
            textBoxD1.Name = "textBoxD1";
            textBoxD1.Size = new Size(503, 39);
            textBoxD1.TabIndex = 23;
            // 
            // textBoxBeltThickness
            // 
            textBoxBeltThickness.Location = new Point(1600, 205);
            textBoxBeltThickness.Name = "textBoxBeltThickness";
            textBoxBeltThickness.Size = new Size(240, 39);
            textBoxBeltThickness.TabIndex = 24;
            // 
            // textBoxCircumForce
            // 
            textBoxCircumForce.Location = new Point(1600, 346);
            textBoxCircumForce.Name = "textBoxCircumForce";
            textBoxCircumForce.Size = new Size(246, 39);
            textBoxCircumForce.TabIndex = 25;
            // 
            // textBoxInitialTension
            // 
            textBoxInitialTension.Location = new Point(1600, 412);
            textBoxInitialTension.Name = "textBoxInitialTension";
            textBoxInitialTension.Size = new Size(246, 39);
            textBoxInitialTension.TabIndex = 26;
            // 
            // textBoxPermTension
            // 
            textBoxPermTension.Location = new Point(1600, 273);
            textBoxPermTension.Name = "textBoxPermTension";
            textBoxPermTension.Size = new Size(243, 39);
            textBoxPermTension.TabIndex = 27;
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.LightCoral;
            panelBackground.Controls.Add(label18);
            panelBackground.Controls.Add(comboBox1);
            panelBackground.Controls.Add(label17);
            panelBackground.Controls.Add(label16);
            panelBackground.Controls.Add(label15);
            panelBackground.Controls.Add(label14);
            panelBackground.Controls.Add(label13);
            panelBackground.Controls.Add(label12);
            panelBackground.Controls.Add(label11);
            panelBackground.Controls.Add(labelInput);
            panelBackground.Controls.Add(labelOutput);
            panelBackground.Controls.Add(labelResult);
            panelBackground.Controls.Add(label1);
            panelBackground.Controls.Add(textBoxMaterial);
            panelBackground.Controls.Add(label2);
            panelBackground.Controls.Add(textBoxKhb);
            panelBackground.Controls.Add(label3);
            panelBackground.Controls.Add(textBoxSigma);
            panelBackground.Controls.Add(label4);
            panelBackground.Controls.Add(textBoxTensionType);
            panelBackground.Controls.Add(label5);
            panelBackground.Controls.Add(textBoxInterAxleDistance);
            panelBackground.Controls.Add(label6);
            panelBackground.Controls.Add(textBoxAngle);
            panelBackground.Controls.Add(label7);
            panelBackground.Controls.Add(textBoxSpeed);
            panelBackground.Controls.Add(label8);
            panelBackground.Controls.Add(textBoxMotorType);
            panelBackground.Controls.Add(label9);
            panelBackground.Controls.Add(textBoxLoadType);
            panelBackground.Controls.Add(label10);
            panelBackground.Controls.Add(textBoxMachineType);
            panelBackground.Controls.Add(textBoxD1);
            panelBackground.Controls.Add(textBoxBeltThickness);
            panelBackground.Controls.Add(textBoxCircumForce);
            panelBackground.Controls.Add(textBoxInitialTension);
            panelBackground.Controls.Add(textBoxPermTension);
            panelBackground.Controls.Add(calcBtn);
            panelBackground.Controls.Add(textBoxResult);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(2143, 1090);
            panelBackground.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = false;
            label18.Font = new Font("Arial", 12F, FontStyle.Bold);
            label18.Location = new Point(1000, 900);
            label18.Name = "label18";
            label18.Size = new Size(450, 37);
            label18.TabIndex = 53;
            label18.Text = "Выберите угол обхвата на меньшем шкиве:";
            // 
            // comboBox1
            // 
            comboBox1.Items.AddRange(new object[] { "110", "120", "130", "140", "150", "160", "170", "180" });
            comboBox1.Location = new Point(1500, 900);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(353, 40);
            comboBox1.TabIndex = 54;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label17.ForeColor = Color.DarkBlue;
            label17.Location = new Point(642, -12);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(732, 171);
            label17.TabIndex = 52;
            label17.Text = "Проектировочный расчёт сечения ремня плоскоременной передачи";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = false;
            label16.Font = new Font("Arial", 12F, FontStyle.Bold);
            label16.Location = new Point(1100, 802);
            label16.Name = "label16";
            label16.Size = new Size(481, 37);
            label16.TabIndex = 35;
            label16.Text = "Рассчитанное сечение ремня";
            // 
            // label15
            // 
            label15.AutoSize = false;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold);
            label15.Location = new Point(1200, 272);
            label15.Name = "label15";
            label15.Size = new Size(400, 37);
            label15.TabIndex = 34;
            label15.Text = "Допускаемое полезное напряжение:";
            // 
            // label14
            // 
            label14.AutoSize = false;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold);
            label14.Location = new Point(1200, 348);
            label14.Name = "label14";
            label14.Size = new Size(400, 37);
            label14.TabIndex = 33;
            label14.Text = "Начальное напряжение ремня:";
            // 
            // label13
            // 
            label13.AutoSize = false;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold);
            label13.Location = new Point(1270, 411);
            label13.Name = "label13";
            label13.Size = new Size(266, 37);
            label13.TabIndex = 32;
            label13.Text = "Окружная сила:";
            // 
            // label12
            // 
            label12.AutoSize = false;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold);
            label12.Location = new Point(1300, 207);
            label12.Name = "label12";
            label12.Size = new Size(275, 37);
            label12.TabIndex = 31;
            label12.Text = "Толщина ремня:";
            // 
            // label11
            // 
            label11.AutoSize = false;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.Location = new Point(3, 170);
            label11.Name = "label11";
            label11.Size = new Size(440, 37);
            label11.TabIndex = 30;
            label11.Text = "Диаметр меньшего шкива:";
            // 
            // Form2
            // 
            ClientSize = new Size(1920, 1080);
            AutoScroll = true;
            Dock = DockStyle.Fill;
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = Color.White;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Курсовая работа Барабаш А.В. ИДБ-22-04";
            panelBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button calcBtn;
        private Label labelInput, labelOutput, labelResult, label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private ComboBox textBoxMaterial, textBoxKhb, textBoxSigma, textBoxTensionType, textBoxInterAxleDistance, textBoxMotorType, textBoxLoadType, textBoxMachineType;
        private TextBox textBoxAngle, textBoxSpeed, textBoxResult, textBoxD1, textBoxBeltThickness, textBoxCircumForce, textBoxInitialTension, textBoxPermTension;
        private Panel panelBackground;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label17;
        private Label label18;
        private ComboBox comboBox1;

        
    }

}