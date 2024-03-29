using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ICSharpCode;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Actions;
using ICSharpCode.TextEditor.Document;

namespace NotesManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textEditorControl1.ShowEOLMarkers = false;
            textEditorControl1.ShowHRuler = false;
            textEditorControl1.ShowInvalidLines = false;
            textEditorControl1.ShowMatchingBracket = true;
            textEditorControl1.ShowSpaces = false;
            textEditorControl1.ShowTabs = false;
            textEditorControl1.ShowVRuler = false;
            textEditorControl1.AllowCaretBeyondEOL = false;
            textEditorControl1.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");
            textEditorControl1.Encoding = Encoding.UTF8;
            textEditorControl1.ActiveTextAreaControl.TextArea.KeyUp += new System.Windows.Forms.KeyEventHandler(textEditorControl1_KeyUp);
        }
        private void textEditorControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Alt)
            {
                return;
            }
            //textEditorControl1.ActiveTextAreaControl.SelectionManager.SelectedText;
            int pos = textEditorControl1.Document.PositionToOffset(textEditorControl1.ActiveTextAreaControl.Caret.Position);
            int lineIndex = textEditorControl1.ActiveTextAreaControl.Caret.Position.Line;
            // 获取当前行的 LineSegment
            var lineSegment = textEditorControl1.Document.GetLineSegment(lineIndex);
            // 使用 Document.GetText 方法获取行的文本
            string lineText = textEditorControl1.Document.GetText(lineSegment.Offset, lineSegment.Length);
            int cursorPosInLine = textEditorControl1.ActiveTextAreaControl.Caret.Offset - lineSegment.Offset;

            //Console.WriteLine(pos);
            if (cursorPosInLine > 0 && lineText.Substring(cursorPosInLine - 1, 1) == ">")
            {
                // 获取当前行的索引
                
                if(lineText.Substring(0, cursorPosInLine).IndexOf("<") != -1)
                {
                    if(!IsInQuote(lineText, cursorPosInLine))
                    {
                        //Console.WriteLine("!!!");
                        int p1 = lineText.Substring(0, cursorPosInLine).LastIndexOf("<");
                        string insert = lineText.Substring(p1 + 1, cursorPosInLine - p1 - 2);
                        //Console.WriteLine(insert);
                        if(insert.IndexOf("/") == -1)
                        {
                            insert = "</" + insert.Substring(0, (insert.IndexOf(" ") != -1)? insert.IndexOf(" "):insert.Length) + ">";
                            textEditorControl1.Document.Insert(textEditorControl1.ActiveTextAreaControl.Caret.Offset, insert);
                        }
                    }
                }
            }
        }
        private bool IsInQuote(string text, int pos)
        {
            string before = text.Substring(0, pos);
            return before.Count(c => c == '\"') % 2 != 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string pos = "raw\\" + this.textBox_html.Text;
            if (!File.Exists(textBox_model.Text) || !File.Exists(pos))
            {
                MessageBox.Show("Position is not correct!");
                return;
            }
            string model = File.ReadAllText(textBox_model.Text);
            string content = File.ReadAllText(pos);
            string whole = model;
            whole = whole.Replace("【TITLE】", this.textBox_title.Text);
            whole = whole.Replace("【KEYWORDS】", this.textBox_keywords.Text);
            whole = whole.Replace("【DESCRIPTION】", this.textBox_descrip.Text);

            whole = whole.Replace("【CONTENT】", content);

            this.textEditorControl1.Text = whole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = this.textBox_html.Text.Substring(0, this.textBox_html.Text.IndexOf(".")) + "\\";
            Directory.CreateDirectory(this.textBox_html.Text.Substring(0, this.textBox_html.Text.IndexOf(".")));
            File.WriteAllText(dir + "F_" + this.textBox_html.Text,this.textEditorControl1.Text);
            File.AppendAllText("index.txt", dir + "F_" + this.textBox_html.Text + "|" + 
                this.textBox_title.Text + "|" + 
                DateTime.UtcNow.ToString() + "|" +
                this.textBox_color.Text + "|" +
                this.textBox_bgcolor.Text + 
                Environment.NewLine);

            if(Directory.Exists("raw\\" + this.textBox_html.Text.Substring(0, this.textBox_html.Text.IndexOf("."))))
            {
                if(MessageBox.Show("Also copy the image?", "Question: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach(var a in Directory.EnumerateFiles("raw\\" + this.textBox_html.Text.Substring(0, this.textBox_html.Text.IndexOf("."))))
                    {
                        File.WriteAllBytes(dir + Path.GetFileName(a), File.ReadAllBytes(a));
                    }
                }
            }

            this.textBox_html.Text = "";
            this.textBox_title.Text = "";
            this.textBox_descrip.Text = "";
            // this.textBox_keywords.Text = "";
            this.textEditorControl1.Text = "";
            
        }

        private void button_gettitle_Click(object sender, EventArgs e)
        {
            string dir = this.textBox_html.Text.Substring(0, this.textBox_html.Text.IndexOf(".")) + "\\";
            if(!File.Exists(dir + "F_" + this.textBox_html.Text))
            {
                MessageBox.Show("NOT EXISTS");
                return;
            }
            string text = File.ReadAllText(dir + "F_" + this.textBox_html.Text);
            string title = text.Substring(text.IndexOf("<title>") + "<title>".Length, text.IndexOf("</title>") - text.IndexOf("<title>") - "<title>".Length);
            this.textBox_title.Text = title;


            string before = "<meta name=\"description\" content=\"";
            string after = "\">";
            string des = text.Substring(text.IndexOf(before) + before.Length, text.IndexOf(after, text.IndexOf(before) + before.Length + 1) - text.IndexOf(before) - before.Length);
            this.textBox_descrip.Text = des;

            string keybefore = "<meta name=\"keywords\" content=\"";
            string key = text.Substring(text.IndexOf(keybefore) + keybefore.Length, text.IndexOf(after, text.IndexOf(keybefore) + keybefore.Length + 1) - text.IndexOf(keybefore) - keybefore.Length);
            this.textBox_keywords.Text = key;
        }
    }
}
