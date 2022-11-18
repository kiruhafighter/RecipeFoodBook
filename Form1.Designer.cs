
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
            this.SuspendLayout();
            // 
            // listBoxAllRecipes
            // 
            this.listBoxAllRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAllRecipes.FormattingEnabled = true;
            this.listBoxAllRecipes.ItemHeight = 20;
            this.listBoxAllRecipes.Location = new System.Drawing.Point(28, 112);
            this.listBoxAllRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAllRecipes.Name = "listBoxAllRecipes";
            this.listBoxAllRecipes.Size = new System.Drawing.Size(206, 244);
            this.listBoxAllRecipes.TabIndex = 0;
            this.listBoxAllRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxAllRecipes_SelectedIndexChanged);
            // 
            // listBoxSelRecIng
            // 
            this.listBoxSelRecIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSelRecIng.FormattingEnabled = true;
            this.listBoxSelRecIng.ItemHeight = 20;
            this.listBoxSelRecIng.Location = new System.Drawing.Point(280, 112);
            this.listBoxSelRecIng.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSelRecIng.Name = "listBoxSelRecIng";
            this.listBoxSelRecIng.Size = new System.Drawing.Size(206, 244);
            this.listBoxSelRecIng.TabIndex = 1;
            // 
            // richTextBoxForInstruction
            // 
            this.richTextBoxForInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxForInstruction.Location = new System.Drawing.Point(532, 112);
            this.richTextBoxForInstruction.Name = "richTextBoxForInstruction";
            this.richTextBoxForInstruction.Size = new System.Drawing.Size(199, 244);
            this.richTextBoxForInstruction.TabIndex = 3;
            this.richTextBoxForInstruction.Text = "";
            // 
            // textBoxSearchRecipe
            // 
            this.textBoxSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchRecipe.Location = new System.Drawing.Point(28, 422);
            this.textBoxSearchRecipe.Name = "textBoxSearchRecipe";
            this.textBoxSearchRecipe.Size = new System.Drawing.Size(206, 26);
            this.textBoxSearchRecipe.TabIndex = 4;
            // 
            // butSearchRecipe
            // 
            this.butSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butSearchRecipe.Location = new System.Drawing.Point(69, 466);
            this.butSearchRecipe.Name = "butSearchRecipe";
            this.butSearchRecipe.Size = new System.Drawing.Size(117, 40);
            this.butSearchRecipe.TabIndex = 5;
            this.butSearchRecipe.Text = "Search";
            this.butSearchRecipe.UseVisualStyleBackColor = true;
            this.butSearchRecipe.Click += new System.EventHandler(this.butSearchRecipe_Click);
            // 
            // RecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 611);
            this.Controls.Add(this.butSearchRecipe);
            this.Controls.Add(this.textBoxSearchRecipe);
            this.Controls.Add(this.richTextBoxForInstruction);
            this.Controls.Add(this.listBoxSelRecIng);
            this.Controls.Add(this.listBoxAllRecipes);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

