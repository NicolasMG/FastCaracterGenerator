using System.Collections.Generic;

namespace FastCaracterGenerator
{
    public class Character
    {
        public string nom;
        public string surnom;
        public string peuple;
        public string archetype;
        public string carriere;
        public List<string> bonusCarriere;
        public string sexe;
        public int age;
        public int taille;
        public int poids;
        public string mainDirigeante;
        public string cheveux;
        public string yeux;
        public string description;
        public string traitsDeCaractère;

        public int PV;

        public List<int> caracteristiques; //COM CNS DIS END FOR HAB MAG MVT PER SOC SRV TIR VOL

        public int ptsFortune;
        public int bonusForce;
        
        public Character(string nom, string surnom, string peuple, string archetype,
            string carriere, List<string> bonusCarriere, string sexe, int age, int taille, int poids, string mainDirigeante,
            string cheveux, string yeux, string description, string traitsDeCaractère)
        {
            this.nom = nom;
            this.surnom = surnom;
            this.peuple = peuple;
            this.archetype = archetype;
            this.carriere = carriere;
            this.bonusCarriere = bonusCarriere;
            this.sexe = sexe;
            this.age = age;
            this.taille = taille;
            this.poids = poids;
            this.mainDirigeante = mainDirigeante;
            this.cheveux = cheveux;
            this.yeux = yeux;
            this.description = description;
            this.traitsDeCaractère = traitsDeCaractère;
        }

        public Character()
        {
        }

        public string ToStringCharacter()
        {
            string returnString = "";
            if (nom != null)
            {
                returnString += "Nom : " + nom + "    ";
            }
            if (surnom != null)
            {
                returnString += "Surnom : " + surnom;
            }
            returnString += System.Environment.NewLine;
            if (peuple!= null)
            {
                returnString += "Peuple : " + peuple + "    ";
            }
            if (archetype != null)
            {
                returnString += "Archetype : " + archetype;
            }
            returnString += System.Environment.NewLine;
            if (carriere != null)
            {
                returnString += "Carriere : " + carriere;
            }
            returnString += System.Environment.NewLine;

            if (sexe != null)
            {
                returnString += "Sexe : " + sexe + "    ";
            }
            if (age != -1)
            {
                returnString += "Age : " + age + "    ";
            }
            if (taille != -1 )
            {
                returnString += "Taille : " + taille + " cm    ";
            }
            if (poids != -1)
            {
                returnString += "Poids : " + poids + " kg    ";
            }
            returnString += System.Environment.NewLine;
            if (cheveux != null)
            {
                returnString += "Cheveux : " + cheveux + "    ";
            }
            if (yeux != null)
            {
                returnString += "Yeux : " + yeux + "    ";
            }
            if (mainDirigeante != null)
            {
                returnString += "Main dirigeante : " + mainDirigeante + "    ";
            }
            returnString += System.Environment.NewLine;

            if (description != null)
            {
                returnString += "Description : " + description + "    ";
            }
            returnString += System.Environment.NewLine;
            if (traitsDeCaractère != null)
            {
                returnString += "Traits de caractère : " + traitsDeCaractère + "    ";
            }
            returnString += System.Environment.NewLine;
            returnString += System.Environment.NewLine;

            if (PV != -1)
            {
                returnString += "PV : " + PV + "    ";
            }
            returnString += System.Environment.NewLine;
            returnString += System.Environment.NewLine;
            returnString += "Modificateur aux dégâts(BF) : + " + bonusForce;
            returnString += System.Environment.NewLine;
            returnString += System.Environment.NewLine;

            returnString += "COM   CNS   DIS   END   FOR   HAB   MAG   MVT   PER   SOC   SRV   TIR   VOL";
            returnString += System.Environment.NewLine;
            foreach(int i in caracteristiques)
            {
                if(i < 100)
                {
                    returnString += i.ToString(" 00") + "   ";
                }
                else
                {
                    returnString += i.ToString("000") + "   ";
                }
            }
            returnString += System.Environment.NewLine;
            
            foreach (string str in bonusCarriere)
            {
                if (str.Length == 1)
                {
                    if (str == "-")
                    {
                        returnString += "      ";
                    }
                    else
                    {
                        if (str == "+")
                        {
                            returnString += " \u25A1    ";
                        }
                        else
                        {
                            returnString += "\u25A1 \u25A1   ";
                        }
                    }
                }
                else
                {
                    if (str == "+1")
                    {
                        returnString += " \u25CB    ";
                    }
                    if (str == "+2")
                    {
                        returnString += " \u25A0    ";
                    }
                    if (str == "*1")
                    {
                        returnString += "\u25A1 \u25CB   ";
                    }
                    if (str == "*2")
                    {
                        returnString += "\u25A1 \u25A0   ";
                    }
                    if (str == "*3")
                    {
                        returnString += "\u25CB \u25A0   ";
                    }
                    if (str == "*4")
                    {
                        returnString += "\u25A0 \u25A0   ";
                    }
                }
            }
            returnString += System.Environment.NewLine;

            int a;
            foreach (int i in caracteristiques)
            {
                a = 50 - i;
                if (a > 0)
                {
                    returnString += "+" + a.ToString("00") + "   ";
                }
                if (a == 0)
                {
                    returnString += " 0 " + "   ";
                }
                if (a < 0)
                {
                    returnString += a.ToString("00") + "   ";
                }
            }

            returnString += System.Environment.NewLine;

            //returnString += "\u25A0";
            //returnString += " ";
            //returnString += "\u25CB";
            //returnString += " ";
            //returnString += "\u25A1";
            returnString += System.Environment.NewLine;
            
            return returnString;
        }
    }
}