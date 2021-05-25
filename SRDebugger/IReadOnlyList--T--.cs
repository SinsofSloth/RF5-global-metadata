[DefaultMemberAttribute] // RVA: 0x13B180 Offset: 0x13B281 VA: 0x13B180
public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 5524
{
	// Properties
	public abstract int Count { get; }
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/
}

