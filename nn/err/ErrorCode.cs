public struct ErrorCode // TypeDefIndex: 11688
{
	// Fields
	public uint category; // 0x0
	public uint number; // 0x4

	// Methods

	// RVA: 0x362430 Offset: 0x362531 VA: 0x362430 Slot: 3
	public override string ToString() { }

	// RVA: 0x3624D0 Offset: 0x3625D1 VA: 0x3624D0
	public bool IsValid() { }

	// RVA: 0x26A9720 Offset: 0x26A9821 VA: 0x26A9720
	private static extern bool IsValid(ErrorCode errorCode) { }

	// RVA: 0x26A7390 Offset: 0x26A7491 VA: 0x26A7390
	public static extern ErrorCode GetInvalidErrorCode() { }
}

