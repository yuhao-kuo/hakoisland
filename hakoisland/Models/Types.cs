using System;

namespace hakoisland
{
    /// <summary>
    /// the hakoisland unit type mapping
    /// </summary>
    public enum UnitType
    {
        #region 一般地形 0 ~ 20
        Sea = 0,                // 海洋
        FlatGround = 1,         // 平地
        Wasteland = 2,          // 荒地
        Contaminatedland = 3,   // 污染的土地
        Sandybeach = 4,         // 沙灘
        Shoal = 5,              // 淺灘
        Mountain = 6,           // 山
        Forest = 7,             // 森林
        #endregion

        #region 都市 21 ~ 50
        Hamlet = 21,                     // 村
        Machi = 22,                      // 町
        City = 23,                      // 都市
        Port = 24,                      // 港口
        SeaCity = 25,                   // 海上都市
        SeaNewCity = 26,                // 海上新都市
        DisasterPreventionCity = 27,    // 防災都市
        DisasterPreventionNewCity = 28, // 防災新都市
        NewCity = 29,                   // 新都市
        CommercialCity = 30,            // 商業都市
        ModernCity = 31,                // 現代都市
        GloriousCity = 32,              // 輝煌都市
        GoldenCity = 33,                // 黃金城
        #endregion

        #region 大學 51 ~ 60
        AgriculturalUniversity = 51,    // 農業大學
        PolytechnicUniversity = 52,     // 理工大學
        MeteorologicalUniversity = 53,  // 氣象大學
        MilitaryUniversity = 54,        // 軍事大學
        EconomicsUniversity = 55,       // 經濟大學
        #endregion

        #region 發電廠 61 ~ 70
        ThermalPowerPlant = 61,         // 火力發電廠
        HydroelectricPowerPlant = 62,   // 水力發電廠
        BiomassPowerPlant = 63,         // 生質能發電廠
        SolarPowerPlant = 64,           // 太陽能發電廠
        NuclearPowerPlant = 65,         // 核能發電廠
        #endregion
        
        #region 農業 71 ~ 90
        CityFrame = 71,                 // 都市形農場
        BigFrame = 72,                  // 大型農場
        FrameResearchInstitute = 73,    // 食物研究所
        Pasture = 74,                   // 牧場
        #endregion

        #region 工業 91 ~ 105
        CityFactory = 91,               // 都市型工廠
        Factory = 92,                   // 工廠
        HighTechFactory = 93,           // 高科技工廠
        HighTechCompany = 94,           // 高科技公司
        #endregion

        #region 礦業 105 ~ 110
        MiningPlant = 105,              // 採礦廠
        #endregion

        #region 一般建築物 111 ~ 150
        LaunchPad = 111,                // 發射台
        PoliceStation = 112,            // 警察局
        Hospital = 113,                 // 醫院
        FireDepartment = 114,           // 消防局
        AirPort = 115,                  // 機場
        Shipyard = 116,                 // 造船廠
        #endregion
        
        #region 軍事設施 151 ~ 200
        MissileBase = 151,              // 飛彈基地
        DefenseBase = 152,              // 防衛基地
        #endregion

        #region 船隻 201 ~ 65535
        #endregion
        
    }
}