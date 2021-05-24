public static class DebugPad // TypeDefIndex: 11549
{
	// Fields
	public const int StateCountMax = 16;

	// Methods

	// RVA: 0x26B0220 Offset: 0x26B0321 VA: 0x26B0220
	public static void Initialize() { }

	// RVA: 0x26B0230 Offset: 0x26B0331 VA: 0x26B0230
	public static void GetState(ref DebugPadState pOutValue) { }

	// RVA: 0x26B0240 Offset: 0x26B0341 VA: 0x26B0240
	public static int GetStates([Out] DebugPadState[] pOutValues, int count) { }
}

