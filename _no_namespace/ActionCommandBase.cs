public abstract class ActionCommandBase // TypeDefIndex: 6173
{
	// Fields
	public ActionCommandBase.State CurrentState; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15BC20 Offset: 0x15BD21 VA: 0x15BC20
	private ActionCode <ActionCode>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15BC30 Offset: 0x15BD31 VA: 0x15BC30
	private ActionCommandDataTable <ActionCommandData>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15BC40 Offset: 0x15BD41 VA: 0x15BC40
	private ActionScriptControllerBase <Controller>k__BackingField; // 0x78

	// Properties
	public ActionCode ActionCode { get; set; }
	public float DelayTime { get; }
	public virtual float Duration { get; }
	public virtual bool HasEndAction { get; }
	protected ActionCommandDataTable ActionCommandData { get; set; }
	protected ActionScriptControllerBase Controller { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19A680 Offset: 0x19A781 VA: 0x19A680
	// RVA: 0x1E759A0 Offset: 0x1E75AA1 VA: 0x1E759A0
	public ActionCode get_ActionCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A690 Offset: 0x19A791 VA: 0x19A690
	// RVA: 0x1E759B0 Offset: 0x1E75AB1 VA: 0x1E759B0
	public void set_ActionCode(ActionCode value) { }

	// RVA: 0x1E75310 Offset: 0x1E75411 VA: 0x1E75310
	public float get_DelayTime() { }

	// RVA: 0x1E759C0 Offset: 0x1E75AC1 VA: 0x1E759C0 Slot: 4
	public virtual float get_Duration() { }

	// RVA: 0x1E759D0 Offset: 0x1E75AD1 VA: 0x1E759D0 Slot: 5
	public virtual bool get_HasEndAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6A0 Offset: 0x19A7A1 VA: 0x19A6A0
	// RVA: 0x1E75A00 Offset: 0x1E75B01 VA: 0x1E75A00
	protected ActionCommandDataTable get_ActionCommandData() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6B0 Offset: 0x19A7B1 VA: 0x19A6B0
	// RVA: 0x1E75A40 Offset: 0x1E75B41 VA: 0x1E75A40
	private void set_ActionCommandData(ActionCommandDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6C0 Offset: 0x19A7C1 VA: 0x19A6C0
	// RVA: 0x1E75A70 Offset: 0x1E75B71 VA: 0x1E75A70
	protected ActionScriptControllerBase get_Controller() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6D0 Offset: 0x19A7D1 VA: 0x19A6D0
	// RVA: 0x1E75A80 Offset: 0x1E75B81 VA: 0x1E75A80
	private void set_Controller(ActionScriptControllerBase value) { }

	// RVA: 0x1E75A90 Offset: 0x1E75B91 VA: 0x1E75A90 Slot: 6
	public virtual bool IsDoneCommand(float currentTime) { }

	// RVA: 0x1E75AF0 Offset: 0x1E75BF1 VA: 0x1E75AF0
	public void .ctor(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller) { }

	// RVA: 0x1E75B50 Offset: 0x1E75C51 VA: 0x1E75B50 Slot: 7
	public virtual void ActionInitial() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DoAction() { }

	// RVA: 0x1E75B60 Offset: 0x1E75C61 VA: 0x1E75B60 Slot: 9
	public virtual void UpdateAction(float elapsedTime) { }

	// RVA: 0x1E75B70 Offset: 0x1E75C71 VA: 0x1E75B70 Slot: 10
	public virtual void EndAction() { }

	// RVA: 0x1E75B80 Offset: 0x1E75C81 VA: 0x1E75B80 Slot: 11
	public virtual void ActionFinal() { }

	// RVA: 0x1E75B90 Offset: 0x1E75C91 VA: 0x1E75B90 Slot: 12
	public virtual void Destroy() { }
}

