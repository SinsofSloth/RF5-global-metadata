[Serializable]
internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 313
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0xB43F0 Offset: 0xB44F1 VA: 0xB43F0
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x2983870 Offset: 0x2983971 VA: 0x2983870
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x2983930 Offset: 0x2983A31 VA: 0x2983930 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x2983980 Offset: 0x2983A81 VA: 0x2983980 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x29839E0 Offset: 0x2983AE1 VA: 0x29839E0 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x2983A90 Offset: 0x2983B91 VA: 0x2983A90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2983BA0 Offset: 0x2983CA1 VA: 0x2983BA0 Slot: 2
	public override int GetHashCode() { }
}

