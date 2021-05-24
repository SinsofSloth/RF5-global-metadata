public static class NpadFullKey // TypeDefIndex: 11567
{
	// Methods

	// RVA: 0x26B24F0 Offset: 0x26B25F1 VA: 0x26B24F0
	public static extern void GetState(ref NpadFullKeyState pOutValue, NpadId npadId) { }

	// RVA: 0x26B1D00 Offset: 0x26B1E01 VA: 0x26B1D00
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x26B2500 Offset: 0x26B2601 VA: 0x26B2500
	public static extern int GetStates([Out] NpadFullKeyState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x26B2070 Offset: 0x26B2171 VA: 0x26B2070
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

