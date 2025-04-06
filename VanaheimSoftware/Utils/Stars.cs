// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class Stars
    {
        private readonly Dictionary<string, StarDetail> Details = new();

        public Stars()
        {
           AssignDetails();
        }

        public class StarDetail
        {
            public string Type = "";
            public string ShortName = "Undefined";
            public bool Scoopable = false;
        }


        private void AssignDetails()
        {
            // Main sequence
            Details.Add("O", new StarDetail() { Type = "O", Scoopable = true, ShortName = "O (blue)" });
            Details.Add("B", new StarDetail() { Type = "B", Scoopable = true, ShortName = "B (blue-white)" });
            Details.Add("A", new StarDetail() { Type = "A", Scoopable = true, ShortName = "A (blue-white)" });
            Details.Add("F", new StarDetail() { Type = "F", Scoopable = true, ShortName = "F (white)" });
            Details.Add("G", new StarDetail() { Type = "G", Scoopable = true, ShortName = "G (white-yellow)" });
            Details.Add("K", new StarDetail() { Type = "K", Scoopable = true, ShortName = "K (yellow-orange)" });
            Details.Add("M", new StarDetail() { Type = "M", Scoopable = true, ShortName = "M (red dwarf)" });
            // Brown dwarfs
            Details.Add("L", new StarDetail() { Type = "L", Scoopable = false, ShortName = "L (brown dwarf)" });
            Details.Add("T", new StarDetail() { Type = "T", Scoopable = false, ShortName = "T (brown dwarf)" });
            Details.Add("Y", new StarDetail() { Type = "Y", Scoopable = false, ShortName = "Y (brown dwarf)" });
            // Proto
            Details.Add("AEBE", new StarDetail() { Type = "AeBe", Scoopable = false, ShortName = "Herbig Ae/Be" });
            Details.Add("TTS", new StarDetail() { Type = "TTS", Scoopable = false, ShortName = "TTS (proto)" });
            // Wolf-Rayet
            Details.Add("W", new StarDetail() { Type = "W", Scoopable = false, ShortName = "W (wolf-rayet)" });
            Details.Add("WN", new StarDetail() { Type = "WN", Scoopable = false, ShortName = "WN (wolf-rayet)" });
            Details.Add("WNC", new StarDetail() { Type = "WNC", Scoopable = false, ShortName = "WNC (wolf-rayet)" });
            Details.Add("WC", new StarDetail() { Type = "WC", Scoopable = false, ShortName = "WC (wolf-rayet)" });
            Details.Add("WO", new StarDetail() { Type = "WO", Scoopable = false, ShortName = "WO (wolf-rayet)" });
            // Carbon
            Details.Add("CS", new StarDetail() { Type = "CS", Scoopable = false, ShortName = "CS (carbon)" });
            Details.Add("C", new StarDetail() { Type = "C", Scoopable = false, ShortName = "C (carbon)" });
            Details.Add("CN", new StarDetail() { Type = "CN", Scoopable = false, ShortName = "CN (carbon)" });
            Details.Add("CJ", new StarDetail() { Type = "CJ", Scoopable = false, ShortName = "CJ (carbon)" });
            Details.Add("CH", new StarDetail() { Type = "CH", Scoopable = false, ShortName = "CH (carbon)" });
            Details.Add("CHD", new StarDetail() { Type = "CHd", Scoopable = false, ShortName = "CHd (carbon)" });
            Details.Add("MS", new StarDetail() { Type = "MS", Scoopable = false, ShortName = "MS (carbon)" });
            Details.Add("S", new StarDetail() { Type = "S", Scoopable = false, ShortName = "S (carbon)" });
            // White dwarf
            Details.Add("D", new StarDetail() { Type = "D", Scoopable = false, ShortName = "D (white dwarf)" });
            Details.Add("DA", new StarDetail() { Type = "DA", Scoopable = false, ShortName = "DA (white dwarf)" });
            Details.Add("DAB", new StarDetail() { Type = "DAB", Scoopable = false, ShortName = "BAD (white dwarf)" });
            Details.Add("DAO", new StarDetail() { Type = "DAO", Scoopable = false, ShortName = "DAO (white dwarf)" });
            Details.Add("DAZ", new StarDetail() { Type = "DAZ", Scoopable = false, ShortName = "DAZ (white dwarf)" });
            Details.Add("DAV", new StarDetail() { Type = "DAV", Scoopable = false, ShortName = "DAV (white dwarf)" });
            Details.Add("DB", new StarDetail() { Type = "DB", Scoopable = false, ShortName = "DB (white dwarf)" });
            Details.Add("DBZ", new StarDetail() { Type = "DBZ", Scoopable = false, ShortName = "DBZ (white dwarf)" });
            Details.Add("DBV", new StarDetail() { Type = "DBV", Scoopable = false, ShortName = "DBV (white dwarf)" });
            Details.Add("DO", new StarDetail() { Type = "DO", Scoopable = false, ShortName = "DO (white dwarf)" });
            Details.Add("DOV", new StarDetail() { Type = "DOV", Scoopable = false, ShortName = "DOV (white dwarf)" });
            Details.Add("DQ", new StarDetail() { Type = "DQ", Scoopable = false, ShortName = "DQ (white dwarf)" });
            Details.Add("DC", new StarDetail() { Type = "DC", Scoopable = false, ShortName = "DC (white dwarf)" });
            Details.Add("DCV", new StarDetail() { Type = "DC", Scoopable = false, ShortName = "DCV (white dwarf)" });
            Details.Add("DX", new StarDetail() { Type = "DC", Scoopable = false, ShortName = "DX (white dwarf)" });
            // Neutron
            Details.Add("N", new StarDetail() { Type = "N", Scoopable = false, ShortName = "N (neutron)" });
            // Black hole
            Details.Add("H", new StarDetail() { Type = "H", Scoopable = false, ShortName = "Black Hole" });
            Details.Add("SUPERMASSIVEBLACKHOLE", new StarDetail() { Type = "SupermassiveBlackHole", Scoopable = false, ShortName = "Super Massive BH" });
            // Giants
            Details.Add("B_BLUEWHITESUPERGIANT", new StarDetail() { Type = "B_BlueWhiteSuperGiant", Scoopable = true, ShortName = "B (super giant)" });
            Details.Add("A_BLUEWHITESUPERGIANT", new StarDetail() { Type = "A_BlueWhiteSuperGiant", Scoopable = true, ShortName = "A (super giant)" });
            Details.Add("F_WHITESUPERGIANT", new StarDetail() { Type = "F_WhiteSuperGiant", Scoopable = true, ShortName = "F (super giant)" });
            Details.Add("G_WHITEYELLOWSUPERGIANT", new StarDetail() { Type = "G_WhiteYellowSuperGiant", Scoopable = true, ShortName = "G (super giant)" });
            Details.Add("K_ORANGEGIANT", new StarDetail() { Type = "K_OrangeGiant", Scoopable = true, ShortName = "K (giant)" });
            Details.Add("M_REDGIANT", new StarDetail() { Type = "M_RedGiant", Scoopable = true, ShortName = "M (giant)" });
            Details.Add("M_REDSUPERGIANT", new StarDetail() { Type = "M_RedSuperGiant", Scoopable = true, ShortName = "M (super giant)" });
            // Undiscovered
            Details.Add("X", new StarDetail() { Type = "X", Scoopable = false, ShortName = "X (exotic)" });
            Details.Add("ROGUEPLANET", new StarDetail() { Type = "RoguePlanet", Scoopable = false, ShortName = "Rogue Planet" });
            Details.Add("NEBULA", new StarDetail() { Type = "Nebula", Scoopable = false, ShortName = "Nebula" });
            Details.Add("STELLARREMNANTNEBULA", new StarDetail() { Type = "StellarRemnantNebula", Scoopable = false, ShortName = "Stellar Remnant" });
        }



        public StarDetail TypeToDetail(string? type)
        {
            if (!string.IsNullOrEmpty(type) && Details.ContainsKey(type.ToUpper()))
                return Details[type.ToUpper()];
            else
                return new() { Scoopable = false, Type = "Undefined", ShortName = "Undefined" };
        }

    }
}
