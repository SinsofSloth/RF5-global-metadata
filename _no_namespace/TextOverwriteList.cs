public class TextOverwriteList // TypeDefIndex: 8437
{
	// Fields
	private static readonly string[] PlayerNameDefineList; // 0x0
	private static readonly string[] PlayerFirstPersonDefineList; // 0x8
	private static readonly string[] ChildNameDefineList; // 0x10
	private static readonly int[] BathMissRankNumList; // 0x18
	private static readonly string SpouseNameDefine; // 0x20
	[TupleElementNamesAttribute] // RVA: 0x16F740 Offset: 0x16F841 VA: 0x16F740
	private static readonly ValueTuple<string, Func<string>>[] ReplaceParamList; // 0x28
	[TupleElementNamesAttribute] // RVA: 0x16F7E0 Offset: 0x16F8E1 VA: 0x16F7E0
	private static readonly ValueTuple<string, Func<string>>[] ReplaceButtonList; // 0x30
	private static readonly string[] ReplaceLocalizeList; // 0x38
	private static readonly int PatchimBase; // 0x40
	private const int ChildPersonalityBase = 36;
	public const int NpcCallingNameIDMax = 42;
	private static int SpeakerNpcId; // 0x44
	private static PlayerCallingNameTextData playerCallingNameTextData; // 0x48
	private static NPCCallingNameTextData npcCallingNameTextData; // 0x50

	// Methods

	// RVA: 0x20A9B30 Offset: 0x20A9C31 VA: 0x20A9B30
	public static string GetDayOfWeekStr(int day) { }

	// RVA: 0x20A9E40 Offset: 0x20A9F41 VA: 0x20A9E40
	public static string GetMonthText(int Season) { }

	// RVA: 0x20AA0C0 Offset: 0x20AA1C1 VA: 0x20AA0C0
	public static string GetMonthText_SeasonOnly(int Season) { }

	// RVA: 0x20AA340 Offset: 0x20AA441 VA: 0x20AA340
	public static string GetNumberWideText(string s) { }

	// RVA: 0x20AA460 Offset: 0x20AA561 VA: 0x20AA460
	public static string TransformText(string text, int speakerId = -1) { }

	// RVA: 0x20ABAD0 Offset: 0x20ABBD1 VA: 0x20ABAD0
	public static string TransformButtonTag(string text) { }

	// RVA: 0x20AB430 Offset: 0x20AB531 VA: 0x20AB430
	public static string TransformText_Localize(string text) { }

	// RVA: 0x20ABEA0 Offset: 0x20ABFA1 VA: 0x20ABEA0
	public static byte[] TransformUnicode(string text) { }

	// RVA: 0x20ABEE0 Offset: 0x20ABFE1 VA: 0x20ABEE0
	public static int TransformToInt(byte[] byteList) { }

	// RVA: 0x20ABBF0 Offset: 0x20ABCF1 VA: 0x20ABBF0
	public static bool IsPatchim() { }

	// RVA: 0x20ABCC0 Offset: 0x20ABDC1 VA: 0x20ABCC0
	public static bool IsGender() { }

	// RVA: 0x20ABF50 Offset: 0x20AC051 VA: 0x20ABF50
	public string TransformName(string text) { }

	// RVA: 0x20AC020 Offset: 0x20AC121 VA: 0x20AC020
	public static string GetPlayerName() { }

	// RVA: 0x20AC1A0 Offset: 0x20AC2A1 VA: 0x20AC1A0
	public static string Get1stChildName() { }

	// RVA: 0x20AC210 Offset: 0x20AC311 VA: 0x20AC210
	public static string Get2ndChildName(Gender gender) { }

	// RVA: 0x20AC2D0 Offset: 0x20AC3D1 VA: 0x20AC2D0
	public static string GetChild1GenderText() { }

	// RVA: 0x20AC4D0 Offset: 0x20AC5D1 VA: 0x20AC4D0
	public static string GetChildPersonality(int type) { }

	// RVA: 0x20AAFE0 Offset: 0x20AB0E1 VA: 0x20AAFE0
	public static string OverwriteNameDefine(string text) { }

	// RVA: 0x20AC8A0 Offset: 0x20AC9A1 VA: 0x20AC8A0
	public static string GetCharacterName(int npcid, string nameTextID) { }

	// RVA: 0x20AB300 Offset: 0x20AB401 VA: 0x20AB300
	public static string OverwriteFirstPersonDefine(string text) { }

	// RVA: 0x20AA650 Offset: 0x20AA751 VA: 0x20AA650
	private static string OverwriteNickName(string text, int speakerNpcId = -1) { }

	// RVA: 0x20AD1B0 Offset: 0x20AD2B1 VA: 0x20AD1B0
	private static int GetCrystalNum(ItemID itemID) { }

	// RVA: 0x20AD230 Offset: 0x20AD331 VA: 0x20AD230
	private static string GetBathMissRank(int blockedNum) { }

	// RVA: 0x20AD3D0 Offset: 0x20AD4D1 VA: 0x20AD3D0
	public void .ctor() { }

	// RVA: 0x20AD3E0 Offset: 0x20AD4E1 VA: 0x20AD3E0
	private static PlayerCallingNameTextData.Data GetPlayerCallingNameTextData(int id) { }

	// RVA: 0x20ACFC0 Offset: 0x20AD0C1 VA: 0x20ACFC0
	public static string GetLoverNameTextFromPlayer(int npcId, int nameId) { }

	// RVA: 0x20ACE20 Offset: 0x20ACF21 VA: 0x20ACE20
	public static string GetLoverNameTextToPlayer(int npcId, int nameId) { }

	// RVA: 0x20AD510 Offset: 0x20AD611 VA: 0x20AD510
	public static string GetLoverNameTextToPlayerForSelector(int npcId, int nameId) { }

	// RVA: 0x20AD0E0 Offset: 0x20AD1E1 VA: 0x20AD0E0
	public static string GetMarriageNameTextFromPlayer(int npcId, int nameId) { }

	// RVA: 0x20ACEF0 Offset: 0x20ACFF1 VA: 0x20ACEF0
	public static string GetMarriageNameTextToPlayer(int npcId, int nameId) { }

	// RVA: 0x20AD660 Offset: 0x20AD761 VA: 0x20AD660
	private static NPCCallingNameTextData.Data GetNPCCallingNameTextData(int id) { }

	// RVA: 0x20ACD60 Offset: 0x20ACE61 VA: 0x20ACD60
	public static string GetNPCCallingNameText(int chId, int targetId) { }

	// RVA: 0x20AD780 Offset: 0x20AD881 VA: 0x20AD780
	public static void LoadAsset() { }

	// RVA: 0x20ADA60 Offset: 0x20ADB61 VA: 0x20ADA60
	private static void .cctor() { }
}

