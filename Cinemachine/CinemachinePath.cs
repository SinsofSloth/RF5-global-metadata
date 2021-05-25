[DocumentationSortingAttribute] // RVA: 0x12E440 Offset: 0x12E541 VA: 0x12E440
[AddComponentMenu] // RVA: 0x12E440 Offset: 0x12E541 VA: 0x12E440
[SaveDuringPlayAttribute] // RVA: 0x12E440 Offset: 0x12E541 VA: 0x12E440
[DisallowMultipleComponent] // RVA: 0x12E440 Offset: 0x12E541 VA: 0x12E440
[HelpURLAttribute] // RVA: 0x12E440 Offset: 0x12E541 VA: 0x12E440
public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 4759
{
	// Fields
	[TooltipAttribute] // RVA: 0x1312D0 Offset: 0x1313D1 VA: 0x1312D0
	public bool m_Looped; // 0x48
	[TooltipAttribute] // RVA: 0x131310 Offset: 0x131411 VA: 0x131310
	public CinemachinePath.Waypoint[] m_Waypoints; // 0x50

	// Properties
	public override float MinPos { get; }
	public override float MaxPos { get; }
	public override bool Looped { get; }
	public override int DistanceCacheSampleStepsPerSegment { get; }

	// Methods

	// RVA: 0x17328B0 Offset: 0x17329B1 VA: 0x17328B0 Slot: 4
	public override float get_MinPos() { }

	// RVA: 0x17328C0 Offset: 0x17329C1 VA: 0x17328C0 Slot: 5
	public override float get_MaxPos() { }

	// RVA: 0x1732900 Offset: 0x1732A01 VA: 0x1732900 Slot: 6
	public override bool get_Looped() { }

	// RVA: 0x1732910 Offset: 0x1732A11 VA: 0x1732910
	private void Reset() { }

	// RVA: 0x1732B60 Offset: 0x1732C61 VA: 0x1732B60 Slot: 13
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0x1732B70 Offset: 0x1732C71 VA: 0x1732B70
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0x1732CF0 Offset: 0x1732DF1 VA: 0x1732CF0 Slot: 8
	public override Vector3 EvaluatePosition(float pos) { }

	// RVA: 0x1732F20 Offset: 0x1733021 VA: 0x1732F20 Slot: 9
	public override Vector3 EvaluateTangent(float pos) { }

	// RVA: 0x17331E0 Offset: 0x17332E1 VA: 0x17331E0 Slot: 10
	public override Quaternion EvaluateOrientation(float pos) { }

	// RVA: 0x17334D0 Offset: 0x17335D1 VA: 0x17334D0
	private void OnValidate() { }

	// RVA: 0x17334E0 Offset: 0x17335E1 VA: 0x17334E0
	public void .ctor() { }
}

