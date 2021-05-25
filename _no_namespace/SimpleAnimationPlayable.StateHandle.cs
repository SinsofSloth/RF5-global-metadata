public class SimpleAnimationPlayable.StateHandle : SimpleAnimationPlayable.IState // TypeDefIndex: 5933
{
	// Fields
	private SimpleAnimationPlayable m_Parent; // 0x10
	private int m_Index; // 0x18
	private Playable m_Target; // 0x20

	// Properties
	public bool enabled { get; set; }
	public float time { get; set; }
	public float normalizedTime { get; set; }
	public float speed { get; set; }
	public string name { get; set; }
	public float weight { get; set; }
	public float length { get; }
	public AnimationClip clip { get; }
	public WrapMode wrapMode { get; }
	public int index { get; }

	// Methods

	// RVA: 0x1B8A840 Offset: 0x1B8A941 VA: 0x1B8A840
	public void .ctor(SimpleAnimationPlayable s, int index, Playable target) { }

	// RVA: 0x1B8DCD0 Offset: 0x1B8DDD1 VA: 0x1B8DCD0 Slot: 4
	public bool IsValid() { }

	// RVA: 0x1B8DD00 Offset: 0x1B8DE01 VA: 0x1B8DD00 Slot: 5
	public bool get_enabled() { }

	// RVA: 0x1B8DE10 Offset: 0x1B8DF11 VA: 0x1B8DE10 Slot: 6
	public void set_enabled(bool value) { }

	// RVA: 0x1B8E040 Offset: 0x1B8E141 VA: 0x1B8E040 Slot: 7
	public float get_time() { }

	// RVA: 0x1B8E0F0 Offset: 0x1B8E1F1 VA: 0x1B8E0F0 Slot: 8
	public void set_time(float value) { }

	// RVA: 0x1B8E210 Offset: 0x1B8E311 VA: 0x1B8E210 Slot: 9
	public float get_normalizedTime() { }

	// RVA: 0x1B8E3D0 Offset: 0x1B8E4D1 VA: 0x1B8E3D0 Slot: 10
	public void set_normalizedTime(float value) { }

	// RVA: 0x1B8E510 Offset: 0x1B8E611 VA: 0x1B8E510 Slot: 11
	public float get_speed() { }

	// RVA: 0x1B8E680 Offset: 0x1B8E781 VA: 0x1B8E680 Slot: 12
	public void set_speed(float value) { }

	// RVA: 0x1B8E800 Offset: 0x1B8E901 VA: 0x1B8E800 Slot: 13
	public string get_name() { }

	// RVA: 0x1B8E990 Offset: 0x1B8EA91 VA: 0x1B8E990 Slot: 14
	public void set_name(string value) { }

	// RVA: 0x1B8EB60 Offset: 0x1B8EC61 VA: 0x1B8EB60 Slot: 15
	public float get_weight() { }

	// RVA: 0x1B8EC70 Offset: 0x1B8ED71 VA: 0x1B8EC70 Slot: 16
	public void set_weight(float value) { }

	// RVA: 0x1B8EE60 Offset: 0x1B8EF61 VA: 0x1B8EE60 Slot: 17
	public float get_length() { }

	// RVA: 0x1B8F070 Offset: 0x1B8F171 VA: 0x1B8F070 Slot: 18
	public AnimationClip get_clip() { }

	// RVA: 0x1B8F200 Offset: 0x1B8F301 VA: 0x1B8F200 Slot: 19
	public WrapMode get_wrapMode() { }

	// RVA: 0x1B8F390 Offset: 0x1B8F491 VA: 0x1B8F390
	public int get_index() { }
}

