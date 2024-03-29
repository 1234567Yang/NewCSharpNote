namespace NotesManage
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_html = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_keywords = new System.Windows.Forms.TextBox();
            this.textBox_descrip = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.textBox_bgcolor = new System.Windows.Forms.TextBox();
            this.button_gettitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(12, 230);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(700, 257);
            this.textEditorControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 143);
            this.label1.TabIndex = 1;
            this.label1.Text = "HTML:\r\n\r\nTITLE:\r\n\r\nDESCRIPTION:\r\n\r\nKEY WORDS(separate by ,):\r\n\r\nColor:\r\n\r\nbgColor" +
    ":";
            // 
            // textBox_html
            // 
            this.textBox_html.Location = new System.Drawing.Point(59, 40);
            this.textBox_html.Name = "textBox_html";
            this.textBox_html.Size = new System.Drawing.Size(475, 20);
            this.textBox_html.TabIndex = 2;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(59, 66);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(475, 20);
            this.textBox_title.TabIndex = 5;
            // 
            // textBox_keywords
            // 
            this.textBox_keywords.Location = new System.Drawing.Point(168, 118);
            this.textBox_keywords.Name = "textBox_keywords";
            this.textBox_keywords.Size = new System.Drawing.Size(434, 20);
            this.textBox_keywords.TabIndex = 6;
            // 
            // textBox_descrip
            // 
            this.textBox_descrip.Location = new System.Drawing.Point(100, 92);
            this.textBox_descrip.Name = "textBox_descrip";
            this.textBox_descrip.Size = new System.Drawing.Size(434, 20);
            this.textBox_descrip.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(250, 195);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirm / Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "static position:";
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(96, 10);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(492, 20);
            this.textBox_model.TabIndex = 11;
            this.textBox_model.Text = "model.html";
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(59, 144);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(434, 20);
            this.textBox_color.TabIndex = 12;
            this.textBox_color.Text = "blue";
            // 
            // textBox_bgcolor
            // 
            this.textBox_bgcolor.Location = new System.Drawing.Point(71, 170);
            this.textBox_bgcolor.Name = "textBox_bgcolor";
            this.textBox_bgcolor.Size = new System.Drawing.Size(434, 20);
            this.textBox_bgcolor.TabIndex = 13;
            this.textBox_bgcolor.Text = "transparent";
            // 
            // button_gettitle
            // 
            this.button_gettitle.Location = new System.Drawing.Point(540, 63);
            this.button_gettitle.Name = "button_gettitle";
            this.button_gettitle.Size = new System.Drawing.Size(75, 23);
            this.button_gettitle.TabIndex = 14;
            this.button_gettitle.Text = "get";
            this.button_gettitle.UseVisualStyleBackColor = true;
            this.button_gettitle.Click += new System.EventHandler(this.button_gettitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 535);
            this.Controls.Add(this.button_gettitle);
            this.Controls.Add(this.textBox_bgcolor);
            this.Controls.Add(this.textBox_color);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_descrip);
            this.Controls.Add(this.textBox_keywords);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_html);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditorControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_html;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_keywords;
        private System.Windows.Forms.TextBox textBox_descrip;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.TextBox textBox_bgcolor;
        private System.Windows.Forms.Button button_gettitle;
    }
}

