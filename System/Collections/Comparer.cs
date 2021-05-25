[ComVisibleAttribute] // RVA: 0xB2B70 Offset: 0xB2C71 VA: 0xB2B70
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 1353
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x185E740 Offset: 0x185E841 VA: 0x185E740
	private void .ctor() { }

	// RVA: 0x185E770 Offset: 0x185E871 VA: 0x185E770
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x185E820 Offset: 0x185E921 VA: 0x185E820
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x185D350 Offset: 0x185D451 VA: 0x185D350 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x185E9A0 Offset: 0x185EAA1 VA: 0x185E9A0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x185EA60 Offset: 0x185EB61 VA: 0x185EA60
	private static void .cctor() { }
}

