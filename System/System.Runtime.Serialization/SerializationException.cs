[ComVisibleAttribute] // RVA: 0xB07D0 Offset: 0xB08D1 VA: 0xB07D0
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 1029
{
	// Fields
	private static string _nullMessage; // 0x0

	// Methods

	// RVA: 0x151E9D0 Offset: 0x151EAD1 VA: 0x151E9D0
	public void .ctor() { }

	// RVA: 0x15098A0 Offset: 0x15099A1 VA: 0x15098A0
	public void .ctor(string message) { }

	// RVA: 0x151B080 Offset: 0x151B181 VA: 0x151B080
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x151EA60 Offset: 0x151EB61 VA: 0x151EA60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x151EA70 Offset: 0x151EB71 VA: 0x151EA70
	private static void .cctor() { }
}

