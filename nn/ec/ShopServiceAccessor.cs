public sealed class ShopServiceAccessor : IDisposable // TypeDefIndex: 11699
{
	// Fields
	private IntPtr _shopServiceAccessor; // 0x10
	private bool isDisposed; // 0x18

	// Properties
	public static ErrorRange ResultShopServiceAccessError { get; }
	public static ErrorRange ResultShopServiceAccessCanceled { get; }
	public static ErrorRange ResultShopServiceAccessInsufficientBuffer { get; }
	public static ErrorRange ResultShopServiceAccessInsufficientWorkMemory { get; }
	public static ErrorRange ResultShopServiceAccessInvalidCharacter { get; }
	public static ErrorRange ResultShopServiceAccessOverRequest { get; }
	public static ErrorRange ResultShopServiceAccessRequestTimeout { get; }
	public static ErrorRange ResultShowErrorCodeRequired { get; }
	public static ErrorRange ResultInternetRequestNotAccepted { get; }
	public static ErrorRange ResultInsufficientWorkMemory { get; }
	internal IntPtr Ptr { get; }
	public static TimeSpan DefaultTimeout { get; }

	// Methods

	// RVA: 0x26A8820 Offset: 0x26A8921 VA: 0x26A8820
	public static ErrorRange get_ResultShopServiceAccessError() { }

	// RVA: 0x26A8830 Offset: 0x26A8931 VA: 0x26A8830
	public static ErrorRange get_ResultShopServiceAccessCanceled() { }

	// RVA: 0x26A8840 Offset: 0x26A8941 VA: 0x26A8840
	public static ErrorRange get_ResultShopServiceAccessInsufficientBuffer() { }

	// RVA: 0x26A8850 Offset: 0x26A8951 VA: 0x26A8850
	public static ErrorRange get_ResultShopServiceAccessInsufficientWorkMemory() { }

	// RVA: 0x26A8860 Offset: 0x26A8961 VA: 0x26A8860
	public static ErrorRange get_ResultShopServiceAccessInvalidCharacter() { }

	// RVA: 0x26A8870 Offset: 0x26A8971 VA: 0x26A8870
	public static ErrorRange get_ResultShopServiceAccessOverRequest() { }

	// RVA: 0x26A8880 Offset: 0x26A8981 VA: 0x26A8880
	public static ErrorRange get_ResultShopServiceAccessRequestTimeout() { }

	// RVA: 0x26A8890 Offset: 0x26A8991 VA: 0x26A8890
	public static ErrorRange get_ResultShowErrorCodeRequired() { }

	// RVA: 0x26A88A0 Offset: 0x26A89A1 VA: 0x26A88A0
	public static ErrorRange get_ResultInternetRequestNotAccepted() { }

	// RVA: 0x26A88B0 Offset: 0x26A89B1 VA: 0x26A88B0
	public static ErrorRange get_ResultInsufficientWorkMemory() { }

	// RVA: 0x26A88C0 Offset: 0x26A89C1 VA: 0x26A88C0
	internal IntPtr get_Ptr() { }

	// RVA: 0x26A88D0 Offset: 0x26A89D1 VA: 0x26A88D0
	public static TimeSpan get_DefaultTimeout() { }

	// RVA: 0x26A8910 Offset: 0x26A8A11 VA: 0x26A8910
	public static extern Result InitializeForShopServiceAccessors() { }

	// RVA: 0x26A8930 Offset: 0x26A8A31 VA: 0x26A8930
	public static extern Result FinalizeForShopServiceAccessors() { }

	// RVA: 0x26A8950 Offset: 0x26A8A51 VA: 0x26A8950
	public void .ctor() { }

	// RVA: 0x26A89C0 Offset: 0x26A8AC1 VA: 0x26A89C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A8B10 Offset: 0x26A8C11 VA: 0x26A8B10
	public Result Initialize(ShopService targetType) { }

	// RVA: 0x26A8B50 Offset: 0x26A8C51 VA: 0x26A8B50
	public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, TimeSpan timeout) { }

	// RVA: 0x26A8CC0 Offset: 0x26A8DC1 VA: 0x26A8CC0
	public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, TimeSpan timeout) { }

	// RVA: 0x26A8DF0 Offset: 0x26A8EF1 VA: 0x26A8DF0
	public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData) { }

	// RVA: 0x26A8EA0 Offset: 0x26A8FA1 VA: 0x26A8EA0
	public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath) { }

	// RVA: 0x26A8FA0 Offset: 0x26A90A1 VA: 0x26A8FA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A8A80 Offset: 0x26A8B81 VA: 0x26A8A80
	private void _Dispose() { }

	// RVA: 0x26A8B30 Offset: 0x26A8C31 VA: 0x26A8B30
	private static extern Result Initialize(IntPtr shopServiceAccessor, ShopService target) { }

	// RVA: 0x26A9080 Offset: 0x26A9181 VA: 0x26A9080
	private static extern Result Finalize(IntPtr shopServiceAccessor) { }

	// RVA: 0x26A8C20 Offset: 0x26A8D21 VA: 0x26A8C20
	private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, long timeoutMilliseconds) { }

	// RVA: 0x26A8D60 Offset: 0x26A8E61 VA: 0x26A8D60
	private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, long timeoutMilliseconds) { }

	// RVA: 0x26A90B0 Offset: 0x26A91B1 VA: 0x26A90B0
	private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData) { }

	// RVA: 0x26A8F20 Offset: 0x26A9021 VA: 0x26A8F20
	private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath) { }

	// RVA: 0x26A89B0 Offset: 0x26A8AB1 VA: 0x26A89B0
	private static extern void New(ref IntPtr shopServiceAccessor) { }

	// RVA: 0x26A90A0 Offset: 0x26A91A1 VA: 0x26A90A0
	private static extern void Delete(IntPtr shopServiceAccessor) { }
}

