public class RF5StampData : SaveDataValueBase // TypeDefIndex: 9901
{
	// Fields
	public StampRecordData[] StampRecordData; // 0x10

	// Methods

	// RVA: 0x20F2DA0 Offset: 0x20F2EA1 VA: 0x20F2DA0
	public void ReleaseNewStamp(StampEnum _stamp) { }

	// RVA: 0x20F2DF0 Offset: 0x20F2EF1 VA: 0x20F2DF0
	public void ReleaseNewStamp(StampEnum _stamp, float _record, StampLevel _stamp_level) { }

	// RVA: 0x20F2EC0 Offset: 0x20F2FC1 VA: 0x20F2EC0
	public bool IsStampReleased(StampEnum _stamp) { }

	// RVA: 0x20F2F10 Offset: 0x20F3011 VA: 0x20F2F10
	public bool IsAnyStampReleased() { }

	// RVA: 0x20F2F90 Offset: 0x20F3091 VA: 0x20F2F90
	public StampRecordData GetStampRecord(StampEnum _stamp) { }

	// RVA: 0x20F2FD0 Offset: 0x20F30D1 VA: 0x20F2FD0
	public int GetStampProgress() { }

	// RVA: 0x20F02E0 Offset: 0x20F03E1 VA: 0x20F02E0
	public void .ctor() { }

	// RVA: 0x20F3050 Offset: 0x20F3151 VA: 0x20F3050 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20F3160 Offset: 0x20F3261 VA: 0x20F3160 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x20F3170 Offset: 0x20F3271 VA: 0x20F3170 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x20F3180 Offset: 0x20F3281 VA: 0x20F3180 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x20F15E0 Offset: 0x20F16E1 VA: 0x20F15E0
	public void Reader0000(BinaryReader reader) { }
}

