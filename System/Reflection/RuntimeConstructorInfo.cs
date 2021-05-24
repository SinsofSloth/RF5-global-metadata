internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 596
{
	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x17F0CA0 Offset: 0x17F0DA1 VA: 0x17F0CA0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x17F0D30 Offset: 0x17F0E31 VA: 0x17F0D30
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17F0DC0 Offset: 0x17F0EC1 VA: 0x17F0DC0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17F0DD0 Offset: 0x17F0ED1 VA: 0x17F0DD0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17F0E60 Offset: 0x17F0F61 VA: 0x17F0E60 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F0FD0 Offset: 0x17F10D1 VA: 0x17F0FD0
	internal string SerializationToString() { }

	// RVA: 0x17F0FF0 Offset: 0x17F10F1 VA: 0x17F0FF0
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F1130 Offset: 0x17F1231 VA: 0x17F1130
	protected void .ctor() { }
}

