[DocumentationSortingAttribute] // RVA: 0x12EF50 Offset: 0x12F051 VA: 0x12EF50
[SaveDuringPlayAttribute] // RVA: 0x12EF50 Offset: 0x12F051 VA: 0x12EF50
[HelpURLAttribute] // RVA: 0x12EF50 Offset: 0x12F051 VA: 0x12EF50
public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 4871
{
	// Fields
	[HeaderAttribute] // RVA: 0x134D70 Offset: 0x134E71 VA: 0x134D70
	[TooltipAttribute] // RVA: 0x134D70 Offset: 0x134E71 VA: 0x134D70
	public LayerMask m_LayerMask; // 0x18
	[TagFieldAttribute] // RVA: 0x134DD0 Offset: 0x134ED1 VA: 0x134DD0
	[TooltipAttribute] // RVA: 0x134DD0 Offset: 0x134ED1 VA: 0x134DD0
	public string m_WithTag; // 0x20
	[TagFieldAttribute] // RVA: 0x134E20 Offset: 0x134F21 VA: 0x134E20
	[TooltipAttribute] // RVA: 0x134E20 Offset: 0x134F21 VA: 0x134E20
	public string m_WithoutTag; // 0x28
	[NoSaveDuringPlayAttribute] // RVA: 0x134E70 Offset: 0x134F71 VA: 0x134E70
	[TooltipAttribute] // RVA: 0x134E70 Offset: 0x134F71 VA: 0x134E70
	public int m_SkipFirst; // 0x30
	[TooltipAttribute] // RVA: 0x134EC0 Offset: 0x134FC1 VA: 0x134EC0
	public bool m_Repeating; // 0x34
	public CinemachineTriggerAction.ActionSettings m_OnObjectEnter; // 0x38
	public CinemachineTriggerAction.ActionSettings m_OnObjectExit; // 0x60
	private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88

	// Methods

	// RVA: 0x1A16C60 Offset: 0x1A16D61 VA: 0x1A16C60
	private bool Filter(GameObject other) { }

	// RVA: 0x1A16D60 Offset: 0x1A16E61 VA: 0x1A16D60
	private void InternalDoTriggerEnter(GameObject other) { }

	// RVA: 0x1A17360 Offset: 0x1A17461 VA: 0x1A17360
	private void InternalDoTriggerExit(GameObject other) { }

	// RVA: 0x1A17410 Offset: 0x1A17511 VA: 0x1A17410
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1A174D0 Offset: 0x1A175D1 VA: 0x1A174D0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x1A17510 Offset: 0x1A17611 VA: 0x1A17510
	private void OnCollisionEnter(Collision other) { }

	// RVA: 0x1A175D0 Offset: 0x1A176D1 VA: 0x1A175D0
	private void OnCollisionExit(Collision other) { }

	// RVA: 0x1A17610 Offset: 0x1A17711 VA: 0x1A17610
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1A176D0 Offset: 0x1A177D1 VA: 0x1A176D0
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1A17710 Offset: 0x1A17811 VA: 0x1A17710
	private void OnCollisionEnter2D(Collision2D other) { }

	// RVA: 0x1A177D0 Offset: 0x1A178D1 VA: 0x1A177D0
	private void OnCollisionExit2D(Collision2D other) { }

	// RVA: 0x1A17810 Offset: 0x1A17911 VA: 0x1A17810
	private void OnEnable() { }

	// RVA: 0x1A17820 Offset: 0x1A17921 VA: 0x1A17820
	public void .ctor() { }
}

