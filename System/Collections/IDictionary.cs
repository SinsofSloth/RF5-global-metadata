[ComVisibleAttribute] // RVA: 0xB2D20 Offset: 0xB2E21 VA: 0xB2D20
[DefaultMemberAttribute] // RVA: 0xB2D20 Offset: 0xB2E21 VA: 0xB2D20
public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1366
{
	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object key) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Add(object key, object value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDictionaryEnumerator GetEnumerator() { }
}

