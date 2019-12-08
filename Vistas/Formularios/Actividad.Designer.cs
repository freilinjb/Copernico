namespace Vistas.Formularios
{
    partial class Actividad
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
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn1 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn2 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn3 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem1 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem2 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem3 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem1 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem2 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem3 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            ganttViewTextViewColumn1.DataType = null;
            ganttViewTextViewColumn1.FieldName = "";
            ganttViewTextViewColumn1.HeaderText = "";
            ganttViewTextViewColumn1.Name = "column1";
            ganttViewTextViewColumn2.DataType = null;
            ganttViewTextViewColumn2.FieldName = "";
            ganttViewTextViewColumn2.HeaderText = "";
            ganttViewTextViewColumn2.Name = "column2";
            ganttViewTextViewColumn3.DataType = null;
            ganttViewTextViewColumn3.FieldName = "";
            ganttViewTextViewColumn3.HeaderText = "";
            ganttViewTextViewColumn3.Name = "column3";
            this.radGanttView1.Columns.AddRange(new Telerik.WinControls.UI.GanttViewTextViewColumn[] {
            ganttViewTextViewColumn1,
            ganttViewTextViewColumn2,
            ganttViewTextViewColumn3});
            this.radGanttView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            ganttViewDataItem1.End = new System.DateTime(((long)(0)));
            ganttViewDataItem1.Expanded = true;
            ganttViewDataItem1.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem1.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem1.Title = null;
            ganttViewDataItem1.Visible = true;
            ganttViewDataItem2.End = new System.DateTime(((long)(0)));
            ganttViewDataItem2.Expanded = true;
            ganttViewDataItem2.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem2.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem2.Title = null;
            ganttViewDataItem2.Visible = true;
            ganttViewDataItem3.End = new System.DateTime(((long)(0)));
            ganttViewDataItem3.Expanded = true;
            ganttViewDataItem3.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem3.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem3.Title = null;
            ganttViewDataItem3.Visible = true;
            this.radGanttView1.Items.AddRange(new Telerik.WinControls.UI.GanttViewDataItem[] {
            ganttViewDataItem1,
            ganttViewDataItem2,
            ganttViewDataItem3});
            ganttViewLinkDataItem1.EndItem = null;
            ganttViewLinkDataItem1.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem1.Selected = false;
            ganttViewLinkDataItem1.StartItem = null;
            ganttViewLinkDataItem2.EndItem = null;
            ganttViewLinkDataItem2.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem2.Selected = false;
            ganttViewLinkDataItem2.StartItem = null;
            ganttViewLinkDataItem3.EndItem = null;
            ganttViewLinkDataItem3.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem3.Selected = false;
            ganttViewLinkDataItem3.StartItem = null;
            this.radGanttView1.Links.AddRange(new Telerik.WinControls.UI.GanttViewLinkDataItem[] {
            ganttViewLinkDataItem1,
            ganttViewLinkDataItem2,
            ganttViewLinkDataItem3});
            this.radGanttView1.Location = new System.Drawing.Point(12, 12);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Size = new System.Drawing.Size(743, 546);
            this.radGanttView1.TabIndex = 0;
            this.radGanttView1.ThemeName = "VisualStudio2012Light";
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 570);
            this.Controls.Add(this.radGanttView1);
            this.Name = "Actividad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView radGanttView1;
    }
}
