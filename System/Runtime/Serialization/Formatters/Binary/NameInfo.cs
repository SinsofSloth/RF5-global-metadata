internal sealed class NameInfo // TypeDefIndex: 1097
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x1607930 Offset: 0x1607A31 VA: 0x1607930
	internal void .ctor() { }

	// RVA: 0x1607940 Offset: 0x1607A41 VA: 0x1607940
	internal void Init() { }

	// RVA: 0x1607990 Offset: 0x1607A91 VA: 0x1607990
	public bool get_IsSealed() { }

	// RVA: 0x16079F0 Offset: 0x1607AF1 VA: 0x16079F0
	public string get_NIname() { }

	// RVA: 0x1607A60 Offset: 0x1607B61 VA: 0x1607A60
	public void set_NIname(string value) { }
}

