[NativeHeaderAttribute] // RVA: 0x104BC0 Offset: 0x104CC1 VA: 0x104BC0
public class UnityWebRequest : IDisposable // TypeDefIndex: 3708
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGeneratedAttribute] // RVA: 0x104D80 Offset: 0x104E81 VA: 0x104D80
	[DebuggerBrowsableAttribute] // RVA: 0x104D80 Offset: 0x104E81 VA: 0x104D80
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x104DC0 Offset: 0x104EC1 VA: 0x104DC0
	[DebuggerBrowsableAttribute] // RVA: 0x104DC0 Offset: 0x104EC1 VA: 0x104DC0
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x104E00 Offset: 0x104F01 VA: 0x104E00
	[DebuggerBrowsableAttribute] // RVA: 0x104E00 Offset: 0x104F01 VA: 0x104E00
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public float uploadProgress { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public bool isNetworkError { get; }
	public bool isHttpError { get; }
	public ulong downloadedBytes { get; }
	public int redirectLimit { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x104E80 Offset: 0x104F81 VA: 0x104E80
	[NativeConditionalAttribute] // RVA: 0x104E80 Offset: 0x104F81 VA: 0x104E80
	// RVA: 0x1BBB9E0 Offset: 0x1BBBAE1 VA: 0x1BBB9E0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x104EE0 Offset: 0x104FE1 VA: 0x104EE0
	// RVA: 0x1BBBA30 Offset: 0x1BBBB31 VA: 0x1BBBA30
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x104EF0 Offset: 0x104FF1 VA: 0x104EF0
	// RVA: 0x1BBBA80 Offset: 0x1BBBB81 VA: 0x1BBBA80
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x104F00 Offset: 0x105001 VA: 0x104F00
	// RVA: 0x1BBBA90 Offset: 0x1BBBB91 VA: 0x1BBBA90
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x104F10 Offset: 0x105011 VA: 0x104F10
	// RVA: 0x1BBBAA0 Offset: 0x1BBBBA1 VA: 0x1BBBAA0
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x104F20 Offset: 0x105021 VA: 0x104F20
	// RVA: 0x1BBBAB0 Offset: 0x1BBBBB1 VA: 0x1BBBAB0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x104F30 Offset: 0x105031 VA: 0x104F30
	// RVA: 0x1BBBAC0 Offset: 0x1BBBBC1 VA: 0x1BBBAC0
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x104F40 Offset: 0x105041 VA: 0x104F40
	// RVA: 0x1BBBAD0 Offset: 0x1BBBBD1 VA: 0x1BBBAD0
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x1BBBAE0 Offset: 0x1BBBBE1 VA: 0x1BBBAE0
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x104F50 Offset: 0x105051 VA: 0x104F50
	// RVA: 0x1BBBB20 Offset: 0x1BBBC21 VA: 0x1BBBB20
	private void Release() { }

	// RVA: 0x1BBBB70 Offset: 0x1BBBC71 VA: 0x1BBBB70
	internal void InternalDestroy() { }

	// RVA: 0x1BBBC70 Offset: 0x1BBBD71 VA: 0x1BBBC70
	private void InternalSetDefaults() { }

	// RVA: 0x1BBBC90 Offset: 0x1BBBD91 VA: 0x1BBBC90
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x1BBC260 Offset: 0x1BBC361 VA: 0x1BBC260 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BBC4E0 Offset: 0x1BBC5E1 VA: 0x1BBC4E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BBC360 Offset: 0x1BBC461 VA: 0x1BBC360
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x104F90 Offset: 0x105091 VA: 0x104F90
	// RVA: 0x1BBC690 Offset: 0x1BBC791 VA: 0x1BBC690
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x1BBC6E0 Offset: 0x1BBC7E1 VA: 0x1BBC6E0
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x104FA0 Offset: 0x1050A1 VA: 0x104FA0
	// RVA: 0x1BBBC20 Offset: 0x1BBBD21 VA: 0x1BBBC20
	public void Abort() { }

	// RVA: 0x1BBC760 Offset: 0x1BBC861 VA: 0x1BBC760
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1BBC7B0 Offset: 0x1BBC8B1 VA: 0x1BBC7B0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1BBC940 Offset: 0x1BBCA41 VA: 0x1BBC940
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x1BBC990 Offset: 0x1BBCA91 VA: 0x1BBC990
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x1BBBE30 Offset: 0x1BBBF31 VA: 0x1BBBE30
	public void set_method(string value) { }

	// RVA: 0x1BBCAD0 Offset: 0x1BBCBD1 VA: 0x1BBCAD0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x1BBCB20 Offset: 0x1BBCC21 VA: 0x1BBCB20
	public string get_error() { }

	// RVA: 0x1BBCE40 Offset: 0x1BBCF41 VA: 0x1BBCE40
	public string get_url() { }

	// RVA: 0x1BBBDA0 Offset: 0x1BBBEA1 VA: 0x1BBBDA0
	public void set_url(string value) { }

	// RVA: 0x1BBCE90 Offset: 0x1BBCF91 VA: 0x1BBCE90
	private string GetUrl() { }

	// RVA: 0x1BBD400 Offset: 0x1BBD501 VA: 0x1BBD400
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x1BBD2C0 Offset: 0x1BBD3C1 VA: 0x1BBD2C0
	private void InternalSetUrl(string url) { }

	// RVA: 0x1BBCDF0 Offset: 0x1BBCEF1 VA: 0x1BBCDF0
	public long get_responseCode() { }

	// RVA: 0x1BBD450 Offset: 0x1BBD551 VA: 0x1BBD450
	private float GetUploadProgress() { }

	// RVA: 0x1BBD4A0 Offset: 0x1BBD5A1 VA: 0x1BBD4A0
	private bool IsExecuting() { }

	// RVA: 0x1BBD4F0 Offset: 0x1BBD5F1 VA: 0x1BBD4F0
	public float get_uploadProgress() { }

	[NativeMethodAttribute] // RVA: 0x104FE0 Offset: 0x1050E1 VA: 0x104FE0
	// RVA: 0x1BBC8F0 Offset: 0x1BBC9F1 VA: 0x1BBC8F0
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x105020 Offset: 0x105121 VA: 0x105020
	// RVA: 0x1BBD5D0 Offset: 0x1BBD6D1 VA: 0x1BBD5D0
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x105060 Offset: 0x105161 VA: 0x105060
	// RVA: 0x1BBCD50 Offset: 0x1BBCE51 VA: 0x1BBCD50
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x1050A0 Offset: 0x1051A1 VA: 0x1050A0
	// RVA: 0x1BBCDA0 Offset: 0x1BBCEA1 VA: 0x1BBCDA0
	public bool get_isHttpError() { }

	// RVA: 0x1BBD620 Offset: 0x1BBD721 VA: 0x1BBD620
	public ulong get_downloadedBytes() { }

	[NativeThrowsAttribute] // RVA: 0x1050E0 Offset: 0x1051E1 VA: 0x1050E0
	// RVA: 0x1BBD670 Offset: 0x1BBD771 VA: 0x1BBD670
	private void SetRedirectLimitFromScripting(int limit) { }

	// RVA: 0x1BBD6C0 Offset: 0x1BBD7C1 VA: 0x1BBD6C0
	public void set_redirectLimit(int value) { }

	[NativeMethodAttribute] // RVA: 0x1050F0 Offset: 0x1051F1 VA: 0x1050F0
	// RVA: 0x1BBD710 Offset: 0x1BBD811 VA: 0x1BBD710
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x1BBD770 Offset: 0x1BBD871 VA: 0x1BBD770
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x1BBD900 Offset: 0x1BBDA01 VA: 0x1BBD900
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1BBC5F0 Offset: 0x1BBC6F1 VA: 0x1BBC5F0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x1BBC110 Offset: 0x1BBC211 VA: 0x1BBC110
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x1BBD950 Offset: 0x1BBDA51 VA: 0x1BBD950
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1BBC5E0 Offset: 0x1BBC6E1 VA: 0x1BBC5E0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x1BBBFC0 Offset: 0x1BBC0C1 VA: 0x1BBBFC0
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x1BBD9A0 Offset: 0x1BBDAA1 VA: 0x1BBD9A0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x1BBC680 Offset: 0x1BBC781 VA: 0x1BBC680
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x1BBD9F0 Offset: 0x1BBDAF1 VA: 0x1BBD9F0
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x1BBDB40 Offset: 0x1BBDC41 VA: 0x1BBDB40
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x1BBDB90 Offset: 0x1BBDC91 VA: 0x1BBDB90
	public void set_timeout(int value) { }
}

