[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 1786
{
	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x161BB00 Offset: 0x161BC01 VA: 0x161BB00
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x161BC30 Offset: 0x161BD31 VA: 0x161BC30
	public void .ctor() { }

	// RVA: 0x161BDE0 Offset: 0x161BEE1 VA: 0x161BDE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161BF10 Offset: 0x161C011 VA: 0x161BF10 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x161BD30 Offset: 0x161BE31 VA: 0x161BD30
	private void Init() { }

	// RVA: 0x161BBE0 Offset: 0x161BCE1 VA: 0x161BBE0
	private void Init(string input, string pattern, TimeSpan timeout) { }
}

