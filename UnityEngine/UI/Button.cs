[AddComponentMenu] // RVA: 0x119BE0 Offset: 0x119CE1 VA: 0x119BE0
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 3903
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x11AF70 Offset: 0x11B071 VA: 0x11AF70
	[SerializeField] // RVA: 0x11AF70 Offset: 0x11B071 VA: 0x11AF70
	private Button.ButtonClickedEvent m_OnClick; // 0xF8

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x1645F90 Offset: 0x1646091 VA: 0x1645F90
	protected void .ctor() { }

	// RVA: 0x1646040 Offset: 0x1646141 VA: 0x1646040
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x1646050 Offset: 0x1646151 VA: 0x1646050
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x1646060 Offset: 0x1646161 VA: 0x1646060
	private void Press() { }

	// RVA: 0x1646100 Offset: 0x1646201 VA: 0x1646100 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x16461B0 Offset: 0x16462B1 VA: 0x16461B0 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x11CDD0 Offset: 0x11CED1 VA: 0x11CDD0
	// RVA: 0x1646300 Offset: 0x1646401 VA: 0x1646300
	private IEnumerator OnFinishSubmit() { }
}

