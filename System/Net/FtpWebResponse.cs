public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

public class FtpWebResponse : WebResponse // TypeDefIndex: 1973
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x17850B0 Offset: 0x17851B1 VA: 0x17850B0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x17845C0 Offset: 0x17846C1 VA: 0x17845C0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1788630 Offset: 0x1788731 VA: 0x1788630
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1789310 Offset: 0x1789411 VA: 0x1789310 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1789370 Offset: 0x1789471 VA: 0x1789370
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1789380 Offset: 0x1789481 VA: 0x1789380
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1789390 Offset: 0x1789491 VA: 0x1789390
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x17893A0 Offset: 0x17894A1 VA: 0x17893A0
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x17893B0 Offset: 0x17894B1 VA: 0x17893B0 Slot: 9
	public override void Close() { }

	// RVA: 0x17894C0 Offset: 0x17895C1 VA: 0x17894C0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1789640 Offset: 0x1789741 VA: 0x1789640
	internal void set_Stream(Stream value) { }

	// RVA: 0x1784DB0 Offset: 0x1784EB1 VA: 0x1784DB0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1789590 Offset: 0x1789691 VA: 0x1789590
	private void CheckDisposed() { }

	// RVA: 0x1785AE0 Offset: 0x1785BE1 VA: 0x1785AE0
	internal bool IsFinal() { }
}

