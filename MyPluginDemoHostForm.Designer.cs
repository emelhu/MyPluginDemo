namespace MyPluginDemo
{
  partial class myPluginHostForm
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
      this.operand1Label = new System.Windows.Forms.Label();
      this.operand2Label = new System.Windows.Forms.Label();
      this.Operand1TextBox = new System.Windows.Forms.TextBox();
      this.Operand2TextBox = new System.Windows.Forms.TextBox();
      this.OperateButton = new System.Windows.Forms.Button();
      this.resultLabel = new System.Windows.Forms.Label();
      this.resultViewLabel = new System.Windows.Forms.Label();
      this.operationListBox = new System.Windows.Forms.ListBox();
      this.operationLabel = new System.Windows.Forms.Label();
      this.messageLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // operand1Label
      // 
      this.operand1Label.AutoSize = true;
      this.operand1Label.Location = new System.Drawing.Point(126, 18);
      this.operand1Label.Name = "operand1Label";
      this.operand1Label.Size = new System.Drawing.Size(60, 13);
      this.operand1Label.TabIndex = 0;
      this.operand1Label.Text = "Operand 1:";
      // 
      // operand2Label
      // 
      this.operand2Label.AutoSize = true;
      this.operand2Label.Location = new System.Drawing.Point(126, 48);
      this.operand2Label.Name = "operand2Label";
      this.operand2Label.Size = new System.Drawing.Size(60, 13);
      this.operand2Label.TabIndex = 3;
      this.operand2Label.Text = "Operand 2:";
      // 
      // Operand1TextBox
      // 
      this.Operand1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Operand1TextBox.Location = new System.Drawing.Point(192, 15);
      this.Operand1TextBox.Name = "Operand1TextBox";
      this.Operand1TextBox.Size = new System.Drawing.Size(100, 22);
      this.Operand1TextBox.TabIndex = 6;
      this.Operand1TextBox.Text = "2";
      this.Operand1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Operand1TextBox.TextChanged += new System.EventHandler(this.Operand1TextBox_TextChanged);
      // 
      // Operand2TextBox
      // 
      this.Operand2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Operand2TextBox.Location = new System.Drawing.Point(192, 45);
      this.Operand2TextBox.Name = "Operand2TextBox";
      this.Operand2TextBox.Size = new System.Drawing.Size(100, 22);
      this.Operand2TextBox.TabIndex = 7;
      this.Operand2TextBox.Text = "3";
      this.Operand2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Operand2TextBox.TextChanged += new System.EventHandler(this.Operand1TextBox_TextChanged);
      // 
      // OperateButton
      // 
      this.OperateButton.Enabled = false;
      this.OperateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.OperateButton.ForeColor = System.Drawing.Color.Crimson;
      this.OperateButton.Location = new System.Drawing.Point(307, 15);
      this.OperateButton.Name = "OperateButton";
      this.OperateButton.Size = new System.Drawing.Size(98, 50);
      this.OperateButton.TabIndex = 8;
      this.OperateButton.Text = "Operate";
      this.OperateButton.UseVisualStyleBackColor = true;
      this.OperateButton.Click += new System.EventHandler(this.OperateButton_Click);
      // 
      // resultLabel
      // 
      this.resultLabel.AutoSize = true;
      this.resultLabel.Location = new System.Drawing.Point(126, 84);
      this.resultLabel.Name = "resultLabel";
      this.resultLabel.Size = new System.Drawing.Size(40, 13);
      this.resultLabel.TabIndex = 9;
      this.resultLabel.Text = "Result:";
      // 
      // resultViewLabel
      // 
      this.resultViewLabel.BackColor = System.Drawing.Color.Linen;
      this.resultViewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.resultViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.resultViewLabel.ForeColor = System.Drawing.Color.Brown;
      this.resultViewLabel.Location = new System.Drawing.Point(192, 76);
      this.resultViewLabel.Name = "resultViewLabel";
      this.resultViewLabel.Size = new System.Drawing.Size(100, 28);
      this.resultViewLabel.TabIndex = 10;
      this.resultViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // operationListBox
      // 
      this.operationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.operationListBox.ForeColor = System.Drawing.Color.Maroon;
      this.operationListBox.FormattingEnabled = true;
      this.operationListBox.ItemHeight = 16;
      this.operationListBox.Items.AddRange(new object[] {
            "Add",
            "Multiply",
            "Maximum"});
      this.operationListBox.Location = new System.Drawing.Point(25, 34);
      this.operationListBox.Name = "operationListBox";
      this.operationListBox.Size = new System.Drawing.Size(75, 52);
      this.operationListBox.TabIndex = 1;
      this.operationListBox.SelectedIndexChanged += new System.EventHandler(this.operationListBox_SelectedIndexChanged);
      // 
      // operationLabel
      // 
      this.operationLabel.AutoSize = true;
      this.operationLabel.Location = new System.Drawing.Point(22, 18);
      this.operationLabel.Name = "operationLabel";
      this.operationLabel.Size = new System.Drawing.Size(56, 13);
      this.operationLabel.TabIndex = 11;
      this.operationLabel.Text = "Operation:";
      // 
      // messageLabel
      // 
      this.messageLabel.BackColor = System.Drawing.SystemColors.Info;
      this.messageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.messageLabel.ForeColor = System.Drawing.Color.OrangeRed;
      this.messageLabel.Location = new System.Drawing.Point(0, 116);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(417, 13);
      this.messageLabel.TabIndex = 12;
      this.messageLabel.Text = "Select \'Operation\' and set \'Operands\' than click \'Operate\' button.";
      this.messageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      // 
      // myPluginHostForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(417, 129);
      this.Controls.Add(this.messageLabel);
      this.Controls.Add(this.operationLabel);
      this.Controls.Add(this.operationListBox);
      this.Controls.Add(this.resultViewLabel);
      this.Controls.Add(this.resultLabel);
      this.Controls.Add(this.OperateButton);
      this.Controls.Add(this.Operand2TextBox);
      this.Controls.Add(this.Operand1TextBox);
      this.Controls.Add(this.operand2Label);
      this.Controls.Add(this.operand1Label);
      this.Name = "myPluginHostForm";
      this.Text = "My Plugin Demo Host Form by eMeL";
      this.Load += new System.EventHandler(this.myPluginHostForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label operand1Label;
    private System.Windows.Forms.Label operand2Label;
    private System.Windows.Forms.TextBox Operand1TextBox;
    private System.Windows.Forms.TextBox Operand2TextBox;
    private System.Windows.Forms.Button OperateButton;
    private System.Windows.Forms.Label resultLabel;
    private System.Windows.Forms.Label resultViewLabel;
    private System.Windows.Forms.ListBox operationListBox;
    private System.Windows.Forms.Label operationLabel;
    private System.Windows.Forms.Label messageLabel;

  }
}

