public class BitBase : MonoBehaviour // TypeDefIndex: 6568
{
	// Fields
	[HeaderAttribute] // RVA: 0x15D660 Offset: 0x15D761 VA: 0x15D660
	[SerializeField] // RVA: 0x15D660 Offset: 0x15D761 VA: 0x15D660
	protected Animator m_Animator; // 0x18
	[SerializeField] // RVA: 0x15D6B0 Offset: 0x15D7B1 VA: 0x15D6B0
	protected BitMotor m_Motor; // 0x20
	[SerializeField] // RVA: 0x15D6C0 Offset: 0x15D7C1 VA: 0x15D6C0
	protected BitBody m_Body; // 0x28
	[SerializeField] // RVA: 0x15D6D0 Offset: 0x15D7D1 VA: 0x15D6D0
	protected EffectID m_StartEffectID; // 0x30
	[SerializeField] // RVA: 0x15D6E0 Offset: 0x15D7E1 VA: 0x15D6E0
	protected EffectID m_DeadEffectID; // 0x34
	[SerializeField] // RVA: 0x15D6F0 Offset: 0x15D7F1 VA: 0x15D6F0
	protected BitParam m_BitParam; // 0x38
	[SerializeField] // RVA: 0x15D700 Offset: 0x15D801 VA: 0x15D700
	protected AnimationCurve m_SpeedRateCurve; // 0x40
	private Vector3 m_offset; // 0x48
	private Collider m_target; // 0x58
	private float m_elapsed; // 0x60
	private float m_cooltime; // 0x64
	private BitState m_bitState; // 0x68
	private BitMode m_bitMode; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x15D710 Offset: 0x15D811 VA: 0x15D710
	private Character <Owner>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x15D720 Offset: 0x15D821 VA: 0x15D720
	private int <Level>k__BackingField; // 0x78

	// Properties
	public Character Owner { get; set; }
	public int Level { get; set; }
	public Alliance Alliance { get; }
	public Collider Target { get; }
	public bool IsCooling { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B780 Offset: 0x19B881 VA: 0x19B780
	// RVA: 0x22E10C0 Offset: 0x22E11C1 VA: 0x22E10C0
	public Character get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B790 Offset: 0x19B891 VA: 0x19B790
	// RVA: 0x22E10D0 Offset: 0x22E11D1 VA: 0x22E10D0
	protected void set_Owner(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B7A0 Offset: 0x19B8A1 VA: 0x19B7A0
	// RVA: 0x22E10E0 Offset: 0x22E11E1 VA: 0x22E10E0
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B7B0 Offset: 0x19B8B1 VA: 0x19B7B0
	// RVA: 0x22E10F0 Offset: 0x22E11F1 VA: 0x22E10F0
	private void set_Level(int value) { }

	// RVA: 0x22E1100 Offset: 0x22E1201 VA: 0x22E1100
	public Alliance get_Alliance() { }

	// RVA: 0x22E11A0 Offset: 0x22E12A1 VA: 0x22E11A0
	public Collider get_Target() { }

	// RVA: 0x22E11B0 Offset: 0x22E12B1 VA: 0x22E11B0
	public bool get_IsCooling() { }

	// RVA: 0x22E11C0 Offset: 0x22E12C1 VA: 0x22E11C0
	protected void Awake() { }

	// RVA: 0x22E11D0 Offset: 0x22E12D1 VA: 0x22E11D0
	private void OnEnable() { }

	// RVA: 0x22E1290 Offset: 0x22E1391 VA: 0x22E1290
	public void Setup(Character owner, Vector3 offset, BitParam bitParam, int level, float initCoolTime, Vector3 position, Quaternion rotation) { }

	// RVA: 0x22E14A0 Offset: 0x22E15A1 VA: 0x22E14A0
	public void SetState(BitState bitState) { }

	// RVA: 0x22E14B0 Offset: 0x22E15B1 VA: 0x22E14B0
	public void SetMode(BitMode bitMode) { }

	// RVA: 0x22E14C0 Offset: 0x22E15C1 VA: 0x22E14C0
	public void OnUpdate() { }

	// RVA: 0x22E1750 Offset: 0x22E1851 VA: 0x22E1750
	public void OnFixedUpdate() { }

	// RVA: 0x22E1840 Offset: 0x22E1941 VA: 0x22E1840
	private void UpdateIdleState() { }

	// RVA: 0x22E1870 Offset: 0x22E1971 VA: 0x22E1870
	private void UpdateTrackingMode() { }

	// RVA: 0x22E1E40 Offset: 0x22E1F41 VA: 0x22E1E40
	private void UpdateHomingMode() { }

	// RVA: 0x22E2A10 Offset: 0x22E2B11 VA: 0x22E2A10
	private void TryShot() { }

	// RVA: 0x22E1860 Offset: 0x22E1961 VA: 0x22E1860
	private void UpdateShotState() { }

	// RVA: 0x22E1540 Offset: 0x22E1641 VA: 0x22E1540
	public void OnDead() { }

	// RVA: 0x22E34B0 Offset: 0x22E35B1 VA: 0x22E34B0
	public void Destroy() { }

	// RVA: 0x22E2B10 Offset: 0x22E2C11 VA: 0x22E2B10
	private bool DoSearchOwnerTarget(bool ignoreAngleAndRange) { }

	// RVA: 0x22E2600 Offset: 0x22E2701 VA: 0x22E2600
	private bool DoSearch() { }

	// RVA: 0x22E2E00 Offset: 0x22E2F01 VA: 0x22E2E00
	public void DoShot() { }

	// RVA: 0x22E35D0 Offset: 0x22E36D1 VA: 0x22E35D0
	public void TryDestroy() { }

	// RVA: 0x22E3670 Offset: 0x22E3771 VA: 0x22E3670
	public void .ctor() { }
}

