[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 3259
{
	// Fields
	[SerializeField] // RVA: 0xCB380 Offset: 0xCB481 VA: 0xCB380
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField] // RVA: 0xCB390 Offset: 0xCB491 VA: 0xCB390
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField] // RVA: 0xCB3A0 Offset: 0xCB4A1 VA: 0xCB3A0
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x2B69660 Offset: 0x2B69761 VA: 0x2B69660
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2B68620 Offset: 0x2B68721 VA: 0x2B68620
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x2B68A40 Offset: 0x2B68B41 VA: 0x2B68A40
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2B69C20 Offset: 0x2B69D21 VA: 0x2B69C20
	public void .ctor() { }
}

