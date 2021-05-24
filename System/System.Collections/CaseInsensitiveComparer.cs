[ComVisibleAttribute] // RVA: 0xB2AE0 Offset: 0xB2BE1 VA: 0xB2AE0
[Serializable]
public class CaseInsensitiveComparer : IComparer // TypeDefIndex: 1350
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveComparer Default { get; }

	// Methods

	// RVA: 0x185D080 Offset: 0x185D181 VA: 0x185D080
	public void .ctor() { }

	// RVA: 0x185D120 Offset: 0x185D221 VA: 0x185D120
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x185D1D0 Offset: 0x185D2D1 VA: 0x185D1D0
	public static CaseInsensitiveComparer get_Default() { }

	// RVA: 0x185D260 Offset: 0x185D361 VA: 0x185D260 Slot: 4
	public int Compare(object a, object b) { }
}

