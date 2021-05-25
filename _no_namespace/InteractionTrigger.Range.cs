[Serializable]
public class InteractionTrigger.Range // TypeDefIndex: 9524
{
	// Fields
	[HideInInspector] // RVA: 0x1985B0 Offset: 0x1986B1 VA: 0x1985B0
	[SerializeField] // RVA: 0x1985B0 Offset: 0x1986B1 VA: 0x1985B0
	public string name; // 0x10
	[HideInInspector] // RVA: 0x1985F0 Offset: 0x1986F1 VA: 0x1985F0
	[SerializeField] // RVA: 0x1985F0 Offset: 0x1986F1 VA: 0x1985F0
	public bool show; // 0x18
	[TooltipAttribute] // RVA: 0x198630 Offset: 0x198731 VA: 0x198630
	public InteractionTrigger.CharacterPosition characterPosition; // 0x20
	[TooltipAttribute] // RVA: 0x198670 Offset: 0x198771 VA: 0x198670
	public InteractionTrigger.CameraPosition cameraPosition; // 0x28
	[TooltipAttribute] // RVA: 0x1986B0 Offset: 0x1987B1 VA: 0x1986B0
	public InteractionTrigger.Range.Interaction[] interactions; // 0x30

	// Methods

	// RVA: 0x2918CD0 Offset: 0x2918DD1 VA: 0x2918CD0
	public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) { }

	// RVA: 0x2919B90 Offset: 0x2919C91 VA: 0x2919B90
	public void .ctor() { }
}

