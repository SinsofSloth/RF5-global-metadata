public interface IBaseKeyframe // TypeDefIndex: 9650
{
	// Properties
	public abstract string id { get; }
	public abstract float time { get; set; }
	public abstract InterpolationCurve interpolationCurve { get; set; }
	public abstract InterpolationDirection interpolationDirection { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_id() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_time() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_time(float value) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract InterpolationCurve get_interpolationCurve() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_interpolationCurve(InterpolationCurve value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract InterpolationDirection get_interpolationDirection() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_interpolationDirection(InterpolationDirection value) { }
}

