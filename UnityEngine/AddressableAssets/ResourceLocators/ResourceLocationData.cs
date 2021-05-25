[Serializable]
public class ResourceLocationData // TypeDefIndex: 5730
{
	// Fields
	[SerializeField] // RVA: 0x13E050 Offset: 0x13E151 VA: 0x13E050
	[FormerlySerializedAsAttribute] // RVA: 0x13E050 Offset: 0x13E151 VA: 0x13E050
	private string[] m_Keys; // 0x10
	[SerializeField] // RVA: 0x13E0A0 Offset: 0x13E1A1 VA: 0x13E0A0
	[FormerlySerializedAsAttribute] // RVA: 0x13E0A0 Offset: 0x13E1A1 VA: 0x13E0A0
	private string m_InternalId; // 0x18
	[SerializeField] // RVA: 0x13E0F0 Offset: 0x13E1F1 VA: 0x13E0F0
	[FormerlySerializedAsAttribute] // RVA: 0x13E0F0 Offset: 0x13E1F1 VA: 0x13E0F0
	private string m_Provider; // 0x20
	[SerializeField] // RVA: 0x13E140 Offset: 0x13E241 VA: 0x13E140
	[FormerlySerializedAsAttribute] // RVA: 0x13E140 Offset: 0x13E241 VA: 0x13E140
	private string[] m_Dependencies; // 0x28
	[SerializeField] // RVA: 0x13E190 Offset: 0x13E291 VA: 0x13E190
	private SerializedType m_ResourceType; // 0x30

	// Properties
	public string[] Keys { get; }
	public string InternalId { get; }
	public string Provider { get; }
	public string[] Dependencies { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x15EBFA0 Offset: 0x15EC0A1 VA: 0x15EBFA0
	public string[] get_Keys() { }

	// RVA: 0x15EBFB0 Offset: 0x15EC0B1 VA: 0x15EBFB0
	public string get_InternalId() { }

	// RVA: 0x15EBFC0 Offset: 0x15EC0C1 VA: 0x15EBFC0
	public string get_Provider() { }

	// RVA: 0x15EBFD0 Offset: 0x15EC0D1 VA: 0x15EBFD0
	public string[] get_Dependencies() { }

	// RVA: 0x15EBFE0 Offset: 0x15EC0E1 VA: 0x15EBFE0
	public Type get_ResourceType() { }

	// RVA: 0x15EBFF0 Offset: 0x15EC0F1 VA: 0x15EBFF0
	public void .ctor(string[] keys, string id, Type provider, Type t, string[] dependencies) { }
}

