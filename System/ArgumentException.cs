[ComVisibleAttribute] // RVA: 0xAB9F0 Offset: 0xABAF1 VA: 0xAB9F0
[Serializable]
public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 176
{
	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1847F10 Offset: 0x1848011 VA: 0x1847F10
	public void .ctor() { }

	// RVA: 0x18466C0 Offset: 0x18467C1 VA: 0x18466C0
	public void .ctor(string message) { }

	// RVA: 0x1847F90 Offset: 0x1848091 VA: 0x1847F90
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1847FD0 Offset: 0x18480D1 VA: 0x1847FD0
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1848020 Offset: 0x1848121 VA: 0x1848020
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18480C0 Offset: 0x18481C1 VA: 0x18480C0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x18481E0 Offset: 0x18482E1 VA: 0x18481E0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

