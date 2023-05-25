using matkateenused.Models;

namespace matkateenused.Services
{
    internal static class HikesServices
    {
        private static List<Hikes> hikes = new()
        {
            new()
            {
                Name = "   Militaarmatkad",
                HeroImage = "img_military.jpg",
                Description = "Tere tulemast militaarmatkale Paldiski linnas! Lähete sügavale metsa, kus instruktorid juhendavad teid läbi rasketes tingimustes, mis simuleerivad tõelisi sõjalisi stsenaariume. Matk hõlmab relvade kasutamist, sõidukite juhtimist ja taktikalisi otsuseid. Ületate takistusi, külastate mahajäetud sõjaväeobjekte ja lahendate meeskonnatöö väljakutseid. Saate kogemusi ja oskusi, mis annavad vajalikud teadmised ja enesekindluse rasketes olukordades hakkama saamiseks. See on tõeline adrenaliin ja seiklus!",
                Guide = "Marta Vasarik",
                Price = 100,
                AccentColorStart = Color.FromArgb("#2196F3"),
                AccentColorEnd = Color.FromArgb("#002171"),
                Images = new()
                {
                    "sygaviik.jpg",
                    "img_mountains.png",
                    "maestik.png"
                }
            },

            new()
            {
                Name = "   Kanuumatkad",
                HeroImage = "kanuu.jpg",
                Description = "",
                Guide = "",
                Price = 130,
                AccentColorStart = Color.FromArgb("#fff2e6"),
                AccentColorEnd = Color.FromArgb("#b35900"),
                Images = new()
                {
                    "img_canoue.png",
                    "rafting.png",
                    "saar.png"
                }
            },

            new()
            {
                Name = "   Loodusmatkad",
                HeroImage = "mets.png",
                Description = "",
                Guide = "",
                Price = 50,
                AccentColorStart = Color.FromArgb("#e6fff9"),
                AccentColorEnd = Color.FromArgb("#00b386"),
                Images = new()
                {
                      "telk.png",
                    "jarv.png",
                    "saar.png"
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