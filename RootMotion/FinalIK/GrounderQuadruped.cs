[HelpURLAttribute] // RVA: 0x148510 Offset: 0x148611 VA: 0x148510
[AddComponentMenu] // RVA: 0x148510 Offset: 0x148611 VA: 0x148510
public class GrounderQuadruped : Grounder // TypeDefIndex: 9429
{
	// Fields
	[TooltipAttribute] // RVA: 0x179560 Offset: 0x179661 VA: 0x179560
	public Grounding forelegSolver; // 0x40
	[TooltipAttribute] // RVA: 0x1795A0 Offset: 0x1796A1 VA: 0x1795A0
	[RangeAttribute] // RVA: 0x1795A0 Offset: 0x1796A1 VA: 0x1795A0
	public float rootRotationWeight; // 0x48
	[TooltipAttribute] // RVA: 0x179600 Offset: 0x179701 VA: 0x179600
	[RangeAttribute] // RVA: 0x179600 Offset: 0x179701 VA: 0x179600
	public float minRootRotation; // 0x4C
	[TooltipAttribute] // RVA: 0x179660 Offset: 0x179761 VA: 0x179660
	[RangeAttribute] // RVA: 0x179660 Offset: 0x179761 VA: 0x179660
	public float maxRootRotation; // 0x50
	[TooltipAttribute] // RVA: 0x1796C0 Offset: 0x1797C1 VA: 0x1796C0
	public float rootRotationSpeed; // 0x54
	[TooltipAttribute] // RVA: 0x179700 Offset: 0x179801 VA: 0x179700
	public float maxLegOffset; // 0x58
	[TooltipAttribute] // RVA: 0x179740 Offset: 0x179841 VA: 0x179740
	public float maxForeLegOffset; // 0x5C
	[TooltipAttribute] // RVA: 0x179780 Offset: 0x179881 VA: 0x179780
	[RangeAttribute] // RVA: 0x179780 Offset: 0x179881 VA: 0x179780
	public float maintainHeadRotationWeight; // 0x60
	[TooltipAttribute] // RVA: 0x1797E0 Offset: 0x1798E1 VA: 0x1797E0
	public Transform characterRoot; // 0x68
	[TooltipAttribute] // RVA: 0x179820 Offset: 0x179921 VA: 0x179820
	public Transform pelvis; // 0x70
	[TooltipAttribute] // RVA: 0x179860 Offset: 0x179961 VA: 0x179860
	public Transform lastSpineBone; // 0x78
	[TooltipAttribute] // RVA: 0x1798A0 Offset: 0x1799A1 VA: 0x1798A0
	public Transform head; // 0x80
	public IK[] legs; // 0x88
	public IK[] forelegs; // 0x90
	[HideInInspector] // RVA: 0x1798E0 Offset: 0x1799E1 VA: 0x1798E0
	public Vector3 gravity; // 0x98
	private GrounderQuadruped.Foot[] feet; // 0xA8
	private Vector3 animatedPelvisLocalPosition; // 0xB0
	private Quaternion animatedPelvisLocalRotation; // 0xBC
	private Quaternion animatedHeadLocalRotation; // 0xCC
	private Vector3 solvedPelvisLocalPosition; // 0xDC
	private Quaternion solvedPelvisLocalRotation; // 0xE8
	private Quaternion solvedHeadLocalRotation; // 0xF8
	private int solvedFeet; // 0x108
	private bool solved; // 0x10C
	private float angle; // 0x110
	private Transform forefeetRoot; // 0x118
	private Quaternion headRotation; // 0x120
	private float lastWeight; // 0x130
	private Rigidbody characterRootRigidbody; // 0x138

	// Methods

	[ContextMenu] // RVA: 0x1AA590 Offset: 0x1AA691 VA: 0x1AA590
	// RVA: 0x2B34980 Offset: 0x2B34A81 VA: 0x2B34980 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA5D0 Offset: 0x1AA6D1 VA: 0x1AA5D0
	// RVA: 0x2B349D0 Offset: 0x2B34AD1 VA: 0x2B349D0 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2B34A20 Offset: 0x2B34B21 VA: 0x2B34A20 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2B34A60 Offset: 0x2B34B61 VA: 0x2B34A60
	private bool IsReadyToInitiate() { }

	// RVA: 0x2B34B90 Offset: 0x2B34C91 VA: 0x2B34B90
	private bool IsReadyToInitiateLegs(IK[] ikComponents) { }

	// RVA: 0x2B34D50 Offset: 0x2B34E51 VA: 0x2B34D50
	private void OnDisable() { }

	// RVA: 0x2B34DC0 Offset: 0x2B34EC1 VA: 0x2B34DC0
	private void Update() { }

	// RVA: 0x2B34E80 Offset: 0x2B34F81 VA: 0x2B34E80
	private void Initiate() { }

	// RVA: 0x2B351B0 Offset: 0x2B352B1 VA: 0x2B351B0
	private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset) { }

	// RVA: 0x2B355E0 Offset: 0x2B356E1 VA: 0x2B355E0
	private void LateUpdate() { }

	// RVA: 0x2B35730 Offset: 0x2B35831 VA: 0x2B35730
	private void RootRotation() { }

	// RVA: 0x2B35BE0 Offset: 0x2B35CE1 VA: 0x2B35BE0
	private void OnSolverUpdate() { }

	// RVA: 0x2B36450 Offset: 0x2B36551 VA: 0x2B36450
	private void UpdateForefeetRoot() { }

	// RVA: 0x2B36710 Offset: 0x2B36811 VA: 0x2B36710
	private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset) { }

	// RVA: 0x2B36870 Offset: 0x2B36971 VA: 0x2B36870
	private void OnPostSolverUpdate() { }

	// RVA: 0x2B36B50 Offset: 0x2B36C51 VA: 0x2B36B50
	private void OnDestroy() { }

	// RVA: 0x2B36B90 Offset: 0x2B36C91 VA: 0x2B36B90
	private void DestroyLegs(IK[] ikComponents) { }

	// RVA: 0x2B36D80 Offset: 0x2B36E81 VA: 0x2B36D80
	public void .ctor() { }
}

