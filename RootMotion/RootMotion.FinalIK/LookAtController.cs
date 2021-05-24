public class LookAtController : MonoBehaviour // TypeDefIndex: 9565
{
	// Fields
	public LookAtIK ik; // 0x18
	[HeaderAttribute] // RVA: 0x17C9C0 Offset: 0x17CAC1 VA: 0x17C9C0
	[TooltipAttribute] // RVA: 0x17C9C0 Offset: 0x17CAC1 VA: 0x17C9C0
	public Transform target; // 0x20
	[RangeAttribute] // RVA: 0x17CA20 Offset: 0x17CB21 VA: 0x17CA20
	public float weight; // 0x28
	public Vector3 offset; // 0x2C
	[TooltipAttribute] // RVA: 0x17CA40 Offset: 0x17CB41 VA: 0x17CA40
	public float targetSwitchSmoothTime; // 0x38
	[TooltipAttribute] // RVA: 0x17CA80 Offset: 0x17CB81 VA: 0x17CA80
	public float weightSmoothTime; // 0x3C
	[HeaderAttribute] // RVA: 0x17CAC0 Offset: 0x17CBC1 VA: 0x17CAC0
	[TooltipAttribute] // RVA: 0x17CAC0 Offset: 0x17CBC1 VA: 0x17CAC0
	public bool smoothTurnTowardsTarget; // 0x40
	[TooltipAttribute] // RVA: 0x17CB20 Offset: 0x17CC21 VA: 0x17CB20
	public float maxRadiansDelta; // 0x44
	[TooltipAttribute] // RVA: 0x17CB60 Offset: 0x17CC61 VA: 0x17CB60
	public float maxMagnitudeDelta; // 0x48
	[TooltipAttribute] // RVA: 0x17CBA0 Offset: 0x17CCA1 VA: 0x17CBA0
	public float slerpSpeed; // 0x4C
	[TooltipAttribute] // RVA: 0x17CBE0 Offset: 0x17CCE1 VA: 0x17CBE0
	public Vector3 pivotOffsetFromRoot; // 0x50
	[TooltipAttribute] // RVA: 0x17CC20 Offset: 0x17CD21 VA: 0x17CC20
	public float minDistance; // 0x5C
	[HeaderAttribute] // RVA: 0x17CC60 Offset: 0x17CD61 VA: 0x17CC60
	[TooltipAttribute] // RVA: 0x17CC60 Offset: 0x17CD61 VA: 0x17CC60
	[RangeAttribute] // RVA: 0x17CC60 Offset: 0x17CD61 VA: 0x17CC60
	public float maxRootAngle; // 0x60
	private Transform lastTarget; // 0x68
	private float switchWeight; // 0x70
	private float switchWeightV; // 0x74
	private float weightV; // 0x78
	private Vector3 lastPosition; // 0x7C
	private Vector3 dir; // 0x88
	private bool lastSmoothTowardsTarget; // 0x94

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x2919F50 Offset: 0x291A051 VA: 0x2919F50
	private void Start() { }

	// RVA: 0x291A190 Offset: 0x291A291 VA: 0x291A190
	private void LateUpdate() { }

	// RVA: 0x291A040 Offset: 0x291A141 VA: 0x291A040
	private Vector3 get_pivot() { }

	// RVA: 0x291A860 Offset: 0x291A961 VA: 0x291A860
	private void ApplyMinDistance() { }

	// RVA: 0x291AA00 Offset: 0x291AB01 VA: 0x291AA00
	private void RootRotation() { }

	// RVA: 0x291AD20 Offset: 0x291AE21 VA: 0x291AD20
	public void .ctor() { }
}

