﻿using matkateenused.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace matkateenused.Services
{
    public class HikesServices
    {
        private static List<Hikes> hikes = new List<Hikes>
        {
            new Hikes
            {
                Name = "   Militaarmatkad",
                HeroImage = "img_military.jpg",
                Description = "Tere tulemast militaarmatkale Paldiski linnas! Lähete sügavale metsa, kus instruktorid juhendavad teid läbi rasketes tingimustes, mis simuleerivad tõelisi sõjalisi stsenaariume. Matk hõlmab relvade kasutamist, sõidukite juhtimist ja taktikalisi otsuseid. Ületate takistusi, külastate mahajäetud sõjaväeobjekte ja lahendate meeskonnatöö väljakutseid. Saate kogemusi ja oskusi, mis annavad vajalikud teadmised ja enesekindluse rasketes olukordades hakkama saamiseks. See on tõeline adrenaliin ja seiklus!",
                Guide = "Marta Vasarik",
                Price = 100,
               AccentColorStart = Color.FromArgb("#e6ffff"),
                AccentColorEnd = Color.FromArgb("#80ffff"),
                Images = new List<string>
                {
                    "sygaviik.jpg",
                    "img_mountains.png",
                    "maestik.png"
                }
            },
            new Hikes
            {
                Name = "   Kanuumatkad",
                HeroImage = "kanuu.jpg",
                Description = "Tere tulemast kanuumatkale Eestimaa jõgedel - seiklus, mida sa ei unusta kunagi! " +
                "Meie matkad sobivad ideaalselt kogu perele, kuid oleme mõelnud ka nõudlikumatele adrenaliinihuvilistele. " +
                "Meie kogenud instruktorid aitavad teil valmistuda ja õpetavad teile kanuumatka aluseid, et tunneksite end" +
                "looduse ilu nautides mugavalt ning turvaliselt. Olenemata sellest, kas soovite nautida rahulikku sõitu mööda " +
                "jõge või otsite seiklust ja adrenaliini, pakume teile unustamatuid kanuumatka kogemusi Eestimaa jõgedel. Tule ja" +
                " ühine meiega seikluseks!\r\n Matkajuht Renata on kirglik ja särav inimene, kellel on pikk kogemus seiklemisel erinevatel " +
                "maailma jõgedel. Ta on tõeline loodusesõber ja pühendunud kanuumatkade instruktor, kes aitab inimestel avastada looduse võlu ja " +
                "õpetab neile turvalise kanuusõidu alused. Renata on tähelepanelik ja empaatiline, alati valmis abistama ning vastama küsimustele. " +
                "Tema kaasahaarav isiksus ja positiivne energia muudavad kanuumatka elamusterohkeks ja meeldejäävaks kogemuseks.",
                Guide = "Renata Vool",
                Price = 130,
                AccentColorStart = Color.FromArgb("#fff2e6"),
                AccentColorEnd = Color.FromArgb("#b35900"),
                Images = new List<string>
                {
                    "jarv.jpg",
                    "rafting.png",
                    "saar.png"
                }
            },
            new Hikes
            {
                Name = "   Loodusmatkad",
                HeroImage = "mets.png",
                Description = "Tere tulemast imelisse Eestimaa loodusesse, kus iga nurk on täis ilu ja võimalusi!" +
                "\n Meie matkad viivad sind läbi metsade, rabade, järvede ja mägede, avastades meie looduse mitmekesisust ja võlu. " +
                "Oled oodatud meiega koos kogema midagi, mis jääb sinuga kogu eluks. Matkad toimuvad nii jalgsi kui räätsadel, fotokaamera kaasas või ilma, ühe päeva jalutades või kuuvalgel telkides. Meie parimad loodusgiidid " +
                "juhendavad ja aitavad sul tundma õppida Eestimaa looduse floorat ja faunat. Kas oled valmis avastama Eestimaa looduse võlumaailma koos meiega? Ootame sind! Matkajuht Uma on särav ja sõbralik inimene," +
                " kes armastab loodust ja kõike sellega seonduvat. Ta  on suurepärane jutuvestja ning oskab rääkida kaasahaaravaid " +
                "lugusid, samas oskuslikult tutvustades Eestimaa looduse hästi hoitud saladusi. ",
                Guide = "Uma Rada",
                Price = 50,
                AccentColorStart = Color.FromArgb("#e6fff9"),
                AccentColorEnd = Color.FromArgb("#00b386"),
                Images = new List<string>
                {
                    "telk.png",
                    "jarv.jpg",
                    "saar.png"
                }
            }
        };

        public static List<Hikes> GetAllHikes()
        {
            foreach (var hike in hikes)
            {
                if (hike.Name.Contains("Loodus"))
                    hike.Type = HikeType.Nature;
                else if (hike.Name.Contains("Militaar"))
                    hike.Type = HikeType.Military;
                else if (hike.Name.Contains("Kanuu"))
                    hike.Type = HikeType.Canoe;
            }

            return hikes;
        }

        public static List<Hikes> GetFeaturedHikes()
        {
            var rnd = new Random();
            var randomizedHikes = hikes.OrderBy(item => rnd.Next());

            var featuredHikes = randomizedHikes.Take(3).ToList();

            // Set the Type property for each featured hike
            featuredHikes[0].Type = HikeType.Nature;
            featuredHikes[1].Type = HikeType.Military;
            featuredHikes[2].Type = HikeType.Canoe;

            return featuredHikes;
        }
    }
}
