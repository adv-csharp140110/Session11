using BL;
using ViewModel;

namespace ui_winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vm = new CategoryInputModel { 
                CategoryName = textBox1.Text
                //,...
            };
            var service = new CategoryService();
            service.Add(vm);
        }
    }
}