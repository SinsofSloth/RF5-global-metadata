public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 5807
{
	// Methods

	// RVA: 0x156F600 Offset: 0x156F701 VA: 0x156F600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1566070 Offset: 0x1566171 VA: 0x1566070 Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x156F620 Offset: 0x156F721 VA: 0x156F620 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x156F6E0 Offset: 0x156F7E1 VA: 0x156F6E0 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

