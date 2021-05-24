[DefaultMemberAttribute] // RVA: 0xB3C00 Offset: 0xB3D01 VA: 0xB3C00
[TypeDependencyAttribute] // RVA: 0xB3C00 Offset: 0xB3D01 VA: 0xB3C00
public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1460
{
	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/
}

