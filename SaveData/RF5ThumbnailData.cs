public class RF5ThumbnailData : SaveDataValueBase // TypeDefIndex: 9924
{
	// Fields
	private byte SavedValue; // 0x10
	private byte DifficultyValue; // 0x11
	private byte IsPlayerMaleValue; // 0x12
	private byte MarriedNPCIDValue; // 0x13
	public int InGameTimeElapsedTime; // 0x14
	public int PlayerLevel; // 0x18
	public FieldPlaceId FieldPlaceId; // 0x1C
	public int NextMissionId; // 0x20
	public string PlayerName; // 0x28

	// Properties
	public bool IsSaved { get; set; }
	public SaveState SaveState { get; set; }
	public Difficulty Difficulty { get; set; }
	public bool IsPlayerMale { get; set; }
	public NPCID MarriedNPCID { get; set; }

	// Methods

	// RVA: 0x20F5100 Offset: 0x20F5201 VA: 0x20F5100
	public bool get_IsSaved() { }

	// RVA: 0x20F5110 Offset: 0x20F5211 VA: 0x20F5110
	public void set_IsSaved(bool value) { }

	// RVA: 0x20F5130 Offset: 0x20F5231 VA: 0x20F5130
	public SaveState get_SaveState() { }

	// RVA: 0x20F5140 Offset: 0x20F5241 VA: 0x20F5140
	public void set_SaveState(SaveState value) { }

	// RVA: 0x20F5150 Offset: 0x20F5251 VA: 0x20F5150
	public Difficulty get_Difficulty() { }

	// RVA: 0x20F5160 Offset: 0x20F5261 VA: 0x20F5160
	public void set_Difficulty(Difficulty value) { }

	// RVA: 0x20F5170 Offset: 0x20F5271 VA: 0x20F5170
	public bool get_IsPlayerMale() { }

	// RVA: 0x20F5180 Offset: 0x20F5281 VA: 0x20F5180
	public void set_IsPlayerMale(bool value) { }

	// RVA: 0x20F51A0 Offset: 0x20F52A1 VA: 0x20F51A0
	public NPCID get_MarriedNPCID() { }

	// RVA: 0x20F51B0 Offset: 0x20F52B1 VA: 0x20F51B0
	public void set_MarriedNPCID(NPCID value) { }

	// RVA: 0x20F4840 Offset: 0x20F4941 VA: 0x20F4840
	public void .ctor() { }

	// RVA: 0x20F51C0 Offset: 0x20F52C1 VA: 0x20F51C0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20F51F0 Offset: 0x20F52F1 VA: 0x20F51F0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x20F5200 Offset: 0x20F5301 VA: 0x20F5200 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x20F4AC0 Offset: 0x20F4BC1 VA: 0x20F4AC0
	public void Update(RF5SaveData saveData) { }

	// RVA: 0x20F5210 Offset: 0x20F5311 VA: 0x20F5210 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x20F4FC0 Offset: 0x20F50C1 VA: 0x20F4FC0
	public void Reader0000(BinaryReader reader) { }
}

