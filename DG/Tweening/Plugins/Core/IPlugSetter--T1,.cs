public interface IPlugSetter<T1, T2, TPlugin, TPlugOptions> // TypeDefIndex: 5050
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DOGetter<T1> Getter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<object, object, object, object>.Getter
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DOSetter<T1> Setter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<object, object, object, object>.Setter
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract T2 EndValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<object, object, object, object>.EndValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TPlugOptions GetOptions() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<object, object, object, object>.GetOptions
	*/
}

