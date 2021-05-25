public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 752
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x17190 Offset: 0x17291 VA: 0x17190
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB8920 Offset: 0xB8A21 VA: 0xB8920
	// RVA: 0x171E0 Offset: 0x172E1 VA: 0x171E0
	internal bool TryDeregister() { }

	// RVA: 0x17250 Offset: 0x17351 VA: 0x17250 Slot: 5
	public void Dispose() { }

	// RVA: 0x17260 Offset: 0x17361 VA: 0x17260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17330 Offset: 0x17431 VA: 0x17330 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x173C0 Offset: 0x174C1 VA: 0x173C0 Slot: 2
	public override int GetHashCode() { }
}

