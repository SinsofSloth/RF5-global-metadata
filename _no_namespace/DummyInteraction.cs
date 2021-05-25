public class DummyInteraction : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7144
{
	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x200FEB0 Offset: 0x200FFB1 VA: 0x200FEB0
	private void Start() { }

	// RVA: 0x200FEC0 Offset: 0x200FFC1 VA: 0x200FEC0
	private void Update() { }

	// RVA: 0x200FED0 Offset: 0x200FFD1 VA: 0x200FED0 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x200FF50 Offset: 0x2010051 VA: 0x200FF50 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x200FF60 Offset: 0x2010061 VA: 0x200FF60 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x200FFB0 Offset: 0x20100B1 VA: 0x200FFB0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x2010000 Offset: 0x2010101 VA: 0x2010000 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x2010010 Offset: 0x2010111 VA: 0x2010010 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x2010020 Offset: 0x2010121 VA: 0x2010020 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x2010030 Offset: 0x2010131 VA: 0x2010030 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x2010040 Offset: 0x2010141 VA: 0x2010040 Slot: 11
	public void OnFocus() { }

	// RVA: 0x2010050 Offset: 0x2010151 VA: 0x2010050 Slot: 12
	public void OffFocus() { }

	// RVA: 0x2010060 Offset: 0x2010161 VA: 0x2010060 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x2010070 Offset: 0x2010171 VA: 0x2010070 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x2010080 Offset: 0x2010181 VA: 0x2010080 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x2010090 Offset: 0x2010191 VA: 0x2010090
	public void .ctor() { }

	// RVA: 0x20100A0 Offset: 0x20101A1 VA: 0x20100A0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x20100B0 Offset: 0x20101B1 VA: 0x20100B0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

