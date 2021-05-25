public class BitController : MonoBehaviour // TypeDefIndex: 6576
{
	// Fields
	[SerializeField] // RVA: 0x15D7D0 Offset: 0x15D8D1 VA: 0x15D7D0
	protected List<Vector3> m_offsets; // 0x18
	protected List<BitBase> m_bits; // 0x20

	// Properties
	public bool IsSummon { get; }

	// Methods

	// RVA: 0x22E3B60 Offset: 0x22E3C61 VA: 0x22E3B60
	public bool get_IsSummon() { }

	// RVA: 0x22E3BC0 Offset: 0x22E3CC1 VA: 0x22E3BC0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x22E3C20 Offset: 0x22E3D21 VA: 0x22E3C20 Slot: 5
	public virtual bool DoCall(BitID bitID, int level) { }

	// RVA: 0x22E3C30 Offset: 0x22E3D31 VA: 0x22E3C30 Slot: 6
	public virtual bool DoRelease() { }

	// RVA: 0x22E3DE0 Offset: 0x22E3EE1 VA: 0x22E3DE0 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x22E4030 Offset: 0x22E4131 VA: 0x22E4030 Slot: 8
	public virtual void OnFixedUpdate() { }

	// RVA: 0x22E41C0 Offset: 0x22E42C1 VA: 0x22E41C0
	public void .ctor() { }
}

