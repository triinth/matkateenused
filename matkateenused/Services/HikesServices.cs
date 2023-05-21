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
                HeroImage = "Brita.jpg",
                Description = "Tere tulemast militaarmatkale Paldiski linnas! Lähete sügavale metsa, kus instruktorid juhendavad teid läbi rasketes tingimustes, mis simuleerivad tõelisi sõjalisi stsenaariume. Matk hõlmab relvade kasutamist, sõidukite juhtimist ja taktikalisi otsuseid. Ületate takistusi, külastate mahajäetud sõjaväeobjekte ja lahendate meeskonnatöö väljakutseid. Saate kogemusi ja oskusi, mis annavad vajalikud teadmised ja enesekindluse rasketes olukordades hakkama saamiseks. See on tõeline adrenaliin ja seiklus!",
                Guide = "Brita Taff",
                Price = 100,
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "",
                    "",
                    ""
                }
            },

            new()
            {
                Name = "Kanuumatkad",
                HeroImage = "Renata.jpg",
                Description = "Tere tulemast kanuumatkale Eestimaa jõgedel - seiklus, mida sa ei unusta kunagi! Meie matkad sobivad ideaalselt kogu perele, kuid oleme mõelnud ka nõudlikumatele adrenaliinihuvilistele. Meie kogenud instruktorid aitavad teil valmistuda ja õpetavad teile kanuumatka aluseid, et tunneksite end looduse ilu nautides mugavalt ning turvaliselt. Olenemata sellest, kas soovite nautida rahulikku sõitu mööda jõge või otsite seiklust ja adrenaliini, pakume teile unustamatuid kanuumatka kogemusi Eestimaa jõgedel. Tule ja ühine meiega seikluseks!\r\n",
                Guide = "Renata Vool",
                Price = 130,
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "",
                    "",
                    ""
                }
            },

            new()
            {
                Name = "Loodusmatkad",
                HeroImage = "Uma.jpg",
                Description = "Tere tulemast imelisse Eestimaa loodusesse, kus iga nurk on täis ilu ja võimalusi! Meie matkad viivad sind läbi metsade, rabade, järvede ja mägede, avastades meie looduse mitmekesisust ja võlu. Oled oodatud meiega koos kogema midagi, mis jääb sinuga kogu eluks. Matkad toimuvad nii jalgsi kui räätsadel, fotokaamera kaasas või ilma, ühe päeva jalutades või kuuvalgel telkides. Meie parimad loodusgiidid juhendavad ja aitavad sul tundma õppida Eestimaa looduse floorat ja faunat. Kas oled valmis avastama Eestimaa looduse võlumaailma koos meiega? Ootame sind!\r\nMatkajuht Uma!\r\nUma on särav ja sõbralik inimene, kes armastab loodust ja kõike sellega seonduvat. Ta  on suurepärane jutuvestja ning oskab rääkida kaasahaaravaid lugusid, samas oskuslikult tutvustades Eestimaa looduse hästi hoitud saladusi. \r\n",
                Guide = "Uma Rada",
                Price = 50,
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                      "",
                    "",
                    ""
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