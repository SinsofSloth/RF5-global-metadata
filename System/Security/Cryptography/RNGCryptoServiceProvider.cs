public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 982
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x19545B0 Offset: 0x19546B1 VA: 0x19545B0
	private static void .cctor() { }

	// RVA: 0x1945D40 Offset: 0x1945E41 VA: 0x1945D40
	public void .ctor() { }

	// RVA: 0x1954660 Offset: 0x1954761 VA: 0x1954660
	private void Check() { }

	// RVA: 0x1954640 Offset: 0x1954741 VA: 0x1954640
	private static bool RngOpen() { }

	// RVA: 0x1954650 Offset: 0x1954751 VA: 0x1954650
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x1954700 Offset: 0x1954801 VA: 0x1954700
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x1954710 Offset: 0x1954811 VA: 0x1954710
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1954720 Offset: 0x1954821 VA: 0x1954720 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1954970 Offset: 0x1954A71 VA: 0x1954970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1954A50 Offset: 0x1954B51 VA: 0x1954A50 Slot: 5
	protected override void Dispose(bool disposing) { }
}

