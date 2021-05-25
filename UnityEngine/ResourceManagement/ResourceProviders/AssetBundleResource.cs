internal class AssetBundleResource : IAssetBundleResource // TypeDefIndex: 4478
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private DownloadHandlerAssetBundle m_downloadHandler; // 0x18
	private AsyncOperation m_RequestOperation; // 0x20
	private WebRequestQueueOperation m_WebRequestQueueOperation; // 0x28
	internal ProvideHandle m_ProvideHandle; // 0x30
	internal AssetBundleRequestOptions m_Options; // 0x48
	private int m_Retries; // 0x50
	private long m_BytesToDownload; // 0x58

	// Methods

	// RVA: 0x19DE0A0 Offset: 0x19DE1A1 VA: 0x19DE0A0
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	// RVA: 0x19DE210 Offset: 0x19DE311 VA: 0x19DE210
	private float PercentComplete() { }

	// RVA: 0x19DE230 Offset: 0x19DE331 VA: 0x19DE230
	private DownloadStatus GetDownloadStatus() { }

	// RVA: 0x19DE340 Offset: 0x19DE441 VA: 0x19DE340 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x19DD800 Offset: 0x19DD901 VA: 0x19DD800
	internal void Start(ProvideHandle provideHandle) { }

	// RVA: 0x19DE670 Offset: 0x19DE771 VA: 0x19DE670
	private void BeginOperation() { }

	// RVA: 0x19DEC00 Offset: 0x19DED01 VA: 0x19DEC00
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x19DED00 Offset: 0x19DEE01 VA: 0x19DED00
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x19DDC40 Offset: 0x19DDD41 VA: 0x19DDC40
	public void Unload() { }

	// RVA: 0x19DD7F0 Offset: 0x19DD8F1 VA: 0x19DD7F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A270 Offset: 0x12A371 VA: 0x12A270
	// RVA: 0x19DF140 Offset: 0x19DF241 VA: 0x19DF140
	private void <BeginOperation>b__13_0(UnityWebRequestAsyncOperation asyncOp) { }
}

