public class BaseEventData : AbstractEventData // TypeDefIndex: 4047
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x1637540 Offset: 0x1637641 VA: 0x1637540
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1637580 Offset: 0x1637681 VA: 0x1637580
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x16375A0 Offset: 0x16376A1 VA: 0x16375A0
	public GameObject get_selectedObject() { }

	// RVA: 0x16375C0 Offset: 0x16376C1 VA: 0x16375C0
	public void set_selectedObject(GameObject value) { }
}

