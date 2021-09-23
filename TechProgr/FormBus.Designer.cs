
namespace TechProgr
{
	partial class FormBus
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBus));
			this.pictureBoxBus = new System.Windows.Forms.PictureBox();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonCreateBus = new System.Windows.Forms.Button();
			this.buttonCreateTwoFloorBus = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxBus
			// 
			this.pictureBoxBus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxBus.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxBus.Name = "pictureBoxBus";
			this.pictureBoxBus.Size = new System.Drawing.Size(900, 500);
			this.pictureBoxBus.TabIndex = 0;
			this.pictureBoxBus.TabStop = false;
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(850, 375);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(40, 40);
			this.buttonRight.TabIndex = 1;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttomMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(804, 375);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(40, 40);
			this.buttonDown.TabIndex = 2;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttomMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(758, 375);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(40, 40);
			this.buttonLeft.TabIndex = 3;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttomMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(804, 329);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(40, 40);
			this.buttonUp.TabIndex = 4;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttomMove_Click);
			// 
			// buttonCreateBus
			// 
			this.buttonCreateBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateBus.BackColor = System.Drawing.SystemColors.Control;
			this.buttonCreateBus.Location = new System.Drawing.Point(758, 421);
			this.buttonCreateBus.Name = "buttonCreateBus";
			this.buttonCreateBus.Size = new System.Drawing.Size(131, 29);
			this.buttonCreateBus.TabIndex = 5;
			this.buttonCreateBus.Text = "Create Bus";
			this.buttonCreateBus.UseVisualStyleBackColor = false;
			this.buttonCreateBus.Click += new System.EventHandler(this.buttonCreateBus_Click);
			// 
			// buttonCreateTwoFloorBus
			// 
			this.buttonCreateTwoFloorBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateTwoFloorBus.BackColor = System.Drawing.SystemColors.Control;
			this.buttonCreateTwoFloorBus.Location = new System.Drawing.Point(758, 458);
			this.buttonCreateTwoFloorBus.Name = "buttonCreateTwoFloorBus";
			this.buttonCreateTwoFloorBus.Size = new System.Drawing.Size(131, 29);
			this.buttonCreateTwoFloorBus.TabIndex = 6;
			this.buttonCreateTwoFloorBus.Text = "Create TwoFloorBus";
			this.buttonCreateTwoFloorBus.UseVisualStyleBackColor = false;
			this.buttonCreateTwoFloorBus.Click += new System.EventHandler(this.buttonCreateTwoFloorBus_Click);
			// 
			// FormBus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.buttonCreateTwoFloorBus);
			this.Controls.Add(this.buttonCreateBus);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.pictureBoxBus);
			this.Name = "FormBus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormBus";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxBus;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonCreateBus;
		private System.Windows.Forms.Button buttonCreateTwoFloorBus;
	}
}

