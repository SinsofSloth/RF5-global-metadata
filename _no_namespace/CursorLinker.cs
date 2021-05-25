public class CursorLinker : MonoBehaviour // TypeDefIndex: 8456
{
	// Fields
	[SerializeField] // RVA: 0x16FB40 Offset: 0x16FC41 VA: 0x16FB40
	private CursorLinker _BackLink; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16FB50 Offset: 0x16FC51 VA: 0x16FB50
	private ButtonWorkBase <ButtonWork>k__BackingField; // 0x20
	private UIItemSlot _ItemSlot; // 0x28
	private CursorLinker WorkLink; // 0x30
	private RectTransform rect; // 0x38
	[SerializeField] // RVA: 0x16FB60 Offset: 0x16FC61 VA: 0x16FB60
	private bool TouchSelector; // 0x40
	[SerializeField] // RVA: 0x16FB70 Offset: 0x16FC71 VA: 0x16FB70
	private bool SubmitOnTouch; // 0x41
	[SerializeField] // RVA: 0x16FB80 Offset: 0x16FC81 VA: 0x16FB80
	private INPUTLAYER inputLayer; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x16FB90 Offset: 0x16FC91 VA: 0x16FB90
	private bool <IsFocusing>k__BackingField; // 0x48

	// Properties
	public ButtonWorkBase ButtonWork { get; set; }
	public UIItemSlot ItemSlot { get; set; }
	public bool IsFocusing { get; set; }
	public CursorLinker BackLink { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7740 Offset: 0x1A7841 VA: 0x1A7740
	// RVA: 0x1FD7400 Offset: 0x1FD7501 VA: 0x1FD7400
	public ButtonWorkBase get_ButtonWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7750 Offset: 0x1A7851 VA: 0x1A7750
	// RVA: 0x1FD7410 Offset: 0x1FD7511 VA: 0x1FD7410
	public void set_ButtonWork(ButtonWorkBase value) { }

	// RVA: 0x1FD7420 Offset: 0x1FD7521 VA: 0x1FD7420
	public UIItemSlot get_ItemSlot() { }

	// RVA: 0x1FD74D0 Offset: 0x1FD75D1 VA: 0x1FD74D0
	public void set_ItemSlot(UIItemSlot value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7760 Offset: 0x1A7861 VA: 0x1A7760
	// RVA: 0x1FD74E0 Offset: 0x1FD75E1 VA: 0x1FD74E0
	public bool get_IsFocusing() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7770 Offset: 0x1A7871 VA: 0x1A7770
	// RVA: 0x1FD74F0 Offset: 0x1FD75F1 VA: 0x1FD74F0
	private void set_IsFocusing(bool value) { }

	// RVA: 0x1FD7500 Offset: 0x1FD7601 VA: 0x1FD7500 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1FD75E0 Offset: 0x1FD76E1 VA: 0x1FD75E0
	private void OnDestroy() { }

	// RVA: 0x1FD6B80 Offset: 0x1FD6C81 VA: 0x1FD6B80
	public CursorLinker get_BackLink() { }

	// RVA: 0x1FD75F0 Offset: 0x1FD76F1 VA: 0x1FD75F0
	public void set_BackLink(CursorLinker value) { }

	// RVA: 0x1FD7600 Offset: 0x1FD7701 VA: 0x1FD7600 Slot: 5
	public virtual CursorLinker GetMyCursorLinker() { }

	// RVA: 0x1FD7610 Offset: 0x1FD7711 VA: 0x1FD7610 Slot: 6
	public virtual CursorLinker GetNextObject(CursorLinker.InputMoveType _InType) { }

	// RVA: 0x1FD4E50 Offset: 0x1FD4F51 VA: 0x1FD4E50
	public Vector2 GetFocusPos() { }

	// RVA: 0x1FD7620 Offset: 0x1FD7721 VA: 0x1FD7620 Slot: 7
	public virtual Vector2 GetImageSize() { }

	// RVA: 0x1FD76F0 Offset: 0x1FD77F1 VA: 0x1FD76F0 Slot: 8
	public virtual void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1FD7700 Offset: 0x1FD7801 VA: 0x1FD7700 Slot: 9
	public virtual void InComingFocus(CursorLinker prevObject) { }

	// RVA: 0x1FD7710 Offset: 0x1FD7811 VA: 0x1FD7710 Slot: 10
	public virtual void OnFocus() { }

	// RVA: 0x1FD7730 Offset: 0x1FD7831 VA: 0x1FD7730 Slot: 11
	public virtual void EndFocus() { }

	// RVA: 0x1FD7750 Offset: 0x1FD7851 VA: 0x1FD7750 Slot: 12
	protected virtual bool CanUpdateCursor() { }

	// RVA: 0x1FD77E0 Offset: 0x1FD78E1 VA: 0x1FD77E0 Slot: 13
	protected virtual void InitInputLayer() { }

	// RVA: 0x1FD78E0 Offset: 0x1FD79E1 VA: 0x1FD78E0 Slot: 14
	protected virtual void ClearInputLayer() { }

	// RVA: 0x1FD79D0 Offset: 0x1FD7AD1 VA: 0x1FD79D0
	protected void UpdateCursor() { }

	// RVA: 0x1FD7CD0 Offset: 0x1FD7DD1 VA: 0x1FD7CD0 Slot: 15
	public virtual void OnTouch() { }

	// RVA: 0x1FD7E60 Offset: 0x1FD7F61 VA: 0x1FD7E60
	private void Update() { }

	// RVA: 0x1FD73F0 Offset: 0x1FD74F1 VA: 0x1FD73F0
	public void .ctor() { }
}

