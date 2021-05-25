public class RF5MakingData : SaveDataValueBase // TypeDefIndex: 9889
{
	// Fields
	public SaveFlagStorage SaveFlag; // 0x10
	public int EnemyLevelupStage; // 0x18
	public int MakingCount; // 0x1C
	public SaveFlagStorage DoEndScriptFlags; // 0x20

	// Methods

	// RVA: 0x1D7A000 Offset: 0x1D7A101 VA: 0x1D7A000
	public bool GetSaveFlag(int id) { }

	// RVA: 0x1D7A020 Offset: 0x1D7A121 VA: 0x1D7A020
	public void SetSaveFlag(int id, bool value) { }

	// RVA: 0x1D7A040 Offset: 0x1D7A141 VA: 0x1D7A040
	public bool GetEndScriptFlag(RF5MakingData.END_SCRIPT_FLAG id) { }

	// RVA: 0x1D7A060 Offset: 0x1D7A161 VA: 0x1D7A060
	public void SetEndScriptFlag(RF5MakingData.END_SCRIPT_FLAG id, bool value) { }

	// RVA: 0x1D7A080 Offset: 0x1D7A181 VA: 0x1D7A080
	public void .ctor() { }

	// RVA: 0x1D7A140 Offset: 0x1D7A241 VA: 0x1D7A140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D7A180 Offset: 0x1D7A281 VA: 0x1D7A180 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D7A190 Offset: 0x1D7A291 VA: 0x1D7A190 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D7A200 Offset: 0x1D7A301 VA: 0x1D7A200 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D7A270 Offset: 0x1D7A371 VA: 0x1D7A270
	public void Reader0000(BinaryReader reader) { }
}

