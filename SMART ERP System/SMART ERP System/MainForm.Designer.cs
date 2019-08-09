using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SMART_ERP_System;
using SMART_ERP_System.MenuUserControl;

namespace SMART_ERP_System
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMenuSearch = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 708);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 10;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(1113, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(56, 45);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "정보";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(983, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1051, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 45);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ERP 솔루션";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.metroTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 659);
            this.splitContainer2.SplitterDistance = 188;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnMenuSearch);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.txbMenuSearch);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listBox);
            this.splitContainer3.Panel2.Controls.Add(this.treeView);
            this.splitContainer3.Size = new System.Drawing.Size(188, 659);
            this.splitContainer3.SplitterDistance = 38;
            this.splitContainer3.TabIndex = 6;
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.Location = new System.Drawing.Point(121, 7);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(42, 22);
            this.btnMenuSearch.TabIndex = 4;
            this.btnMenuSearch.Text = "Go";
            this.btnMenuSearch.UseVisualStyleBackColor = true;
            this.btnMenuSearch.Click += new System.EventHandler(this.BtnMenuSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = global::SMART_ERP_System.Properties.Resources.find;
            this.label2.Location = new System.Drawing.Point(7, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 3;
            // 
            // txbMenuSearch
            // 
            this.txbMenuSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMenuSearch.Location = new System.Drawing.Point(47, 6);
            this.txbMenuSearch.Name = "txbMenuSearch";
            this.txbMenuSearch.Size = new System.Drawing.Size(68, 21);
            this.txbMenuSearch.TabIndex = 2;
            this.txbMenuSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbMenuSearch_KeyUp);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(47, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(116, 88);
            this.listBox.TabIndex = 12;
            this.listBox.Visible = false;
            this.listBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(184, 613);
            this.treeView.TabIndex = 2;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(1044, 655);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMenuSearch;
        private System.Windows.Forms.Button btnInfo;

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private Button btnMenuSearch;
        private ListBox listBox;
    }
}

