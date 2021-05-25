[Serializable]
public class Grounding // TypeDefIndex: 9432
{
	// Fields
	[TooltipAttribute] // RVA: 0x179930 Offset: 0x179A31 VA: 0x179930
	public LayerMask layers; // 0x10
	[TooltipAttribute] // RVA: 0x179970 Offset: 0x179A71 VA: 0x179970
	public float maxStep; // 0x14
	[TooltipAttribute] // RVA: 0x1799B0 Offset: 0x179AB1 VA: 0x1799B0
	public float heightOffset; // 0x18
	[TooltipAttribute] // RVA: 0x1799F0 Offset: 0x179AF1 VA: 0x1799F0
	public float footSpeed; // 0x1C
	[TooltipAttribute] // RVA: 0x179A30 Offset: 0x179B31 VA: 0x179A30
	public float footRadius; // 0x20
	[TooltipAttribute] // RVA: 0x179A70 Offset: 0x179B71 VA: 0x179A70
	[HideInInspector] // RVA: 0x179A70 Offset: 0x179B71 VA: 0x179A70
	public float footCenterOffset; // 0x24
	[TooltipAttribute] // RVA: 0x179AC0 Offset: 0x179BC1 VA: 0x179AC0
	public float prediction; // 0x28
	[TooltipAttribute] // RVA: 0x179B00 Offset: 0x179C01 VA: 0x179B00
	[RangeAttribute] // RVA: 0x179B00 Offset: 0x179C01 VA: 0x179B00
	public float footRotationWeight; // 0x2C
	[TooltipAttribute] // RVA: 0x179B60 Offset: 0x179C61 VA: 0x179B60
	public float footRotationSpeed; // 0x30
	[TooltipAttribute] // RVA: 0x179BA0 Offset: 0x179CA1 VA: 0x179BA0
	[RangeAttribute] // RVA: 0x179BA0 Offset: 0x179CA1 VA: 0x179BA0
	public float maxFootRotationAngle; // 0x34
	[TooltipAttribute] // RVA: 0x179C00 Offset: 0x179D01 VA: 0x179C00
	public bool rotateSolver; // 0x38
	[TooltipAttribute] // RVA: 0x179C40 Offset: 0x179D41 VA: 0x179C40
	public float pelvisSpeed; // 0x3C
	[TooltipAttribute] // RVA: 0x179C80 Offset: 0x179D81 VA: 0x179C80
	[RangeAttribute] // RVA: 0x179C80 Offset: 0x179D81 VA: 0x179C80
	public float pelvisDamper; // 0x40
	[TooltipAttribute] // RVA: 0x179CE0 Offset: 0x179DE1 VA: 0x179CE0
	public float lowerPelvisWeight; // 0x44
	[TooltipAttribute] // RVA: 0x179D20 Offset: 0x179E21 VA: 0x179D20
	public float liftPelvisWeight; // 0x48
	[TooltipAttribute] // RVA: 0x179D60 Offset: 0x179E61 VA: 0x179D60
	public float rootSphereCastRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x179DA0 Offset: 0x179EA1 VA: 0x179DA0
	public bool overstepFallsDown; // 0x50
	[TooltipAttribute] // RVA: 0x179DE0 Offset: 0x179EE1 VA: 0x179DE0
	public Grounding.Quality quality; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x179E20 Offset: 0x179F21 VA: 0x179E20
	private Grounding.Leg[] <legs>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x179E30 Offset: 0x179F31 VA: 0x179E30
	private Grounding.Pelvis <pelvis>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x179E40 Offset: 0x179F41 VA: 0x179E40
	private bool <isGrounded>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x179E50 Offset: 0x179F51 VA: 0x179E50
	private Transform <root>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x179E60 Offset: 0x179F61 VA: 0x179E60
	private RaycastHit <rootHit>k__BackingField; // 0x78
	private bool initiated; // 0xA4

	// Properties
	public Grounding.Leg[] legs { get; set; }
	public Grounding.Pelvis pelvis { get; set; }
	public bool isGrounded { get; set; }
	public Transform root { get; set; }
	public RaycastHit rootHit { get; set; }
	public bool rootGrounded { get; }
	public Vector3 up { get; }
	private bool useRootRotation { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA6D0 Offset: 0x1AA7D1 VA: 0x1AA6D0
	// RVA: 0x2B37E10 Offset: 0x2B37F11 VA: 0x2B37E10
	public Grounding.Leg[] get_legs() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA6E0 Offset: 0x1AA7E1 VA: 0x1AA6E0
	// RVA: 0x2B37E20 Offset: 0x2B37F21 VA: 0x2B37E20
	private void set_legs(Grounding.Leg[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA6F0 Offset: 0x1AA7F1 VA: 0x1AA6F0
	// RVA: 0x2B37E30 Offset: 0x2B37F31 VA: 0x2B37E30
	public Grounding.Pelvis get_pelvis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA700 Offset: 0x1AA801 VA: 0x1AA700
	// RVA: 0x2B37E40 Offset: 0x2B37F41 VA: 0x2B37E40
	private void set_pelvis(Grounding.Pelvis value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA710 Offset: 0x1AA811 VA: 0x1AA710
	// RVA: 0x2B37E50 Offset: 0x2B37F51 VA: 0x2B37E50
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA720 Offset: 0x1AA821 VA: 0x1AA720
	// RVA: 0x2B37E60 Offset: 0x2B37F61 VA: 0x2B37E60
	private void set_isGrounded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA730 Offset: 0x1AA831 VA: 0x1AA730
	// RVA: 0x2B37E70 Offset: 0x2B37F71 VA: 0x2B37E70
	public Transform get_root() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA740 Offset: 0x1AA841 VA: 0x1AA740
	// RVA: 0x2B37E80 Offset: 0x2B37F81 VA: 0x2B37E80
	private void set_root(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA750 Offset: 0x1AA851 VA: 0x1AA750
	// RVA: 0x2B37E90 Offset: 0x2B37F91 VA: 0x2B37E90
	public RaycastHit get_rootHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA760 Offset: 0x1AA861 VA: 0x1AA760
	// RVA: 0x2B37EC0 Offset: 0x2B37FC1 VA: 0x2B37EC0
	private void set_rootHit(RaycastHit value) { }

	// RVA: 0x2B37EE0 Offset: 0x2B37FE1 VA: 0x2B37EE0
	public bool get_rootGrounded() { }

	// RVA: 0x2B37F40 Offset: 0x2B38041 VA: 0x2B37F40
	public RaycastHit GetRootHit(float maxDistanceMlp = 10) { }

	// RVA: 0x2B38340 Offset: 0x2B38441 VA: 0x2B38340
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2B30E80 Offset: 0x2B30F81 VA: 0x2B30E80
	public void Initiate(Transform root, Transform[] feet) { }

	// RVA: 0x2B31710 Offset: 0x2B31811 VA: 0x2B31710
	public void Update() { }

	// RVA: 0x2B33870 Offset: 0x2B33971 VA: 0x2B33870
	public Vector3 GetLegsPlaneNormal() { }

	// RVA: 0x2B30960 Offset: 0x2B30A61 VA: 0x2B30960
	public void Reset() { }

	// RVA: 0x2B38650 Offset: 0x2B38751 VA: 0x2B38650
	public void LogWarning(string message) { }

	// RVA: 0x2B31A60 Offset: 0x2B31B61 VA: 0x2B31A60
	public Vector3 get_up() { }

	// RVA: 0x2B39560 Offset: 0x2B39661 VA: 0x2B39560
	public float GetVerticalOffset(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2B396D0 Offset: 0x2B397D1 VA: 0x2B396D0
	public Vector3 Flatten(Vector3 v) { }

	// RVA: 0x2B39490 Offset: 0x2B39591 VA: 0x2B39490
	private bool get_useRootRotation() { }

	// RVA: 0x2B397E0 Offset: 0x2B398E1 VA: 0x2B397E0
	public Vector3 GetFootCenterOffset() { }

	// RVA: 0x2B30530 Offset: 0x2B30631 VA: 0x2B30530
	public void .ctor() { }
}

