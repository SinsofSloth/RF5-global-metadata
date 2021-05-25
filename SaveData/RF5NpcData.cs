public class RF5NpcData : SaveDataValueBase // TypeDefIndex: 9892
{
	// Fields
	public List<NpcSaveParameter> NpcSaveParameters; // 0x10
	public NpcDateSaveParameter NpcDateSaveParam; // 0x18
	public ChildSaveData ChildSaveDatas; // 0x20
	public GiveBirthSaveParameter GiveBirthParams; // 0x28
	public Dictionary<ActorID, ItemStorageData> NpcHatCache; // 0x30

	// Methods

	// RVA: 0x1D7A690 Offset: 0x1D7A791 VA: 0x1D7A690
	public void .ctor() { }

	// RVA: 0x1D7A6C0 Offset: 0x1D7A7C1 VA: 0x1D7A6C0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D7A9A0 Offset: 0x1D7AAA1 VA: 0x1D7A9A0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D7AA50 Offset: 0x1D7AB51 VA: 0x1D7AA50 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D7B2D0 Offset: 0x1D7B3D1 VA: 0x1D7B2D0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D7B6C0 Offset: 0x1D7B7C1 VA: 0x1D7B6C0
	public void Reader0000(BinaryReader reader) { }
}

