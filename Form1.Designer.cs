
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
            this.listBoxAllIngredients = new System.Windows.Forms.ListBox();
            this.richTextBoxForInstruction = new System.Windows.Forms.RichTextBox();
            this.textBoxSearchRecipe = new System.Windows.Forms.TextBox();
            this.butSearchRecipe = new System.Windows.Forms.Button();
            this.addNameRecipeTextBox = new System.Windows.Forms.TextBox();
            this.addInstrRecipeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.deleteRecipeButton = new System.Windows.Forms.Button();
            this.labelDeleteRecipe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.showAllIngredientsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteIngredientButton = new System.Windows.Forms.Button();
            this.addIngredientToRecipeButton = new System.Windows.Forms.Button();
            this.updateInstructionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.changeRecipeNameButton = new System.Windows.Forms.Button();
            this.changeRecipeNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeIngredientNameButton = new System.Windows.Forms.Button();
            this.changeIngredientNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxAllRecipes
            // 
            this.listBoxAllRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllRecipes.FormattingEnabled = true;
            this.listBoxAllRecipes.ItemHeight = 25;
            this.listBoxAllRecipes.Location = new System.Drawing.Point(29, 81);
            this.listBoxAllRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAllRecipes.Name = "listBoxAllRecipes";
            this.listBoxAllRecipes.Size = new System.Drawing.Size(273, 279);
            this.listBoxAllRecipes.TabIndex = 0;
            this.listBoxAllRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxAllRecipes_SelectedIndexChanged);
            // 
            // listBoxSelRecIng
            // 
            this.listBoxAllIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllIngredients.FormattingEnabled = true;
            this.listBoxAllIngredients.ItemHeight = 25;
            this.listBoxAllIngredients.Location = new System.Drawing.Point(365, 81);
            this.listBoxAllIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAllIngredients.Name = "listBoxSelRecIng";
            this.listBoxAllIngredients.Size = new System.Drawing.Size(273, 279);
            this.listBoxAllIngredients.TabIndex = 1;
            // 
            // richTextBoxForInstruction
            // 
            this.richTextBoxForInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxForInstruction.Location = new System.Drawing.Point(715, 81);
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
            // deleteRecipeButton
            // 
            this.deleteRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteRecipeButton.Location = new System.Drawing.Point(1328, 336);
            this.deleteRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRecipeButton.Name = "deleteRecipeButton";
            this.deleteRecipeButton.Size = new System.Drawing.Size(104, 38);
            this.deleteRecipeButton.TabIndex = 10;
            this.deleteRecipeButton.Text = "Delete";
            this.deleteRecipeButton.UseVisualStyleBackColor = true;
            this.deleteRecipeButton.Click += new System.EventHandler(this.deleteRecipeButton_Click);
            // 
            // labelDeleteRecipe
            // 
            this.labelDeleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDeleteRecipe.Location = new System.Drawing.Point(1066, 335);
            this.labelDeleteRecipe.Name = "labelDeleteRecipe";
            this.labelDeleteRecipe.Size = new System.Drawing.Size(229, 39);
            this.labelDeleteRecipe.TabIndex = 11;
            this.labelDeleteRecipe.Text = "Delete Selected Recipe: ";
            this.labelDeleteRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(422, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Ingredient";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addIngredientTextBox
            // 
            this.addIngredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addIngredientTextBox.Location = new System.Drawing.Point(371, 519);
            this.addIngredientTextBox.Name = "addIngredientTextBox";
            this.addIngredientTextBox.Size = new System.Drawing.Size(275, 30);
            this.addIngredientTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(57, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search Recipe by Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addIngredientButton.Location = new System.Drawing.Point(399, 574);
            this.addIngredientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(219, 49);
            this.addIngredientButton.TabIndex = 15;
            this.addIngredientButton.Text = "Add New Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // showAllIngredientsButton
            // 
            this.showAllIngredientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showAllIngredientsButton.Location = new System.Drawing.Point(391, 22);
            this.showAllIngredientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.showAllIngredientsButton.Name = "showAllIngredientsButton";
            this.showAllIngredientsButton.Size = new System.Drawing.Size(206, 41);
            this.showAllIngredientsButton.TabIndex = 16;
            this.showAllIngredientsButton.Text = "Show all Ingredients";
            this.showAllIngredientsButton.UseVisualStyleBackColor = true;
            this.showAllIngredientsButton.Click += new System.EventHandler(this.showAllIngredientsButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1066, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Delete Selected Ingredient: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteIngredientButton
            // 
            this.deleteIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteIngredientButton.Location = new System.Drawing.Point(1330, 402);
            this.deleteIngredientButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteIngredientButton.Name = "deleteIngredientButton";
            this.deleteIngredientButton.Size = new System.Drawing.Size(104, 38);
            this.deleteIngredientButton.TabIndex = 17;
            this.deleteIngredientButton.Text = "Delete";
            this.deleteIngredientButton.UseVisualStyleBackColor = true;
            this.deleteIngredientButton.Click += new System.EventHandler(this.deleteIngredientButton_Click);
            // 
            // addIngredientToRecipeButton
            // 
            this.addIngredientToRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addIngredientToRecipeButton.Location = new System.Drawing.Point(371, 366);
            this.addIngredientToRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addIngredientToRecipeButton.Name = "addIngredientToRecipeButton";
            this.addIngredientToRecipeButton.Size = new System.Drawing.Size(264, 49);
            this.addIngredientToRecipeButton.TabIndex = 19;
            this.addIngredientToRecipeButton.Text = "Add Ingredient to Recipe";
            this.addIngredientToRecipeButton.UseVisualStyleBackColor = true;
            this.addIngredientToRecipeButton.Click += new System.EventHandler(this.addIngredientToRecipeButton_Click);
            // 
            // updateInstructionButton
            // 
            this.updateInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateInstructionButton.Location = new System.Drawing.Point(733, 366);
            this.updateInstructionButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateInstructionButton.Name = "updateInstructionButton";
            this.updateInstructionButton.Size = new System.Drawing.Size(264, 49);
            this.updateInstructionButton.TabIndex = 20;
            this.updateInstructionButton.Text = "Update Instruction";
            this.updateInstructionButton.UseVisualStyleBackColor = true;
            this.updateInstructionButton.Click += new System.EventHandler(this.updateInstructionButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(880, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 39);
            this.label5.TabIndex = 23;
            this.label5.Text = "Change Recepe Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeRecipeNameButton
            // 
            this.changeRecipeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeRecipeNameButton.Location = new System.Drawing.Point(935, 586);
            this.changeRecipeNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeRecipeNameButton.Name = "changeRecipeNameButton";
            this.changeRecipeNameButton.Size = new System.Drawing.Size(124, 37);
            this.changeRecipeNameButton.TabIndex = 22;
            this.changeRecipeNameButton.Text = "Change";
            this.changeRecipeNameButton.UseVisualStyleBackColor = true;
            this.changeRecipeNameButton.Click += new System.EventHandler(this.changeRecipeNameButton_Click);
            // 
            // changeRecipeNameTextBox
            // 
            this.changeRecipeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeRecipeNameTextBox.Location = new System.Drawing.Point(885, 544);
            this.changeRecipeNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.changeRecipeNameTextBox.Name = "changeRecipeNameTextBox";
            this.changeRecipeNameTextBox.Size = new System.Drawing.Size(220, 30);
            this.changeRecipeNameTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(1129, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Change Ingredient Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeIngredientNameButton
            // 
            this.changeIngredientNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeIngredientNameButton.Location = new System.Drawing.Point(1184, 586);
            this.changeIngredientNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeIngredientNameButton.Name = "changeIngredientNameButton";
            this.changeIngredientNameButton.Size = new System.Drawing.Size(124, 37);
            this.changeIngredientNameButton.TabIndex = 25;
            this.changeIngredientNameButton.Text = "Change";
            this.changeIngredientNameButton.UseVisualStyleBackColor = true;
            this.changeIngredientNameButton.Click += new System.EventHandler(this.changeIngredientNameButton_Click);
            // 
            // changeIngredientNameTextBox
            // 
            this.changeIngredientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeIngredientNameTextBox.Location = new System.Drawing.Point(1134, 544);
            this.changeIngredientNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.changeIngredientNameTextBox.Name = "changeIngredientNameTextBox";
            this.changeIngredientNameTextBox.Size = new System.Drawing.Size(220, 30);
            this.changeIngredientNameTextBox.TabIndex = 24;
            // 
            // RecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 797);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changeIngredientNameButton);
            this.Controls.Add(this.changeIngredientNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeRecipeNameButton);
            this.Controls.Add(this.changeRecipeNameTextBox);
            this.Controls.Add(this.updateInstructionButton);
            this.Controls.Add(this.addIngredientToRecipeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteIngredientButton);
            this.Controls.Add(this.showAllIngredientsButton);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addIngredientTextBox);
            this.Controls.Add(this.labelDeleteRecipe);
            this.Controls.Add(this.deleteRecipeButton);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addInstrRecipeTextBox);
            this.Controls.Add(this.addNameRecipeTextBox);
            this.Controls.Add(this.butSearchRecipe);
            this.Controls.Add(this.textBoxSearchRecipe);
            this.Controls.Add(this.richTextBoxForInstruction);
            this.Controls.Add(this.listBoxAllIngredients);
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
        private System.Windows.Forms.ListBox listBoxAllIngredients;
        private System.Windows.Forms.RichTextBox richTextBoxForInstruction;
        private System.Windows.Forms.TextBox textBoxSearchRecipe;
        private System.Windows.Forms.Button butSearchRecipe;
        private System.Windows.Forms.TextBox addNameRecipeTextBox;
        private System.Windows.Forms.TextBox addInstrRecipeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.Button deleteRecipeButton;
        private System.Windows.Forms.Label labelDeleteRecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addIngredientTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button showAllIngredientsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteIngredientButton;
        private System.Windows.Forms.Button addIngredientToRecipeButton;
        private System.Windows.Forms.Button updateInstructionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changeRecipeNameButton;
        private System.Windows.Forms.TextBox changeRecipeNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeIngredientNameButton;
        private System.Windows.Forms.TextBox changeIngredientNameTextBox;
    }
}

