﻿namespace matkateenused.Models
{
    public enum HikeType
    {
        Nature,
        Canoe,
        Military
    }

    public class Hikes
    {
        public string Name { get; set; }
        public string HeroImage { get; set; }
        public string Description { get; set; }
        public string Guide { get; set; }
        public int Price { get; set; }
        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }
        public HikeType Type { get; set; } // Add the Type property

        public List<string> Images { get; set; }

        // Background
        public Brush Background
        {
            get
            {
                var gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(AccentColorStart, 0.0f));
                gradientStops.Add(new GradientStop(AccentColorEnd, 1.0f));

                var bgBrush = new LinearGradientBrush(gradientStops,
                    new Point(0.0, 0.0),
                    new Point(1.0, 1.0));

                return bgBrush;
            }
        }
    }
}
