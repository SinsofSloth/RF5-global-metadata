public interface IEqualityComparer<T> // TypeDefIndex: 1456
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.GetHashCode
	*/
}

