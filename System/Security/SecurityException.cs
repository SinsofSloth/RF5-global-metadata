[ComVisibleAttribute] // RVA: 0xAF9D0 Offset: 0xAFAD1 VA: 0xAF9D0
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 891
{
	// Fields
	private string permissionState; // 0x88

	// Methods

	// RVA: 0x2642990 Offset: 0x2642A91 VA: 0x2642990
	public void .ctor() { }

	// RVA: 0x2642A00 Offset: 0x2642B01 VA: 0x2642A00
	public void .ctor(string message) { }

	// RVA: 0x2642A30 Offset: 0x2642B31 VA: 0x2642A30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2642B80 Offset: 0x2642C81 VA: 0x2642B80
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x2642BB0 Offset: 0x2642CB1 VA: 0x2642BB0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2642CD0 Offset: 0x2642DD1 VA: 0x2642CD0 Slot: 3
	public override string ToString() { }
}

