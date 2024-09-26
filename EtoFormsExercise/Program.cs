using Eto.Forms;
using Application = Eto.Forms.Application;
using Button = Eto.Forms.Button;
using Form = Eto.Forms.Form;
using Label = Eto.Forms.Label;

namespace EtoFormsExercise
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            new Application(Eto.Platforms.WinForms).Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private TextArea textArea;

        public MainForm()
        {
            Title = "My EtoForms Exercise";
            ClientSize = new Eto.Drawing.Size(800, 600);

            // ������ť  
            var button = new Button { Text = "Click Me" };
            button.Click += Button_Click;

            // �����ı�����  
            textArea = new TextArea
            {
                Size = new Eto.Drawing.Size(600, 300)
            };

            // ��������  
            var layout = new StackLayout
            {
                Padding = 10,
                Spacing = 10,
                Items =
                {
                    new Label { Text = "Hello, My EtoForms Exercise!" },
                    button,
                    textArea
                }
            };

            Content = layout;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // ����ť�����ʱ�������ı����������
            textArea.Text += "DotNetGuide����������һ������.NET�����ߵĿ�Դ����������ּ��Ϊ���������ṩȫ���C#/.NET/.NET Core���ѧϰ���ϡ������������ѯ����Ŀ����Ƽ�����ְ����Ƹ��Ѷ���Լ���������ƽ̨��";
        }
    }
}