[NativeHeaderAttribute] // RVA: 0xC6260 Offset: 0xC6361 VA: 0xC6260
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 2973
{
	// Methods

	// RVA: 0x2B723B0 Offset: 0x2B724B1 VA: 0x2B723B0 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2B72540 Offset: 0x2B72641 VA: 0x2B72540 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2B726E0 Offset: 0x2B727E1 VA: 0x2B726E0 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x2B72760 Offset: 0x2B72861 VA: 0x2B72760 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x2B72840 Offset: 0x2B72941 VA: 0x2B72840 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x2B72920 Offset: 0x2B72A21 VA: 0x2B72920 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x2B729A0 Offset: 0x2B72AA1 VA: 0x2B729A0 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x2B72A20 Offset: 0x2B72B21 VA: 0x2B72A20 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xD5510 Offset: 0xD5611 VA: 0xD5510
	// RVA: 0x2B729E0 Offset: 0x2B72AE1 VA: 0x2B729E0
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xD5550 Offset: 0xD5651 VA: 0xD5550
	// RVA: 0x2B72960 Offset: 0x2B72A61 VA: 0x2B72960
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xD5590 Offset: 0xD5691 VA: 0xD5590
	// RVA: 0x2B727F0 Offset: 0x2B728F1 VA: 0x2B727F0
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xD55D0 Offset: 0xD56D1 VA: 0xD55D0
	// RVA: 0x2B728D0 Offset: 0x2B729D1 VA: 0x2B728D0
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xD5610 Offset: 0xD5711 VA: 0xD5610
	// RVA: 0x2B724E0 Offset: 0x2B725E1 VA: 0x2B724E0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xD5650 Offset: 0xD5751 VA: 0xD5650
	// RVA: 0x2B72680 Offset: 0x2B72781 VA: 0x2B72680
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xD5690 Offset: 0xD5791 VA: 0xD5690
	// RVA: 0x2B72720 Offset: 0x2B72821 VA: 0x2B72720
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xD56D0 Offset: 0xD57D1 VA: 0xD56D0
	// RVA: 0x2B72A60 Offset: 0x2B72B61 VA: 0x2B72A60
	private static void DisconnectAll() { }

	// RVA: 0x2B683A0 Offset: 0x2B684A1 VA: 0x2B683A0
	public void .ctor() { }
}

