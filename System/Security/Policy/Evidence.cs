[MonoTODOAttribute] // RVA: 0xAFA30 Offset: 0xAFB31 VA: 0xAFA30
[ComVisibleAttribute] // RVA: 0xAFA30 Offset: 0xAFB31 VA: 0xAFA30
[Serializable]
public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 894
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[ObsoleteAttribute] // RVA: 0xBA4A0 Offset: 0xBA5A1 VA: 0xBA4A0
	public int Count { get; }

	// Methods

	// RVA: 0x263E160 Offset: 0x263E261 VA: 0x263E160
	public void .ctor() { }

	// RVA: 0x263E170 Offset: 0x263E271 VA: 0x263E170 Slot: 5
	public int get_Count() { }

	[ObsoleteAttribute] // RVA: 0xB9170 Offset: 0xB9271 VA: 0xB9170
	// RVA: 0x263E1E0 Offset: 0x263E2E1 VA: 0x263E1E0 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0xB9180 Offset: 0xB9281 VA: 0xB9180
	// RVA: 0x263E2B0 Offset: 0x263E3B1 VA: 0x263E2B0 Slot: 6
	public IEnumerator GetEnumerator() { }
}

