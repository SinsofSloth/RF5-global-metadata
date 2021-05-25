public class ObjectInteractionController : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7195
{
	// Fields
	[SerializeField] // RVA: 0x164E00 Offset: 0x164F01 VA: 0x164E00
	private string InteractionID; // 0x18
	private FocusObjectDataTable Data; // 0x20
	private string focusName; // 0x38
	[SerializeField] // RVA: 0x164E10 Offset: 0x164F11 VA: 0x164E10
	private float InteractionAngle; // 0x40
	private ObjectType ObjectType; // 0x44
	private GameFlagData GameFlag; // 0x48
	[SerializeField] // RVA: 0x164E20 Offset: 0x164F21 VA: 0x164E20
	private int _focusPriority; // 0x4C

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1D8D260 Offset: 0x1D8D361 VA: 0x1D8D260
	private void Start() { }

	// RVA: 0x1D8D300 Offset: 0x1D8D401 VA: 0x1D8D300
	private void LoadAsset() { }

	// RVA: 0x1D8D4B0 Offset: 0x1D8D5B1 VA: 0x1D8D4B0
	public void SetNameID(string nameID) { }

	// RVA: 0x1D8D580 Offset: 0x1D8D681 VA: 0x1D8D580 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1D8D790 Offset: 0x1D8D891 VA: 0x1D8D790 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1D8D980 Offset: 0x1D8DA81 VA: 0x1D8D980 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1D8D9D0 Offset: 0x1D8DAD1 VA: 0x1D8D9D0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1D8DA00 Offset: 0x1D8DB01 VA: 0x1D8DA00
	public ObjectType GetObjectType() { }

	// RVA: 0x1D8DA30 Offset: 0x1D8DB31 VA: 0x1D8DA30 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1D8DC30 Offset: 0x1D8DD31 VA: 0x1D8DC30 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D8DC40 Offset: 0x1D8DD41 VA: 0x1D8DC40 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1D8DC50 Offset: 0x1D8DD51 VA: 0x1D8DC50 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1D8DC60 Offset: 0x1D8DD61 VA: 0x1D8DC60 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1D8DC70 Offset: 0x1D8DD71 VA: 0x1D8DC70 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1D8DC80 Offset: 0x1D8DD81 VA: 0x1D8DC80 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1D8DCA0 Offset: 0x1D8DDA1 VA: 0x1D8DCA0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D8DE20 Offset: 0x1D8DF21 VA: 0x1D8DE20 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D8DF40 Offset: 0x1D8E041 VA: 0x1D8DF40
	public void .ctor() { }

	// RVA: 0x1D8DF50 Offset: 0x1D8E051 VA: 0x1D8DF50 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D8DF60 Offset: 0x1D8E061 VA: 0x1D8DF60 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

