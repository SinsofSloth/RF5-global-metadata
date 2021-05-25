public interface IMouseEvent // TypeDefIndex: 4191
{
	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract int clickCount { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventModifiers get_modifiers() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_mousePosition() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2 get_mouseDelta() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_clickCount() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_button() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_pressedButtons() { }
}

