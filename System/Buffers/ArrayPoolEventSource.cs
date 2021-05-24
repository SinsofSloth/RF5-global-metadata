internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 3748
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0x1BE0D60 Offset: 0x1BE0E61 VA: 0x1BE0D60
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	// RVA: 0x1BE0DD0 Offset: 0x1BE0ED1 VA: 0x1BE0DD0
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	// RVA: 0x1BE0E40 Offset: 0x1BE0F41 VA: 0x1BE0E40
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	// RVA: 0x1BE0EB0 Offset: 0x1BE0FB1 VA: 0x1BE0EB0
	public void .ctor() { }

	// RVA: 0x1BE0F20 Offset: 0x1BE1021 VA: 0x1BE0F20
	private static void .cctor() { }
}

