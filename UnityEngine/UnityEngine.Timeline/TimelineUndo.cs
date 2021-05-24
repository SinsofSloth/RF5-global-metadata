internal static class TimelineUndo // TypeDefIndex: 4640
{
	// Methods

	// RVA: 0x1B3E3D0 Offset: 0x1B3E4D1 VA: 0x1B3E3D0
	public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy) { }

	[ConditionalAttribute] // RVA: 0x12C400 Offset: 0x12C501 VA: 0x12C400
	// RVA: 0x1B3E470 Offset: 0x1B3E571 VA: 0x1B3E470
	public static void PushUndo(Object[] thingsToDirty, string operation) { }

	[ConditionalAttribute] // RVA: 0x12C440 Offset: 0x12C541 VA: 0x12C440
	// RVA: 0x1B3E480 Offset: 0x1B3E581 VA: 0x1B3E480
	public static void PushUndo(Object thingToDirty, string operation) { }

	[ConditionalAttribute] // RVA: 0x12C480 Offset: 0x12C581 VA: 0x12C480
	// RVA: 0x1B3E490 Offset: 0x1B3E591 VA: 0x1B3E490
	public static void RegisterCreatedObjectUndo(Object thingCreated, string operation) { }

	// RVA: 0x1B3E4A0 Offset: 0x1B3E5A1 VA: 0x1B3E4A0
	private static string UndoName(string name) { }
}

