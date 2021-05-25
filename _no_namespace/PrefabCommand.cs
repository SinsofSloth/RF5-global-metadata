public class PrefabCommand : ActionCommandBase // TypeDefIndex: 6187
{
	// Fields
	private Prefab _PrefabID; // 0x80
	private bool IsParse; // 0x84
	private GameObject PrefabParentObject; // 0x88
	private PrefabCommand.PrefabLoadState CurrentPrefabLoadState; // 0x90
	private UnityEvent OnComplete; // 0x98

	// Properties
	private Prefab PrefabID { get; }
	public bool IsAttach { get; }

	// Methods

	// RVA: 0x27746C0 Offset: 0x27747C1 VA: 0x27746C0
	private Prefab get_PrefabID() { }

	// RVA: 0x2774740 Offset: 0x2774841 VA: 0x2774740
	public bool get_IsAttach() { }

	// RVA: 0x2774760 Offset: 0x2774861 VA: 0x2774760
	public void .ctor(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller) { }

	// RVA: 0x2774830 Offset: 0x2774931 VA: 0x2774830 Slot: 8
	public override void DoAction() { }

	// RVA: 0x2774A90 Offset: 0x2774B91 VA: 0x2774A90
	public void Create() { }

	// RVA: 0x2774C50 Offset: 0x2774D51 VA: 0x2774C50 Slot: 11
	public override void ActionFinal() { }

	// RVA: 0x2774D30 Offset: 0x2774E31 VA: 0x2774D30 Slot: 12
	public override void Destroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A7B0 Offset: 0x19A8B1 VA: 0x19A7B0
	// RVA: 0x2774E00 Offset: 0x2774F01 VA: 0x2774E00
	private void <DoAction>b__11_0(AssetHandle<GameObject> handle) { }
}

