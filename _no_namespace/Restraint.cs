[Serializable]
public class Restraint // TypeDefIndex: 6808
{
	// Fields
	[SerializeField] // RVA: 0x15FB20 Offset: 0x15FC21 VA: 0x15FB20
	private List<Transform> m_TargetList; // 0x10
	[SerializeField] // RVA: 0x15FB30 Offset: 0x15FC31 VA: 0x15FB30
	[RangeAttribute] // RVA: 0x15FB30 Offset: 0x15FC31 VA: 0x15FB30
	private float m_Weight; // 0x18
	[SerializeField] // RVA: 0x15FB70 Offset: 0x15FC71 VA: 0x15FB70
	private Vector3 m_PositionOffset; // 0x1C
	[SerializeField] // RVA: 0x15FB80 Offset: 0x15FC81 VA: 0x15FB80
	private Vector3 m_RotationOffset; // 0x28
	[SerializeField] // RVA: 0x15FB90 Offset: 0x15FC91 VA: 0x15FB90
	private Vector3 m_Scale; // 0x34
	[SerializeField] // RVA: 0x15FBA0 Offset: 0x15FCA1 VA: 0x15FBA0
	private RestraintSource[] m_Sources; // 0x40

	// Properties
	public bool IsAttached { get; }

	// Methods

	// RVA: 0x232AC40 Offset: 0x232AD41 VA: 0x232AC40
	public bool get_IsAttached() { }

	// RVA: 0x232ACB0 Offset: 0x232ADB1 VA: 0x232ACB0
	public void Update() { }

	// RVA: 0x232B3B0 Offset: 0x232B4B1 VA: 0x232B3B0
	public void Attach(Transform target) { }

	// RVA: 0x232B470 Offset: 0x232B571 VA: 0x232B470
	public void MannequinEquipSetParent() { }

	// RVA: 0x232B610 Offset: 0x232B711 VA: 0x232B610
	public void Detach(Transform target) { }

	// RVA: 0x232B680 Offset: 0x232B781 VA: 0x232B680
	public void Clear() { }

	// RVA: 0x232B6E0 Offset: 0x232B7E1 VA: 0x232B6E0
	public void Release() { }

	// RVA: 0x232B790 Offset: 0x232B891 VA: 0x232B790
	public void .ctor(RestraintSource[] sources) { }
}

