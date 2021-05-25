[Serializable]
private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2719
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C1F0 Offset: 0x267C2F1 VA: 0x267C1F0
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C240 Offset: 0x267C341 VA: 0x267C240
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C250 Offset: 0x267C351 VA: 0x267C250
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C260 Offset: 0x267C361 VA: 0x267C260
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C2E0 Offset: 0x267C3E1 VA: 0x267C2E0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C3C0 Offset: 0x267C4C1 VA: 0x267C3C0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/
}

