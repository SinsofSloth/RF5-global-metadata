public class ActionCode // TypeDefIndex: 6165
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15B9D0 Offset: 0x15BAD1 VA: 0x15B9D0
	private ActionScriptControllerBase <AS_Controller>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15B9E0 Offset: 0x15BAE1 VA: 0x15B9E0
	private string <ActionCodeName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15B9F0 Offset: 0x15BAF1 VA: 0x15B9F0
	private ActionCommandBase[] <Commands>k__BackingField; // 0x20
	[TupleElementNamesAttribute] // RVA: 0x15BA00 Offset: 0x15BB01 VA: 0x15BA00
	private ValueTuple<float, ActionCommandBase>[] DoActions; // 0x28
	[TupleElementNamesAttribute] // RVA: 0x15BAA0 Offset: 0x15BBA1 VA: 0x15BAA0
	private ValueTuple<float, ActionCommandBase>[] EndActions; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15BB40 Offset: 0x15BC41 VA: 0x15BB40
	private float <CurrentTime>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15BB50 Offset: 0x15BC51 VA: 0x15BB50
	private bool <IsActive>k__BackingField; // 0x3C
	private static ActionCode.Comparer _Comparer; // 0x0

	// Properties
	public ActionScriptControllerBase AS_Controller { get; set; }
	public string ActionCodeName { get; set; }
	public ActionCommandBase[] Commands { get; set; }
	public float CurrentTime { get; set; }
	public bool IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19A3F0 Offset: 0x19A4F1 VA: 0x19A3F0
	// RVA: 0x1E74FA0 Offset: 0x1E750A1 VA: 0x1E74FA0
	public ActionScriptControllerBase get_AS_Controller() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A400 Offset: 0x19A501 VA: 0x19A400
	// RVA: 0x1E74FB0 Offset: 0x1E750B1 VA: 0x1E74FB0
	private void set_AS_Controller(ActionScriptControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A410 Offset: 0x19A511 VA: 0x19A410
	// RVA: 0x1E74FC0 Offset: 0x1E750C1 VA: 0x1E74FC0
	public string get_ActionCodeName() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A420 Offset: 0x19A521 VA: 0x19A420
	// RVA: 0x1E74FD0 Offset: 0x1E750D1 VA: 0x1E74FD0
	private void set_ActionCodeName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A430 Offset: 0x19A531 VA: 0x19A430
	// RVA: 0x1E74FE0 Offset: 0x1E750E1 VA: 0x1E74FE0
	public ActionCommandBase[] get_Commands() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A440 Offset: 0x19A541 VA: 0x19A440
	// RVA: 0x1E74FF0 Offset: 0x1E750F1 VA: 0x1E74FF0
	public void set_Commands(ActionCommandBase[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A450 Offset: 0x19A551 VA: 0x19A450
	// RVA: 0x1E75000 Offset: 0x1E75101 VA: 0x1E75000
	public float get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A460 Offset: 0x19A561 VA: 0x19A460
	// RVA: 0x1E75010 Offset: 0x1E75111 VA: 0x1E75010
	private void set_CurrentTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A470 Offset: 0x19A571 VA: 0x19A470
	// RVA: 0x1E75020 Offset: 0x1E75121 VA: 0x1E75020
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A480 Offset: 0x19A581 VA: 0x19A480
	// RVA: 0x1E75030 Offset: 0x1E75131 VA: 0x1E75030
	private void set_IsActive(bool value) { }

	// RVA: 0x1E75040 Offset: 0x1E75141 VA: 0x1E75040
	public void .ctor(string actionCodeName, ActionCommandBase[] actionCommands) { }

	// RVA: 0x1E75320 Offset: 0x1E75421 VA: 0x1E75320
	public void StartCode() { }

	// RVA: 0x1E753B0 Offset: 0x1E754B1 VA: 0x1E753B0
	public void StopActionCode() { }

	// RVA: 0x1E75430 Offset: 0x1E75531 VA: 0x1E75430
	public void DestroyActionCode() { }

	// RVA: 0x1E754A0 Offset: 0x1E755A1 VA: 0x1E754A0
	public void Update(float deltaTime) { }

	// RVA: 0x1E756F0 Offset: 0x1E757F1 VA: 0x1E756F0
	private static void .cctor() { }
}

