[HelpURLAttribute] // RVA: 0x148570 Offset: 0x148671 VA: 0x148570
[AddComponentMenu] // RVA: 0x148570 Offset: 0x148671 VA: 0x148570
public class GrounderVRIK : Grounder // TypeDefIndex: 9431
{
	// Fields
	[TooltipAttribute] // RVA: 0x1798F0 Offset: 0x1799F1 VA: 0x1798F0
	public VRIK ik; // 0x40
	private Transform[] feet; // 0x48

	// Methods

	[ContextMenu] // RVA: 0x1AA610 Offset: 0x1AA711 VA: 0x1AA610
	// RVA: 0x2B36F70 Offset: 0x2B37071 VA: 0x2B36F70
	private void OpenTutorial() { }

	[ContextMenu] // RVA: 0x1AA650 Offset: 0x1AA751 VA: 0x1AA650
	// RVA: 0x2B36FC0 Offset: 0x2B370C1 VA: 0x2B36FC0 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA690 Offset: 0x1AA791 VA: 0x1AA690
	// RVA: 0x2B37010 Offset: 0x2B37111 VA: 0x2B37010 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2B37060 Offset: 0x2B37161 VA: 0x2B37060 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2B37080 Offset: 0x2B37181 VA: 0x2B37080
	private bool IsReadyToInitiate() { }

	// RVA: 0x2B37120 Offset: 0x2B37221 VA: 0x2B37120
	private void Update() { }

	// RVA: 0x2B371E0 Offset: 0x2B372E1 VA: 0x2B371E0
	private void Initiate() { }

	// RVA: 0x2B37430 Offset: 0x2B37531 VA: 0x2B37430
	private void OnSolverUpdate() { }

	// RVA: 0x2B376D0 Offset: 0x2B377D1 VA: 0x2B376D0
	private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg) { }

	// RVA: 0x2B377E0 Offset: 0x2B378E1 VA: 0x2B377E0
	private void OnPostSolverUpdate() { }

	// RVA: 0x2B379E0 Offset: 0x2B37AE1 VA: 0x2B379E0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2B37B40 Offset: 0x2B37C41 VA: 0x2B37B40
	private void OnDestroy() { }

	// RVA: 0x2B37CE0 Offset: 0x2B37DE1 VA: 0x2B37CE0
	public void .ctor() { }
}

