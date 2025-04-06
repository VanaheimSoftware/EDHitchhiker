// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class Planets
    {
        private readonly Dictionary<string, PlanetDetail> Details = new();

        public Planets()
        {
            AssignDetail();
        }

        public class PlanetDetail
        {
            public string Type = "";
            public string ShortName = "Undefined";

            public bool IsWater()
            {
                return ShortName.ToUpper() == "WATER";
            }

            public bool IsEarthlike()
            {
                return ShortName.ToUpper() == "EARTHLIKE";
            }

            public bool IsAmmonia()
            {
                return ShortName.ToUpper() == "AMMONIA";
            }
        }


        private void AssignDetail()
        {
            Details.Add("METAL RICH BODY", new PlanetDetail() { Type = "Metal rich body", ShortName = "Metal rich" });
            Details.Add("HIGH METAL CONTENT BODY", new PlanetDetail() { Type = "High metal content body", ShortName = "High metal" });
            Details.Add("ROCKY BODY", new PlanetDetail() { Type = "Rocky body", ShortName = "Rocky" });
            Details.Add("ICY BODY", new PlanetDetail() { Type = "Icy body", ShortName = "Icy" });
            Details.Add("ROCKY ICE BODY", new PlanetDetail() { Type = "Rocky ice body", ShortName = "Rocky ice" });
            Details.Add("EARTHLIKE BODY", new PlanetDetail() { Type = "Earthlike body", ShortName = "Earthlike" });
            Details.Add("WATER WORLD", new PlanetDetail() { Type = "Water world", ShortName = "Water" });
            Details.Add("AMMONIA WORLD", new PlanetDetail() { Type = "Ammonia world", ShortName = "Ammonia" });
            Details.Add("WATER GIANT", new PlanetDetail() { Type = "Water giant", ShortName = "Water giant" });
            Details.Add("WATER GIANT WITH LIFE", new PlanetDetail() { Type = "Water giant with life", ShortName = "Water giant life" });
            Details.Add("GAS GIANT WITH WATER BASED LIFE", new PlanetDetail() { Type = "Gas giant with water based life", ShortName = "Gas giant water life" });
            Details.Add("GAS GIANT WITH AMMONIA BASED LIFE", new PlanetDetail() { Type = "Gas giant with ammonia based life", ShortName = "Gas giant ammonia life" });
            Details.Add("HELIUM RICH GAS GIANT", new PlanetDetail() { Type = "Helium rich gas giant", ShortName = "Helium rich" });
            Details.Add("HELIUM GAS GIANT", new PlanetDetail() { Type = "Helium gas giant", ShortName = "Helium" });
            Details.Add("SUDARSKY CLASS I GAS GIANT", new PlanetDetail() { Type = "Sudarsky class I gas giant", ShortName = "Gas giant I" });
            Details.Add("SUDARSKY CLASS II GAS GIANT", new PlanetDetail() { Type = "Sudarsky class II gas giant", ShortName = "Gas giant II" });
            Details.Add("SUDARSKY CLASS III GAS GIANT", new PlanetDetail() { Type = "Sudarsky class III gas giant", ShortName = "Gas giant III" });
            Details.Add("SUDARSKY CLASS IV GAS GIANT", new PlanetDetail() { Type = "Sudarsky class IV gas giant", ShortName = "Gas giant IV" });
            Details.Add("SUDARSKY CLASS V GAS GIANT", new PlanetDetail() { Type = "Sudarsky class V gas giant", ShortName = "Gas giant V" });
        }

        public PlanetDetail TypeToDetail(string? type)
        {
            if (!String.IsNullOrEmpty(type) && Details.ContainsKey(type.ToUpper()))
            {
                return Details[type.ToUpper()];
            }
            else
                return new() { Type = "Undefined", ShortName = "Undefined" };
        }

    }
}
