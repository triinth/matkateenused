using matkateenused.Models;

namespace matkateenused.Services
{
    internal static class HikesServices
    {
        private static List<Hikes> hikes = new()
        {
            new()
            {
                Name = "Militaarmatkad",
                HeroImage = "brita.jpg",
                Description = "Tere tulemast militaarmatkale Paldiski linnas! Lähete sügavale metsa, kus instruktorid juhendavad teid läbi rasketes tingimustes, mis simuleerivad tõelisi sõjalisi stsenaariume. " +
                "Matk hõlmab relvade kasutamist, sõidukite juhtimist ja taktikalisi otsuseid. Ületate takistusi, külastate mahajäetud sõjaväeobjekte ja lahendate meeskonnatöö väljakutseid. Saate kogemusi ja oskusi, " +
                "mis annavad vajalikud teadmised ja enesekindluse rasketes olukordades hakkama saamiseks. See on tõeline adrenaliin ja seiklus! \r\n Matkajuht Brita on kogenud militaarvaldkonna professionaal ja seiklusjanuline giid." +
                " Ta on spetsialiseerunud keerukate stsenaariumide loomisele, et pakkuda autentset sõjalist kogemust. Inimesena on ta kaasahaarav ja motiveeriv, aidates matkajatel ületada oma piire, avastada enda tugevusi, kogeda " +
                "adrenaliini ja lahendada meeskonnatöö väljakutseid. Kui soovid kogeda midagi erilist ja väljakutset pakkuvat, siis oled väga oodatud.",
                Guide = "Brita Taff",
                Price = 100,
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://static.wixstatic.com/media/b5200d_44db052515984911b4f70b8502ed9b3a~mv2.jpg/v1/fill/w_693,h_462,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/mariell.jpg",
                    "https://matkarada.ee/sites/default/files/2020-08/Paldiski%20300%20Muula%20kindluses.jpg",
                    "https://matkarada.ee/sites/default/files/2020-11/_MG_3692_.JPG"

                }
            },

            new()
            {
                Name = "Kanuumatkad",
                HeroImage = "renata.jpg",
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
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://visitviljandi.ee/wp-content/uploads/2023/04/1_-1_false_false_81817eb0e3f84a019e9e9a35bafc8962-1.jpg",
                    "https://visitviljandi.ee/wp-content/uploads/2023/04/1_-1_false_false_8db473167e43cdda81eb66617810bf53-1.jpg",
                    "https://www.viikingitekyla.ee/wp-content/uploads/2017/06/viikingite-k%C3%BCla-kanuumatk.jpg"

                }
            },

            new()
            {
                Name = "Loodusmatkad",
                HeroImage = "uma.jpg",
                Description = "Tere tulemast imelisse Eestimaa loodusesse, kus iga nurk on täis ilu ja võimalusi! Meie matkad viivad sind läbi metsade, rabade, järvede ja mägede, avastades meie looduse mitmekesisust ja võlu. " +
                "Oled oodatud meiega koos kogema midagi, mis jääb sinuga kogu eluks. Matkad toimuvad nii jalgsi kui räätsadel, fotokaamera kaasas või ilma, ühe päeva jalutades või kuuvalgel telkides. Meie parimad loodusgiidid " +
                "juhendavad ja aitavad sul tundma õppida Eestimaa looduse floorat ja faunat. Kas oled valmis avastama Eestimaa looduse võlumaailma koos meiega? Ootame sind! \r\n Matkajuht Uma on särav ja sõbralik inimene," +
                " kes armastab loodust ja kõike sellega seonduvat. Ta  on suurepärane jutuvestja ning oskab rääkida kaasahaaravaid " +
                "lugusid, samas oskuslikult tutvustades Eestimaa looduse hästi hoitud saladusi. ",
                Guide = "Uma Rada",
                Price = 50,
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://www.ecb.ee/wp-content/uploads/2020/12/29153329605_2c21225925_k.jpg",
                    "https://images.rove.me/w_1920,q_85/vwzrl9fmhbkgogripe21/estonia-hiking.jpg",
                    "https://static.visitestonia.com/images/3626708/600_400_false_false_9ab2a55cc9c32d0b348d38bb2baaf942.jpg"

                }
            },
        };




        public static List<Hikes> GetAllHikes()
            => hikes;


        public static List<Hikes> GetFeaturedHikes()
        {
            var rnd = new Random();
            var randomizedHikes = hikes.OrderBy(item => rnd.Next());

            return randomizedHikes.Take(2).ToList();
        }
    }
}