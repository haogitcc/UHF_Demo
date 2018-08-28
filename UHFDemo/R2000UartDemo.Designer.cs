﻿using System.Windows.Forms;
namespace UHFDemo
{
    partial class R2000UartDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // add ms
        public static long wasteTime = 0;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R2000UartDemo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btFastInventory = new System.Windows.Forms.Button();
            this.label123 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.txtDStay = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.cmbAntSelect1 = new System.Windows.Forms.ComboBox();
            this.label121 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.cmbAntSelect4 = new System.Windows.Forms.ComboBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtCStay = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtAStay = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.cmbAntSelect2 = new System.Windows.Forms.ComboBox();
            this.label118 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.cmbAntSelect3 = new System.Windows.Forms.ComboBox();
            this.txtBStay = new System.Windows.Forms.TextBox();
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.PagReaderSetting = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.antType8 = new System.Windows.Forms.RadioButton();
            this.antType4 = new System.Windows.Forms.RadioButton();
            this.antType1 = new System.Windows.Forms.RadioButton();
            this.btReaderSetupRefresh = new System.Windows.Forms.Button();
            this.gbCmdReadGpio = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.rdbGpio3High = new System.Windows.Forms.RadioButton();
            this.rdbGpio3Low = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rdbGpio4High = new System.Windows.Forms.RadioButton();
            this.rdbGpio4Low = new System.Windows.Forms.RadioButton();
            this.btnWriteGpio4Value = new System.Windows.Forms.Button();
            this.btnWriteGpio3Value = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.rdbGpio1High = new System.Windows.Forms.RadioButton();
            this.rdbGpio1Low = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rdbGpio2High = new System.Windows.Forms.RadioButton();
            this.rdbGpio2Low = new System.Windows.Forms.RadioButton();
            this.btnReadGpioValue = new System.Windows.Forms.Button();
            this.gbCmdBeeper = new System.Windows.Forms.GroupBox();
            this.btnSetBeeperMode = new System.Windows.Forms.Button();
            this.rdbBeeperModeTag = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeInventory = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeSlient = new System.Windows.Forms.RadioButton();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbCmdVersion = new System.Windows.Forms.GroupBox();
            this.btnGetFirmwareVersion = new System.Windows.Forms.Button();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.btnResetReader = new System.Windows.Forms.Button();
            this.gbCmdBaudrate = new System.Windows.Forms.GroupBox();
            this.htbGetIdentifier = new CustomControl.HexTextBox();
            this.htbSetIdentifier = new CustomControl.HexTextBox();
            this.btSetIdentifier = new System.Windows.Forms.Button();
            this.btGetIdentifier = new System.Windows.Forms.Button();
            this.gbCmdReaderAddress = new System.Windows.Forms.GroupBox();
            this.htxtReadId = new CustomControl.HexTextBox();
            this.btnSetReadAddress = new System.Windows.Forms.Button();
            this.gbTcpIp = new System.Windows.Forms.GroupBox();
            this.btnDisconnectTcp = new System.Windows.Forms.Button();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.btnConnectTcp = new System.Windows.Forms.Button();
            this.ipIpServer = new CustomControl.IpAddressTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRS232 = new System.Windows.Forms.GroupBox();
            this.btnSetUartBaudrate = new System.Windows.Forms.Button();
            this.btnDisconnectRs232 = new System.Windows.Forms.Button();
            this.cmbSetBaudrate = new System.Windows.Forms.ComboBox();
            this.lbChangeBaudrate = new System.Windows.Forms.Label();
            this.btnConnectRs232 = new System.Windows.Forms.Button();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConnectType = new System.Windows.Forms.GroupBox();
            this.rdbTcpIp = new System.Windows.Forms.RadioButton();
            this.rdbRS232 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btGetProfile = new System.Windows.Forms.Button();
            this.btSetProfile = new System.Windows.Forms.Button();
            this.rdbProfile3 = new System.Windows.Forms.RadioButton();
            this.rdbProfile2 = new System.Windows.Forms.RadioButton();
            this.rdbProfile1 = new System.Windows.Forms.RadioButton();
            this.rdbProfile0 = new System.Windows.Forms.RadioButton();
            this.btRfSetup = new System.Windows.Forms.Button();
            this.gbMonza = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbMonzaOff = new System.Windows.Forms.RadioButton();
            this.btSetMonzaStatus = new System.Windows.Forms.Button();
            this.btGetMonzaStatus = new System.Windows.Forms.Button();
            this.rdbMonzaOn = new System.Windows.Forms.RadioButton();
            this.gbCmdAntDetector = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAntDectector = new System.Windows.Forms.TextBox();
            this.btnGetAntDetector = new System.Windows.Forms.Button();
            this.btnSetAntDetector = new System.Windows.Forms.Button();
            this.gbCmdAntenna = new System.Windows.Forms.GroupBox();
            this.label107 = new System.Windows.Forms.Label();
            this.cmbWorkAnt = new System.Windows.Forms.ComboBox();
            this.btnGetWorkAntenna = new System.Windows.Forms.Button();
            this.btnSetWorkAntenna = new System.Windows.Forms.Button();
            this.gbCmdRegion = new System.Windows.Forms.GroupBox();
            this.cbUserDefineFreq = new System.Windows.Forms.CheckBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.textFreqQuantity = new System.Windows.Forms.TextBox();
            this.TextFreqInterval = new System.Windows.Forms.TextBox();
            this.textStartFreq = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbFrequencyEnd = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFrequencyStart = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbRegionChn = new System.Windows.Forms.RadioButton();
            this.rdbRegionEtsi = new System.Windows.Forms.RadioButton();
            this.rdbRegionFcc = new System.Windows.Forms.RadioButton();
            this.btnGetFrequencyRegion = new System.Windows.Forms.Button();
            this.btnSetFrequencyRegion = new System.Windows.Forms.Button();
            this.gbCmdOutputPower = new System.Windows.Forms.GroupBox();
            this.label115 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGetOutputPower = new System.Windows.Forms.Button();
            this.btnSetOutputPower = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pageEpcTest = new System.Windows.Forms.TabPage();
            this.tabEpcTest = new System.Windows.Forms.TabControl();
            this.pageRealMode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customizedExeTime = new System.Windows.Forms.TextBox();
            this.label127 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.mSessionExeTime = new System.Windows.Forms.ComboBox();
            this.btRealTimeInventory = new System.Windows.Forms.Button();
            this.label84 = new System.Windows.Forms.Label();
            this.textRealRound = new System.Windows.Forms.TextBox();
            this.sessionInventoryrb = new System.Windows.Forms.RadioButton();
            this.autoInventoryrb = new System.Windows.Forms.RadioButton();
            this.m_session_q_cb = new System.Windows.Forms.CheckBox();
            this.m_session_sl_cb = new System.Windows.Forms.CheckBox();
            this.m_session_max_q = new System.Windows.Forms.TextBox();
            this.m_session_min_q = new System.Windows.Forms.TextBox();
            this.m_session_start_q = new System.Windows.Forms.TextBox();
            this.m_max_q_content = new System.Windows.Forms.Label();
            this.m_min_q_content = new System.Windows.Forms.Label();
            this.m_start_q_content = new System.Windows.Forms.Label();
            this.m_session_sl = new System.Windows.Forms.ComboBox();
            this.m_sl_content = new System.Windows.Forms.Label();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.excel_format_rb = new System.Windows.Forms.RadioButton();
            this.txt_format_rb = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.mTestTagCounts = new System.Windows.Forms.TextBox();
            this.label129 = new System.Windows.Forms.Label();
            this.m_intervalTimetb = new System.Windows.Forms.TextBox();
            this.label128 = new System.Windows.Forms.Label();
            this.mInventoryBStatusCount = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.mInventoryAStatusCount = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.ｍOneKeyInventory = new System.Windows.Forms.Button();
            this.cbRealWorkant8 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant7 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant6 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant5 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant3 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRealMinRssi = new System.Windows.Forms.TextBox();
            this.tbRealMaxRssi = new System.Windows.Forms.TextBox();
            this.btRealFresh = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lbRealTagCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledReal3 = new LxControl.LxLedControl();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ledReal5 = new LxControl.LxLedControl();
            this.ledReal2 = new LxControl.LxLedControl();
            this.ledReal4 = new LxControl.LxLedControl();
            this.label53 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.ledReal1 = new LxControl.LxLedControl();
            this.lvRealList = new System.Windows.Forms.ListView();
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageBufferedMode = new System.Windows.Forms.TabPage();
            this.excel_format_buffer_rb = new System.Windows.Forms.RadioButton();
            this.txt_format_buffer_rb = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btClearBuffer = new System.Windows.Forms.Button();
            this.btQueryBuffer = new System.Windows.Forms.Button();
            this.btGetClearBuffer = new System.Windows.Forms.Button();
            this.btGetBuffer = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btBufferInventory = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.textReadRoundBuffer = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant2 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ledBuffer4 = new LxControl.LxLedControl();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.ledBuffer5 = new LxControl.LxLedControl();
            this.ledBuffer2 = new LxControl.LxLedControl();
            this.ledBuffer3 = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.ledBuffer1 = new LxControl.LxLedControl();
            this.btBufferFresh = new System.Windows.Forms.Button();
            this.labelBufferTagCount = new System.Windows.Forms.Label();
            this.lvBufferList = new System.Windows.Forms.ListView();
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageFast4AntMode = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.ledFast1 = new LxControl.LxLedControl();
            this.label58 = new System.Windows.Forms.Label();
            this.ledFast4 = new LxControl.LxLedControl();
            this.ledFast2 = new LxControl.LxLedControl();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.ledFast3 = new LxControl.LxLedControl();
            this.label57 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.ledFast5 = new LxControl.LxLedControl();
            this.txt_format_fast_rb = new System.Windows.Forms.RadioButton();
            this.excel_format_fast_rb = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.m_new_fast_inventory_power2 = new System.Windows.Forms.TextBox();
            this.m_new_fast_inventory_power1 = new System.Windows.Forms.TextBox();
            this.m_new_fast_inventory_repeat2 = new System.Windows.Forms.TextBox();
            this.m_new_fast_inventory_repeat1 = new System.Windows.Forms.TextBox();
            this.mRepeatPower1 = new System.Windows.Forms.Label();
            this.mRepeatPower2 = new System.Windows.Forms.Label();
            this.mRepeat2 = new System.Windows.Forms.Label();
            this.mRepeat1 = new System.Windows.Forms.Label();
            this.mDynamicPoll = new System.Windows.Forms.CheckBox();
            this.label132 = new System.Windows.Forms.Label();
            this.mFastExeCount = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.mFastIntervalTime = new System.Windows.Forms.TextBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.m_new_fast_inventory_target_count = new System.Windows.Forms.TextBox();
            this.mTargetQuantity = new System.Windows.Forms.Label();
            this.m_new_fast_inventory_continue = new System.Windows.Forms.TextBox();
            this.mContiue = new System.Windows.Forms.Label();
            this.m_new_fast_inventory_optimized = new System.Windows.Forms.TextBox();
            this.mOpitimized = new System.Windows.Forms.Label();
            this.m_phase_value = new System.Windows.Forms.CheckBox();
            this.m_new_fast_inventory_flag = new System.Windows.Forms.ComboBox();
            this.m_new_fast_inventory_session = new System.Windows.Forms.ComboBox();
            this.m_new_fast_inventory = new System.Windows.Forms.CheckBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.mReserve = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.mPower1 = new System.Windows.Forms.TextBox();
            this.mPower2 = new System.Windows.Forms.TextBox();
            this.mPower5 = new System.Windows.Forms.TextBox();
            this.mPower4 = new System.Windows.Forms.TextBox();
            this.mPower3 = new System.Windows.Forms.TextBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.txtFastMaxRssi = new System.Windows.Forms.TextBox();
            this.txtFastMinRssi = new System.Windows.Forms.TextBox();
            this.buttonFastFresh = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.lvFastList = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader356 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label49 = new System.Windows.Forms.Label();
            this.txtFastTagList = new System.Windows.Forms.Label();
            this.pageAcessTag = new System.Windows.Forms.TabPage();
            this.ltvOperate = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCmdOperateTag = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnKillTag = new System.Windows.Forms.Button();
            this.htxtKillPwd = new CustomControl.HexTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.htxtLockPwd = new CustomControl.HexTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rdbUserMemory = new System.Windows.Forms.RadioButton();
            this.rdbTidMemory = new System.Windows.Forms.RadioButton();
            this.rdbEpcMermory = new System.Windows.Forms.RadioButton();
            this.rdbKillPwd = new System.Windows.Forms.RadioButton();
            this.rdbAccessPwd = new System.Windows.Forms.RadioButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.rdbLockEver = new System.Windows.Forms.RadioButton();
            this.rdbFreeEver = new System.Windows.Forms.RadioButton();
            this.rdbLock = new System.Windows.Forms.RadioButton();
            this.rdbFree = new System.Windows.Forms.RadioButton();
            this.btnLockTag = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.htxtWriteData = new CustomControl.HexTextBox();
            this.txtWordCnt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnWriteTag = new System.Windows.Forms.Button();
            this.btnReadTag = new System.Windows.Forms.Button();
            this.txtWordAdd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.htxtReadAndWritePwd = new CustomControl.HexTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbTid = new System.Windows.Forms.RadioButton();
            this.rdbEpc = new System.Windows.Forms.RadioButton();
            this.rdbReserved = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSetAccessEpcMatch = new System.Windows.Forms.Button();
            this.cmbSetAccessEpcMatch = new System.Windows.Forms.ComboBox();
            this.txtAccessEpcMatch = new System.Windows.Forms.TextBox();
            this.ckAccessEpcMatch = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label111 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.hexTextBox9 = new CustomControl.HexTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PagISO18000 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInventoryISO18000 = new System.Windows.Forms.Button();
            this.ltvTagISO18000 = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbISO1800LockQuery = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.htxtQueryAdd = new CustomControl.HexTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.htxtLockAdd = new CustomControl.HexTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.btnQueryTagISO18000 = new System.Windows.Forms.Button();
            this.btnLockTagISO18000 = new System.Windows.Forms.Button();
            this.gbISO1800ReadWrite = new System.Windows.Forms.GroupBox();
            this.txtLoopTimes = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.htxtWriteData18000 = new CustomControl.HexTextBox();
            this.txtWriteLength = new System.Windows.Forms.TextBox();
            this.htxtReadData18000 = new CustomControl.HexTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btnWriteTagISO18000 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtReadLength = new System.Windows.Forms.TextBox();
            this.htxtWriteStartAdd = new CustomControl.HexTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.htxtReadStartAdd = new CustomControl.HexTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnReadTagISO18000 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.htxtReadUID = new CustomControl.HexTextBox();
            this.PagTranDataLog = new System.Windows.Forms.TabPage();
            this.gbCmdManual = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.htxtSendData = new CustomControl.HexTextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.htxtCheckData = new CustomControl.HexTextBox();
            this.lrtxtDataTran = new CustomControl.LogRichTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.ckDisplayLog = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.lxLedControl9 = new LxControl.LxLedControl();
            this.lxLedControl10 = new LxControl.LxLedControl();
            this.lxLedControl11 = new LxControl.LxLedControl();
            this.lxLedControl12 = new LxControl.LxLedControl();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.lxLedControl13 = new LxControl.LxLedControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.lxLedControl14 = new LxControl.LxLedControl();
            this.lxLedControl15 = new LxControl.LxLedControl();
            this.lxLedControl16 = new LxControl.LxLedControl();
            this.lxLedControl17 = new LxControl.LxLedControl();
            this.lxLedControl18 = new LxControl.LxLedControl();
            this.timerInventory = new System.Windows.Forms.Timer(this.components);
            this.intervalExecuteTimer = new System.Windows.Forms.Timer(this.components);
            this.totalTime = new System.Windows.Forms.Timer(this.components);
            this.mFastSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.sortImageList = new System.Windows.Forms.ImageList(this.components);
            this.mSendFastSwitchTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCtrMain.SuspendLayout();
            this.PagReaderSetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.gbCmdReadGpio.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbCmdBeeper.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbCmdVersion.SuspendLayout();
            this.gbCmdBaudrate.SuspendLayout();
            this.gbCmdReaderAddress.SuspendLayout();
            this.gbTcpIp.SuspendLayout();
            this.gbRS232.SuspendLayout();
            this.gbConnectType.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbProfile.SuspendLayout();
            this.gbMonza.SuspendLayout();
            this.gbCmdAntDetector.SuspendLayout();
            this.gbCmdAntenna.SuspendLayout();
            this.gbCmdRegion.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.gbCmdOutputPower.SuspendLayout();
            this.pageEpcTest.SuspendLayout();
            this.tabEpcTest.SuspendLayout();
            this.pageRealMode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).BeginInit();
            this.pageBufferedMode.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).BeginInit();
            this.pageFast4AntMode.SuspendLayout();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.pageAcessTag.SuspendLayout();
            this.gbCmdOperateTag.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.PagISO18000.SuspendLayout();
            this.gbISO1800LockQuery.SuspendLayout();
            this.gbISO1800ReadWrite.SuspendLayout();
            this.PagTranDataLog.SuspendLayout();
            this.gbCmdManual.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btFastInventory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label123);
            this.splitContainer1.Panel2.Controls.Add(this.textBox16);
            this.splitContainer1.Panel2.Controls.Add(this.label124);
            this.splitContainer1.Panel2.Controls.Add(this.label120);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox4);
            this.splitContainer1.Panel2.Controls.Add(this.txtDStay);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label64);
            this.splitContainer1.Panel2.Controls.Add(this.label116);
            this.splitContainer1.Panel2.Controls.Add(this.textBox15);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAntSelect1);
            this.splitContainer1.Panel2.Controls.Add(this.label121);
            this.splitContainer1.Panel2.Controls.Add(this.label48);
            this.splitContainer1.Panel2.Controls.Add(this.label65);
            this.splitContainer1.Panel2.Controls.Add(this.label119);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAntSelect4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox14);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel2.Controls.Add(this.txtCStay);
            this.splitContainer1.Panel2.Controls.Add(this.label59);
            this.splitContainer1.Panel2.Controls.Add(this.txtAStay);
            this.splitContainer1.Panel2.Controls.Add(this.label117);
            this.splitContainer1.Panel2.Controls.Add(this.label62);
            this.splitContainer1.Panel2.Controls.Add(this.textBox13);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAntSelect2);
            this.splitContainer1.Panel2.Controls.Add(this.label118);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label61);
            this.splitContainer1.Panel2.Controls.Add(this.label63);
            this.splitContainer1.Panel2.Controls.Add(this.label60);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAntSelect3);
            this.splitContainer1.Panel2.Controls.Add(this.txtBStay);
            // 
            // btFastInventory
            // 
            resources.ApplyResources(this.btFastInventory, "btFastInventory");
            this.btFastInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btFastInventory.Name = "btFastInventory";
            this.btFastInventory.UseVisualStyleBackColor = true;
            this.btFastInventory.Click += new System.EventHandler(this.btFastInventory_Click);
            // 
            // label123
            // 
            resources.ApplyResources(this.label123, "label123");
            this.label123.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label123.Name = "label123";
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            // 
            // label124
            // 
            resources.ApplyResources(this.label124, "label124");
            this.label124.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label124.Name = "label124";
            // 
            // label120
            // 
            resources.ApplyResources(this.label120, "label120");
            this.label120.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label120.Name = "label120";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            resources.GetString("comboBox4.Items1"),
            resources.GetString("comboBox4.Items2"),
            resources.GetString("comboBox4.Items3"),
            resources.GetString("comboBox4.Items4"),
            resources.GetString("comboBox4.Items5"),
            resources.GetString("comboBox4.Items6"),
            resources.GetString("comboBox4.Items7"),
            resources.GetString("comboBox4.Items8")});
            this.comboBox4.Name = "comboBox4";
            // 
            // txtDStay
            // 
            this.txtDStay.AcceptsReturn = true;
            resources.ApplyResources(this.txtDStay, "txtDStay");
            this.txtDStay.Name = "txtDStay";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8")});
            this.comboBox1.Name = "comboBox1";
            // 
            // label64
            // 
            resources.ApplyResources(this.label64, "label64");
            this.label64.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label64.Name = "label64";
            // 
            // label116
            // 
            resources.ApplyResources(this.label116, "label116");
            this.label116.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label116.Name = "label116";
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            // 
            // cmbAntSelect1
            // 
            this.cmbAntSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbAntSelect1, "cmbAntSelect1");
            this.cmbAntSelect1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect1.FormattingEnabled = true;
            this.cmbAntSelect1.Items.AddRange(new object[] {
            resources.GetString("cmbAntSelect1.Items"),
            resources.GetString("cmbAntSelect1.Items1"),
            resources.GetString("cmbAntSelect1.Items2"),
            resources.GetString("cmbAntSelect1.Items3"),
            resources.GetString("cmbAntSelect1.Items4"),
            resources.GetString("cmbAntSelect1.Items5"),
            resources.GetString("cmbAntSelect1.Items6"),
            resources.GetString("cmbAntSelect1.Items7"),
            resources.GetString("cmbAntSelect1.Items8")});
            this.cmbAntSelect1.Name = "cmbAntSelect1";
            // 
            // label121
            // 
            resources.ApplyResources(this.label121, "label121");
            this.label121.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label121.Name = "label121";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Name = "label48";
            // 
            // label65
            // 
            resources.ApplyResources(this.label65, "label65");
            this.label65.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label65.Name = "label65";
            // 
            // label119
            // 
            resources.ApplyResources(this.label119, "label119");
            this.label119.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label119.Name = "label119";
            // 
            // cmbAntSelect4
            // 
            this.cmbAntSelect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbAntSelect4, "cmbAntSelect4");
            this.cmbAntSelect4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect4.FormattingEnabled = true;
            this.cmbAntSelect4.Items.AddRange(new object[] {
            resources.GetString("cmbAntSelect4.Items"),
            resources.GetString("cmbAntSelect4.Items1"),
            resources.GetString("cmbAntSelect4.Items2"),
            resources.GetString("cmbAntSelect4.Items3"),
            resources.GetString("cmbAntSelect4.Items4"),
            resources.GetString("cmbAntSelect4.Items5"),
            resources.GetString("cmbAntSelect4.Items6"),
            resources.GetString("cmbAntSelect4.Items7"),
            resources.GetString("cmbAntSelect4.Items8")});
            this.cmbAntSelect4.Name = "cmbAntSelect4";
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4"),
            resources.GetString("comboBox3.Items5"),
            resources.GetString("comboBox3.Items6"),
            resources.GetString("comboBox3.Items7"),
            resources.GetString("comboBox3.Items8")});
            this.comboBox3.Name = "comboBox3";
            // 
            // txtCStay
            // 
            resources.ApplyResources(this.txtCStay, "txtCStay");
            this.txtCStay.Name = "txtCStay";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label59.Name = "label59";
            // 
            // txtAStay
            // 
            resources.ApplyResources(this.txtAStay, "txtAStay");
            this.txtAStay.Name = "txtAStay";
            // 
            // label117
            // 
            resources.ApplyResources(this.label117, "label117");
            this.label117.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label117.Name = "label117";
            // 
            // label62
            // 
            resources.ApplyResources(this.label62, "label62");
            this.label62.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label62.Name = "label62";
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            // 
            // cmbAntSelect2
            // 
            this.cmbAntSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbAntSelect2, "cmbAntSelect2");
            this.cmbAntSelect2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect2.FormattingEnabled = true;
            this.cmbAntSelect2.Items.AddRange(new object[] {
            resources.GetString("cmbAntSelect2.Items"),
            resources.GetString("cmbAntSelect2.Items1"),
            resources.GetString("cmbAntSelect2.Items2"),
            resources.GetString("cmbAntSelect2.Items3"),
            resources.GetString("cmbAntSelect2.Items4"),
            resources.GetString("cmbAntSelect2.Items5"),
            resources.GetString("cmbAntSelect2.Items6"),
            resources.GetString("cmbAntSelect2.Items7"),
            resources.GetString("cmbAntSelect2.Items8")});
            this.cmbAntSelect2.Name = "cmbAntSelect2";
            // 
            // label118
            // 
            resources.ApplyResources(this.label118, "label118");
            this.label118.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label118.Name = "label118";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8")});
            this.comboBox2.Name = "comboBox2";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label61.Name = "label61";
            this.label61.Click += new System.EventHandler(this.label61_Click);
            // 
            // label63
            // 
            resources.ApplyResources(this.label63, "label63");
            this.label63.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label63.Name = "label63";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label60.Name = "label60";
            // 
            // cmbAntSelect3
            // 
            this.cmbAntSelect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbAntSelect3, "cmbAntSelect3");
            this.cmbAntSelect3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect3.FormattingEnabled = true;
            this.cmbAntSelect3.Items.AddRange(new object[] {
            resources.GetString("cmbAntSelect3.Items"),
            resources.GetString("cmbAntSelect3.Items1"),
            resources.GetString("cmbAntSelect3.Items2"),
            resources.GetString("cmbAntSelect3.Items3"),
            resources.GetString("cmbAntSelect3.Items4"),
            resources.GetString("cmbAntSelect3.Items5"),
            resources.GetString("cmbAntSelect3.Items6"),
            resources.GetString("cmbAntSelect3.Items7"),
            resources.GetString("cmbAntSelect3.Items8")});
            this.cmbAntSelect3.Name = "cmbAntSelect3";
            // 
            // txtBStay
            // 
            resources.ApplyResources(this.txtBStay, "txtBStay");
            this.txtBStay.Name = "txtBStay";
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Controls.Add(this.PagReaderSetting);
            this.tabCtrMain.Controls.Add(this.pageEpcTest);
            this.tabCtrMain.Controls.Add(this.PagISO18000);
            this.tabCtrMain.Controls.Add(this.PagTranDataLog);
            resources.ApplyResources(this.tabCtrMain, "tabCtrMain");
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrMain_SelectedIndexChanged);
            this.tabCtrMain.Click += new System.EventHandler(this.tabCtrMain_Click);
            // 
            // PagReaderSetting
            // 
            this.PagReaderSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagReaderSetting.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.PagReaderSetting, "PagReaderSetting");
            this.PagReaderSetting.Name = "PagReaderSetting";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox24);
            this.tabPage1.Controls.Add(this.btReaderSetupRefresh);
            this.tabPage1.Controls.Add(this.gbCmdReadGpio);
            this.tabPage1.Controls.Add(this.gbCmdBeeper);
            this.tabPage1.Controls.Add(this.gbCmdTemperature);
            this.tabPage1.Controls.Add(this.gbCmdVersion);
            this.tabPage1.Controls.Add(this.btnResetReader);
            this.tabPage1.Controls.Add(this.gbCmdBaudrate);
            this.tabPage1.Controls.Add(this.gbCmdReaderAddress);
            this.tabPage1.Controls.Add(this.gbTcpIp);
            this.tabPage1.Controls.Add(this.gbRS232);
            this.tabPage1.Controls.Add(this.gbConnectType);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.antType8);
            this.groupBox24.Controls.Add(this.antType4);
            this.groupBox24.Controls.Add(this.antType1);
            resources.ApplyResources(this.groupBox24, "groupBox24");
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.TabStop = false;
            // 
            // antType8
            // 
            resources.ApplyResources(this.antType8, "antType8");
            this.antType8.Name = "antType8";
            this.antType8.TabStop = true;
            this.antType8.UseVisualStyleBackColor = true;
            this.antType8.CheckedChanged += new System.EventHandler(this.antType8_CheckedChanged);
            // 
            // antType4
            // 
            resources.ApplyResources(this.antType4, "antType4");
            this.antType4.Name = "antType4";
            this.antType4.TabStop = true;
            this.antType4.UseVisualStyleBackColor = true;
            this.antType4.CheckedChanged += new System.EventHandler(this.antType4_CheckedChanged);
            // 
            // antType1
            // 
            resources.ApplyResources(this.antType1, "antType1");
            this.antType1.Name = "antType1";
            this.antType1.TabStop = true;
            this.antType1.UseVisualStyleBackColor = true;
            this.antType1.CheckedChanged += new System.EventHandler(this.antType1_CheckedChanged);
            // 
            // btReaderSetupRefresh
            // 
            resources.ApplyResources(this.btReaderSetupRefresh, "btReaderSetupRefresh");
            this.btReaderSetupRefresh.Name = "btReaderSetupRefresh";
            this.btReaderSetupRefresh.UseVisualStyleBackColor = true;
            this.btReaderSetupRefresh.Click += new System.EventHandler(this.btReaderSetupRefresh_Click);
            // 
            // gbCmdReadGpio
            // 
            this.gbCmdReadGpio.Controls.Add(this.groupBox11);
            this.gbCmdReadGpio.Controls.Add(this.groupBox10);
            this.gbCmdReadGpio.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdReadGpio, "gbCmdReadGpio");
            this.gbCmdReadGpio.Name = "gbCmdReadGpio";
            this.gbCmdReadGpio.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.groupBox6);
            this.groupBox11.Controls.Add(this.groupBox7);
            this.groupBox11.Controls.Add(this.btnWriteGpio4Value);
            this.groupBox11.Controls.Add(this.btnWriteGpio3Value);
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.rdbGpio3High);
            this.groupBox6.Controls.Add(this.rdbGpio3Low);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // rdbGpio3High
            // 
            resources.ApplyResources(this.rdbGpio3High, "rdbGpio3High");
            this.rdbGpio3High.Name = "rdbGpio3High";
            this.rdbGpio3High.TabStop = true;
            this.rdbGpio3High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio3Low
            // 
            resources.ApplyResources(this.rdbGpio3Low, "rdbGpio3Low");
            this.rdbGpio3Low.Name = "rdbGpio3Low";
            this.rdbGpio3Low.TabStop = true;
            this.rdbGpio3Low.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.rdbGpio4High);
            this.groupBox7.Controls.Add(this.rdbGpio4Low);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // rdbGpio4High
            // 
            resources.ApplyResources(this.rdbGpio4High, "rdbGpio4High");
            this.rdbGpio4High.Name = "rdbGpio4High";
            this.rdbGpio4High.TabStop = true;
            this.rdbGpio4High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio4Low
            // 
            resources.ApplyResources(this.rdbGpio4Low, "rdbGpio4Low");
            this.rdbGpio4Low.Name = "rdbGpio4Low";
            this.rdbGpio4Low.TabStop = true;
            this.rdbGpio4Low.UseVisualStyleBackColor = true;
            // 
            // btnWriteGpio4Value
            // 
            resources.ApplyResources(this.btnWriteGpio4Value, "btnWriteGpio4Value");
            this.btnWriteGpio4Value.Name = "btnWriteGpio4Value";
            this.btnWriteGpio4Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio4Value.Click += new System.EventHandler(this.btnWriteGpio4Value_Click);
            // 
            // btnWriteGpio3Value
            // 
            resources.ApplyResources(this.btnWriteGpio3Value, "btnWriteGpio3Value");
            this.btnWriteGpio3Value.Name = "btnWriteGpio3Value";
            this.btnWriteGpio3Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio3Value.Click += new System.EventHandler(this.btnWriteGpio3Value_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox4);
            this.groupBox10.Controls.Add(this.groupBox5);
            this.groupBox10.Controls.Add(this.btnReadGpioValue);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.rdbGpio1High);
            this.groupBox4.Controls.Add(this.rdbGpio1Low);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // rdbGpio1High
            // 
            resources.ApplyResources(this.rdbGpio1High, "rdbGpio1High");
            this.rdbGpio1High.Name = "rdbGpio1High";
            this.rdbGpio1High.TabStop = true;
            this.rdbGpio1High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio1Low
            // 
            resources.ApplyResources(this.rdbGpio1Low, "rdbGpio1Low");
            this.rdbGpio1Low.Name = "rdbGpio1Low";
            this.rdbGpio1Low.TabStop = true;
            this.rdbGpio1Low.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.rdbGpio2High);
            this.groupBox5.Controls.Add(this.rdbGpio2Low);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // rdbGpio2High
            // 
            resources.ApplyResources(this.rdbGpio2High, "rdbGpio2High");
            this.rdbGpio2High.Name = "rdbGpio2High";
            this.rdbGpio2High.TabStop = true;
            this.rdbGpio2High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio2Low
            // 
            resources.ApplyResources(this.rdbGpio2Low, "rdbGpio2Low");
            this.rdbGpio2Low.Name = "rdbGpio2Low";
            this.rdbGpio2Low.TabStop = true;
            this.rdbGpio2Low.UseVisualStyleBackColor = true;
            // 
            // btnReadGpioValue
            // 
            resources.ApplyResources(this.btnReadGpioValue, "btnReadGpioValue");
            this.btnReadGpioValue.Name = "btnReadGpioValue";
            this.btnReadGpioValue.UseVisualStyleBackColor = true;
            this.btnReadGpioValue.Click += new System.EventHandler(this.btnReadGpioValue_Click);
            // 
            // gbCmdBeeper
            // 
            this.gbCmdBeeper.Controls.Add(this.btnSetBeeperMode);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeTag);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeInventory);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeSlient);
            this.gbCmdBeeper.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdBeeper, "gbCmdBeeper");
            this.gbCmdBeeper.Name = "gbCmdBeeper";
            this.gbCmdBeeper.TabStop = false;
            // 
            // btnSetBeeperMode
            // 
            resources.ApplyResources(this.btnSetBeeperMode, "btnSetBeeperMode");
            this.btnSetBeeperMode.Name = "btnSetBeeperMode";
            this.btnSetBeeperMode.UseVisualStyleBackColor = true;
            this.btnSetBeeperMode.Click += new System.EventHandler(this.btnSetBeeperMode_Click);
            // 
            // rdbBeeperModeTag
            // 
            resources.ApplyResources(this.rdbBeeperModeTag, "rdbBeeperModeTag");
            this.rdbBeeperModeTag.Name = "rdbBeeperModeTag";
            this.rdbBeeperModeTag.TabStop = true;
            this.rdbBeeperModeTag.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeInventory
            // 
            resources.ApplyResources(this.rdbBeeperModeInventory, "rdbBeeperModeInventory");
            this.rdbBeeperModeInventory.Name = "rdbBeeperModeInventory";
            this.rdbBeeperModeInventory.TabStop = true;
            this.rdbBeeperModeInventory.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeSlient
            // 
            resources.ApplyResources(this.rdbBeeperModeSlient, "rdbBeeperModeSlient");
            this.rdbBeeperModeSlient.Name = "rdbBeeperModeSlient";
            this.rdbBeeperModeSlient.TabStop = true;
            this.rdbBeeperModeSlient.UseVisualStyleBackColor = true;
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdTemperature, "gbCmdTemperature");
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.TabStop = false;
            // 
            // btnGetReaderTemperature
            // 
            resources.ApplyResources(this.btnGetReaderTemperature, "btnGetReaderTemperature");
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            resources.ApplyResources(this.txtReaderTemperature, "txtReaderTemperature");
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            // 
            // gbCmdVersion
            // 
            this.gbCmdVersion.Controls.Add(this.btnGetFirmwareVersion);
            this.gbCmdVersion.Controls.Add(this.txtFirmwareVersion);
            this.gbCmdVersion.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdVersion, "gbCmdVersion");
            this.gbCmdVersion.Name = "gbCmdVersion";
            this.gbCmdVersion.TabStop = false;
            // 
            // btnGetFirmwareVersion
            // 
            resources.ApplyResources(this.btnGetFirmwareVersion, "btnGetFirmwareVersion");
            this.btnGetFirmwareVersion.Name = "btnGetFirmwareVersion";
            this.btnGetFirmwareVersion.UseVisualStyleBackColor = true;
            this.btnGetFirmwareVersion.Click += new System.EventHandler(this.btnGetFirmwareVersion_Click);
            // 
            // txtFirmwareVersion
            // 
            resources.ApplyResources(this.txtFirmwareVersion, "txtFirmwareVersion");
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.ReadOnly = true;
            // 
            // btnResetReader
            // 
            resources.ApplyResources(this.btnResetReader, "btnResetReader");
            this.btnResetReader.Name = "btnResetReader";
            this.btnResetReader.UseVisualStyleBackColor = true;
            this.btnResetReader.Click += new System.EventHandler(this.btnResetReader_Click);
            // 
            // gbCmdBaudrate
            // 
            this.gbCmdBaudrate.Controls.Add(this.htbGetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.htbSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btGetIdentifier);
            this.gbCmdBaudrate.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdBaudrate, "gbCmdBaudrate");
            this.gbCmdBaudrate.Name = "gbCmdBaudrate";
            this.gbCmdBaudrate.TabStop = false;
            // 
            // htbGetIdentifier
            // 
            resources.ApplyResources(this.htbGetIdentifier, "htbGetIdentifier");
            this.htbGetIdentifier.Name = "htbGetIdentifier";
            this.htbGetIdentifier.ReadOnly = true;
            // 
            // htbSetIdentifier
            // 
            resources.ApplyResources(this.htbSetIdentifier, "htbSetIdentifier");
            this.htbSetIdentifier.Name = "htbSetIdentifier";
            // 
            // btSetIdentifier
            // 
            resources.ApplyResources(this.btSetIdentifier, "btSetIdentifier");
            this.btSetIdentifier.Name = "btSetIdentifier";
            this.btSetIdentifier.UseVisualStyleBackColor = true;
            this.btSetIdentifier.Click += new System.EventHandler(this.btSetIdentifier_Click);
            // 
            // btGetIdentifier
            // 
            resources.ApplyResources(this.btGetIdentifier, "btGetIdentifier");
            this.btGetIdentifier.Name = "btGetIdentifier";
            this.btGetIdentifier.UseVisualStyleBackColor = true;
            this.btGetIdentifier.Click += new System.EventHandler(this.btGetIdentifier_Click);
            // 
            // gbCmdReaderAddress
            // 
            this.gbCmdReaderAddress.Controls.Add(this.htxtReadId);
            this.gbCmdReaderAddress.Controls.Add(this.btnSetReadAddress);
            this.gbCmdReaderAddress.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdReaderAddress, "gbCmdReaderAddress");
            this.gbCmdReaderAddress.Name = "gbCmdReaderAddress";
            this.gbCmdReaderAddress.TabStop = false;
            // 
            // htxtReadId
            // 
            resources.ApplyResources(this.htxtReadId, "htxtReadId");
            this.htxtReadId.Name = "htxtReadId";
            // 
            // btnSetReadAddress
            // 
            resources.ApplyResources(this.btnSetReadAddress, "btnSetReadAddress");
            this.btnSetReadAddress.Name = "btnSetReadAddress";
            this.btnSetReadAddress.UseVisualStyleBackColor = true;
            this.btnSetReadAddress.Click += new System.EventHandler(this.btnSetReadAddress_Click);
            // 
            // gbTcpIp
            // 
            this.gbTcpIp.Controls.Add(this.btnDisconnectTcp);
            this.gbTcpIp.Controls.Add(this.txtTcpPort);
            this.gbTcpIp.Controls.Add(this.btnConnectTcp);
            this.gbTcpIp.Controls.Add(this.ipIpServer);
            this.gbTcpIp.Controls.Add(this.label4);
            this.gbTcpIp.Controls.Add(this.label3);
            resources.ApplyResources(this.gbTcpIp, "gbTcpIp");
            this.gbTcpIp.Name = "gbTcpIp";
            this.gbTcpIp.TabStop = false;
            // 
            // btnDisconnectTcp
            // 
            resources.ApplyResources(this.btnDisconnectTcp, "btnDisconnectTcp");
            this.btnDisconnectTcp.Name = "btnDisconnectTcp";
            this.btnDisconnectTcp.UseVisualStyleBackColor = true;
            this.btnDisconnectTcp.Click += new System.EventHandler(this.btnDisconnectTcp_Click);
            // 
            // txtTcpPort
            // 
            resources.ApplyResources(this.txtTcpPort, "txtTcpPort");
            this.txtTcpPort.Name = "txtTcpPort";
            // 
            // btnConnectTcp
            // 
            resources.ApplyResources(this.btnConnectTcp, "btnConnectTcp");
            this.btnConnectTcp.Name = "btnConnectTcp";
            this.btnConnectTcp.UseVisualStyleBackColor = true;
            this.btnConnectTcp.Click += new System.EventHandler(this.btnConnectTcp_Click);
            // 
            // ipIpServer
            // 
            this.ipIpServer.IpAddressStr = "";
            resources.ApplyResources(this.ipIpServer, "ipIpServer");
            this.ipIpServer.Name = "ipIpServer";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // gbRS232
            // 
            this.gbRS232.Controls.Add(this.btnSetUartBaudrate);
            this.gbRS232.Controls.Add(this.btnDisconnectRs232);
            this.gbRS232.Controls.Add(this.cmbSetBaudrate);
            this.gbRS232.Controls.Add(this.lbChangeBaudrate);
            this.gbRS232.Controls.Add(this.btnConnectRs232);
            this.gbRS232.Controls.Add(this.cmbBaudrate);
            this.gbRS232.Controls.Add(this.cmbComPort);
            this.gbRS232.Controls.Add(this.label2);
            this.gbRS232.Controls.Add(this.label1);
            resources.ApplyResources(this.gbRS232, "gbRS232");
            this.gbRS232.Name = "gbRS232";
            this.gbRS232.TabStop = false;
            // 
            // btnSetUartBaudrate
            // 
            resources.ApplyResources(this.btnSetUartBaudrate, "btnSetUartBaudrate");
            this.btnSetUartBaudrate.Name = "btnSetUartBaudrate";
            this.btnSetUartBaudrate.UseVisualStyleBackColor = true;
            this.btnSetUartBaudrate.Click += new System.EventHandler(this.btnSetUartBaudrate_Click);
            // 
            // btnDisconnectRs232
            // 
            resources.ApplyResources(this.btnDisconnectRs232, "btnDisconnectRs232");
            this.btnDisconnectRs232.Name = "btnDisconnectRs232";
            this.btnDisconnectRs232.UseVisualStyleBackColor = true;
            this.btnDisconnectRs232.Click += new System.EventHandler(this.btnDisconnectRs232_Click);
            // 
            // cmbSetBaudrate
            // 
            this.cmbSetBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetBaudrate.FormattingEnabled = true;
            this.cmbSetBaudrate.Items.AddRange(new object[] {
            resources.GetString("cmbSetBaudrate.Items"),
            resources.GetString("cmbSetBaudrate.Items1")});
            resources.ApplyResources(this.cmbSetBaudrate, "cmbSetBaudrate");
            this.cmbSetBaudrate.Name = "cmbSetBaudrate";
            // 
            // lbChangeBaudrate
            // 
            resources.ApplyResources(this.lbChangeBaudrate, "lbChangeBaudrate");
            this.lbChangeBaudrate.Name = "lbChangeBaudrate";
            // 
            // btnConnectRs232
            // 
            resources.ApplyResources(this.btnConnectRs232, "btnConnectRs232");
            this.btnConnectRs232.Name = "btnConnectRs232";
            this.btnConnectRs232.UseVisualStyleBackColor = true;
            this.btnConnectRs232.Click += new System.EventHandler(this.btnConnectRs232_Click);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            resources.GetString("cmbBaudrate.Items"),
            resources.GetString("cmbBaudrate.Items1")});
            resources.ApplyResources(this.cmbBaudrate, "cmbBaudrate");
            this.cmbBaudrate.Name = "cmbBaudrate";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Items.AddRange(new object[] {
            resources.GetString("cmbComPort.Items"),
            resources.GetString("cmbComPort.Items1"),
            resources.GetString("cmbComPort.Items2"),
            resources.GetString("cmbComPort.Items3"),
            resources.GetString("cmbComPort.Items4"),
            resources.GetString("cmbComPort.Items5"),
            resources.GetString("cmbComPort.Items6"),
            resources.GetString("cmbComPort.Items7"),
            resources.GetString("cmbComPort.Items8"),
            resources.GetString("cmbComPort.Items9"),
            resources.GetString("cmbComPort.Items10"),
            resources.GetString("cmbComPort.Items11"),
            resources.GetString("cmbComPort.Items12"),
            resources.GetString("cmbComPort.Items13"),
            resources.GetString("cmbComPort.Items14"),
            resources.GetString("cmbComPort.Items15")});
            resources.ApplyResources(this.cmbComPort, "cmbComPort");
            this.cmbComPort.Name = "cmbComPort";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbConnectType
            // 
            this.gbConnectType.Controls.Add(this.rdbTcpIp);
            this.gbConnectType.Controls.Add(this.rdbRS232);
            resources.ApplyResources(this.gbConnectType, "gbConnectType");
            this.gbConnectType.Name = "gbConnectType";
            this.gbConnectType.TabStop = false;
            // 
            // rdbTcpIp
            // 
            resources.ApplyResources(this.rdbTcpIp, "rdbTcpIp");
            this.rdbTcpIp.Name = "rdbTcpIp";
            this.rdbTcpIp.TabStop = true;
            this.rdbTcpIp.UseVisualStyleBackColor = true;
            this.rdbTcpIp.CheckedChanged += new System.EventHandler(this.rdbTcpIp_CheckedChanged);
            // 
            // rdbRS232
            // 
            resources.ApplyResources(this.rdbRS232, "rdbRS232");
            this.rdbRS232.Name = "rdbRS232";
            this.rdbRS232.TabStop = true;
            this.rdbRS232.UseVisualStyleBackColor = true;
            this.rdbRS232.CheckedChanged += new System.EventHandler(this.rdbRS232_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.gbReturnLoss);
            this.tabPage2.Controls.Add(this.gbProfile);
            this.tabPage2.Controls.Add(this.btRfSetup);
            this.tabPage2.Controls.Add(this.gbMonza);
            this.tabPage2.Controls.Add(this.gbCmdAntDetector);
            this.tabPage2.Controls.Add(this.gbCmdAntenna);
            this.tabPage2.Controls.Add(this.gbCmdRegion);
            this.tabPage2.Controls.Add(this.gbCmdOutputPower);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.label110);
            this.gbReturnLoss.Controls.Add(this.label109);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label108);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbReturnLoss, "gbReturnLoss");
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.TabStop = false;
            // 
            // label110
            // 
            resources.ApplyResources(this.label110, "label110");
            this.label110.Name = "label110";
            // 
            // label109
            // 
            resources.ApplyResources(this.label109, "label109");
            this.label109.Name = "label109";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Items.AddRange(new object[] {
            resources.GetString("cmbReturnLossFreq.Items"),
            resources.GetString("cmbReturnLossFreq.Items1"),
            resources.GetString("cmbReturnLossFreq.Items2"),
            resources.GetString("cmbReturnLossFreq.Items3"),
            resources.GetString("cmbReturnLossFreq.Items4"),
            resources.GetString("cmbReturnLossFreq.Items5"),
            resources.GetString("cmbReturnLossFreq.Items6"),
            resources.GetString("cmbReturnLossFreq.Items7"),
            resources.GetString("cmbReturnLossFreq.Items8"),
            resources.GetString("cmbReturnLossFreq.Items9"),
            resources.GetString("cmbReturnLossFreq.Items10"),
            resources.GetString("cmbReturnLossFreq.Items11"),
            resources.GetString("cmbReturnLossFreq.Items12"),
            resources.GetString("cmbReturnLossFreq.Items13"),
            resources.GetString("cmbReturnLossFreq.Items14"),
            resources.GetString("cmbReturnLossFreq.Items15"),
            resources.GetString("cmbReturnLossFreq.Items16"),
            resources.GetString("cmbReturnLossFreq.Items17"),
            resources.GetString("cmbReturnLossFreq.Items18"),
            resources.GetString("cmbReturnLossFreq.Items19"),
            resources.GetString("cmbReturnLossFreq.Items20"),
            resources.GetString("cmbReturnLossFreq.Items21"),
            resources.GetString("cmbReturnLossFreq.Items22"),
            resources.GetString("cmbReturnLossFreq.Items23"),
            resources.GetString("cmbReturnLossFreq.Items24"),
            resources.GetString("cmbReturnLossFreq.Items25"),
            resources.GetString("cmbReturnLossFreq.Items26"),
            resources.GetString("cmbReturnLossFreq.Items27"),
            resources.GetString("cmbReturnLossFreq.Items28"),
            resources.GetString("cmbReturnLossFreq.Items29"),
            resources.GetString("cmbReturnLossFreq.Items30"),
            resources.GetString("cmbReturnLossFreq.Items31"),
            resources.GetString("cmbReturnLossFreq.Items32"),
            resources.GetString("cmbReturnLossFreq.Items33"),
            resources.GetString("cmbReturnLossFreq.Items34"),
            resources.GetString("cmbReturnLossFreq.Items35"),
            resources.GetString("cmbReturnLossFreq.Items36"),
            resources.GetString("cmbReturnLossFreq.Items37"),
            resources.GetString("cmbReturnLossFreq.Items38"),
            resources.GetString("cmbReturnLossFreq.Items39"),
            resources.GetString("cmbReturnLossFreq.Items40"),
            resources.GetString("cmbReturnLossFreq.Items41"),
            resources.GetString("cmbReturnLossFreq.Items42"),
            resources.GetString("cmbReturnLossFreq.Items43"),
            resources.GetString("cmbReturnLossFreq.Items44"),
            resources.GetString("cmbReturnLossFreq.Items45"),
            resources.GetString("cmbReturnLossFreq.Items46"),
            resources.GetString("cmbReturnLossFreq.Items47"),
            resources.GetString("cmbReturnLossFreq.Items48"),
            resources.GetString("cmbReturnLossFreq.Items49"),
            resources.GetString("cmbReturnLossFreq.Items50"),
            resources.GetString("cmbReturnLossFreq.Items51"),
            resources.GetString("cmbReturnLossFreq.Items52"),
            resources.GetString("cmbReturnLossFreq.Items53"),
            resources.GetString("cmbReturnLossFreq.Items54"),
            resources.GetString("cmbReturnLossFreq.Items55"),
            resources.GetString("cmbReturnLossFreq.Items56"),
            resources.GetString("cmbReturnLossFreq.Items57"),
            resources.GetString("cmbReturnLossFreq.Items58"),
            resources.GetString("cmbReturnLossFreq.Items59")});
            resources.ApplyResources(this.cmbReturnLossFreq, "cmbReturnLossFreq");
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.Name = "label108";
            // 
            // textReturnLoss
            // 
            resources.ApplyResources(this.textReturnLoss, "textReturnLoss");
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            // 
            // btReturnLoss
            // 
            resources.ApplyResources(this.btReturnLoss, "btReturnLoss");
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btGetProfile);
            this.gbProfile.Controls.Add(this.btSetProfile);
            this.gbProfile.Controls.Add(this.rdbProfile3);
            this.gbProfile.Controls.Add(this.rdbProfile2);
            this.gbProfile.Controls.Add(this.rdbProfile1);
            this.gbProfile.Controls.Add(this.rdbProfile0);
            this.gbProfile.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbProfile, "gbProfile");
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.TabStop = false;
            // 
            // btGetProfile
            // 
            resources.ApplyResources(this.btGetProfile, "btGetProfile");
            this.btGetProfile.Name = "btGetProfile";
            this.btGetProfile.UseVisualStyleBackColor = true;
            this.btGetProfile.Click += new System.EventHandler(this.btGetProfile_Click);
            // 
            // btSetProfile
            // 
            resources.ApplyResources(this.btSetProfile, "btSetProfile");
            this.btSetProfile.Name = "btSetProfile";
            this.btSetProfile.UseVisualStyleBackColor = true;
            this.btSetProfile.Click += new System.EventHandler(this.btSetProfile_Click);
            // 
            // rdbProfile3
            // 
            resources.ApplyResources(this.rdbProfile3, "rdbProfile3");
            this.rdbProfile3.Name = "rdbProfile3";
            this.rdbProfile3.TabStop = true;
            this.rdbProfile3.UseVisualStyleBackColor = true;
            // 
            // rdbProfile2
            // 
            resources.ApplyResources(this.rdbProfile2, "rdbProfile2");
            this.rdbProfile2.Name = "rdbProfile2";
            this.rdbProfile2.TabStop = true;
            this.rdbProfile2.UseVisualStyleBackColor = true;
            // 
            // rdbProfile1
            // 
            resources.ApplyResources(this.rdbProfile1, "rdbProfile1");
            this.rdbProfile1.ForeColor = System.Drawing.Color.Black;
            this.rdbProfile1.Name = "rdbProfile1";
            this.rdbProfile1.TabStop = true;
            this.rdbProfile1.UseVisualStyleBackColor = true;
            // 
            // rdbProfile0
            // 
            resources.ApplyResources(this.rdbProfile0, "rdbProfile0");
            this.rdbProfile0.Name = "rdbProfile0";
            this.rdbProfile0.TabStop = true;
            this.rdbProfile0.UseVisualStyleBackColor = true;
            // 
            // btRfSetup
            // 
            resources.ApplyResources(this.btRfSetup, "btRfSetup");
            this.btRfSetup.Name = "btRfSetup";
            this.btRfSetup.UseVisualStyleBackColor = true;
            this.btRfSetup.Click += new System.EventHandler(this.btRfSetup_Click);
            // 
            // gbMonza
            // 
            this.gbMonza.Controls.Add(this.label14);
            this.gbMonza.Controls.Add(this.label11);
            this.gbMonza.Controls.Add(this.rdbMonzaOff);
            this.gbMonza.Controls.Add(this.btSetMonzaStatus);
            this.gbMonza.Controls.Add(this.btGetMonzaStatus);
            this.gbMonza.Controls.Add(this.rdbMonzaOn);
            this.gbMonza.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbMonza, "gbMonza");
            this.gbMonza.Name = "gbMonza";
            this.gbMonza.TabStop = false;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Name = "label14";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Name = "label11";
            // 
            // rdbMonzaOff
            // 
            resources.ApplyResources(this.rdbMonzaOff, "rdbMonzaOff");
            this.rdbMonzaOff.Name = "rdbMonzaOff";
            this.rdbMonzaOff.TabStop = true;
            this.rdbMonzaOff.UseVisualStyleBackColor = true;
            // 
            // btSetMonzaStatus
            // 
            resources.ApplyResources(this.btSetMonzaStatus, "btSetMonzaStatus");
            this.btSetMonzaStatus.Name = "btSetMonzaStatus";
            this.btSetMonzaStatus.UseVisualStyleBackColor = true;
            this.btSetMonzaStatus.Click += new System.EventHandler(this.btSetMonzaStatus_Click);
            // 
            // btGetMonzaStatus
            // 
            resources.ApplyResources(this.btGetMonzaStatus, "btGetMonzaStatus");
            this.btGetMonzaStatus.Name = "btGetMonzaStatus";
            this.btGetMonzaStatus.UseVisualStyleBackColor = true;
            this.btGetMonzaStatus.Click += new System.EventHandler(this.btGetMonzaStatus_Click);
            // 
            // rdbMonzaOn
            // 
            resources.ApplyResources(this.rdbMonzaOn, "rdbMonzaOn");
            this.rdbMonzaOn.Name = "rdbMonzaOn";
            this.rdbMonzaOn.TabStop = true;
            this.rdbMonzaOn.UseVisualStyleBackColor = true;
            // 
            // gbCmdAntDetector
            // 
            this.gbCmdAntDetector.Controls.Add(this.label7);
            this.gbCmdAntDetector.Controls.Add(this.label6);
            this.gbCmdAntDetector.Controls.Add(this.label5);
            this.gbCmdAntDetector.Controls.Add(this.label10);
            this.gbCmdAntDetector.Controls.Add(this.label8);
            this.gbCmdAntDetector.Controls.Add(this.tbAntDectector);
            this.gbCmdAntDetector.Controls.Add(this.btnGetAntDetector);
            this.gbCmdAntDetector.Controls.Add(this.btnSetAntDetector);
            this.gbCmdAntDetector.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdAntDetector, "gbCmdAntDetector");
            this.gbCmdAntDetector.Name = "gbCmdAntDetector";
            this.gbCmdAntDetector.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Name = "label5";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbAntDectector
            // 
            resources.ApplyResources(this.tbAntDectector, "tbAntDectector");
            this.tbAntDectector.Name = "tbAntDectector";
            // 
            // btnGetAntDetector
            // 
            resources.ApplyResources(this.btnGetAntDetector, "btnGetAntDetector");
            this.btnGetAntDetector.Name = "btnGetAntDetector";
            this.btnGetAntDetector.UseVisualStyleBackColor = true;
            this.btnGetAntDetector.Click += new System.EventHandler(this.btnGetAntDetector_Click);
            // 
            // btnSetAntDetector
            // 
            resources.ApplyResources(this.btnSetAntDetector, "btnSetAntDetector");
            this.btnSetAntDetector.Name = "btnSetAntDetector";
            this.btnSetAntDetector.UseVisualStyleBackColor = true;
            this.btnSetAntDetector.Click += new System.EventHandler(this.btnSetAntDetector_Click);
            // 
            // gbCmdAntenna
            // 
            this.gbCmdAntenna.Controls.Add(this.label107);
            this.gbCmdAntenna.Controls.Add(this.cmbWorkAnt);
            this.gbCmdAntenna.Controls.Add(this.btnGetWorkAntenna);
            this.gbCmdAntenna.Controls.Add(this.btnSetWorkAntenna);
            this.gbCmdAntenna.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdAntenna, "gbCmdAntenna");
            this.gbCmdAntenna.Name = "gbCmdAntenna";
            this.gbCmdAntenna.TabStop = false;
            // 
            // label107
            // 
            resources.ApplyResources(this.label107, "label107");
            this.label107.Name = "label107";
            // 
            // cmbWorkAnt
            // 
            this.cmbWorkAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkAnt.FormattingEnabled = true;
            this.cmbWorkAnt.Items.AddRange(new object[] {
            resources.GetString("cmbWorkAnt.Items"),
            resources.GetString("cmbWorkAnt.Items1"),
            resources.GetString("cmbWorkAnt.Items2"),
            resources.GetString("cmbWorkAnt.Items3")});
            resources.ApplyResources(this.cmbWorkAnt, "cmbWorkAnt");
            this.cmbWorkAnt.Name = "cmbWorkAnt";
            // 
            // btnGetWorkAntenna
            // 
            resources.ApplyResources(this.btnGetWorkAntenna, "btnGetWorkAntenna");
            this.btnGetWorkAntenna.Name = "btnGetWorkAntenna";
            this.btnGetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnGetWorkAntenna.Click += new System.EventHandler(this.btnGetWorkAntenna_Click);
            // 
            // btnSetWorkAntenna
            // 
            resources.ApplyResources(this.btnSetWorkAntenna, "btnSetWorkAntenna");
            this.btnSetWorkAntenna.Name = "btnSetWorkAntenna";
            this.btnSetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnSetWorkAntenna.Click += new System.EventHandler(this.btnSetWorkAntenna_Click);
            // 
            // gbCmdRegion
            // 
            this.gbCmdRegion.Controls.Add(this.cbUserDefineFreq);
            this.gbCmdRegion.Controls.Add(this.groupBox23);
            this.gbCmdRegion.Controls.Add(this.groupBox21);
            this.gbCmdRegion.Controls.Add(this.btnGetFrequencyRegion);
            this.gbCmdRegion.Controls.Add(this.btnSetFrequencyRegion);
            this.gbCmdRegion.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdRegion, "gbCmdRegion");
            this.gbCmdRegion.Name = "gbCmdRegion";
            this.gbCmdRegion.TabStop = false;
            // 
            // cbUserDefineFreq
            // 
            resources.ApplyResources(this.cbUserDefineFreq, "cbUserDefineFreq");
            this.cbUserDefineFreq.Name = "cbUserDefineFreq";
            this.cbUserDefineFreq.UseVisualStyleBackColor = true;
            this.cbUserDefineFreq.CheckedChanged += new System.EventHandler(this.cbUserDefineFreq_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label106);
            this.groupBox23.Controls.Add(this.label105);
            this.groupBox23.Controls.Add(this.label104);
            this.groupBox23.Controls.Add(this.label103);
            this.groupBox23.Controls.Add(this.label86);
            this.groupBox23.Controls.Add(this.label75);
            this.groupBox23.Controls.Add(this.textFreqQuantity);
            this.groupBox23.Controls.Add(this.TextFreqInterval);
            this.groupBox23.Controls.Add(this.textStartFreq);
            this.groupBox23.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox23, "groupBox23");
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.TabStop = false;
            // 
            // label106
            // 
            resources.ApplyResources(this.label106, "label106");
            this.label106.Name = "label106";
            // 
            // label105
            // 
            resources.ApplyResources(this.label105, "label105");
            this.label105.Name = "label105";
            // 
            // label104
            // 
            resources.ApplyResources(this.label104, "label104");
            this.label104.Name = "label104";
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.Name = "label103";
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.Name = "label86";
            // 
            // label75
            // 
            resources.ApplyResources(this.label75, "label75");
            this.label75.Name = "label75";
            // 
            // textFreqQuantity
            // 
            resources.ApplyResources(this.textFreqQuantity, "textFreqQuantity");
            this.textFreqQuantity.Name = "textFreqQuantity";
            // 
            // TextFreqInterval
            // 
            resources.ApplyResources(this.TextFreqInterval, "TextFreqInterval");
            this.TextFreqInterval.Name = "TextFreqInterval";
            // 
            // textStartFreq
            // 
            resources.ApplyResources(this.textStartFreq, "textStartFreq");
            this.textStartFreq.Name = "textStartFreq";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.label36);
            this.groupBox21.Controls.Add(this.cmbFrequencyEnd);
            this.groupBox21.Controls.Add(this.label13);
            this.groupBox21.Controls.Add(this.cmbFrequencyStart);
            this.groupBox21.Controls.Add(this.label12);
            this.groupBox21.Controls.Add(this.rdbRegionChn);
            this.groupBox21.Controls.Add(this.rdbRegionEtsi);
            this.groupBox21.Controls.Add(this.rdbRegionFcc);
            this.groupBox21.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox21, "groupBox21");
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.TabStop = false;
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // cmbFrequencyEnd
            // 
            this.cmbFrequencyEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyEnd.FormattingEnabled = true;
            resources.ApplyResources(this.cmbFrequencyEnd, "cmbFrequencyEnd");
            this.cmbFrequencyEnd.Name = "cmbFrequencyEnd";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // cmbFrequencyStart
            // 
            this.cmbFrequencyStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyStart.FormattingEnabled = true;
            resources.ApplyResources(this.cmbFrequencyStart, "cmbFrequencyStart");
            this.cmbFrequencyStart.Name = "cmbFrequencyStart";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // rdbRegionChn
            // 
            resources.ApplyResources(this.rdbRegionChn, "rdbRegionChn");
            this.rdbRegionChn.Name = "rdbRegionChn";
            this.rdbRegionChn.TabStop = true;
            this.rdbRegionChn.UseVisualStyleBackColor = true;
            this.rdbRegionChn.CheckedChanged += new System.EventHandler(this.rdbRegionChn_CheckedChanged);
            // 
            // rdbRegionEtsi
            // 
            resources.ApplyResources(this.rdbRegionEtsi, "rdbRegionEtsi");
            this.rdbRegionEtsi.Name = "rdbRegionEtsi";
            this.rdbRegionEtsi.TabStop = true;
            this.rdbRegionEtsi.UseVisualStyleBackColor = true;
            this.rdbRegionEtsi.CheckedChanged += new System.EventHandler(this.rdbRegionEtsi_CheckedChanged);
            // 
            // rdbRegionFcc
            // 
            resources.ApplyResources(this.rdbRegionFcc, "rdbRegionFcc");
            this.rdbRegionFcc.Name = "rdbRegionFcc";
            this.rdbRegionFcc.TabStop = true;
            this.rdbRegionFcc.UseVisualStyleBackColor = true;
            this.rdbRegionFcc.CheckedChanged += new System.EventHandler(this.rdbRegionFcc_CheckedChanged);
            // 
            // btnGetFrequencyRegion
            // 
            resources.ApplyResources(this.btnGetFrequencyRegion, "btnGetFrequencyRegion");
            this.btnGetFrequencyRegion.Name = "btnGetFrequencyRegion";
            this.btnGetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnGetFrequencyRegion.Click += new System.EventHandler(this.btnGetFrequencyRegion_Click);
            // 
            // btnSetFrequencyRegion
            // 
            resources.ApplyResources(this.btnSetFrequencyRegion, "btnSetFrequencyRegion");
            this.btnSetFrequencyRegion.Name = "btnSetFrequencyRegion";
            this.btnSetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnSetFrequencyRegion.Click += new System.EventHandler(this.btnSetFrequencyRegion_Click);
            // 
            // gbCmdOutputPower
            // 
            this.gbCmdOutputPower.Controls.Add(this.label115);
            this.gbCmdOutputPower.Controls.Add(this.label114);
            this.gbCmdOutputPower.Controls.Add(this.label113);
            this.gbCmdOutputPower.Controls.Add(this.label112);
            this.gbCmdOutputPower.Controls.Add(this.textBox10);
            this.gbCmdOutputPower.Controls.Add(this.textBox9);
            this.gbCmdOutputPower.Controls.Add(this.textBox8);
            this.gbCmdOutputPower.Controls.Add(this.textBox7);
            this.gbCmdOutputPower.Controls.Add(this.label34);
            this.gbCmdOutputPower.Controls.Add(this.label21);
            this.gbCmdOutputPower.Controls.Add(this.label20);
            this.gbCmdOutputPower.Controls.Add(this.label18);
            this.gbCmdOutputPower.Controls.Add(this.textBox4);
            this.gbCmdOutputPower.Controls.Add(this.textBox3);
            this.gbCmdOutputPower.Controls.Add(this.textBox2);
            this.gbCmdOutputPower.Controls.Add(this.textBox1);
            this.gbCmdOutputPower.Controls.Add(this.label15);
            this.gbCmdOutputPower.Controls.Add(this.btnGetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.btnSetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.label9);
            this.gbCmdOutputPower.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.gbCmdOutputPower, "gbCmdOutputPower");
            this.gbCmdOutputPower.Name = "gbCmdOutputPower";
            this.gbCmdOutputPower.TabStop = false;
            // 
            // label115
            // 
            resources.ApplyResources(this.label115, "label115");
            this.label115.Name = "label115";
            // 
            // label114
            // 
            resources.ApplyResources(this.label114, "label114");
            this.label114.Name = "label114";
            // 
            // label113
            // 
            resources.ApplyResources(this.label113, "label113");
            this.label113.Name = "label113";
            // 
            // label112
            // 
            resources.ApplyResources(this.label112, "label112");
            this.label112.Name = "label112";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // btnGetOutputPower
            // 
            resources.ApplyResources(this.btnGetOutputPower, "btnGetOutputPower");
            this.btnGetOutputPower.Name = "btnGetOutputPower";
            this.btnGetOutputPower.UseVisualStyleBackColor = true;
            this.btnGetOutputPower.Click += new System.EventHandler(this.btnGetOutputPower_Click);
            // 
            // btnSetOutputPower
            // 
            resources.ApplyResources(this.btnSetOutputPower, "btnSetOutputPower");
            this.btnSetOutputPower.Name = "btnSetOutputPower";
            this.btnSetOutputPower.UseVisualStyleBackColor = true;
            this.btnSetOutputPower.Click += new System.EventHandler(this.btnSetOutputPower_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // pageEpcTest
            // 
            this.pageEpcTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageEpcTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageEpcTest.Controls.Add(this.tabEpcTest);
            resources.ApplyResources(this.pageEpcTest, "pageEpcTest");
            this.pageEpcTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageEpcTest.Name = "pageEpcTest";
            // 
            // tabEpcTest
            // 
            this.tabEpcTest.Controls.Add(this.pageRealMode);
            this.tabEpcTest.Controls.Add(this.pageBufferedMode);
            this.tabEpcTest.Controls.Add(this.pageFast4AntMode);
            this.tabEpcTest.Controls.Add(this.pageAcessTag);
            this.tabEpcTest.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabEpcTest, "tabEpcTest");
            this.tabEpcTest.Name = "tabEpcTest";
            this.tabEpcTest.SelectedIndex = 0;
            this.tabEpcTest.TabStop = false;
            this.tabEpcTest.SelectedIndexChanged += new System.EventHandler(this.tabEpcTest_SelectedIndexChanged);
            // 
            // pageRealMode
            // 
            this.pageRealMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageRealMode.Controls.Add(this.tableLayoutPanel1);
            this.pageRealMode.Controls.Add(this.excel_format_rb);
            this.pageRealMode.Controls.Add(this.txt_format_rb);
            this.pageRealMode.Controls.Add(this.button8);
            this.pageRealMode.Controls.Add(this.groupBox20);
            this.pageRealMode.Controls.Add(this.tbRealMinRssi);
            this.pageRealMode.Controls.Add(this.tbRealMaxRssi);
            this.pageRealMode.Controls.Add(this.btRealFresh);
            this.pageRealMode.Controls.Add(this.label70);
            this.pageRealMode.Controls.Add(this.label74);
            this.pageRealMode.Controls.Add(this.lbRealTagCount);
            this.pageRealMode.Controls.Add(this.groupBox1);
            this.pageRealMode.Controls.Add(this.lvRealList);
            resources.ApplyResources(this.pageRealMode, "pageRealMode");
            this.pageRealMode.Name = "pageRealMode";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.customizedExeTime);
            this.panel5.Controls.Add(this.label127);
            this.panel5.Controls.Add(this.Duration);
            this.panel5.Controls.Add(this.mSessionExeTime);
            this.panel5.Controls.Add(this.btRealTimeInventory);
            this.panel5.Controls.Add(this.label84);
            this.panel5.Controls.Add(this.textRealRound);
            this.panel5.Controls.Add(this.sessionInventoryrb);
            this.panel5.Controls.Add(this.autoInventoryrb);
            this.panel5.Controls.Add(this.m_session_q_cb);
            this.panel5.Controls.Add(this.m_session_sl_cb);
            this.panel5.Controls.Add(this.m_session_max_q);
            this.panel5.Controls.Add(this.m_session_min_q);
            this.panel5.Controls.Add(this.m_session_start_q);
            this.panel5.Controls.Add(this.m_max_q_content);
            this.panel5.Controls.Add(this.m_min_q_content);
            this.panel5.Controls.Add(this.m_start_q_content);
            this.panel5.Controls.Add(this.m_session_sl);
            this.panel5.Controls.Add(this.m_sl_content);
            this.panel5.Controls.Add(this.cmbTarget);
            this.panel5.Controls.Add(this.label98);
            this.panel5.Controls.Add(this.cmbSession);
            this.panel5.Controls.Add(this.label97);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // customizedExeTime
            // 
            resources.ApplyResources(this.customizedExeTime, "customizedExeTime");
            this.customizedExeTime.Name = "customizedExeTime";
            // 
            // label127
            // 
            resources.ApplyResources(this.label127, "label127");
            this.label127.Name = "label127";
            // 
            // Duration
            // 
            resources.ApplyResources(this.Duration, "Duration");
            this.Duration.Name = "Duration";
            // 
            // mSessionExeTime
            // 
            this.mSessionExeTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mSessionExeTime, "mSessionExeTime");
            this.mSessionExeTime.FormattingEnabled = true;
            this.mSessionExeTime.Name = "mSessionExeTime";
            // 
            // btRealTimeInventory
            // 
            resources.ApplyResources(this.btRealTimeInventory, "btRealTimeInventory");
            this.btRealTimeInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btRealTimeInventory.Name = "btRealTimeInventory";
            this.btRealTimeInventory.UseVisualStyleBackColor = true;
            this.btRealTimeInventory.Click += new System.EventHandler(this.btRealTimeInventory_Click);
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.Name = "label84";
            // 
            // textRealRound
            // 
            resources.ApplyResources(this.textRealRound, "textRealRound");
            this.textRealRound.Name = "textRealRound";
            // 
            // sessionInventoryrb
            // 
            resources.ApplyResources(this.sessionInventoryrb, "sessionInventoryrb");
            this.sessionInventoryrb.Name = "sessionInventoryrb";
            this.sessionInventoryrb.TabStop = true;
            this.sessionInventoryrb.UseVisualStyleBackColor = true;
            this.sessionInventoryrb.CheckedChanged += new System.EventHandler(this.sessionInventoryrb_CheckedChanged);
            // 
            // autoInventoryrb
            // 
            resources.ApplyResources(this.autoInventoryrb, "autoInventoryrb");
            this.autoInventoryrb.Checked = true;
            this.autoInventoryrb.Name = "autoInventoryrb";
            this.autoInventoryrb.TabStop = true;
            this.autoInventoryrb.UseVisualStyleBackColor = true;
            this.autoInventoryrb.CheckedChanged += new System.EventHandler(this.autoInventoryrb_CheckedChanged);
            // 
            // m_session_q_cb
            // 
            resources.ApplyResources(this.m_session_q_cb, "m_session_q_cb");
            this.m_session_q_cb.Name = "m_session_q_cb";
            this.m_session_q_cb.UseVisualStyleBackColor = true;
            this.m_session_q_cb.CheckedChanged += new System.EventHandler(this.m_session_q_cb_CheckedChanged);
            // 
            // m_session_sl_cb
            // 
            resources.ApplyResources(this.m_session_sl_cb, "m_session_sl_cb");
            this.m_session_sl_cb.Name = "m_session_sl_cb";
            this.m_session_sl_cb.UseVisualStyleBackColor = true;
            this.m_session_sl_cb.CheckedChanged += new System.EventHandler(this.m_session_sl_cb_CheckedChanged);
            // 
            // m_session_max_q
            // 
            resources.ApplyResources(this.m_session_max_q, "m_session_max_q");
            this.m_session_max_q.Name = "m_session_max_q";
            // 
            // m_session_min_q
            // 
            resources.ApplyResources(this.m_session_min_q, "m_session_min_q");
            this.m_session_min_q.Name = "m_session_min_q";
            // 
            // m_session_start_q
            // 
            resources.ApplyResources(this.m_session_start_q, "m_session_start_q");
            this.m_session_start_q.Name = "m_session_start_q";
            // 
            // m_max_q_content
            // 
            resources.ApplyResources(this.m_max_q_content, "m_max_q_content");
            this.m_max_q_content.Name = "m_max_q_content";
            // 
            // m_min_q_content
            // 
            resources.ApplyResources(this.m_min_q_content, "m_min_q_content");
            this.m_min_q_content.Name = "m_min_q_content";
            // 
            // m_start_q_content
            // 
            resources.ApplyResources(this.m_start_q_content, "m_start_q_content");
            this.m_start_q_content.Name = "m_start_q_content";
            // 
            // m_session_sl
            // 
            this.m_session_sl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.m_session_sl, "m_session_sl");
            this.m_session_sl.FormattingEnabled = true;
            this.m_session_sl.Items.AddRange(new object[] {
            resources.GetString("m_session_sl.Items"),
            resources.GetString("m_session_sl.Items1"),
            resources.GetString("m_session_sl.Items2"),
            resources.GetString("m_session_sl.Items3")});
            this.m_session_sl.Name = "m_session_sl";
            // 
            // m_sl_content
            // 
            resources.ApplyResources(this.m_sl_content, "m_sl_content");
            this.m_sl_content.Name = "m_sl_content";
            this.m_sl_content.Click += new System.EventHandler(this.label125_Click);
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbTarget, "cmbTarget");
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Items.AddRange(new object[] {
            resources.GetString("cmbTarget.Items"),
            resources.GetString("cmbTarget.Items1")});
            this.cmbTarget.Name = "cmbTarget";
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.Name = "label98";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSession, "cmbSession");
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Items.AddRange(new object[] {
            resources.GetString("cmbSession.Items"),
            resources.GetString("cmbSession.Items1"),
            resources.GetString("cmbSession.Items2"),
            resources.GetString("cmbSession.Items3"),
            resources.GetString("cmbSession.Items4")});
            this.cmbSession.Name = "cmbSession";
            // 
            // label97
            // 
            resources.ApplyResources(this.label97, "label97");
            this.label97.Name = "label97";
            // 
            // excel_format_rb
            // 
            resources.ApplyResources(this.excel_format_rb, "excel_format_rb");
            this.excel_format_rb.Name = "excel_format_rb";
            this.excel_format_rb.UseVisualStyleBackColor = true;
            // 
            // txt_format_rb
            // 
            resources.ApplyResources(this.txt_format_rb, "txt_format_rb");
            this.txt_format_rb.Checked = true;
            this.txt_format_rb.Name = "txt_format_rb";
            this.txt_format_rb.TabStop = true;
            this.txt_format_rb.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.mTestTagCounts);
            this.groupBox20.Controls.Add(this.label129);
            this.groupBox20.Controls.Add(this.m_intervalTimetb);
            this.groupBox20.Controls.Add(this.label128);
            this.groupBox20.Controls.Add(this.mInventoryBStatusCount);
            this.groupBox20.Controls.Add(this.label126);
            this.groupBox20.Controls.Add(this.mInventoryAStatusCount);
            this.groupBox20.Controls.Add(this.label125);
            this.groupBox20.Controls.Add(this.ｍOneKeyInventory);
            this.groupBox20.Controls.Add(this.cbRealWorkant8);
            this.groupBox20.Controls.Add(this.cbRealWorkant7);
            this.groupBox20.Controls.Add(this.cbRealWorkant6);
            this.groupBox20.Controls.Add(this.cbRealWorkant5);
            this.groupBox20.Controls.Add(this.cbRealWorkant1);
            this.groupBox20.Controls.Add(this.cbRealWorkant4);
            this.groupBox20.Controls.Add(this.cbRealWorkant3);
            this.groupBox20.Controls.Add(this.cbRealWorkant2);
            this.groupBox20.Controls.Add(this.label19);
            resources.ApplyResources(this.groupBox20, "groupBox20");
            this.groupBox20.ForeColor = System.Drawing.Color.Black;
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.TabStop = false;
            // 
            // mTestTagCounts
            // 
            resources.ApplyResources(this.mTestTagCounts, "mTestTagCounts");
            this.mTestTagCounts.Name = "mTestTagCounts";
            // 
            // label129
            // 
            resources.ApplyResources(this.label129, "label129");
            this.label129.Name = "label129";
            // 
            // m_intervalTimetb
            // 
            resources.ApplyResources(this.m_intervalTimetb, "m_intervalTimetb");
            this.m_intervalTimetb.Name = "m_intervalTimetb";
            // 
            // label128
            // 
            resources.ApplyResources(this.label128, "label128");
            this.label128.Name = "label128";
            // 
            // mInventoryBStatusCount
            // 
            resources.ApplyResources(this.mInventoryBStatusCount, "mInventoryBStatusCount");
            this.mInventoryBStatusCount.Name = "mInventoryBStatusCount";
            // 
            // label126
            // 
            resources.ApplyResources(this.label126, "label126");
            this.label126.Name = "label126";
            // 
            // mInventoryAStatusCount
            // 
            resources.ApplyResources(this.mInventoryAStatusCount, "mInventoryAStatusCount");
            this.mInventoryAStatusCount.Name = "mInventoryAStatusCount";
            // 
            // label125
            // 
            resources.ApplyResources(this.label125, "label125");
            this.label125.Name = "label125";
            // 
            // ｍOneKeyInventory
            // 
            resources.ApplyResources(this.ｍOneKeyInventory, "ｍOneKeyInventory");
            this.ｍOneKeyInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.ｍOneKeyInventory.Name = "ｍOneKeyInventory";
            this.ｍOneKeyInventory.UseVisualStyleBackColor = true;
            this.ｍOneKeyInventory.Click += new System.EventHandler(this.ｍOneKeyInventory_Click);
            // 
            // cbRealWorkant8
            // 
            resources.ApplyResources(this.cbRealWorkant8, "cbRealWorkant8");
            this.cbRealWorkant8.Name = "cbRealWorkant8";
            this.cbRealWorkant8.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant7
            // 
            resources.ApplyResources(this.cbRealWorkant7, "cbRealWorkant7");
            this.cbRealWorkant7.Name = "cbRealWorkant7";
            this.cbRealWorkant7.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant6
            // 
            resources.ApplyResources(this.cbRealWorkant6, "cbRealWorkant6");
            this.cbRealWorkant6.Name = "cbRealWorkant6";
            this.cbRealWorkant6.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant5
            // 
            resources.ApplyResources(this.cbRealWorkant5, "cbRealWorkant5");
            this.cbRealWorkant5.Name = "cbRealWorkant5";
            this.cbRealWorkant5.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant1
            // 
            resources.ApplyResources(this.cbRealWorkant1, "cbRealWorkant1");
            this.cbRealWorkant1.Checked = true;
            this.cbRealWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRealWorkant1.Name = "cbRealWorkant1";
            this.cbRealWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant4
            // 
            resources.ApplyResources(this.cbRealWorkant4, "cbRealWorkant4");
            this.cbRealWorkant4.Name = "cbRealWorkant4";
            this.cbRealWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant3
            // 
            resources.ApplyResources(this.cbRealWorkant3, "cbRealWorkant3");
            this.cbRealWorkant3.Name = "cbRealWorkant3";
            this.cbRealWorkant3.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant2
            // 
            resources.ApplyResources(this.cbRealWorkant2, "cbRealWorkant2");
            this.cbRealWorkant2.Name = "cbRealWorkant2";
            this.cbRealWorkant2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // tbRealMinRssi
            // 
            resources.ApplyResources(this.tbRealMinRssi, "tbRealMinRssi");
            this.tbRealMinRssi.Name = "tbRealMinRssi";
            this.tbRealMinRssi.ReadOnly = true;
            // 
            // tbRealMaxRssi
            // 
            resources.ApplyResources(this.tbRealMaxRssi, "tbRealMaxRssi");
            this.tbRealMaxRssi.Name = "tbRealMaxRssi";
            this.tbRealMaxRssi.ReadOnly = true;
            // 
            // btRealFresh
            // 
            resources.ApplyResources(this.btRealFresh, "btRealFresh");
            this.btRealFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btRealFresh.Name = "btRealFresh";
            this.btRealFresh.UseVisualStyleBackColor = true;
            this.btRealFresh.Click += new System.EventHandler(this.btRealFresh_Click);
            // 
            // label70
            // 
            resources.ApplyResources(this.label70, "label70");
            this.label70.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label70.Name = "label70";
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label74.Name = "label74";
            // 
            // lbRealTagCount
            // 
            resources.ApplyResources(this.lbRealTagCount, "lbRealTagCount");
            this.lbRealTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbRealTagCount.Name = "lbRealTagCount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledReal3);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.ledReal5);
            this.groupBox1.Controls.Add(this.ledReal2);
            this.groupBox1.Controls.Add(this.ledReal4);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.ledReal1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ledReal3
            // 
            this.ledReal3.BackColor = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal3.BevelRate = 0.1F;
            this.ledReal3.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal3.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledReal3, "ledReal3");
            this.ledReal3.Name = "ledReal3";
            this.ledReal3.RoundCorner = true;
            this.ledReal3.SegmentIntervalRatio = 50;
            this.ledReal3.ShowHighlight = true;
            this.ledReal3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal3.TotalCharCount = 10;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            resources.GetString("comboBox6.Items"),
            resources.GetString("comboBox6.Items1"),
            resources.GetString("comboBox6.Items2"),
            resources.GetString("comboBox6.Items3"),
            resources.GetString("comboBox6.Items4")});
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.Name = "comboBox6";
            // 
            // ledReal5
            // 
            this.ledReal5.BackColor = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal5.BevelRate = 0.1F;
            this.ledReal5.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal5.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledReal5, "ledReal5");
            this.ledReal5.Name = "ledReal5";
            this.ledReal5.RoundCorner = true;
            this.ledReal5.SegmentIntervalRatio = 50;
            this.ledReal5.ShowHighlight = true;
            this.ledReal5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal5.TotalCharCount = 10;
            // 
            // ledReal2
            // 
            this.ledReal2.BackColor = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal2.BevelRate = 0.1F;
            this.ledReal2.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal2.ForeColor = System.Drawing.Color.Purple;
            this.ledReal2.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledReal2, "ledReal2");
            this.ledReal2.Name = "ledReal2";
            this.ledReal2.RoundCorner = true;
            this.ledReal2.SegmentIntervalRatio = 50;
            this.ledReal2.ShowHighlight = true;
            this.ledReal2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal2.TotalCharCount = 6;
            // 
            // ledReal4
            // 
            this.ledReal4.BackColor = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal4.BevelRate = 0.1F;
            this.ledReal4.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal4.ForeColor = System.Drawing.Color.Purple;
            this.ledReal4.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledReal4, "ledReal4");
            this.ledReal4.Name = "ledReal4";
            this.ledReal4.RoundCorner = true;
            this.ledReal4.SegmentIntervalRatio = 50;
            this.ledReal4.ShowHighlight = true;
            this.ledReal4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal4.TotalCharCount = 6;
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label53.Name = "label53";
            // 
            // label66
            // 
            resources.ApplyResources(this.label66, "label66");
            this.label66.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label66.Name = "label66";
            // 
            // label67
            // 
            resources.ApplyResources(this.label67, "label67");
            this.label67.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label67.Name = "label67";
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label68.Name = "label68";
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label69.Name = "label69";
            // 
            // ledReal1
            // 
            this.ledReal1.BackColor = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal1.BevelRate = 0.1F;
            this.ledReal1.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal1.BorderWidth = 3;
            this.ledReal1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal1.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledReal1, "ledReal1");
            this.ledReal1.Name = "ledReal1";
            this.ledReal1.RoundCorner = true;
            this.ledReal1.SegmentIntervalRatio = 50;
            this.ledReal1.ShowHighlight = true;
            this.ledReal1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lvRealList
            // 
            this.lvRealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42});
            resources.ApplyResources(this.lvRealList, "lvRealList");
            this.lvRealList.GridLines = true;
            this.lvRealList.Name = "lvRealList";
            this.lvRealList.UseCompatibleStateImageBehavior = false;
            this.lvRealList.View = System.Windows.Forms.View.Details;
            this.lvRealList.SelectedIndexChanged += new System.EventHandler(this.lvRealList_SelectedIndexChanged);
            // 
            // columnHeader37
            // 
            resources.ApplyResources(this.columnHeader37, "columnHeader37");
            // 
            // columnHeader38
            // 
            resources.ApplyResources(this.columnHeader38, "columnHeader38");
            // 
            // columnHeader39
            // 
            resources.ApplyResources(this.columnHeader39, "columnHeader39");
            // 
            // columnHeader40
            // 
            resources.ApplyResources(this.columnHeader40, "columnHeader40");
            // 
            // columnHeader41
            // 
            resources.ApplyResources(this.columnHeader41, "columnHeader41");
            // 
            // columnHeader42
            // 
            resources.ApplyResources(this.columnHeader42, "columnHeader42");
            // 
            // pageBufferedMode
            // 
            this.pageBufferedMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageBufferedMode.Controls.Add(this.excel_format_buffer_rb);
            this.pageBufferedMode.Controls.Add(this.txt_format_buffer_rb);
            this.pageBufferedMode.Controls.Add(this.button6);
            this.pageBufferedMode.Controls.Add(this.tableLayoutPanel4);
            this.pageBufferedMode.Controls.Add(this.groupBox3);
            this.pageBufferedMode.Controls.Add(this.btBufferFresh);
            this.pageBufferedMode.Controls.Add(this.labelBufferTagCount);
            this.pageBufferedMode.Controls.Add(this.lvBufferList);
            this.pageBufferedMode.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.pageBufferedMode, "pageBufferedMode");
            this.pageBufferedMode.Name = "pageBufferedMode";
            // 
            // excel_format_buffer_rb
            // 
            resources.ApplyResources(this.excel_format_buffer_rb, "excel_format_buffer_rb");
            this.excel_format_buffer_rb.Name = "excel_format_buffer_rb";
            this.excel_format_buffer_rb.UseVisualStyleBackColor = true;
            // 
            // txt_format_buffer_rb
            // 
            resources.ApplyResources(this.txt_format_buffer_rb, "txt_format_buffer_rb");
            this.txt_format_buffer_rb.Checked = true;
            this.txt_format_buffer_rb.Name = "txt_format_buffer_rb";
            this.txt_format_buffer_rb.TabStop = true;
            this.txt_format_buffer_rb.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btClearBuffer);
            this.panel9.Controls.Add(this.btQueryBuffer);
            this.panel9.Controls.Add(this.btGetClearBuffer);
            this.panel9.Controls.Add(this.btGetBuffer);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // btClearBuffer
            // 
            resources.ApplyResources(this.btClearBuffer, "btClearBuffer");
            this.btClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClearBuffer.Name = "btClearBuffer";
            this.btClearBuffer.UseVisualStyleBackColor = true;
            this.btClearBuffer.Click += new System.EventHandler(this.btClearBuffer_Click);
            // 
            // btQueryBuffer
            // 
            resources.ApplyResources(this.btQueryBuffer, "btQueryBuffer");
            this.btQueryBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQueryBuffer.Name = "btQueryBuffer";
            this.btQueryBuffer.UseVisualStyleBackColor = true;
            this.btQueryBuffer.Click += new System.EventHandler(this.btQueryBuffer_Click);
            // 
            // btGetClearBuffer
            // 
            resources.ApplyResources(this.btGetClearBuffer, "btGetClearBuffer");
            this.btGetClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetClearBuffer.Name = "btGetClearBuffer";
            this.btGetClearBuffer.UseVisualStyleBackColor = true;
            this.btGetClearBuffer.Click += new System.EventHandler(this.btGetClearBuffer_Click);
            // 
            // btGetBuffer
            // 
            resources.ApplyResources(this.btGetBuffer, "btGetBuffer");
            this.btGetBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetBuffer.Name = "btGetBuffer";
            this.btGetBuffer.UseVisualStyleBackColor = true;
            this.btGetBuffer.Click += new System.EventHandler(this.btGetBuffer_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btBufferInventory);
            this.panel10.Controls.Add(this.label85);
            this.panel10.Controls.Add(this.textReadRoundBuffer);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // btBufferInventory
            // 
            resources.ApplyResources(this.btBufferInventory, "btBufferInventory");
            this.btBufferInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btBufferInventory.Name = "btBufferInventory";
            this.btBufferInventory.UseVisualStyleBackColor = true;
            this.btBufferInventory.Click += new System.EventHandler(this.btBufferInventory_Click);
            // 
            // label85
            // 
            resources.ApplyResources(this.label85, "label85");
            this.label85.Name = "label85";
            // 
            // textReadRoundBuffer
            // 
            resources.ApplyResources(this.textReadRoundBuffer, "textReadRoundBuffer");
            this.textReadRoundBuffer.Name = "textReadRoundBuffer";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBox4);
            this.panel8.Controls.Add(this.checkBox3);
            this.panel8.Controls.Add(this.checkBox2);
            this.panel8.Controls.Add(this.checkBox1);
            this.panel8.Controls.Add(this.cbBufferWorkant1);
            this.panel8.Controls.Add(this.cbBufferWorkant4);
            this.panel8.Controls.Add(this.cbBufferWorkant2);
            this.panel8.Controls.Add(this.cbBufferWorkant3);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant1
            // 
            resources.ApplyResources(this.cbBufferWorkant1, "cbBufferWorkant1");
            this.cbBufferWorkant1.Checked = true;
            this.cbBufferWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBufferWorkant1.Name = "cbBufferWorkant1";
            this.cbBufferWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant4
            // 
            resources.ApplyResources(this.cbBufferWorkant4, "cbBufferWorkant4");
            this.cbBufferWorkant4.Name = "cbBufferWorkant4";
            this.cbBufferWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant2
            // 
            resources.ApplyResources(this.cbBufferWorkant2, "cbBufferWorkant2");
            this.cbBufferWorkant2.Name = "cbBufferWorkant2";
            this.cbBufferWorkant2.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant3
            // 
            resources.ApplyResources(this.cbBufferWorkant3, "cbBufferWorkant3");
            this.cbBufferWorkant3.Name = "cbBufferWorkant3";
            this.cbBufferWorkant3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ledBuffer4);
            this.groupBox3.Controls.Add(this.comboBox11);
            this.groupBox3.Controls.Add(this.ledBuffer5);
            this.groupBox3.Controls.Add(this.ledBuffer2);
            this.groupBox3.Controls.Add(this.ledBuffer3);
            this.groupBox3.Controls.Add(this.label92);
            this.groupBox3.Controls.Add(this.label93);
            this.groupBox3.Controls.Add(this.label94);
            this.groupBox3.Controls.Add(this.label95);
            this.groupBox3.Controls.Add(this.label96);
            this.groupBox3.Controls.Add(this.ledBuffer1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // ledBuffer4
            // 
            this.ledBuffer4.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer4.BevelRate = 0.1F;
            this.ledBuffer4.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer4.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledBuffer4, "ledBuffer4");
            this.ledBuffer4.Name = "ledBuffer4";
            this.ledBuffer4.RoundCorner = true;
            this.ledBuffer4.SegmentIntervalRatio = 50;
            this.ledBuffer4.ShowHighlight = true;
            this.ledBuffer4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer4.TotalCharCount = 10;
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            resources.GetString("comboBox11.Items"),
            resources.GetString("comboBox11.Items1"),
            resources.GetString("comboBox11.Items2"),
            resources.GetString("comboBox11.Items3"),
            resources.GetString("comboBox11.Items4")});
            resources.ApplyResources(this.comboBox11, "comboBox11");
            this.comboBox11.Name = "comboBox11";
            // 
            // ledBuffer5
            // 
            this.ledBuffer5.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer5.BevelRate = 0.1F;
            this.ledBuffer5.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer5.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledBuffer5, "ledBuffer5");
            this.ledBuffer5.Name = "ledBuffer5";
            this.ledBuffer5.RoundCorner = true;
            this.ledBuffer5.SegmentIntervalRatio = 50;
            this.ledBuffer5.ShowHighlight = true;
            this.ledBuffer5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer5.TotalCharCount = 10;
            // 
            // ledBuffer2
            // 
            this.ledBuffer2.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer2.BevelRate = 0.1F;
            this.ledBuffer2.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer2.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer2.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledBuffer2, "ledBuffer2");
            this.ledBuffer2.Name = "ledBuffer2";
            this.ledBuffer2.RoundCorner = true;
            this.ledBuffer2.SegmentIntervalRatio = 50;
            this.ledBuffer2.ShowHighlight = true;
            this.ledBuffer2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer2.TotalCharCount = 6;
            // 
            // ledBuffer3
            // 
            this.ledBuffer3.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer3.BevelRate = 0.1F;
            this.ledBuffer3.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer3.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer3.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledBuffer3, "ledBuffer3");
            this.ledBuffer3.Name = "ledBuffer3";
            this.ledBuffer3.RoundCorner = true;
            this.ledBuffer3.SegmentIntervalRatio = 50;
            this.ledBuffer3.ShowHighlight = true;
            this.ledBuffer3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer3.TotalCharCount = 6;
            // 
            // label92
            // 
            resources.ApplyResources(this.label92, "label92");
            this.label92.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label92.Name = "label92";
            // 
            // label93
            // 
            resources.ApplyResources(this.label93, "label93");
            this.label93.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label93.Name = "label93";
            // 
            // label94
            // 
            resources.ApplyResources(this.label94, "label94");
            this.label94.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label94.Name = "label94";
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label95.Name = "label95";
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label96.Name = "label96";
            // 
            // ledBuffer1
            // 
            this.ledBuffer1.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer1.BevelRate = 0.1F;
            this.ledBuffer1.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer1.BorderWidth = 3;
            this.ledBuffer1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer1.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledBuffer1, "ledBuffer1");
            this.ledBuffer1.Name = "ledBuffer1";
            this.ledBuffer1.RoundCorner = true;
            this.ledBuffer1.SegmentIntervalRatio = 50;
            this.ledBuffer1.ShowHighlight = true;
            this.ledBuffer1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // btBufferFresh
            // 
            resources.ApplyResources(this.btBufferFresh, "btBufferFresh");
            this.btBufferFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBufferFresh.Name = "btBufferFresh";
            this.btBufferFresh.UseVisualStyleBackColor = true;
            this.btBufferFresh.Click += new System.EventHandler(this.btBufferFresh_Click);
            // 
            // labelBufferTagCount
            // 
            resources.ApplyResources(this.labelBufferTagCount, "labelBufferTagCount");
            this.labelBufferTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelBufferTagCount.Name = "labelBufferTagCount";
            // 
            // lvBufferList
            // 
            this.lvBufferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader16});
            resources.ApplyResources(this.lvBufferList, "lvBufferList");
            this.lvBufferList.GridLines = true;
            this.lvBufferList.Name = "lvBufferList";
            this.lvBufferList.UseCompatibleStateImageBehavior = false;
            this.lvBufferList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader49
            // 
            resources.ApplyResources(this.columnHeader49, "columnHeader49");
            // 
            // columnHeader50
            // 
            resources.ApplyResources(this.columnHeader50, "columnHeader50");
            // 
            // columnHeader51
            // 
            resources.ApplyResources(this.columnHeader51, "columnHeader51");
            // 
            // columnHeader52
            // 
            resources.ApplyResources(this.columnHeader52, "columnHeader52");
            // 
            // columnHeader53
            // 
            resources.ApplyResources(this.columnHeader53, "columnHeader53");
            // 
            // columnHeader54
            // 
            resources.ApplyResources(this.columnHeader54, "columnHeader54");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // pageFast4AntMode
            // 
            this.pageFast4AntMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageFast4AntMode.Controls.Add(this.groupBox25);
            this.pageFast4AntMode.Controls.Add(this.txt_format_fast_rb);
            this.pageFast4AntMode.Controls.Add(this.excel_format_fast_rb);
            this.pageFast4AntMode.Controls.Add(this.button7);
            this.pageFast4AntMode.Controls.Add(this.groupBox2);
            this.pageFast4AntMode.Controls.Add(this.txtFastMaxRssi);
            this.pageFast4AntMode.Controls.Add(this.txtFastMinRssi);
            this.pageFast4AntMode.Controls.Add(this.buttonFastFresh);
            this.pageFast4AntMode.Controls.Add(this.label22);
            this.pageFast4AntMode.Controls.Add(this.lvFastList);
            this.pageFast4AntMode.Controls.Add(this.label49);
            this.pageFast4AntMode.Controls.Add(this.txtFastTagList);
            this.pageFast4AntMode.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.pageFast4AntMode, "pageFast4AntMode");
            this.pageFast4AntMode.Name = "pageFast4AntMode";
            this.pageFast4AntMode.Enter += new System.EventHandler(this.pageFast4AntMode_Enter);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.ledFast1);
            this.groupBox25.Controls.Add(this.label58);
            this.groupBox25.Controls.Add(this.ledFast4);
            this.groupBox25.Controls.Add(this.ledFast2);
            this.groupBox25.Controls.Add(this.label55);
            this.groupBox25.Controls.Add(this.label56);
            this.groupBox25.Controls.Add(this.ledFast3);
            this.groupBox25.Controls.Add(this.label57);
            this.groupBox25.Controls.Add(this.label54);
            this.groupBox25.Controls.Add(this.ledFast5);
            resources.ApplyResources(this.groupBox25, "groupBox25");
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.TabStop = false;
            // 
            // ledFast1
            // 
            this.ledFast1.BackColor = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast1.BevelRate = 0.1F;
            this.ledFast1.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast1.BorderWidth = 3;
            this.ledFast1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast1.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledFast1, "ledFast1");
            this.ledFast1.Name = "ledFast1";
            this.ledFast1.RoundCorner = true;
            this.ledFast1.SegmentIntervalRatio = 50;
            this.ledFast1.ShowHighlight = true;
            this.ledFast1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label58.Name = "label58";
            // 
            // ledFast4
            // 
            this.ledFast4.BackColor = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast4.BevelRate = 0.1F;
            this.ledFast4.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast4.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledFast4, "ledFast4");
            this.ledFast4.Name = "ledFast4";
            this.ledFast4.RoundCorner = true;
            this.ledFast4.SegmentIntervalRatio = 50;
            this.ledFast4.ShowHighlight = true;
            this.ledFast4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast4.TotalCharCount = 10;
            // 
            // ledFast2
            // 
            this.ledFast2.BackColor = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast2.BevelRate = 0.1F;
            this.ledFast2.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast2.ForeColor = System.Drawing.Color.Purple;
            this.ledFast2.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledFast2, "ledFast2");
            this.ledFast2.Name = "ledFast2";
            this.ledFast2.RoundCorner = true;
            this.ledFast2.SegmentIntervalRatio = 50;
            this.ledFast2.ShowHighlight = true;
            this.ledFast2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast2.TotalCharCount = 6;
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label55.Name = "label55";
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label56.Name = "label56";
            // 
            // ledFast3
            // 
            this.ledFast3.BackColor = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast3.BevelRate = 0.1F;
            this.ledFast3.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast3.ForeColor = System.Drawing.Color.Purple;
            this.ledFast3.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledFast3, "ledFast3");
            this.ledFast3.Name = "ledFast3";
            this.ledFast3.RoundCorner = true;
            this.ledFast3.SegmentIntervalRatio = 50;
            this.ledFast3.ShowHighlight = true;
            this.ledFast3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast3.TotalCharCount = 6;
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label57.Name = "label57";
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label54.Name = "label54";
            // 
            // ledFast5
            // 
            this.ledFast5.BackColor = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast5.BevelRate = 0.1F;
            this.ledFast5.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast5.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.ledFast5, "ledFast5");
            this.ledFast5.Name = "ledFast5";
            this.ledFast5.RoundCorner = true;
            this.ledFast5.SegmentIntervalRatio = 50;
            this.ledFast5.ShowHighlight = true;
            this.ledFast5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast5.TotalCharCount = 10;
            // 
            // txt_format_fast_rb
            // 
            resources.ApplyResources(this.txt_format_fast_rb, "txt_format_fast_rb");
            this.txt_format_fast_rb.Checked = true;
            this.txt_format_fast_rb.Name = "txt_format_fast_rb";
            this.txt_format_fast_rb.TabStop = true;
            this.txt_format_fast_rb.UseVisualStyleBackColor = true;
            // 
            // excel_format_fast_rb
            // 
            resources.ApplyResources(this.excel_format_fast_rb, "excel_format_fast_rb");
            this.excel_format_fast_rb.Name = "excel_format_fast_rb";
            this.excel_format_fast_rb.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox28);
            this.groupBox2.Controls.Add(this.groupBox27);
            this.groupBox2.Controls.Add(this.groupBox26);
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Controls.Add(this.comboBox7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.m_new_fast_inventory_power2);
            this.groupBox28.Controls.Add(this.m_new_fast_inventory_power1);
            this.groupBox28.Controls.Add(this.m_new_fast_inventory_repeat2);
            this.groupBox28.Controls.Add(this.m_new_fast_inventory_repeat1);
            this.groupBox28.Controls.Add(this.mRepeatPower1);
            this.groupBox28.Controls.Add(this.mRepeatPower2);
            this.groupBox28.Controls.Add(this.mRepeat2);
            this.groupBox28.Controls.Add(this.mRepeat1);
            this.groupBox28.Controls.Add(this.mDynamicPoll);
            this.groupBox28.Controls.Add(this.label132);
            this.groupBox28.Controls.Add(this.mFastExeCount);
            this.groupBox28.Controls.Add(this.label131);
            this.groupBox28.Controls.Add(this.mFastIntervalTime);
            resources.ApplyResources(this.groupBox28, "groupBox28");
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.TabStop = false;
            // 
            // m_new_fast_inventory_power2
            // 
            resources.ApplyResources(this.m_new_fast_inventory_power2, "m_new_fast_inventory_power2");
            this.m_new_fast_inventory_power2.Name = "m_new_fast_inventory_power2";
            // 
            // m_new_fast_inventory_power1
            // 
            resources.ApplyResources(this.m_new_fast_inventory_power1, "m_new_fast_inventory_power1");
            this.m_new_fast_inventory_power1.Name = "m_new_fast_inventory_power1";
            // 
            // m_new_fast_inventory_repeat2
            // 
            resources.ApplyResources(this.m_new_fast_inventory_repeat2, "m_new_fast_inventory_repeat2");
            this.m_new_fast_inventory_repeat2.Name = "m_new_fast_inventory_repeat2";
            // 
            // m_new_fast_inventory_repeat1
            // 
            resources.ApplyResources(this.m_new_fast_inventory_repeat1, "m_new_fast_inventory_repeat1");
            this.m_new_fast_inventory_repeat1.Name = "m_new_fast_inventory_repeat1";
            // 
            // mRepeatPower1
            // 
            resources.ApplyResources(this.mRepeatPower1, "mRepeatPower1");
            this.mRepeatPower1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mRepeatPower1.Name = "mRepeatPower1";
            // 
            // mRepeatPower2
            // 
            resources.ApplyResources(this.mRepeatPower2, "mRepeatPower2");
            this.mRepeatPower2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mRepeatPower2.Name = "mRepeatPower2";
            // 
            // mRepeat2
            // 
            resources.ApplyResources(this.mRepeat2, "mRepeat2");
            this.mRepeat2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mRepeat2.Name = "mRepeat2";
            // 
            // mRepeat1
            // 
            resources.ApplyResources(this.mRepeat1, "mRepeat1");
            this.mRepeat1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mRepeat1.Name = "mRepeat1";
            // 
            // mDynamicPoll
            // 
            resources.ApplyResources(this.mDynamicPoll, "mDynamicPoll");
            this.mDynamicPoll.Name = "mDynamicPoll";
            this.mDynamicPoll.UseVisualStyleBackColor = true;
            this.mDynamicPoll.CheckedChanged += new System.EventHandler(this.mDynamicPoll_CheckedChanged);
            // 
            // label132
            // 
            resources.ApplyResources(this.label132, "label132");
            this.label132.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label132.Name = "label132";
            // 
            // mFastExeCount
            // 
            resources.ApplyResources(this.mFastExeCount, "mFastExeCount");
            this.mFastExeCount.Name = "mFastExeCount";
            // 
            // label131
            // 
            resources.ApplyResources(this.label131, "label131");
            this.label131.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label131.Name = "label131";
            // 
            // mFastIntervalTime
            // 
            resources.ApplyResources(this.mFastIntervalTime, "mFastIntervalTime");
            this.mFastIntervalTime.Name = "mFastIntervalTime";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.m_new_fast_inventory_target_count);
            this.groupBox27.Controls.Add(this.mTargetQuantity);
            this.groupBox27.Controls.Add(this.m_new_fast_inventory_continue);
            this.groupBox27.Controls.Add(this.mContiue);
            this.groupBox27.Controls.Add(this.m_new_fast_inventory_optimized);
            this.groupBox27.Controls.Add(this.mOpitimized);
            this.groupBox27.Controls.Add(this.m_phase_value);
            this.groupBox27.Controls.Add(this.m_new_fast_inventory_flag);
            this.groupBox27.Controls.Add(this.m_new_fast_inventory_session);
            this.groupBox27.Controls.Add(this.m_new_fast_inventory);
            this.groupBox27.Controls.Add(this.label73);
            this.groupBox27.Controls.Add(this.txtInterval);
            this.groupBox27.Controls.Add(this.label72);
            this.groupBox27.Controls.Add(this.mReserve);
            this.groupBox27.Controls.Add(this.txtRepeat);
            this.groupBox27.Controls.Add(this.mPower1);
            this.groupBox27.Controls.Add(this.mPower2);
            this.groupBox27.Controls.Add(this.mPower5);
            this.groupBox27.Controls.Add(this.mPower4);
            this.groupBox27.Controls.Add(this.mPower3);
            resources.ApplyResources(this.groupBox27, "groupBox27");
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.TabStop = false;
            // 
            // m_new_fast_inventory_target_count
            // 
            resources.ApplyResources(this.m_new_fast_inventory_target_count, "m_new_fast_inventory_target_count");
            this.m_new_fast_inventory_target_count.Name = "m_new_fast_inventory_target_count";
            // 
            // mTargetQuantity
            // 
            resources.ApplyResources(this.mTargetQuantity, "mTargetQuantity");
            this.mTargetQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mTargetQuantity.Name = "mTargetQuantity";
            // 
            // m_new_fast_inventory_continue
            // 
            resources.ApplyResources(this.m_new_fast_inventory_continue, "m_new_fast_inventory_continue");
            this.m_new_fast_inventory_continue.Name = "m_new_fast_inventory_continue";
            // 
            // mContiue
            // 
            resources.ApplyResources(this.mContiue, "mContiue");
            this.mContiue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mContiue.Name = "mContiue";
            // 
            // m_new_fast_inventory_optimized
            // 
            resources.ApplyResources(this.m_new_fast_inventory_optimized, "m_new_fast_inventory_optimized");
            this.m_new_fast_inventory_optimized.Name = "m_new_fast_inventory_optimized";
            // 
            // mOpitimized
            // 
            resources.ApplyResources(this.mOpitimized, "mOpitimized");
            this.mOpitimized.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mOpitimized.Name = "mOpitimized";
            // 
            // m_phase_value
            // 
            resources.ApplyResources(this.m_phase_value, "m_phase_value");
            this.m_phase_value.Name = "m_phase_value";
            this.m_phase_value.UseVisualStyleBackColor = true;
            this.m_phase_value.CheckedChanged += new System.EventHandler(this.m_phase_value_CheckedChanged);
            // 
            // m_new_fast_inventory_flag
            // 
            this.m_new_fast_inventory_flag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.m_new_fast_inventory_flag, "m_new_fast_inventory_flag");
            this.m_new_fast_inventory_flag.ForeColor = System.Drawing.SystemColors.InfoText;
            this.m_new_fast_inventory_flag.FormattingEnabled = true;
            this.m_new_fast_inventory_flag.Items.AddRange(new object[] {
            resources.GetString("m_new_fast_inventory_flag.Items"),
            resources.GetString("m_new_fast_inventory_flag.Items1")});
            this.m_new_fast_inventory_flag.Name = "m_new_fast_inventory_flag";
            // 
            // m_new_fast_inventory_session
            // 
            this.m_new_fast_inventory_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.m_new_fast_inventory_session, "m_new_fast_inventory_session");
            this.m_new_fast_inventory_session.ForeColor = System.Drawing.SystemColors.InfoText;
            this.m_new_fast_inventory_session.FormattingEnabled = true;
            this.m_new_fast_inventory_session.Items.AddRange(new object[] {
            resources.GetString("m_new_fast_inventory_session.Items"),
            resources.GetString("m_new_fast_inventory_session.Items1"),
            resources.GetString("m_new_fast_inventory_session.Items2"),
            resources.GetString("m_new_fast_inventory_session.Items3")});
            this.m_new_fast_inventory_session.Name = "m_new_fast_inventory_session";
            // 
            // m_new_fast_inventory
            // 
            resources.ApplyResources(this.m_new_fast_inventory, "m_new_fast_inventory");
            this.m_new_fast_inventory.Name = "m_new_fast_inventory";
            this.m_new_fast_inventory.UseVisualStyleBackColor = true;
            this.m_new_fast_inventory.CheckedChanged += new System.EventHandler(this.m_new_fast_inventory_CheckedChanged);
            // 
            // label73
            // 
            resources.ApplyResources(this.label73, "label73");
            this.label73.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label73.Name = "label73";
            // 
            // txtInterval
            // 
            resources.ApplyResources(this.txtInterval, "txtInterval");
            this.txtInterval.Name = "txtInterval";
            // 
            // label72
            // 
            resources.ApplyResources(this.label72, "label72");
            this.label72.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label72.Name = "label72";
            // 
            // mReserve
            // 
            resources.ApplyResources(this.mReserve, "mReserve");
            this.mReserve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mReserve.Name = "mReserve";
            // 
            // txtRepeat
            // 
            resources.ApplyResources(this.txtRepeat, "txtRepeat");
            this.txtRepeat.Name = "txtRepeat";
            // 
            // mPower1
            // 
            resources.ApplyResources(this.mPower1, "mPower1");
            this.mPower1.Name = "mPower1";
            // 
            // mPower2
            // 
            resources.ApplyResources(this.mPower2, "mPower2");
            this.mPower2.Name = "mPower2";
            // 
            // mPower5
            // 
            resources.ApplyResources(this.mPower5, "mPower5");
            this.mPower5.Name = "mPower5";
            // 
            // mPower4
            // 
            resources.ApplyResources(this.mPower4, "mPower4");
            this.mPower4.Name = "mPower4";
            this.mPower4.TextChanged += new System.EventHandler(this.mPower4_TextChanged);
            // 
            // mPower3
            // 
            resources.ApplyResources(this.mPower3, "mPower3");
            this.mPower3.Name = "mPower3";
            // 
            // groupBox26
            // 
            resources.ApplyResources(this.groupBox26, "groupBox26");
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.TabStop = false;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            resources.GetString("comboBox7.Items"),
            resources.GetString("comboBox7.Items1"),
            resources.GetString("comboBox7.Items2"),
            resources.GetString("comboBox7.Items3"),
            resources.GetString("comboBox7.Items4")});
            resources.ApplyResources(this.comboBox7, "comboBox7");
            this.comboBox7.Name = "comboBox7";
            // 
            // txtFastMaxRssi
            // 
            resources.ApplyResources(this.txtFastMaxRssi, "txtFastMaxRssi");
            this.txtFastMaxRssi.Name = "txtFastMaxRssi";
            // 
            // txtFastMinRssi
            // 
            resources.ApplyResources(this.txtFastMinRssi, "txtFastMinRssi");
            this.txtFastMinRssi.Name = "txtFastMinRssi";
            // 
            // buttonFastFresh
            // 
            resources.ApplyResources(this.buttonFastFresh, "buttonFastFresh");
            this.buttonFastFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFastFresh.Name = "buttonFastFresh";
            this.buttonFastFresh.UseVisualStyleBackColor = true;
            this.buttonFastFresh.Click += new System.EventHandler(this.buttonFastFresh_Click);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Name = "label22";
            // 
            // lvFastList
            // 
            this.lvFastList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader356,
            this.columnHeader36});
            resources.ApplyResources(this.lvFastList, "lvFastList");
            this.lvFastList.GridLines = true;
            this.lvFastList.Name = "lvFastList";
            this.lvFastList.UseCompatibleStateImageBehavior = false;
            this.lvFastList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader31
            // 
            resources.ApplyResources(this.columnHeader31, "columnHeader31");
            // 
            // columnHeader32
            // 
            resources.ApplyResources(this.columnHeader32, "columnHeader32");
            // 
            // columnHeader33
            // 
            resources.ApplyResources(this.columnHeader33, "columnHeader33");
            // 
            // columnHeader34
            // 
            resources.ApplyResources(this.columnHeader34, "columnHeader34");
            // 
            // columnHeader35
            // 
            resources.ApplyResources(this.columnHeader35, "columnHeader35");
            // 
            // columnHeader356
            // 
            resources.ApplyResources(this.columnHeader356, "columnHeader356");
            // 
            // columnHeader36
            // 
            resources.ApplyResources(this.columnHeader36, "columnHeader36");
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label49.Name = "label49";
            // 
            // txtFastTagList
            // 
            resources.ApplyResources(this.txtFastTagList, "txtFastTagList");
            this.txtFastTagList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtFastTagList.Name = "txtFastTagList";
            // 
            // pageAcessTag
            // 
            this.pageAcessTag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageAcessTag.Controls.Add(this.ltvOperate);
            this.pageAcessTag.Controls.Add(this.gbCmdOperateTag);
            resources.ApplyResources(this.pageAcessTag, "pageAcessTag");
            this.pageAcessTag.Name = "pageAcessTag";
            this.pageAcessTag.UseVisualStyleBackColor = true;
            // 
            // ltvOperate
            // 
            this.ltvOperate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            resources.ApplyResources(this.ltvOperate, "ltvOperate");
            this.ltvOperate.GridLines = true;
            this.ltvOperate.Name = "ltvOperate";
            this.ltvOperate.UseCompatibleStateImageBehavior = false;
            this.ltvOperate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // gbCmdOperateTag
            // 
            this.gbCmdOperateTag.Controls.Add(this.groupBox16);
            this.gbCmdOperateTag.Controls.Add(this.groupBox15);
            this.gbCmdOperateTag.Controls.Add(this.groupBox14);
            this.gbCmdOperateTag.Controls.Add(this.groupBox13);
            resources.ApplyResources(this.gbCmdOperateTag, "gbCmdOperateTag");
            this.gbCmdOperateTag.Name = "gbCmdOperateTag";
            this.gbCmdOperateTag.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnKillTag);
            this.groupBox16.Controls.Add(this.htxtKillPwd);
            this.groupBox16.Controls.Add(this.label29);
            resources.ApplyResources(this.groupBox16, "groupBox16");
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.TabStop = false;
            // 
            // btnKillTag
            // 
            resources.ApplyResources(this.btnKillTag, "btnKillTag");
            this.btnKillTag.Name = "btnKillTag";
            this.btnKillTag.UseVisualStyleBackColor = true;
            this.btnKillTag.Click += new System.EventHandler(this.btnKillTag_Click);
            // 
            // htxtKillPwd
            // 
            resources.ApplyResources(this.htxtKillPwd, "htxtKillPwd");
            this.htxtKillPwd.Name = "htxtKillPwd";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.htxtLockPwd);
            this.groupBox15.Controls.Add(this.label28);
            this.groupBox15.Controls.Add(this.groupBox19);
            this.groupBox15.Controls.Add(this.groupBox18);
            this.groupBox15.Controls.Add(this.btnLockTag);
            resources.ApplyResources(this.groupBox15, "groupBox15");
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.TabStop = false;
            // 
            // htxtLockPwd
            // 
            resources.ApplyResources(this.htxtLockPwd, "htxtLockPwd");
            this.htxtLockPwd.Name = "htxtLockPwd";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rdbUserMemory);
            this.groupBox19.Controls.Add(this.rdbTidMemory);
            this.groupBox19.Controls.Add(this.rdbEpcMermory);
            this.groupBox19.Controls.Add(this.rdbKillPwd);
            this.groupBox19.Controls.Add(this.rdbAccessPwd);
            resources.ApplyResources(this.groupBox19, "groupBox19");
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.TabStop = false;
            // 
            // rdbUserMemory
            // 
            resources.ApplyResources(this.rdbUserMemory, "rdbUserMemory");
            this.rdbUserMemory.Name = "rdbUserMemory";
            this.rdbUserMemory.TabStop = true;
            this.rdbUserMemory.UseVisualStyleBackColor = true;
            // 
            // rdbTidMemory
            // 
            resources.ApplyResources(this.rdbTidMemory, "rdbTidMemory");
            this.rdbTidMemory.Name = "rdbTidMemory";
            this.rdbTidMemory.TabStop = true;
            this.rdbTidMemory.UseVisualStyleBackColor = true;
            // 
            // rdbEpcMermory
            // 
            resources.ApplyResources(this.rdbEpcMermory, "rdbEpcMermory");
            this.rdbEpcMermory.Name = "rdbEpcMermory";
            this.rdbEpcMermory.TabStop = true;
            this.rdbEpcMermory.UseVisualStyleBackColor = true;
            // 
            // rdbKillPwd
            // 
            resources.ApplyResources(this.rdbKillPwd, "rdbKillPwd");
            this.rdbKillPwd.Name = "rdbKillPwd";
            this.rdbKillPwd.TabStop = true;
            this.rdbKillPwd.UseVisualStyleBackColor = true;
            // 
            // rdbAccessPwd
            // 
            resources.ApplyResources(this.rdbAccessPwd, "rdbAccessPwd");
            this.rdbAccessPwd.Name = "rdbAccessPwd";
            this.rdbAccessPwd.TabStop = true;
            this.rdbAccessPwd.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.rdbLockEver);
            this.groupBox18.Controls.Add(this.rdbFreeEver);
            this.groupBox18.Controls.Add(this.rdbLock);
            this.groupBox18.Controls.Add(this.rdbFree);
            resources.ApplyResources(this.groupBox18, "groupBox18");
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.TabStop = false;
            // 
            // rdbLockEver
            // 
            resources.ApplyResources(this.rdbLockEver, "rdbLockEver");
            this.rdbLockEver.Name = "rdbLockEver";
            this.rdbLockEver.TabStop = true;
            this.rdbLockEver.UseVisualStyleBackColor = true;
            // 
            // rdbFreeEver
            // 
            resources.ApplyResources(this.rdbFreeEver, "rdbFreeEver");
            this.rdbFreeEver.Name = "rdbFreeEver";
            this.rdbFreeEver.TabStop = true;
            this.rdbFreeEver.UseVisualStyleBackColor = true;
            // 
            // rdbLock
            // 
            resources.ApplyResources(this.rdbLock, "rdbLock");
            this.rdbLock.Name = "rdbLock";
            this.rdbLock.TabStop = true;
            this.rdbLock.UseVisualStyleBackColor = true;
            // 
            // rdbFree
            // 
            resources.ApplyResources(this.rdbFree, "rdbFree");
            this.rdbFree.Name = "rdbFree";
            this.rdbFree.TabStop = true;
            this.rdbFree.UseVisualStyleBackColor = true;
            // 
            // btnLockTag
            // 
            resources.ApplyResources(this.btnLockTag, "btnLockTag");
            this.btnLockTag.Name = "btnLockTag";
            this.btnLockTag.UseVisualStyleBackColor = true;
            this.btnLockTag.Click += new System.EventHandler(this.btnLockTag_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioButton2);
            this.groupBox14.Controls.Add(this.radioButton1);
            this.groupBox14.Controls.Add(this.htxtWriteData);
            this.groupBox14.Controls.Add(this.txtWordCnt);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.btnWriteTag);
            this.groupBox14.Controls.Add(this.btnReadTag);
            this.groupBox14.Controls.Add(this.txtWordAdd);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.htxtReadAndWritePwd);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.label24);
            resources.ApplyResources(this.groupBox14, "groupBox14");
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.TabStop = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Checked = true;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // htxtWriteData
            // 
            resources.ApplyResources(this.htxtWriteData, "htxtWriteData");
            this.htxtWriteData.Name = "htxtWriteData";
            // 
            // txtWordCnt
            // 
            resources.ApplyResources(this.txtWordCnt, "txtWordCnt");
            this.txtWordCnt.Name = "txtWordCnt";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // btnWriteTag
            // 
            resources.ApplyResources(this.btnWriteTag, "btnWriteTag");
            this.btnWriteTag.Name = "btnWriteTag";
            this.btnWriteTag.UseVisualStyleBackColor = true;
            this.btnWriteTag.Click += new System.EventHandler(this.btnWriteTag_Click);
            // 
            // btnReadTag
            // 
            resources.ApplyResources(this.btnReadTag, "btnReadTag");
            this.btnReadTag.Name = "btnReadTag";
            this.btnReadTag.UseVisualStyleBackColor = true;
            this.btnReadTag.Click += new System.EventHandler(this.btnReadTag_Click);
            // 
            // txtWordAdd
            // 
            resources.ApplyResources(this.txtWordAdd, "txtWordAdd");
            this.txtWordAdd.Name = "txtWordAdd";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // htxtReadAndWritePwd
            // 
            resources.ApplyResources(this.htxtReadAndWritePwd, "htxtReadAndWritePwd");
            this.htxtReadAndWritePwd.Name = "htxtReadAndWritePwd";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.rdbUser);
            this.groupBox17.Controls.Add(this.rdbTid);
            this.groupBox17.Controls.Add(this.rdbEpc);
            this.groupBox17.Controls.Add(this.rdbReserved);
            resources.ApplyResources(this.groupBox17, "groupBox17");
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.TabStop = false;
            // 
            // rdbUser
            // 
            resources.ApplyResources(this.rdbUser, "rdbUser");
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.TabStop = true;
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbTid
            // 
            resources.ApplyResources(this.rdbTid, "rdbTid");
            this.rdbTid.Name = "rdbTid";
            this.rdbTid.TabStop = true;
            this.rdbTid.UseVisualStyleBackColor = true;
            // 
            // rdbEpc
            // 
            resources.ApplyResources(this.rdbEpc, "rdbEpc");
            this.rdbEpc.Name = "rdbEpc";
            this.rdbEpc.TabStop = true;
            this.rdbEpc.UseVisualStyleBackColor = true;
            // 
            // rdbReserved
            // 
            resources.ApplyResources(this.rdbReserved, "rdbReserved");
            this.rdbReserved.Name = "rdbReserved";
            this.rdbReserved.TabStop = true;
            this.rdbReserved.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.btnSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.cmbSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.txtAccessEpcMatch);
            this.groupBox13.Controls.Add(this.ckAccessEpcMatch);
            resources.ApplyResources(this.groupBox13, "groupBox13");
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.TabStop = false;
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // btnSetAccessEpcMatch
            // 
            resources.ApplyResources(this.btnSetAccessEpcMatch, "btnSetAccessEpcMatch");
            this.btnSetAccessEpcMatch.Name = "btnSetAccessEpcMatch";
            this.btnSetAccessEpcMatch.UseVisualStyleBackColor = true;
            this.btnSetAccessEpcMatch.Click += new System.EventHandler(this.btnSetAccessEpcMatch_Click);
            // 
            // cmbSetAccessEpcMatch
            // 
            this.cmbSetAccessEpcMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetAccessEpcMatch.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSetAccessEpcMatch, "cmbSetAccessEpcMatch");
            this.cmbSetAccessEpcMatch.Name = "cmbSetAccessEpcMatch";
            this.cmbSetAccessEpcMatch.DropDown += new System.EventHandler(this.cmbSetAccessEpcMatch_DropDown);
            // 
            // txtAccessEpcMatch
            // 
            resources.ApplyResources(this.txtAccessEpcMatch, "txtAccessEpcMatch");
            this.txtAccessEpcMatch.Name = "txtAccessEpcMatch";
            this.txtAccessEpcMatch.ReadOnly = true;
            // 
            // ckAccessEpcMatch
            // 
            resources.ApplyResources(this.ckAccessEpcMatch, "ckAccessEpcMatch");
            this.ckAccessEpcMatch.Name = "ckAccessEpcMatch";
            this.ckAccessEpcMatch.UseVisualStyleBackColor = true;
            this.ckAccessEpcMatch.CheckedChanged += new System.EventHandler(this.cbAccessEpcMatch_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Controls.Add(this.groupBox22);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox9);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            resources.ApplyResources(this.listView2, "listView2");
            this.listView2.GridLines = true;
            this.listView2.Name = "listView2";
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.button3);
            this.groupBox22.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox22, "groupBox22");
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label111);
            this.groupBox12.Controls.Add(this.comboBox16);
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            // 
            // label111
            // 
            resources.ApplyResources(this.label111, "label111");
            this.label111.Name = "label111";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            resources.GetString("comboBox16.Items"),
            resources.GetString("comboBox16.Items1"),
            resources.GetString("comboBox16.Items2"),
            resources.GetString("comboBox16.Items3"),
            resources.GetString("comboBox16.Items4"),
            resources.GetString("comboBox16.Items5")});
            resources.ApplyResources(this.comboBox16, "comboBox16");
            this.comboBox16.Name = "comboBox16";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox12);
            this.groupBox9.Controls.Add(this.textBox11);
            this.groupBox9.Controls.Add(this.hexTextBox9);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.comboBox12);
            this.groupBox9.Controls.Add(this.label39);
            this.groupBox9.Controls.Add(this.label71);
            this.groupBox9.Controls.Add(this.label99);
            this.groupBox9.Controls.Add(this.label100);
            this.groupBox9.Controls.Add(this.label101);
            this.groupBox9.Controls.Add(this.label102);
            this.groupBox9.Controls.Add(this.comboBox13);
            this.groupBox9.Controls.Add(this.comboBox14);
            this.groupBox9.Controls.Add(this.comboBox15);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // hexTextBox9
            // 
            resources.ApplyResources(this.hexTextBox9, "hexTextBox9");
            this.hexTextBox9.Name = "hexTextBox9";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.DropDownWidth = 70;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            resources.GetString("comboBox12.Items"),
            resources.GetString("comboBox12.Items1"),
            resources.GetString("comboBox12.Items2"),
            resources.GetString("comboBox12.Items3"),
            resources.GetString("comboBox12.Items4")});
            resources.ApplyResources(this.comboBox12, "comboBox12");
            this.comboBox12.Name = "comboBox12";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label71
            // 
            resources.ApplyResources(this.label71, "label71");
            this.label71.Name = "label71";
            // 
            // label99
            // 
            resources.ApplyResources(this.label99, "label99");
            this.label99.Name = "label99";
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.Name = "label100";
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.Name = "label101";
            // 
            // label102
            // 
            resources.ApplyResources(this.label102, "label102");
            this.label102.Name = "label102";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            resources.GetString("comboBox13.Items"),
            resources.GetString("comboBox13.Items1"),
            resources.GetString("comboBox13.Items2"),
            resources.GetString("comboBox13.Items3")});
            resources.ApplyResources(this.comboBox13, "comboBox13");
            this.comboBox13.Name = "comboBox13";
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            resources.GetString("comboBox14.Items"),
            resources.GetString("comboBox14.Items1"),
            resources.GetString("comboBox14.Items2"),
            resources.GetString("comboBox14.Items3"),
            resources.GetString("comboBox14.Items4"),
            resources.GetString("comboBox14.Items5"),
            resources.GetString("comboBox14.Items6"),
            resources.GetString("comboBox14.Items7")});
            resources.ApplyResources(this.comboBox14, "comboBox14");
            this.comboBox14.Name = "comboBox14";
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            resources.GetString("comboBox15.Items"),
            resources.GetString("comboBox15.Items1"),
            resources.GetString("comboBox15.Items2"),
            resources.GetString("comboBox15.Items3"),
            resources.GetString("comboBox15.Items4")});
            resources.ApplyResources(this.comboBox15, "comboBox15");
            this.comboBox15.Name = "comboBox15";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagISO18000
            // 
            this.PagISO18000.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PagISO18000.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagISO18000.Controls.Add(this.btnClear);
            this.PagISO18000.Controls.Add(this.btnInventoryISO18000);
            this.PagISO18000.Controls.Add(this.ltvTagISO18000);
            this.PagISO18000.Controls.Add(this.gbISO1800LockQuery);
            this.PagISO18000.Controls.Add(this.gbISO1800ReadWrite);
            this.PagISO18000.Controls.Add(this.label41);
            this.PagISO18000.Controls.Add(this.htxtReadUID);
            resources.ApplyResources(this.PagISO18000, "PagISO18000");
            this.PagISO18000.Name = "PagISO18000";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInventoryISO18000
            // 
            resources.ApplyResources(this.btnInventoryISO18000, "btnInventoryISO18000");
            this.btnInventoryISO18000.ForeColor = System.Drawing.Color.Indigo;
            this.btnInventoryISO18000.Name = "btnInventoryISO18000";
            this.btnInventoryISO18000.UseVisualStyleBackColor = true;
            this.btnInventoryISO18000.Click += new System.EventHandler(this.btnInventoryISO18000_Click);
            // 
            // ltvTagISO18000
            // 
            this.ltvTagISO18000.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader28});
            resources.ApplyResources(this.ltvTagISO18000, "ltvTagISO18000");
            this.ltvTagISO18000.FullRowSelect = true;
            this.ltvTagISO18000.GridLines = true;
            this.ltvTagISO18000.Name = "ltvTagISO18000";
            this.ltvTagISO18000.UseCompatibleStateImageBehavior = false;
            this.ltvTagISO18000.View = System.Windows.Forms.View.Details;
            this.ltvTagISO18000.Click += new System.EventHandler(this.ltvTagISO18000_Click);
            this.ltvTagISO18000.DoubleClick += new System.EventHandler(this.ltvTagISO18000_DoubleClick);
            // 
            // columnHeader27
            // 
            resources.ApplyResources(this.columnHeader27, "columnHeader27");
            // 
            // columnHeader25
            // 
            resources.ApplyResources(this.columnHeader25, "columnHeader25");
            // 
            // columnHeader26
            // 
            resources.ApplyResources(this.columnHeader26, "columnHeader26");
            // 
            // columnHeader28
            // 
            resources.ApplyResources(this.columnHeader28, "columnHeader28");
            // 
            // gbISO1800LockQuery
            // 
            this.gbISO1800LockQuery.Controls.Add(this.txtStatus);
            this.gbISO1800LockQuery.Controls.Add(this.htxtQueryAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label46);
            this.gbISO1800LockQuery.Controls.Add(this.htxtLockAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label47);
            this.gbISO1800LockQuery.Controls.Add(this.btnQueryTagISO18000);
            this.gbISO1800LockQuery.Controls.Add(this.btnLockTagISO18000);
            resources.ApplyResources(this.gbISO1800LockQuery, "gbISO1800LockQuery");
            this.gbISO1800LockQuery.Name = "gbISO1800LockQuery";
            this.gbISO1800LockQuery.TabStop = false;
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            // 
            // htxtQueryAdd
            // 
            resources.ApplyResources(this.htxtQueryAdd, "htxtQueryAdd");
            this.htxtQueryAdd.Name = "htxtQueryAdd";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // htxtLockAdd
            // 
            resources.ApplyResources(this.htxtLockAdd, "htxtLockAdd");
            this.htxtLockAdd.Name = "htxtLockAdd";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // btnQueryTagISO18000
            // 
            resources.ApplyResources(this.btnQueryTagISO18000, "btnQueryTagISO18000");
            this.btnQueryTagISO18000.Name = "btnQueryTagISO18000";
            this.btnQueryTagISO18000.UseVisualStyleBackColor = true;
            this.btnQueryTagISO18000.Click += new System.EventHandler(this.btnQueryTagISO18000_Click);
            // 
            // btnLockTagISO18000
            // 
            resources.ApplyResources(this.btnLockTagISO18000, "btnLockTagISO18000");
            this.btnLockTagISO18000.Name = "btnLockTagISO18000";
            this.btnLockTagISO18000.UseVisualStyleBackColor = true;
            this.btnLockTagISO18000.Click += new System.EventHandler(this.btnLockTagISO18000_Click);
            // 
            // gbISO1800ReadWrite
            // 
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoopTimes);
            this.gbISO1800ReadWrite.Controls.Add(this.label44);
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoop);
            this.gbISO1800ReadWrite.Controls.Add(this.label40);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.txtWriteLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label45);
            this.gbISO1800ReadWrite.Controls.Add(this.btnWriteTagISO18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label51);
            this.gbISO1800ReadWrite.Controls.Add(this.label52);
            this.gbISO1800ReadWrite.Controls.Add(this.txtReadLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label50);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label42);
            this.gbISO1800ReadWrite.Controls.Add(this.label43);
            this.gbISO1800ReadWrite.Controls.Add(this.btnReadTagISO18000);
            resources.ApplyResources(this.gbISO1800ReadWrite, "gbISO1800ReadWrite");
            this.gbISO1800ReadWrite.Name = "gbISO1800ReadWrite";
            this.gbISO1800ReadWrite.TabStop = false;
            // 
            // txtLoopTimes
            // 
            resources.ApplyResources(this.txtLoopTimes, "txtLoopTimes");
            this.txtLoopTimes.Name = "txtLoopTimes";
            this.txtLoopTimes.ReadOnly = true;
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // txtLoop
            // 
            resources.ApplyResources(this.txtLoop, "txtLoop");
            this.txtLoop.Name = "txtLoop";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // htxtWriteData18000
            // 
            resources.ApplyResources(this.htxtWriteData18000, "htxtWriteData18000");
            this.htxtWriteData18000.Name = "htxtWriteData18000";
            // 
            // txtWriteLength
            // 
            resources.ApplyResources(this.txtWriteLength, "txtWriteLength");
            this.txtWriteLength.Name = "txtWriteLength";
            this.txtWriteLength.ReadOnly = true;
            // 
            // htxtReadData18000
            // 
            resources.ApplyResources(this.htxtReadData18000, "htxtReadData18000");
            this.htxtReadData18000.Name = "htxtReadData18000";
            this.htxtReadData18000.ReadOnly = true;
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // btnWriteTagISO18000
            // 
            resources.ApplyResources(this.btnWriteTagISO18000, "btnWriteTagISO18000");
            this.btnWriteTagISO18000.Name = "btnWriteTagISO18000";
            this.btnWriteTagISO18000.UseVisualStyleBackColor = true;
            this.btnWriteTagISO18000.Click += new System.EventHandler(this.btnWriteTagISO18000_Click);
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // txtReadLength
            // 
            resources.ApplyResources(this.txtReadLength, "txtReadLength");
            this.txtReadLength.Name = "txtReadLength";
            // 
            // htxtWriteStartAdd
            // 
            resources.ApplyResources(this.htxtWriteStartAdd, "htxtWriteStartAdd");
            this.htxtWriteStartAdd.Name = "htxtWriteStartAdd";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // htxtReadStartAdd
            // 
            resources.ApplyResources(this.htxtReadStartAdd, "htxtReadStartAdd");
            this.htxtReadStartAdd.Name = "htxtReadStartAdd";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // btnReadTagISO18000
            // 
            resources.ApplyResources(this.btnReadTagISO18000, "btnReadTagISO18000");
            this.btnReadTagISO18000.Name = "btnReadTagISO18000";
            this.btnReadTagISO18000.UseVisualStyleBackColor = true;
            this.btnReadTagISO18000.Click += new System.EventHandler(this.btnReadTagISO18000_Click);
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // htxtReadUID
            // 
            resources.ApplyResources(this.htxtReadUID, "htxtReadUID");
            this.htxtReadUID.Name = "htxtReadUID";
            this.htxtReadUID.ReadOnly = true;
            // 
            // PagTranDataLog
            // 
            this.PagTranDataLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagTranDataLog.Controls.Add(this.gbCmdManual);
            this.PagTranDataLog.Controls.Add(this.lrtxtDataTran);
            resources.ApplyResources(this.PagTranDataLog, "PagTranDataLog");
            this.PagTranDataLog.Name = "PagTranDataLog";
            this.PagTranDataLog.UseVisualStyleBackColor = true;
            // 
            // gbCmdManual
            // 
            this.gbCmdManual.Controls.Add(this.label16);
            this.gbCmdManual.Controls.Add(this.htxtSendData);
            this.gbCmdManual.Controls.Add(this.btnClearData);
            this.gbCmdManual.Controls.Add(this.label17);
            this.gbCmdManual.Controls.Add(this.btnSendData);
            this.gbCmdManual.Controls.Add(this.htxtCheckData);
            resources.ApplyResources(this.gbCmdManual, "gbCmdManual");
            this.gbCmdManual.Name = "gbCmdManual";
            this.gbCmdManual.TabStop = false;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // htxtSendData
            // 
            resources.ApplyResources(this.htxtSendData, "htxtSendData");
            this.htxtSendData.Name = "htxtSendData";
            this.htxtSendData.Leave += new System.EventHandler(this.htxtSendData_Leave);
            // 
            // btnClearData
            // 
            resources.ApplyResources(this.btnClearData, "btnClearData");
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // btnSendData
            // 
            resources.ApplyResources(this.btnSendData, "btnSendData");
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // htxtCheckData
            // 
            resources.ApplyResources(this.htxtCheckData, "htxtCheckData");
            this.htxtCheckData.Name = "htxtCheckData";
            this.htxtCheckData.ReadOnly = true;
            // 
            // lrtxtDataTran
            // 
            resources.ApplyResources(this.lrtxtDataTran, "lrtxtDataTran");
            this.lrtxtDataTran.Name = "lrtxtDataTran";
            this.lrtxtDataTran.DoubleClick += new System.EventHandler(this.lrtxtDataTran_DoubleClick);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // ckDisplayLog
            // 
            resources.ApplyResources(this.ckDisplayLog, "ckDisplayLog");
            this.ckDisplayLog.ForeColor = System.Drawing.Color.Indigo;
            this.ckDisplayLog.Name = "ckDisplayLog";
            this.ckDisplayLog.UseVisualStyleBackColor = true;
            this.ckDisplayLog.CheckedChanged += new System.EventHandler(this.ckDisplayLog_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBox5);
            this.panel7.Controls.Add(this.checkBox6);
            this.panel7.Controls.Add(this.checkBox7);
            this.panel7.Controls.Add(this.checkBox8);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            resources.ApplyResources(this.label76, "label76");
            this.label76.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label76.Name = "label76";
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label77.Name = "label77";
            // 
            // label78
            // 
            resources.ApplyResources(this.label78, "label78");
            this.label78.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label78.Name = "label78";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox9);
            this.groupBox8.Controls.Add(this.lxLedControl9);
            this.groupBox8.Controls.Add(this.lxLedControl10);
            this.groupBox8.Controls.Add(this.lxLedControl11);
            this.groupBox8.Controls.Add(this.lxLedControl12);
            this.groupBox8.Controls.Add(this.label79);
            this.groupBox8.Controls.Add(this.label80);
            this.groupBox8.Controls.Add(this.label81);
            this.groupBox8.Controls.Add(this.label82);
            this.groupBox8.Controls.Add(this.label83);
            this.groupBox8.Controls.Add(this.lxLedControl13);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            resources.GetString("comboBox9.Items"),
            resources.GetString("comboBox9.Items1"),
            resources.GetString("comboBox9.Items2"),
            resources.GetString("comboBox9.Items3"),
            resources.GetString("comboBox9.Items4")});
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.Name = "comboBox9";
            // 
            // lxLedControl9
            // 
            this.lxLedControl9.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl9.BevelRate = 0.1F;
            this.lxLedControl9.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl9.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl9.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl9.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl9.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl9, "lxLedControl9");
            this.lxLedControl9.Name = "lxLedControl9";
            this.lxLedControl9.RoundCorner = true;
            this.lxLedControl9.SegmentIntervalRatio = 50;
            this.lxLedControl9.ShowHighlight = true;
            this.lxLedControl9.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl9.TotalCharCount = 10;
            // 
            // lxLedControl10
            // 
            this.lxLedControl10.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl10.BevelRate = 0.1F;
            this.lxLedControl10.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl10.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl10.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl10.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl10.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl10, "lxLedControl10");
            this.lxLedControl10.Name = "lxLedControl10";
            this.lxLedControl10.RoundCorner = true;
            this.lxLedControl10.SegmentIntervalRatio = 50;
            this.lxLedControl10.ShowHighlight = true;
            this.lxLedControl10.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl11
            // 
            this.lxLedControl11.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl11.BevelRate = 0.1F;
            this.lxLedControl11.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl11.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl11.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl11.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl11.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl11, "lxLedControl11");
            this.lxLedControl11.Name = "lxLedControl11";
            this.lxLedControl11.RoundCorner = true;
            this.lxLedControl11.SegmentIntervalRatio = 50;
            this.lxLedControl11.ShowHighlight = true;
            this.lxLedControl11.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl12
            // 
            this.lxLedControl12.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl12.BevelRate = 0.1F;
            this.lxLedControl12.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl12.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl12.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl12.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl12.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl12, "lxLedControl12");
            this.lxLedControl12.Name = "lxLedControl12";
            this.lxLedControl12.RoundCorner = true;
            this.lxLedControl12.SegmentIntervalRatio = 50;
            this.lxLedControl12.ShowHighlight = true;
            this.lxLedControl12.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label79
            // 
            resources.ApplyResources(this.label79, "label79");
            this.label79.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label79.Name = "label79";
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label80.Name = "label80";
            // 
            // label81
            // 
            resources.ApplyResources(this.label81, "label81");
            this.label81.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label81.Name = "label81";
            // 
            // label82
            // 
            resources.ApplyResources(this.label82, "label82");
            this.label82.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label82.Name = "label82";
            // 
            // label83
            // 
            resources.ApplyResources(this.label83, "label83");
            this.label83.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label83.Name = "label83";
            // 
            // lxLedControl13
            // 
            this.lxLedControl13.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl13.BevelRate = 0.1F;
            this.lxLedControl13.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl13.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl13.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl13.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl13.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl13, "lxLedControl13");
            this.lxLedControl13.Name = "lxLedControl13";
            this.lxLedControl13.RoundCorner = true;
            this.lxLedControl13.SegmentIntervalRatio = 50;
            this.lxLedControl13.ShowHighlight = true;
            this.lxLedControl13.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader43
            // 
            resources.ApplyResources(this.columnHeader43, "columnHeader43");
            // 
            // columnHeader44
            // 
            resources.ApplyResources(this.columnHeader44, "columnHeader44");
            // 
            // columnHeader45
            // 
            resources.ApplyResources(this.columnHeader45, "columnHeader45");
            // 
            // columnHeader46
            // 
            resources.ApplyResources(this.columnHeader46, "columnHeader46");
            // 
            // columnHeader47
            // 
            resources.ApplyResources(this.columnHeader47, "columnHeader47");
            // 
            // columnHeader48
            // 
            resources.ApplyResources(this.columnHeader48, "columnHeader48");
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            resources.GetString("comboBox10.Items"),
            resources.GetString("comboBox10.Items1"),
            resources.GetString("comboBox10.Items2"),
            resources.GetString("comboBox10.Items3"),
            resources.GetString("comboBox10.Items4")});
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.Name = "comboBox10";
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label87.Name = "label87";
            // 
            // label88
            // 
            resources.ApplyResources(this.label88, "label88");
            this.label88.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label88.Name = "label88";
            // 
            // label89
            // 
            resources.ApplyResources(this.label89, "label89");
            this.label89.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label89.Name = "label89";
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label90.Name = "label90";
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label91.Name = "label91";
            // 
            // ckClearOperationRec
            // 
            resources.ApplyResources(this.ckClearOperationRec, "ckClearOperationRec");
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // lrtxtLog
            // 
            resources.ApplyResources(this.lrtxtLog, "lrtxtLog");
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.TextChanged += new System.EventHandler(this.lrtxtLog_TextChanged);
            this.lrtxtLog.DoubleClick += new System.EventHandler(this.lrtxtLog_DoubleClick);
            // 
            // lxLedControl14
            // 
            this.lxLedControl14.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl14.BevelRate = 0.1F;
            this.lxLedControl14.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl14.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl14.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl14.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl14.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl14, "lxLedControl14");
            this.lxLedControl14.Name = "lxLedControl14";
            this.lxLedControl14.RoundCorner = true;
            this.lxLedControl14.SegmentIntervalRatio = 50;
            this.lxLedControl14.ShowHighlight = true;
            this.lxLedControl14.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl14.TotalCharCount = 10;
            // 
            // lxLedControl15
            // 
            this.lxLedControl15.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl15.BevelRate = 0.1F;
            this.lxLedControl15.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl15.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl15.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl15.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl15.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl15, "lxLedControl15");
            this.lxLedControl15.Name = "lxLedControl15";
            this.lxLedControl15.RoundCorner = true;
            this.lxLedControl15.SegmentIntervalRatio = 50;
            this.lxLedControl15.ShowHighlight = true;
            this.lxLedControl15.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl16
            // 
            this.lxLedControl16.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl16.BevelRate = 0.1F;
            this.lxLedControl16.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl16.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl16.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl16.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl16.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl16, "lxLedControl16");
            this.lxLedControl16.Name = "lxLedControl16";
            this.lxLedControl16.RoundCorner = true;
            this.lxLedControl16.SegmentIntervalRatio = 50;
            this.lxLedControl16.ShowHighlight = true;
            this.lxLedControl16.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl17
            // 
            this.lxLedControl17.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl17.BevelRate = 0.1F;
            this.lxLedControl17.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl17.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl17.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl17.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl17.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl17, "lxLedControl17");
            this.lxLedControl17.Name = "lxLedControl17";
            this.lxLedControl17.RoundCorner = true;
            this.lxLedControl17.SegmentIntervalRatio = 50;
            this.lxLedControl17.ShowHighlight = true;
            this.lxLedControl17.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl18
            // 
            this.lxLedControl18.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl18.BevelRate = 0.1F;
            this.lxLedControl18.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl18.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl18.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl18.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl18.HighlightOpaque = ((byte)(20));
            resources.ApplyResources(this.lxLedControl18, "lxLedControl18");
            this.lxLedControl18.Name = "lxLedControl18";
            this.lxLedControl18.RoundCorner = true;
            this.lxLedControl18.SegmentIntervalRatio = 50;
            this.lxLedControl18.ShowHighlight = true;
            this.lxLedControl18.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // timerInventory
            // 
            this.timerInventory.Interval = 500;
            this.timerInventory.Tick += new System.EventHandler(this.timerInventory_Tick);
            // 
            // totalTime
            // 
            this.totalTime.Interval = 50;
            this.totalTime.Tick += new System.EventHandler(this.totalTimeDisplay);
            // 
            // sortImageList
            // 
            this.sortImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sortImageList.ImageStream")));
            this.sortImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sortImageList.Images.SetKeyName(0, "sort.png");
            // 
            // R2000UartDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.ckDisplayLog);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.lrtxtLog);
            this.Controls.Add(this.tabCtrMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "R2000UartDemo";
            this.Load += new System.EventHandler(this.R2000UartDemo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabCtrMain.ResumeLayout(false);
            this.PagReaderSetting.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.gbCmdReadGpio.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbCmdBeeper.ResumeLayout(false);
            this.gbCmdBeeper.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbCmdVersion.ResumeLayout(false);
            this.gbCmdVersion.PerformLayout();
            this.gbCmdBaudrate.ResumeLayout(false);
            this.gbCmdBaudrate.PerformLayout();
            this.gbCmdReaderAddress.ResumeLayout(false);
            this.gbCmdReaderAddress.PerformLayout();
            this.gbTcpIp.ResumeLayout(false);
            this.gbTcpIp.PerformLayout();
            this.gbRS232.ResumeLayout(false);
            this.gbRS232.PerformLayout();
            this.gbConnectType.ResumeLayout(false);
            this.gbConnectType.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.gbMonza.ResumeLayout(false);
            this.gbMonza.PerformLayout();
            this.gbCmdAntDetector.ResumeLayout(false);
            this.gbCmdAntDetector.PerformLayout();
            this.gbCmdAntenna.ResumeLayout(false);
            this.gbCmdAntenna.PerformLayout();
            this.gbCmdRegion.ResumeLayout(false);
            this.gbCmdRegion.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.gbCmdOutputPower.ResumeLayout(false);
            this.gbCmdOutputPower.PerformLayout();
            this.pageEpcTest.ResumeLayout(false);
            this.tabEpcTest.ResumeLayout(false);
            this.pageRealMode.ResumeLayout(false);
            this.pageRealMode.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).EndInit();
            this.pageBufferedMode.ResumeLayout(false);
            this.pageBufferedMode.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).EndInit();
            this.pageFast4AntMode.ResumeLayout(false);
            this.pageFast4AntMode.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.pageAcessTag.ResumeLayout(false);
            this.gbCmdOperateTag.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.PagISO18000.ResumeLayout(false);
            this.PagISO18000.PerformLayout();
            this.gbISO1800LockQuery.ResumeLayout(false);
            this.gbISO1800LockQuery.PerformLayout();
            this.gbISO1800ReadWrite.ResumeLayout(false);
            this.gbISO1800ReadWrite.PerformLayout();
            this.PagTranDataLog.ResumeLayout(false);
            this.gbCmdManual.ResumeLayout(false);
            this.gbCmdManual.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrMain;
        private System.Windows.Forms.TabPage PagReaderSetting;
        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.TabPage PagTranDataLog;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label17;
        private CustomControl.HexTextBox htxtSendData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbCmdManual;
        private CustomControl.LogRichTextBox lrtxtDataTran;
        private CustomControl.HexTextBox htxtCheckData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TabPage PagISO18000;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnWriteTagISO18000;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private CustomControl.HexTextBox htxtReadUID;
        private CustomControl.HexTextBox htxtQueryAdd;
        private CustomControl.HexTextBox htxtWriteStartAdd;
        private System.Windows.Forms.Button btnInventoryISO18000;
        private System.Windows.Forms.Button btnReadTagISO18000;
        private System.Windows.Forms.Button btnLockTagISO18000;
        private System.Windows.Forms.Button btnQueryTagISO18000;
        private System.Windows.Forms.Label label50;
        private CustomControl.HexTextBox htxtReadStartAdd;
        private CustomControl.HexTextBox htxtWriteData18000;
        private CustomControl.HexTextBox htxtLockAdd;
        private System.Windows.Forms.ListView ltvTagISO18000;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtReadLength;
        private System.Windows.Forms.TextBox txtWriteLength;
        private CustomControl.HexTextBox htxtReadData18000;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox gbISO1800ReadWrite;
        private System.Windows.Forms.GroupBox gbISO1800LockQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckDisplayLog;
        private System.Windows.Forms.TextBox txtLoopTimes;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TabPage pageEpcTest;
        private System.Windows.Forms.TabControl tabEpcTest;
        private System.Windows.Forms.TabPage pageFast4AntMode;
        private System.Windows.Forms.TabPage pageRealMode;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ComboBox cmbAntSelect4;
        private System.Windows.Forms.ComboBox cmbAntSelect3;
        private System.Windows.Forms.ComboBox cmbAntSelect2;
        private System.Windows.Forms.ComboBox cmbAntSelect1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage pageBufferedMode;
        private System.Windows.Forms.TabPage pageAcessTag;
        private System.Windows.Forms.Label txtFastTagList;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader356;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Button buttonFastFresh;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFastMinRssi;
        private System.Windows.Forms.TextBox txtFastMaxRssi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbRealMinRssi;
        private System.Windows.Forms.TextBox tbRealMaxRssi;
        private System.Windows.Forms.Button btRealFresh;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label lbRealTagCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private LxControl.LxLedControl ledReal5;
        private LxControl.LxLedControl ledReal2;
        private LxControl.LxLedControl ledReal4;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private LxControl.LxLedControl ledReal1;
        private System.Windows.Forms.Button btRealTimeInventory;
        private System.Windows.Forms.Button btGetBuffer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btBufferFresh;
        private System.Windows.Forms.Label labelBufferTagCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private LxControl.LxLedControl lxLedControl9;
        private LxControl.LxLedControl lxLedControl10;
        private LxControl.LxLedControl lxLedControl11;
        private LxControl.LxLedControl lxLedControl12;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private LxControl.LxLedControl lxLedControl13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ComboBox comboBox10;
        private LxControl.LxLedControl lxLedControl14;
        private LxControl.LxLedControl lxLedControl15;
        private LxControl.LxLedControl lxLedControl16;
        private LxControl.LxLedControl lxLedControl17;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLedControl18;
        private System.Windows.Forms.Button btQueryBuffer;
        private System.Windows.Forms.Button btGetClearBuffer;
        private System.Windows.Forms.Button btClearBuffer;
        private System.Windows.Forms.ListView lvBufferList;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.GroupBox gbCmdOperateTag;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btnKillTag;
        private CustomControl.HexTextBox htxtKillPwd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox15;
        private CustomControl.HexTextBox htxtLockPwd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rdbUserMemory;
        private System.Windows.Forms.RadioButton rdbTidMemory;
        private System.Windows.Forms.RadioButton rdbEpcMermory;
        private System.Windows.Forms.RadioButton rdbKillPwd;
        private System.Windows.Forms.RadioButton rdbAccessPwd;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton rdbLockEver;
        private System.Windows.Forms.RadioButton rdbFreeEver;
        private System.Windows.Forms.RadioButton rdbLock;
        private System.Windows.Forms.RadioButton rdbFree;
        private System.Windows.Forms.Button btnLockTag;
        private System.Windows.Forms.GroupBox groupBox14;
        private CustomControl.HexTextBox htxtWriteData;
        private System.Windows.Forms.TextBox txtWordCnt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnWriteTag;
        private System.Windows.Forms.Button btnReadTag;
        private System.Windows.Forms.TextBox txtWordAdd;
        private System.Windows.Forms.Label label26;
        private CustomControl.HexTextBox htxtReadAndWritePwd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbTid;
        private System.Windows.Forms.RadioButton rdbEpc;
        private System.Windows.Forms.RadioButton rdbReserved;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSetAccessEpcMatch;
        private System.Windows.Forms.ComboBox cmbSetAccessEpcMatch;
        private System.Windows.Forms.TextBox txtAccessEpcMatch;
        private System.Windows.Forms.CheckBox ckAccessEpcMatch;
        private System.Windows.Forms.TextBox textRealRound;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox textReadRoundBuffer;
        private System.Windows.Forms.ListView ltvOperate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvRealList;
        private LxControl.LxLedControl ledReal3;
        private System.Windows.Forms.GroupBox groupBox3;
        private LxControl.LxLedControl ledBuffer4;
        private System.Windows.Forms.ComboBox comboBox11;
        private LxControl.LxLedControl ledBuffer5;
        private LxControl.LxLedControl ledBuffer2;
        private LxControl.LxLedControl ledBuffer3;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private LxControl.LxLedControl ledBuffer1;
        private System.Windows.Forms.Button btBufferInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btFastInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private LxControl.LxLedControl ledFast4;
        private System.Windows.Forms.ComboBox comboBox7;
        private LxControl.LxLedControl ledFast5;
        private LxControl.LxLedControl ledFast2;
        private LxControl.LxLedControl ledFast3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private LxControl.LxLedControl ledFast1;
        private System.Windows.Forms.TextBox txtDStay;
        private System.Windows.Forms.TextBox txtCStay;
        private System.Windows.Forms.TextBox txtBStay;
        private System.Windows.Forms.TextBox txtAStay;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCmdReadGpio;
        private System.Windows.Forms.Button btnWriteGpio4Value;
        private System.Windows.Forms.Button btnWriteGpio3Value;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rdbGpio4High;
        private System.Windows.Forms.RadioButton rdbGpio4Low;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rdbGpio3High;
        private System.Windows.Forms.RadioButton rdbGpio3Low;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RadioButton rdbGpio2High;
        private System.Windows.Forms.RadioButton rdbGpio2Low;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton rdbGpio1High;
        private System.Windows.Forms.RadioButton rdbGpio1Low;
        private System.Windows.Forms.Button btnReadGpioValue;
        private System.Windows.Forms.GroupBox gbCmdBeeper;
        private System.Windows.Forms.Button btnSetBeeperMode;
        private System.Windows.Forms.RadioButton rdbBeeperModeTag;
        private System.Windows.Forms.RadioButton rdbBeeperModeInventory;
        private System.Windows.Forms.RadioButton rdbBeeperModeSlient;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.GroupBox gbCmdVersion;
        private System.Windows.Forms.Button btnGetFirmwareVersion;
        private System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Button btnResetReader;
        public System.Windows.Forms.GroupBox gbCmdBaudrate;
        private CustomControl.HexTextBox htbGetIdentifier;
        private CustomControl.HexTextBox htbSetIdentifier;
        private System.Windows.Forms.Button btSetIdentifier;
        private System.Windows.Forms.Button btGetIdentifier;
        private System.Windows.Forms.GroupBox gbCmdReaderAddress;
        private CustomControl.HexTextBox htxtReadId;
        private System.Windows.Forms.Button btnSetReadAddress;
        private System.Windows.Forms.GroupBox gbTcpIp;
        private System.Windows.Forms.Button btnDisconnectTcp;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Button btnConnectTcp;
        private CustomControl.IpAddressTextBox ipIpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRS232;
        private System.Windows.Forms.Button btnSetUartBaudrate;
        private System.Windows.Forms.Button btnDisconnectRs232;
        private System.Windows.Forms.ComboBox cmbSetBaudrate;
        private System.Windows.Forms.Label lbChangeBaudrate;
        private System.Windows.Forms.Button btnConnectRs232;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConnectType;
        private System.Windows.Forms.RadioButton rdbTcpIp;
        private System.Windows.Forms.RadioButton rdbRS232;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbMonza;
        private System.Windows.Forms.RadioButton rdbMonzaOff;
        private System.Windows.Forms.Button btSetMonzaStatus;
        private System.Windows.Forms.Button btGetMonzaStatus;
        private System.Windows.Forms.RadioButton rdbMonzaOn;
        private System.Windows.Forms.GroupBox gbCmdAntenna;
        private System.Windows.Forms.Button btnGetWorkAntenna;
        private System.Windows.Forms.Button btnSetWorkAntenna;
        private System.Windows.Forms.GroupBox gbCmdAntDetector;
        private System.Windows.Forms.Button btnGetAntDetector;
        private System.Windows.Forms.Button btnSetAntDetector;
        private System.Windows.Forms.GroupBox gbCmdRegion;
        private System.Windows.Forms.Button btnGetFrequencyRegion;
        private System.Windows.Forms.Button btnSetFrequencyRegion;
        private System.Windows.Forms.GroupBox gbCmdOutputPower;
        private System.Windows.Forms.Button btnGetOutputPower;
        private System.Windows.Forms.Button btnSetOutputPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReaderSetupRefresh;
        private System.Windows.Forms.Button btRfSetup;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tbAntDectector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox cbRealWorkant1;
        private System.Windows.Forms.CheckBox cbRealWorkant4;
        private System.Windows.Forms.CheckBox cbRealWorkant3;
        private System.Windows.Forms.CheckBox cbRealWorkant2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Button btGetProfile;
        private System.Windows.Forms.Button btSetProfile;
        private System.Windows.Forms.RadioButton rdbProfile3;
        private System.Windows.Forms.RadioButton rdbProfile2;
        private System.Windows.Forms.RadioButton rdbProfile1;
        private System.Windows.Forms.RadioButton rdbProfile0;
        private System.Windows.Forms.CheckBox cbBufferWorkant1;
        private System.Windows.Forms.CheckBox cbBufferWorkant4;
        private System.Windows.Forms.CheckBox cbBufferWorkant2;
        private System.Windows.Forms.CheckBox cbBufferWorkant3;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textFreqQuantity;
        private System.Windows.Forms.TextBox TextFreqInterval;
        private System.Windows.Forms.TextBox textStartFreq;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbFrequencyEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFrequencyStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbRegionChn;
        private System.Windows.Forms.RadioButton rdbRegionEtsi;
        private System.Windows.Forms.RadioButton rdbRegionFcc;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cmbWorkAnt;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.CheckBox cbUserDefineFreq;
        private System.Windows.Forms.Timer timerInventory;

        private System.Windows.Forms.Timer totalTime;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox9;
        private CustomControl.HexTextBox hexTextBox9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox cbRealWorkant8;
        private System.Windows.Forms.CheckBox cbRealWorkant7;
        private System.Windows.Forms.CheckBox cbRealWorkant6;
        private System.Windows.Forms.CheckBox cbRealWorkant5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.RadioButton antType8;
        private System.Windows.Forms.RadioButton antType4;
        private System.Windows.Forms.RadioButton antType1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label m_sl_content;
        private System.Windows.Forms.TextBox m_session_max_q;
        private System.Windows.Forms.TextBox m_session_min_q;
        private System.Windows.Forms.TextBox m_session_start_q;
        private System.Windows.Forms.Label m_max_q_content;
        private System.Windows.Forms.Label m_min_q_content;
        private System.Windows.Forms.Label m_start_q_content;
        private System.Windows.Forms.ComboBox m_session_sl;
        private System.Windows.Forms.CheckBox m_session_q_cb;
        private System.Windows.Forms.CheckBox m_session_sl_cb;
        private System.Windows.Forms.RadioButton excel_format_rb;
        private System.Windows.Forms.RadioButton txt_format_rb;
        private RadioButton excel_format_buffer_rb;
        private RadioButton txt_format_buffer_rb;
        private RadioButton excel_format_fast_rb;
        private System.Windows.Forms.ListView lvFastList;
        private RadioButton txt_format_fast_rb;
        private Timer intervalExecuteTimer;
        private Timer mFastSessionTimer;
        private ImageList sortImageList;
        private RadioButton sessionInventoryrb;
        private RadioButton autoInventoryrb;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox mInventoryBStatusCount;
        private Label label126;
        private TextBox mInventoryAStatusCount;
        private Label label125;
        private Button ｍOneKeyInventory;
        private ComboBox mSessionExeTime;
        private Label Duration;
        private TextBox customizedExeTime;
        private Label label127;
        private TextBox m_intervalTimetb;
        private Label label128;
        private TextBox mTestTagCounts;
        private Label label129;
        private TextBox mFastExeCount;
        private TextBox mFastIntervalTime;
        private Label label132;
        private Label label131;
        private TextBox mPower5;
        private TextBox mPower4;
        private TextBox mPower3;
        private TextBox mPower2;
        private TextBox mPower1;
        private Label mReserve;
        private Timer mSendFastSwitchTimer;
        private SplitContainer splitContainer1;
        private GroupBox groupBox25;
        private GroupBox groupBox27;
        private GroupBox groupBox26;
        private GroupBox groupBox28;
        private TextBox m_new_fast_inventory_power2;
        private TextBox m_new_fast_inventory_power1;
        private TextBox m_new_fast_inventory_repeat2;
        private TextBox m_new_fast_inventory_repeat1;
        private Label mRepeatPower1;
        private Label mRepeatPower2;
        private Label mRepeat2;
        private Label mRepeat1;
        private CheckBox mDynamicPoll;
        private TextBox m_new_fast_inventory_target_count;
        private Label mTargetQuantity;
        private TextBox m_new_fast_inventory_continue;
        private Label mContiue;
        private TextBox m_new_fast_inventory_optimized;
        private Label mOpitimized;
        private CheckBox m_phase_value;
        private ComboBox m_new_fast_inventory_flag;
        private ComboBox m_new_fast_inventory_session;
        private CheckBox m_new_fast_inventory;
    }
}

