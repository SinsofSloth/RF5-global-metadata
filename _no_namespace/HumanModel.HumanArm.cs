[Serializable]
public class HumanModel.HumanArm // TypeDefIndex: 6661
{
	// Fields
	private float m_Weight; // 0x10
	private Transform m_Target; // 0x18
	private IKSolverLimb m_Solver; // 0x20
	[SerializeField] // RVA: 0x195490 Offset: 0x195591 VA: 0x195490
	private bool m_enable; // 0x28
	[SerializeField] // RVA: 0x1954A0 Offset: 0x1955A1 VA: 0x1954A0
	private Transform m_IkPoint; // 0x30

	// Properties
	public bool Enable { get; set; }

	// Methods

	// RVA: 0x20C03F0 Offset: 0x20C04F1 VA: 0x20C03F0
	public bool get_Enable() { }

	// RVA: 0x20C0400 Offset: 0x20C0501 VA: 0x20C0400
	public void set_Enable(bool value) { }

	// RVA: 0x20BE3E0 Offset: 0x20BE4E1 VA: 0x20BE3E0
	public void .ctor(Transform ikPoint) { }

	// RVA: 0x20C0410 Offset: 0x20C0511 VA: 0x20C0410
	public void Setup(IKSolverLimb solver) { }

	// RVA: 0x20C0420 Offset: 0x20C0521 VA: 0x20C0420
	public void SetWeight(float _weight) { }

	// RVA: 0x20C0430 Offset: 0x20C0531 VA: 0x20C0430
	public void SetTarget(Transform _target) { }

	// RVA: 0x20BF5C0 Offset: 0x20BF6C1 VA: 0x20BF5C0
	public void Update() { }
}

