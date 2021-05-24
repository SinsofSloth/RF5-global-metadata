[Serializable]
public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3262
{
	// Fields
	[SerializeField] // RVA: 0xCB3B0 Offset: 0xCB4B1 VA: 0xCB3B0
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x2B69E10 Offset: 0x2B69F11 VA: 0x2B69E10
	public Guid get_MessageTypeId() { }

	// RVA: 0x2B69FE0 Offset: 0x2B6A0E1 VA: 0x2B69FE0
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x2B69F30 Offset: 0x2B6A031 VA: 0x2B69F30
	public void .ctor() { }
}

