﻿namespace GoClient
{
	partial class GameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.Field = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.GameTreeBox = new System.Windows.Forms.GroupBox();
			this.GameTreePaintBox = new System.Windows.Forms.Panel();
			this.GameBox = new System.Windows.Forms.GroupBox();
			this.PlayerToMove = new System.Windows.Forms.Label();
			this.MoveIndex = new System.Windows.Forms.Label();
			this.PlayBox = new System.Windows.Forms.GroupBox();
			this.PlayTimeLabel = new System.Windows.Forms.Label();
			this.PlayButton = new System.Windows.Forms.Button();
			this.PlayProgress = new System.Windows.Forms.TrackBar();
			this.RecordingBox = new System.Windows.Forms.GroupBox();
			this.FinishOrSaveButton = new System.Windows.Forms.Button();
			this.RecordTimeLabel = new System.Windows.Forms.Label();
			this.RecordButton = new System.Windows.Forms.Button();
			this.RecordingState = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.LessonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseLessonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveWithAudioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FinishRecordingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveWithoutAudioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PauseLessonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.GameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewBoardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board9x9MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board11x11MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board13x13MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board17x17MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board19x19MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Board37x37MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mergeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ScreenshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoveToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PutStoneToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ScoreToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.TriangleToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SquareToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CircleToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.TextLabelToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NumberLabelToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SymbolLabelToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ActionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PassActionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ResignActionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateFirstMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateLeftForkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.NavigateLeft1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateLeft10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateLastMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateRightForkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.NavigateRight1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NavigateRight10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SaveAudioLessonDialog = new System.Windows.Forms.SaveFileDialog();
			this.NavigationFocus = new System.Windows.Forms.TextBox();
			this.SaveReplayDialog = new System.Windows.Forms.SaveFileDialog();
			this.jsonExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
			this.panel1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.GameTreeBox.SuspendLayout();
			this.GameBox.SuspendLayout();
			this.PlayBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayProgress)).BeginInit();
			this.RecordingBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Field
			// 
			this.Field.BackColor = System.Drawing.Color.Green;
			this.Field.Dock = System.Windows.Forms.DockStyle.Left;
			this.Field.Location = new System.Drawing.Point(0, 24);
			this.Field.Name = "Field";
			this.Field.Size = new System.Drawing.Size(403, 422);
			this.Field.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Field.TabIndex = 0;
			this.Field.TabStop = false;
			this.Field.Click += new System.EventHandler(this.Field_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Controls.Add(this.GameBox);
			this.panel1.Controls.Add(this.PlayBox);
			this.panel1.Controls.Add(this.RecordingBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(403, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(229, 422);
			this.panel1.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 200);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.GameTreeBox);
			this.splitContainer1.Size = new System.Drawing.Size(229, 222);
			this.splitContainer1.SplitterDistance = 83;
			this.splitContainer1.TabIndex = 16;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(229, 83);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "";
			// 
			// GameTreeBox
			// 
			this.GameTreeBox.Controls.Add(this.GameTreePaintBox);
			this.GameTreeBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameTreeBox.Location = new System.Drawing.Point(0, 0);
			this.GameTreeBox.Name = "GameTreeBox";
			this.GameTreeBox.Size = new System.Drawing.Size(229, 135);
			this.GameTreeBox.TabIndex = 14;
			this.GameTreeBox.TabStop = false;
			this.GameTreeBox.Text = "GameTree";
			// 
			// GameTreePaintBox
			// 
			this.GameTreePaintBox.AutoScroll = true;
			this.GameTreePaintBox.AutoScrollMinSize = new System.Drawing.Size(1000, 1000);
			this.GameTreePaintBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameTreePaintBox.Location = new System.Drawing.Point(3, 16);
			this.GameTreePaintBox.Name = "GameTreePaintBox";
			this.GameTreePaintBox.Size = new System.Drawing.Size(223, 116);
			this.GameTreePaintBox.TabIndex = 0;
			this.GameTreePaintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GameTreeBox_Paint);
			this.GameTreePaintBox.Click += new System.EventHandler(this.GameTreePaintBox_Click);
			// 
			// GameBox
			// 
			this.GameBox.Controls.Add(this.PlayerToMove);
			this.GameBox.Controls.Add(this.MoveIndex);
			this.GameBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.GameBox.Location = new System.Drawing.Point(0, 160);
			this.GameBox.Name = "GameBox";
			this.GameBox.Size = new System.Drawing.Size(229, 40);
			this.GameBox.TabIndex = 15;
			this.GameBox.TabStop = false;
			this.GameBox.Text = "Game";
			// 
			// PlayerToMove
			// 
			this.PlayerToMove.AutoSize = true;
			this.PlayerToMove.Location = new System.Drawing.Point(84, 16);
			this.PlayerToMove.Name = "PlayerToMove";
			this.PlayerToMove.Size = new System.Drawing.Size(76, 13);
			this.PlayerToMove.TabIndex = 3;
			this.PlayerToMove.Text = "PlayerToMove";
			// 
			// MoveIndex
			// 
			this.MoveIndex.AutoSize = true;
			this.MoveIndex.Location = new System.Drawing.Point(6, 16);
			this.MoveIndex.Name = "MoveIndex";
			this.MoveIndex.Size = new System.Drawing.Size(60, 13);
			this.MoveIndex.TabIndex = 2;
			this.MoveIndex.Text = "MoveIndex";
			// 
			// PlayBox
			// 
			this.PlayBox.Controls.Add(this.PlayTimeLabel);
			this.PlayBox.Controls.Add(this.PlayButton);
			this.PlayBox.Controls.Add(this.PlayProgress);
			this.PlayBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.PlayBox.Location = new System.Drawing.Point(0, 75);
			this.PlayBox.Name = "PlayBox";
			this.PlayBox.Size = new System.Drawing.Size(229, 85);
			this.PlayBox.TabIndex = 14;
			this.PlayBox.TabStop = false;
			this.PlayBox.Text = "Play";
			// 
			// PlayTimeLabel
			// 
			this.PlayTimeLabel.AutoSize = true;
			this.PlayTimeLabel.Location = new System.Drawing.Point(49, 61);
			this.PlayTimeLabel.Name = "PlayTimeLabel";
			this.PlayTimeLabel.Size = new System.Drawing.Size(48, 13);
			this.PlayTimeLabel.TabIndex = 6;
			this.PlayTimeLabel.Text = "Progress";
			// 
			// PlayButton
			// 
			this.PlayButton.Location = new System.Drawing.Point(6, 23);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(37, 35);
			this.PlayButton.TabIndex = 3;
			this.PlayButton.Text = "Play";
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// PlayProgress
			// 
			this.PlayProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlayProgress.LargeChange = 60;
			this.PlayProgress.Location = new System.Drawing.Point(43, 23);
			this.PlayProgress.Maximum = 3100;
			this.PlayProgress.Name = "PlayProgress";
			this.PlayProgress.Size = new System.Drawing.Size(180, 45);
			this.PlayProgress.TabIndex = 4;
			this.PlayProgress.TickFrequency = 300;
			this.PlayProgress.Scroll += new System.EventHandler(this.PlayProgress_Scroll);
			// 
			// RecordingBox
			// 
			this.RecordingBox.Controls.Add(this.FinishOrSaveButton);
			this.RecordingBox.Controls.Add(this.RecordTimeLabel);
			this.RecordingBox.Controls.Add(this.RecordButton);
			this.RecordingBox.Controls.Add(this.RecordingState);
			this.RecordingBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.RecordingBox.Location = new System.Drawing.Point(0, 0);
			this.RecordingBox.Margin = new System.Windows.Forms.Padding(8);
			this.RecordingBox.Name = "RecordingBox";
			this.RecordingBox.Size = new System.Drawing.Size(229, 75);
			this.RecordingBox.TabIndex = 13;
			this.RecordingBox.TabStop = false;
			this.RecordingBox.Text = "Recording";
			// 
			// FinishOrSaveButton
			// 
			this.FinishOrSaveButton.Location = new System.Drawing.Point(90, 41);
			this.FinishOrSaveButton.Name = "FinishOrSaveButton";
			this.FinishOrSaveButton.Size = new System.Drawing.Size(93, 23);
			this.FinishOrSaveButton.TabIndex = 2;
			this.FinishOrSaveButton.Text = "Finish";
			this.FinishOrSaveButton.UseVisualStyleBackColor = true;
			this.FinishOrSaveButton.Click += new System.EventHandler(this.FinishOrSave_Click);
			// 
			// RecordTimeLabel
			// 
			this.RecordTimeLabel.AutoSize = true;
			this.RecordTimeLabel.Location = new System.Drawing.Point(115, 16);
			this.RecordTimeLabel.Name = "RecordTimeLabel";
			this.RecordTimeLabel.Size = new System.Drawing.Size(35, 13);
			this.RecordTimeLabel.TabIndex = 2;
			this.RecordTimeLabel.Text = "label1";
			// 
			// RecordButton
			// 
			this.RecordButton.Location = new System.Drawing.Point(9, 41);
			this.RecordButton.Name = "RecordButton";
			this.RecordButton.Size = new System.Drawing.Size(75, 23);
			this.RecordButton.TabIndex = 1;
			this.RecordButton.Text = "Record";
			this.RecordButton.UseVisualStyleBackColor = true;
			this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
			// 
			// RecordingState
			// 
			this.RecordingState.AutoSize = true;
			this.RecordingState.Location = new System.Drawing.Point(16, 16);
			this.RecordingState.Name = "RecordingState";
			this.RecordingState.Size = new System.Drawing.Size(81, 13);
			this.RecordingState.TabIndex = 0;
			this.RecordingState.Text = "RecordingState";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LessonMenuItem,
            this.GameMenuItem,
            this.toolsToolStripMenuItem,
            this.ActionMenuItem,
            this.navigationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(632, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// LessonMenuItem
			// 
			this.LessonMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseLessonMenuItem,
            this.SaveWithAudioMenuItem,
            this.FinishRecordingMenuItem,
            this.SaveWithoutAudioMenuItem,
            this.jsonExportToolStripMenuItem,
            this.PauseLessonMenuItem,
            this.toolStripMenuItem7});
			this.LessonMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.LessonMenuItem.MergeIndex = 0;
			this.LessonMenuItem.Name = "LessonMenuItem";
			this.LessonMenuItem.Size = new System.Drawing.Size(35, 20);
			this.LessonMenuItem.Text = "&File";
			// 
			// CloseLessonMenuItem
			// 
			this.CloseLessonMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.CloseLessonMenuItem.MergeIndex = 3;
			this.CloseLessonMenuItem.Name = "CloseLessonMenuItem";
			this.CloseLessonMenuItem.Size = new System.Drawing.Size(190, 22);
			this.CloseLessonMenuItem.Text = "&Close";
			this.CloseLessonMenuItem.Click += new System.EventHandler(this.CloseLessonMenuItem_Click);
			// 
			// SaveWithAudioMenuItem
			// 
			this.SaveWithAudioMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.SaveWithAudioMenuItem.MergeIndex = 3;
			this.SaveWithAudioMenuItem.Name = "SaveWithAudioMenuItem";
			this.SaveWithAudioMenuItem.Size = new System.Drawing.Size(190, 22);
			this.SaveWithAudioMenuItem.Text = "&Save with Audio...";
			this.SaveWithAudioMenuItem.Click += new System.EventHandler(this.SaveWithAudioMenuItem_Click);
			// 
			// FinishRecordingMenuItem
			// 
			this.FinishRecordingMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.FinishRecordingMenuItem.MergeIndex = 3;
			this.FinishRecordingMenuItem.Name = "FinishRecordingMenuItem";
			this.FinishRecordingMenuItem.Size = new System.Drawing.Size(190, 22);
			this.FinishRecordingMenuItem.Text = "&Finish Recording";
			this.FinishRecordingMenuItem.Click += new System.EventHandler(this.FinishRecordingMenuItem_Click);
			// 
			// SaveWithoutAudioMenuItem
			// 
			this.SaveWithoutAudioMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.SaveWithoutAudioMenuItem.MergeIndex = 3;
			this.SaveWithoutAudioMenuItem.Name = "SaveWithoutAudioMenuItem";
			this.SaveWithoutAudioMenuItem.Size = new System.Drawing.Size(190, 22);
			this.SaveWithoutAudioMenuItem.Text = "Save without Audio...";
			this.SaveWithoutAudioMenuItem.Click += new System.EventHandler(this.saveWithoutAudioToolStripMenuItem_Click);
			// 
			// PauseLessonMenuItem
			// 
			this.PauseLessonMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.PauseLessonMenuItem.MergeIndex = 3;
			this.PauseLessonMenuItem.Name = "PauseLessonMenuItem";
			this.PauseLessonMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.PauseLessonMenuItem.Size = new System.Drawing.Size(190, 22);
			this.PauseLessonMenuItem.Text = "&Pause";
			this.PauseLessonMenuItem.Click += new System.EventHandler(this.PauseLessonMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.toolStripMenuItem7.MergeIndex = 3;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(187, 6);
			// 
			// GameMenuItem
			// 
			this.GameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBoardMenuItem,
            this.AddGameMenuItem,
            this.mergeVideoToolStripMenuItem,
            this.SaveGameMenuItem,
            this.ScreenshotMenuItem});
			this.GameMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.GameMenuItem.MergeIndex = 1;
			this.GameMenuItem.Name = "GameMenuItem";
			this.GameMenuItem.Size = new System.Drawing.Size(46, 20);
			this.GameMenuItem.Text = "&Game";
			// 
			// NewBoardMenuItem
			// 
			this.NewBoardMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Board9x9MenuItem,
            this.Board11x11MenuItem,
            this.Board13x13MenuItem,
            this.Board17x17MenuItem,
            this.Board19x19MenuItem,
            this.Board37x37MenuItem});
			this.NewBoardMenuItem.Name = "NewBoardMenuItem";
			this.NewBoardMenuItem.Size = new System.Drawing.Size(230, 22);
			this.NewBoardMenuItem.Text = "New &Board";
			// 
			// Board9x9MenuItem
			// 
			this.Board9x9MenuItem.Name = "Board9x9MenuItem";
			this.Board9x9MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board9x9MenuItem.Text = "9x9";
			this.Board9x9MenuItem.Click += new System.EventHandler(this.Board9x9MenuItem_Click);
			// 
			// Board11x11MenuItem
			// 
			this.Board11x11MenuItem.Name = "Board11x11MenuItem";
			this.Board11x11MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board11x11MenuItem.Text = "11x11";
			this.Board11x11MenuItem.Click += new System.EventHandler(this.Board11x11MenuItem_Click);
			// 
			// Board13x13MenuItem
			// 
			this.Board13x13MenuItem.Name = "Board13x13MenuItem";
			this.Board13x13MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board13x13MenuItem.Text = "13x13";
			this.Board13x13MenuItem.Click += new System.EventHandler(this.Board13x13MenuItem_Click);
			// 
			// Board17x17MenuItem
			// 
			this.Board17x17MenuItem.Name = "Board17x17MenuItem";
			this.Board17x17MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board17x17MenuItem.Text = "17x17";
			this.Board17x17MenuItem.Click += new System.EventHandler(this.Board17x17MenuItem_Click);
			// 
			// Board19x19MenuItem
			// 
			this.Board19x19MenuItem.Name = "Board19x19MenuItem";
			this.Board19x19MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board19x19MenuItem.Text = "19x19";
			this.Board19x19MenuItem.Click += new System.EventHandler(this.Board19x19MenuItem_Click);
			// 
			// Board37x37MenuItem
			// 
			this.Board37x37MenuItem.Name = "Board37x37MenuItem";
			this.Board37x37MenuItem.Size = new System.Drawing.Size(152, 22);
			this.Board37x37MenuItem.Text = "37x37";
			this.Board37x37MenuItem.Click += new System.EventHandler(this.Board37x37MenuItem_Click);
			// 
			// AddGameMenuItem
			// 
			this.AddGameMenuItem.Name = "AddGameMenuItem";
			this.AddGameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.AddGameMenuItem.Size = new System.Drawing.Size(230, 22);
			this.AddGameMenuItem.Text = "Add Board from File...";
			this.AddGameMenuItem.Click += new System.EventHandler(this.AddGameMenuItem_Click);
			// 
			// mergeVideoToolStripMenuItem
			// 
			this.mergeVideoToolStripMenuItem.Name = "mergeVideoToolStripMenuItem";
			this.mergeVideoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.mergeVideoToolStripMenuItem.Text = "Merge &Video";
			this.mergeVideoToolStripMenuItem.Click += new System.EventHandler(this.mergeVideoToolStripMenuItem_Click);
			// 
			// SaveGameMenuItem
			// 
			this.SaveGameMenuItem.Name = "SaveGameMenuItem";
			this.SaveGameMenuItem.Size = new System.Drawing.Size(230, 22);
			this.SaveGameMenuItem.Text = "&Save...";
			// 
			// ScreenshotMenuItem
			// 
			this.ScreenshotMenuItem.Name = "ScreenshotMenuItem";
			this.ScreenshotMenuItem.Size = new System.Drawing.Size(230, 22);
			this.ScreenshotMenuItem.Text = "Sc&reenshot...";
			this.ScreenshotMenuItem.Click += new System.EventHandler(this.ScreenshotMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveToolMenuItem,
            this.PutStoneToolMenuItem,
            this.ScoreToolMenuItem,
            this.toolStripMenuItem1,
            this.TriangleToolMenuItem,
            this.SquareToolMenuItem,
            this.CircleToolMenuItem,
            this.toolStripMenuItem2,
            this.TextLabelToolMenuItem,
            this.NumberLabelToolMenuItem,
            this.SymbolLabelToolMenuItem});
			this.toolsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.toolsToolStripMenuItem.MergeIndex = 2;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// MoveToolMenuItem
			// 
			this.MoveToolMenuItem.Name = "MoveToolMenuItem";
			this.MoveToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.MoveToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.MoveToolMenuItem.Tag = "";
			this.MoveToolMenuItem.Text = "&Move";
			this.MoveToolMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
			// 
			// PutStoneToolMenuItem
			// 
			this.PutStoneToolMenuItem.Name = "PutStoneToolMenuItem";
			this.PutStoneToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.PutStoneToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.PutStoneToolMenuItem.Tag = "";
			this.PutStoneToolMenuItem.Text = "Put &Stone";
			this.PutStoneToolMenuItem.Click += new System.EventHandler(this.putStoneToolStripMenuItem_Click);
			// 
			// ScoreToolMenuItem
			// 
			this.ScoreToolMenuItem.Enabled = false;
			this.ScoreToolMenuItem.Name = "ScoreToolMenuItem";
			this.ScoreToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.ScoreToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.ScoreToolMenuItem.Tag = "";
			this.ScoreToolMenuItem.Text = "&Score";
			this.ScoreToolMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
			// 
			// TriangleToolMenuItem
			// 
			this.TriangleToolMenuItem.Name = "TriangleToolMenuItem";
			this.TriangleToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.TriangleToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.TriangleToolMenuItem.Text = "T&riangle";
			this.TriangleToolMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
			// 
			// SquareToolMenuItem
			// 
			this.SquareToolMenuItem.Name = "SquareToolMenuItem";
			this.SquareToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.SquareToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.SquareToolMenuItem.Text = "S&quare";
			this.SquareToolMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
			// 
			// CircleToolMenuItem
			// 
			this.CircleToolMenuItem.Name = "CircleToolMenuItem";
			this.CircleToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.CircleToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.CircleToolMenuItem.Text = "&Circle";
			this.CircleToolMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
			// 
			// TextLabelToolMenuItem
			// 
			this.TextLabelToolMenuItem.Name = "TextLabelToolMenuItem";
			this.TextLabelToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.TextLabelToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.TextLabelToolMenuItem.Text = "&Text Label";
			this.TextLabelToolMenuItem.Click += new System.EventHandler(this.textLabelToolStripMenuItem_Click);
			// 
			// NumberLabelToolMenuItem
			// 
			this.NumberLabelToolMenuItem.Name = "NumberLabelToolMenuItem";
			this.NumberLabelToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.NumberLabelToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.NumberLabelToolMenuItem.Text = "&Number Label";
			this.NumberLabelToolMenuItem.Click += new System.EventHandler(this.numberLabelToolStripMenuItem_Click);
			// 
			// SymbolLabelToolMenuItem
			// 
			this.SymbolLabelToolMenuItem.Name = "SymbolLabelToolMenuItem";
			this.SymbolLabelToolMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.SymbolLabelToolMenuItem.Size = new System.Drawing.Size(169, 22);
			this.SymbolLabelToolMenuItem.Text = "S&ymbol Label";
			this.SymbolLabelToolMenuItem.Click += new System.EventHandler(this.symbolLabelToolStripMenuItem_Click);
			// 
			// ActionMenuItem
			// 
			this.ActionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PassActionMenuItem,
            this.ResignActionMenuItem});
			this.ActionMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.ActionMenuItem.MergeIndex = 3;
			this.ActionMenuItem.Name = "ActionMenuItem";
			this.ActionMenuItem.Size = new System.Drawing.Size(49, 20);
			this.ActionMenuItem.Text = "&Action";
			// 
			// PassActionMenuItem
			// 
			this.PassActionMenuItem.Name = "PassActionMenuItem";
			this.PassActionMenuItem.Size = new System.Drawing.Size(117, 22);
			this.PassActionMenuItem.Text = "&Pass";
			this.PassActionMenuItem.Click += new System.EventHandler(this.PassActionMenuItem_Click);
			// 
			// ResignActionMenuItem
			// 
			this.ResignActionMenuItem.Name = "ResignActionMenuItem";
			this.ResignActionMenuItem.Size = new System.Drawing.Size(117, 22);
			this.ResignActionMenuItem.Text = "&Resign";
			// 
			// navigationToolStripMenuItem
			// 
			this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
			this.navigationToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.navigationToolStripMenuItem.MergeIndex = 4;
			this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
			this.navigationToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.navigationToolStripMenuItem.Text = "&Navigation";
			// 
			// leftToolStripMenuItem
			// 
			this.leftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavigateFirstMenuItem,
            this.NavigateLeftForkMenuItem,
            this.toolStripMenuItem5,
            this.NavigateLeft1MenuItem,
            this.NavigateLeft10MenuItem});
			this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
			this.leftToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.leftToolStripMenuItem.Text = "Left";
			// 
			// NavigateFirstMenuItem
			// 
			this.NavigateFirstMenuItem.Name = "NavigateFirstMenuItem";
			this.NavigateFirstMenuItem.Size = new System.Drawing.Size(131, 22);
			this.NavigateFirstMenuItem.Text = "&First";
			this.NavigateFirstMenuItem.Click += new System.EventHandler(this.NavigateFirstMenuItem_Click);
			// 
			// NavigateLeftForkMenuItem
			// 
			this.NavigateLeftForkMenuItem.Name = "NavigateLeftForkMenuItem";
			this.NavigateLeftForkMenuItem.Size = new System.Drawing.Size(131, 22);
			this.NavigateLeftForkMenuItem.Text = "Last Fork";
			this.NavigateLeftForkMenuItem.Click += new System.EventHandler(this.NavigateLeftForkMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 6);
			// 
			// NavigateLeft1MenuItem
			// 
			this.NavigateLeft1MenuItem.Name = "NavigateLeft1MenuItem";
			this.NavigateLeft1MenuItem.Size = new System.Drawing.Size(131, 22);
			this.NavigateLeft1MenuItem.Text = "1 Move";
			this.NavigateLeft1MenuItem.Click += new System.EventHandler(this.NavigateLeft1MenuItem_Click);
			// 
			// NavigateLeft10MenuItem
			// 
			this.NavigateLeft10MenuItem.Name = "NavigateLeft10MenuItem";
			this.NavigateLeft10MenuItem.Size = new System.Drawing.Size(131, 22);
			this.NavigateLeft10MenuItem.Text = "10 Moves";
			this.NavigateLeft10MenuItem.Click += new System.EventHandler(this.NavigateLeft10MenuItem_Click);
			// 
			// rightToolStripMenuItem
			// 
			this.rightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavigateLastMenuItem,
            this.NavigateRightForkMenuItem,
            this.toolStripMenuItem6,
            this.NavigateRight1MenuItem,
            this.NavigateRight10MenuItem});
			this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
			this.rightToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.rightToolStripMenuItem.Text = "Right";
			// 
			// NavigateLastMenuItem
			// 
			this.NavigateLastMenuItem.Name = "NavigateLastMenuItem";
			this.NavigateLastMenuItem.Size = new System.Drawing.Size(132, 22);
			this.NavigateLastMenuItem.Text = "&Last";
			this.NavigateLastMenuItem.Click += new System.EventHandler(this.NavigateLastMenuItem_Click);
			// 
			// NavigateRightForkMenuItem
			// 
			this.NavigateRightForkMenuItem.Name = "NavigateRightForkMenuItem";
			this.NavigateRightForkMenuItem.Size = new System.Drawing.Size(132, 22);
			this.NavigateRightForkMenuItem.Text = "Next Fork";
			this.NavigateRightForkMenuItem.Click += new System.EventHandler(this.NavigateRightForkMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(129, 6);
			// 
			// NavigateRight1MenuItem
			// 
			this.NavigateRight1MenuItem.Name = "NavigateRight1MenuItem";
			this.NavigateRight1MenuItem.Size = new System.Drawing.Size(132, 22);
			this.NavigateRight1MenuItem.Text = "1 Move";
			this.NavigateRight1MenuItem.Click += new System.EventHandler(this.NavigateRight1MenuItem_Click);
			// 
			// NavigateRight10MenuItem
			// 
			this.NavigateRight10MenuItem.Name = "NavigateRight10MenuItem";
			this.NavigateRight10MenuItem.Size = new System.Drawing.Size(132, 22);
			this.NavigateRight10MenuItem.Text = "10 Moves";
			this.NavigateRight10MenuItem.Click += new System.EventHandler(this.NavigateRight10MenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// SaveAudioLessonDialog
			// 
			this.SaveAudioLessonDialog.DefaultExt = "goal";
			this.SaveAudioLessonDialog.Filter = "Go Audio Lessons (*.GoLesson)|*.GoLesson|All files|*.*";
			// 
			// NavigationFocus
			// 
			this.NavigationFocus.Location = new System.Drawing.Point(32767, 32767);
			this.NavigationFocus.Name = "NavigationFocus";
			this.NavigationFocus.ReadOnly = true;
			this.NavigationFocus.Size = new System.Drawing.Size(0, 20);
			this.NavigationFocus.TabIndex = 0;
			this.NavigationFocus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
			// 
			// SaveReplayDialog
			// 
			this.SaveReplayDialog.DefaultExt = "GoReplay";
			this.SaveReplayDialog.Filter = "Go Replay|*.GoReplay|All Files|*.*";
			// 
			// jsonExportToolStripMenuItem
			// 
			this.jsonExportToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.jsonExportToolStripMenuItem.MergeIndex = 3;
			this.jsonExportToolStripMenuItem.Name = "jsonExportToolStripMenuItem";
			this.jsonExportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.jsonExportToolStripMenuItem.Text = "Json Export...";
			this.jsonExportToolStripMenuItem.Click += new System.EventHandler(this.jsonExportToolStripMenuItem_Click);
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 446);
			this.Controls.Add(this.NavigationFocus);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Field);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.Name = "GameForm";
			this.Text = "GO Audio Lesson Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.GameTreeBox.ResumeLayout(false);
			this.GameBox.ResumeLayout(false);
			this.GameBox.PerformLayout();
			this.PlayBox.ResumeLayout(false);
			this.PlayBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayProgress)).EndInit();
			this.RecordingBox.ResumeLayout(false);
			this.RecordingBox.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Field;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem LessonMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PauseLessonMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MoveToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PutStoneToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ScoreToolMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem TriangleToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SquareToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CircleToolMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem TextLabelToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NumberLabelToolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SymbolLabelToolMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem ActionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PassActionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddGameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveGameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ScreenshotMenuItem;
		private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateLeftForkMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem NavigateLeft1MenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateLeft10MenuItem;
		private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateRightForkMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem NavigateRight1MenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateRight10MenuItem;
		private System.Windows.Forms.ToolStripMenuItem ResignActionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseLessonMenuItem;
		private System.Windows.Forms.GroupBox GameBox;
		private System.Windows.Forms.Label PlayerToMove;
		private System.Windows.Forms.Label MoveIndex;
		private System.Windows.Forms.GroupBox PlayBox;
		private System.Windows.Forms.Label PlayTimeLabel;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.TrackBar PlayProgress;
		private System.Windows.Forms.GroupBox RecordingBox;
		private System.Windows.Forms.Label RecordTimeLabel;
		private System.Windows.Forms.Button RecordButton;
		private System.Windows.Forms.Label RecordingState;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox GameTreeBox;
		private System.Windows.Forms.Button FinishOrSaveButton;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.SaveFileDialog SaveAudioLessonDialog;
		private System.Windows.Forms.Panel GameTreePaintBox;
		private System.Windows.Forms.ToolStripMenuItem mergeVideoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewBoardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board9x9MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board11x11MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board13x13MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board17x17MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board19x19MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Board37x37MenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateFirstMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NavigateLastMenuItem;
		private System.Windows.Forms.TextBox NavigationFocus;
		private System.Windows.Forms.ToolStripMenuItem FinishRecordingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveWithoutAudioMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveWithAudioMenuItem;
		private System.Windows.Forms.SaveFileDialog SaveReplayDialog;
		private System.Windows.Forms.ToolStripMenuItem jsonExportToolStripMenuItem;
	}
}

