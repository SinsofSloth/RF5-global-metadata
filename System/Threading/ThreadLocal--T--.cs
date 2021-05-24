[DebuggerTypeProxyAttribute] // RVA: 0xAF180 Offset: 0xAF281 VA: 0xAF180
[DebuggerDisplayAttribute] // RVA: 0xAF180 Offset: 0xAF281 VA: 0xAF180
public class ThreadLocal<T> : IDisposable // TypeDefIndex: 770
{
	// Fields
	private Func<T> m_valueFactory; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB5420 Offset: 0xB5521 VA: 0xB5420
	private static ThreadLocal.LinkedSlotVolatile<T>[] ts_slotArray; // 0xFFFFFFFF
	[ThreadStaticAttribute] // RVA: 0xB5430 Offset: 0xB5531 VA: 0xB5430
	private static ThreadLocal.FinalizationHelper<T> ts_finalizationHelper; // 0xFFFFFFFF
	private int m_idComplement; // 0x0
	private bool m_initialized; // 0x0
	private static ThreadLocal.IdManager<T> s_idManager; // 0x0
	private ThreadLocal.LinkedSlot<T> m_linkedSlot; // 0x0
	private bool m_trackAllValues; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0xBA410 Offset: 0xBA511 VA: 0xBA410
	public T Value { get; set; }
	public bool IsValueCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92800 Offset: 0x2B92901 VA: 0x2B92800
	|-ThreadLocal<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B928B0 Offset: 0x2B929B1 VA: 0x2B928B0
	|-ThreadLocal<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B929C0 Offset: 0x2B92AC1 VA: 0x2B929C0
	|-ThreadLocal<object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92A50 Offset: 0x2B92B51 VA: 0x2B92A50
	|-ThreadLocal<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92AE0 Offset: 0x2B92BE1 VA: 0x2B92AE0
	|-ThreadLocal<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92E70 Offset: 0x2B92F71 VA: 0x2B92E70
	|-ThreadLocal<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92EB0 Offset: 0x2B92FB1 VA: 0x2B92EB0
	|-ThreadLocal<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92FE0 Offset: 0x2B930E1 VA: 0x2B92FE0
	|-ThreadLocal<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	private T GetValueSlow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B93130 Offset: 0x2B93231 VA: 0x2B93130
	|-ThreadLocal<object>.GetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void SetValueSlow(T value, ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B932B0 Offset: 0x2B933B1 VA: 0x2B932B0
	|-ThreadLocal<object>.SetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void CreateLinkedSlot(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, int id, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B93690 Offset: 0x2B93791 VA: 0x2B93690
	|-ThreadLocal<object>.CreateLinkedSlot
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B939E0 Offset: 0x2B93AE1 VA: 0x2B939E0
	|-ThreadLocal<object>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ref ThreadLocal.LinkedSlotVolatile<T>[] table, int minLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B93B80 Offset: 0x2B93C81 VA: 0x2B93B80
	|-ThreadLocal<object>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetNewTableSize(int minSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B93EC0 Offset: 0x2B93FC1 VA: 0x2B93EC0
	|-ThreadLocal<object>.GetNewTableSize
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B93F00 Offset: 0x2B94001 VA: 0x2B93F00
	|-ThreadLocal<object>..cctor
	*/
}

