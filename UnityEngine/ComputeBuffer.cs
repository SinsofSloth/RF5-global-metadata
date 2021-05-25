[NativeHeaderAttribute] // RVA: 0xC7040 Offset: 0xC7141 VA: 0xC7040
[NativeHeaderAttribute] // RVA: 0xC7040 Offset: 0xC7141 VA: 0xC7040
[UsedByNativeCodeAttribute] // RVA: 0xC7040 Offset: 0xC7141 VA: 0xC7040
public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3049
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x2B01B40 Offset: 0x2B01C41 VA: 0x2B01B40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2B01CE0 Offset: 0x2B01DE1 VA: 0x2B01CE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B01C10 Offset: 0x2B01D11 VA: 0x2B01C10
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xD76B0 Offset: 0xD77B1 VA: 0xD76B0
	// RVA: 0x2B01F50 Offset: 0x2B02051 VA: 0x2B01F50
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xD76F0 Offset: 0xD77F1 VA: 0xD76F0
	// RVA: 0x2B01DC0 Offset: 0x2B01EC1 VA: 0x2B01DC0
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x2B01FC0 Offset: 0x2B020C1 VA: 0x2B01FC0
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x2B01FD0 Offset: 0x2B020D1 VA: 0x2B01FD0
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x2B02100 Offset: 0x2B02201 VA: 0x2B02100
	public void Release() { }

	// RVA: 0x2B02110 Offset: 0x2B02211 VA: 0x2B02110
	public void SetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xD7730 Offset: 0xD7831 VA: 0xD7730
	// RVA: 0x2B022B0 Offset: 0x2B023B1 VA: 0x2B022B0
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2B02330 Offset: 0x2B02431 VA: 0x2B02330
	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }
}

