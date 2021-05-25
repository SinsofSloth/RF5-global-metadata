public class OrderBoardController : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7197
{
	// Fields
	[SerializeField] // RVA: 0x164E80 Offset: 0x164F81 VA: 0x164E80
	private PublicationPlace publicationPlace; // 0x18
	private string focusName; // 0x20

	// Properties
	public PublicationPlace PublicationPlace { get; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1F1CB60 Offset: 0x1F1CC61 VA: 0x1F1CB60
	public PublicationPlace get_PublicationPlace() { }

	// RVA: 0x1F1CB70 Offset: 0x1F1CC71 VA: 0x1F1CB70
	private void Awake() { }

	// RVA: 0x1F1CC80 Offset: 0x1F1CD81 VA: 0x1F1CC80 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1F1D220 Offset: 0x1F1D321 VA: 0x1F1D220 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1F1D2E0 Offset: 0x1F1D3E1 VA: 0x1F1D2E0 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1F1D330 Offset: 0x1F1D431 VA: 0x1F1D330 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1F1D340 Offset: 0x1F1D441 VA: 0x1F1D340 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1F1D3B0 Offset: 0x1F1D4B1 VA: 0x1F1D3B0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1F1D3C0 Offset: 0x1F1D4C1 VA: 0x1F1D3C0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1F1D3D0 Offset: 0x1F1D4D1 VA: 0x1F1D3D0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1F1D3E0 Offset: 0x1F1D4E1 VA: 0x1F1D3E0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1F1D3F0 Offset: 0x1F1D4F1 VA: 0x1F1D3F0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1F1D400 Offset: 0x1F1D501 VA: 0x1F1D400 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1F1CE30 Offset: 0x1F1CF31 VA: 0x1F1CE30
	private bool CheckStory() { }

	// RVA: 0x1F1D480 Offset: 0x1F1D581 VA: 0x1F1D480 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1F1D490 Offset: 0x1F1D591 VA: 0x1F1D490 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1F1D4A0 Offset: 0x1F1D5A1 VA: 0x1F1D4A0
	public void .ctor() { }

	// RVA: 0x1F1D500 Offset: 0x1F1D601 VA: 0x1F1D500 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1F1D510 Offset: 0x1F1D611 VA: 0x1F1D510 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

