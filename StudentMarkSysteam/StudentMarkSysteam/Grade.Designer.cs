namespace StudentMarkSysteam
{
    partial class Grade
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
            this.dgvGraded = new System.Windows.Forms.DataGridView();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtAtten = new System.Windows.Forms.TextBox();
            this.txtAssm1 = new System.Windows.Forms.TextBox();
            this.txtAssm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraded)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGraded
            // 
            this.dgvGraded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraded.Location = new System.Drawing.Point(58, 337);
            this.dgvGraded.Name = "dgvGraded";
            this.dgvGraded.RowHeadersWidth = 51;
            this.dgvGraded.RowTemplate.Height = 24;
            this.dgvGraded.Size = new System.Drawing.Size(1293, 333);
            this.dgvGraded.TabIndex = 0;
            this.dgvGraded.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGraded_CellContentClick);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(437, 71);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(156, 22);
            this.txtSID.TabIndex = 1;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(437, 130);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(156, 22);
            this.txtCID.TabIndex = 2;
            // 
            // txtAtten
            // 
            this.txtAtten.Location = new System.Drawing.Point(437, 191);
            this.txtAtten.Name = "txtAtten";
            this.txtAtten.Size = new System.Drawing.Size(155, 22);
            this.txtAtten.TabIndex = 3;
            // 
            // txtAssm1
            // 
            this.txtAssm1.Location = new System.Drawing.Point(970, 71);
            this.txtAssm1.Name = "txtAssm1";
            this.txtAssm1.Size = new System.Drawing.Size(155, 22);
            this.txtAssm1.TabIndex = 4;
            // 
            // txtAssm2
            // 
            this.txtAssm2.Location = new System.Drawing.Point(970, 152);
            this.txtAssm2.Name = "txtAssm2";
            this.txtAssm2.Size = new System.Drawing.Size(155, 22);
            this.txtAssm2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(294, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(294, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(294, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attendance:";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labell.Location = new System.Drawing.Point(792, 69);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(129, 24);
            this.labell.TabIndex = 9;
            this.labell.Text = "Assignment 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(792, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Assignment 2:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1055, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(790, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(527, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1422, 703);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssm2);
            this.Controls.Add(this.txtAssm1);
            this.Controls.Add(this.txtAtten);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.dgvGraded);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGraded;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtAtten;
        private System.Windows.Forms.TextBox txtAssm1;
        private System.Windows.Forms.TextBox txtAssm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}