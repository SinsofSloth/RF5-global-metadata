[Serializable]
public class InteractionObject.InteractionEvent // TypeDefIndex: 9510
{
	// Fields
	[TooltipAttribute] // RVA: 0x197D10 Offset: 0x197E11 VA: 0x197D10
	public float time; // 0x10
	[TooltipAttribute] // RVA: 0x197D50 Offset: 0x197E51 VA: 0x197D50
	public bool pause; // 0x14
	[TooltipAttribute] // RVA: 0x197D90 Offset: 0x197E91 VA: 0x197D90
	public bool pickUp; // 0x15
	[TooltipAttribute] // RVA: 0x197DD0 Offset: 0x197ED1 VA: 0x197DD0
	public InteractionObject.AnimatorEvent[] animations; // 0x18
	[TooltipAttribute] // RVA: 0x197E10 Offset: 0x197F11 VA: 0x197E10
	public InteractionObject.Message[] messages; // 0x20
	[TooltipAttribute] // RVA: 0x197E50 Offset: 0x197F51 VA: 0x197E50
	public UnityEvent unityEvent; // 0x28

	// Methods

	// RVA: 0x2913970 Offset: 0x2913A71 VA: 0x2913970
	public void Activate(Transform t) { }

	// RVA: 0x2913B40 Offset: 0x2913C41 VA: 0x2913B40
	public void .ctor() { }
}

