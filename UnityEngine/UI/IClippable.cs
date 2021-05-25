public interface IClippable // TypeDefIndex: 3913
{
	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetClipSoftness(Vector2 clipSoftness) { }
}

