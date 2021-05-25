internal class SendMouseEvents // TypeDefIndex: 3634
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xF9B10 Offset: 0xF9C11 VA: 0xF9B10
	// RVA: 0x1BDC470 Offset: 0x1BDC571 VA: 0x1BDC470
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF9B20 Offset: 0xF9C21 VA: 0xF9B20
	// RVA: 0x1BDC4E0 Offset: 0x1BDC5E1 VA: 0x1BDC4E0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x1BDCF50 Offset: 0x1BDD051 VA: 0x1BDCF50
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x1BDD640 Offset: 0x1BDD741 VA: 0x1BDD640
	private static void .cctor() { }
}

