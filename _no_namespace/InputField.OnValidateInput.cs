public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 3949
{
	// Methods

	// RVA: 0x18B9C10 Offset: 0x18B9D11 VA: 0x18B9C10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18B9C30 Offset: 0x18B9D31 VA: 0x18B9C30 Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x18BA0B0 Offset: 0x18BA1B1 VA: 0x18BA0B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x18BA170 Offset: 0x18BA271 VA: 0x18BA170 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

