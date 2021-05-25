public class FarmChargeInteraction : SingletonMonoBehaviour<FarmChargeInteraction> // TypeDefIndex: 8384
{
	// Fields
	private readonly Vector3[] DefineBoxSize; // 0x18
	private List<ToolInteractionInterface> FocusInteractionList; // 0x20
	private FarmRange CurrentFarmRange; // 0x28
	private Vector3 BoxSize; // 0x2C
	private Vector3 BoxPosition; // 0x38
	private FarmAction CurrentFarmAction; // 0x44

	// Methods

	// RVA: 0x202B450 Offset: 0x202B551 VA: 0x202B450
	public List<ToolInteractionInterface> GetFocusInteractions() { }

	// RVA: 0x202B460 Offset: 0x202B561 VA: 0x202B460
	public void UpdateRotation() { }

	// RVA: 0x202B470 Offset: 0x202B571 VA: 0x202B470
	public void OnMultiFocus(FarmRange farmRange, FarmAction action) { }

	// RVA: 0x202C5C0 Offset: 0x202C6C1 VA: 0x202C5C0
	public void OffMultiFocus() { }

	// RVA: 0x202C7C0 Offset: 0x202C8C1 VA: 0x202C7C0
	public static bool IsSupportFarmInteractionType(ItemCategory itemCategory, ToolInteractionInterface target, HumanController human) { }

	// RVA: 0x202BCF0 Offset: 0x202BDF1 VA: 0x202BCF0
	public static bool IsSupportFarmInteractionType(FarmAction action, ToolInteractionInterface target, HumanController human, bool isMulti = False) { }

	// RVA: 0x202C870 Offset: 0x202C971 VA: 0x202C870
	private void OnDrawGizmos() { }

	// RVA: 0x202C8F0 Offset: 0x202C9F1 VA: 0x202C8F0
	public void .ctor() { }
}

