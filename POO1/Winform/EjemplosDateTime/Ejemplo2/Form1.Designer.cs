namespace Ejemplo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            calFecha = new MonthCalendar();
            btnDaytimepicker = new Button();
            btnCalendar = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(221, 96);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(248, 23);
            dtpFecha.TabIndex = 0;
            // 
            // calFecha
            // 
            calFecha.Location = new Point(221, 143);
            calFecha.Name = "calFecha";
            calFecha.TabIndex = 1;
            // 
            // btnDaytimepicker
            // 
            btnDaytimepicker.Location = new Point(514, 96);
            btnDaytimepicker.Name = "btnDaytimepicker";
            btnDaytimepicker.Size = new Size(75, 23);
            btnDaytimepicker.TabIndex = 2;
            btnDaytimepicker.Text = "Prueba 1";
            btnDaytimepicker.UseVisualStyleBackColor = true;
            btnDaytimepicker.Click += btnDaytimepicker_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Location = new Point(514, 210);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(75, 23);
            btnCalendar.TabIndex = 3;
            btnCalendar.Text = "Prueba 2";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalendar);
            Controls.Add(btnDaytimepicker);
            Controls.Add(calFecha);
            Controls.Add(dtpFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private MonthCalendar calFecha;
        private Button btnDaytimepicker;
        private Button btnCalendar;
    }
}
