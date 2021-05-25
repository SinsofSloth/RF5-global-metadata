public class MakingSystem // TypeDefIndex: 9821
{
	// Fields
	public static UIMakingMenu UIMakingMenu; // 0x0
	private static bool Inited; // 0x8
	private static bool[] Flags; // 0x10
	public static int playingCountId; // 0x18
	public static bool isGimmick_D19flag; // 0x1C
	public static readonly Dictionary<MakingID, CalendarDataTable.FestivalId> MakingFesDic; // 0x20
	public static UIMakingMenu playingUIMakingMenu; // 0x28

	// Methods

	// RVA: 0x1E00FE0 Offset: 0x1E010E1 VA: 0x1E00FE0
	public static void InitOnStartGame() { }

	// RVA: 0x1E01280 Offset: 0x1E01381 VA: 0x1E01280
	public static void InitOnLoadGame() { }

	// RVA: 0x1E010F0 Offset: 0x1E011F1 VA: 0x1E010F0
	private static void UpdateFlag() { }

	// RVA: 0x1E012F0 Offset: 0x1E013F1 VA: 0x1E012F0
	public static bool SetFlag(bool value, MakingID makingID) { }

	// RVA: 0x1DF7D90 Offset: 0x1DF7E91 VA: 0x1DF7D90
	public static bool GetFlag(MakingID makingID) { }

	// RVA: 0x1E02140 Offset: 0x1E02241 VA: 0x1E02140
	public static void SetLicenseSuccess(MakingID makingID) { }

	// RVA: 0x1E02220 Offset: 0x1E02321 VA: 0x1E02220
	public static void SetLicenseFail() { }

	// RVA: 0x1E022A0 Offset: 0x1E023A1 VA: 0x1E022A0
	public static void CheckCalendarDate(MakingID makingID, out int day, out int season) { }

	// RVA: 0x1E024A0 Offset: 0x1E025A1 VA: 0x1E024A0
	public static int CalcMonsterLevel(int monsterLevel) { }

	// RVA: 0x1E02570 Offset: 0x1E02671 VA: 0x1E02570
	public static bool CanUpMonsterLevel() { }

	// RVA: 0x1E025A0 Offset: 0x1E026A1 VA: 0x1E025A0
	public static bool CanDownMonsterLevel() { }

	// RVA: 0x1E025D0 Offset: 0x1E026D1 VA: 0x1E025D0
	public static void AddMakingEnemyLevelupStage(int add) { }

	// RVA: 0x1E02680 Offset: 0x1E02781 VA: 0x1E02680
	public static void MonsterLevelUp() { }

	// RVA: 0x1E026F0 Offset: 0x1E027F1 VA: 0x1E026F0
	public static void MonsterLevelDown() { }

	// RVA: 0x1E01500 Offset: 0x1E01601 VA: 0x1E01500
	private static bool FlagOn(MakingID makingID) { }

	// RVA: 0x1E02760 Offset: 0x1E02861 VA: 0x1E02760
	public static bool CheckIdActive(MakingID makingID) { }

	// RVA: 0x1E03610 Offset: 0x1E03711 VA: 0x1E03610
	public static void DoOpenWindow() { }

	// RVA: 0x1E037C0 Offset: 0x1E038C1 VA: 0x1E037C0
	public static void OpenWindow() { }

	// RVA: 0x1E034F0 Offset: 0x1E035F1 VA: 0x1E034F0
	public static bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1E03A50 Offset: 0x1E03B51 VA: 0x1E03A50
	public void .ctor() { }

	// RVA: 0x1E03A60 Offset: 0x1E03B61 VA: 0x1E03A60
	private static void .cctor() { }
}

