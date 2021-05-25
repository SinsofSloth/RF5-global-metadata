internal interface IPlayerEditorConnectionNative // TypeDefIndex: 2972
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected() { }
}

