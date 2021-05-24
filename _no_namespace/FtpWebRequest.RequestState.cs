private enum FtpWebRequest.RequestState // TypeDefIndex: 1972
{
	// Fields
	public int value__; // 0x0
	public const FtpWebRequest.RequestState Before = 0;
	public const FtpWebRequest.RequestState Scheduled = 1;
	public const FtpWebRequest.RequestState Connecting = 2;
	public const FtpWebRequest.RequestState Authenticating = 3;
	public const FtpWebRequest.RequestState OpeningData = 4;
	public const FtpWebRequest.RequestState TransferInProgress = 5;
	public const FtpWebRequest.RequestState Finished = 6;
	public const FtpWebRequest.RequestState Aborted = 7;
	public const FtpWebRequest.RequestState Error = 8;
}

