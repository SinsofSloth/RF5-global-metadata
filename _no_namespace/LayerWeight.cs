public class LayerWeight : StateMachineBehaviour // TypeDefIndex: 6552
{
	// Fields
	[SerializeField] // RVA: 0x15D460 Offset: 0x15D561 VA: 0x15D460
	private string LayerName; // 0x18
	[SerializeField] // RVA: 0x15D470 Offset: 0x15D571 VA: 0x15D470
	private float EnterWeight; // 0x20
	[SerializeField] // RVA: 0x15D480 Offset: 0x15D581 VA: 0x15D480
	private float ExitWeight; // 0x24
	private int LayerIndex; // 0x28

	// Methods

	// RVA: 0x218AD60 Offset: 0x218AE61 VA: 0x218AD60 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x218ADB0 Offset: 0x218AEB1 VA: 0x218ADB0 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x218AE00 Offset: 0x218AF01 VA: 0x218AE00
	public void .ctor() { }
}

