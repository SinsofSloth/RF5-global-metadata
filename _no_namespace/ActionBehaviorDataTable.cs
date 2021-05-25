public class ActionBehaviorDataTable : ScriptableObject // TypeDefIndex: 6136
{
	// Fields
	[SerializeField] // RVA: 0x15B8F0 Offset: 0x15B9F1 VA: 0x15B8F0
	public List<bool> CommandParameterList_Bool; // 0x18
	[SerializeField] // RVA: 0x15B900 Offset: 0x15BA01 VA: 0x15B900
	public List<int> CommandParameterList_Int; // 0x20
	[SerializeField] // RVA: 0x15B910 Offset: 0x15BA11 VA: 0x15B910
	public List<float> CommandParameterList_Float; // 0x28
	[SerializeField] // RVA: 0x15B920 Offset: 0x15BA21 VA: 0x15B920
	public List<string> CommandParameterList_String; // 0x30
	[SerializeField] // RVA: 0x15B930 Offset: 0x15BA31 VA: 0x15B930
	public List<Vector2> CommandParameterList_Vector2; // 0x38
	[SerializeField] // RVA: 0x15B940 Offset: 0x15BA41 VA: 0x15B940
	public List<Vector3> CommandParameterList_Vector3; // 0x40

	// Methods

	// RVA: 0x1E74DE0 Offset: 0x1E74EE1 VA: 0x1E74DE0
	public List<ActionBehaviorCommandInformation> CreateActionBehaviorCommandInformation(List<ActionBehaviorCommandData> commandDataList) { }

	// RVA: 0x1E74F90 Offset: 0x1E75091 VA: 0x1E74F90
	public void .ctor() { }
}

