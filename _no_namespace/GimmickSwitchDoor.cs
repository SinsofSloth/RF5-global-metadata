public class GimmickSwitchDoor : GimmickBase // TypeDefIndex: 7590
{
	// Fields
	[SerializeField] // RVA: 0x167A70 Offset: 0x167B71 VA: 0x167A70
	public OnChangeStateOnDoor OnChangeStateOnDoor; // 0x20
	[SerializeField] // RVA: 0x167A80 Offset: 0x167B81 VA: 0x167A80
	[HeaderAttribute] // RVA: 0x167A80 Offset: 0x167B81 VA: 0x167A80
	private bool CameraViewEnable; // 0x28
	[SerializeField] // RVA: 0x167AD0 Offset: 0x167BD1 VA: 0x167AD0
	[RangeAttribute] // RVA: 0x167AD0 Offset: 0x167BD1 VA: 0x167AD0
	[HeaderAttribute] // RVA: 0x167AD0 Offset: 0x167BD1 VA: 0x167AD0
	private float CameraViewTime; // 0x2C
	[SerializeField] // RVA: 0x167B40 Offset: 0x167C41 VA: 0x167B40
	[RangeAttribute] // RVA: 0x167B40 Offset: 0x167C41 VA: 0x167B40
	[HeaderAttribute] // RVA: 0x167B40 Offset: 0x167C41 VA: 0x167B40
	private float CameraOffsetZ; // 0x30
	[SerializeField] // RVA: 0x167BB0 Offset: 0x167CB1 VA: 0x167BB0
	[RangeAttribute] // RVA: 0x167BB0 Offset: 0x167CB1 VA: 0x167BB0
	[HeaderAttribute] // RVA: 0x167BB0 Offset: 0x167CB1 VA: 0x167BB0
	private float CameraOffsetY; // 0x34
	[SerializeField] // RVA: 0x167C20 Offset: 0x167D21 VA: 0x167C20
	[RangeAttribute] // RVA: 0x167C20 Offset: 0x167D21 VA: 0x167C20
	[HeaderAttribute] // RVA: 0x167C20 Offset: 0x167D21 VA: 0x167C20
	private float CameraLookY; // 0x38
	public static GimmickLayoutID gimmickID; // 0x0
	private GimmickSwitchDoor.DoorCameraState doorCameraState; // 0x3C
	private float EventTime; // 0x40

	// Properties
	public bool IsEvent { get; }

	// Methods

	// RVA: 0x1EA75A0 Offset: 0x1EA76A1 VA: 0x1EA75A0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA75B0 Offset: 0x1EA76B1 VA: 0x1EA75B0 Slot: 9
	public override void Init() { }

	// RVA: 0x1EA7630 Offset: 0x1EA7731 VA: 0x1EA7630 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1EA77C0 Offset: 0x1EA78C1 VA: 0x1EA77C0
	private void Update() { }

	// RVA: 0x1EA78E0 Offset: 0x1EA79E1 VA: 0x1EA78E0
	public bool get_IsEvent() { }

	// RVA: 0x1EA76C0 Offset: 0x1EA77C1 VA: 0x1EA76C0
	private void DoorCameraStart(GimmickLayoutID gid) { }

	// RVA: 0x1EA78F0 Offset: 0x1EA79F1 VA: 0x1EA78F0
	private void DoorCameraSet() { }

	// RVA: 0x1EA7B40 Offset: 0x1EA7C41 VA: 0x1EA7B40
	private void DoorCameraEnd() { }

	// RVA: 0x1EA7850 Offset: 0x1EA7951 VA: 0x1EA7850
	private void DoorCameraUpdate() { }

	// RVA: 0x1EA7C40 Offset: 0x1EA7D41 VA: 0x1EA7C40
	public void .ctor() { }

	// RVA: 0x1EA7CE0 Offset: 0x1EA7DE1 VA: 0x1EA7CE0
	private static void .cctor() { }
}

