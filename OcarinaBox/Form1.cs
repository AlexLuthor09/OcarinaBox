using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcarinaBox
{
    public partial class OcarinaBox : Form
    {
        public OcarinaBox()
        {
            InitializeComponent();
        }

        //--------------fonction------------------------------------
        void egnime(string Text,string site)
        {
            label4.Text = ("Etape " + (N_question + 1) + "\n" + Text);
            GoToSite(site);
            clear();
            N_question++;
            progressBar1.Value = N_question;
        }
        void egnimeT(string Text)
        {
            label4.Text = ("Etape " + (N_question + 1) + "\n" + Text);
            clear();
            N_question++;
            progressBar1.Value = N_question;

        }
        void GoToSite(string url)
        {
            System.Diagnostics.Process.Start(url);

        }
        void clear()
        {
            textBoxMP.Text = "";
        }
        //----------------- Constantes -----------------------------
        int N_question = 0;

        string video1 = "https://youtu.be/uiQ4UftlVm0";
        string video2 = "https://ocarina.be";

        string site1 = "https://ocarina.be ";
        string site2 = "https://www.instagram.com/p/CDbo78DF5Yx/";
        string site3 = "https://www.facebook.com/ocarinatournai";
        string site4 = "https://www.facebook.com/ocarinaasbl";        

        string text1 = "Avant de commencer le protocole , nous voulons vérifier que les ocariniens connaissent bien  les valeurs de notre bel organisme. Quelles sont-elles? (crememotomichel...)";
        string text2 = "Où ce trouve le mot « salut » sur l’image  : centre , hautdroite, hautgauche, basgauche, basdroite ?(cremearase)";
        string text3 = "Durant le confinement, Ocarina Tournai Permanents a organisé plusieurs défis…. \n Lors du défi n°7 , que devions nous partager à nos semblables? (motdepasse)";
        string text4 = "Combien de centilitre de gel douche les permanent ont confectionnés en team building ? (000)";
        string text5 = "ous savez tous que la formation de la team formateur R a été compliquée. Un visuel a bcp tourné dans les mails de FX et du national. Une chose est précisée dans ce visuel : “ Qui dit formation dit ________ “ (creme)";
        string text6 = "Dans cette étape du protocole, on aimerait voir si vous avez encore une culture musical. Trouver donc le titre de cette chanson grâce au couplet suivant : \n Nageant dans le brouillard \nEnlacés, roulant dans l'herbe \n On écoutera Tom à la guitare \n Phil à la kéna, jusqu'à la nuit noire \n Un autre arrivera pour nous dire des nouvelles \n D'un qui reviendra dans un an ou deux \n Puisqu'il est heureux, on s'endormira \n (motdepasse)";
        string text7 = "Les hauts-dignitaires se doivent de connaître les noms de toutes les régios. Pour vérifier cela vous devez fournir les initiales des différentes régios dans l’ordre alphabétique (AAAAAAAAAAAA) ";
        string text8 = "Pour cette étape du protocole, on se demandait si vous saviez au moins où et quand se passait le congrès. Montrez nous que vous savez! (LieuJJ/MM/AAAA)";
        string text9 = "Pour terminer le protocole, nous tenions à vous rappeler la date de votre prochaine réunion. Ne nous remerciez pas surtout, c’est cadeau. Le code est donc la date de la prochaine commission congrès (JJ/MM/AAAA)";
        string text10 = "Merci d'avoir participé et bonne vidéo , vous pouvez maintenant couper l'application :D";
        //----------------------------------------------------------
        private void ValidationButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                switch (textBoxMP.Text)
                {
                    case  "centre":                   //mot de passe pour site 1 
                        if (N_question == 2)
                        {                           
                            egnime(text3, site3);
                        }
                        break;

                    case "bonsplans":                   //mot de passe pour site 2
                        if (N_question == 3)
                        {
                           
                            egnime(text4, site4);
                        }
                        break;


                    case "225":                   //mot de passe pour site 3
                        if (N_question == 4)
                        {
                            egnimeT(text5);
                        }
                        break;

                    case "preparation":                   //mot de passe pour site 4
                        if (N_question == 5)
                        {
                            egnimeT(text6);
                        }
                        break;
                    case "sanfrancisco":                   //Vrai mot de passe
                        if (N_question == 6)
                        {
                            egnimeT(text7);
                        }
                        break;
                    case "BBDEHLLMMNPTTV":                   //Vrai mot de passe
                        if (N_question == 7)
                        {
                            egnimeT(text8);
                        }
                        break;
                    case "Massembre16/10/2021":                   //Vrai mot de passe
                        if (N_question == 8)
                        {
                            egnimeT(text9);
                        }
                        break;
                    case "30/09/2020":                   //Vrai mot de passe
                        if (N_question == 9)
                        {
                            label4.Text = (text10);                        
                            clear();
                            GoToSite(video2);
                            N_question++;
                            progressBar1.Value = N_question;
                            this.ControlBox = true;
                        }
                        break;

                    default:
                        
                        if (N_question == 1 && textBoxMP.Text != "")
                        {
                            egnime(text2, site2);                         
                        }
                        else if (N_question == 0 && textBoxMP.Text != "")
                        {
                            
                            egnime(text1, site1);
                        
                        }
                        else  
                        {
                            MessageBox.Show("ERROR : Mauvais mot de passe");
                        }
                        break;
                }
                
            }
        
        }

        private void OcarinaBox_Load(object sender, EventArgs e)
        {
            GoToSite(video1);
        }
    }
}
