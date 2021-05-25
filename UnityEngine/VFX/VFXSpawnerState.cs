[NativeTypeAttribute] // RVA: 0x1226F0 Offset: 0x1227F1 VA: 0x1226F0
[RequiredByNativeCodeAttribute] // RVA: 0x1226F0 Offset: 0x1227F1 VA: 0x1226F0
public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 4262
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18

	// Methods

	// RVA: 0x1BE1A80 Offset: 0x1BE1B81 VA: 0x1BE1A80
	internal void .ctor(IntPtr ptr, bool owner) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x122950 Offset: 0x122A51 VA: 0x122950
	// RVA: 0x1BE1AC0 Offset: 0x1BE1BC1 VA: 0x1BE1AC0
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x122960 Offset: 0x122A61 VA: 0x122960
	// RVA: 0x1BE1B30 Offset: 0x1BE1C31 VA: 0x1BE1B30
	internal void SetWrapValue(IntPtr ptr) { }

	// RVA: 0x1BE1BD0 Offset: 0x1BE1CD1 VA: 0x1BE1BD0
	private void Release() { }

	// RVA: 0x1BE1CC0 Offset: 0x1BE1DC1 VA: 0x1BE1CC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BE1DA0 Offset: 0x1BE1EA1 VA: 0x1BE1DA0 Slot: 4
	public void Dispose() { }

	[NativeMethodAttribute] // RVA: 0x122970 Offset: 0x122A71 VA: 0x122970
	// RVA: 0x1BE1C70 Offset: 0x1BE1D71 VA: 0x1BE1C70
	private static void Internal_Destroy(IntPtr ptr) { }
}

