public class FarmManager : SingletonMonoBehaviour<FarmManager> // TypeDefIndex: 10342
{
	// Fields
	public static FarmController ActiveFarmController; // 0x0
	private static FarmController villageFarmController; // 0x8
	public static FarmDragonManager ActiveFarmDragonManager; // 0x10
	public List<List<FarmCropData>> farmCropDataList; // 0x18
	private static List<OnGroundItem> _onGroundItems; // 0x18
	private static GameObject _farmMineBasePrefab; // 0x20
	private List<ItemID> itemHarvestIdList; // 0x20
	private int[] harvestCounts; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x181590 Offset: 0x181691 VA: 0x181590
	private bool <IsDataInitialize>k__BackingField; // 0x30
	public static int[] FarmSizeLevels; // 0x28
	private static GameObject FarmRunePrefab; // 0x30
	public static int[][] crystalUseCounts; // 0x38
	private CellController cellMagnifier; // 0x38
	private static FarmManager.RF3_FREEFARM _rf_free_farm; // 0x40
	public static readonly Vector3Int[] FARM_SIZE; // 0x88
	public static readonly Vector3[] CellIdToPosition; // 0x90
	private Vector3[] tutorialObstaclePoints; // 0x40
	private string[] tutorialObstacleName; // 0x48
	private const int FX32_SHIFT = 12;
	private const int RF3_FM_DETAIL_TXT_STR_MAX = 256;
	private const int RF3_CROP_STONE = 1;
	private const int RF3_CROP_ROCK = 2;
	private const int RF3_CROP_BRANCH = 3;
	private const int RF3_CROP_STUMP = 4;
	private const int RF3_CROP_PALING = 5;
	private const int RF3_CROP_GRASS_D = 20;
	private const int RF3_CROP_S_ROCK = 22;
	private const int RF3_ITEM_LEVELMIN = 0;
	private const int RF3_ITEM_LEVELMAX = 9;
	private const int RF4_FREE_FARM_MAX = 7;
	private const int RF4_FREE_FARM_CROP_MAX = 76;
	private const int RF4_FF_SAVE_CROP_NUM = 532;
	private const int RF4_FF_GROW_SHIFT = 8;
	private const int RF4_FF_GROW_MASK = 255;
	private const int RF4_CROP_FRUIT_MAX = 7;
	private const int RF4_CROP_LV_MIN = 0;
	private const int RF4_CROP_LV_MAX = 4095;
	private const int RF4_CROP_SIZE_MIN = -256;
	private const int RF4_CROP_SIZE_POOR = -256;
	private const int RF4_CROP_SIZE_MAX = 511;
	private const int RF4_CROP_GROW_MIN = 0;
	private const int RF4_CROP_GROW_MAX = 131071;
	private const int RF4_CROP_NUM_MIN = -1024;
	private const int RF4_CROP_NUM_MAX = 1023;
	private const int RF4_CROP_HP_MIN = 0;
	private const int RF4_CROP_HP_MAX = 255;
	private const int RF4_CROP_LEVELUP_MAX = 3;
	private const int RF4_FREE_FARM_SEASON_ON = 6144;
	private const int RF4_FREE_FARM_SEASON_OFF = 3072;
	private const int RF4_FREE_FARM_SEASON_ON_SIZE = 4608;
	private const int RF4_FREE_FARM_SEASON_OFF_SIZE = 1024;
	private const int RF4_FREE_FARM_HALF_HP_DIE = 128;
	private const int RF4_FREE_FARM_QUARTER_HP_DIE = 32;
	private const int RF4_FREE_FARM_QUARTER_RESS_HP_DIE = 8;
	private const int RF4_FREE_FARM_ZERO_HP_DIE = 1;
	private const byte RF4_FREE_FARM_HP_CARE = 8;
	private const byte RF4_FREE_FARM_HP_CARE_BOOST = 8;
	private const byte RF4_FREE_FARM_HP_CARE_BOOST2 = 1;
	private const byte RF4_FREE_FARM_RP_CARE = 2;
	private const byte RF4_FREE_FARM_RP_CARE_BOOST = 2;
	private const int RF4_FREE_FARM_GROW_SPD_RETURN = 32;
	private const int RF4_FREE_FARM_GROW_SPD_DOWN = 10;
	private const int RF4_FREE_FARM_GROW_LV_RETURN = 16;
	private const int RF4_FREE_FARM_GROW_LV_DOWN = 8;
	private const int RF4_FREE_FARM_GROW_SIZE_RETURN = 8;
	private const int RF4_FREE_FARM_GROW_SIZE_DOWN = 8;
	private const int RF4_FREE_FARM_GROW_NUM_RETURN = 8;
	private const int RF4_FREE_FARM_GROW_NUM_DOWN = 4;
	private const int RF4_FREE_FARM_DAMAGE_RETURN = 1;
	private const int RF4_FREE_FARM_DEF_RETURN = 3;
	private const int RF4_FREE_FARM_DEF_USE = 8;
	public const int RF4_FREE_FARM_RP_USE = 6;
	private const int RF4_FREE_FARM_GROW_SPD_DAMAGE = 16;
	private const int RF4_FREE_FARM_GROW_LV_DAMAGE = 8;
	private const int RF4_FREE_FARM_GROW_SIZE_DAMAGE = 8;
	private const int RF4_FREE_FARM_GROW_NUM_DAMAGE = 8;
	private const int RFD_FF_YOUNG_CORN_CURE_HP = 150;
	private const int RFD_FF_GRASS_D_CURE_HP = 30;
	private const int RFD_FF_YOUNG_CORN_CURE_RP = 5;
	private const int RFD_FF_GRASS_D_CURE_RP = 1;
	private const int RFD_FF_YOUNG_CORN_CURE_GROW = 64;
	private const int RFD_FF_GRASS_D_CURE_GROW = 16;
	private const int RFD_SDRUG_D_ITEM_TYUUWA = 32;
	private const int RFD_SDRUG_D_ITEM_GNGNGREEN = 16;
	private const int RFD_SDRUG_D_ITEM_GNGNGREEN_HAYATE = 128;
	private const int RFD_SDRUG_D_ITEM_YOKU_NOBIRU = 128;
	private const int RFD_SDRUG_D_ITEM_SUBAYAKU_NOBIRU = 256;
	private const int RFD_SDRUG_D_ITEM_HAGESHIKU_NOBIRU = 512;
	private const int RFD_SDRUG_D_ITEM_OOKIKUNARE = 80;
	private const int RFD_SDRUG_D_ITEM_TIISAKUNARE = -256;
	private const int RFD_SDRUG_D_ITEM_TIISAKUNARE_HP = 60;
	private const int RFD_SDRUG_D_ITEM_KUSARASENAINO_A = -4;
	private const int RFD_SDRUG_D_ITEM_KUSARASENAINO_B = -15;
	private const int RFD_SDRUG_DAMAGE_HP = 12;
	private const int RF4_CROP_ORE = 26;
	private const int RF4_CROP_ORE_BIG_FX32 = 4608;
	private const int RF4_CROP_ORE_MINI_FX32 = 3072;
	private const int RF4_FREE_FARM_RAND_TBL_MAX = 32;
	private const int RF4_FREE_FARM_ORE_RAND_TBL_MAX = 16;
	private const int RF4_FREE_FARM_ROCK_RAND_TBL_MAX = 3;
	private const int RF4_FREE_FARM_WOOD_RAND_TBL_MAX = 3;
	private const int RF4_FREE_FARM_FLOWER_RAND_TBL_MAX = 64;
	private const int RF4_FREE_FARM_VEGETABLE_RAND_TBL_MAX = 64;
	private const int RF4_FREE_FARM_ALL_CROP_MAX = 532;
	private const int RF4_FREE_FARM_ARERU_NUM = 15;
	private const int RF4_CROP_TYPE_GRASS = 8;
	public const int RF4_CROP_TYPE_TREE = 512;
	private const int RF4_SOIL_GROW_SPD_MIN = 128;
	private const int RF4_SOIL_GROW_SPD_MAX = 1280;
	private const int RF4_SOIL_GROW_NUM_MAX = 512;
	private const int RF4_SOIL_GROW_LV_MIN = -512;
	private const int RF4_SOIL_GROW_LV_MAX = 511;
	private const int RF4_SOIL_GROW_SIZE_MIN = -512;
	private const int RF4_SOIL_GROW_SIZE_MAX = 511;
	private const int RF4_SOIL_DOPING_MIN = 0;
	private const int RF4_SOIL_DOPING_MAX = 3;
	private const int RF4_SOIL_DEF_MIN = 0;
	private const int RF4_SOIL_DEF_MAX = 63;
	private const int RF4_SOIL_HP_MIN = 0;
	private const int RF4_SOIL_HP_MAX = 255;
	private const int RF4_SOIL_RP_MIN = 0;
	private const int RF4_SOIL_RP_MAX = 15;
	private const int RF4_SOIL_ATK_MIN = 0;
	private const int RF4_SOIL_ATK_MAX = 31;
	private const int RF4_SOIL_LV_MAX = 15;
	private const int RF4_SOIL_EXP_MAX = 255;
	private const int RF3_CROP_VEGETABLE_START_ID = 38;
	private const int RF3_CROP_CULTIVATE = 88;
	private static uint fix_seed; // 0x98
	private const int farmGoodCropAddRangeMin = 0;
	private const int farmGoodCropAddRangeMax = 3;
	private const int farmBadCropSubRangeMin = 0;
	private const int farmBadCropSubRangeMax = 3;
	private const int farmDamageReductionHoeLevel = 3;
	private const int farmRainWateringWait = 1;
	private const int farmTyphoonBuildWait = 2;
	private const int farmTyphoonBreakWait = 4;
	private static readonly int[] RegistTyphoonBuild; // 0xA0
	private static readonly int[] RegistTyphoonBreake; // 0xA8
	public static readonly int[] UseCrystalCountTable; // 0xB0
	public static readonly int[][] UseGroundCrystalCountTable; // 0xB8
	private static readonly int[] AvailableDaysCountTable; // 0xC0
	private const int boostRuneRate = 128;
	private const int branchBuildRate = 0;
	private const int StumpBuildRate = 1;
	private const int bigStumpBuildRate = 2;
	private const int stoneBuildRate = 3;
	private const int RockBuildRate = 4;
	private const int bigRockBuildRate = 5;
	private static readonly int[] obstacleRateList; // 0xC8
	public static Vector3[] farmOffset; // 0xD0
	public static readonly int[] rf_free_farm_spd; // 0xD8
	public static readonly int[] rf_free_farm_num; // 0xE0
	private static readonly int[] rf_free_farm_num_rate; // 0xE8
	public static readonly int[] rf_free_farm_lv; // 0xF0
	private static readonly int[] rf_free_farm_lv_rate; // 0xF8
	public static readonly int[] rf_free_farm_size; // 0x100
	public static readonly int[] rf_free_farm_hp; // 0x108
	public static readonly int[] rf_free_farm_rp; // 0x110
	public static readonly int[] rf_free_farm_atk; // 0x118
	public static readonly int[] rf_free_farm_def; // 0x120
	private static readonly int[] rf_free_farm_seed_rate; // 0x128
	private static readonly int[] rf_free_farm_seed_under_rate; // 0x130
	private static readonly int[] rf_free_farm_soil_exp; // 0x138
	public static readonly BitVector32Int.Section csi0_fruit; // 0x140
	public static readonly BitVector32Int.Section csi0_crop_lv; // 0x148
	public static readonly BitVector32Int.Section csi0_crop_size; // 0x150
	public static readonly BitVector32Int.Section csi1_crop_grow; // 0x158
	public static readonly BitVector32Int.Section csi1_crop_num; // 0x160
	public static readonly BitVector32Int.Section csi1_water; // 0x168
	public static readonly BitVector32Int.Section csi1_crop_die; // 0x170
	public static readonly BitVector32Int.Section csi1_large; // 0x178
	public static readonly BitVector32Int.Section csi2_crop_hp; // 0x180
	public static readonly BitVector32Int.Section csi2_x; // 0x188
	public static readonly BitVector32Int.Section csi2_y; // 0x190
	public static readonly BitVector32Int.Section csi2_levelup; // 0x198
	public static readonly BitVector32Int.Section csi2_kuwa; // 0x1A0
	public static readonly BitVector32Int.Section csi3_crop_id; // 0x1A8
	public static readonly BitVector32Int.Section si0_grow_spd; // 0x1B0
	public static readonly BitVector32Int.Section si0_grow_num; // 0x1B8
	public static readonly BitVector32Int.Section si0_grow_lv; // 0x1C0
	public static readonly BitVector32Int.Section si1_grow_size; // 0x1C8
	public static readonly BitVector32Int.Section si1_def; // 0x1D0
	public static readonly BitVector32Int.Section si1_hp; // 0x1D8
	public static readonly BitVector32Int.Section si1_atk; // 0x1E0
	public static readonly BitVector32Int.Section si1_doping; // 0x1E8
	public static readonly BitVector32Int.Section si1_work_on_crop; // 0x1F0
	public static readonly BitVector32Int.Section si2_rp; // 0x1F8
	public static readonly BitVector32Int.Section si2_soil_num_lv; // 0x200
	public static readonly BitVector32Int.Section si2_soil_lv_lv; // 0x208
	public static readonly BitVector32Int.Section si2_soil_size_lv; // 0x210
	public static readonly BitVector32Int.Section si2_soil_exp; // 0x218
	public static readonly BitVector32Int.Section si2_soil_spd_exp; // 0x220
	public static readonly BitVector32Int.Section si3_soil_num_exp; // 0x228
	public static readonly BitVector32Int.Section si3_soil_lv_exp; // 0x230
	public static readonly BitVector32Int.Section si3_soil_size_exp; // 0x238
	public static readonly BitVector32Int.Section si3_soil_lv; // 0x240
	public static readonly BitVector32Int.Section si3_soil_spd_lv; // 0x248
	private bool[] monsterHutReleaseFlags; // 0x50
	public static Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>> SceneIDToFarmIDAndPlaceIDDic; // 0x250
	private static readonly int[] _rf__level_rate_0; // 0x258
	private static readonly int[] _rf__level_rate_1; // 0x260
	private static readonly int[] _rf__level_rate_2; // 0x268
	private static readonly int[] _rf__level_rate_0a; // 0x270
	private static readonly int[] _rf__level_rate_1a; // 0x278
	private static readonly int[] _rf__level_rate_2a; // 0x280
	private static readonly int[] _rf__level_rate_0b; // 0x288
	private static readonly int[] _rf__level_rate_1b; // 0x290
	private static readonly int[] _rf__level_rate_2b; // 0x298

	// Properties
	public bool IsDataInitialize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AE9E0 Offset: 0x1AEAE1 VA: 0x1AE9E0
	// RVA: 0x1F8DFB0 Offset: 0x1F8E0B1 VA: 0x1F8DFB0
	public bool get_IsDataInitialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE9F0 Offset: 0x1AEAF1 VA: 0x1AE9F0
	// RVA: 0x1F8DFC0 Offset: 0x1F8E0C1 VA: 0x1F8DFC0
	public void set_IsDataInitialize(bool value) { }

	// RVA: 0x1F8DFD0 Offset: 0x1F8E0D1 VA: 0x1F8DFD0
	private void OnDestroy() { }

	// RVA: 0x1F8E190 Offset: 0x1F8E291 VA: 0x1F8E190
	private void Start() { }

	// RVA: 0x1F8E850 Offset: 0x1F8E951 VA: 0x1F8E850
	private void Update() { }

	// RVA: 0x1F8E2F0 Offset: 0x1F8E3F1 VA: 0x1F8E2F0
	public void FarmDataInitialize() { }

	// RVA: 0x1F8A4B0 Offset: 0x1F8A5B1 VA: 0x1F8A4B0
	public void ChangeFarmScene(FarmManager.FARM_ID farmId, FarmController farmController) { }

	// RVA: 0x1F91F50 Offset: 0x1F92051 VA: 0x1F91F50
	private void rf4FreeFarmInit() { }

	// RVA: 0x1F93E00 Offset: 0x1F93F01 VA: 0x1F93E00
	public void CreateTutorialObstacle() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEA00 Offset: 0x1AEB01 VA: 0x1AEA00
	// RVA: 0x1F944A0 Offset: 0x1F945A1 VA: 0x1F944A0
	public static IEnumerator createFurniture() { }

	// RVA: 0x1F94500 Offset: 0x1F94601 VA: 0x1F94500
	public void FarmDataSave() { }

	// RVA: 0x1F934E0 Offset: 0x1F935E1 VA: 0x1F934E0
	public void FarmDataLoad() { }

	// RVA: 0x1F94A10 Offset: 0x1F94B11 VA: 0x1F94A10
	private void CorrectFarmCropData(FarmCropData farmCropData) { }

	// RVA: 0x1F94360 Offset: 0x1F94461 VA: 0x1F94360
	public static int getSerialCellId(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId = -1) { }

	// RVA: 0x1F94240 Offset: 0x1F94341 VA: 0x1F94240
	public static void getCellIdfromSerialId(FarmManager.FARM_ID _farmId, int serialcellid, ref Vector3Int _cellSetId, ref int _cellId) { }

	// RVA: 0x1F94A40 Offset: 0x1F94B41 VA: 0x1F94A40
	public void FarmCropDataListUpdate(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId, ItemData _itemData, Nullable<CropDataTable> _cropData, SoilStatus _soilStatus, PlantStatus _plantStatus, bool _isDataReset = False) { }

	// RVA: 0x1F95160 Offset: 0x1F95261 VA: 0x1F95160
	public FarmCropData GetFarmCropCellData(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId) { }

	// RVA: 0x1F8C9C0 Offset: 0x1F8CAC1 VA: 0x1F8C9C0
	public List<FarmCropData> GetFarmCropCellSetData(FarmManager.FARM_ID farmId, Vector3Int cellSetId) { }

	// RVA: 0x1F95900 Offset: 0x1F95A01 VA: 0x1F95900
	public void SetFarmCropData(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId, FarmCropData farmCropData) { }

	// RVA: 0x1F95AA0 Offset: 0x1F95BA1 VA: 0x1F95AA0
	private void checkFarm2Second(int elapsedSec) { }

	// RVA: 0x1F95BF0 Offset: 0x1F95CF1 VA: 0x1F95BF0
	private void checkFarm2Hour(int elapsedHour) { }

	// RVA: 0x1F95DA0 Offset: 0x1F95EA1 VA: 0x1F95DA0
	private void checkFarm2Day(int elapsedDay) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEA70 Offset: 0x1AEB71 VA: 0x1AEA70
	// RVA: 0x1F8C930 Offset: 0x1F8CA31 VA: 0x1F8C930
	public IEnumerator LoadCropPrefab(Prefab prefabId, UnityAction<GameObject> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEAE0 Offset: 0x1AEBE1 VA: 0x1AEAE0
	// RVA: 0x1F8DE90 Offset: 0x1F8DF91 VA: 0x1F8DE90
	public IEnumerator GetMonsterHutFlags(FarmManager.FARM_ID farmId, UnityAction<bool[]> callback) { }

	// RVA: 0x1F96430 Offset: 0x1F96531 VA: 0x1F96430
	public void SetMonsterHutFlag(FarmManager.FARM_ID farmId, int monsterHutId, bool status) { }

	// RVA: 0x1F96500 Offset: 0x1F96601 VA: 0x1F96500
	public void ForceGrowCrop(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId) { }

	// RVA: 0x1F965F0 Offset: 0x1F966F1 VA: 0x1F965F0
	public void ForceGrowCrop(ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1F96FD0 Offset: 0x1F970D1 VA: 0x1F96FD0
	public void ForceGrowLargeCrop(FarmManager.FARM_ID farmId, Vector3Int cellSetId) { }

	// RVA: 0x1F97F00 Offset: 0x1F98001 VA: 0x1F97F00
	public void ForceChangeSeeds() { }

	// RVA: 0x1F980B0 Offset: 0x1F981B1 VA: 0x1F980B0
	public void ForceChangeSeed(CellController cellController) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEB50 Offset: 0x1AEC51 VA: 0x1AEB50
	// RVA: 0x1F98B30 Offset: 0x1F98C31 VA: 0x1F98B30
	public IEnumerator ForceCreateObstacle(int type) { }

	// RVA: 0x1F93BB0 Offset: 0x1F93CB1 VA: 0x1F93BB0
	public void ResetObstacleObject(FarmController farmController) { }

	// RVA: 0x1F98BA0 Offset: 0x1F98CA1 VA: 0x1F98BA0
	public void ForceObstaclePickupAll() { }

	// RVA: 0x1F98F10 Offset: 0x1F99011 VA: 0x1F98F10
	public void ForceHealFarmCropsAndSoils() { }

	// RVA: 0x1F991A0 Offset: 0x1F992A1 VA: 0x1F991A0
	public int UseCrystalCount(FarmManager.FARM_ID farmID, int type) { }

	// RVA: 0x1F99310 Offset: 0x1F99411 VA: 0x1F99310
	public bool UseCrystalCheck(FarmManager.FARM_ID farmID, int type, int hasCount) { }

	// RVA: 0x1F994B0 Offset: 0x1F995B1 VA: 0x1F994B0
	public bool UseCrystal(FarmManager.FARM_ID farmID, int type) { }

	// RVA: 0x1F99EE0 Offset: 0x1F99FE1 VA: 0x1F99EE0
	public bool ChangeFarmSize(FarmManager.FARM_ID farmID) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEBC0 Offset: 0x1AECC1 VA: 0x1AEBC0
	// RVA: 0x1F95B80 Offset: 0x1F95C81 VA: 0x1F95B80
	private static IEnumerator rf4WeatherWorkFunc(int elapsedSec) { }

	// RVA: 0x1F95C70 Offset: 0x1F95D71 VA: 0x1F95C70
	private static void rf4FreeFarmHourFunc(int elapsedHour) { }

	// RVA: 0x1F9A200 Offset: 0x1F9A301 VA: 0x1F9A200
	private static void rf4FreeFarmCropWater(ref FarmManager.RF4_CROP_STATE pCrop, int water) { }

	// RVA: 0x1F9A900 Offset: 0x1F9AA01 VA: 0x1F9A900
	private void rf4FreeFarmAllWater() { }

	// RVA: 0x1F9AC60 Offset: 0x1F9AD61 VA: 0x1F9AC60
	public void SetHoeLevelFlag(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, int hoeLevel) { }

	// RVA: 0x1F97370 Offset: 0x1F97471 VA: 0x1F97370
	private static bool rf4FreeFarmCropLargeCheck(int farm_id, ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1F9C1B0 Offset: 0x1F9C2B1 VA: 0x1F9C1B0
	public void ChangeLargeSizeCropForInactiveFarm(int farm_id, int[] cropIndexList, int cellId) { }

	// RVA: 0x1F9C3C0 Offset: 0x1F9C4C1 VA: 0x1F9C3C0
	private void rf4FreeFarmDayFuncCropExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, int farm_id) { }

	// RVA: 0x1F9D520 Offset: 0x1F9D621 VA: 0x1F9D520
	private void rf4FreeFarmCropToGrassDie(FarmManager.FARM_ID farm_id, ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1F9DB20 Offset: 0x1F9DC21 VA: 0x1F9DB20
	private int rf4FreeFarmDayFuncValueCalc(int now, int tag, int down_value, int up_value, int soil_state, bool compost, bool minus = False) { }

	// RVA: 0x1F9DBB0 Offset: 0x1F9DCB1 VA: 0x1F9DBB0
	private void rf4FreeFarmDayFuncSoilExec(ref FarmManager.RF4_SOIL_INFO pSoil, bool compost) { }

	// RVA: 0x1F95F40 Offset: 0x1F96041 VA: 0x1F95F40
	private void rf4FreeFarmDayFunc() { }

	// RVA: 0x1F9AD60 Offset: 0x1F9AE61 VA: 0x1F9AD60
	private static void rf4FreeFarmPickupSoilExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, bool cut_flag = False) { }

	// RVA: 0x1F9EC30 Offset: 0x1F9ED31 VA: 0x1F9EC30
	private static void rf4FreeFarmPickupSoilDamageExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, bool cut_flag = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEC30 Offset: 0x1AED31 VA: 0x1AEC30
	// RVA: 0x1F9A150 Offset: 0x1F9A251 VA: 0x1F9A150
	private static IEnumerator rf4FreeFarmDamageFarm(int num, bool typhoon = False, bool init = False, bool wood = False, bool stone = False) { }

	// RVA: 0x1F9F020 Offset: 0x1F9F121 VA: 0x1F9F020
	public static void buildObstacle(FarmManager.FARM_ID farmId, int type, float posx, float posz, ref MineTypeID mineId, ref CropID cropId, ref ItemID itemId) { }

	// RVA: 0x1F9FD50 Offset: 0x1F9FE51 VA: 0x1F9FD50
	public static ItemID popupItemObstacleObject(FarmManager.FARM_ID farm_id, ItemID itemid, float posx, float posz) { }

	// RVA: 0x1FA00D0 Offset: 0x1FA01D1 VA: 0x1FA00D0
	private static bool rf4FreeFarmCropCreateCheckPosGet(int farm_id, ref float x, ref float y, float r) { }

	// RVA: 0x1FA0A60 Offset: 0x1FA0B61 VA: 0x1FA0A60
	private static ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropSearch(int farm_id, int index) { }

	// RVA: 0x1FA0B20 Offset: 0x1FA0C21 VA: 0x1FA0B20
	public bool rf4FreeFarmCropPickupOkCheck(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar) { }

	// RVA: 0x1FA0CE0 Offset: 0x1FA0DE1 VA: 0x1FA0CE0
	public ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropPickup(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar, ref int num, ref int cropItemLevel) { }

	// RVA: 0x1FA1C90 Offset: 0x1FA1D91 VA: 0x1FA1C90
	private static ItemData CreateLeafWeaponData(FarmManager.FARM_ID farmId, ItemID item_id, Vector3Int cellsetid, int cellid, FarmManager.RF4_CROP_STATE pCrop, int level) { }

	// RVA: 0x1FA2830 Offset: 0x1FA2931 VA: 0x1FA2830
	public bool rf4FreeFarmSoilAction(int x, int y, int farm_id, ItemID item_id) { }

	// RVA: 0x1FA2F50 Offset: 0x1FA3051 VA: 0x1FA2F50
	public void FarmActionChopWood(Vector3Int cellSetId, int cellId, int skill = -1, int axe_level = -1) { }

	// RVA: 0x1FA36C0 Offset: 0x1FA37C1 VA: 0x1FA36C0
	public static void rf4FreeFarmCultivateHeal(ItemID item_id, Vector3Int cellSetId) { }

	// RVA: 0x1FA3D80 Offset: 0x1FA3E81 VA: 0x1FA3D80
	private static void rf4FreeFarmTyphoonAttack(int farm_id, int crop_index) { }

	// RVA: 0x1F8ED20 Offset: 0x1F8EE21 VA: 0x1F8ED20
	public static string rf4FreeFarmLoupeDetailStrSet(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId) { }

	// RVA: 0x1F95260 Offset: 0x1F95361 VA: 0x1F95260
	private void rf4FreeFarmCropDispChange(FarmManager.RF4_CROP_STATE pCrop, bool wither = True) { }

	// RVA: 0x1F9C0C0 Offset: 0x1F9C1C1 VA: 0x1F9C0C0
	public static void rf4FreeFarmCropDelete(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid) { }

	// RVA: 0x1F98610 Offset: 0x1F98711 VA: 0x1F98610
	public static void rf4FreeFarmCropDelete(ref FarmManager.RF4_CROP_STATE pCrop, bool isSizeKeep = False) { }

	// RVA: 0x1FA4AF0 Offset: 0x1FA4BF1 VA: 0x1FA4AF0
	public static void rf4FreeFarmCropDeleteAll(int farm_id) { }

	// RVA: 0x1F968D0 Offset: 0x1F969D1 VA: 0x1F968D0
	private static void rf4FreeFarmCropInfoSetup(ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1F9EA00 Offset: 0x1F9EB01 VA: 0x1F9EA00
	private static int rfSpdChangeSet(int lSpd, int sTargetSpd, int sSpd) { }

	// RVA: 0x1FA4C20 Offset: 0x1FA4D21 VA: 0x1FA4C20
	private static int rfCalcRandList(int[] pRand, int num) { }

	// RVA: 0x1FA4CF0 Offset: 0x1FA4DF1 VA: 0x1FA4CF0
	public List<CellController> GetWorkAreaCellControllers(int area) { }

	// RVA: 0x1FA4F60 Offset: 0x1FA5061 VA: 0x1FA4F60
	public List<FarmCropData> GetWorkAreaCropDatas(FarmManager.FARM_ID farmId, int area) { }

	// RVA: 0x1FA5170 Offset: 0x1FA5271 VA: 0x1FA5170
	public bool CheckWorkAreaData(FarmManager.FARM_ID farmId, int area, FarmCropData farmCropData) { }

	// RVA: 0x1FA5300 Offset: 0x1FA5401 VA: 0x1FA5300
	private static void rf4FreeFarmPickupSoilDamageExec_Monster(FarmManager.FARM_ID id, ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1FA56F0 Offset: 0x1FA57F1 VA: 0x1FA56F0
	private static void rf4FreeFarmPickupSoilExec_Monster(FarmManager.FARM_ID farmId, ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop) { }

	// RVA: 0x1FA60D0 Offset: 0x1FA61D1 VA: 0x1FA60D0
	public ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropPickup_Monster(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar, ref int num, ref int cropItemLevel, out ItemData harvestItemData) { }

	// RVA: 0x1FA6AE0 Offset: 0x1FA6BE1 VA: 0x1FA6AE0
	public FarmManager.FARM_MONSTER_TASK CanFarmAction(FarmCropData farmCropData) { }

	// RVA: 0x1F9A570 Offset: 0x1F9A671 VA: 0x1F9A570
	public void DoFarmAction(FarmManager.FARM_ID farmId, FarmCropData farmCropData) { }

	// RVA: 0x1F9EAE0 Offset: 0x1F9EBE1 VA: 0x1F9EAE0
	public Vector3 GetFarmCropWorldPosition(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId) { }

	// RVA: 0x1FA6B50 Offset: 0x1FA6C51 VA: 0x1FA6B50
	public Vector3 GetFarmCropWorldPosition(FarmManager.FARM_ID farmId) { }

	// RVA: 0x1FA0880 Offset: 0x1FA0981 VA: 0x1FA0880
	private static Vector3 GetFarmCellLocalPosition(int farmId, int cellX, int cellY, int cellId) { }

	// RVA: 0x1F984B0 Offset: 0x1F985B1 VA: 0x1F984B0
	public static int GetFreeFarmCropCurrentItemLevel(Vector3Int cellsetid, int cellid) { }

	// RVA: 0x1FA6C40 Offset: 0x1FA6D41 VA: 0x1FA6C40
	public static int CalcSlashedCropSeedLevel(HumanController human, Vector3Int cellSetId, int cellId) { }

	// RVA: 0x1FA70B0 Offset: 0x1FA71B1 VA: 0x1FA70B0
	private static int CalcSickleGrowRate(int cropLevel, int kamaLevel) { }

	// RVA: 0x1FA7020 Offset: 0x1FA7121 VA: 0x1FA7020
	private static int CalcFreeFarmActionKamaLvUpRate(int skillLevel, int kama_level) { }

	// RVA: 0x1F9D510 Offset: 0x1F9D611 VA: 0x1F9D510
	private static int FX_Mul(int val1, int val2) { }

	// RVA: 0x1FA1920 Offset: 0x1FA1A21 VA: 0x1FA1920
	private int rf3MainGoodCropNowWeek() { }

	// RVA: 0x1FA1A60 Offset: 0x1FA1B61 VA: 0x1FA1A60
	private int rf3MainBadCropNowWeek() { }

	// RVA: 0x1FA71A0 Offset: 0x1FA72A1 VA: 0x1FA71A0
	private List<CropDataTable> GetCropDataTableLotteryList() { }

	// RVA: 0x1FA72C0 Offset: 0x1FA73C1 VA: 0x1FA72C0
	private int rf3MainGoodCropNextWeek() { }

	// RVA: 0x1FA73C0 Offset: 0x1FA74C1 VA: 0x1FA73C0
	private int rf3MainBadCropNextWeek() { }

	// RVA: 0x1FA74D0 Offset: 0x1FA75D1 VA: 0x1FA74D0
	public string GetGoodCropNowWeekName() { }

	// RVA: 0x1FA76B0 Offset: 0x1FA77B1 VA: 0x1FA76B0
	public string GetBadCropNowWeekName() { }

	// RVA: 0x1FA7890 Offset: 0x1FA7991 VA: 0x1FA7890
	public string GetGoodCropNextWeekName() { }

	// RVA: 0x1FA7A60 Offset: 0x1FA7B61 VA: 0x1FA7A60
	public string GetBadCropNextWeekName() { }

	// RVA: 0x1FA1BA0 Offset: 0x1FA1CA1 VA: 0x1FA1BA0
	public static int rf3CalcTreasureOreLevelGet(ItemID item_id, int skill, int hammer) { }

	// RVA: 0x1FA7C30 Offset: 0x1FA7D31 VA: 0x1FA7C30
	public static int GetHammerLevel(ItemData equipItem) { }

	// RVA: 0x1FA7C60 Offset: 0x1FA7D61 VA: 0x1FA7C60
	public static int GetAxeLevel(ItemData equipItem) { }

	// RVA: 0x1FA7C90 Offset: 0x1FA7D91 VA: 0x1FA7C90
	public static int GetHoeLevel(ItemData equipItem) { }

	// RVA: 0x1FA6FF0 Offset: 0x1FA70F1 VA: 0x1FA6FF0
	private static int GetSickleLevel(ItemData equipItem) { }

	// RVA: 0x1FA2280 Offset: 0x1FA2381 VA: 0x1FA2280
	private static int rf3CalcRandLevel(int difficult = 0, int skill_level = -1) { }

	// RVA: 0x1FA7CC0 Offset: 0x1FA7DC1 VA: 0x1FA7CC0
	private int rf3LengthFast(int dx, int dy) { }

	// RVA: 0x1F9EA60 Offset: 0x1F9EB61 VA: 0x1F9EA60
	private static int CropLevelToCropItemLevel(int cropLevel) { }

	// RVA: 0x1F95840 Offset: 0x1F95941 VA: 0x1F95840
	private static int CropItemLevelToCropLevel(int cropItemLevel) { }

	// RVA: 0x1F958C0 Offset: 0x1F959C1 VA: 0x1F958C0
	public static bool IsMeteorKarekusa(ItemData cropItemData) { }

	// RVA: -1 Offset: -1
	private static void removeChildObjectsSameComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0D10 Offset: 0x21D0E11 VA: 0x21D0D10
	|-FarmManager.removeChildObjectsSameComponent<CellSetController>
	|-FarmManager.removeChildObjectsSameComponent<MiningPoint>
	|-FarmManager.removeChildObjectsSameComponent<object>
	*/

	// RVA: 0x1FA7DC0 Offset: 0x1FA7EC1 VA: 0x1FA7DC0
	private static void removeChildObjectsAll(Transform t) { }

	// RVA: 0x1FA4890 Offset: 0x1FA4991 VA: 0x1FA4890
	private static string strcat(ref string s1, string s2) { }

	// RVA: 0x1FA48D0 Offset: 0x1FA49D1 VA: 0x1FA48D0
	private static int sprintf(ref string s1, string format, object[] args) { }

	// RVA: 0x1FA7E90 Offset: 0x1FA7F91 VA: 0x1FA7E90
	public void .ctor() { }

	// RVA: 0x1FA8E00 Offset: 0x1FA8F01 VA: 0x1FA8E00
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AECA0 Offset: 0x1AEDA1 VA: 0x1AECA0
	// RVA: 0x1FAA340 Offset: 0x1FAA441 VA: 0x1FAA340
	private void <ChangeFarmScene>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AECB0 Offset: 0x1AEDB1 VA: 0x1AECB0
	// RVA: 0x1FAA460 Offset: 0x1FAA561 VA: 0x1FAA460
	private void <ChangeFarmSize>b__51_0() { }
}

