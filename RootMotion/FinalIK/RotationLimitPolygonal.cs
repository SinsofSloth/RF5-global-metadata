[HelpURLAttribute] // RVA: 0x148DA0 Offset: 0x148EA1 VA: 0x148DA0
[AddComponentMenu] // RVA: 0x148DA0 Offset: 0x148EA1 VA: 0x148DA0
public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 9537
{
	// Fields
	[RangeAttribute] // RVA: 0x17C0A0 Offset: 0x17C1A1 VA: 0x17C0A0
	public float twistLimit; // 0x38
	[RangeAttribute] // RVA: 0x17C0C0 Offset: 0x17C1C1 VA: 0x17C0C0
	public int smoothIterations; // 0x3C
	[SerializeField] // RVA: 0x17C0E0 Offset: 0x17C1E1 VA: 0x17C0E0
	[HideInInspector] // RVA: 0x17C0E0 Offset: 0x17C1E1 VA: 0x17C0E0
	public RotationLimitPolygonal.LimitPoint[] points; // 0x40
	[SerializeField] // RVA: 0x17C120 Offset: 0x17C221 VA: 0x17C120
	[HideInInspector] // RVA: 0x17C120 Offset: 0x17C221 VA: 0x17C120
	public Vector3[] P; // 0x48
	[SerializeField] // RVA: 0x17C160 Offset: 0x17C261 VA: 0x17C160
	[HideInInspector] // RVA: 0x17C160 Offset: 0x17C261 VA: 0x17C160
	public RotationLimitPolygonal.ReachCone[] reachCones; // 0x50

	// Methods

	[ContextMenu] // RVA: 0x1ABFA0 Offset: 0x1AC0A1 VA: 0x1ABFA0
	// RVA: 0x29217B0 Offset: 0x29218B1 VA: 0x29217B0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1ABFE0 Offset: 0x1AC0E1 VA: 0x1ABFE0
	// RVA: 0x2921800 Offset: 0x2921901 VA: 0x2921800
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AC020 Offset: 0x1AC121 VA: 0x1AC020
	// RVA: 0x2921850 Offset: 0x2921951 VA: 0x2921850
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AC060 Offset: 0x1AC161 VA: 0x1AC060
	// RVA: 0x29218A0 Offset: 0x29219A1 VA: 0x29218A0
	private void ASThread() { }

	// RVA: 0x29218F0 Offset: 0x29219F1 VA: 0x29218F0
	public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points) { }

	// RVA: 0x2921E40 Offset: 0x2921F41 VA: 0x2921E40 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x2921F40 Offset: 0x2922041 VA: 0x2921F40
	private void Start() { }

	// RVA: 0x2922570 Offset: 0x2922671 VA: 0x2922570
	public void ResetToDefault() { }

	// RVA: 0x29219A0 Offset: 0x2921AA1 VA: 0x29219A0
	public void BuildReachCones() { }

	// RVA: 0x2922A60 Offset: 0x2922B61 VA: 0x2922A60
	private Vector3[] SmoothPoints() { }

	// RVA: 0x2923350 Offset: 0x2923451 VA: 0x2923350
	private float GetScalar(int k) { }

	// RVA: 0x29233A0 Offset: 0x29234A1 VA: 0x29233A0
	private Vector3 PointToTangentPlane(Vector3 p, float r) { }

	// RVA: 0x29234F0 Offset: 0x29235F1 VA: 0x29234F0
	private Vector3 TangentPointToSphere(Vector3 q, float r) { }

	// RVA: 0x2922230 Offset: 0x2922331 VA: 0x2922230
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x2923680 Offset: 0x2923781 VA: 0x2923680
	private int GetReachCone(Vector3 L) { }

	// RVA: 0x2923850 Offset: 0x2923951 VA: 0x2923850
	public void .ctor() { }
}

