public class SystemSaveData : SaveDataBase // TypeDefIndex: 9925
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA70 Offset: 0x17FB71 VA: 0x17FA70
	private RF5SystemData <Data>k__BackingField; // 0x28

	// Properties
	public override uint Version { get; }
	public RF5SystemData Data { get; set; }

	// Methods

	// RVA: 0x20FB1B0 Offset: 0x20FB2B1 VA: 0x20FB1B0 Slot: 4
	public override uint get_Version() { }

	// RVA: 0x20FB1C0 Offset: 0x20FB2C1 VA: 0x20FB1C0 Slot: 14
	protected override void VersionInitialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD460 Offset: 0x1AD561 VA: 0x1AD460
	// RVA: 0x20FB2B0 Offset: 0x20FB3B1 VA: 0x20FB2B0
	public RF5SystemData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD470 Offset: 0x1AD571 VA: 0x1AD470
	// RVA: 0x20FB2C0 Offset: 0x20FB3C1 VA: 0x20FB2C0
	private void set_Data(RF5SystemData value) { }

	// RVA: 0x20F99F0 Offset: 0x20F9AF1 VA: 0x20F99F0
	public void .ctor() { }

	// RVA: 0x20FB2D0 Offset: 0x20FB3D1 VA: 0x20FB2D0 Slot: 5
	public override void Initialize() { }

	// RVA: 0x20FA000 Offset: 0x20FA101 VA: 0x20FA000
	public void UpdateSaveData(int slot, RF5SaveData saveData) { }

	// RVA: 0x20FB360 Offset: 0x20FB461 VA: 0x20FB360 Slot: 7
	public override void Save(SaveControllerBase controller) { }

	// RVA: 0x20FB3E0 Offset: 0x20FB4E1 VA: 0x20FB3E0 Slot: 8
	public override void Load(SaveControllerBase controller) { }

	// RVA: 0x20FB4D0 Offset: 0x20FB5D1 VA: 0x20FB4D0 Slot: 9
	public override void BeforeSave() { }

	// RVA: 0x20FB4F0 Offset: 0x20FB5F1 VA: 0x20FB4F0 Slot: 10
	public override void AfterLoad() { }

	// RVA: 0x20FB510 Offset: 0x20FB611 VA: 0x20FB510 Slot: 11
	public override void Delete(SaveControllerBase controller) { }

	// RVA: 0x20FB570 Offset: 0x20FB671 VA: 0x20FB570 Slot: 15
	protected override void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20FB590 Offset: 0x20FB691 VA: 0x20FB590
	private void ReaderFunc0000(BinaryReader reader) { }
}

