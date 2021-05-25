internal class PropagationPaths // TypeDefIndex: 4223
{
	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0x15C8B80 Offset: 0x15C8C81 VA: 0x15C8B80
	public void .ctor() { }

	// RVA: 0x15BB6F0 Offset: 0x15BB7F1 VA: 0x15BB6F0
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0x15BB420 Offset: 0x15BB521 VA: 0x15BB420
	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	// RVA: 0x15BBE60 Offset: 0x15BBF61 VA: 0x15BBE60
	public void Release() { }

	// RVA: 0x15C8C60 Offset: 0x15C8D61 VA: 0x15C8C60
	private static void .cctor() { }
}

