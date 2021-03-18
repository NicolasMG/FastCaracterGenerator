using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastCaracterGenerator
{
    public partial class Generator : Form
    {
        private GeneratorName generatorName;

        public Generator()
        {
            InitializeComponent();

            generatorName = new GeneratorName();
            generatorName.GeneratNPC();
            FastRender.Text = generatorName.AnswerBuilderToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Lock_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            generatorName.GeneratNPC();
            FastRender.Text = generatorName.AnswerBuilderToString();
        }
    }
}
