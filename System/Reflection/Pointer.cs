[CLSCompliantAttribute] // RVA: 0xADE70 Offset: 0xADF71 VA: 0xADE70
[ComVisibleAttribute] // RVA: 0xADE70 Offset: 0xADF71 VA: 0xADE70
[Serializable]
public sealed class Pointer : ISerializable // TypeDefIndex: 557
{
	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x17EFA30 Offset: 0x17EFB31 VA: 0x17EFA30
	private void .ctor() { }

	// RVA: 0x17EFA40 Offset: 0x17EFB41 VA: 0x17EFA40
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EFBB0 Offset: 0x17EFCB1 VA: 0x17EFBB0
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x17EFD80 Offset: 0x17EFE81 VA: 0x17EFD80 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

