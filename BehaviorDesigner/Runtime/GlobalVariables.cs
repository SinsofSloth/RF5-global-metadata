public class GlobalVariables : ScriptableObject, IVariableSource // TypeDefIndex: 4671
{
	// Fields
	private static GlobalVariables instance; // 0x0
	[SerializeField] // RVA: 0x12D550 Offset: 0x12D651 VA: 0x12D550
	private List<SharedVariable> mVariables; // 0x18
	private Dictionary<string, int> mSharedVariableIndex; // 0x20
	[SerializeField] // RVA: 0x12D560 Offset: 0x12D661 VA: 0x12D560
	private VariableSerializationData mVariableData; // 0x28
	[SerializeField] // RVA: 0x12D570 Offset: 0x12D671 VA: 0x12D570
	private string mVersion; // 0x30

	// Properties
	public static GlobalVariables Instance { get; }
	public List<SharedVariable> Variables { get; set; }
	public VariableSerializationData VariableData { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x1772290 Offset: 0x1772391 VA: 0x1772290
	public void .ctor() { }

	// RVA: 0x17722A0 Offset: 0x17723A1 VA: 0x17722A0
	private static void .cctor() { }

	// RVA: 0x1769F60 Offset: 0x176A061 VA: 0x1769F60
	public static GlobalVariables get_Instance() { }

	// RVA: 0x17723C0 Offset: 0x17724C1 VA: 0x17723C0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17723D0 Offset: 0x17724D1 VA: 0x17723D0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1772580 Offset: 0x1772681 VA: 0x1772580
	public VariableSerializationData get_VariableData() { }

	// RVA: 0x1772590 Offset: 0x1772691 VA: 0x1772590
	public void set_VariableData(VariableSerializationData value) { }

	// RVA: 0x17725A0 Offset: 0x17726A1 VA: 0x17725A0
	public string get_Version() { }

	// RVA: 0x17725B0 Offset: 0x17726B1 VA: 0x17725B0
	public void set_Version(string value) { }

	// RVA: 0x17722B0 Offset: 0x17723B1 VA: 0x17722B0
	public void CheckForSerialization(bool force) { }

	// RVA: 0x176A160 Offset: 0x176A261 VA: 0x176A160 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x17727E0 Offset: 0x17728E1 VA: 0x17727E0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x1772810 Offset: 0x1772911 VA: 0x1772810 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1772AA0 Offset: 0x1772BA1 VA: 0x1772AA0
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x1772AF0 Offset: 0x1772BF1 VA: 0x1772AF0 Slot: 8
	public void UpdateVariableName(SharedVariable sharedVariable, string name) { }

	// RVA: 0x1772B40 Offset: 0x1772C41 VA: 0x1772B40 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1772400 Offset: 0x1772501 VA: 0x1772400
	private void UpdateVariablesIndex() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x12DA70 Offset: 0x12DB71 VA: 0x12DA70
	// RVA: 0x1772B50 Offset: 0x1772C51 VA: 0x1772B50
	private static void DomainReset() { }
}

