[ComVisibleAttribute] // RVA: 0xACAF0 Offset: 0xACBF1 VA: 0xACAF0
[Serializable]
public sealed class TypeInitializationException : SystemException // TypeDefIndex: 334
{
	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1ADE1F0 Offset: 0x1ADE2F1 VA: 0x1ADE1F0
	private void .ctor() { }

	// RVA: 0x1ADE270 Offset: 0x1ADE371 VA: 0x1ADE270
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x1ADE380 Offset: 0x1ADE481 VA: 0x1ADE380
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ADE420 Offset: 0x1ADE521 VA: 0x1ADE420
	public string get_TypeName() { }

	// RVA: 0x1ADE490 Offset: 0x1ADE591 VA: 0x1ADE490 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

