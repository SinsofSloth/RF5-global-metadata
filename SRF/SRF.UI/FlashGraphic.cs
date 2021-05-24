[AddComponentMenu] // RVA: 0x1270B0 Offset: 0x1271B1 VA: 0x1270B0
[ExecuteInEditMode] // RVA: 0x1270B0 Offset: 0x1271B1 VA: 0x1270B0
public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 4317
{
	// Fields
	public float DecayTime; // 0x18
	public Color DefaultColor; // 0x1C
	public Color FlashColor; // 0x2C
	public Graphic Target; // 0x40

	// Methods

	// RVA: 0x1A86540 Offset: 0x1A86641 VA: 0x1A86540 Slot: 17
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A86580 Offset: 0x1A86681 VA: 0x1A86580 Slot: 18
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A865C0 Offset: 0x1A866C1 VA: 0x1A865C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A86610 Offset: 0x1A86711 VA: 0x1A86610
	protected void Update() { }

	// RVA: 0x1A86620 Offset: 0x1A86721 VA: 0x1A86620
	public void Flash() { }

	// RVA: 0x1A866A0 Offset: 0x1A867A1 VA: 0x1A866A0
	public void .ctor() { }
}

