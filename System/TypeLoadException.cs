[ComVisibleAttribute] // RVA: 0xACB10 Offset: 0xACC11 VA: 0xACB10
[Serializable]
public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 335
{
	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1ADE600 Offset: 0x1ADE701 VA: 0x1ADE600
	public void .ctor() { }

	// RVA: 0x1ADDAE0 Offset: 0x1ADDBE1 VA: 0x1ADDAE0
	public void .ctor(string message) { }

	// RVA: 0x1ADE680 Offset: 0x1ADE781 VA: 0x1ADE680 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1ADE6B0 Offset: 0x1ADE7B1 VA: 0x1ADE6B0
	private void SetMessageField() { }

	// RVA: 0x1ADE800 Offset: 0x1ADE901 VA: 0x1ADE800
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x1ADE890 Offset: 0x1ADE991 VA: 0x1ADE890
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x1ADDE10 Offset: 0x1ADDF11 VA: 0x1ADDE10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ADE930 Offset: 0x1ADEA31 VA: 0x1ADE930 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

