public class SV // TypeDefIndex: 6881
{
	// Fields
	public static BustupChildParameter[] childParameters; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FF10 Offset: 0x160011 VA: 0x15FF10
	private static UIRes <UIRes>k__BackingField; // 0x8
	public static AutoSaveType ReserveAutoSaveType; // 0x10
	public static AutoSaveCheckData AutoSaveCheckData; // 0x14
	public static bool isAutoSaving; // 0x24
	private static bool isAutoSavingPause; // 0x25
	public static bool[] FieldRandomTreasureBoxSpawnFlags; // 0x28
	public static bool[] FieldWoodBoxSpawnFlags; // 0x30
	public static bool[] FieldHideItemSpawnFlags; // 0x38
	public static GimickChange OnChangeGimmickEvents; // 0x40

	// Properties
	public static UIRes UIRes { get; set; }
	public static long PlayerGold { get; }
	public static int SeedPoint { get; }
	public static int Stone { get; }
	public static int Lumber { get; }
	public static int Compost { get; }
	public static int Esa { get; }
	public static int BathroomBlocked { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DB30 Offset: 0x19DC31 VA: 0x19DB30
	// RVA: 0x1D6DB10 Offset: 0x1D6DC11 VA: 0x1D6DB10
	public static UIRes get_UIRes() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DB40 Offset: 0x19DC41 VA: 0x19DB40
	// RVA: 0x1D6DB80 Offset: 0x1D6DC81 VA: 0x1D6DB80
	private static void set_UIRes(UIRes value) { }

	// RVA: 0x1D6DBF0 Offset: 0x1D6DCF1 VA: 0x1D6DBF0
	public static void InitFieldSpawnData() { }

	// RVA: 0x1D6DF40 Offset: 0x1D6E041 VA: 0x1D6DF40
	public static void AfterGameDataLoadFieldSpawnData() { }

	// RVA: 0x1D6DFE0 Offset: 0x1D6E0E1 VA: 0x1D6DFE0
	public static void SetEventScriptAchievedTime(int eventScriptAchievedType) { }

	// RVA: 0x1D6DFF0 Offset: 0x1D6E0F1 VA: 0x1D6DFF0
	public static long get_PlayerGold() { }

	// RVA: 0x1D6E020 Offset: 0x1D6E121 VA: 0x1D6E020
	private static int ClampPlayerGold(long gold) { }

	// RVA: 0x1D6E050 Offset: 0x1D6E151 VA: 0x1D6E050
	public static void AddPlayerGold(int gold) { }

	// RVA: 0x1D6E170 Offset: 0x1D6E271 VA: 0x1D6E170
	public static void SubPlayerGold(int gold) { }

	// RVA: 0x1D6E220 Offset: 0x1D6E321 VA: 0x1D6E220
	public static int CheckGoldMax(int gold) { }

	// RVA: 0x1D6E240 Offset: 0x1D6E341 VA: 0x1D6E240
	public static int CheckGoldPlus(int addGold, int baseGold) { }

	// RVA: 0x1D6E260 Offset: 0x1D6E361 VA: 0x1D6E260
	public static int CheckGoldPlus(int addGold) { }

	// RVA: 0x1D6E2F0 Offset: 0x1D6E3F1 VA: 0x1D6E2F0
	public static int get_SeedPoint() { }

	// RVA: 0x1D6E320 Offset: 0x1D6E421 VA: 0x1D6E320
	public static void SetSeedPoint(int val) { }

	// RVA: 0x1D6E3B0 Offset: 0x1D6E4B1 VA: 0x1D6E3B0
	public static void AddSeedPoint(int val) { }

	// RVA: 0x1D6E4B0 Offset: 0x1D6E5B1 VA: 0x1D6E4B0
	public static int get_Stone() { }

	// RVA: 0x1D6E4E0 Offset: 0x1D6E5E1 VA: 0x1D6E4E0
	public static void SetStone(int val) { }

	// RVA: 0x1D6E570 Offset: 0x1D6E671 VA: 0x1D6E570
	public static void AddStone(int val) { }

	// RVA: 0x1D6E670 Offset: 0x1D6E771 VA: 0x1D6E670
	public static int get_Lumber() { }

	// RVA: 0x1D6E6A0 Offset: 0x1D6E7A1 VA: 0x1D6E6A0
	public static void SetLumber(int val) { }

	// RVA: 0x1D6E730 Offset: 0x1D6E831 VA: 0x1D6E730
	public static void AddLumber(int val) { }

	// RVA: 0x1D6E830 Offset: 0x1D6E931 VA: 0x1D6E830
	public static int get_Compost() { }

	// RVA: 0x1D6E860 Offset: 0x1D6E961 VA: 0x1D6E860
	public static void SetCompost(int val) { }

	// RVA: 0x1D6E8F0 Offset: 0x1D6E9F1 VA: 0x1D6E8F0
	public static void AddCompost(int val) { }

	// RVA: 0x1D6E9F0 Offset: 0x1D6EAF1 VA: 0x1D6E9F0
	public static int get_Esa() { }

	// RVA: 0x1D6EA20 Offset: 0x1D6EB21 VA: 0x1D6EA20
	public static void SetEsa(int val) { }

	// RVA: 0x1D6EAB0 Offset: 0x1D6EBB1 VA: 0x1D6EAB0
	public static void AddEsa(int val) { }

	// RVA: 0x1D6EBB0 Offset: 0x1D6ECB1 VA: 0x1D6EBB0
	public static int GetPlayerBirthSeason() { }

	// RVA: 0x1D6EBF0 Offset: 0x1D6ECF1 VA: 0x1D6EBF0
	public static int GetPlayerBirthDay() { }

	// RVA: 0x1D6EC40 Offset: 0x1D6ED41 VA: 0x1D6EC40
	public static void SetPlayerBirthDay(int day, int season) { }

	// RVA: 0x1D6EC80 Offset: 0x1D6ED81 VA: 0x1D6EC80
	public static int get_BathroomBlocked() { }

	// RVA: 0x1D6ECB0 Offset: 0x1D6EDB1 VA: 0x1D6ECB0
	public static void AddBathroomBlocked() { }

	// RVA: 0x1D6ED00 Offset: 0x1D6EE01 VA: 0x1D6ED00
	public static void InitializeAutoSaveCheckData() { }

	// RVA: 0x1D6ED90 Offset: 0x1D6EE91 VA: 0x1D6ED90
	public static void AfterGameDataLoadAutoSaveCheckData() { }

	// RVA: 0x1D6EE40 Offset: 0x1D6EF41 VA: 0x1D6EE40
	public static void AutoSaveReservation(AutoSaveType type) { }

	// RVA: 0x1D6EEB0 Offset: 0x1D6EFB1 VA: 0x1D6EEB0
	public static void AutoSave(AutoSaveType type) { }

	// RVA: 0x1D6F0E0 Offset: 0x1D6F1E1 VA: 0x1D6F0E0
	public static bool CheckAutoSave(AutoSaveType type, int time) { }

	// RVA: 0x1D6F2C0 Offset: 0x1D6F3C1 VA: 0x1D6F2C0
	public static void CreateUIRes() { }

	// RVA: 0x1D6F460 Offset: 0x1D6F561 VA: 0x1D6F460
	public static void ReleaseUIRes() { }

	// RVA: 0x1D6F630 Offset: 0x1D6F731 VA: 0x1D6F630
	public void .ctor() { }

	// RVA: 0x1D6F640 Offset: 0x1D6F741 VA: 0x1D6F640
	private static void .cctor() { }
}

