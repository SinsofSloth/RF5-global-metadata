[RequiredByNativeCodeAttribute] // RVA: 0xC6CB0 Offset: 0xC6DB1 VA: 0xC6CB0
[AttributeUsageAttribute] // RVA: 0xC6CB0 Offset: 0xC6DB1 VA: 0xC6CB0
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute // TypeDefIndex: 3021
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Properties
	private RuntimeInitializeLoadType loadType { set; }

	// Methods

	// RVA: 0x2A24450 Offset: 0x2A24551 VA: 0x2A24450
	public void .ctor() { }

	// RVA: 0x2A244A0 Offset: 0x2A245A1 VA: 0x2A244A0
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x2A24490 Offset: 0x2A24591 VA: 0x2A24490
	private void set_loadType(RuntimeInitializeLoadType value) { }
}

