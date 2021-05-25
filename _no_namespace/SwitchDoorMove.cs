[ExecuteInEditMode] // RVA: 0x146720 Offset: 0x146821 VA: 0x146720
public class SwitchDoorMove : MonoBehaviour // TypeDefIndex: 7609
{
	// Fields
	protected const string EffectRootName = "EffectRoot";
	[SerializeField] // RVA: 0x168330 Offset: 0x168431 VA: 0x168330
	private float DoorMoveDuration; // 0x18
	[SerializeField] // RVA: 0x168340 Offset: 0x168441 VA: 0x168340
	private Transform ActivePoint; // 0x20
	[SerializeField] // RVA: 0x168350 Offset: 0x168451 VA: 0x168350
	private Transform DeActivePoint; // 0x28
	[SerializeField] // RVA: 0x168360 Offset: 0x168461 VA: 0x168360
	public EffectID EffectId; // 0x30
	[SerializeField] // RVA: 0x168370 Offset: 0x168471 VA: 0x168370
	private Transform EffectRoot; // 0x38
	[SerializeField] // RVA: 0x168380 Offset: 0x168481 VA: 0x168380
	private float MoveDelay; // 0x40
	private bool MoveDirection; // 0x44
	private bool MoveDone; // 0x45
	private float ElapsedTime; // 0x48

	// Methods

	// RVA: 0x1C633C0 Offset: 0x1C634C1 VA: 0x1C633C0
	private void Awake() { }

	// RVA: 0x1C63590 Offset: 0x1C63691 VA: 0x1C63590
	private void SetElapsedTimeAndUpdatePoint() { }

	// RVA: 0x1C63710 Offset: 0x1C63811 VA: 0x1C63710
	private void Update() { }

	// RVA: 0x1C63770 Offset: 0x1C63871 VA: 0x1C63770
	private void OnChangeSwitchState(bool newState, bool immediate) { }

	// RVA: 0x1C638D0 Offset: 0x1C639D1 VA: 0x1C638D0
	public void .ctor() { }
}

