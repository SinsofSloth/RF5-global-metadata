[NativeHeaderAttribute] // RVA: 0xC8860 Offset: 0xC8961 VA: 0xC8860
[NativeHeaderAttribute] // RVA: 0xC8860 Offset: 0xC8961 VA: 0xC8860
[RequiredByNativeCodeAttribute] // RVA: 0xC8860 Offset: 0xC8961 VA: 0xC8860
public class BatchRendererGroup // TypeDefIndex: 3313
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD9AA0 Offset: 0xD9BA1 VA: 0xD9AA0
	// RVA: 0x2A1CE70 Offset: 0x2A1CF71 VA: 0x2A1CE70
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }
}

