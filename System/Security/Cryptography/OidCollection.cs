[DefaultMemberAttribute] // RVA: 0xBC010 Offset: 0xBC111 VA: 0xBC010
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 1826
{
	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x1711800 Offset: 0x1711901 VA: 0x1711800
	public void .ctor() { }

	// RVA: 0x1711880 Offset: 0x1711981 VA: 0x1711880
	public int Add(Oid oid) { }

	// RVA: 0x17118B0 Offset: 0x17119B1 VA: 0x17118B0
	public Oid get_Item(int index) { }

	// RVA: 0x1711940 Offset: 0x1711A41 VA: 0x1711940 Slot: 5
	public int get_Count() { }

	// RVA: 0x1711970 Offset: 0x1711A71 VA: 0x1711970 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1711A30 Offset: 0x1711B31 VA: 0x1711A30 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
}

