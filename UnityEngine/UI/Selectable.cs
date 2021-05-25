[AddComponentMenu] // RVA: 0x11A610 Offset: 0x11A711 VA: 0x11A610
[ExecuteAlways] // RVA: 0x11A610 Offset: 0x11A711 VA: 0x11A610
[SelectionBaseAttribute] // RVA: 0x11A610 Offset: 0x11A711 VA: 0x11A610
[DisallowMultipleComponent] // RVA: 0x11A610 Offset: 0x11A711 VA: 0x11A610
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 4002
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x11C550 Offset: 0x11C651 VA: 0x11C550
	[SerializeField] // RVA: 0x11C550 Offset: 0x11C651 VA: 0x11C550
	private Navigation m_Navigation; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x11C5A0 Offset: 0x11C6A1 VA: 0x11C5A0
	[SerializeField] // RVA: 0x11C5A0 Offset: 0x11C6A1 VA: 0x11C5A0
	private Selectable.Transition m_Transition; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0x11C5F0 Offset: 0x11C6F1 VA: 0x11C5F0
	[SerializeField] // RVA: 0x11C5F0 Offset: 0x11C6F1 VA: 0x11C5F0
	private ColorBlock m_Colors; // 0x4C
	[FormerlySerializedAsAttribute] // RVA: 0x11C640 Offset: 0x11C741 VA: 0x11C640
	[SerializeField] // RVA: 0x11C640 Offset: 0x11C741 VA: 0x11C640
	private SpriteState m_SpriteState; // 0xA8
	[FormerlySerializedAsAttribute] // RVA: 0x11C690 Offset: 0x11C791 VA: 0x11C690
	[SerializeField] // RVA: 0x11C690 Offset: 0x11C791 VA: 0x11C690
	private AnimationTriggers m_AnimationTriggers; // 0xC8
	[TooltipAttribute] // RVA: 0x11C6E0 Offset: 0x11C7E1 VA: 0x11C6E0
	[SerializeField] // RVA: 0x11C6E0 Offset: 0x11C7E1 VA: 0x11C6E0
	private bool m_Interactable; // 0xD0
	[FormerlySerializedAsAttribute] // RVA: 0x11C730 Offset: 0x11C831 VA: 0x11C730
	[FormerlySerializedAsAttribute] // RVA: 0x11C730 Offset: 0x11C831 VA: 0x11C730
	[SerializeField] // RVA: 0x11C730 Offset: 0x11C831 VA: 0x11C730
	private Graphic m_TargetGraphic; // 0xD8
	private bool m_GroupsAllowInteraction; // 0xE0
	protected int m_CurrentIndex; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x11C7A0 Offset: 0x11C8A1 VA: 0x11C7A0
	private bool <isPointerInside>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x11C7B0 Offset: 0x11C8B1 VA: 0x11C7B0
	private bool <isPointerDown>k__BackingField; // 0xE9
	[CompilerGeneratedAttribute] // RVA: 0x11C7C0 Offset: 0x11C8C1 VA: 0x11C7C0
	private bool <hasSelection>k__BackingField; // 0xEA
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF0

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] // RVA: 0x11DA40 Offset: 0x11DB41 VA: 0x11DA40
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x18CFBE0 Offset: 0x18CFCE1 VA: 0x18CFBE0
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x18CFC80 Offset: 0x18CFD81 VA: 0x18CFC80
	public static int get_allSelectableCount() { }

	// RVA: 0x18CFCF0 Offset: 0x18CFDF1 VA: 0x18CFCF0
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x18CFE00 Offset: 0x18CFF01 VA: 0x18CFE00
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x18CFF00 Offset: 0x18D0001 VA: 0x18CFF00
	public Navigation get_navigation() { }

	// RVA: 0x18CFF20 Offset: 0x18D0021 VA: 0x18CFF20
	public void set_navigation(Navigation value) { }

	// RVA: 0x18D0090 Offset: 0x18D0191 VA: 0x18D0090
	public Selectable.Transition get_transition() { }

	// RVA: 0x18D00A0 Offset: 0x18D01A1 VA: 0x18D00A0
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x18D0170 Offset: 0x18D0271 VA: 0x18D0170
	public ColorBlock get_colors() { }

	// RVA: 0x18D01C0 Offset: 0x18D02C1 VA: 0x18D01C0
	public void set_colors(ColorBlock value) { }

	// RVA: 0x18D0300 Offset: 0x18D0401 VA: 0x18D0300
	public SpriteState get_spriteState() { }

	// RVA: 0x18D0320 Offset: 0x18D0421 VA: 0x18D0320
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x18D0410 Offset: 0x18D0511 VA: 0x18D0410
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x18D0420 Offset: 0x18D0521 VA: 0x18D0420
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x18D04F0 Offset: 0x18D05F1 VA: 0x18D04F0
	public Graphic get_targetGraphic() { }

	// RVA: 0x18D0500 Offset: 0x18D0601 VA: 0x18D0500
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x18D05D0 Offset: 0x18D06D1 VA: 0x18D05D0
	public bool get_interactable() { }

	// RVA: 0x18D05E0 Offset: 0x18D06E1 VA: 0x18D05E0
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D210 Offset: 0x11D311 VA: 0x11D210
	// RVA: 0x18D07C0 Offset: 0x18D08C1 VA: 0x18D07C0
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D220 Offset: 0x11D321 VA: 0x11D220
	// RVA: 0x18D07D0 Offset: 0x18D08D1 VA: 0x18D07D0
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D230 Offset: 0x11D331 VA: 0x11D230
	// RVA: 0x18D07E0 Offset: 0x18D08E1 VA: 0x18D07E0
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D240 Offset: 0x11D341 VA: 0x11D240
	// RVA: 0x18D07F0 Offset: 0x18D08F1 VA: 0x18D07F0
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D250 Offset: 0x11D351 VA: 0x11D250
	// RVA: 0x18D0800 Offset: 0x18D0901 VA: 0x18D0800
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D260 Offset: 0x11D361 VA: 0x11D260
	// RVA: 0x18D0810 Offset: 0x18D0911 VA: 0x18D0810
	private void set_hasSelection(bool value) { }

	// RVA: 0x18CD700 Offset: 0x18CD801 VA: 0x18CD700
	protected void .ctor() { }

	// RVA: 0x18D0820 Offset: 0x18D0921 VA: 0x18D0820
	public Image get_image() { }

	// RVA: 0x18D08C0 Offset: 0x18D09C1 VA: 0x18D08C0
	public void set_image(Image value) { }

	// RVA: 0x18D08D0 Offset: 0x18D09D1 VA: 0x18D08D0
	public Animator get_animator() { }

	// RVA: 0x18D0920 Offset: 0x18D0A21 VA: 0x18D0920 Slot: 4
	protected override void Awake() { }

	// RVA: 0x18D09E0 Offset: 0x18D0AE1 VA: 0x18D09E0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x18D0C00 Offset: 0x18D0D01 VA: 0x18D0C00 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x18D0C20 Offset: 0x18D0D21 VA: 0x18D0C20 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18CDC80 Offset: 0x18CDD81 VA: 0x18CDC80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18D0D10 Offset: 0x18D0E11 VA: 0x18D0D10 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18D0020 Offset: 0x18D0121 VA: 0x18D0020
	private void OnSetProperty() { }

	// RVA: 0x18CDED0 Offset: 0x18CDFD1 VA: 0x18CDED0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18D0C90 Offset: 0x18D0D91 VA: 0x18D0C90
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x18D0D50 Offset: 0x18D0E51 VA: 0x18D0D50 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x18D1430 Offset: 0x18D1531 VA: 0x18D1430 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x18D16E0 Offset: 0x18D17E1 VA: 0x18D16E0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x18D1B90 Offset: 0x18D1C91 VA: 0x18D1B90
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x18D1DD0 Offset: 0x18D1ED1 VA: 0x18D1DD0
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x18CF200 Offset: 0x18CF301 VA: 0x18CF200 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x18CF370 Offset: 0x18CF471 VA: 0x18CF370 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x18CF4E0 Offset: 0x18CF5E1 VA: 0x18CF4E0 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x18CF650 Offset: 0x18CF751 VA: 0x18CF650 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x18CF130 Offset: 0x18CF231 VA: 0x18CF130 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18D0EA0 Offset: 0x18D0FA1 VA: 0x18D0EA0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x18D0FA0 Offset: 0x18D10A1 VA: 0x18D0FA0
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x18D1130 Offset: 0x18D1231 VA: 0x18D1130
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x18D1EA0 Offset: 0x18D1FA1 VA: 0x18D1EA0
	protected bool IsHighlighted() { }

	// RVA: 0x18D1F40 Offset: 0x18D2041 VA: 0x18D1F40
	protected bool IsPressed() { }

	// RVA: 0x18D1FB0 Offset: 0x18D20B1 VA: 0x18D1FB0
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x18CE9C0 Offset: 0x18CEAC1 VA: 0x18CE9C0 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18CEDE0 Offset: 0x18CEEE1 VA: 0x18CEDE0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18D2060 Offset: 0x18D2161 VA: 0x18D2060 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18D2110 Offset: 0x18D2211 VA: 0x18D2110 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18D21C0 Offset: 0x18D22C1 VA: 0x18D21C0 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18D2270 Offset: 0x18D2371 VA: 0x18D2270 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18D2320 Offset: 0x18D2421 VA: 0x18D2320 Slot: 38
	public virtual void Select() { }

	// RVA: 0x18D2450 Offset: 0x18D2551 VA: 0x18D2450
	private static void .cctor() { }
}

