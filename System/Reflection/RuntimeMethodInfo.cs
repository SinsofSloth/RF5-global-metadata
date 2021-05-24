internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 594
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x17F1900 Offset: 0x17F1A01 VA: 0x17F1900
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17F1910 Offset: 0x17F1A11 VA: 0x17F1910 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x17F1A50 Offset: 0x17F1B51 VA: 0x17F1A50
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17F1AE0 Offset: 0x17F1BE1 VA: 0x17F1AE0 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x17F1C30 Offset: 0x17F1D31 VA: 0x17F1C30 Slot: 43
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x17F1C50 Offset: 0x17F1D51 VA: 0x17F1C50 Slot: 44
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x17F1C70 Offset: 0x17F1D71 VA: 0x17F1C70 Slot: 3
	public override string ToString() { }

	// RVA: 0x17F19B0 Offset: 0x17F1AB1 VA: 0x17F19B0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17F1D10 Offset: 0x17F1E11 VA: 0x17F1D10 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F1F50 Offset: 0x17F2051 VA: 0x17F1F50
	internal string SerializationToString() { }

	// RVA: 0x17F2000 Offset: 0x17F2101 VA: 0x17F2000
	protected void .ctor() { }
}

