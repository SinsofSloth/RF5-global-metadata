public interface IPanel : IDisposable // TypeDefIndex: 4122
{
	// Properties
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	public abstract FocusController focusController { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement get_visualTree() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ContextType get_contextType() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract FocusController get_focusController() { }
}

