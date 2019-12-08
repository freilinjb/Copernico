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
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn4 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn5 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewTextViewColumn ganttViewTextViewColumn6 = new Telerik.WinControls.UI.GanttViewTextViewColumn();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem4 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem5 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewDataItem ganttViewDataItem6 = new Telerik.WinControls.UI.GanttViewDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem4 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem5 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            Telerik.WinControls.UI.GanttViewLinkDataItem ganttViewLinkDataItem6 = new Telerik.WinControls.UI.GanttViewLinkDataItem();
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGanttView1
            // 
            ganttViewTextViewColumn4.DataType = null;
            ganttViewTextViewColumn4.FieldName = "";
            ganttViewTextViewColumn4.HeaderText = "";
            ganttViewTextViewColumn4.Name = "column1";
            ganttViewTextViewColumn5.DataType = null;
            ganttViewTextViewColumn5.FieldName = "";
            ganttViewTextViewColumn5.HeaderText = "";
            ganttViewTextViewColumn5.Name = "column2";
            ganttViewTextViewColumn6.DataType = null;
            ganttViewTextViewColumn6.FieldName = "";
            ganttViewTextViewColumn6.HeaderText = "";
            ganttViewTextViewColumn6.Name = "column3";
            this.radGanttView1.Columns.AddRange(new Telerik.WinControls.UI.GanttViewTextViewColumn[] {
            ganttViewTextViewColumn4,
            ganttViewTextViewColumn5,
            ganttViewTextViewColumn6});
            this.radGanttView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            ganttViewDataItem4.End = new System.DateTime(((long)(0)));
            ganttViewDataItem4.Expanded = true;
            ganttViewDataItem4.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem4.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem4.Title = null;
            ganttViewDataItem4.Visible = true;
            ganttViewDataItem5.End = new System.DateTime(((long)(0)));
            ganttViewDataItem5.Expanded = true;
            ganttViewDataItem5.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem5.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem5.Title = null;
            ganttViewDataItem5.Visible = true;
            ganttViewDataItem6.End = new System.DateTime(((long)(0)));
            ganttViewDataItem6.Expanded = true;
            ganttViewDataItem6.Progress = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ganttViewDataItem6.Start = new System.DateTime(((long)(0)));
            ganttViewDataItem6.Title = null;
            ganttViewDataItem6.Visible = true;
            this.radGanttView1.Items.AddRange(new Telerik.WinControls.UI.GanttViewDataItem[] {
            ganttViewDataItem4,
            ganttViewDataItem5,
            ganttViewDataItem6});
            ganttViewLinkDataItem4.EndItem = null;
            ganttViewLinkDataItem4.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem4.Selected = false;
            ganttViewLinkDataItem4.StartItem = null;
            ganttViewLinkDataItem5.EndItem = null;
            ganttViewLinkDataItem5.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem5.Selected = false;
            ganttViewLinkDataItem5.StartItem = null;
            ganttViewLinkDataItem6.EndItem = null;
            ganttViewLinkDataItem6.LinkType = Telerik.WinControls.UI.TasksLinkType.FinishToFinish;
            ganttViewLinkDataItem6.Selected = false;
            ganttViewLinkDataItem6.StartItem = null;
            this.radGanttView1.Links.AddRange(new Telerik.WinControls.UI.GanttViewLinkDataItem[] {
            ganttViewLinkDataItem4,
            ganttViewLinkDataItem5,
            ganttViewLinkDataItem6});
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
