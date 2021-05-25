public class PlayerFarmingCamera : SingletonMonoBehaviour<PlayerFarmingCamera>, IPlayerCamera // TypeDefIndex: 6500
{
	// Fields
	[SerializeField] // RVA: 0x15CF40 Offset: 0x15D041 VA: 0x15CF40
	private CinemachineVirtualCamera m_VirtualCamera; // 0x18
	private CinemachineFramingTransposer m_Transposer; // 0x20
	private Quaternion m_TargetRotation; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15CF50 Offset: 0x15D051 VA: 0x15CF50
	private float <DistanceOffset>k__BackingField; // 0x38

	// Properties
	public float DistanceOffset { get; set; }
	private Character CtrlCharacter { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B3F0 Offset: 0x19B4F1 VA: 0x19B3F0
	// RVA: 0x1FEC960 Offset: 0x1FECA61 VA: 0x1FEC960 Slot: 9
	public float get_DistanceOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B400 Offset: 0x19B501 VA: 0x19B400
	// RVA: 0x1FEC970 Offset: 0x1FECA71 VA: 0x1FEC970 Slot: 10
	public void set_DistanceOffset(float value) { }

	// RVA: 0x1FEC980 Offset: 0x1FECA81 VA: 0x1FEC980
	private Character get_CtrlCharacter() { }

	// RVA: 0x1FEC9E0 Offset: 0x1FECAE1 VA: 0x1FEC9E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1FECA90 Offset: 0x1FECB91 VA: 0x1FECA90
	protected void Start() { }

	// RVA: 0x1FECAA0 Offset: 0x1FECBA1 VA: 0x1FECAA0 Slot: 5
	public void PreUpdate() { }

	// RVA: 0x1FECAB0 Offset: 0x1FECBB1 VA: 0x1FECAB0 Slot: 6
	public void FrameUpdate() { }

	// RVA: 0x1FECAC0 Offset: 0x1FECBC1 VA: 0x1FECAC0 Slot: 7
	public void TimeStepUpdate() { }

	// RVA: 0x1FECAD0 Offset: 0x1FECBD1 VA: 0x1FECAD0 Slot: 8
	public void CameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: 0x1FECE60 Offset: 0x1FECF61 VA: 0x1FECE60
	public void .ctor() { }
}

