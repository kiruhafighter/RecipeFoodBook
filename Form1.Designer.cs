
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
            this.deleteRecipeButton = new System.Windows.Forms.Button();
            this.labelDeleteRecipe = new System.Windows.Forms.Label();
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
            this.removeFromRecopeButton = new System.Windows.Forms.Button();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.ShowAllRecipesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAllRecipes
            // 
            this.listBoxAllRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllRecipes.FormattingEnabled = true;
            this.listBoxAllRecipes.ItemHeight = 20;
            this.listBoxAllRecipes.Location = new System.Drawing.Point(22, 77);
            this.listBoxAllRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAllRecipes.Name = "listBoxAllRecipes";
            this.listBoxAllRecipes.Size = new System.Drawing.Size(206, 224);
            this.listBoxAllRecipes.TabIndex = 0;
            this.listBoxAllRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxAllRecipes_SelectedIndexChanged);
            // 
            // listBoxAllIngredients
            // 
            this.listBoxAllIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllIngredients.FormattingEnabled = true;
            this.listBoxAllIngredients.ItemHeight = 20;
            this.listBoxAllIngredients.Location = new System.Drawing.Point(274, 77);
            this.listBoxAllIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAllIngredients.Name = "listBoxAllIngredients";
            this.listBoxAllIngredients.Size = new System.Drawing.Size(206, 224);
            this.listBoxAllIngredients.TabIndex = 1;
            // 
            // richTextBoxForInstruction
            // 
            this.richTextBoxForInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxForInstruction.Location = new System.Drawing.Point(536, 77);
            this.richTextBoxForInstruction.Name = "richTextBoxForInstruction";
            this.richTextBoxForInstruction.Size = new System.Drawing.Size(233, 227);
            this.richTextBoxForInstruction.TabIndex = 3;
            this.richTextBoxForInstruction.Text = "";
            // 
            // textBoxSearchRecipe
            // 
            this.textBoxSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchRecipe.Location = new System.Drawing.Point(22, 316);
            this.textBoxSearchRecipe.Name = "textBoxSearchRecipe";
            this.textBoxSearchRecipe.Size = new System.Drawing.Size(206, 26);
            this.textBoxSearchRecipe.TabIndex = 4;
            // 
            // butSearchRecipe
            // 
            this.butSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butSearchRecipe.Location = new System.Drawing.Point(68, 360);
            this.butSearchRecipe.Name = "butSearchRecipe";
            this.butSearchRecipe.Size = new System.Drawing.Size(117, 40);
            this.butSearchRecipe.TabIndex = 5;
            this.butSearchRecipe.Text = "Search";
            this.butSearchRecipe.UseVisualStyleBackColor = true;
            this.butSearchRecipe.Click += new System.EventHandler(this.butSearchRecipe_Click);
            // 
            // deleteRecipeButton
            // 
            this.deleteRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteRecipeButton.Location = new System.Drawing.Point(1035, 55);
            this.deleteRecipeButton.Name = "deleteRecipeButton";
            this.deleteRecipeButton.Size = new System.Drawing.Size(78, 31);
            this.deleteRecipeButton.TabIndex = 10;
            this.deleteRecipeButton.Text = "Delete";
            this.deleteRecipeButton.UseVisualStyleBackColor = true;
            this.deleteRecipeButton.Click += new System.EventHandler(this.deleteRecipeButton_Click);
            // 
            // labelDeleteRecipe
            // 
            this.labelDeleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDeleteRecipe.Location = new System.Drawing.Point(814, 54);
            this.labelDeleteRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteRecipe.Name = "labelDeleteRecipe";
            this.labelDeleteRecipe.Size = new System.Drawing.Size(207, 32);
            this.labelDeleteRecipe.TabIndex = 11;
            this.labelDeleteRecipe.Text = "Delete Selected Recipe: ";
            this.labelDeleteRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAllIngredientsButton
            // 
            this.showAllIngredientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showAllIngredientsButton.Location = new System.Drawing.Point(293, 39);
            this.showAllIngredientsButton.Name = "showAllIngredientsButton";
            this.showAllIngredientsButton.Size = new System.Drawing.Size(154, 33);
            this.showAllIngredientsButton.TabIndex = 16;
            this.showAllIngredientsButton.Text = "Show all Ingredients";
            this.showAllIngredientsButton.UseVisualStyleBackColor = true;
            this.showAllIngredientsButton.Click += new System.EventHandler(this.showAllIngredientsButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(789, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Delete Selected Ingredient: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteIngredientButton
            // 
            this.deleteIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteIngredientButton.Location = new System.Drawing.Point(1035, 110);
            this.deleteIngredientButton.Name = "deleteIngredientButton";
            this.deleteIngredientButton.Size = new System.Drawing.Size(78, 31);
            this.deleteIngredientButton.TabIndex = 17;
            this.deleteIngredientButton.Text = "Delete";
            this.deleteIngredientButton.UseVisualStyleBackColor = true;
            this.deleteIngredientButton.Click += new System.EventHandler(this.deleteIngredientButton_Click);
            // 
            // addIngredientToRecipeButton
            // 
            this.addIngredientToRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addIngredientToRecipeButton.Location = new System.Drawing.Point(274, 316);
            this.addIngredientToRecipeButton.Name = "addIngredientToRecipeButton";
            this.addIngredientToRecipeButton.Size = new System.Drawing.Size(206, 42);
            this.addIngredientToRecipeButton.TabIndex = 19;
            this.addIngredientToRecipeButton.Text = "Add Ingredient to Recipe";
            this.addIngredientToRecipeButton.UseVisualStyleBackColor = true;
            this.addIngredientToRecipeButton.Click += new System.EventHandler(this.addIngredientToRecipeButton_Click);
            // 
            // updateInstructionButton
            // 
            this.updateInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateInstructionButton.Location = new System.Drawing.Point(550, 308);
            this.updateInstructionButton.Name = "updateInstructionButton";
            this.updateInstructionButton.Size = new System.Drawing.Size(198, 40);
            this.updateInstructionButton.TabIndex = 20;
            this.updateInstructionButton.Text = "Update Instruction";
            this.updateInstructionButton.UseVisualStyleBackColor = true;
            this.updateInstructionButton.Click += new System.EventHandler(this.updateInstructionButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(44, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 42);
            this.label5.TabIndex = 23;
            this.label5.Text = "Change Recipe Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeRecipeNameButton
            // 
            this.changeRecipeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeRecipeNameButton.Location = new System.Drawing.Point(78, 530);
            this.changeRecipeNameButton.Name = "changeRecipeNameButton";
            this.changeRecipeNameButton.Size = new System.Drawing.Size(93, 30);
            this.changeRecipeNameButton.TabIndex = 22;
            this.changeRecipeNameButton.Text = "Change";
            this.changeRecipeNameButton.UseVisualStyleBackColor = true;
            this.changeRecipeNameButton.Click += new System.EventHandler(this.changeRecipeNameButton_Click);
            // 
            // changeRecipeNameTextBox
            // 
            this.changeRecipeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeRecipeNameTextBox.Location = new System.Drawing.Point(47, 496);
            this.changeRecipeNameTextBox.Name = "changeRecipeNameTextBox";
            this.changeRecipeNameTextBox.Size = new System.Drawing.Size(166, 26);
            this.changeRecipeNameTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(289, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 40);
            this.label6.TabIndex = 26;
            this.label6.Text = "Change Ingredient Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeIngredientNameButton
            // 
            this.changeIngredientNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeIngredientNameButton.Location = new System.Drawing.Point(325, 530);
            this.changeIngredientNameButton.Name = "changeIngredientNameButton";
            this.changeIngredientNameButton.Size = new System.Drawing.Size(93, 30);
            this.changeIngredientNameButton.TabIndex = 25;
            this.changeIngredientNameButton.Text = "Change";
            this.changeIngredientNameButton.UseVisualStyleBackColor = true;
            this.changeIngredientNameButton.Click += new System.EventHandler(this.changeIngredientNameButton_Click);
            // 
            // changeIngredientNameTextBox
            // 
            this.changeIngredientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeIngredientNameTextBox.Location = new System.Drawing.Point(293, 498);
            this.changeIngredientNameTextBox.Name = "changeIngredientNameTextBox";
            this.changeIngredientNameTextBox.Size = new System.Drawing.Size(166, 26);
            this.changeIngredientNameTextBox.TabIndex = 24;
            // 
            // removeFromRecopeButton
            // 
            this.removeFromRecopeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeFromRecopeButton.Location = new System.Drawing.Point(274, 375);
            this.removeFromRecopeButton.Name = "removeFromRecopeButton";
            this.removeFromRecopeButton.Size = new System.Drawing.Size(206, 42);
            this.removeFromRecopeButton.TabIndex = 27;
            this.removeFromRecopeButton.Text = "Remove from Recipe";
            this.removeFromRecopeButton.UseVisualStyleBackColor = true;
            this.removeFromRecopeButton.Click += new System.EventHandler(this.removeFromRecopeButton_Click);
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddRecipe.Location = new System.Drawing.Point(913, 191);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(200, 59);
            this.buttonAddRecipe.TabIndex = 28;
            this.buttonAddRecipe.Text = "Add New Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddIngredient.Location = new System.Drawing.Point(913, 289);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(200, 59);
            this.buttonAddIngredient.TabIndex = 29;
            this.buttonAddIngredient.Text = "Add New Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // ShowAllRecipesButton
            // 
            this.ShowAllRecipesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowAllRecipesButton.Location = new System.Drawing.Point(47, 39);
            this.ShowAllRecipesButton.Name = "ShowAllRecipesButton";
            this.ShowAllRecipesButton.Size = new System.Drawing.Size(154, 33);
            this.ShowAllRecipesButton.TabIndex = 30;
            this.ShowAllRecipesButton.Text = "Show all Ingredients";
            this.ShowAllRecipesButton.UseVisualStyleBackColor = true;
            this.ShowAllRecipesButton.Click += new System.EventHandler(this.ShowAllRecipesButton_Click);
            // 
            // RecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 648);
            this.Controls.Add(this.ShowAllRecipesButton);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.removeFromRecopeButton);
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
            this.Controls.Add(this.labelDeleteRecipe);
            this.Controls.Add(this.deleteRecipeButton);
            this.Controls.Add(this.butSearchRecipe);
            this.Controls.Add(this.textBoxSearchRecipe);
            this.Controls.Add(this.richTextBoxForInstruction);
            this.Controls.Add(this.listBoxAllIngredients);
            this.Controls.Add(this.listBoxAllRecipes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecipeBook";
            this.Text = "RecipeBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button deleteRecipeButton;
        private System.Windows.Forms.Label labelDeleteRecipe;
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
        private System.Windows.Forms.Button removeFromRecopeButton;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button ShowAllRecipesButton;
    }
}

