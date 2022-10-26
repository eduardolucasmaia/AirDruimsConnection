/*Informações:
 * 1 = baqueta esquerda
 * 2 = baqueta direita
 * 3 = pedal esquerdo
 * 4 = pedal direito
 * 5 = calibrar
 * 6 = calibragem ok
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Media;


namespace Air_Druims_Connection
{
    public partial class Form1 : Form
    {
        #region //Seleção de sons a serem tocados nos instrumentos
        String MidBaquetaEsquerda = config.Default.chimbal;
        String MidBaquetaDireita = config.Default.caixa;
        String MidPedalEsquerdo = config.Default.chimbalAberto;
        String MidPedalDireito = config.Default.bumbo;
        #endregion

        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e) // Quando fecha o programa
        {
            try
            {
                if (serialPort1.IsOpen) serialPort1.Close();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Botão de Calibrar as baquetas
        {
            DialogResult resultado = MessageBox.Show("Deixe as baquetas na horizontal para ter uma melhor calibragem. Clique em OK para continuar...",
                "Calibrar Baquetas", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensagem de Erro
            if (resultado == System.Windows.Forms.DialogResult.OK) // SE apertou CANCELAR...
            {
                serialPort1.Write("5");
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);   
            }
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) //Conversa entre Arduino e PC
        {
            SerialPort sp = (SerialPort)sender;
            string funcao = sp.ReadExisting();

            #region Diretorios dos Sons
            String dirBaquetaEsquerda = @"C:\Air Drums\Chimbal\" + MidBaquetaEsquerda + ".wav";
            String dirBaquetaDireita = @"C:\Air Drums\Tambor\" + MidBaquetaDireita + ".wav";
            String dirPedalEsquerdo = @"C:\Air Drums\Chimbal Aberto\" + MidPedalEsquerdo + ".wav";
            String dirPedalDireito = @"C:\Air Drums\Bumbo\" + MidPedalDireito + ".wav";
            String dirCalibragem = @"C:\Air Drums\Calibragem.wav";
            #endregion

            #region Variaveis Utilizadas para som
            /*var SomBaquetaEsquerda = new WMPLib.WindowsMediaPlayer();
            SomBaquetaEsquerda.URL = @"E:\" + MidBaquetaEsquerda + ".wav";
            var SomBaquetaDireita = new WMPLib.WindowsMediaPlayer();
            var SomPedalDireito = new WMPLib.WindowsMediaPlayer();
            var calibragem = new WMPLib.WindowsMediaPlayer();*/

            /*System.Media.SoundPlayer SomBaquetaEsquerda = new System.Media.SoundPlayer(@"E:\" + MidBaquetaEsquerda + ".wav");
            System.Media.SoundPlayer SomBaquetaDireita = new System.Media.SoundPlayer(@"E:\" + MidBaquetaDireita + ".wav");
            System.Media.SoundPlayer SomPedalDireito = new System.Media.SoundPlayer(@"E:\" + MidPedalDireito + ".wav");
            System.Media.SoundPlayer calibragem = new System.Media.SoundPlayer(@"E:\som2.wav");
            SomPedalDireito.Play();/*

            /*SoundPlayer SomBaquetaEsquerda = new SoundPlayer(@"E:\"+MidBaquetaEsquerda+".wav");
            SoundPlayer SomBaquetaDireita = new SoundPlayer(@"E:\"+MidBaquetaDireita+".wav");*
            SoundPlayer SomPedalDireito = new SoundPlayer(@"E:\som2.wav");
            SoundPlayer calibragem = new SoundPlayer(@"E:\som2.wav");
            SomPedalDireito.Play();*/
            #endregion


            #region Recebe '1'
            if (funcao.Equals("1")) //Som Baqueta esquerda
            {               
                try
                {
                    var SomBaquetaEsquerda = new WMPLib.WindowsMediaPlayer();
                    SomBaquetaEsquerda.URL = dirBaquetaEsquerda;
                }
                catch 
                {
                    var SomBaquetaEsquerda2 = new WMPLib.WindowsMediaPlayer();
                    SomBaquetaEsquerda2.URL = dirBaquetaEsquerda;
                };
            }
            #endregion

            #region Recebe '2'
            if (funcao.Equals("2")) //Som Baqueta direita
            {  
                try
                {
                    var SomBaquetaDireita = new WMPLib.WindowsMediaPlayer();
                    SomBaquetaDireita.URL = dirBaquetaDireita;
                }
                catch 
                {
                    var SomBaquetaDireita2 = new WMPLib.WindowsMediaPlayer();
                    SomBaquetaDireita2.URL = dirBaquetaDireita;
                }

            }
            #endregion

            #region Recebe '3'
            if (funcao.Equals("3")) //Som pedal esquerdo
            {
                try
                {
                    var SomPedalEsquerdo = new WMPLib.WindowsMediaPlayer();
                    SomPedalEsquerdo.URL = dirPedalEsquerdo;
                }

                catch
                {
                    var SomPedalEsquerdo2 = new WMPLib.WindowsMediaPlayer();
                    SomPedalEsquerdo2.URL = dirPedalEsquerdo;
                }
            }
            #endregion 

            #region Recebe '4'
            if (funcao.Equals("4")) //Som pedal direito
            {
                
                try
                {
                    var SomPedalDireito = new WMPLib.WindowsMediaPlayer();
                    SomPedalDireito.URL = dirPedalDireito;
                }

                catch
                {
                    var SomPedalDireito2 = new WMPLib.WindowsMediaPlayer();
                    SomPedalDireito2.URL = dirPedalDireito;
                }
            }
            #endregion

            #region Recebe '6'
            if (funcao.Equals("6")) //Som Calibração OK
            {
                try
                {
                    var somCalibragem = new WMPLib.WindowsMediaPlayer();
                    somCalibragem.URL = dirCalibragem;
                }
                catch { };
            }
            #endregion
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            calibrar.Enabled = false;
            portaUsb.Text = config.Default.portaUSB;
            caixa.Text = config.Default.caixa;
            chimbal.Text = config.Default.chimbal;
            pedalChimbal.Text = config.Default.chimbalAberto;
            bumbo.Text = config.Default.bumbo;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void botaoLiga_Click_1(object sender, EventArgs e)
        {
            try
            {
                config.Default.portaUSB = portaUsb.Text;  //salva a ultima porta usb utilizada
                serialPort1.PortName = portaUsb.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                portaUsb.Enabled = false;
                botaoLiga.Enabled = false;
                calibrar.Enabled = true;
                config.Default.Save();

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch
            {
                DialogResult resultado = MessageBox.Show("Arduino Conectado em porta USB errada ou nao conectado. Esperimente outra porta.",
                "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensagem de Erro
                if (resultado == System.Windows.Forms.DialogResult.OK) // SE apertou CANCELAR...
                {
                }
            }
        }

        public void chimbal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chimbal.Text.Equals("som1"))
            {
                MidBaquetaEsquerda = "som1";
            }

            if (chimbal.Text.Equals("som2"))
            {
                MidBaquetaEsquerda = "som2";
            }

            if (chimbal.Text.Equals("som3"))
            {
                MidBaquetaEsquerda = "som3";
            }

            if (chimbal.Text.Equals("som4"))
            {
                MidBaquetaEsquerda = "som4";
            }

            if (chimbal.Text.Equals("som5"))
            {
                MidBaquetaEsquerda = "som5";
            }

            if (chimbal.Text.Equals("som6"))
            {
                MidBaquetaEsquerda = "som6";
            }

            if (chimbal.Text.Equals("som7"))
            {
                MidBaquetaEsquerda = "som7";
            }

            if (chimbal.Text.Equals("som8"))
            {
                MidBaquetaEsquerda = "som8";
            }

            if (chimbal.Text.Equals("som9"))
            {
                MidBaquetaEsquerda = "som9";
            }

            if (chimbal.Text.Equals("som10"))
            {
                MidBaquetaEsquerda = "som10";
            }

            if (chimbal.Text.Equals("som11"))
            {
                MidBaquetaEsquerda = "som11";
            }

            if (chimbal.Text.Equals("som12"))
            {
                MidBaquetaEsquerda = "som12";
            }

            if (chimbal.Text.Equals("som13"))
            {
                MidBaquetaEsquerda = "som13";
            }

            if (chimbal.Text.Equals("som14"))
            {
                MidBaquetaEsquerda = "som14";
            }

            if (chimbal.Text.Equals("som15"))
            {
                MidBaquetaEsquerda = "som15";
            }

            if (chimbal.Text.Equals("som16"))
            {
                MidBaquetaEsquerda = "som16";
            }

            if (chimbal.Text.Equals("som17"))
            {
                MidBaquetaEsquerda = "som17";
            }

            if (chimbal.Text.Equals("som18"))
            {
                MidBaquetaEsquerda = "som18";
            }

            if (chimbal.Text.Equals("som19"))
            {
                MidBaquetaEsquerda = "som19";
            }

            if (chimbal.Text.Equals("som20"))
            {
                MidBaquetaEsquerda = "som20";
            }

            if (chimbal.Text.Equals("som21"))
            {
                MidBaquetaEsquerda = "som21";
            }

            if (chimbal.Text.Equals("som22"))
            {
                MidBaquetaEsquerda = "som22";
            }

            if (chimbal.Text.Equals("som23"))
            {
                MidBaquetaEsquerda = "som23";
            }

            if (chimbal.Text.Equals("som24"))
            {
                MidBaquetaEsquerda = "som24";
            }

            if (chimbal.Text.Equals("som25"))
            {
                MidBaquetaEsquerda = "som25";
            }

            config.Default.chimbal = chimbal.Text;
            config.Default.Save();
        }

        private void caixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caixa.Text.Equals("som1"))
            {
                MidBaquetaDireita = "som1";
            }

            if (caixa.Text.Equals("som2"))
            {
                MidBaquetaDireita = "som2";
            }

            if (caixa.Text.Equals("som3"))
            {
                MidBaquetaDireita = "som3";
            }

            if (caixa.Text.Equals("som4"))
            {
                MidBaquetaDireita = "som4";
            }

            if (caixa.Text.Equals("som5"))
            {
                MidBaquetaDireita = "som5";
            }

            if (caixa.Text.Equals("som6"))
            {
                MidBaquetaDireita = "som6";
            }

            if (caixa.Text.Equals("som7"))
            {
                MidBaquetaDireita = "som7";
            }

            if (caixa.Text.Equals("som8"))
            {
                MidBaquetaDireita = "som8";
            }

            if (caixa.Text.Equals("som9"))
            {
                MidBaquetaDireita = "som9";
            }

            if (caixa.Text.Equals("som10"))
            {
                MidBaquetaDireita = "som10";
            }

            if (caixa.Text.Equals("som11"))
            {
                MidBaquetaDireita = "som11";
            }

            if (caixa.Text.Equals("som12"))
            {
                MidBaquetaDireita = "som12";
            }

            if (caixa.Text.Equals("som13"))
            {
                MidBaquetaDireita = "som13";
            }

            if (caixa.Text.Equals("som14"))
            {
                MidBaquetaDireita = "som14";
            }

            if (caixa.Text.Equals("som15"))
            {
                MidBaquetaDireita = "som15";
            }

            if (caixa.Text.Equals("som16"))
            {
                MidBaquetaDireita = "som16";
            }

            if (caixa.Text.Equals("som17"))
            {
                MidBaquetaDireita = "som17";
            }

            if (caixa.Text.Equals("som18"))
            {
                MidBaquetaDireita = "som18";
            }

            if (caixa.Text.Equals("som19"))
            {
                MidBaquetaDireita = "som19";
            }

            if (caixa.Text.Equals("som20"))
            {
                MidBaquetaDireita = "som20";
            }

            if (caixa.Text.Equals("som21"))
            {
                MidBaquetaDireita = "som21";
            }

            if (caixa.Text.Equals("som22"))
            {
                MidBaquetaDireita = "som22";
            }

            if (caixa.Text.Equals("som23"))
            {
                MidBaquetaDireita = "som23";
            }

            if (caixa.Text.Equals("som24"))
            {
                MidBaquetaDireita = "som24";
            }

            if (caixa.Text.Equals("som25"))
            {
                MidBaquetaDireita = "som25";
            }

            if (caixa.Text.Equals("som26"))
            {
                MidBaquetaDireita = "som26";
            }

            if (caixa.Text.Equals("som27"))
            {
                MidBaquetaDireita = "som27";
            }

            if (caixa.Text.Equals("som28"))
            {
                MidBaquetaDireita = "som28";
            }

            if (caixa.Text.Equals("som29"))
            {
                MidBaquetaDireita = "som29";
            }

            if (caixa.Text.Equals("som30"))
            {
                MidBaquetaDireita = "som30";
            }

            if (caixa.Text.Equals("som31"))
            {
                MidBaquetaDireita = "som31";
            }

            if (caixa.Text.Equals("som32"))
            {
                MidBaquetaDireita = "som32";
            }

            if (caixa.Text.Equals("som33"))
            {
                MidBaquetaDireita = "som33";
            }

            if (caixa.Text.Equals("som34"))
            {
                MidBaquetaDireita = "som34";
            }

            if (caixa.Text.Equals("som35"))
            {
                MidBaquetaDireita = "som35";
            }

            if (caixa.Text.Equals("som36"))
            {
                MidBaquetaDireita = "som36";
            }

            if (caixa.Text.Equals("som37"))
            {
                MidBaquetaDireita = "som37";
            }

            if (caixa.Text.Equals("som38"))
            {
                MidBaquetaDireita = "som38";
            }

            if (caixa.Text.Equals("som39"))
            {
                MidBaquetaDireita = "som39";
            }


            config.Default.caixa = caixa.Text;
            config.Default.Save();
        }
        
        private void bumbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bumbo.Text.Equals("som1"))
            {
                MidPedalDireito = "som1";
            }

            if (bumbo.Text.Equals("som2"))
            {
                MidPedalDireito = "som2";
            }

            if (bumbo.Text.Equals("som3"))
            {
                MidPedalDireito = "som3";
            }

            if (bumbo.Text.Equals("som4"))
            {
                MidPedalDireito = "som4";
            }

            if (bumbo.Text.Equals("som5"))
            {
                MidPedalDireito = "som5";
            }

            if (bumbo.Text.Equals("som6"))
            {
                MidPedalDireito = "som6";
            }

            if (bumbo.Text.Equals("som7"))
            {
                MidPedalDireito = "som7";
            }

            if (bumbo.Text.Equals("som8"))
            {
                MidPedalDireito = "som8";
            }

            if (bumbo.Text.Equals("som9"))
            {
                MidPedalDireito = "som9";
            }

            if (bumbo.Text.Equals("som10"))
            {
                MidPedalDireito = "som10";
            }

            if (bumbo.Text.Equals("som11"))
            {
                MidPedalDireito = "som11";
            }

            if (bumbo.Text.Equals("som12"))
            {
                MidPedalDireito = "som12";
            }

            if (bumbo.Text.Equals("som13"))
            {
                MidPedalDireito = "som13";
            }

            if (bumbo.Text.Equals("som14"))
            {
                MidPedalDireito = "som14";
            }

            if (bumbo.Text.Equals("som15"))
            {
                MidPedalDireito = "som15";
            }

            if (bumbo.Text.Equals("som16"))
            {
                MidPedalDireito = "som16";
            }

            if (bumbo.Text.Equals("som17"))
            {
                MidPedalDireito = "som17";
            }

            if (bumbo.Text.Equals("som18"))
            {
                MidPedalDireito = "som18";
            }

            if (bumbo.Text.Equals("som19"))
            {
                MidPedalDireito = "som19";
            }

            if (bumbo.Text.Equals("som20"))
            {
                MidPedalDireito = "som20";
            }

            if (bumbo.Text.Equals("som21"))
            {
                MidPedalDireito = "som21";
            }

            if (bumbo.Text.Equals("som22"))
            {
                MidPedalDireito = "som22";
            }

            if (bumbo.Text.Equals("som23"))
            {
                MidPedalDireito = "som23";
            }

            if (bumbo.Text.Equals("som24"))
            {
                MidPedalDireito = "som24";
            }

            config.Default.bumbo = bumbo.Text;
            config.Default.Save();
        }
        
        private void pedalChimbal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedalChimbal.Text.Equals("som1"))
            {
                MidPedalEsquerdo = "som1";
            }

            if (pedalChimbal.Text.Equals("som2"))
            {
                MidPedalEsquerdo = "som2";
            }

            if (pedalChimbal.Text.Equals("som3"))
            {
                MidPedalEsquerdo = "som3";
            }

            if (pedalChimbal.Text.Equals("som4"))
            {
                MidPedalEsquerdo = "som4";
            }

            if (pedalChimbal.Text.Equals("som5"))
            {
                MidPedalEsquerdo = "som5";
            }

            if (pedalChimbal.Text.Equals("som6"))
            {
                MidPedalEsquerdo = "som6";
            }

            if (pedalChimbal.Text.Equals("som7"))
            {
                MidPedalEsquerdo = "som7";
            }

            if (pedalChimbal.Text.Equals("som8"))
            {
                MidPedalEsquerdo = "som8";
            }

            if (pedalChimbal.Text.Equals("som9"))
            {
                MidPedalEsquerdo = "som9";
            }

            if (pedalChimbal.Text.Equals("som10"))
            {
                MidPedalEsquerdo = "som10";
            }

            if (pedalChimbal.Text.Equals("som11"))
            {
                MidPedalEsquerdo = "som11";
            }

            if (pedalChimbal.Text.Equals("som12"))
            {
                MidPedalEsquerdo = "som12";
            }

            if (pedalChimbal.Text.Equals("som13"))
            {
                MidPedalEsquerdo = "som13";
            }

            if (pedalChimbal.Text.Equals("som14"))
            {
                MidPedalEsquerdo = "som14";
            }

            if (pedalChimbal.Text.Equals("som15"))
            {
                MidPedalEsquerdo = "som15";
            }

            if (pedalChimbal.Text.Equals("som16"))
            {
                MidPedalEsquerdo = "som16";
            }

            if (pedalChimbal.Text.Equals("som17"))
            {
                MidPedalEsquerdo = "som17";
            }

            if (pedalChimbal.Text.Equals("som18"))
            {
                MidPedalEsquerdo = "som18";
            }

            if (pedalChimbal.Text.Equals("som19"))
            {
                MidPedalEsquerdo = "som19";
            }

            if (pedalChimbal.Text.Equals("som20"))
            {
                MidPedalEsquerdo = "som20";
            }

            if (pedalChimbal.Text.Equals("som21"))
            {
                MidPedalEsquerdo = "som21";
            }

            if (pedalChimbal.Text.Equals("som22"))
            {
                MidPedalEsquerdo = "som22";
            }

            if (pedalChimbal.Text.Equals("som23"))
            {
                MidPedalEsquerdo = "som23";
            }

            if (pedalChimbal.Text.Equals("som24"))
            {
                MidPedalEsquerdo = "som24";
            }

            if (pedalChimbal.Text.Equals("som25"))
            {
                MidPedalEsquerdo = "som25";
            }

            config.Default.chimbalAberto = pedalChimbal.Text;
            config.Default.Save();
        }
    
    }
}

