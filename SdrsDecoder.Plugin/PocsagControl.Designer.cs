﻿
namespace SdrsDecoder.Plugin
{
    partial class PocsagControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            checkBoxDeDuplicate = new System.Windows.Forms.CheckBox();
            checkBoxHideBad = new System.Windows.Forms.CheckBox();
            buttonClear = new System.Windows.Forms.Button();
            checkBoxMultiline = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            label1 = new System.Windows.Forms.Label();
            modeSelector = new System.Windows.Forms.ComboBox();
            checkBoxLogging = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            textBoxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Timestamp, Protocol, Address, Errors, Type, Payload, Data });
            dataGridView1.Location = new System.Drawing.Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(1418, 432);
            dataGridView1.TabIndex = 0;
            // 
            // Timestamp
            // 
            Timestamp.DataPropertyName = "TimestampText";
            Timestamp.HeaderText = "Timestamp";
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            Timestamp.Width = 97;
            // 
            // Protocol
            // 
            Protocol.DataPropertyName = "Protocol";
            Protocol.HeaderText = "Protocol";
            Protocol.Name = "Protocol";
            Protocol.ReadOnly = true;
            Protocol.Width = 82;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            Address.DefaultCellStyle = dataGridViewCellStyle1;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 81;
            // 
            // Errors
            // 
            Errors.DataPropertyName = "ErrorText";
            Errors.HeaderText = "Error(s)";
            Errors.Name = "Errors";
            Errors.ReadOnly = true;
            Errors.Width = 77;
            // 
            // Type
            // 
            Type.DataPropertyName = "TypeText";
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 61;
            // 
            // Payload
            // 
            Payload.DataPropertyName = "Payload";
            Payload.HeaderText = "Payload";
            Payload.Name = "Payload";
            Payload.ReadOnly = true;
            Payload.Width = 79;
            // 
            // Data
            // 
            Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // checkBoxDeDuplicate
            // 
            checkBoxDeDuplicate.AutoSize = true;
            checkBoxDeDuplicate.Location = new System.Drawing.Point(5, 6);
            checkBoxDeDuplicate.Name = "checkBoxDeDuplicate";
            checkBoxDeDuplicate.Size = new System.Drawing.Size(101, 21);
            checkBoxDeDuplicate.TabIndex = 1;
            checkBoxDeDuplicate.Text = "De-duplicate";
            checkBoxDeDuplicate.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideBad
            // 
            checkBoxHideBad.AutoSize = true;
            checkBoxHideBad.Location = new System.Drawing.Point(106, 6);
            checkBoxHideBad.Name = "checkBoxHideBad";
            checkBoxHideBad.Size = new System.Drawing.Size(135, 21);
            checkBoxHideBad.TabIndex = 2;
            checkBoxHideBad.Text = "Hide bad decodes";
            checkBoxHideBad.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonClear.Location = new System.Drawing.Point(1342, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(75, 26);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            toolTip1.SetToolTip(buttonClear, "Clear all entries from the table");
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiline
            // 
            checkBoxMultiline.AutoSize = true;
            checkBoxMultiline.Location = new System.Drawing.Point(234, 6);
            checkBoxMultiline.Name = "checkBoxMultiline";
            checkBoxMultiline.Size = new System.Drawing.Size(110, 21);
            checkBoxMultiline.TabIndex = 4;
            checkBoxMultiline.Text = "Wrap payload";
            checkBoxMultiline.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(415, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 17);
            label1.TabIndex = 5;
            label1.Text = "Mode";
            // 
            // modeSelector
            // 
            modeSelector.FormattingEnabled = true;
            modeSelector.Location = new System.Drawing.Point(459, 3);
            modeSelector.Name = "modeSelector";
            modeSelector.Size = new System.Drawing.Size(196, 25);
            modeSelector.TabIndex = 6;
            // 
            // checkBoxLogging
            // 
            checkBoxLogging.AutoSize = true;
            checkBoxLogging.Location = new System.Drawing.Point(339, 6);
            checkBoxLogging.Name = "checkBoxLogging";
            checkBoxLogging.Size = new System.Drawing.Size(75, 21);
            checkBoxLogging.TabIndex = 7;
            checkBoxLogging.Text = "Logging";
            checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(661, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 17);
            label2.TabIndex = 8;
            label2.Text = "Filter";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new System.Drawing.Point(700, 3);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new System.Drawing.Size(200, 23);
            textBoxFilter.TabIndex = 9;
            // 
            // PocsagControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(textBoxFilter);
            Controls.Add(label2);
            Controls.Add(checkBoxLogging);
            Controls.Add(modeSelector);
            Controls.Add(label1);
            Controls.Add(checkBoxMultiline);
            Controls.Add(buttonClear);
            Controls.Add(checkBoxHideBad);
            Controls.Add(checkBoxDeDuplicate);
            Controls.Add(dataGridView1);
            Name = "PocsagControl";
            Size = new System.Drawing.Size(1418, 466);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxDeDuplicate;
        private System.Windows.Forms.CheckBox checkBoxHideBad;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxMultiline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modeSelector;
        private System.Windows.Forms.CheckBox checkBoxLogging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Errors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}
