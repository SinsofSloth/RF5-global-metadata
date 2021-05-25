[DocumentationSortingAttribute] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
[AddComponentMenu] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
[SaveDuringPlayAttribute] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
[ExecuteAlways] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
[DisallowMultipleComponent] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
[HelpURLAttribute] // RVA: 0x12E770 Offset: 0x12E871 VA: 0x12E770
public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 4773
{
	// Fields
	[TooltipAttribute] // RVA: 0x131A00 Offset: 0x131B01 VA: 0x131A00
	public CinemachineTargetGroup.PositionMode m_PositionMode; // 0x18
	[TooltipAttribute] // RVA: 0x131A40 Offset: 0x131B41 VA: 0x131A40
	public CinemachineTargetGroup.RotationMode m_RotationMode; // 0x1C
	[TooltipAttribute] // RVA: 0x131A80 Offset: 0x131B81 VA: 0x131A80
	public CinemachineTargetGroup.UpdateMethod m_UpdateMethod; // 0x20
	[NoSaveDuringPlayAttribute] // RVA: 0x131AC0 Offset: 0x131BC1 VA: 0x131AC0
	[TooltipAttribute] // RVA: 0x131AC0 Offset: 0x131BC1 VA: 0x131AC0
	public CinemachineTargetGroup.Target[] m_Targets; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x131B10 Offset: 0x131C11 VA: 0x131B10
	private Bounds <BoundingBox>k__BackingField; // 0x30
	private float mMaxWeight; // 0x48
	private Vector3 mAveragePos; // 0x4C

	// Properties
	public Transform Transform { get; }
	public Bounds BoundingBox { get; set; }
	public BoundingSphere Sphere { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1739910 Offset: 0x1739A11 VA: 0x1739910 Slot: 4
	public Transform get_Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C40 Offset: 0x136D41 VA: 0x136C40
	// RVA: 0x1739920 Offset: 0x1739A21 VA: 0x1739920 Slot: 5
	public Bounds get_BoundingBox() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C50 Offset: 0x136D51 VA: 0x136C50
	// RVA: 0x1739940 Offset: 0x1739A41 VA: 0x1739940
	private void set_BoundingBox(Bounds value) { }

	// RVA: 0x1739960 Offset: 0x1739A61 VA: 0x1739960 Slot: 6
	public BoundingSphere get_Sphere() { }

	// RVA: 0x1739AB0 Offset: 0x1739BB1 VA: 0x1739AB0 Slot: 7
	public bool get_IsEmpty() { }

	// RVA: 0x1739BC0 Offset: 0x1739CC1 VA: 0x1739BC0
	public void AddMember(Transform t, float weight, float radius) { }

	// RVA: 0x1739D00 Offset: 0x1739E01 VA: 0x1739D00
	public void RemoveMember(Transform t) { }

	// RVA: 0x1739DF0 Offset: 0x1739EF1 VA: 0x1739DF0
	public int FindMember(Transform t) { }

	// RVA: 0x1739EF0 Offset: 0x1739FF1 VA: 0x1739EF0
	public BoundingSphere GetWeightedBoundsForMember(int index) { }

	// RVA: 0x173A120 Offset: 0x173A221 VA: 0x173A120 Slot: 8
	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

	// RVA: 0x1739F60 Offset: 0x173A061 VA: 0x1739F60
	private static BoundingSphere WeightedMemberBounds(CinemachineTargetGroup.Target t, Vector3 avgPos, float maxWeight) { }

	// RVA: 0x173A330 Offset: 0x173A431 VA: 0x173A330
	public void DoUpdate() { }

	// RVA: 0x173A440 Offset: 0x173A541 VA: 0x173A440
	private Vector3 CalculateAveragePosition(out float maxWeight) { }

	// RVA: 0x173A980 Offset: 0x173AA81 VA: 0x173A980
	private Quaternion CalculateAverageOrientation() { }

	// RVA: 0x173A730 Offset: 0x173A831 VA: 0x173A730
	private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight) { }

	// RVA: 0x173AC40 Offset: 0x173AD41 VA: 0x173AC40
	private void OnValidate() { }

	// RVA: 0x173AD60 Offset: 0x173AE61 VA: 0x173AD60
	private void FixedUpdate() { }

	// RVA: 0x173AD80 Offset: 0x173AE81 VA: 0x173AD80
	private void Update() { }

	// RVA: 0x173ADC0 Offset: 0x173AEC1 VA: 0x173ADC0
	private void LateUpdate() { }

	// RVA: 0x173ADE0 Offset: 0x173AEE1 VA: 0x173ADE0 Slot: 9
	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	// RVA: 0x173B310 Offset: 0x173B411 VA: 0x173B310
	public void .ctor() { }
}

