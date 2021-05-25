[AddComponentMenu] // RVA: 0x1413F0 Offset: 0x1414F1 VA: 0x1413F0
[DisallowMultipleComponent] // RVA: 0x1413F0 Offset: 0x1414F1 VA: 0x1413F0
internal sealed class Entity : MonoBehaviour // TypeDefIndex: 5950
{
	// Fields
	[HideInInspector] // RVA: 0x1419D0 Offset: 0x141AD1 VA: 0x1419D0
	[SerializeField] // RVA: 0x1419D0 Offset: 0x141AD1 VA: 0x1419D0
	[FormerlySerializedAsAttribute] // RVA: 0x1419D0 Offset: 0x141AD1 VA: 0x1419D0
	private EntityType m_EntityType; // 0x18

	// Properties
	public EntityType entityType { get; }

	// Methods

	// RVA: 0x1A91C20 Offset: 0x1A91D21 VA: 0x1A91C20
	public EntityType get_entityType() { }

	// RVA: 0x1A91C30 Offset: 0x1A91D31 VA: 0x1A91C30
	public void Awake() { }

	// RVA: 0x1A91D00 Offset: 0x1A91E01 VA: 0x1A91D00
	public void SetEntity(EntityType t) { }

	// RVA: 0x1A91D10 Offset: 0x1A91E11 VA: 0x1A91D10
	public void .ctor() { }
}

