public interface ILayoutElement // TypeDefIndex: 3969
{
	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority() { }
}

