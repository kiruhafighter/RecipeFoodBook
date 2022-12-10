
namespace RecipeFoodBook
{
    partial class RecipeBook
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
            this.listBoxAllRecipes = new System.Windows.Forms.ListBox();
            this.listBoxSelRecIng = new System.Windows.Forms.ListBox();
            this.richTextBoxForInstruction = new System.Windows.Forms.RichTextBox();
            this.textBoxSearchRecipe = new System.Windows.Forms.TextBox();
            this.butSearchRecipe = new System.Windows.Forms.Button();
            this.addNameRecipeTextBox = new System.Windows.Forms.TextBox();
            this.addInstrRecipeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAllRecipes
            // 
            this.listBoxAllRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllRecipes.FormattingEnabled = true;
            this.listBoxAllRecipes.ItemHeight = 25;
            this.listBoxAllRecipes.Location = new System.Drawing.Point(37, 138);
            this.listBoxAllRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAllRecipes.Name = "listBoxAllRecipes";
            this.listBoxAllRecipes.Size = new System.Drawing.Size(273, 279);
            this.listBoxAllRecipes.TabIndex = 0;
            this.listBoxAllRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxAllRecipes_SelectedIndexChanged);
            // 
            // listBoxSelRecIng
            // 
            this.listBoxSelRecIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSelRecIng.FormattingEnabled = true;
            this.listBoxSelRecIng.ItemHeight = 25;
            this.listBoxSelRecIng.Location = new System.Drawing.Point(373, 138);
            this.listBoxSelRecIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSelRecIng.Name = "listBoxSelRecIng";
            this.listBoxSelRecIng.Size = new System.Drawing.Size(273, 279);
            this.listBoxSelRecIng.TabIndex = 1;
            // 
            // richTextBoxForInstruction
            // 
            this.richTextBoxForInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxForInstruction.Location = new System.Drawing.Point(723, 138);
            this.richTextBoxForInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxForInstruction.Name = "richTextBoxForInstruction";
            this.richTextBoxForInstruction.Size = new System.Drawing.Size(309, 279);
            this.richTextBoxForInstruction.TabIndex = 3;
            this.richTextBoxForInstruction.Text = "";
            // 
            // textBoxSearchRecipe
            // 
            this.textBoxSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchRecipe.Location = new System.Drawing.Point(37, 519);
            this.textBoxSearchRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchRecipe.Name = "textBoxSearchRecipe";
            this.textBoxSearchRecipe.Size = new System.Drawing.Size(273, 30);
            this.textBoxSearchRecipe.TabIndex = 4;
            // 
            // butSearchRecipe
            // 
            this.butSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butSearchRecipe.Location = new System.Drawing.Point(92, 574);
            this.butSearchRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.butSearchRecipe.Name = "butSearchRecipe";
            this.butSearchRecipe.Size = new System.Drawing.Size(156, 49);
            this.butSearchRecipe.TabIndex = 5;
            this.butSearchRecipe.Text = "Search";
            this.butSearchRecipe.UseVisualStyleBackColor = true;
            this.butSearchRecipe.Click += new System.EventHandler(this.butSearchRecipe_Click);
            // 
            // addNameRecipeTextBox
            // 
            this.addNameRecipeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNameRecipeTextBox.Location = new System.Drawing.Point(1124, 138);
            this.addNameRecipeTextBox.Name = "addNameRecipeTextBox";
            this.addNameRecipeTextBox.Size = new System.Drawing.Size(275, 30);
            this.addNameRecipeTextBox.TabIndex = 6;
            // 
            // addInstrRecipeTextBox
            // 
            this.addInstrRecipeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addInstrRecipeTextBox.Location = new System.Drawing.Point(1124, 185);
            this.addInstrRecipeTextBox.Name = "addInstrRecipeTextBox";
            this.addInstrRecipeTextBox.Size = new System.Drawing.Size(275, 30);
            this.addInstrRecipeTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1197, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Recipe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addRecipeButton.Location = new System.Drawing.Point(1168, 239);
            this.addRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(202, 61);
            this.addRecipeButton.TabIndex = 9;
            this.addRecipeButton.Text = "Add New Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // RecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 797);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addInstrRecipeTextBox);
            this.Controls.Add(this.addNameRecipeTextBox);
            this.Controls.Add(this.butSearchRecipe);
            this.Controls.Add(this.textBoxSearchRecipe);
            this.Controls.Add(this.richTextBoxForInstruction);
            this.Controls.Add(this.listBoxSelRecIng);
            this.Controls.Add(this.listBoxAllRecipes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecipeBook";
            this.Text = "RecipeBook";
            this.Load += new System.EventHandler(this.RecipeBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllRecipes;
        private System.Windows.Forms.ListBox listBoxSelRecIng;
        private System.Windows.Forms.RichTextBox richTextBoxForInstruction;
        private System.Windows.Forms.TextBox textBoxSearchRecipe;
        private System.Windows.Forms.Button butSearchRecipe;
        private System.Windows.Forms.TextBox addNameRecipeTextBox;
        private System.Windows.Forms.TextBox addInstrRecipeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRecipeButton;
    }
}

