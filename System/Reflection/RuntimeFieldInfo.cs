internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 590
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x17F1550 Offset: 0x17F1651 VA: 0x17F1550
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17F1560 Offset: 0x17F1661 VA: 0x17F1560 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x17F16A0 Offset: 0x17F17A1 VA: 0x17F16A0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17F1730 Offset: 0x17F1831 VA: 0x17F1730
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17F1600 Offset: 0x17F1701 VA: 0x17F1600
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17F17C0 Offset: 0x17F18C1 VA: 0x17F17C0 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F0A70 Offset: 0x17F0B71 VA: 0x17F0A70
	protected void .ctor() { }
}

