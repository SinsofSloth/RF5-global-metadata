public class BaseInput : UIBehaviour // TypeDefIndex: 4078
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x1637800 Offset: 0x1637901 VA: 0x1637800 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x1637810 Offset: 0x1637911 VA: 0x1637810 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1637820 Offset: 0x1637921 VA: 0x1637820 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1637830 Offset: 0x1637931 VA: 0x1637830 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x1637840 Offset: 0x1637941 VA: 0x1637840 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1637850 Offset: 0x1637951 VA: 0x1637850 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x1637860 Offset: 0x1637961 VA: 0x1637860 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x1637870 Offset: 0x1637971 VA: 0x1637870 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x1637880 Offset: 0x1637981 VA: 0x1637880 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x1637890 Offset: 0x1637991 VA: 0x1637890 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x16378A0 Offset: 0x16379A1 VA: 0x16378A0 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x16378B0 Offset: 0x16379B1 VA: 0x16378B0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x16378C0 Offset: 0x16379C1 VA: 0x16378C0 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x16378D0 Offset: 0x16379D1 VA: 0x16378D0 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x16378E0 Offset: 0x16379E1 VA: 0x16378E0 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x16378F0 Offset: 0x16379F1 VA: 0x16378F0 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x1637900 Offset: 0x1637A01 VA: 0x1637900
	public void .ctor() { }
}

