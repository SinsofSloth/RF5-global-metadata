internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 588
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x17F11A0 Offset: 0x17F12A1 VA: 0x17F11A0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17F11B0 Offset: 0x17F12B1 VA: 0x17F11B0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x17F12F0 Offset: 0x17F13F1 VA: 0x17F12F0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17F1380 Offset: 0x17F1481 VA: 0x17F1380
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17F1250 Offset: 0x17F1351 VA: 0x17F1250
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17F1410 Offset: 0x17F1511 VA: 0x17F1410 Slot: 20
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F1540 Offset: 0x17F1641 VA: 0x17F1540
	protected void .ctor() { }
}

