using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace FastCaracterGenerator
{
    //http://members.iinet.net.au/~rene1/realnpc.htm
    public  class GeneratorName
    {
        List<string> sexeList = new List<string>();
        List<string> mainList = new List<string>();

        string humanFemaleNamesFiles;
        List<string> humanFemaleNamesList;
        string humanMaleNamesFiles;
        List<string> humanMaleNamesList;
        string peuplesFiles;
        List<string> peuplesList;


        string archétypesFiles;
        List<string> archétypesList;
        string spécialitésFiles;
        List<string> spécialitésList;
        string carrièresFiles;
        List<string> carrièresList;

        string statsFiles;
        List<string> statsList;
        public List<int> cStats;
        string motivationAmbitionsFiles;
        string motivationCausesFiles;
        string motivationRelationsFiles;
        string obligationsFiles;
        string TraitsPersonnalitéFiles;
        List<string> TraitsPersonnalitéList;

        public Character character;
        
        private Random random;

        public GeneratorName()
        {
            random = new Random();

            humanFemaleNamesList = new List<string>();
            humanMaleNamesList = new List<string>();
            peuplesList = new List<string>();
            archétypesList = new List<string>();
            spécialitésList = new List<string>();
            carrièresList = new List<string>();
            statsList = new List<string>();
            TraitsPersonnalitéList = new List<string>();

            cStats = new List<int>();

            archétypesFiles = FastCaracterGenerator.Properties.Resources.Archétypes;
            carrièresFiles = FastCaracterGenerator.Properties.Resources.Carrières;
            humanFemaleNamesFiles = FastCaracterGenerator.Properties.Resources.HumanFemaleNames;
            humanMaleNamesFiles = FastCaracterGenerator.Properties.Resources.HumanMaleNames;
            motivationAmbitionsFiles = FastCaracterGenerator.Properties.Resources.MotivationAmbitions;
            motivationCausesFiles = FastCaracterGenerator.Properties.Resources.MotivationCauses;
            motivationRelationsFiles = FastCaracterGenerator.Properties.Resources.MotivationRelations;
            obligationsFiles = FastCaracterGenerator.Properties.Resources.Obligations;
            peuplesFiles = FastCaracterGenerator.Properties.Resources.Peuples;
            spécialitésFiles = FastCaracterGenerator.Properties.Resources.Spécialités;
            statsFiles = FastCaracterGenerator.Properties.Resources.Stats;
            TraitsPersonnalitéFiles = FastCaracterGenerator.Properties.Resources.TraitsPersonnalité;

            sexeList.Add("Homme");
            sexeList.Add("Femme");

            //mainList feed
            {
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Droitier");
                mainList.Add("Gaucher");
                mainList.Add("Gaucher");
                mainList.Add("Gaucher");
                mainList.Add("Ambidextre");
            }

            string line;
            StringReader stringReader = new StringReader(humanFemaleNamesFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    humanFemaleNamesList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(humanMaleNamesFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    humanMaleNamesList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(peuplesFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    peuplesList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(archétypesFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    archétypesList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(spécialitésFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    spécialitésList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(carrièresFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    carrièresList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(statsFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    statsList.Add(line);
                }
                else
                {
                    break;
                }
            }
            stringReader = new StringReader(TraitsPersonnalitéFiles);
            while (true)
            {
                line = stringReader.ReadLine();
                if (line != null)
                {
                    TraitsPersonnalitéList.Add(line);
                }
                else
                {
                    break;
                }
            }


            foreach (string str in statsList)
            {
                cStats.Add(0);
            }

            this.character = new Character();
            GeneratNPC(0);
        }

        public void GeneratNPC(int lv)
        {
            string cSexe = sexeList[random.Next(sexeList.Count)];
            string cNom;
            string cNurnom = "";
            switch (cSexe)
            {
                case "Homme":
                    cNom = humanMaleNamesList[random.Next(humanMaleNamesList.Count)];
                    break;
                case "Femme":
                    cNom = humanFemaleNamesList[random.Next(humanFemaleNamesList.Count)];
                    break;
                default:
                    cNom = humanMaleNamesList[random.Next(humanMaleNamesList.Count)];
                    break;
            }

            string cMain = mainList[random.Next(mainList.Count)];

            string sepTab = "\t";
            string[] cArchétype = archétypesList[random.Next(archétypesList.Count)].Split(sepTab.ToCharArray());
            string sepVirgule = ",";
            string[] traits = cArchétype[cArchétype.Length - 1].Split(sepVirgule.ToCharArray());
            string str;
            for(int i = 0; i< traits.Length; i++)
            {
                str = traits[i];
                if (str.Substring(0, 1) == " ")
                {
                    traits[i] = traits[i].Substring(1);
                }
            }

            string traitsForChar = traits[random.Next(traits.Length-1)];
            str = traits[random.Next(traits.Length - 1)];
            while (traitsForChar == str)
            {
                str = traits[random.Next(traits.Length - 1)];
            }

            traitsForChar += ", " + str;
            string[] cPeuple = peuplesList[random.Next(0,2)].Split(sepTab.ToCharArray());
            //string[] cPeuple = peuplesList[random.Next(peuplesList.Count)].Split(sepTab.ToCharArray());
            string[] cCarriere = carrièresList[random.Next(carrièresList.Count)].Split(sepTab.ToCharArray());
            List<string> cBonusCarriere = new List<string>();
            for (int i = 2; i< cCarriere.Length; i++)
            {
                cBonusCarriere.Add(cCarriere[i]);
            }



            string cTraitDeCaractère = TraitsPersonnalitéList[random.Next(TraitsPersonnalitéList.Count)];

            bool positive = false;
            bool negative = false;
            string first2char;
            for (int i = 0; i < cStats.Count; i++)
            {
                cStats[i] = Int32.Parse(cPeuple[i+1]) + random.Next(1, 11) + random.Next(1, 11);
                if(cArchétype[i + 1].Length > 1)
                {
                     first2char = cArchétype[i + 1].Substring(0, 2);
                }
                else
                {
                    first2char = "";
                }
                
                if (first2char == "/+")
                {
                    if (positive || random.Next(0, 2) == 0)
                    {
                        cStats[i] += Int32.Parse(cArchétype[i + 1].Substring(1, 2));
                    }
                    else
                    {
                        positive = true;
                    }
                }
                else
                {
                    if (first2char == "/-")
                    {
                        if (negative || random.Next(0, 2) == 0)
                        {
                            cStats[i] += Int32.Parse(cArchétype[i + 1].Substring(1, 2));
                        }
                        else
                        {
                            negative = true;
                        }
                    }
                    else
                    {
                        cStats[i] += Int32.Parse(cArchétype[i + 1]);
                    }
                }
            }

            string currentString;
            int valueInt = 0;
            while (lv > 0)
            {
                valueInt = random.Next(cBonusCarriere.Count);
                currentString = cBonusCarriere[valueInt];
                if (currentString != "+2" || currentString != "*4")
                {
                    if (currentString == "+")
                    {
                        cBonusCarriere[valueInt] = "+1";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "+1")
                    {
                        cBonusCarriere[valueInt] = "+2";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*")
                    {
                        cBonusCarriere[valueInt] = "*1";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*1")
                    {
                        cBonusCarriere[valueInt] = "*2";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*2")
                    {
                        cBonusCarriere[valueInt] = "*3";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*3")
                    {
                        cBonusCarriere[valueInt] = "*4";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                }
            }
            
            if (cStats[6] >= 19 || cCarriere[0] == "Occultiste"
                    || cCarriere[1] == "Initié, Prêtre" || cCarriere[1] == "Chasseur de sorcières")
            {
                int value = random.Next(5, 10) + random.Next(5, 10) +
                    random.Next(5, 10) + random.Next(5, 10) + random.Next(5, 10);
                cStats[6] = value;
                int val = 6;
                while(value > 0)
                {
                    while (val == 6)
                    {
                        val = random.Next(0, cStats.Count);
                    }
                    if (cStats[val] > 15)
                    {
                        cStats[val]--;
                        value--;
                    }
                    val = random.Next(0, cStats.Count);
                }
            }
            else
            {
                cStats[6] = 0;
            }
            
            character.nom = cNom;
            character.surnom = cNurnom;
            character.peuple = cPeuple[0];
            character.archetype = cArchétype[0] + "  (" + traitsForChar +")";
            character.caracteristiques = cStats;
            character.carriere = cCarriere[0] + ", " + cCarriere[1];
            character.bonusCarriere = cBonusCarriere;
            character.PV = cStats[4]/5 + cStats[3] / 5 + cStats[12] / 10;
            character.ptsFortune = cStats[12] / 5;
            character.bonusForce = cStats[4] / 10;
            character.mainDirigeante = cMain;
            character.sexe = cSexe;
            character.age = random.Next(15,51);
            character.poids = random.Next(20, 50) + random.Next(20, 50);
            character.taille = random.Next(75, 100) + random.Next(75, 100);
            character.cheveux = "-";
            character.yeux = "-";
            character.description = "-";
            character.traitsDeCaractère = cTraitDeCaractère;
        }

        public void RerollStats(int lv)
        {
            string sepTab = "\t";
            string[] cArchétype = archétypesList[random.Next(archétypesList.Count)].Split(sepTab.ToCharArray());
            string sepVirgule = ",";
            string[] traits = cArchétype[cArchétype.Length - 1].Split(sepVirgule.ToCharArray());
            
            bool positive = false;
            bool negative = false;
            string first2char;
            string[] cPeuple = peuplesList[random.Next(0, 2)].Split(sepTab.ToCharArray());

            for (int i = 0; i < cStats.Count; i++)
            {
                cStats[i] = Int32.Parse(cPeuple[i + 1]) + random.Next(1, 11) + random.Next(1, 11);
                if (cArchétype[i + 1].Length > 1)
                {
                    first2char = cArchétype[i + 1].Substring(0, 2);
                }
                else
                {
                    first2char = "";
                }

                if (first2char == "/+")
                {
                    if (positive || random.Next(0, 2) == 0)
                    {
                        cStats[i] += Int32.Parse(cArchétype[i + 1].Substring(1, 2));
                    }
                    else
                    {
                        positive = true;
                    }
                }
                else
                {
                    if (first2char == "/-")
                    {
                        if (negative || random.Next(0, 2) == 0)
                        {
                            cStats[i] += Int32.Parse(cArchétype[i + 1].Substring(1, 2));
                        }
                        else
                        {
                            negative = true;
                        }
                    }
                    else
                    {
                        cStats[i] += Int32.Parse(cArchétype[i + 1]);
                    }
                }
            }

            string[] cCarriere= { };
            foreach (string str in carrièresList)
            {
                if(character.carriere == str.Split(sepTab.ToCharArray())[0] +", " + str.Split(sepTab.ToCharArray())[1])
                {
                    cCarriere = str.Split(sepTab.ToCharArray());
                    break;
                }
            }

            //string[] cCarriere = carrièresList[random.Next(carrièresList.Count)].Split(sepTab.ToCharArray());
            List<string> cBonusCarriere = new List<string>();
            for (int i = 2; i < cCarriere.Length; i++)
            {
                cBonusCarriere.Add(cCarriere[i]);
            }
            string currentString;
            int valueInt = 0;
            while (lv > 0)
            {
                valueInt = random.Next(cBonusCarriere.Count);
                currentString = cBonusCarriere[valueInt];
                if (currentString != "+2" || currentString != "*4")
                {
                    if (currentString == "+")
                    {
                        cBonusCarriere[valueInt] = "+1";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "+1")
                    {
                        cBonusCarriere[valueInt] = "+2";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*")
                    {
                        cBonusCarriere[valueInt] = "*1";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*1")
                    {
                        cBonusCarriere[valueInt] = "*2";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*2")
                    {
                        cBonusCarriere[valueInt] = "*3";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                    if (currentString == "*3")
                    {
                        cBonusCarriere[valueInt] = "*4";
                        cStats[valueInt] += 5;
                        lv--;
                        continue;
                    }
                }
            }


            if (cStats[6] >= 19 || cCarriere[0] == "Occultiste"
                    || cCarriere[1] == "Initié, Prêtre" || cCarriere[1] == "Chasseur de sorcières")
            {
                int value = random.Next(5, 10) + random.Next(5, 10) +
                    random.Next(5, 10) + random.Next(5, 10) + random.Next(5, 10);
                cStats[6] = value;
                int val = 6;
                while (value > 0)
                {
                    while (val == 6)
                    {
                        val = random.Next(0, cStats.Count);
                    }
                    if (cStats[val] > 15)
                    {
                        cStats[val]--;
                        value--;
                    }
                    val = random.Next(0, cStats.Count);
                }
            }
            else
            {
                cStats[6] = 0;
            }
            character.caracteristiques = cStats;
            character.bonusCarriere = cBonusCarriere;
            character.PV = cStats[4] / 5 + cStats[3] / 5 + cStats[12] / 10;
            character.ptsFortune = cStats[12] / 5;
            character.bonusForce = cStats[4] / 10;
        }

        public string AnswerBuilderToString()
        {
            return character.ToStringCharacter();
        }
    }
}