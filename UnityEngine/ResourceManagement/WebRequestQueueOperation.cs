internal class WebRequestQueueOperation // TypeDefIndex: 4458
{
	// Fields
	public UnityWebRequestAsyncOperation Result; // 0x10
	public Action<UnityWebRequestAsyncOperation> OnComplete; // 0x18
	internal UnityWebRequest m_WebRequest; // 0x20

	// Properties
	public bool IsDone { get; }

	// Methods

	// RVA: 0x19DEBF0 Offset: 0x19DECF1 VA: 0x19DEBF0
	public bool get_IsDone() { }

	// RVA: 0x19E5C70 Offset: 0x19E5D71 VA: 0x19E5C70
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x19E5CB0 Offset: 0x19E5DB1 VA: 0x19E5CB0
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }
}

