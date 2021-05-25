public class RF5WorldData : SaveDataValueBase // TypeDefIndex: 9903
{
	// Fields
	private byte DifficultyValue; // 0x10
	public int SenarioStoppedTime; // 0x14
	public int MapId; // 0x18
	public Vector3 Position; // 0x1C
	public Vector3 RotationEuler; // 0x28
	public int InGameTimeElapsedTime; // 0x34
	public WeatherData WeatherData; // 0x38
	public uint ShopRandSeedFix; // 0x48
	public uint ShopRandSeed; // 0x4C
	public int ShopSeedGenerateDay; // 0x50
	public int LastShippingDay; // 0x54
	public int LastPlaceId; // 0x58
	public int LastSleepTime; // 0x5C
	public MiningPointSaveData[] MiningPointSaveDatas; // 0x60
	public RewardBoxSaveData RewardBoxSaveData; // 0x68
	public SaveFlagStorage ItemSpawnFlag; // 0x70
	public SaveFlagStorage TreasureFlag; // 0x78
	public SaveFlagStorage GimmickFlag; // 0x80
	public int SeedPointElapsedDay; // 0x88
	public int SeedPointMonsterAddedCount; // 0x8C
	public float SeedSupportCoolTime; // 0x90
	public List<int> MeteorPosition; // 0x98
	public int OffsetFiveYearAgo; // 0xA0
	public int PunchCount; // 0xA4

	// Properties
	public Difficulty Difficulty { get; set; }
	public Weather Weather { get; set; }
	public WeatherDay WeatherDay { get; set; }
	public byte TodayRate { get; set; }
	public byte TyphoonDayCount { get; set; }
	public byte RuneyDayCount { get; set; }
	public byte MeteorShowerDayCount { get; set; }
	public byte NextWeatherDayId { get; set; }
	public byte[] WeatherHour { get; set; }

	// Methods

	// RVA: 0x20F5520 Offset: 0x20F5621 VA: 0x20F5520
	public Difficulty get_Difficulty() { }

	// RVA: 0x20F5530 Offset: 0x20F5631 VA: 0x20F5530
	public void set_Difficulty(Difficulty value) { }

	// RVA: 0x20F5540 Offset: 0x20F5641 VA: 0x20F5540
	public Weather get_Weather() { }

	// RVA: 0x20F5550 Offset: 0x20F5651 VA: 0x20F5550
	public void set_Weather(Weather value) { }

	// RVA: 0x20F5560 Offset: 0x20F5661 VA: 0x20F5560
	public WeatherDay get_WeatherDay() { }

	// RVA: 0x20F5570 Offset: 0x20F5671 VA: 0x20F5570
	public void set_WeatherDay(WeatherDay value) { }

	// RVA: 0x20F5580 Offset: 0x20F5681 VA: 0x20F5580
	public byte get_TodayRate() { }

	// RVA: 0x20F5590 Offset: 0x20F5691 VA: 0x20F5590
	public void set_TodayRate(byte value) { }

	// RVA: 0x20F55A0 Offset: 0x20F56A1 VA: 0x20F55A0
	public byte get_TyphoonDayCount() { }

	// RVA: 0x20F55B0 Offset: 0x20F56B1 VA: 0x20F55B0
	public void set_TyphoonDayCount(byte value) { }

	// RVA: 0x20F55C0 Offset: 0x20F56C1 VA: 0x20F55C0
	public byte get_RuneyDayCount() { }

	// RVA: 0x20F55D0 Offset: 0x20F56D1 VA: 0x20F55D0
	public void set_RuneyDayCount(byte value) { }

	// RVA: 0x20F55E0 Offset: 0x20F56E1 VA: 0x20F55E0
	public byte get_MeteorShowerDayCount() { }

	// RVA: 0x20F55F0 Offset: 0x20F56F1 VA: 0x20F55F0
	public void set_MeteorShowerDayCount(byte value) { }

	// RVA: 0x20F5600 Offset: 0x20F5701 VA: 0x20F5600
	public byte get_NextWeatherDayId() { }

	// RVA: 0x20F5610 Offset: 0x20F5711 VA: 0x20F5610
	public void set_NextWeatherDayId(byte value) { }

	// RVA: 0x20F5620 Offset: 0x20F5721 VA: 0x20F5620
	public byte[] get_WeatherHour() { }

	// RVA: 0x20F5630 Offset: 0x20F5731 VA: 0x20F5630
	public void set_WeatherHour(byte[] value) { }

	// RVA: 0x20F5640 Offset: 0x20F5741 VA: 0x20F5640
	public bool GetItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x20F56D0 Offset: 0x20F57D1 VA: 0x20F56D0
	public void SetItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x20F5760 Offset: 0x20F5861 VA: 0x20F5760
	public bool GetTreasureFlag(FieldUniqueTreasureBoxSpawnID id) { }

	// RVA: 0x20F57F0 Offset: 0x20F58F1 VA: 0x20F57F0
	public void SetTreasureFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x20F5880 Offset: 0x20F5981 VA: 0x20F5880
	public bool GetGimmickFlag(GimmickLayoutID id) { }

	// RVA: 0x20F5910 Offset: 0x20F5A11 VA: 0x20F5910
	public void SetGimmickFlag(GimmickLayoutID id, bool value) { }

	// RVA: 0x20F01E0 Offset: 0x20F02E1 VA: 0x20F01E0
	public void .ctor() { }

	// RVA: 0x20F59A0 Offset: 0x20F5AA1 VA: 0x20F59A0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20F5CD0 Offset: 0x20F5DD1 VA: 0x20F5CD0
	public void InitPunchCount() { }

	// RVA: 0x20F5CE0 Offset: 0x20F5DE1 VA: 0x20F5CE0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x20F5F00 Offset: 0x20F6001 VA: 0x20F5F00 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x20F5F10 Offset: 0x20F6011 VA: 0x20F5F10 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x20F1170 Offset: 0x20F1271 VA: 0x20F1170
	public void Reader0000(BinaryReader reader) { }

	// RVA: 0x20F1D90 Offset: 0x20F1E91 VA: 0x20F1D90
	public void Reader0001(BinaryReader reader) { }

	// RVA: 0x20F2470 Offset: 0x20F2571 VA: 0x20F2470
	public void Reader0002(BinaryReader reader) { }
}

