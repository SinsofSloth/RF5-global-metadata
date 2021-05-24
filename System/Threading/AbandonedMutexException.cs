[ComVisibleAttribute] // RVA: 0xAF210 Offset: 0xAF311 VA: 0xAF210
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 776
{
	// Fields
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90

	// Methods

	// RVA: 0x1A0A340 Offset: 0x1A0A441 VA: 0x1A0A340
	public void .ctor() { }

	// RVA: 0x1A0A3C0 Offset: 0x1A0A4C1 VA: 0x1A0A3C0
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x1A0A4B0 Offset: 0x1A0A5B1 VA: 0x1A0A4B0
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x1A0A540 Offset: 0x1A0A641 VA: 0x1A0A540
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

