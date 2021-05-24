[Serializable]
internal class LongList // TypeDefIndex: 1014
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x1515CF0 Offset: 0x1515DF1 VA: 0x1515CF0
	internal void .ctor() { }

	// RVA: 0x1515D60 Offset: 0x1515E61 VA: 0x1515D60
	internal void .ctor(int startingSize) { }

	// RVA: 0x1515DE0 Offset: 0x1515EE1 VA: 0x1515DE0
	internal void Add(long value) { }

	// RVA: 0x1515F90 Offset: 0x1516091 VA: 0x1515F90
	internal int get_Count() { }

	// RVA: 0x1515FA0 Offset: 0x15160A1 VA: 0x1515FA0
	internal void StartEnumeration() { }

	// RVA: 0x1515FB0 Offset: 0x15160B1 VA: 0x1515FB0
	internal bool MoveNext() { }

	// RVA: 0x1516020 Offset: 0x1516121 VA: 0x1516020
	internal long get_Current() { }

	// RVA: 0x1516060 Offset: 0x1516161 VA: 0x1516060
	internal bool RemoveElement(long value) { }

	// RVA: 0x1515EF0 Offset: 0x1515FF1 VA: 0x1515EF0
	private void EnlargeArray() { }
}

