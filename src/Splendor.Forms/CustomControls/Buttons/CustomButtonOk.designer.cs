namespace Splendor.Forms
{
    partial class CustomButtonOk
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomButtonOk
            // 
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IconColor = System.Drawing.Color.White;
            this.IconSize = 40;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(70, 50);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
