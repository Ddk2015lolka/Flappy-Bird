namespace FlappyBird
{
    partial class Form1
    {
        
        /// Обязательная переменная конструктора.
        
        private System.ComponentModel.IContainer components = null;

        
        /// Освободить все используемые ресурсы.
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

      
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
      
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            //void InitializeComponent()
          
            // {
           // components = new System::ComponentModel::Container();
             //   System::ComponentModel::ComponentResourceManager ^ resources = gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid);
               // timer1 = gcnew System::Windows::Forms::Timer(components);
                //button1 = gcnew Button();
                //SuspendLayout();
            // }
        
            // button1

            button1.Location = new Point(611, 611);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(121, 106);
            button1.TabIndex = 0;
            button1.Text = "Force";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(748, 735);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Flappy Bird";
            Paint += OnPaint;
            ResumeLayout(false);
        }
        //  SizeF* AutoScaleDimensions = new SizeF(8.0F, 20.0F);

        //AutoScaleMode = AutoScaleMode::Font;

       //BackColor = SystemColors::GradientActiveCaption;

      // BackgroundImage = dynamic_cast<Image*>(resources->GetObject("$this.BackgroundImage"));

     // ClientSize = Size(748, 735);

      // Controls->Add(button1);

        // DoubleBuffered = true;

// Margin = Padding(4, 5, 4, 5);

        // Name = "Form1";

// Text = "Flappy Bird";

//  Paint += gcnew PaintEventHandler(this, &Form1::OnPaint);

        // ResumeLayout(false);
        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}