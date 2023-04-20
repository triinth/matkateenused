using matkateenused.Models;

namespace matkateenused.Services
{
    internal static class HikesServices
    {
        private static List<Hike> hikes = new()
        {
            new()
            {
                Name = "Militaarmatkad",
                HeroImage = "",
                Description = "Tere tulemast militaarmatkale Paldiski linnas! Lähete sügavale metsa, kus instruktorid juhendavad teid läbi rasketes tingimustes, mis simuleerivad tõelisi sõjalisi stsenaariume. Matk hõlmab relvade kasutamist, sõidukite juhtimist ja taktikalisi otsuseid. Ületate takistusi, külastate mahajäetud sõjaväeobjekte ja lahendate meeskonnatöö väljakutseid. Saate kogemusi ja oskusi, mis annavad vajalikud teadmised ja enesekindluse rasketes olukordades hakkama saamiseks. See on tõeline adrenaliin ja seiklus!",
                Guide = "Marta Vasarik",
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
                HeroImage = "",
                Description = "",
                Guide = "",
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
                HeroImage = "",
                Description = "",
                Guide = "",
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




        public static List<Hike> GetAllHikes()
            => hikes;


        public static List<Hike> GetFeaturedHikes()
        {
            var rnd = new Random();
            var randomizedHikes = hikes.OrderBy(item => rnd.Next());

            return randomizedHikes.Take(2).ToList();
        }
    }
}