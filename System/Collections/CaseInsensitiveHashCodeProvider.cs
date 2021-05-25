[ComVisibleAttribute] // RVA: 0xB2B00 Offset: 0xB2C01 VA: 0xB2B00
[ObsoleteAttribute] // RVA: 0xB2B00 Offset: 0xB2C01 VA: 0xB2B00
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 1351
{
	// Fields
	private TextInfo m_text; // 0x10

	// Properties
	public static CaseInsensitiveHashCodeProvider Default { get; }

	// Methods

	// RVA: 0x185D590 Offset: 0x185D691 VA: 0x185D590
	public void .ctor() { }

	// RVA: 0x185D630 Offset: 0x185D731 VA: 0x185D630
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x185D6E0 Offset: 0x185D7E1 VA: 0x185D6E0
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	// RVA: 0x185D770 Offset: 0x185D871 VA: 0x185D770 Slot: 4
	public int GetHashCode(object obj) { }
}

