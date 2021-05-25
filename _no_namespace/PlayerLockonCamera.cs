public class PlayerLockonCamera : SingletonMonoBehaviour<PlayerLockonCamera>, IPlayerCamera // TypeDefIndex: 6501
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15CF60 Offset: 0x15D061 VA: 0x15CF60
	private float <DistanceOffset>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x15CF70 Offset: 0x15D071 VA: 0x15CF70
	private CinemachineVirtualCamera m_VirtualCamera; // 0x20
	[SerializeField] // RVA: 0x15CF80 Offset: 0x15D081 VA: 0x15CF80
	private CinemachineFramingTransposer m_CinemachineFramingTransposer; // 0x28
	private Transform LookAtTransform; // 0x30
	public float DefaultDistance; // 0x38
	public float m_FollowDuration; // 0x3C
	public float m_LookPosAdjustmentRange; // 0x40
	public float AngleXMin; // 0x44
	public float AngleXMax; // 0x48
	public float AngleXMin_DN18_01; // 0x4C
	public float AngleXMax_DN18_01; // 0x50

	// Properties
	public float DistanceOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B410 Offset: 0x19B511 VA: 0x19B410
	// RVA: 0x21FFE60 Offset: 0x21FFF61 VA: 0x21FFE60 Slot: 9
	public float get_DistanceOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B420 Offset: 0x19B521 VA: 0x19B420
	// RVA: 0x21FFE70 Offset: 0x21FFF71 VA: 0x21FFE70 Slot: 10
	public void set_DistanceOffset(float value) { }

	// RVA: 0x21FFE80 Offset: 0x21FFF81 VA: 0x21FFE80
	private void Start() { }

	// RVA: 0x21FFFA0 Offset: 0x22000A1 VA: 0x21FFFA0
	private void Update() { }

	// RVA: 0x22001D0 Offset: 0x22002D1 VA: 0x22001D0 Slot: 5
	public void PreUpdate() { }

	// RVA: 0x22001E0 Offset: 0x22002E1 VA: 0x22001E0 Slot: 6
	public void FrameUpdate() { }

	// RVA: 0x22001F0 Offset: 0x22002F1 VA: 0x22001F0 Slot: 7
	public void TimeStepUpdate() { }

	// RVA: 0x2200750 Offset: 0x2200851 VA: 0x2200750 Slot: 8
	public void CameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: 0x2200890 Offset: 0x2200991 VA: 0x2200890
	public void .ctor() { }
}

