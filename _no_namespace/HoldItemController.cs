public class HoldItemController : MonoBehaviour // TypeDefIndex: 7659
{
	// Fields
	[SerializeField] // RVA: 0x168860 Offset: 0x168961 VA: 0x168860
	private HoldItemController.MoveParameter MoveParam; // 0x18
	private StateMachine<HoldItemController.HoldItemState> sm; // 0x20
	private int ItemAmount; // 0x28
	private float HaveOffsetX; // 0x2C
	private float HaveOffsetZ; // 0x30
	private float StateSeconds; // 0x34
	private float ExtendedRate; // 0x38
	private Vector3 PrevPosition; // 0x3C
	private float PrevRotation; // 0x48
	private List<HoldItemController.ItemModel> ModelList; // 0x50
	private HoldMotionType MotionType; // 0x58
	private float ObjectInterval; // 0x5C
	private static TransitionTables[] transitionTables; // 0x0
	private static int stateElementTableCount; // 0x8

	// Methods

	// RVA: 0x1E80000 Offset: 0x1E80101 VA: 0x1E80000
	private void Awake() { }

	// RVA: 0x1E803F0 Offset: 0x1E804F1 VA: 0x1E803F0
	public void SetModel(Transform modelsRoot) { }

	// RVA: 0x1E80820 Offset: 0x1E80921 VA: 0x1E80820
	public void SetAmount(int amount) { }

	// RVA: 0x1E80A40 Offset: 0x1E80B41 VA: 0x1E80A40
	public void OnHoldEnter(HoldMotionType holdMotionType) { }

	// RVA: 0x1E80AD0 Offset: 0x1E80BD1 VA: 0x1E80AD0
	public void OnHoldExit() { }

	// RVA: 0x1E80B60 Offset: 0x1E80C61 VA: 0x1E80B60
	private void None_Enter() { }

	// RVA: 0x1E80B90 Offset: 0x1E80C91 VA: 0x1E80B90
	private void Extend_Enter() { }

	// RVA: 0x1E80BC0 Offset: 0x1E80CC1 VA: 0x1E80BC0
	private void Extend_FixedUpdate() { }

	// RVA: 0x1E80CC0 Offset: 0x1E80DC1 VA: 0x1E80CC0
	private void Hold_Enter() { }

	// RVA: 0x1E80CF0 Offset: 0x1E80DF1 VA: 0x1E80CF0
	private void Hold_FixedUpdate() { }

	// RVA: 0x1E81290 Offset: 0x1E81391 VA: 0x1E81290
	private void Shrink_Enter() { }

	// RVA: 0x1E812E0 Offset: 0x1E813E1 VA: 0x1E812E0
	private void Shrink_FixedUpdate() { }

	// RVA: 0x1E80610 Offset: 0x1E80711 VA: 0x1E80610
	private void ResetMoveParam() { }

	// RVA: 0x1E80830 Offset: 0x1E80931 VA: 0x1E80830
	private void ResetModel(bool resetPosition = True) { }

	// RVA: 0x1E806C0 Offset: 0x1E807C1 VA: 0x1E806C0
	private void SetExtendRate(float rate) { }

	// RVA: 0x1E81230 Offset: 0x1E81331 VA: 0x1E81230
	private float AddOffset(float current, float add, float range) { }

	// RVA: 0x1E81260 Offset: 0x1E81361 VA: 0x1E81260
	private float ToStop(float current, float sub) { }

	// RVA: 0x1E813D0 Offset: 0x1E814D1 VA: 0x1E813D0
	public void .ctor() { }

	// RVA: 0x1E81530 Offset: 0x1E81631 VA: 0x1E81530
	private static void .cctor() { }
}

