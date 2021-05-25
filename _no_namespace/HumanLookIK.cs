public class HumanLookIK : MonoBehaviour // TypeDefIndex: 6655
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15E690 Offset: 0x15E791 VA: 0x15E690
	private IKSolverLookAt <IKSolverLookAt>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x15E6A0 Offset: 0x15E7A1 VA: 0x15E6A0
	private Transform m_Target; // 0x20
	[SerializeField] // RVA: 0x15E6B0 Offset: 0x15E7B1 VA: 0x15E6B0
	private Vector3 m_Offset; // 0x28
	[SerializeField] // RVA: 0x15E6C0 Offset: 0x15E7C1 VA: 0x15E6C0
	private float m_maxDistance; // 0x34
	[SerializeField] // RVA: 0x15E6D0 Offset: 0x15E7D1 VA: 0x15E6D0
	private float m_LookSpeed; // 0x38
	[SerializeField] // RVA: 0x15E6E0 Offset: 0x15E7E1 VA: 0x15E6E0
	private float m_TargetChangeDelta; // 0x3C
	[SerializeField] // RVA: 0x15E6F0 Offset: 0x15E7F1 VA: 0x15E6F0
	[RangeAttribute] // RVA: 0x15E6F0 Offset: 0x15E7F1 VA: 0x15E6F0
	private float m_MaxAzimuth; // 0x40
	[SerializeField] // RVA: 0x15E740 Offset: 0x15E841 VA: 0x15E740
	[RangeAttribute] // RVA: 0x15E740 Offset: 0x15E841 VA: 0x15E740
	private float m_MinAzimuth; // 0x44
	[SerializeField] // RVA: 0x15E790 Offset: 0x15E891 VA: 0x15E790
	[RangeAttribute] // RVA: 0x15E790 Offset: 0x15E891 VA: 0x15E790
	private float m_MaxAltura; // 0x48
	[SerializeField] // RVA: 0x15E7E0 Offset: 0x15E8E1 VA: 0x15E7E0
	[RangeAttribute] // RVA: 0x15E7E0 Offset: 0x15E8E1 VA: 0x15E7E0
	private float m_MinAltura; // 0x4C
	[SerializeField] // RVA: 0x15E830 Offset: 0x15E931 VA: 0x15E830
	[RangeAttribute] // RVA: 0x15E830 Offset: 0x15E931 VA: 0x15E830
	private float m_MaxWeight; // 0x50
	[SerializeField] // RVA: 0x15E870 Offset: 0x15E971 VA: 0x15E870
	[RangeAttribute] // RVA: 0x15E870 Offset: 0x15E971 VA: 0x15E870
	private float m_BodyWeight; // 0x54
	[SerializeField] // RVA: 0x15E8B0 Offset: 0x15E9B1 VA: 0x15E8B0
	private bool m_IgnorAngle; // 0x58
	private float m_currentMaxWeight; // 0x5C
	private Transform m_head; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x15E8C0 Offset: 0x15E9C1 VA: 0x15E8C0
	private bool <IsDeltaTime>k__BackingField; // 0x68

	// Properties
	public IKSolverLookAt IKSolverLookAt { get; set; }
	public bool IsDeltaTime { get; set; }
	private float GetdeltaTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C5E0 Offset: 0x19C6E1 VA: 0x19C5E0
	// RVA: 0x20BC270 Offset: 0x20BC371 VA: 0x20BC270
	public IKSolverLookAt get_IKSolverLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C5F0 Offset: 0x19C6F1 VA: 0x19C5F0
	// RVA: 0x20BC280 Offset: 0x20BC381 VA: 0x20BC280
	public void set_IKSolverLookAt(IKSolverLookAt value) { }

	// RVA: 0x20BC290 Offset: 0x20BC391 VA: 0x20BC290
	public void Setup(HumanModel humanModel) { }

	// RVA: 0x20BC450 Offset: 0x20BC551 VA: 0x20BC450
	private void LateUpdate() { }

	// RVA: 0x20BC460 Offset: 0x20BC561 VA: 0x20BC460
	private void OnUpdate() { }

	// RVA: 0x20BCA40 Offset: 0x20BCB41 VA: 0x20BCA40
	public void SetTarget(Transform target, Vector3 offset) { }

	// RVA: 0x20BCA90 Offset: 0x20BCB91 VA: 0x20BCA90
	public void SetTarget(Transform target) { }

	// RVA: 0x20BCB40 Offset: 0x20BCC41 VA: 0x20BCB40
	public void SetWeight(float weight) { }

	// RVA: 0x20BCB50 Offset: 0x20BCC51 VA: 0x20BCB50
	public void SetSpeed(float speed) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C600 Offset: 0x19C701 VA: 0x19C600
	// RVA: 0x20BCB60 Offset: 0x20BCC61 VA: 0x20BCB60
	public bool get_IsDeltaTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C610 Offset: 0x19C711 VA: 0x19C610
	// RVA: 0x20BCB70 Offset: 0x20BCC71 VA: 0x20BCB70
	public void set_IsDeltaTime(bool value) { }

	// RVA: 0x20BCA20 Offset: 0x20BCB21 VA: 0x20BCA20
	private float get_GetdeltaTime() { }

	// RVA: 0x20BCB80 Offset: 0x20BCC81 VA: 0x20BCB80
	public void .ctor() { }
}

