[Serializable]
public class ActionBehaviorCommandData // TypeDefIndex: 6134
{
	// Fields
	[SerializeField] // RVA: 0x15B8D0 Offset: 0x15B9D1 VA: 0x15B8D0
	public ActionBehaviorCommandType CommandType; // 0x10
	[SerializeField] // RVA: 0x15B8E0 Offset: 0x15B9E1 VA: 0x15B8E0
	public List<ActionBehaviorCommandData.Argument> ArgumentList; // 0x18

	// Methods

	// RVA: 0x1E746C0 Offset: 0x1E747C1 VA: 0x1E746C0
	public ActionBehaviorCommandInformation CreateActionBehaviorCommandInformation(ActionBehaviorDataTable dataTable) { }

	// RVA: 0x1E74A90 Offset: 0x1E74B91 VA: 0x1E74A90
	public void .ctor() { }
}

