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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMenuSearch = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pbx메인 = new System.Windows.Forms.PictureBox();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblUser = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx메인)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
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
            this.splitContainer1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(797, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 38);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(859, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfo.Location = new System.Drawing.Point(1113, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(56, 38);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.TabStop = false;
            this.btnInfo.Text = "정보";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(983, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(1051, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 38);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = false;
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
            this.splitContainer2.Panel2.Controls.Add(this.pbx메인);
            this.splitContainer2.Panel2.Controls.Add(this.metroTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 659);
            this.splitContainer2.SplitterDistance = 188;
            this.splitContainer2.TabIndex = 2;
            this.splitContainer2.TabStop = false;
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
            this.splitContainer3.TabStop = false;
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
            this.txbMenuSearch.Size = new System.Drawing.Size(116, 21);
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
            this.listBox.TabStop = false;
            this.listBox.Visible = false;
            this.listBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            this.listBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyUp);
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
            // pbx메인
            // 
            this.pbx메인.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx메인.Image = global::SMART_ERP_System.Properties.Resources.background;
            this.pbx메인.Location = new System.Drawing.Point(0, 0);
            this.pbx메인.Name = "pbx메인";
            this.pbx메인.Size = new System.Drawing.Size(1044, 655);
            this.pbx메인.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx메인.TabIndex = 1;
            this.pbx메인.TabStop = false;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(1044, 655);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MetroTabControl_MouseClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ERP";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(23, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(514, 33);
            this.lblUser.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.NotifyTest_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx메인)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
        private ListBox listBox;
        private Button btnSearch;
        private Button btnDelete;
        private PictureBox pbx메인;
        private NotifyIcon notifyIcon;
        private Label lblUser;
    }
}

