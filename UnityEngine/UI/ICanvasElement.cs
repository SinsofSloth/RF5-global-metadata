public interface ICanvasElement // TypeDefIndex: 3907
{
	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed() { }
}

