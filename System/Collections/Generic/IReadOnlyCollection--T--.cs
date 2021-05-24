[TypeDependencyAttribute] // RVA: 0xB3B80 Offset: 0xB3C81 VA: 0xB3B80
public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1458
{
	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyCollection<object>.get_Count
	*/
}

