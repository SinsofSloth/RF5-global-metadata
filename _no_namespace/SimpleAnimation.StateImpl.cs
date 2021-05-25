private class SimpleAnimation.StateImpl : SimpleAnimation.State // TypeDefIndex: 5927
{
	// Fields
	private SimpleAnimationPlayable.IState m_StateHandle; // 0x10
	private SimpleAnimation m_Component; // 0x18

	// Properties
	private bool SimpleAnimation.State.enabled { get; set; }
	private bool SimpleAnimation.State.isValid { get; }
	private float SimpleAnimation.State.time { get; set; }
	private float SimpleAnimation.State.normalizedTime { get; set; }
	private float SimpleAnimation.State.speed { get; set; }
	private string SimpleAnimation.State.name { get; set; }
	private float SimpleAnimation.State.weight { get; set; }
	private float SimpleAnimation.State.length { get; }
	private AnimationClip SimpleAnimation.State.clip { get; }
	private WrapMode SimpleAnimation.State.wrapMode { get; set; }

	// Methods

	// RVA: 0x1B87960 Offset: 0x1B87A61 VA: 0x1B87960
	public void .ctor(SimpleAnimationPlayable.IState handle, SimpleAnimation component) { }

	// RVA: 0x1B89210 Offset: 0x1B89311 VA: 0x1B89210 Slot: 4
	private bool SimpleAnimation.State.get_enabled() { }

	// RVA: 0x1B892D0 Offset: 0x1B893D1 VA: 0x1B892D0 Slot: 5
	private void SimpleAnimation.State.set_enabled(bool value) { }

	// RVA: 0x1B893D0 Offset: 0x1B894D1 VA: 0x1B893D0 Slot: 6
	private bool SimpleAnimation.State.get_isValid() { }

	// RVA: 0x1B89480 Offset: 0x1B89581 VA: 0x1B89480 Slot: 7
	private float SimpleAnimation.State.get_time() { }

	// RVA: 0x1B89540 Offset: 0x1B89641 VA: 0x1B89540 Slot: 8
	private void SimpleAnimation.State.set_time(float value) { }

	// RVA: 0x1B89640 Offset: 0x1B89741 VA: 0x1B89640 Slot: 9
	private float SimpleAnimation.State.get_normalizedTime() { }

	// RVA: 0x1B89700 Offset: 0x1B89801 VA: 0x1B89700 Slot: 10
	private void SimpleAnimation.State.set_normalizedTime(float value) { }

	// RVA: 0x1B89800 Offset: 0x1B89901 VA: 0x1B89800 Slot: 11
	private float SimpleAnimation.State.get_speed() { }

	// RVA: 0x1B898C0 Offset: 0x1B899C1 VA: 0x1B898C0 Slot: 12
	private void SimpleAnimation.State.set_speed(float value) { }

	// RVA: 0x1B899C0 Offset: 0x1B89AC1 VA: 0x1B899C0 Slot: 13
	private string SimpleAnimation.State.get_name() { }

	// RVA: 0x1B89A80 Offset: 0x1B89B81 VA: 0x1B89A80 Slot: 14
	private void SimpleAnimation.State.set_name(string value) { }

	// RVA: 0x1B89B50 Offset: 0x1B89C51 VA: 0x1B89B50 Slot: 15
	private float SimpleAnimation.State.get_weight() { }

	// RVA: 0x1B89C10 Offset: 0x1B89D11 VA: 0x1B89C10 Slot: 16
	private void SimpleAnimation.State.set_weight(float value) { }

	// RVA: 0x1B89D10 Offset: 0x1B89E11 VA: 0x1B89D10 Slot: 17
	private float SimpleAnimation.State.get_length() { }

	// RVA: 0x1B89DD0 Offset: 0x1B89ED1 VA: 0x1B89DD0 Slot: 18
	private AnimationClip SimpleAnimation.State.get_clip() { }

	// RVA: 0x1B89E90 Offset: 0x1B89F91 VA: 0x1B89E90 Slot: 19
	private WrapMode SimpleAnimation.State.get_wrapMode() { }

	// RVA: 0x1B89F50 Offset: 0x1B8A051 VA: 0x1B89F50 Slot: 20
	private void SimpleAnimation.State.set_wrapMode(WrapMode value) { }
}

