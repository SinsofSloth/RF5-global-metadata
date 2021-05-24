internal class ObjectPool<T> // TypeDefIndex: 4118
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private int m_MaxSize; // 0x0

	// Properties
	public int maxSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_maxSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1980 Offset: 0x2AB1A81 VA: 0x2AB1980
	|-ObjectPool<object>.get_maxSize
	*/

	// RVA: -1 Offset: -1
	public void set_maxSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1990 Offset: 0x2AB1A91 VA: 0x2AB1990
	|-ObjectPool<object>.set_maxSize
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxSize = 100) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1A60 Offset: 0x2AB1B61 VA: 0x2AB1A60
	|-ObjectPool<List<VisualElement>>..ctor
	|-ObjectPool<Queue<EventDispatcher.EventRecord>>..ctor
	|-ObjectPool<object>..ctor
	|-ObjectPool<PropagationPaths>..ctor
	*/

	// RVA: -1 Offset: -1
	public int Size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1B10 Offset: 0x2AB1C11 VA: 0x2AB1B10
	|-ObjectPool<object>.Size
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1B40 Offset: 0x2AB1C41 VA: 0x2AB1B40
	|-ObjectPool<List<VisualElement>>.Get
	|-ObjectPool<Queue<EventDispatcher.EventRecord>>.Get
	|-ObjectPool<object>.Get
	|-ObjectPool<PropagationPaths>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1BC0 Offset: 0x2AB1CC1 VA: 0x2AB1BC0
	|-ObjectPool<List<VisualElement>>.Release
	|-ObjectPool<Queue<EventDispatcher.EventRecord>>.Release
	|-ObjectPool<object>.Release
	|-ObjectPool<PropagationPaths>.Release
	*/
}

