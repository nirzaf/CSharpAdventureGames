using System;

namespace game {
    /// <summary>
    /// AdventureConstants contains classes that
    /// define any constants that might be needed
    /// 'globally' throughout the game.
    /// </summary>
    ///     


    public enum Rm {
        GoreStreet,
        Alleyway,
        DeadEnd,
        OpiumTerrace,
        DaggerStreet,   
        RipperMews,
        GardenN,
        GardenS,
        OakTree,
        VegetableGarden,
        PalmHouse,
        Balcony,
        DesertedShop,
        Basement,
        Attic,        
        Bedroom,
        Kitchen,
        NOEXIT
    }

    public enum ObID {
        Leaflet,
        SignGoreStreet,
        SignOpiumTerrace,
        Bone,
        Coin,
        Knife,
        Lamp,
        Acorn,
        Bed,
        Key,
        Bin,
        Chest
    }

    public enum Dir {
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UP,
        DOWN
    }

}
