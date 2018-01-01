using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using WMPLib;
using System.Diagnostics;
using System.IO.Ports;

namespace PersonalAIGayle
{
    public partial class frmgayle : Form
    {

        SerialPort sp;

        public frmgayle()
        {
            InitializeComponent();
            sp = new SerialPort("COM3");
            sp.BaudRate = 9600;

        }
        SpeechRecognitionEngine recEng = new SpeechRecognitionEngine();

        private void btnenable_Click(object sender, EventArgs e)
        {



            recEng.RecognizeAsync(RecognizeMode.Multiple);
            btnenable.Enabled = false;
            btndisable.Enabled = true;
        }

        private void frmgayle_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] {
                "turn on living room",
                "turn off living room",
                "turn on tv",
                "turn off tv",
                "turn on fan",
                "turn off fan",
                "turn on pc",
                "turn off pc",
                "open abcd",
                "close abcd" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            Grammar grammar = new Grammar(gBuilder);

            recEng.LoadGrammarAsync(grammar);
            recEng.SetInputToDefaultAudioDevice();
            recEng.SpeechRecognized += recEng_SpeechRecognized;

        }



        private void recEng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            log.Text = e.Result.Text;
            switch (e.Result.Text)
            {
                case "turn on living room":
                    writeToSerialPort("1");
                    break;

                case "turn off living room":
                    writeToSerialPort("2");
                    break;


                case "turn on tv":
                    writeToSerialPort("3");
                    break;

                case "turn off tv":
                    writeToSerialPort("4");
                    break;



                case "turn on fan":
                    writeToSerialPort("5");
                    break;

                case "turn off fan":
                    writeToSerialPort("6");
                    break;


                case "turn on pc":
                    writeToSerialPort("7");
                    break;

                case "turn off pc":
                    writeToSerialPort("8");
                    break;


                case "open abcd":
                    writeToSerialPort("9");
                    break;

                case "close abcd":
                    writeToSerialPort("0");


                    break;

                case "test":
                    MessageBox.Show("Test");
                    break;

            }
        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            recEng.RecognizeAsyncStop();
            btnenable.Enabled = true;
            btndisable.Enabled = false;
        }

        public void writeToSerialPort(string text)
        {
            try
            {
                sp.Open();
                sp.Write(text);
                sp.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmgayle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
