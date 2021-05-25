public struct UserPresence // TypeDefIndex: 11673
{
	// Methods

	// RVA: 0x363930 Offset: 0x363A31 VA: 0x363930
	public Result Initialize(Uid uid) { }

	// RVA: 0x363950 Offset: 0x363A51 VA: 0x363950
	public Result Initialize() { }

	// RVA: 0x363970 Offset: 0x363A71 VA: 0x363970
	public void Clear() { }

	// RVA: 0x363980 Offset: 0x363A81 VA: 0x363980
	public Result Commit() { }

	// RVA: 0x3639A0 Offset: 0x363AA1 VA: 0x3639A0
	public void DeclareOpenOnlinePlaySession() { }

	// RVA: 0x3639B0 Offset: 0x363AB1 VA: 0x3639B0
	public void DeclareCloseOnlinePlaySession() { }

	// RVA: 0x3639C0 Offset: 0x363AC1 VA: 0x3639C0
	public Result SetDescription(string description) { }

	// RVA: 0x26AD000 Offset: 0x26AD101 VA: 0x26AD000
	private static extern Result Initialize(ref UserPresence pUserPresence, Uid uid) { }

	// RVA: 0x26AD040 Offset: 0x26AD141 VA: 0x26AD040
	private static extern Result Initialize(ref UserPresence pUserPresence) { }

	// RVA: 0x26AD070 Offset: 0x26AD171 VA: 0x26AD070
	private static extern void Clear(ref UserPresence pUserPresence) { }

	// RVA: 0x26AD0A0 Offset: 0x26AD1A1 VA: 0x26AD0A0
	private static extern Result Commit(ref UserPresence pUserPresence) { }

	// RVA: 0x26AD0D0 Offset: 0x26AD1D1 VA: 0x26AD0D0
	private static extern void DeclareOpenOnlinePlaySession(ref UserPresence pUserPresence) { }

	// RVA: 0x26AD0F0 Offset: 0x26AD1F1 VA: 0x26AD0F0
	private static extern void DeclareCloseOnlinePlaySession(ref UserPresence pUserPresence) { }

	// RVA: 0x26AD150 Offset: 0x26AD251 VA: 0x26AD150
	private static extern Result SetDescription(ref UserPresence pUserPresence, [In] string description) { }
}

