public class ThrowController : MonoBehaviour // TypeDefIndex: 6674
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15EA80 Offset: 0x15EB81 VA: 0x15EA80
	private HoldableInterface <HoldObj>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15EA90 Offset: 0x15EB91 VA: 0x15EA90
	private Collider <Collider>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x15EAA0 Offset: 0x15EBA1 VA: 0x15EAA0
	public float TriggerRadius; // 0x28
	[SerializeField] // RVA: 0x15EAB0 Offset: 0x15EBB1 VA: 0x15EAB0
	public float PhysicsRadius; // 0x2C
	public const int BoundNumMax = -1;
	public CharacterBase Target; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15EAC0 Offset: 0x15EBC1 VA: 0x15EAC0
	private Vector3 <Velocity>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15EAD0 Offset: 0x15EBD1 VA: 0x15EAD0
	private int <BoundNum>k__BackingField; // 0x44
	private const float Gravity = 9.8;
	private const float BaseRange = 10;
	private const float UpRange = 50;
	[CompilerGeneratedAttribute] // RVA: 0x15EAE0 Offset: 0x15EBE1 VA: 0x15EAE0
	private Vector3 <PrevPos>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15EAF0 Offset: 0x15EBF1 VA: 0x15EAF0
	private Vector3 <TargetPos>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x15EB00 Offset: 0x15EC01 VA: 0x15EB00
	private Vector3 <LandPlanPoint>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x15EB10 Offset: 0x15EC11 VA: 0x15EB10
	private bool <IsThrow>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x15EB20 Offset: 0x15EC21 VA: 0x15EB20
	private HumanController <ThrowOwner>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x15EB30 Offset: 0x15EC31 VA: 0x15EB30
	private readonly HashSet<GameObject> <TriggerChecks>k__BackingField; // 0x78

	// Properties
	private HoldableInterface HoldObj { get; set; }
	private Collider Collider { get; set; }
	private float Range { get; }
	public Vector3 Velocity { get; set; }
	private int BoundNum { get; set; }
	private Vector3 PrevPos { get; set; }
	private Vector3 TargetPos { get; set; }
	private Vector3 LandPlanPoint { get; set; }
	private Vector3 Position { get; set; }
	public bool IsThrow { get; set; }
	public HumanController ThrowOwner { get; set; }
	private HashSet<GameObject> TriggerChecks { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C660 Offset: 0x19C761 VA: 0x19C660
	// RVA: 0x1D150F0 Offset: 0x1D151F1 VA: 0x1D150F0
	private HoldableInterface get_HoldObj() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C670 Offset: 0x19C771 VA: 0x19C670
	// RVA: 0x1D15100 Offset: 0x1D15201 VA: 0x1D15100
	private void set_HoldObj(HoldableInterface value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C680 Offset: 0x19C781 VA: 0x19C680
	// RVA: 0x1D15110 Offset: 0x1D15211 VA: 0x1D15110
	private Collider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C690 Offset: 0x19C791 VA: 0x19C690
	// RVA: 0x1D15120 Offset: 0x1D15221 VA: 0x1D15120
	private void set_Collider(Collider value) { }

	// RVA: 0x1D15130 Offset: 0x1D15231 VA: 0x1D15130
	private float get_Range() { }

	// RVA: 0x1D15160 Offset: 0x1D15261 VA: 0x1D15160
	private bool HasThrowRing() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6A0 Offset: 0x19C7A1 VA: 0x19C6A0
	// RVA: 0x1D151E0 Offset: 0x1D152E1 VA: 0x1D151E0
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6B0 Offset: 0x19C7B1 VA: 0x19C6B0
	// RVA: 0x1D151F0 Offset: 0x1D152F1 VA: 0x1D151F0
	private void set_Velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6C0 Offset: 0x19C7C1 VA: 0x19C6C0
	// RVA: 0x1D15200 Offset: 0x1D15301 VA: 0x1D15200
	private int get_BoundNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6D0 Offset: 0x19C7D1 VA: 0x19C6D0
	// RVA: 0x1D15210 Offset: 0x1D15311 VA: 0x1D15210
	private void set_BoundNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6E0 Offset: 0x19C7E1 VA: 0x19C6E0
	// RVA: 0x1D15220 Offset: 0x1D15321 VA: 0x1D15220
	private Vector3 get_PrevPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C6F0 Offset: 0x19C7F1 VA: 0x19C6F0
	// RVA: 0x1D15230 Offset: 0x1D15331 VA: 0x1D15230
	private void set_PrevPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C700 Offset: 0x19C801 VA: 0x19C700
	// RVA: 0x1D15240 Offset: 0x1D15341 VA: 0x1D15240
	private Vector3 get_TargetPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C710 Offset: 0x19C811 VA: 0x19C710
	// RVA: 0x1D15250 Offset: 0x1D15351 VA: 0x1D15250
	private void set_TargetPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C720 Offset: 0x19C821 VA: 0x19C720
	// RVA: 0x1D15260 Offset: 0x1D15361 VA: 0x1D15260
	private Vector3 get_LandPlanPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C730 Offset: 0x19C831 VA: 0x19C730
	// RVA: 0x1D15270 Offset: 0x1D15371 VA: 0x1D15270
	private void set_LandPlanPoint(Vector3 value) { }

	// RVA: 0x1D15280 Offset: 0x1D15381 VA: 0x1D15280
	private Vector3 get_Position() { }

	// RVA: 0x1D15350 Offset: 0x1D15451 VA: 0x1D15350
	private void set_Position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C740 Offset: 0x19C841 VA: 0x19C740
	// RVA: 0x1D15420 Offset: 0x1D15521 VA: 0x1D15420
	public bool get_IsThrow() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C750 Offset: 0x19C851 VA: 0x19C750
	// RVA: 0x1D15430 Offset: 0x1D15531 VA: 0x1D15430
	protected void set_IsThrow(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C760 Offset: 0x19C861 VA: 0x19C760
	// RVA: 0x1D15440 Offset: 0x1D15541 VA: 0x1D15440
	public HumanController get_ThrowOwner() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C770 Offset: 0x19C871 VA: 0x19C770
	// RVA: 0x1D15450 Offset: 0x1D15551 VA: 0x1D15450
	private void set_ThrowOwner(HumanController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C780 Offset: 0x19C881 VA: 0x19C780
	// RVA: 0x1D15460 Offset: 0x1D15561 VA: 0x1D15460
	private HashSet<GameObject> get_TriggerChecks() { }

	// RVA: 0x1D15470 Offset: 0x1D15571 VA: 0x1D15470
	private void Awake() { }

	// RVA: 0x1D15500 Offset: 0x1D15601 VA: 0x1D15500
	public void OnThrow(Vector3 position, HumanController human, CharacterBase target) { }

	// RVA: 0x1D15EE0 Offset: 0x1D15FE1 VA: 0x1D15EE0
	public void OnThrow(HumanController human) { }

	// RVA: 0x1D16010 Offset: 0x1D16111 VA: 0x1D16010
	private void UpdateThrow(float deltaTime) { }

	// RVA: 0x1D15DD0 Offset: 0x1D15ED1 VA: 0x1D15DD0
	private Vector3 GetDefaultTargetPosition(HumanController human) { }

	// RVA: 0x1D16770 Offset: 0x1D16871 VA: 0x1D16770
	private void FixedUpdate() { }

	// RVA: 0x1D167B0 Offset: 0x1D168B1 VA: 0x1D167B0
	public void .ctor() { }
}

