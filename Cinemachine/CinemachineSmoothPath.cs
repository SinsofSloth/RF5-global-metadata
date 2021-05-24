[DocumentationSortingAttribute] // RVA: 0x12E570 Offset: 0x12E671 VA: 0x12E570
[AddComponentMenu] // RVA: 0x12E570 Offset: 0x12E671 VA: 0x12E570
[SaveDuringPlayAttribute] // RVA: 0x12E570 Offset: 0x12E671 VA: 0x12E570
[DisallowMultipleComponent] // RVA: 0x12E570 Offset: 0x12E671 VA: 0x12E570
[HelpURLAttribute] // RVA: 0x12E570 Offset: 0x12E671 VA: 0x12E570
public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 4763
{
	// Fields
	[TooltipAttribute] // RVA: 0x131350 Offset: 0x131451 VA: 0x131350
	public bool m_Looped; // 0x48
	[TooltipAttribute] // RVA: 0x131390 Offset: 0x131491 VA: 0x131390
	public CinemachineSmoothPath.Waypoint[] m_Waypoints; // 0x50
	private CinemachineSmoothPath.Waypoint[] m_ControlPoints1; // 0x58
	private CinemachineSmoothPath.Waypoint[] m_ControlPoints2; // 0x60
	private bool m_IsLoopedCache; // 0x68

	// Properties
	public override float MinPos { get; }
	public override float MaxPos { get; }
	public override bool Looped { get; }
	public override int DistanceCacheSampleStepsPerSegment { get; }

	// Methods

	// RVA: 0x1734C10 Offset: 0x1734D11 VA: 0x1734C10 Slot: 4
	public override float get_MinPos() { }

	// RVA: 0x1734C20 Offset: 0x1734D21 VA: 0x1734C20 Slot: 5
	public override float get_MaxPos() { }

	// RVA: 0x1734C60 Offset: 0x1734D61 VA: 0x1734C60 Slot: 6
	public override bool get_Looped() { }

	// RVA: 0x1734C70 Offset: 0x1734D71 VA: 0x1734C70 Slot: 13
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0x1734C80 Offset: 0x1734D81 VA: 0x1734C80
	private void OnValidate() { }

	// RVA: 0x1734C90 Offset: 0x1734D91 VA: 0x1734C90
	private void Reset() { }

	// RVA: 0x1734E00 Offset: 0x1734F01 VA: 0x1734E00 Slot: 14
	public override void InvalidateDistanceCache() { }

	// RVA: 0x1734E60 Offset: 0x1734F61 VA: 0x1734E60
	private void UpdateControlPoints() { }

	// RVA: 0x1735330 Offset: 0x1735431 VA: 0x1735330
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0x1735470 Offset: 0x1735571 VA: 0x1735470 Slot: 8
	public override Vector3 EvaluatePosition(float pos) { }

	// RVA: 0x1735640 Offset: 0x1735741 VA: 0x1735640 Slot: 9
	public override Vector3 EvaluateTangent(float pos) { }

	// RVA: 0x17358A0 Offset: 0x17359A1 VA: 0x17358A0 Slot: 10
	public override Quaternion EvaluateOrientation(float pos) { }

	// RVA: 0x1735BF0 Offset: 0x1735CF1 VA: 0x1735BF0
	private Quaternion RollAroundForward(float angle) { }

	// RVA: 0x1735CB0 Offset: 0x1735DB1 VA: 0x1735CB0
	public void .ctor() { }
}

