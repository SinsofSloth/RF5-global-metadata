public sealed class AsyncContext : IDisposable // TypeDefIndex: 11713
{
	// Fields
	internal IntPtr _context; // 0x10

	// Methods

	// RVA: 0x26A47B0 Offset: 0x26A48B1 VA: 0x26A47B0
	public void .ctor() { }

	// RVA: 0x26A4820 Offset: 0x26A4921 VA: 0x26A4820 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A4930 Offset: 0x26A4A31 VA: 0x26A4930 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A48D0 Offset: 0x26A49D1 VA: 0x26A48D0
	private void Dispose(bool disposing) { }

	// RVA: 0x26A49F0 Offset: 0x26A4AF1 VA: 0x26A49F0
	public Result Cancel() { }

	// RVA: 0x26A4A30 Offset: 0x26A4B31 VA: 0x26A4A30
	public Result HasDone(ref bool pOut) { }

	// RVA: 0x26A4A70 Offset: 0x26A4B71 VA: 0x26A4A70
	public Result GetResult() { }

	// RVA: 0x26A4810 Offset: 0x26A4911 VA: 0x26A4810
	private static extern IntPtr Create() { }

	// RVA: 0x26A49E0 Offset: 0x26A4AE1 VA: 0x26A49E0
	private static extern void Destroy(IntPtr context) { }

	// RVA: 0x26A4A10 Offset: 0x26A4B11 VA: 0x26A4A10
	private static extern Result Cancel(IntPtr context) { }

	// RVA: 0x26A4A50 Offset: 0x26A4B51 VA: 0x26A4A50
	private static extern Result HasDone(IntPtr context, ref bool pOut) { }

	// RVA: 0x26A4A90 Offset: 0x26A4B91 VA: 0x26A4A90
	private static extern Result GetResult(IntPtr context) { }
}

