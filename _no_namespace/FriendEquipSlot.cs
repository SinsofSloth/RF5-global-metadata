public class FriendEquipSlot : MonoBehaviour // TypeDefIndex: 8659
{
	// Fields
	private UIEquipSlot equipSlot; // 0x18
	[SerializeField] // RVA: 0x171CE0 Offset: 0x171DE1 VA: 0x171CE0
	private Image focusImage; // 0x20
	private UnityAction touchAction; // 0x28

	// Methods

	// RVA: 0x1D60BD0 Offset: 0x1D60CD1 VA: 0x1D60BD0
	private void Awake() { }

	// RVA: 0x1D60CF0 Offset: 0x1D60DF1 VA: 0x1D60CF0
	public void SetupSlotData(ActorID _actor) { }

	// RVA: 0x1D60DC0 Offset: 0x1D60EC1 VA: 0x1D60DC0
	public ItemData GetEquipItemData() { }

	// RVA: 0x1D60DE0 Offset: 0x1D60EE1 VA: 0x1D60DE0
	public void SetTouchAction(UnityAction _action) { }

	// RVA: 0x1D60E00 Offset: 0x1D60F01 VA: 0x1D60E00
	private void OnTouch() { }

	// RVA: 0x1D60E20 Offset: 0x1D60F21 VA: 0x1D60E20
	public void OnFocus() { }

	// RVA: 0x1D60E40 Offset: 0x1D60F41 VA: 0x1D60E40
	public void OffFocus() { }

	// RVA: 0x1D60E60 Offset: 0x1D60F61 VA: 0x1D60E60
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7F80 Offset: 0x1A8081 VA: 0x1A7F80
	// RVA: 0x1D60E70 Offset: 0x1D60F71 VA: 0x1D60E70
	private void <Awake>b__3_0(BaseEventData _data) { }
}

