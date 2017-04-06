using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace 高校学生成绩管理系统
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }
        string strcon; //声明连接字串
        OleDbConnection oledbcon;

        private void MainInterface_Load(object sender, EventArgs e)
        {

            strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Management_Database.accdb";
            //strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Management_Database.accdb";
            oledbcon = new OleDbConnection(strcon);//实例化数据库连接
            try
            {
                oledbcon.Open(); //打开 SQL 连接 
                //MessageBox.Show("连接到数据库\r\n");
            }
            catch(Exception ex)
            {

                if (MessageBox.Show("无法连接数据库Microsoft.ACE.OLEDB.12.0\r\n" + ex.ToString()) == DialogResult.OK)
                {
                    Application.Exit();
                }; 
                
               //提示失败信息
                //MessageBox.Show("无法连接数据库Microsoft.Jet.OLEDB.4.0\r\n"); Application.Exit(); //提示失败信息
            }            
        }

        private void button_Student_ID_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Student_ID_Search.Text.ToString()=="")
            { MessageBox.Show("大哥，虽然我是电脑，但也不能这样玩我。你什么都没填让我怎么查！！！"); return; }
            OleDbDataAdapter oledbda =
                new OleDbDataAdapter
                    ("select * from Student_Info where Student_ID='" + textBox_Student_ID_Search.Text.ToString() + "'", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Student_Info"); //Fill 方法填充
            ShowBox.Text = "";
            if (ds.Tables["Student_Info"].Rows.Count == 0) { MessageBox.Show("亲！没有 " + textBox_Student_ID_Search.Text.ToString() + " 学号的学生"); return; }
            for (int i = 0; i < ds.Tables["Student_Info"].Rows.Count; i++)
            {
                ShowBox.Text += "学号：  " + ds.Tables["Student_Info"].Rows[i]["Student_ID"].ToString() + "\r\n" +
                             "姓名：  " + ds.Tables["Student_Info"].Rows[i]["Student_Name"].ToString() + "\r\n" +
                             "性别：  " + ds.Tables["Student_Info"].Rows[i]["Student_Gender"].ToString() + "\r\n" +
                             "出生日期：  " + ds.Tables["Student_Info"].Rows[i]["Student_Birthday"].ToString() + "\r\n" +
                             "民族：  " + ds.Tables["Student_Info"].Rows[i]["Student_Race"].ToString() + "\r\n" +
                             "班级编号：  " + ds.Tables["Student_Info"].Rows[i]["Student_Class_No"].ToString() + "\r\n\r\n\r\n";
            }
        }

        private void button_Student_Name_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Student_Name_Search.Text.ToString() == "")
            { MessageBox.Show("大哥，虽然我是电脑，但也不能这样玩我。你什么都没填让我怎么查！！！"); return; }
            OleDbDataAdapter oledbda =
                new OleDbDataAdapter
                    ("select * from Student_Info where Student_Name='" + textBox_Student_Name_Search.Text.ToString() + "'", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Student_Info"); //Fill 方法填充
            ShowBox.Text = "";
            if (ds.Tables["Student_Info"].Rows.Count == 0) { MessageBox.Show("亲！没有叫 " + textBox_Student_Name_Search.Text.ToString() + " 的学生"); return; }
            for (int i = 0; i < ds.Tables["Student_Info"].Rows.Count; i++)
            {
                ShowBox.Text += "学号：  " + ds.Tables["Student_Info"].Rows[i]["Student_ID"].ToString() + "\r\n" +
                             "姓名：  " + ds.Tables["Student_Info"].Rows[i]["Student_Name"].ToString() + "\r\n" +
                             "性别：  " + ds.Tables["Student_Info"].Rows[i]["Student_Gender"].ToString() + "\r\n" +
                             "出生日期：  " + ds.Tables["Student_Info"].Rows[i]["Student_Birthday"].ToString() + "\r\n" +
                             "民族：  " + ds.Tables["Student_Info"].Rows[i]["Student_Race"].ToString() + "\r\n" +
                             "班级编号：  " + ds.Tables["Student_Info"].Rows[i]["Student_Class_No"].ToString() + "\r\n\r\n\r\n";
            }
        }

        private void button_Student_Class_No_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Student_Class_No_Search.Text.ToString() == "")
            { MessageBox.Show("大哥，虽然我是电脑，但也不能这样玩我。你什么都没填让我怎么查！！！"); return; }
            OleDbDataAdapter oledbda =
                new OleDbDataAdapter
                    ("select * from Student_Info where Student_Class_No='" + textBox_Student_Class_No_Search.Text.ToString() + "'", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Student_Info"); //Fill 方法填充
            ShowBox.Text = "";
            if (ds.Tables["Student_Info"].Rows.Count == 0) { MessageBox.Show("亲！没有 " + textBox_Student_Class_No_Search.Text.ToString() + " 这个班级"); return; }
            for (int i = 0; i < ds.Tables["Student_Info"].Rows.Count; i++)
            {
                ShowBox.Text += "学号：  " + ds.Tables["Student_Info"].Rows[i]["Student_ID"].ToString() + "\r\n" +
                             "姓名：  " + ds.Tables["Student_Info"].Rows[i]["Student_Name"].ToString() + "\r\n" +
                             "性别：  " + ds.Tables["Student_Info"].Rows[i]["Student_Gender"].ToString() + "\r\n" +
                             "出生日期：  " + ds.Tables["Student_Info"].Rows[i]["Student_Birthday"].ToString() + "\r\n" +
                             "民族：  " + ds.Tables["Student_Info"].Rows[i]["Student_Race"].ToString() + "\r\n" +
                             "班级编号：  " + ds.Tables["Student_Info"].Rows[i]["Student_Class_No"].ToString() + "\r\n\r\n\r\n";
            }
        }

        private void button_Student_Info_Insert_Data_Click(object sender, EventArgs e)
        {
            if (textBox_Student_ID_Info.Text.ToString() == "")
            { MessageBox.Show("跟你说了学号是必填，你耳朵塞了驴毛啦！！！"); return; }
            try
            {
                OleDbDataAdapter oledbda =
               new OleDbDataAdapter
                   ("select * from Student_Info where Student_ID='" + textBox_Student_ID_Info.Text.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Student_Info"); //Fill 方法填充
                if (ds.Tables["Student_Info"].Rows.Count == 0)
                {
                    string cmdstring =
                        "insert into Student_Info values('"
                        + textBox_Student_ID_Info.Text.ToString() + "','"
                        + textBox_Student_Name_Info.Text.ToString() +"','"
                        + comboBox_Student_Gender_Info.SelectedItem.ToString() + "','"
                        + dateTimePicker_Student_Birthday_Info.Value.Date.ToString() + "','"
                        + comboBox_Student_Race_Info.SelectedItem.ToString() + "','"
                        + textBox_Student_Class_No_Info.Text.ToString() + "')";
                    OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
                    olecmd.ExecuteNonQuery();
                    MessageBox.Show("插入完毕！！！"); 
                }
                else
                {
                    DialogResult MsgBoxResult;//设置对话框的返回值
                    MsgBoxResult = MessageBox.Show("哥们儿，你输入的学号已经存在了。如果你点了确定，那就会把已经存在的数据给改了。Are you sure about that?",//对话框的显示内容
                    "提示",//对话框的标题
                    MessageBoxButtons.YesNo,//定义对话框的按钮，这里定义了YSE和NO两个按钮
                    MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号
                    MessageBoxDefaultButton.Button2);//定义对话框的按钮式样
                    
                    if (MsgBoxResult == DialogResult.No)//如果对话框的返回值是NO（按"N"按钮）
                    {
                        return;
                    }
                    string cmdstring=null;
                    OleDbCommand olecmd; 
                    if (textBox_Student_Name_Info.Text.ToString()!="")
                    {
                        cmdstring =
                        "update  Student_Info set Student_Name= '"
                        + textBox_Student_Name_Info.Text.ToString() + "' where Student_ID='"
                        + textBox_Student_ID_Info.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    if (comboBox_Student_Gender_Info.SelectedItem.ToString() != "")
                    {
                        cmdstring =
                        "update  Student_Info set Student_Gender= '"
                        + comboBox_Student_Gender_Info.SelectedItem.ToString() + "' where Student_ID='"
                        + textBox_Student_ID_Info.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    if (dateTimePicker_Student_Birthday_Info.Value.Date.ToString() != "")
                    {
                        cmdstring =
                        "update  Student_Info set Student_Birthday= '"
                        + dateTimePicker_Student_Birthday_Info.Value.Date.ToString() + "' where Student_ID='"
                        + textBox_Student_ID_Info.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    if (comboBox_Student_Race_Info.SelectedItem.ToString() != "")
                    {
                        cmdstring =
                        "update  Student_Info set Student_Race= '"
                        + comboBox_Student_Race_Info.SelectedItem.ToString() + "' where Student_ID='"
                        + textBox_Student_ID_Info.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    if (textBox_Student_Class_No_Info.Text.ToString() != "")
                    {
                        cmdstring =
                        "update  Student_Info set Student_Class_No= '"
                        + textBox_Student_Class_No_Info.Text.ToString() + "' where Student_ID='"
                        + textBox_Student_ID_Info.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("更新完毕！！！"); 
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button_Student_Info_Delete_Data_Click(object sender, EventArgs e)
        {
            if (textBox_Student_ID_Info.Text.ToString() == "")
            { MessageBox.Show("跟你说了学号是必填，你耳朵塞了驴毛啦！！！"); return; }
            try
            {
             string cmdstring = null;
             OleDbCommand olecmd;
             cmdstring =
             "delete from Student_Info where Student_ID='"
             + textBox_Student_ID_Info.Text.ToString() + "'";
             olecmd = new OleDbCommand(cmdstring, oledbcon);
             olecmd.ExecuteNonQuery();
             MessageBox.Show("删完了！！！"); 
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        
        private void tabControl_Main_container_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Main_container.SelectedIndex == 1) 
            {
                OleDbDataAdapter oledbda =
               new OleDbDataAdapter
                   ("select * from Course_Info ", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Course_Info"); //Fill 方法填充
                for (int i = 0; i < ds.Tables["Course_Info"].Rows.Count; i++) 
                {
                   comboBox_Course_Info_Course_ID.Items.Add(ds.Tables["Course_Info"].Rows[i]["Course_ID"].ToString());
                }
                comboBox_Course_Info_Course_ID.Items.Add("如果想添加课程,点这里。还有，请输入新的课程名。");
            }

            if (tabControl_Main_container.SelectedIndex == 2)
            {
                OleDbDataAdapter oledbda =
               new OleDbDataAdapter
                   ("select * from Class_Info ", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Class_Info"); //Fill 方法填充
                for (int i = 0; i < ds.Tables["Class_Info"].Rows.Count; i++)
                {
                    comboBox_Class_Info_Class_ID.Items.Add(ds.Tables["Class_Info"].Rows[i]["Class_ID"].ToString());
                }
                comboBox_Class_Info_Class_ID.Items.Add("如果想添加班级,点这里。还有，请输入新的课程名。");
            }

            if (tabControl_Main_container.SelectedIndex == 3)
            {
                {
                    OleDbDataAdapter oledbda =
                   new OleDbDataAdapter
                       ("select * from Transcript_Info ", oledbcon);
                    if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                    DataSet ds = new DataSet(); //创建数据集
                    oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充
                    for (int i = 0; i < ds.Tables["Transcript_Info"].Rows.Count; i++)
                    {
                        comboBox_Transcript_Info_Search_by_Student_ID.Items.Add(ds.Tables["Transcript_Info"].Rows[i]["Student_ID"].ToString());
                    }
                }

                {
                    OleDbDataAdapter oledbda =
                   new OleDbDataAdapter
                       ("select * from Student_Info where Student_ID in (select Student_ID from Transcript_Info)", oledbcon);
                    if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                    DataSet ds = new DataSet(); //创建数据集
                    oledbda.Fill(ds, "Student_Info"); //Fill 方法填充
                    for (int i = 0; i < ds.Tables["Student_Info"].Rows.Count; i++)
                    {
                        comboBox_Transcript_Info_Search_by_Student_Name.Items.Add(ds.Tables["Student_Info"].Rows[i]["Student_Name"].ToString());
                    }
                }

                {
                    OleDbDataAdapter oledbda =
                   new OleDbDataAdapter
                       ("select * from Course_Info ", oledbcon);
                    if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                    DataSet ds = new DataSet(); //创建数据集
                    oledbda.Fill(ds, "Course_Info"); //Fill 方法填充
                    for (int i = 0; i < ds.Tables["Course_Info"].Rows.Count; i++)
                    {
                        comboBox_Transcript_Info_Search_by_Course_ID.Items.Add
                            (ds.Tables["Course_Info"].Rows[i]["Course_ID"].ToString() );
                    }
                }

                {
                    OleDbDataAdapter oledbda =
                   new OleDbDataAdapter
                       ("select * from Class_Info ", oledbcon);
                    if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                    DataSet ds = new DataSet(); //创建数据集
                    oledbda.Fill(ds, "Class_Info"); //Fill 方法填充
                    for (int i = 0; i < ds.Tables["Class_Info"].Rows.Count; i++)
                    {
                        comboBox_Transcript_Info_Search_by_Class_ID.Items.Add
                            (ds.Tables["Class_Info"].Rows[i]["Class_ID"].ToString());
                    }
                }
            }
        }

        private void comboBox_Course_Info_Course_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Course_Info_Course_ID.SelectedItem.ToString() == "如果想添加课程,点这里。还有，请输入新的课程名。")
            {
                textBox_Course_Info_Course_Created_Time.Visible = false;
                textBox_Course_Info_Course_Created_Time.Enabled = false;
                dateTimePicker_Course_Info_Course_Created_Time.Enabled = true;
                dateTimePicker_Course_Info_Course_Created_Time.Visible = true;
            }
            else
            {
                OleDbDataAdapter oledbda =
                    new OleDbDataAdapter
                        ("select * from Course_Info where Course_ID='" + comboBox_Course_Info_Course_ID.SelectedItem.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Course_Info"); //Fill 方法填充            
                if (ds.Tables["Course_Info"].Rows.Count == 0) { MessageBox.Show("亲！没有编号是 " + textBox_Student_Name_Search.Text.ToString() + " 的课程"); return; }

                textBox_Course_Info_Course_Name.Text = ds.Tables["Course_Info"].Rows[0]["Course_Name"].ToString();
                textBox_Course_Info_Course_Time.Text = ds.Tables["Course_Info"].Rows[0]["Course_Time"].ToString();
                textBox_Course_Info_Course_Created_Time.Text = ds.Tables["Course_Info"].Rows[0]["Course_Created_Time"].ToString();
            }

        }

        private void button_Course_Info_Insert_Data_Click(object sender, EventArgs e)
        {
            if (comboBox_Course_Info_Course_ID.Text.ToString() == "如果想添加课程,点这里。还有，请输入新的课程名。"
                ||comboBox_Course_Info_Course_ID.Text.ToString() ==""
                ||textBox_Course_Info_Course_Name.Text==""
                ||textBox_Course_Info_Course_Time.Text==""
                ||dateTimePicker_Course_Info_Course_Created_Time.Enabled ==false)
            
            { MessageBox.Show("你玩我？信息没输完怎么插入数据库！！！"); return; }
           
            try
            {
                OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Course_Info where Course_ID='" + comboBox_Course_Info_Course_ID.SelectedText.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Course_Info"); //Fill 方法填充            
                if (ds.Tables["Course_Info"].Rows.Count == 0)
                {
                    string cmdstring =
                        "insert into Course_Info values('"
                        + comboBox_Course_Info_Course_ID.Text.ToString() + "','"
                        + textBox_Course_Info_Course_Name.Text.ToString() + "','"
                        + textBox_Course_Info_Course_Time.Text.ToString() + "','"
                        + dateTimePicker_Course_Info_Course_Created_Time.Value.Date.ToString() + "'"
                        + ")";
                    
                    OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
                    olecmd.ExecuteNonQuery();
                    MessageBox.Show("插入完毕！！！");
                }
                else
                {
                    DialogResult MsgBoxResult;//设置对话框的返回值
                    MsgBoxResult = MessageBox.Show("哥们儿，你输入的课程号已经存在了。如果你点了确定，那就会把已经存在的数据给改了。Are you sure about that?",//对话框的显示内容
                    "提示",//对话框的标题
                    MessageBoxButtons.YesNo,//定义对话框的按钮，这里定义了YSE和NO两个按钮
                    MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号
                    MessageBoxDefaultButton.Button2);//定义对话框的按钮式样
                    
                    if (MsgBoxResult == DialogResult.No)//如果对话框的返回值是NO（按"N"按钮）
                    {
                        return;
                    }
                    string cmdstring=null;
                    OleDbCommand olecmd;
                    if (textBox_Course_Info_Course_Name.Text.ToString() != "")
                    {
                        cmdstring =
                        "update  Course_Info set Course_Name= '"
                        + textBox_Course_Info_Course_Name.Text.ToString() + "' where Course_ID='"
                        + comboBox_Course_Info_Course_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }

                    if (textBox_Course_Info_Course_Time.Text.ToString() != "")
                    {
                        cmdstring =
                        "update  Course_Info set Course_Time= '"
                        + textBox_Course_Info_Course_Time.Text.ToString() + "' where Course_ID='"
                        + comboBox_Course_Info_Course_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }

                    if (dateTimePicker_Course_Info_Course_Created_Time.Value.ToString() != "")
                    {
                        cmdstring =
                        "update  Course_Info set Course_Created_Time= '"
                        + dateTimePicker_Course_Info_Course_Created_Time.Value.ToString() + "' where Course_ID='"
                        + comboBox_Course_Info_Course_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("更新完毕！！！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button_Course_Info_Delete_Data_Click(object sender, EventArgs e)
        {
            try
                    {
            if (comboBox_Course_Info_Course_ID.Text.ToString() == "如果想添加课程,点这里。还有，请输入新的课程名。"
                || comboBox_Course_Info_Course_ID.Text.ToString() == "")

            { MessageBox.Show("删除根毛啊，你妹的，没有编号我怎么删啊！！！"); return; }
            string cmdstring =
                        "Delete from Course_Info where Course_ID='"
                        + comboBox_Course_Info_Course_ID.Text.ToString() + "'";
            OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
            olecmd.ExecuteNonQuery();
                    }
            catch (Exception ex) { MessageBox.Show("你输入的编号有问题\r\n" + ex.ToString()); return; }
            MessageBox.Show("删除完毕！！！");
            tabControl_Main_container.SelectedIndex = 1;
        }

        private void comboBox_Class_Info_Class_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Class_Info_Class_ID.SelectedItem.ToString() == "如果想添加班级,点这里。还有，请输入新的课程名。")
            {
                textBox_Class_Info_Class_Created_Time.Visible = false;
                textBox_Class_Info_Class_Created_Time.Enabled = false;
                dateTimePicker_Class_Info_Class_Created_Time.Enabled = true;
                dateTimePicker_Class_Info_Class_Created_Time.Visible = true;
            }
            else
            {
                OleDbDataAdapter oledbda =
                    new OleDbDataAdapter
                        ("select * from Class_Info where Class_ID='" + comboBox_Class_Info_Class_ID.SelectedItem.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Class_Info"); //Fill 方法填充            
                if (ds.Tables["Class_Info"].Rows.Count == 0) { MessageBox.Show("亲！没有编号是 " + textBox_Student_Name_Search.Text.ToString() + " 的班级"); return; }

                textBox_Class_Info_Class_Name.Text = ds.Tables["Class_Info"].Rows[0]["Class_Name"].ToString();
                textBox_Class_Info_Class_Created_Time.Text = ds.Tables["Class_Info"].Rows[0]["Class_Created_Time"].ToString();
            }
        }

        private void button_Class_Info_Class_Insert_Data_Click(object sender, EventArgs e)
        {
            if (comboBox_Class_Info_Class_ID.Text.ToString() == "如果想添加班级,点这里。还有，请输入新的课程名。"
                || comboBox_Class_Info_Class_ID.Text.ToString() == ""
                || textBox_Class_Info_Class_Name.Text == ""
                || dateTimePicker_Class_Info_Class_Created_Time.Enabled == false)

            { MessageBox.Show("唉，就一个信息你都懒得输入，没救了！！！"); return; }
            
            try
            {
                OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Class_Info where Course_ID='" + comboBox_Class_Info_Class_ID.SelectedText.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Class_Info"); //Fill 方法填充            
                if (ds.Tables["Class_Info"].Rows.Count == 0)
                {
                    string cmdstring =
                        "insert into Class_Info values('"
                        + comboBox_Class_Info_Class_ID.Text.ToString() + "','"
                        + textBox_Class_Info_Class_Name.Text.ToString() + "','"
                        + dateTimePicker_Class_Info_Class_Created_Time.Value.Date.ToString() + "'"
                        + ")";

                    OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
                    olecmd.ExecuteNonQuery();
                    MessageBox.Show("插入完毕！！！");
                }
                else
                {
                    DialogResult MsgBoxResult;//设置对话框的返回值
                    MsgBoxResult = MessageBox.Show("哥们儿，你输入的班级号已经存在了。如果你点了确定，那就会把已经存在的数据给改了。Are you sure about that?",//对话框的显示内容
                    "提示",//对话框的标题
                    MessageBoxButtons.YesNo,//定义对话框的按钮，这里定义了YSE和NO两个按钮
                    MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号
                    MessageBoxDefaultButton.Button2);//定义对话框的按钮式样

                    if (MsgBoxResult == DialogResult.No)//如果对话框的返回值是NO（按"N"按钮）
                    {
                        return;
                    }
                    try
                    {
                        string cmdstring = null;
                        OleDbCommand olecmd;
                        if (textBox_Class_Info_Class_Name.Text.ToString() != "")
                        {
                            cmdstring =
                            "update  Class_Info set Class_Name= '"
                            + textBox_Class_Info_Class_Name.Text.ToString() + "' where Class_ID='"
                            + comboBox_Class_Info_Class_ID.Text.ToString() + "'";
                            olecmd = new OleDbCommand(cmdstring, oledbcon);
                            olecmd.ExecuteNonQuery();
                        }

                        if (dateTimePicker_Class_Info_Class_Created_Time.Value.ToString() != "")
                        {
                            cmdstring =
                            "update  Class_Info set Class_Created_Time= '"
                            + dateTimePicker_Class_Info_Class_Created_Time.Value.ToString() + "' where Class_ID='"
                            + comboBox_Class_Info_Class_ID.Text.ToString() + "'";
                            olecmd = new OleDbCommand(cmdstring, oledbcon);
                            olecmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("你输入的编号有问题\r\n" + ex.ToString()); return; }
                    MessageBox.Show("更新完毕！！！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button_Class_Info_Class_Delete_Data_Click(object sender, EventArgs e)
        {
            try
            {
            if (comboBox_Class_Info_Class_ID.Text.ToString() == "如果想添加班级,点这里。还有，请输入新的课程名。"
                || comboBox_Class_Info_Class_ID.Text.ToString() == "")

            { MessageBox.Show("删除根毛啊，你妹的，没有班级编号我怎么删啊！！！"); return; }
            string cmdstring =
                        "Delete from Class_Info where Class_ID='"
                        + comboBox_Class_Info_Class_ID.Text.ToString() + "'";
            OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
            olecmd.ExecuteNonQuery();
            MessageBox.Show("删除完毕！！！");
            tabControl_Main_container.SelectedIndex = 2;
            }
            catch (Exception ex) { MessageBox.Show("你输入的编号有问题\r\n" + ex.ToString()); return; }
        }

        private void comboBox_Transcript_Info_Search_by_Student_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_Transcript_Info_Search_by_Student_ID
            //comboBox_Transcript_Info_Search_by_Student_Name
            //comboBox_Transcript_Info_Search_by_Course_ID
            //comboBox_Transcript_Info_Search_by_Class_ID
            //comboBox_Transcript_Info_Search_by_Student_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Student_Name.Text = "";
            comboBox_Transcript_Info_Search_by_Course_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Class_ID.Text = "";

            OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Transcript_Info where Student_ID='" + 
                         comboBox_Transcript_Info_Search_by_Student_ID.Text.ToString() + "'", oledbcon);
                if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
                DataSet ds = new DataSet(); //创建数据集
                oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充      
                Result.Text = "";
                if (ds.Tables["Transcript_Info"].Rows.Count == 0)
                {
                    Result.Text = "没结果";
                }
                else 
                {
                    for (int i = 0; i < ds.Tables["Transcript_Info"].Rows.Count; i++)
                    {
                        Result.Text +=
                        "学号："+
                        ds.Tables["Transcript_Info"].Rows[i]["Student_ID"].ToString()+
                        "\r\n课程编号：" +
                        ds.Tables["Transcript_Info"].Rows[i]["Course_ID"].ToString()+
                        "\r\n分数：" +
                        ds.Tables["Transcript_Info"].Rows[i]["Student_Score"].ToString()+
                        "\r\n创建时间：" +
                        ds.Tables["Transcript_Info"].Rows[i]["Transcript_Created_Time"].ToString() + "\r\n\r\n";
                    }
                }
        }

        private void button_Transcript_Info_Delete_Data_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Transcript_Info_Search_by_Student_ID.Text.ToString() == "")

                { MessageBox.Show("删除根毛啊，你妹的，没有班级编号我怎么删啊！！！"); return; }
                string cmdstring =
                            "Delete from Transcript_Info where Student_ID='"
                            + comboBox_Transcript_Info_Search_by_Student_ID.Text.ToString() + "'";
                OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
                olecmd.ExecuteNonQuery();
                MessageBox.Show("删除完毕！！！");
                tabControl_Main_container.SelectedIndex = 3;
            }
            catch (Exception ex) { MessageBox.Show("你输入的学号有问题\r\n" + ex.ToString()); return; }
        }

        private void comboBox_Transcript_Info_Search_by_Student_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Transcript_Info_Search_by_Student_ID.Text = "";
            //comboBox_Transcript_Info_Search_by_Student_Name.Text = "";
            comboBox_Transcript_Info_Search_by_Course_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Class_ID.Text = "";
            OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Transcript_Info where Student_ID in( select Student_ID from Student_Info where Student_Name='" +
                         comboBox_Transcript_Info_Search_by_Student_Name.Text.ToString() + "')", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充      
            Result.Text = "";
            if (ds.Tables["Transcript_Info"].Rows.Count == 0)
            {
                Result.Text = "没结果";
            }
            else
            {
                for (int i = 0; i < ds.Tables["Transcript_Info"].Rows.Count; i++)
                {
                    Result.Text +=
                    "学号：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_ID"].ToString() +
                    "\r\n课程编号：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Course_ID"].ToString() +
                    "\r\n分数：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_Score"].ToString() +
                    "\r\n创建时间：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Transcript_Created_Time"].ToString() + "\r\n\r\n";
                }
            }
        }

        private void comboBox_Transcript_Info_Search_by_Course_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Transcript_Info_Search_by_Student_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Student_Name.Text = "";
            //comboBox_Transcript_Info_Search_by_Course_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Class_ID.Text = "";
            OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Transcript_Info where Course_ID ='" +
                         comboBox_Transcript_Info_Search_by_Course_ID.Text.ToString() + "'", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充      
            Result.Text = "";
            if (ds.Tables["Transcript_Info"].Rows.Count == 0)
            {
                Result.Text = "没结果";
            }
            else
            {
                for (int i = 0; i < ds.Tables["Transcript_Info"].Rows.Count; i++)
                {
                    Result.Text +=
                    "学号：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_ID"].ToString() +
                    "\r\n课程编号：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Course_ID"].ToString() +
                    "\r\n分数：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_Score"].ToString() +
                    "\r\n创建时间：" +
                    ds.Tables["Transcript_Info"].Rows[i]["Transcript_Created_Time"].ToString() + "\r\n\r\n";
                }
            }
        }

        private void comboBox_Transcript_Info_Search_by_Class_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Transcript_Info_Search_by_Student_ID.Text = "";
            comboBox_Transcript_Info_Search_by_Student_Name.Text = "";
            comboBox_Transcript_Info_Search_by_Course_ID.Text = "";
            //comboBox_Transcript_Info_Search_by_Class_ID.Text = "";
            OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Transcript_Info where Student_ID IN (select Student_ID from Student_Info where Student_Class_No='" +
                         comboBox_Transcript_Info_Search_by_Class_ID.Text.ToString() + "')", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充      
            Result.Text = "";
            if (ds.Tables["Transcript_Info"].Rows.Count == 0)
            {
                Result.Text = "没结果";
            }
            else
            {
                for (int i = 0; i < ds.Tables["Transcript_Info"].Rows.Count; i++)
                {
                    Result.Text +=
                    "学号：   " +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_ID"].ToString() +
                    "\r\n课程编号：   " +
                    ds.Tables["Transcript_Info"].Rows[i]["Course_ID"].ToString() +
                    "\r\n分数：   " +
                    ds.Tables["Transcript_Info"].Rows[i]["Student_Score"].ToString() +
                    "\r\n创建时间：   " +
                    ds.Tables["Transcript_Info"].Rows[i]["Transcript_Created_Time"].ToString() + "\r\n\r\n";
                }
            }
        }

        private void button_Transcript_Info_Insert_Update_Data_Click(object sender, EventArgs e)
        {
            try{
            OleDbDataAdapter oledbda =
                     new OleDbDataAdapter
                         ("select * from Transcript_Info where Student_ID ='" +
                         textBox_Transcript_Info_Student_ID.Text.ToString() + "' and Course_ID='" + textBox_Transcript_Info_Class_ID.Text.ToString() + "'", oledbcon);
            if (oledbda == null) { MessageBox.Show("no OleDbDataAdapter!"); return; }
            DataSet ds = new DataSet(); //创建数据集
            oledbda.Fill(ds, "Transcript_Info"); //Fill 方法填充      
            if (ds.Tables["Transcript_Info"].Rows.Count == 0) 
            {
                string cmdstring =
                        "insert into Transcript_Info values('"
                        + textBox_Transcript_Info_Student_ID.Text.ToString() + "','"
                        + textBox_Transcript_Info_Class_ID.Text.ToString() +"','"
                        + textBox_Transcript_Info_Student_Score.Text.ToString() + "','"
                        + dateTimePicker_Transcript_Info_Transcript_Created_Time.Value.Date.ToString() + "')";
                    OleDbCommand olecmd = new OleDbCommand(cmdstring, oledbcon);
                    olecmd.ExecuteNonQuery();
                    MessageBox.Show("插入完毕！！！");
            }else
                {
                    DialogResult MsgBoxResult;//设置对话框的返回值
                    MsgBoxResult = MessageBox.Show("哥们儿，你输入的学号已经存在了。如果你点了确定，那就会把已经存在的数据给改了。Are you sure about that?",//对话框的显示内容
                    "提示",//对话框的标题
                    MessageBoxButtons.YesNo,//定义对话框的按钮，这里定义了YSE和NO两个按钮
                    MessageBoxIcon.Exclamation,//定义对话框内的图表式样，这里是一个黄色三角型内加一个感叹号
                    MessageBoxDefaultButton.Button2);//定义对话框的按钮式样
                    
                    if (MsgBoxResult == DialogResult.No)//如果对话框的返回值是NO（按"N"按钮）
                    {
                        return;
                    }
                    string cmdstring=null;
                    OleDbCommand olecmd;
                    if (textBox_Transcript_Info_Class_ID.Text.ToString() != "")
                    {
                        cmdstring =
                        "update  Transcript_Info set Class_ID= '"
                        + textBox_Transcript_Info_Class_ID.Text.ToString() + "' where Student_ID='"
                        + textBox_Transcript_Info_Student_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    if (textBox_Transcript_Info_Student_Score.Text.ToString() != "")
                    {
                        cmdstring =
                        "update  Transcript_Info set Student_Score= '"
                        + textBox_Transcript_Info_Student_Score.Text.ToString() + "' where Student_ID='"
                        + textBox_Transcript_Info_Student_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }

                    if (dateTimePicker_Transcript_Info_Transcript_Created_Time.Value.Date.ToString() != "")
                    {
                        cmdstring =
                        "update  Transcript_Info set Transcript_Created_Time= '"
                        + dateTimePicker_Transcript_Info_Transcript_Created_Time.Value.Date.ToString() + "' where Student_ID='"
                        + textBox_Transcript_Info_Student_ID.Text.ToString() + "'";
                        olecmd = new OleDbCommand(cmdstring, oledbcon);
                        olecmd.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("更新完毕！！！"); 
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
           
        }

           

       

       
    }
}
