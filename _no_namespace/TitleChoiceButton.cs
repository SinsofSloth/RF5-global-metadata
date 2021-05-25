public class TitleChoiceButton : ChoiceButton // TypeDefIndex: 8882
{
	// Fields
	[SerializeField] // RVA: 0x174800 Offset: 0x174901 VA: 0x174800
	private Image buttonImage; // 0x68
	private readonly float ANIM_TIME; // 0x70
	private readonly Vector2 START_SCALE; // 0x74
	private readonly Vector2 GOAL_SCALE; // 0x7C
	[SerializeField] // RVA: 0x174810 Offset: 0x174911 VA: 0x174810
	private TitleCanvasControl titleControl; // 0x88

	// Methods

	// RVA: 0x1D27E10 Offset: 0x1D27F11 VA: 0x1D27E10 Slot: 4
	public override void DoButton() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8CA0 Offset: 0x1A8DA1 VA: 0x1A8CA0
	// RVA: 0x1D27EE0 Offset: 0x1D27FE1 VA: 0x1D27EE0
	private IEnumerator Scaling() { }

	// RVA: 0x1D27F90 Offset: 0x1D28091 VA: 0x1D27F90
	public void .ctor() { }
}

