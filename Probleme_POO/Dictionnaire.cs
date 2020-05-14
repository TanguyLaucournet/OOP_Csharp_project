using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Probleme_POO
{
    class Dictionnaire
    {
      
        List<string> mots3 = new List<string>();
        List<string> mots4 = new List<string>();
        List<string> mots5 = new List<string>();
        List<string> mots6 = new List<string>();
        List<string> mots7 = new List<string>();
        List<string> mots8 = new List<string>();
        List<string> mots9 = new List<string>();
        List<string> mots10 = new List<string>();
        List<string> mots11 = new List<string>();
        List<string> mots12 = new List<string>();
        List<string> mots13 = new List<string>();
        List<string> mots14 = new List<string>();

        public int[] listLen = new int[12];

        public Dictionnaire(string filename)
        {
            
            ReadFile(filename);
            listLen[0] = mots3.Count;
            listLen[1] = mots4.Count;
            listLen[2] = mots5.Count;
            listLen[3] = mots6.Count;
            listLen[4] = mots7.Count;
            listLen[5] = mots8.Count;
            listLen[6] = mots9.Count;
            listLen[7] = mots10.Count;
            listLen[8] = mots11.Count;
            listLen[9] = mots12.Count;
            listLen[10] = mots13.Count;
            listLen[11] = mots14.Count;
        }

       
        /// <summary>
        /// Fonction ReadFIle lis de fichier et repère le nombre de lettre du mot et stock le mot a l'endroit adapté
        /// </summary>
        /// <param name="filename"></param>
        public void ReadFile(String filename)
        {
            StreamReader flux = new StreamReader(filename);
            int nbLettres = 0;



            string line;

            char[] separateur = { ' ' };
            try
            {

                while ((line = flux.ReadLine()) != null)
                {
                    //flux = new StreamReader(filename);
                    string[] s = line.Split(separateur);
                    if (s.Length < 2)
                    {
                        nbLettres = int.Parse(s[0]);
                    }
                    else
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            switch (nbLettres)
                             {

                                 
                                 case 3:
                                     mots3.Add(s[i]);
                                     break;
                                 case 4:

                                     mots4.Add(s[i]);
                                     break;
                                 case 5:
                                     mots5.Add(s[i]);
                                     break;
                                 case 6:
                                     mots6.Add(s[i]);
                                     break;
                                 case 7:
                                     mots7.Add(s[i]);
                                     break;
                                 case 8:
                                     mots8.Add(s[i]);
                                     break;
                                 case 9:
                                     mots9.Add(s[i]);
                                     break;
                                 case 10:
                                     mots10.Add(s[i]);
                                     break;
                                 case 11:
                                     mots11.Add(s[i]);
                                     break;
                                 case 12:
                                     mots12.Add(s[i]);
                                     break;
                                 case 13:
                                     mots13.Add(s[i]);
                                     break;
                                 case 14:
                                     mots14.Add(s[i]);
                                     break;




                             }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (flux != null) { flux.Close(); }
            }
        }
        public bool RechDichoRecursif(int debut, int fin, string mot)
        {
            mot = mot.ToUpper();
            int nbLettres = mot.Length;
            int milieu = (debut + fin) / 2;
            if (debut > fin)
            { return false; }
            else
            {
                switch (nbLettres)
                {
                    case 3:

                        if (mot == mots3[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots3[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu+1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu-1, mot);  }

                        

                    case 4:
                        if (mot == mots4[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots4[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }


                      case 5:
                        if (mot == mots5[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots5[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }


                    case 6:
                        if (mot == mots6[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots6[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }


                    case 7:
                        if (mot == mots7[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots7[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }


                    case 8:
                        if (mot == mots8[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots8[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 9:
                        if (mot == mots9[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots9[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 10:
                        if (mot == mots10[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots10[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 11:
                        if (mot == mots11[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots11[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 12:
                        if (mot == mots12[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots12[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 13:
                        if (mot == mots13[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots13[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    case 14:
                        if (mot == mots14[milieu])
                        { return true; }
                        else if (String.Compare(mot, mots14[milieu], true) > 0)
                        {
                            return RechDichoRecursif(milieu + 1, fin, mot);
                        }
                        else { return RechDichoRecursif(debut, milieu - 1, mot); }

                    default: return false;
                }
            }
        }

       override public string ToString()
        {
            return "";
        }

    }
}
