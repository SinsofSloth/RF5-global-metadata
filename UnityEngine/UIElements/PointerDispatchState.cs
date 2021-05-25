internal class PointerDispatchState // TypeDefIndex: 4127
{
	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0x15BCDE0 Offset: 0x15BCEE1 VA: 0x15BCDE0
	public void .ctor() { }

	// RVA: 0x15C6FD0 Offset: 0x15C70D1 VA: 0x15C6FD0
	internal void Reset() { }

	// RVA: 0x15C5ED0 Offset: 0x15C5FD1 VA: 0x15C5ED0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0x15C5CB0 Offset: 0x15C5DB1 VA: 0x15C5CB0
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x15C5D00 Offset: 0x15C5E01 VA: 0x15C5D00
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x15C5F10 Offset: 0x15C6011 VA: 0x15C5F10
	public void ReleasePointer(int pointerId) { }

	// RVA: 0x15C5E70 Offset: 0x15C5F71 VA: 0x15C5E70
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x15C6370 Offset: 0x15C6471 VA: 0x15C6370
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0x15C6060 Offset: 0x15C6161 VA: 0x15C6060
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x15C61B0 Offset: 0x15C62B1 VA: 0x15C61B0
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x15C61F0 Offset: 0x15C62F1 VA: 0x15C61F0
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }
}

