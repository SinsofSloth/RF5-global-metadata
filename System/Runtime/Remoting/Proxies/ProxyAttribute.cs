[ComVisibleAttribute] // RVA: 0xB0BE0 Offset: 0xB0CE1 VA: 0xB0BE0
[AttributeUsageAttribute] // RVA: 0xB0BE0 Offset: 0xB0CE1 VA: 0xB0BE0
public class ProxyAttribute : Attribute // TypeDefIndex: 1132
{
	// Methods

	// RVA: 0x15EFD80 Offset: 0x15EFE81 VA: 0x15EFD80 Slot: 4
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x15EFF50 Offset: 0x15F0051 VA: 0x15EFF50 Slot: 5
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }
}

