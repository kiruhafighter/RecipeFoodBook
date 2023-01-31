namespace RecipeFoodBook
{
    partial class AddIngredientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientButton.Location = new System.Drawing.Point(169, 156);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(102, 31);
            this.addIngredientButton.TabIndex = 18;
            this.addIngredientButton.Text = "ADD";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 43);
            this.label2.TabIndex = 17;
            this.label2.Text = "Add New Ingredient";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addIngredientTextBox
            // 
            this.addIngredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addIngredientTextBox.Location = new System.Drawing.Point(120, 104);
            this.addIngredientTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addIngredientTextBox.Name = "addIngredientTextBox";
            this.addIngredientTextBox.Size = new System.Drawing.Size(203, 26);
            this.addIngredientTextBox.TabIndex = 16;
            // 
            // AddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 235);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addIngredientTextBox);
            this.Name = "AddIngredientForm";
            this.Text = "AddIngredientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addIngredientTextBox;
    }
}