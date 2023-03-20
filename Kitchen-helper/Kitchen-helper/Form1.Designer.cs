namespace Kitchen_helper
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
            ingredientsList = new CheckedListBox();
            goNextButton = new Button();
            SuspendLayout();
            // 
            // ingredientsList
            // 
            ingredientsList.FormattingEnabled = true;
            ingredientsList.Location = new Point(12, 12);
            ingredientsList.Name = "ingredientsList";
            ingredientsList.Size = new Size(776, 274);
            ingredientsList.TabIndex = 0;
            ingredientsList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // goNextButton
            // 
            goNextButton.Location = new Point(250, 350);
            goNextButton.Name = "goNextButton";
            goNextButton.Size = new Size(269, 74);
            goNextButton.TabIndex = 1;
            goNextButton.Text = "Next";
            goNextButton.UseVisualStyleBackColor = true;
            goNextButton.Click += goNextButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goNextButton);
            Controls.Add(ingredientsList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox ingredientsList;
        private Button goNextButton;
    }
}