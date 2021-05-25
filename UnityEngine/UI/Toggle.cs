[AddComponentMenu] // RVA: 0x11A760 Offset: 0x11A861 VA: 0x11A760
[RequireComponent] // RVA: 0x11A760 Offset: 0x11A861 VA: 0x11A760
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 4014
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0xF8
	public Graphic graphic; // 0x100
	[SerializeField] // RVA: 0x11C980 Offset: 0x11CA81 VA: 0x11C980
	private ToggleGroup m_Group; // 0x108
	public Toggle.ToggleEvent onValueChanged; // 0x110
	[TooltipAttribute] // RVA: 0x11C990 Offset: 0x11CA91 VA: 0x11C990
	[SerializeField] // RVA: 0x11C990 Offset: 0x11CA91 VA: 0x11C990
	private bool m_IsOn; // 0x118

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x1B83110 Offset: 0x1B83211 VA: 0x1B83110
	public ToggleGroup get_group() { }

	// RVA: 0x1B83120 Offset: 0x1B83221 VA: 0x1B83120
	public void set_group(ToggleGroup value) { }

	// RVA: 0x1B83500 Offset: 0x1B83601 VA: 0x1B83500
	protected void .ctor() { }

	// RVA: 0x1B83620 Offset: 0x1B83721 VA: 0x1B83620 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1B83630 Offset: 0x1B83731 VA: 0x1B83630 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x1B83640 Offset: 0x1B83741 VA: 0x1B83640 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1B83650 Offset: 0x1B83751 VA: 0x1B83650 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1B837A0 Offset: 0x1B838A1 VA: 0x1B837A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B83870 Offset: 0x1B83971 VA: 0x1B83870 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B838A0 Offset: 0x1B839A1 VA: 0x1B838A0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1B831F0 Offset: 0x1B832F1 VA: 0x1B831F0
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x1B83E20 Offset: 0x1B83F21 VA: 0x1B83E20
	public bool get_isOn() { }

	// RVA: 0x1B83E30 Offset: 0x1B83F31 VA: 0x1B83E30
	public void set_isOn(bool value) { }

	// RVA: 0x1B83E40 Offset: 0x1B83F41 VA: 0x1B83E40
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x1B839B0 Offset: 0x1B83AB1 VA: 0x1B839B0
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x1B83420 Offset: 0x1B83521 VA: 0x1B83420
	private void PlayEffect(bool instant) { }

	// RVA: 0x1B83FA0 Offset: 0x1B840A1 VA: 0x1B83FA0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1B84060 Offset: 0x1B84161 VA: 0x1B84060
	private void InternalToggle() { }

	// RVA: 0x1B840D0 Offset: 0x1B841D1 VA: 0x1B840D0 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1B84150 Offset: 0x1B84251 VA: 0x1B84150 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1B841C0 Offset: 0x1B842C1 VA: 0x1B841C0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

