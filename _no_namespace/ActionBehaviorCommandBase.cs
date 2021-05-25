public abstract class ActionBehaviorCommandBase // TypeDefIndex: 6107
{
	// Fields
	protected ActionBehaviorController Controller; // 0x10
	protected ActionBehaviorCommandInformation Info; // 0x18

	// Methods

	// RVA: 0x1E74650 Offset: 0x1E74751 VA: 0x1E74650
	public void .ctor(ActionBehaviorController controller, ActionBehaviorCommandInformation info) { }

	// RVA: 0x1E746A0 Offset: 0x1E747A1 VA: 0x1E746A0 Slot: 4
	public virtual void OnSetupParameter() { }

	// RVA: 0x1E746B0 Offset: 0x1E747B1 VA: 0x1E746B0 Slot: 5
	public virtual void OnExecute() { }
}

