[DebuggerTypeProxyAttribute] // RVA: 0xAB610 Offset: 0xAB711 VA: 0xAB610
[DebuggerDisplayAttribute] // RVA: 0xAB610 Offset: 0xAB711 VA: 0xAB610
[ComVisibleAttribute] // RVA: 0xAB610 Offset: 0xAB711 VA: 0xAB610
[Serializable]
public class Lazy<T> // TypeDefIndex: 141
{
	// Fields
	private static readonly Func<T> ALREADY_INVOKED_SENTINEL; // 0x0
	private object m_boxed; // 0x0
	private Func<T> m_valueFactory; // 0x0
	private object m_threadSafeObj; // 0x0

	// Properties
	internal LazyThreadSafetyMode Mode { get; }
	public bool IsValueCreated { get; }
	[DebuggerBrowsableAttribute] // RVA: 0xB9FE0 Offset: 0xBA0E1 VA: 0xB9FE0
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14610 Offset: 0x2B14711 VA: 0x2B14610
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14640 Offset: 0x2B14741 VA: 0x2B14640
	|-Lazy<DynamicAssembly>..ctor
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14670 Offset: 0x2B14771 VA: 0x2B14670
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory, LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14740 Offset: 0x2B14841 VA: 0x2B14740
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static object GetObjectFromMode(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14890 Offset: 0x2B14991 VA: 0x2B14890
	|-Lazy<object>.GetObjectFromMode
	*/

	[OnSerializingAttribute] // RVA: 0xB58A0 Offset: 0xB59A1 VA: 0xB58A0
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B149B0 Offset: 0x2B14AB1 VA: 0x2B149B0
	|-Lazy<object>.OnSerializing
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B149E0 Offset: 0x2B14AE1 VA: 0x2B149E0
	|-Lazy<object>.ToString
	*/

	// RVA: -1 Offset: -1
	internal LazyThreadSafetyMode get_Mode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14AA0 Offset: 0x2B14BA1 VA: 0x2B14AA0
	|-Lazy<object>.get_Mode
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14B30 Offset: 0x2B14C31 VA: 0x2B14B30
	|-Lazy<object>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14B90 Offset: 0x2B14C91 VA: 0x2B14B90
	|-Lazy<DynamicAssembly>.get_Value
	|-Lazy<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	private T LazyInitValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14CD0 Offset: 0x2B14DD1 VA: 0x2B14CD0
	|-Lazy<object>.LazyInitValue
	*/

	// RVA: -1 Offset: -1
	private Lazy.Boxed<T> CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B15190 Offset: 0x2B15291 VA: 0x2B15190
	|-Lazy<object>.CreateValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B15800 Offset: 0x2B15901 VA: 0x2B15800
	|-Lazy<object>..cctor
	*/
}

