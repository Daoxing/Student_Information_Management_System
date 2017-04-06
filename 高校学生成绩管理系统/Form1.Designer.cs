namespace 高校学生成绩管理系统
{
    partial class MainInterface
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.tabControl_Main_container = new System.Windows.Forms.TabControl();
            this.Student_Info = new System.Windows.Forms.TabPage();
            this.textBox_Student_Class_No_Info = new System.Windows.Forms.TextBox();
            this.ShowBox = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Student_Race_Info = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Student_Birthday_Info = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Student_Gender_Info = new System.Windows.Forms.ComboBox();
            this.button_Student_Info_Delete_Data = new System.Windows.Forms.Button();
            this.button_Student_Info_Insert_Data = new System.Windows.Forms.Button();
            this.textBox_Student_Name_Info = new System.Windows.Forms.TextBox();
            this.textBox_Student_ID_Info = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBox_Student_Class_No_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Student_Class_No_Search = new System.Windows.Forms.Button();
            this.textBox_Student_Name_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Student_Name_Search = new System.Windows.Forms.Button();
            this.textBox_Student_ID_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Student_ID_Search = new System.Windows.Forms.Button();
            this.Course_Info = new System.Windows.Forms.TabPage();
            this.textBox_Course_Info_Course_Created_Time = new System.Windows.Forms.TextBox();
            this.button_Course_Info_Delete_Data = new System.Windows.Forms.Button();
            this.button_Course_Info_Insert_Data = new System.Windows.Forms.Button();
            this.dateTimePicker_Course_Info_Course_Created_Time = new System.Windows.Forms.DateTimePicker();
            this.textBox_Course_Info_Course_Time = new System.Windows.Forms.TextBox();
            this.textBox_Course_Info_Course_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Course_Info_Course_ID = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_Class_Info_Class_Created_Time = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Class_Info_Class_Created_Time = new System.Windows.Forms.DateTimePicker();
            this.button_Class_Info_Class_Delete_Data = new System.Windows.Forms.Button();
            this.button_Class_Info_Class_Insert_Data = new System.Windows.Forms.Button();
            this.textBox_Class_Info_Class_Name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_Class_Info_Class_ID = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker_Transcript_Info_Transcript_Created_Time = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_Transcript_Info_Student_Score = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_Transcript_Info_Class_ID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_Transcript_Info_Student_ID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button_Transcript_Info_Insert_Update_Data = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.button_Transcript_Info_Delete_Data = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox_Transcript_Info_Search_by_Class_ID = new System.Windows.Forms.ComboBox();
            this.comboBox_Transcript_Info_Search_by_Course_ID = new System.Windows.Forms.ComboBox();
            this.comboBox_Transcript_Info_Search_by_Student_Name = new System.Windows.Forms.ComboBox();
            this.comboBox_Transcript_Info_Search_by_Student_ID = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl_Main_container.SuspendLayout();
            this.Student_Info.SuspendLayout();
            this.Course_Info.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main_container
            // 
            this.tabControl_Main_container.Controls.Add(this.Student_Info);
            this.tabControl_Main_container.Controls.Add(this.Course_Info);
            this.tabControl_Main_container.Controls.Add(this.tabPage3);
            this.tabControl_Main_container.Controls.Add(this.tabPage4);
            this.tabControl_Main_container.Location = new System.Drawing.Point(2, 0);
            this.tabControl_Main_container.Name = "tabControl_Main_container";
            this.tabControl_Main_container.SelectedIndex = 0;
            this.tabControl_Main_container.Size = new System.Drawing.Size(993, 486);
            this.tabControl_Main_container.TabIndex = 0;
            this.tabControl_Main_container.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_container_SelectedIndexChanged);
            // 
            // Student_Info
            // 
            this.Student_Info.Controls.Add(this.textBox_Student_Class_No_Info);
            this.Student_Info.Controls.Add(this.ShowBox);
            this.Student_Info.Controls.Add(this.label10);
            this.Student_Info.Controls.Add(this.comboBox_Student_Race_Info);
            this.Student_Info.Controls.Add(this.dateTimePicker_Student_Birthday_Info);
            this.Student_Info.Controls.Add(this.comboBox_Student_Gender_Info);
            this.Student_Info.Controls.Add(this.button_Student_Info_Delete_Data);
            this.Student_Info.Controls.Add(this.button_Student_Info_Insert_Data);
            this.Student_Info.Controls.Add(this.textBox_Student_Name_Info);
            this.Student_Info.Controls.Add(this.textBox_Student_ID_Info);
            this.Student_Info.Controls.Add(this.label9);
            this.Student_Info.Controls.Add(this.label8);
            this.Student_Info.Controls.Add(this.label7);
            this.Student_Info.Controls.Add(this.label6);
            this.Student_Info.Controls.Add(this.label5);
            this.Student_Info.Controls.Add(this.label4);
            this.Student_Info.Controls.Add(this.label);
            this.Student_Info.Controls.Add(this.textBox_Student_Class_No_Search);
            this.Student_Info.Controls.Add(this.label3);
            this.Student_Info.Controls.Add(this.button_Student_Class_No_Search);
            this.Student_Info.Controls.Add(this.textBox_Student_Name_Search);
            this.Student_Info.Controls.Add(this.label2);
            this.Student_Info.Controls.Add(this.button_Student_Name_Search);
            this.Student_Info.Controls.Add(this.textBox_Student_ID_Search);
            this.Student_Info.Controls.Add(this.label1);
            this.Student_Info.Controls.Add(this.button_Student_ID_Search);
            this.Student_Info.Location = new System.Drawing.Point(4, 22);
            this.Student_Info.Name = "Student_Info";
            this.Student_Info.Padding = new System.Windows.Forms.Padding(3);
            this.Student_Info.Size = new System.Drawing.Size(985, 460);
            this.Student_Info.TabIndex = 0;
            this.Student_Info.Text = "学生信息";
            this.Student_Info.UseVisualStyleBackColor = true;
            // 
            // textBox_Student_Class_No_Info
            // 
            this.textBox_Student_Class_No_Info.Location = new System.Drawing.Point(116, 366);
            this.textBox_Student_Class_No_Info.Name = "textBox_Student_Class_No_Info";
            this.textBox_Student_Class_No_Info.Size = new System.Drawing.Size(145, 21);
            this.textBox_Student_Class_No_Info.TabIndex = 31;
            // 
            // ShowBox
            // 
            this.ShowBox.AutoSize = true;
            this.ShowBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowBox.Location = new System.Drawing.Point(470, 52);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(48, 16);
            this.ShowBox.TabIndex = 30;
            this.ShowBox.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "* 学号必填（如果删除信息只需要填写学号）";
            // 
            // comboBox_Student_Race_Info
            // 
            this.comboBox_Student_Race_Info.FormattingEnabled = true;
            this.comboBox_Student_Race_Info.Items.AddRange(new object[] {
            "蒙古族",
            "回族   ",
            "壮族  ",
            "维吾尔族 ",
            "藏族   ",
            "苗族   ",
            "彝族   ",
            "布依族  ",
            "朝鲜族  ",
            "满族   ",
            "侗族   ",
            "瑶族   ",
            "白族  ",
            "土家族  ",
            "哈尼族  ",
            "哈萨克族   ",
            "傣族   ",
            "黎族",
            "僳僳族  ",
            "佤族  ",
            "畲族  ",
            "拉祜族  ",
            "水族  ",
            "东乡族  ",
            "纳西族  ",
            "景颇族  ",
            "柯尔克孜族  ",
            "土族  ",
            "达斡尔族  ",
            "仫佬族  ",
            "仡佬族  ",
            "羌族  ",
            "锡伯族",
            "布朗族  ",
            "撒拉族  ",
            "毛南族  ",
            "阿昌族  ",
            "普米族  ",
            "塔吉克族  ",
            "怒族  ",
            "乌孜别克族  ",
            "俄罗斯族  ",
            "鄂温克族  ",
            "德昂族  ",
            "保安族  ",
            "裕固族  ",
            "京族  ",
            "基诺族  ",
            "高山族  ",
            "塔塔尔族  ",
            "独龙族  ",
            "鄂伦春族  ",
            "赫哲族  ",
            "门巴族  ",
            "珞巴族",
            "汉族"});
            this.comboBox_Student_Race_Info.Location = new System.Drawing.Point(116, 336);
            this.comboBox_Student_Race_Info.Name = "comboBox_Student_Race_Info";
            this.comboBox_Student_Race_Info.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Student_Race_Info.TabIndex = 27;
            // 
            // dateTimePicker_Student_Birthday_Info
            // 
            this.dateTimePicker_Student_Birthday_Info.Location = new System.Drawing.Point(116, 303);
            this.dateTimePicker_Student_Birthday_Info.Name = "dateTimePicker_Student_Birthday_Info";
            this.dateTimePicker_Student_Birthday_Info.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_Student_Birthday_Info.TabIndex = 26;
            // 
            // comboBox_Student_Gender_Info
            // 
            this.comboBox_Student_Gender_Info.FormattingEnabled = true;
            this.comboBox_Student_Gender_Info.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_Student_Gender_Info.Location = new System.Drawing.Point(116, 272);
            this.comboBox_Student_Gender_Info.Name = "comboBox_Student_Gender_Info";
            this.comboBox_Student_Gender_Info.Size = new System.Drawing.Size(32, 20);
            this.comboBox_Student_Gender_Info.TabIndex = 25;
            // 
            // button_Student_Info_Delete_Data
            // 
            this.button_Student_Info_Delete_Data.Location = new System.Drawing.Point(116, 408);
            this.button_Student_Info_Delete_Data.Name = "button_Student_Info_Delete_Data";
            this.button_Student_Info_Delete_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Student_Info_Delete_Data.TabIndex = 24;
            this.button_Student_Info_Delete_Data.Text = "删除信息";
            this.button_Student_Info_Delete_Data.UseVisualStyleBackColor = true;
            this.button_Student_Info_Delete_Data.Click += new System.EventHandler(this.button_Student_Info_Delete_Data_Click);
            // 
            // button_Student_Info_Insert_Data
            // 
            this.button_Student_Info_Insert_Data.Location = new System.Drawing.Point(32, 408);
            this.button_Student_Info_Insert_Data.Name = "button_Student_Info_Insert_Data";
            this.button_Student_Info_Insert_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Student_Info_Insert_Data.TabIndex = 22;
            this.button_Student_Info_Insert_Data.Text = "插入信息";
            this.button_Student_Info_Insert_Data.UseVisualStyleBackColor = true;
            this.button_Student_Info_Insert_Data.Click += new System.EventHandler(this.button_Student_Info_Insert_Data_Click);
            // 
            // textBox_Student_Name_Info
            // 
            this.textBox_Student_Name_Info.Location = new System.Drawing.Point(116, 242);
            this.textBox_Student_Name_Info.Name = "textBox_Student_Name_Info";
            this.textBox_Student_Name_Info.Size = new System.Drawing.Size(145, 21);
            this.textBox_Student_Name_Info.TabIndex = 17;
            // 
            // textBox_Student_ID_Info
            // 
            this.textBox_Student_ID_Info.Location = new System.Drawing.Point(116, 210);
            this.textBox_Student_ID_Info.Name = "textBox_Student_ID_Info";
            this.textBox_Student_ID_Info.Size = new System.Drawing.Size(145, 21);
            this.textBox_Student_ID_Info.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "班级编号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "民族：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "出生日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "学号：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(415, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 25);
            this.label.TabIndex = 9;
            this.label.Text = "结果:";
            // 
            // textBox_Student_Class_No_Search
            // 
            this.textBox_Student_Class_No_Search.Location = new System.Drawing.Point(52, 138);
            this.textBox_Student_Class_No_Search.Name = "textBox_Student_Class_No_Search";
            this.textBox_Student_Class_No_Search.Size = new System.Drawing.Size(210, 21);
            this.textBox_Student_Class_No_Search.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "班级:";
            // 
            // button_Student_Class_No_Search
            // 
            this.button_Student_Class_No_Search.Location = new System.Drawing.Point(268, 136);
            this.button_Student_Class_No_Search.Name = "button_Student_Class_No_Search";
            this.button_Student_Class_No_Search.Size = new System.Drawing.Size(128, 23);
            this.button_Student_Class_No_Search.TabIndex = 6;
            this.button_Student_Class_No_Search.Text = "按班级搜索";
            this.button_Student_Class_No_Search.UseVisualStyleBackColor = true;
            this.button_Student_Class_No_Search.Click += new System.EventHandler(this.button_Student_Class_No_Search_Click);
            // 
            // textBox_Student_Name_Search
            // 
            this.textBox_Student_Name_Search.Location = new System.Drawing.Point(52, 80);
            this.textBox_Student_Name_Search.Name = "textBox_Student_Name_Search";
            this.textBox_Student_Name_Search.Size = new System.Drawing.Size(210, 21);
            this.textBox_Student_Name_Search.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名:";
            // 
            // button_Student_Name_Search
            // 
            this.button_Student_Name_Search.Location = new System.Drawing.Point(268, 78);
            this.button_Student_Name_Search.Name = "button_Student_Name_Search";
            this.button_Student_Name_Search.Size = new System.Drawing.Size(128, 23);
            this.button_Student_Name_Search.TabIndex = 3;
            this.button_Student_Name_Search.Text = "按姓名搜索";
            this.button_Student_Name_Search.UseVisualStyleBackColor = true;
            this.button_Student_Name_Search.Click += new System.EventHandler(this.button_Student_Name_Search_Click);
            // 
            // textBox_Student_ID_Search
            // 
            this.textBox_Student_ID_Search.Location = new System.Drawing.Point(52, 27);
            this.textBox_Student_ID_Search.Name = "textBox_Student_ID_Search";
            this.textBox_Student_ID_Search.Size = new System.Drawing.Size(210, 21);
            this.textBox_Student_ID_Search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号:";
            // 
            // button_Student_ID_Search
            // 
            this.button_Student_ID_Search.Location = new System.Drawing.Point(268, 25);
            this.button_Student_ID_Search.Name = "button_Student_ID_Search";
            this.button_Student_ID_Search.Size = new System.Drawing.Size(128, 23);
            this.button_Student_ID_Search.TabIndex = 0;
            this.button_Student_ID_Search.Text = "按学号搜索";
            this.button_Student_ID_Search.UseVisualStyleBackColor = true;
            this.button_Student_ID_Search.Click += new System.EventHandler(this.button_Student_ID_Search_Click);
            // 
            // Course_Info
            // 
            this.Course_Info.Controls.Add(this.textBox_Course_Info_Course_Created_Time);
            this.Course_Info.Controls.Add(this.button_Course_Info_Delete_Data);
            this.Course_Info.Controls.Add(this.button_Course_Info_Insert_Data);
            this.Course_Info.Controls.Add(this.dateTimePicker_Course_Info_Course_Created_Time);
            this.Course_Info.Controls.Add(this.textBox_Course_Info_Course_Time);
            this.Course_Info.Controls.Add(this.textBox_Course_Info_Course_Name);
            this.Course_Info.Controls.Add(this.label14);
            this.Course_Info.Controls.Add(this.label13);
            this.Course_Info.Controls.Add(this.label12);
            this.Course_Info.Controls.Add(this.label11);
            this.Course_Info.Controls.Add(this.comboBox_Course_Info_Course_ID);
            this.Course_Info.Location = new System.Drawing.Point(4, 22);
            this.Course_Info.Name = "Course_Info";
            this.Course_Info.Padding = new System.Windows.Forms.Padding(3);
            this.Course_Info.Size = new System.Drawing.Size(985, 460);
            this.Course_Info.TabIndex = 1;
            this.Course_Info.Text = "课程信息";
            this.Course_Info.UseVisualStyleBackColor = true;
            // 
            // textBox_Course_Info_Course_Created_Time
            // 
            this.textBox_Course_Info_Course_Created_Time.Location = new System.Drawing.Point(125, 154);
            this.textBox_Course_Info_Course_Created_Time.Name = "textBox_Course_Info_Course_Created_Time";
            this.textBox_Course_Info_Course_Created_Time.Size = new System.Drawing.Size(121, 21);
            this.textBox_Course_Info_Course_Created_Time.TabIndex = 11;
            // 
            // button_Course_Info_Delete_Data
            // 
            this.button_Course_Info_Delete_Data.Location = new System.Drawing.Point(218, 223);
            this.button_Course_Info_Delete_Data.Name = "button_Course_Info_Delete_Data";
            this.button_Course_Info_Delete_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Course_Info_Delete_Data.TabIndex = 9;
            this.button_Course_Info_Delete_Data.Text = "删除数据";
            this.button_Course_Info_Delete_Data.UseVisualStyleBackColor = true;
            this.button_Course_Info_Delete_Data.Click += new System.EventHandler(this.button_Course_Info_Delete_Data_Click);
            // 
            // button_Course_Info_Insert_Data
            // 
            this.button_Course_Info_Insert_Data.Location = new System.Drawing.Point(125, 223);
            this.button_Course_Info_Insert_Data.Name = "button_Course_Info_Insert_Data";
            this.button_Course_Info_Insert_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Course_Info_Insert_Data.TabIndex = 8;
            this.button_Course_Info_Insert_Data.Text = "插入数据";
            this.button_Course_Info_Insert_Data.UseVisualStyleBackColor = true;
            this.button_Course_Info_Insert_Data.Click += new System.EventHandler(this.button_Course_Info_Insert_Data_Click);
            // 
            // dateTimePicker_Course_Info_Course_Created_Time
            // 
            this.dateTimePicker_Course_Info_Course_Created_Time.Enabled = false;
            this.dateTimePicker_Course_Info_Course_Created_Time.Location = new System.Drawing.Point(125, 157);
            this.dateTimePicker_Course_Info_Course_Created_Time.Name = "dateTimePicker_Course_Info_Course_Created_Time";
            this.dateTimePicker_Course_Info_Course_Created_Time.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_Course_Info_Course_Created_Time.TabIndex = 7;
            this.dateTimePicker_Course_Info_Course_Created_Time.Visible = false;
            // 
            // textBox_Course_Info_Course_Time
            // 
            this.textBox_Course_Info_Course_Time.Location = new System.Drawing.Point(125, 121);
            this.textBox_Course_Info_Course_Time.Name = "textBox_Course_Info_Course_Time";
            this.textBox_Course_Info_Course_Time.Size = new System.Drawing.Size(121, 21);
            this.textBox_Course_Info_Course_Time.TabIndex = 6;
            // 
            // textBox_Course_Info_Course_Name
            // 
            this.textBox_Course_Info_Course_Name.Location = new System.Drawing.Point(125, 79);
            this.textBox_Course_Info_Course_Name.Name = "textBox_Course_Info_Course_Name";
            this.textBox_Course_Info_Course_Name.Size = new System.Drawing.Size(121, 21);
            this.textBox_Course_Info_Course_Name.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "创建时间:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "课时:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "课程名:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "课程编号:";
            // 
            // comboBox_Course_Info_Course_ID
            // 
            this.comboBox_Course_Info_Course_ID.FormattingEnabled = true;
            this.comboBox_Course_Info_Course_ID.Location = new System.Drawing.Point(125, 41);
            this.comboBox_Course_Info_Course_ID.Name = "comboBox_Course_Info_Course_ID";
            this.comboBox_Course_Info_Course_ID.Size = new System.Drawing.Size(224, 20);
            this.comboBox_Course_Info_Course_ID.TabIndex = 0;
            this.comboBox_Course_Info_Course_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_Info_Course_ID_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_Class_Info_Class_Created_Time);
            this.tabPage3.Controls.Add(this.dateTimePicker_Class_Info_Class_Created_Time);
            this.tabPage3.Controls.Add(this.button_Class_Info_Class_Delete_Data);
            this.tabPage3.Controls.Add(this.button_Class_Info_Class_Insert_Data);
            this.tabPage3.Controls.Add(this.textBox_Class_Info_Class_Name);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboBox_Class_Info_Class_ID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(985, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "班级信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_Class_Info_Class_Created_Time
            // 
            this.textBox_Class_Info_Class_Created_Time.Location = new System.Drawing.Point(124, 114);
            this.textBox_Class_Info_Class_Created_Time.Name = "textBox_Class_Info_Class_Created_Time";
            this.textBox_Class_Info_Class_Created_Time.Size = new System.Drawing.Size(121, 21);
            this.textBox_Class_Info_Class_Created_Time.TabIndex = 16;
            // 
            // dateTimePicker_Class_Info_Class_Created_Time
            // 
            this.dateTimePicker_Class_Info_Class_Created_Time.Location = new System.Drawing.Point(124, 116);
            this.dateTimePicker_Class_Info_Class_Created_Time.Name = "dateTimePicker_Class_Info_Class_Created_Time";
            this.dateTimePicker_Class_Info_Class_Created_Time.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_Class_Info_Class_Created_Time.TabIndex = 15;
            // 
            // button_Class_Info_Class_Delete_Data
            // 
            this.button_Class_Info_Class_Delete_Data.Location = new System.Drawing.Point(240, 209);
            this.button_Class_Info_Class_Delete_Data.Name = "button_Class_Info_Class_Delete_Data";
            this.button_Class_Info_Class_Delete_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Class_Info_Class_Delete_Data.TabIndex = 14;
            this.button_Class_Info_Class_Delete_Data.Text = "删除数据";
            this.button_Class_Info_Class_Delete_Data.UseVisualStyleBackColor = true;
            this.button_Class_Info_Class_Delete_Data.Click += new System.EventHandler(this.button_Class_Info_Class_Delete_Data_Click);
            // 
            // button_Class_Info_Class_Insert_Data
            // 
            this.button_Class_Info_Class_Insert_Data.Location = new System.Drawing.Point(124, 209);
            this.button_Class_Info_Class_Insert_Data.Name = "button_Class_Info_Class_Insert_Data";
            this.button_Class_Info_Class_Insert_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Class_Info_Class_Insert_Data.TabIndex = 13;
            this.button_Class_Info_Class_Insert_Data.Text = "插入数据";
            this.button_Class_Info_Class_Insert_Data.UseVisualStyleBackColor = true;
            this.button_Class_Info_Class_Insert_Data.Click += new System.EventHandler(this.button_Class_Info_Class_Insert_Data_Click);
            // 
            // textBox_Class_Info_Class_Name
            // 
            this.textBox_Class_Info_Class_Name.Location = new System.Drawing.Point(124, 77);
            this.textBox_Class_Info_Class_Name.Name = "textBox_Class_Info_Class_Name";
            this.textBox_Class_Info_Class_Name.Size = new System.Drawing.Size(121, 21);
            this.textBox_Class_Info_Class_Name.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "创建时间:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "班级名称:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 8;
            this.label17.Text = "班级编号:";
            // 
            // comboBox_Class_Info_Class_ID
            // 
            this.comboBox_Class_Info_Class_ID.FormattingEnabled = true;
            this.comboBox_Class_Info_Class_ID.Location = new System.Drawing.Point(124, 39);
            this.comboBox_Class_Info_Class_ID.Name = "comboBox_Class_Info_Class_ID";
            this.comboBox_Class_Info_Class_ID.Size = new System.Drawing.Size(138, 20);
            this.comboBox_Class_Info_Class_ID.TabIndex = 7;
            this.comboBox_Class_Info_Class_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Class_Info_Class_ID_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dateTimePicker_Transcript_Info_Transcript_Created_Time);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.textBox_Transcript_Info_Student_Score);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.textBox_Transcript_Info_Class_ID);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.textBox_Transcript_Info_Student_ID);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.button_Transcript_Info_Insert_Update_Data);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.button_Transcript_Info_Delete_Data);
            this.tabPage4.Controls.Add(this.Result);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.comboBox_Transcript_Info_Search_by_Class_ID);
            this.tabPage4.Controls.Add(this.comboBox_Transcript_Info_Search_by_Course_ID);
            this.tabPage4.Controls.Add(this.comboBox_Transcript_Info_Search_by_Student_Name);
            this.tabPage4.Controls.Add(this.comboBox_Transcript_Info_Search_by_Student_ID);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(985, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "学生成绩";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Transcript_Info_Transcript_Created_Time
            // 
            this.dateTimePicker_Transcript_Info_Transcript_Created_Time.Location = new System.Drawing.Point(119, 374);
            this.dateTimePicker_Transcript_Info_Transcript_Created_Time.Name = "dateTimePicker_Transcript_Info_Transcript_Created_Time";
            this.dateTimePicker_Transcript_Info_Transcript_Created_Time.Size = new System.Drawing.Size(111, 21);
            this.dateTimePicker_Transcript_Info_Transcript_Created_Time.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(40, 374);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 23;
            this.label27.Text = "创建日期：";
            // 
            // textBox_Transcript_Info_Student_Score
            // 
            this.textBox_Transcript_Info_Student_Score.Location = new System.Drawing.Point(119, 337);
            this.textBox_Transcript_Info_Student_Score.Name = "textBox_Transcript_Info_Student_Score";
            this.textBox_Transcript_Info_Student_Score.Size = new System.Drawing.Size(100, 21);
            this.textBox_Transcript_Info_Student_Score.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(40, 340);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 21;
            this.label26.Text = "分数：";
            // 
            // textBox_Transcript_Info_Class_ID
            // 
            this.textBox_Transcript_Info_Class_ID.Location = new System.Drawing.Point(119, 297);
            this.textBox_Transcript_Info_Class_ID.Name = "textBox_Transcript_Info_Class_ID";
            this.textBox_Transcript_Info_Class_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_Transcript_Info_Class_ID.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 300);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 19;
            this.label25.Text = "课程编号：";
            // 
            // textBox_Transcript_Info_Student_ID
            // 
            this.textBox_Transcript_Info_Student_ID.Location = new System.Drawing.Point(119, 260);
            this.textBox_Transcript_Info_Student_ID.Name = "textBox_Transcript_Info_Student_ID";
            this.textBox_Transcript_Info_Student_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_Transcript_Info_Student_ID.TabIndex = 18;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 263);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 17;
            this.label24.Text = "学号：";
            // 
            // button_Transcript_Info_Insert_Update_Data
            // 
            this.button_Transcript_Info_Insert_Update_Data.Location = new System.Drawing.Point(78, 410);
            this.button_Transcript_Info_Insert_Update_Data.Name = "button_Transcript_Info_Insert_Update_Data";
            this.button_Transcript_Info_Insert_Update_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Transcript_Info_Insert_Update_Data.TabIndex = 16;
            this.button_Transcript_Info_Insert_Update_Data.Text = "插入/更新";
            this.button_Transcript_Info_Insert_Update_Data.UseVisualStyleBackColor = true;
            this.button_Transcript_Info_Insert_Update_Data.Click += new System.EventHandler(this.button_Transcript_Info_Insert_Update_Data_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(354, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 15;
            this.label23.Text = "*学号必填";
            // 
            // button_Transcript_Info_Delete_Data
            // 
            this.button_Transcript_Info_Delete_Data.Location = new System.Drawing.Point(347, 52);
            this.button_Transcript_Info_Delete_Data.Name = "button_Transcript_Info_Delete_Data";
            this.button_Transcript_Info_Delete_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Transcript_Info_Delete_Data.TabIndex = 14;
            this.button_Transcript_Info_Delete_Data.Text = "删除";
            this.button_Transcript_Info_Delete_Data.UseVisualStyleBackColor = true;
            this.button_Transcript_Info_Delete_Data.Click += new System.EventHandler(this.button_Transcript_Info_Delete_Data_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(440, 37);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(53, 12);
            this.Result.TabIndex = 13;
            this.Result.Text = "        ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(369, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 12;
            this.label22.Text = "搜索结果：";
            // 
            // comboBox_Transcript_Info_Search_by_Class_ID
            // 
            this.comboBox_Transcript_Info_Search_by_Class_ID.FormattingEnabled = true;
            this.comboBox_Transcript_Info_Search_by_Class_ID.Location = new System.Drawing.Point(78, 182);
            this.comboBox_Transcript_Info_Search_by_Class_ID.Name = "comboBox_Transcript_Info_Search_by_Class_ID";
            this.comboBox_Transcript_Info_Search_by_Class_ID.Size = new System.Drawing.Size(213, 20);
            this.comboBox_Transcript_Info_Search_by_Class_ID.TabIndex = 11;
            this.comboBox_Transcript_Info_Search_by_Class_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Transcript_Info_Search_by_Class_ID_SelectedIndexChanged);
            // 
            // comboBox_Transcript_Info_Search_by_Course_ID
            // 
            this.comboBox_Transcript_Info_Search_by_Course_ID.FormattingEnabled = true;
            this.comboBox_Transcript_Info_Search_by_Course_ID.Location = new System.Drawing.Point(78, 132);
            this.comboBox_Transcript_Info_Search_by_Course_ID.Name = "comboBox_Transcript_Info_Search_by_Course_ID";
            this.comboBox_Transcript_Info_Search_by_Course_ID.Size = new System.Drawing.Size(213, 20);
            this.comboBox_Transcript_Info_Search_by_Course_ID.TabIndex = 10;
            this.comboBox_Transcript_Info_Search_by_Course_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Transcript_Info_Search_by_Course_ID_SelectedIndexChanged);
            // 
            // comboBox_Transcript_Info_Search_by_Student_Name
            // 
            this.comboBox_Transcript_Info_Search_by_Student_Name.FormattingEnabled = true;
            this.comboBox_Transcript_Info_Search_by_Student_Name.Location = new System.Drawing.Point(78, 82);
            this.comboBox_Transcript_Info_Search_by_Student_Name.Name = "comboBox_Transcript_Info_Search_by_Student_Name";
            this.comboBox_Transcript_Info_Search_by_Student_Name.Size = new System.Drawing.Size(213, 20);
            this.comboBox_Transcript_Info_Search_by_Student_Name.TabIndex = 9;
            this.comboBox_Transcript_Info_Search_by_Student_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox_Transcript_Info_Search_by_Student_Name_SelectedIndexChanged);
            // 
            // comboBox_Transcript_Info_Search_by_Student_ID
            // 
            this.comboBox_Transcript_Info_Search_by_Student_ID.FormattingEnabled = true;
            this.comboBox_Transcript_Info_Search_by_Student_ID.Location = new System.Drawing.Point(78, 37);
            this.comboBox_Transcript_Info_Search_by_Student_ID.Name = "comboBox_Transcript_Info_Search_by_Student_ID";
            this.comboBox_Transcript_Info_Search_by_Student_ID.Size = new System.Drawing.Size(213, 20);
            this.comboBox_Transcript_Info_Search_by_Student_ID.TabIndex = 8;
            this.comboBox_Transcript_Info_Search_by_Student_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Transcript_Info_Search_by_Student_ID_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "班级：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 5;
            this.label20.Text = "课程：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 3;
            this.label19.Text = "姓名：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "学号：";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 485);
            this.Controls.Add(this.tabControl_Main_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.Text = "高校学生成绩管理系统";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.tabControl_Main_container.ResumeLayout(false);
            this.Student_Info.ResumeLayout(false);
            this.Student_Info.PerformLayout();
            this.Course_Info.ResumeLayout(false);
            this.Course_Info.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main_container;
        private System.Windows.Forms.TabPage Student_Info;
        private System.Windows.Forms.TextBox textBox_Student_Class_No_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Student_Class_No_Search;
        private System.Windows.Forms.TextBox textBox_Student_Name_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Student_Name_Search;
        private System.Windows.Forms.TextBox textBox_Student_ID_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Student_ID_Search;
        private System.Windows.Forms.TabPage Course_Info;
        private System.Windows.Forms.Button button_Student_Info_Delete_Data;
        private System.Windows.Forms.Button button_Student_Info_Insert_Data;
        private System.Windows.Forms.TextBox textBox_Student_Name_Info;
        private System.Windows.Forms.TextBox textBox_Student_ID_Info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Student_Race_Info;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Student_Birthday_Info;
        private System.Windows.Forms.ComboBox comboBox_Student_Gender_Info;
        private System.Windows.Forms.Label ShowBox;
        private System.Windows.Forms.TextBox textBox_Student_Class_No_Info;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_Course_Info_Course_ID;
        private System.Windows.Forms.Button button_Course_Info_Delete_Data;
        private System.Windows.Forms.Button button_Course_Info_Insert_Data;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Course_Info_Course_Created_Time;
        private System.Windows.Forms.TextBox textBox_Course_Info_Course_Time;
        private System.Windows.Forms.TextBox textBox_Course_Info_Course_Name;
        private System.Windows.Forms.TextBox textBox_Course_Info_Course_Created_Time;
        private System.Windows.Forms.TextBox textBox_Class_Info_Class_Name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_Class_Info_Class_ID;
        private System.Windows.Forms.Button button_Class_Info_Class_Delete_Data;
        private System.Windows.Forms.Button button_Class_Info_Class_Insert_Data;
        private System.Windows.Forms.TextBox textBox_Class_Info_Class_Created_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Class_Info_Class_Created_Time;
        private System.Windows.Forms.Button button_Transcript_Info_Delete_Data;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox_Transcript_Info_Search_by_Class_ID;
        private System.Windows.Forms.ComboBox comboBox_Transcript_Info_Search_by_Course_ID;
        private System.Windows.Forms.ComboBox comboBox_Transcript_Info_Search_by_Student_Name;
        private System.Windows.Forms.ComboBox comboBox_Transcript_Info_Search_by_Student_ID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_Transcript_Info_Insert_Update_Data;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_Transcript_Info_Student_ID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Transcript_Info_Transcript_Created_Time;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_Transcript_Info_Student_Score;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_Transcript_Info_Class_ID;
    }
}

