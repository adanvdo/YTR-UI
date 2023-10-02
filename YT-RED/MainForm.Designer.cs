﻿namespace YTR
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
            this.tcMainTabControl = new DevExpress.XtraBars.TabFormControl();
            this.bsiMessage = new DevExpress.XtraBars.BarStaticItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bbiSettings = new DevExpress.XtraBars.BarButtonItem();
            this.tfpMain = new YTR.Controls.CustomTabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.sccMainSplitter = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcFormats = new DevExpress.XtraGrid.GridControl();
            this.gvFormats = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pnlPlaylistControls = new DevExpress.XtraEditors.PanelControl();
            this.btnPLSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblSelectAFormat = new DevExpress.XtraEditors.LabelControl();
            this.videoInfoPanel = new YTR.Controls.VideoInfoPanel();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.ipMainInput = new YTR.Controls.InputPanel();
            this.pnlScrollableControls = new DevExpress.XtraEditors.XtraScrollableControl();
            this.cpMainControlPanel = new YTR.Controls.ControlPanel();
            this.scHistorySplitter = new DevExpress.XtraEditors.SplitterControl();
            this.pnlHistoryPanel = new DevExpress.XtraEditors.PanelControl();
            this.gcHistory = new DevExpress.XtraGrid.GridControl();
            this.gvHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repFileExists = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repPostProcessed = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.lblHistoryVert = new DevExpress.XtraEditors.LabelControl();
            this.pnlHistoryHeader = new DevExpress.XtraEditors.PanelControl();
            this.lblHeaderLabel = new DevExpress.XtraEditors.LabelControl();
            this.btnShowHideHistory = new DevExpress.XtraEditors.SimpleButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskBarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.historyBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiReDownload = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNewDownload = new DevExpress.XtraBars.BarButtonItem();
            this.historyPopup = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tcMainTabControl)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter.Panel1)).BeginInit();
            this.sccMainSplitter.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter.Panel2)).BeginInit();
            this.sccMainSplitter.Panel2.SuspendLayout();
            this.sccMainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPlaylistControls)).BeginInit();
            this.pnlPlaylistControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.pnlScrollableControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHistoryPanel)).BeginInit();
            this.pnlHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repFileExists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPostProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHistoryHeader)).BeginInit();
            this.pnlHistoryHeader.SuspendLayout();
            this.taskBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMainTabControl
            // 
            this.tcMainTabControl.AllowMoreTabsButton = DevExpress.Utils.DefaultBoolean.False;
            this.tcMainTabControl.AllowMoveTabsToOuterForm = false;
            this.tcMainTabControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiMessage,
            this.skinBarSubItem1,
            this.bbiSettings});
            this.tcMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.tcMainTabControl.Name = "tcMainTabControl";
            this.tcMainTabControl.Pages.Add(this.tfpMain);
            this.tcMainTabControl.SelectedPage = this.tfpMain;
            this.tcMainTabControl.ShowAddPageButton = false;
            this.tcMainTabControl.Size = new System.Drawing.Size(1188, 66);
            this.tcMainTabControl.TabForm = this;
            this.tcMainTabControl.TabIndex = 0;
            this.tcMainTabControl.TabRightItemLinks.Add(this.bsiMessage);
            this.tcMainTabControl.TabRightItemLinks.Add(this.skinBarSubItem1);
            this.tcMainTabControl.TabRightItemLinks.Add(this.bbiSettings);
            this.tcMainTabControl.TabStop = false;
            // 
            // bsiMessage
            // 
            this.bsiMessage.Id = 2;
            this.bsiMessage.Name = "bsiMessage";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.AllowSerializeChildren = DevExpress.Utils.DefaultBoolean.False;
            this.skinBarSubItem1.Hint = "Skins";
            this.skinBarSubItem1.Id = 3;
            this.skinBarSubItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.skinBarSubItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("skinBarSubItem1.ImageOptions.SvgImage")));
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            this.skinBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiSettings
            // 
            this.bbiSettings.Hint = "Settings";
            this.bbiSettings.Id = 0;
            this.bbiSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bbiSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSettings.ImageOptions.SvgImage")));
            this.bbiSettings.Name = "bbiSettings";
            this.bbiSettings.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettings_ItemClick);
            // 
            // tfpMain
            // 
            this.tfpMain.ContentContainer = this.tabFormContentContainer1;
            this.tfpMain.Name = "tfpMain";
            this.tfpMain.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tfpMain.Text = "Download";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.sccMainSplitter);
            this.tabFormContentContainer1.Controls.Add(this.scHistorySplitter);
            this.tabFormContentContainer1.Controls.Add(this.pnlHistoryPanel);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 66);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1188, 767);
            this.tabFormContentContainer1.TabIndex = 0;
            // 
            // sccMainSplitter
            // 
            this.sccMainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sccMainSplitter.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.sccMainSplitter.Location = new System.Drawing.Point(0, 0);
            this.sccMainSplitter.Margin = new System.Windows.Forms.Padding(0);
            this.sccMainSplitter.Name = "sccMainSplitter";
            this.sccMainSplitter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // sccMainSplitter.Panel1
            // 
            this.sccMainSplitter.Panel1.Controls.Add(this.gcFormats);
            this.sccMainSplitter.Panel1.Controls.Add(this.pnlPlaylistControls);
            this.sccMainSplitter.Panel1.Controls.Add(this.videoInfoPanel);
            this.sccMainSplitter.Panel1.Controls.Add(this.marqueeProgressBarControl1);
            this.sccMainSplitter.Panel1.Controls.Add(this.ipMainInput);
            this.sccMainSplitter.Panel1.MinSize = 350;
            this.sccMainSplitter.Panel1.Text = "Panel1";
            // 
            // sccMainSplitter.Panel2
            // 
            this.sccMainSplitter.Panel2.Controls.Add(this.pnlScrollableControls);
            this.sccMainSplitter.Panel2.MinSize = 323;
            this.sccMainSplitter.Panel2.Text = "Panel2";
            this.sccMainSplitter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sccMainSplitter.Size = new System.Drawing.Size(872, 767);
            this.sccMainSplitter.SplitterPosition = 523;
            this.sccMainSplitter.TabIndex = 0;
            this.sccMainSplitter.SplitterMoved += new System.EventHandler(this.sccMainSplitter_SplitterMoved);
            this.sccMainSplitter.Resize += new System.EventHandler(this.sccMainSplitter_Resize);
            // 
            // gcFormats
            // 
            this.gcFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFormats.Location = new System.Drawing.Point(0, 298);
            this.gcFormats.MainView = this.gvFormats;
            this.gcFormats.Name = "gcFormats";
            this.gcFormats.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repPictureEdit});
            this.gcFormats.Size = new System.Drawing.Size(523, 469);
            this.gcFormats.TabIndex = 0;
            this.gcFormats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormats});
            // 
            // gvFormats
            // 
            this.gvFormats.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvFormats.GridControl = this.gcFormats;
            this.gvFormats.Name = "gvFormats";
            this.gvFormats.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gvFormats.OptionsBehavior.Editable = false;
            this.gvFormats.OptionsCustomization.AllowGroup = false;
            this.gvFormats.OptionsDetail.ShowDetailTabs = false;
            this.gvFormats.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gvFormats.OptionsSelection.CheckBoxSelectorField = "Selected";
            this.gvFormats.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvFormats.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvFormats.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvFormats.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gvFormats.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gvFormats.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.gvFormats.OptionsView.ColumnAutoWidth = false;
            this.gvFormats.OptionsView.ShowDetailButtons = false;
            this.gvFormats.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvFormats.OptionsView.ShowGroupPanel = false;
            this.gvFormats.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvFormats_RowClick);
            this.gvFormats.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvFormats_CustomDrawCell);
            this.gvFormats.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvFormats_SelectionChanged);
            this.gvFormats.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvFormats_FocusedRowChanged);
            this.gvFormats.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvFormats_CustomColumnDisplayText);
            this.gvFormats.RowCountChanged += new System.EventHandler(this.gvFormats_RowCountChanged);
            // 
            // repPictureEdit
            // 
            this.repPictureEdit.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True;
            this.repPictureEdit.AllowDisposeImage = true;
            this.repPictureEdit.AllowFocused = false;
            this.repPictureEdit.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.repPictureEdit.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.repPictureEdit.AllowZoom = DevExpress.Utils.DefaultBoolean.False;
            this.repPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repPictureEdit.Name = "repPictureEdit";
            this.repPictureEdit.ReadOnly = true;
            this.repPictureEdit.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.repPictureEdit.ShowMenu = false;
            this.repPictureEdit.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.repPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // pnlPlaylistControls
            // 
            this.pnlPlaylistControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPlaylistControls.Controls.Add(this.btnPLSelectAll);
            this.pnlPlaylistControls.Controls.Add(this.lblSelectAFormat);
            this.pnlPlaylistControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlaylistControls.Location = new System.Drawing.Point(0, 273);
            this.pnlPlaylistControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlaylistControls.Name = "pnlPlaylistControls";
            this.pnlPlaylistControls.Size = new System.Drawing.Size(523, 25);
            this.pnlPlaylistControls.TabIndex = 3;
            // 
            // btnPLSelectAll
            // 
            this.btnPLSelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPLSelectAll.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnPLSelectAll.ImageOptions.SvgImage = global::YTR.Properties.Resources.checkbox;
            this.btnPLSelectAll.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btnPLSelectAll.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnPLSelectAll.Location = new System.Drawing.Point(0, 0);
            this.btnPLSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnPLSelectAll.Name = "btnPLSelectAll";
            this.btnPLSelectAll.Size = new System.Drawing.Size(110, 25);
            this.btnPLSelectAll.TabIndex = 0;
            this.btnPLSelectAll.Text = "Select All";
            this.btnPLSelectAll.Visible = false;
            this.btnPLSelectAll.Click += new System.EventHandler(this.btnPLSelectAll_Click);
            // 
            // lblSelectAFormat
            // 
            this.lblSelectAFormat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSelectAFormat.Appearance.Options.UseFont = true;
            this.lblSelectAFormat.Appearance.Options.UseTextOptions = true;
            this.lblSelectAFormat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSelectAFormat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSelectAFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectAFormat.Location = new System.Drawing.Point(0, 0);
            this.lblSelectAFormat.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelectAFormat.Name = "lblSelectAFormat";
            this.lblSelectAFormat.Size = new System.Drawing.Size(523, 25);
            this.lblSelectAFormat.TabIndex = 0;
            this.lblSelectAFormat.Text = "Select a Video and/or Audio Format";
            // 
            // videoInfoPanel
            // 
            this.videoInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoInfoPanel.Location = new System.Drawing.Point(0, 123);
            this.videoInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.videoInfoPanel.Name = "videoInfoPanel";
            this.videoInfoPanel.Size = new System.Drawing.Size(523, 150);
            this.videoInfoPanel.TabIndex = 2;
            this.videoInfoPanel.UseMediaSize = new System.Drawing.Size(0, 0);
            this.videoInfoPanel.Visible = false;
            this.videoInfoPanel.Crop_Click += new System.EventHandler(this.videoInfoPanel_Crop_Click);
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(0, 103);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.AllowFocused = false;
            this.marqueeProgressBarControl1.Properties.ShowTitle = true;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(523, 20);
            this.marqueeProgressBarControl1.TabIndex = 0;
            this.marqueeProgressBarControl1.Visible = false;
            // 
            // ipMainInput
            // 
            this.ipMainInput.AutoSize = true;
            this.ipMainInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ipMainInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipMainInput.ListMode = YTR.Classes.ListMode.Format;
            this.ipMainInput.Location = new System.Drawing.Point(0, 0);
            this.ipMainInput.Margin = new System.Windows.Forms.Padding(0);
            this.ipMainInput.MinimumSize = new System.Drawing.Size(350, 100);
            this.ipMainInput.Name = "ipMainInput";
            this.ipMainInput.ShowCrab = false;
            this.ipMainInput.Size = new System.Drawing.Size(523, 103);
            this.ipMainInput.TabIndex = 1;
            this.ipMainInput.URL = "";
            this.ipMainInput.ListFormats_Click += new System.EventHandler(this.ipMainInput_ListFormats_Click);
            this.ipMainInput.ResetList_Click += new System.EventHandler(this.ipMainInput_ResetList_Click);
            this.ipMainInput.Url_Changed += new System.EventHandler(this.ipMainInput_Url_Changed);
            this.ipMainInput.Crab_Click += new System.EventHandler(this.ipMainInput_Crab_Click);
            this.ipMainInput.Url_KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipMainInput_Url_KeyDown);
            this.ipMainInput.ListFormats_MouseMove += new System.EventHandler(this.cancelProcessButtons_MouseMove);
            this.ipMainInput.ListFormats_MouseLeave += new System.EventHandler(this.cancelProcessButtons_MouseLeave);
            // 
            // pnlScrollableControls
            // 
            this.pnlScrollableControls.Controls.Add(this.cpMainControlPanel);
            this.pnlScrollableControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScrollableControls.Location = new System.Drawing.Point(0, 0);
            this.pnlScrollableControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlScrollableControls.Name = "pnlScrollableControls";
            this.pnlScrollableControls.Size = new System.Drawing.Size(328, 767);
            this.pnlScrollableControls.TabIndex = 3;
            // 
            // cpMainControlPanel
            // 
            this.cpMainControlPanel.ConvertAudioFormat = null;
            this.cpMainControlPanel.ConvertIntended = false;
            this.cpMainControlPanel.ConvertVideoFormat = null;
            this.cpMainControlPanel.CropBottom = "0";
            this.cpMainControlPanel.CropLeft = "0";
            this.cpMainControlPanel.CropRight = "0";
            this.cpMainControlPanel.CropTop = "0";
            this.cpMainControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpMainControlPanel.DownloadAudioVisible = true;
            this.cpMainControlPanel.DownloadBestVisible = true;
            this.cpMainControlPanel.DownloadSelectionVisible = false;
            this.cpMainControlPanel.Location = new System.Drawing.Point(0, 0);
            this.cpMainControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cpMainControlPanel.MaxFilesize = 0;
            this.cpMainControlPanel.MaxResolution = null;
            this.cpMainControlPanel.Name = "cpMainControlPanel";
            this.cpMainControlPanel.SegmentDuration = System.TimeSpan.Parse("00:00:01");
            this.cpMainControlPanel.SegmentStart = System.TimeSpan.Parse("00:00:00");
            this.cpMainControlPanel.Size = new System.Drawing.Size(328, 767);
            this.cpMainControlPanel.TabIndex = 2;
            this.cpMainControlPanel.Cancel_MouseMove += new System.EventHandler(this.cancelProcessButtons_MouseMove);
            this.cpMainControlPanel.Cancel_MouseLeave += new System.EventHandler(this.cancelProcessButtons_MouseLeave);
            this.cpMainControlPanel.Controls_Updated += new System.EventHandler(this.cpMainControlPanel_Controls_Updated);
            this.cpMainControlPanel.DownloadSelection_Click += new System.EventHandler(this.cpMainControlPanel_DownloadSelection_Click);
            this.cpMainControlPanel.DownloadAudio_Click += new System.EventHandler(this.cpMainControlPanel_DownloadAudio_Click);
            this.cpMainControlPanel.DownloadBest_Click += new System.EventHandler(this.cpMainControlPanel_DownloadBest_Click);
            this.cpMainControlPanel.CancelProcess_Click += new System.EventHandler(this.cpMainControlPanel_CancelProcess_Click);
            this.cpMainControlPanel.ReDownload_Click += new System.EventHandler(this.cpMainControlPanel_ReDownload_Click);
            this.cpMainControlPanel.NewDownload_Click += new System.EventHandler(this.cpMainControlPanel_NewDownload_Click);
            // 
            // scHistorySplitter
            // 
            this.scHistorySplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.scHistorySplitter.Location = new System.Drawing.Point(872, 0);
            this.scHistorySplitter.MinExtra = 700;
            this.scHistorySplitter.MinSize = 300;
            this.scHistorySplitter.Name = "scHistorySplitter";
            this.scHistorySplitter.Size = new System.Drawing.Size(16, 767);
            this.scHistorySplitter.TabIndex = 2;
            this.scHistorySplitter.TabStop = false;
            // 
            // pnlHistoryPanel
            // 
            this.pnlHistoryPanel.Controls.Add(this.gcHistory);
            this.pnlHistoryPanel.Controls.Add(this.lblHistoryVert);
            this.pnlHistoryPanel.Controls.Add(this.pnlHistoryHeader);
            this.pnlHistoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHistoryPanel.Location = new System.Drawing.Point(888, 0);
            this.pnlHistoryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistoryPanel.MinimumSize = new System.Drawing.Size(300, 0);
            this.pnlHistoryPanel.Name = "pnlHistoryPanel";
            this.pnlHistoryPanel.Size = new System.Drawing.Size(300, 767);
            this.pnlHistoryPanel.TabIndex = 1;
            this.pnlHistoryPanel.Visible = false;
            // 
            // gcHistory
            // 
            this.gcHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHistory.Location = new System.Drawing.Point(2, 240);
            this.gcHistory.MainView = this.gvHistory;
            this.gcHistory.MinimumSize = new System.Drawing.Size(0, 200);
            this.gcHistory.Name = "gcHistory";
            this.gcHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repFileExists,
            this.repPostProcessed});
            this.gcHistory.Size = new System.Drawing.Size(296, 525);
            this.gcHistory.TabIndex = 1;
            this.gcHistory.ToolTipController = this.toolTipController;
            this.gcHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistory});
            this.gcHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcHistory_MouseClick);
            // 
            // gvHistory
            // 
            this.gvHistory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvHistory.GridControl = this.gcHistory;
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gvHistory.OptionsBehavior.Editable = false;
            this.gvHistory.OptionsCustomization.AllowColumnMoving = false;
            this.gvHistory.OptionsCustomization.AllowGroup = false;
            this.gvHistory.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvHistory.OptionsDetail.EnableDetailToolTip = true;
            this.gvHistory.OptionsDetail.ShowDetailTabs = false;
            this.gvHistory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvHistory.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvHistory.OptionsView.ShowDetailButtons = false;
            this.gvHistory.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvHistory.OptionsView.ShowGroupPanel = false;
            this.gvHistory.OptionsView.ShowIndicator = false;
            this.gvHistory.DoubleClick += new System.EventHandler(this.gvHistory_DoubleClick);
            // 
            // repFileExists
            // 
            this.repFileExists.AutoHeight = false;
            this.repFileExists.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.repFileExists.ImageOptions.SvgImageChecked = global::YTR.Properties.Resources.actions_checkcircled;
            this.repFileExists.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.repFileExists.ImageOptions.SvgImageUnchecked = global::YTR.Properties.Resources.security_warningcircled2;
            this.repFileExists.Name = "repFileExists";
            // 
            // repPostProcessed
            // 
            this.repPostProcessed.AutoHeight = false;
            this.repPostProcessed.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.repPostProcessed.CheckBoxOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.repPostProcessed.ImageOptions.SvgImageChecked = global::YTR.Properties.Resources.functionsinformation;
            this.repPostProcessed.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.repPostProcessed.ImageOptions.SvgImageUnchecked = global::YTR.Properties.Resources.about1;
            this.repPostProcessed.Name = "repPostProcessed";
            // 
            // toolTipController
            // 
            this.toolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.historyTooltip_GetActiveObjectInfo);
            // 
            // lblHistoryVert
            // 
            this.lblHistoryVert.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHistoryVert.Appearance.Options.UseFont = true;
            this.lblHistoryVert.Appearance.Options.UseTextOptions = true;
            this.lblHistoryVert.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHistoryVert.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblHistoryVert.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHistoryVert.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryVert.Location = new System.Drawing.Point(2, 32);
            this.lblHistoryVert.Margin = new System.Windows.Forms.Padding(0);
            this.lblHistoryVert.Name = "lblHistoryVert";
            this.lblHistoryVert.Size = new System.Drawing.Size(296, 208);
            this.lblHistoryVert.TabIndex = 2;
            this.lblHistoryVert.Text = "D\r\nO\r\nW\r\nN\r\nL\r\nO\r\nA\r\nD\r\n\r\nH\r\nI\r\nS\r\nT\r\nO\r\nR\r\nY";
            this.lblHistoryVert.Visible = false;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.Controls.Add(this.lblHeaderLabel);
            this.pnlHistoryHeader.Controls.Add(this.btnShowHideHistory);
            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Location = new System.Drawing.Point(2, 2);
            this.pnlHistoryHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(296, 30);
            this.pnlHistoryHeader.TabIndex = 0;
            // 
            // lblHeaderLabel
            // 
            this.lblHeaderLabel.Appearance.Options.UseTextOptions = true;
            this.lblHeaderLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHeaderLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHeaderLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderLabel.Location = new System.Drawing.Point(2, 2);
            this.lblHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeaderLabel.Name = "lblHeaderLabel";
            this.lblHeaderLabel.Size = new System.Drawing.Size(266, 26);
            this.lblHeaderLabel.TabIndex = 1;
            this.lblHeaderLabel.Text = "Download History";
            // 
            // btnShowHideHistory
            // 
            this.btnShowHideHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowHideHistory.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnShowHideHistory.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnShowHideHistory.ImageOptions.SvgImage = global::YTR.Properties.Resources.doublenext;
            this.btnShowHideHistory.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btnShowHideHistory.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnShowHideHistory.Location = new System.Drawing.Point(268, 2);
            this.btnShowHideHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowHideHistory.Name = "btnShowHideHistory";
            this.btnShowHideHistory.Size = new System.Drawing.Size(26, 26);
            this.btnShowHideHistory.TabIndex = 0;
            this.btnShowHideHistory.Click += new System.EventHandler(this.btnShowHideHistory_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Quick Download is now enabled.\r\nConfigure Hotkey in Advanced Settings.\r\nDouble Cl" +
    "ick to open YTR";
            this.notifyIcon.BalloonTipTitle = "YTR is Still Running";
            this.notifyIcon.ContextMenuStrip = this.taskBarMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "YTR";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // taskBarMenu
            // 
            this.taskBarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiDownload,
            this.tsiSettings,
            this.tsiExit});
            this.taskBarMenu.Name = "taskBarMenu";
            this.taskBarMenu.Size = new System.Drawing.Size(163, 70);
            // 
            // tsiDownload
            // 
            this.tsiDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiDownload.Name = "tsiDownload";
            this.tsiDownload.Size = new System.Drawing.Size(162, 22);
            this.tsiDownload.Text = "Quick Download";
            this.tsiDownload.Click += new System.EventHandler(this.tsiDownload_Click);
            // 
            // tsiSettings
            // 
            this.tsiSettings.Name = "tsiSettings";
            this.tsiSettings.Size = new System.Drawing.Size(162, 22);
            this.tsiSettings.Text = "Settings";
            this.tsiSettings.Click += new System.EventHandler(this.tsiSettings_Click);
            // 
            // tsiExit
            // 
            this.tsiExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(162, 22);
            this.tsiExit.Text = "Exit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // historyBarManager
            // 
            this.historyBarManager.DockControls.Add(this.barDockControlTop);
            this.historyBarManager.DockControls.Add(this.barDockControlBottom);
            this.historyBarManager.DockControls.Add(this.barDockControlLeft);
            this.historyBarManager.DockControls.Add(this.barDockControlRight);
            this.historyBarManager.Form = this;
            this.historyBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiReDownload,
            this.bbiNewDownload});
            this.historyBarManager.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.historyBarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1188, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 833);
            this.barDockControlBottom.Manager = this.historyBarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1188, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.historyBarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 833);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1188, 0);
            this.barDockControlRight.Manager = this.historyBarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 833);
            // 
            // bbiReDownload
            // 
            this.bbiReDownload.Caption = "Download Again";
            this.bbiReDownload.Id = 0;
            this.bbiReDownload.Name = "bbiReDownload";
            this.bbiReDownload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReDownload_ItemClick);
            // 
            // bbiNewDownload
            // 
            this.bbiNewDownload.Caption = "Use URL for New Download";
            this.bbiNewDownload.Id = 1;
            this.bbiNewDownload.Name = "bbiNewDownload";
            this.bbiNewDownload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNewDownload_ItemClick);
            // 
            // historyPopup
            // 
            this.historyPopup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiReDownload),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNewDownload)});
            this.historyPopup.Manager = this.historyBarManager;
            this.historyPopup.Name = "historyPopup";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 833);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tcMainTabControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.MinimumSize = new System.Drawing.Size(823, 664);
            this.Name = "MainForm";
            this.TabFormControl = this.tcMainTabControl;
            this.Text = "YTR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tcMainTabControl)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter.Panel1)).EndInit();
            this.sccMainSplitter.Panel1.ResumeLayout(false);
            this.sccMainSplitter.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter.Panel2)).EndInit();
            this.sccMainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter)).EndInit();
            this.sccMainSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPlaylistControls)).EndInit();
            this.pnlPlaylistControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.pnlScrollableControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHistoryPanel)).EndInit();
            this.pnlHistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repFileExists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPostProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHistoryHeader)).EndInit();
            this.pnlHistoryHeader.ResumeLayout(false);
            this.taskBarMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected DevExpress.XtraBars.TabFormControl tcMainTabControl;
        private DevExpress.XtraBars.BarButtonItem bbiSettings;
        private DevExpress.XtraBars.BarStaticItem bsiMessage;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip taskBarMenu;
        private System.Windows.Forms.ToolStripMenuItem tsiDownload;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.ToolStripMenuItem tsiSettings;
        private DevExpress.Utils.ToolTipController toolTipController;
        private YTR.Controls.CustomTabFormPage tfpMain;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.SplitContainerControl sccMainSplitter;
        private Controls.InputPanel ipMainInput;
        private DevExpress.XtraEditors.LabelControl lblSelectAFormat;
        private DevExpress.XtraGrid.GridControl gcFormats;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFormats;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private Controls.ControlPanel cpMainControlPanel;
        private Controls.VideoInfoPanel videoInfoPanel;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repPictureEdit;
        private DevExpress.XtraEditors.PanelControl pnlPlaylistControls;
        private DevExpress.XtraEditors.SimpleButton btnPLSelectAll;
        private DevExpress.XtraEditors.XtraScrollableControl pnlScrollableControls;
        private DevExpress.XtraEditors.PanelControl pnlHistoryPanel;
        private DevExpress.XtraEditors.PanelControl pnlHistoryHeader;
        public DevExpress.XtraGrid.GridControl gcHistory;
        public DevExpress.XtraGrid.Views.Grid.GridView gvHistory;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repFileExists;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repPostProcessed;
        private DevExpress.XtraEditors.SimpleButton btnShowHideHistory;
        private DevExpress.XtraEditors.LabelControl lblHistoryVert;
        private DevExpress.XtraEditors.LabelControl lblHeaderLabel;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager historyBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiReDownload;
        private DevExpress.XtraBars.BarButtonItem bbiNewDownload;
        private DevExpress.XtraBars.PopupMenu historyPopup;
        private DevExpress.XtraEditors.SplitterControl scHistorySplitter;
    }
}

