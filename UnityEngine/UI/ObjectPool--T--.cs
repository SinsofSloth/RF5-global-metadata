internal class ObjectPool<T> // TypeDefIndex: 4020
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11C9F0 Offset: 0x11CAF1 VA: 0x11C9F0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11D2D0 Offset: 0x11D3D1 VA: 0x11D2D0
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD7A0 Offset: 0x2AAD8A1 VA: 0x2AAD7A0
	|-ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11D2E0 Offset: 0x11D3E1 VA: 0x11D2E0
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD7B0 Offset: 0x2AAD8B1 VA: 0x2AAD7B0
	|-ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD7C0 Offset: 0x2AAD8C1 VA: 0x2AAD7C0
	|-ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD830 Offset: 0x2AAD931 VA: 0x2AAD830
	|-ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD860 Offset: 0x2AAD961 VA: 0x2AAD860
	|-ObjectPool<List<IEventSystemHandler>>..ctor
	|-ObjectPool<object>..ctor
	|-ObjectPool<LayoutRebuilder>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD920 Offset: 0x2AADA21 VA: 0x2AAD920
	|-ObjectPool<List<IEventSystemHandler>>.Get
	|-ObjectPool<object>.Get
	|-ObjectPool<LayoutRebuilder>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADA10 Offset: 0x2AADB11 VA: 0x2AADA10
	|-ObjectPool<List<IEventSystemHandler>>.Release
	|-ObjectPool<object>.Release
	|-ObjectPool<LayoutRebuilder>.Release
	*/
}

