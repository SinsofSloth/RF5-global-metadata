public interface SimpleAnimation.State // TypeDefIndex: 5924
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract bool isValid { get; }
	public abstract float time { get; set; }
	public abstract float normalizedTime { get; set; }
	public abstract float speed { get; set; }
	public abstract string name { get; set; }
	public abstract float weight { get; set; }
	public abstract float length { get; }
	public abstract AnimationClip clip { get; }
	public abstract WrapMode wrapMode { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isValid() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_time() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_time(float value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_normalizedTime() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_normalizedTime(float value) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_speed() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_speed(float value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_name() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_name(string value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_weight() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_weight(float value) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_length() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract AnimationClip get_clip() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract WrapMode get_wrapMode() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_wrapMode(WrapMode value) { }
}

