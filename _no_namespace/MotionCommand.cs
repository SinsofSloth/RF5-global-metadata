public class MotionCommand : ToolActionCommandBase // TypeDefIndex: 6279
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15BE80 Offset: 0x15BF81 VA: 0x15BE80
	private bool <IsMotionDone>k__BackingField; // 0x88
	private bool IsActionFrame; // 0x89

	// Properties
	public string StateName { get; }
	public bool AutoEnd { get; }
	public float SkipStart { get; }
	public float MotionSpeed { get; }
	public float FadeTime { get; }
	private bool IsMotionDone { get; set; }
	public override bool HasEndAction { get; }

	// Methods

	// RVA: 0x1CD9210 Offset: 0x1CD9311 VA: 0x1CD9210
	public string get_StateName() { }

	// RVA: 0x1CD9230 Offset: 0x1CD9331 VA: 0x1CD9230
	public bool get_AutoEnd() { }

	// RVA: 0x1CD9250 Offset: 0x1CD9351 VA: 0x1CD9250
	public float get_SkipStart() { }

	// RVA: 0x1CD9270 Offset: 0x1CD9371 VA: 0x1CD9270
	public float get_MotionSpeed() { }

	// RVA: 0x1CD9290 Offset: 0x1CD9391 VA: 0x1CD9290
	public float get_FadeTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8C0 Offset: 0x19A9C1 VA: 0x19A8C0
	// RVA: 0x1CD92B0 Offset: 0x1CD93B1 VA: 0x1CD92B0
	private bool get_IsMotionDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8D0 Offset: 0x19A9D1 VA: 0x19A8D0
	// RVA: 0x1CD92C0 Offset: 0x1CD93C1 VA: 0x1CD92C0
	private void set_IsMotionDone(bool value) { }

	// RVA: 0x1CD92D0 Offset: 0x1CD93D1 VA: 0x1CD92D0 Slot: 5
	public override bool get_HasEndAction() { }

	// RVA: 0x1CD92F0 Offset: 0x1CD93F1 VA: 0x1CD92F0 Slot: 6
	public override bool IsDoneCommand(float currentTime) { }

	// RVA: 0x1CD9320 Offset: 0x1CD9421 VA: 0x1CD9320
	public void .ctor(ActionCommandDataTable actionCommandData, AS_ToolController controller) { }

	// RVA: 0x1CD9380 Offset: 0x1CD9481 VA: 0x1CD9380 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1CD9440 Offset: 0x1CD9541 VA: 0x1CD9440 Slot: 9
	public override void UpdateAction(float elapsedTime) { }

	// RVA: 0x1CD9570 Offset: 0x1CD9671 VA: 0x1CD9570 Slot: 11
	public override void ActionFinal() { }
}

