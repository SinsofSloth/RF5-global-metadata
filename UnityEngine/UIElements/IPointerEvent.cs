public interface IPointerEvent // TypeDefIndex: 4212
{
	// Properties
	public abstract int pointerId { get; }
	public abstract string pointerType { get; }
	public abstract bool isPrimary { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }
	public abstract Vector3 position { get; }
	public abstract Vector3 localPosition { get; }
	public abstract Vector3 deltaPosition { get; }
	public abstract float deltaTime { get; }
	public abstract int clickCount { get; }
	public abstract float pressure { get; }
	public abstract float tangentialPressure { get; }
	public abstract float altitudeAngle { get; }
	public abstract float azimuthAngle { get; }
	public abstract float twist { get; }
	public abstract Vector2 radius { get; }
	public abstract Vector2 radiusVariance { get; }
	public abstract EventModifiers modifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_pointerId() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_pointerType() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isPrimary() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_button() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_pressedButtons() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector3 get_position() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector3 get_localPosition() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector3 get_deltaPosition() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_clickCount() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_pressure() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_tangentialPressure() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_altitudeAngle() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_azimuthAngle() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_twist() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Vector2 get_radius() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector2 get_radiusVariance() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract EventModifiers get_modifiers() { }
}

