[EditorBrowsableAttribute] // RVA: 0xBBE80 Offset: 0xBBF81 VA: 0xBBE80
public abstract class RegexRunner // TypeDefIndex: 1791
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int timeout; // 0x70
	private bool ignoreTimeout; // 0x74
	private int timeoutOccursAt; // 0x78
	private int timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x1618410 Offset: 0x1618511 VA: 0x1618410
	protected internal void .ctor() { }

	// RVA: 0x1625890 Offset: 0x1625991 VA: 0x1625890
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x1625C60 Offset: 0x1625D61 VA: 0x1625C60
	private void StartTimeoutWatch() { }

	// RVA: 0x161B590 Offset: 0x161B691 VA: 0x161B590
	protected void CheckTimeout() { }

	// RVA: 0x1625F50 Offset: 0x1626051 VA: 0x1625F50
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount() { }

	// RVA: 0x1625CB0 Offset: 0x1625DB1 VA: 0x1625CB0
	private void InitMatch() { }

	// RVA: 0x1625EE0 Offset: 0x1625FE1 VA: 0x1625EE0
	private Match TidyMatch(bool quick) { }

	// RVA: 0x16185F0 Offset: 0x16186F1 VA: 0x16185F0
	protected void EnsureStorage() { }

	// RVA: 0x161B880 Offset: 0x161B981 VA: 0x161B880
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x161B9A0 Offset: 0x161BAA1 VA: 0x161B9A0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x1626100 Offset: 0x1626201 VA: 0x1626100
	protected void DoubleTrack() { }

	// RVA: 0x1626040 Offset: 0x1626141 VA: 0x1626040
	protected void DoubleStack() { }

	// RVA: 0x16261C0 Offset: 0x16262C1 VA: 0x16261C0
	protected void DoubleCrawl() { }

	// RVA: 0x1626280 Offset: 0x1626381 VA: 0x1626280
	protected void Crawl(int i) { }

	// RVA: 0x16262F0 Offset: 0x16263F1 VA: 0x16262F0
	protected int Popcrawl() { }

	// RVA: 0x161B850 Offset: 0x161B951 VA: 0x161B850
	protected int Crawlpos() { }

	// RVA: 0x161B750 Offset: 0x161B851 VA: 0x161B750
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x161B5E0 Offset: 0x161B6E1 VA: 0x161B5E0
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x161B7F0 Offset: 0x161B8F1 VA: 0x161B7F0
	protected void Uncapture() { }

	// RVA: 0x161B5C0 Offset: 0x161B6C1 VA: 0x161B5C0
	protected bool IsMatched(int cap) { }

	// RVA: 0x161BAC0 Offset: 0x161BBC1 VA: 0x161BAC0
	protected int MatchIndex(int cap) { }

	// RVA: 0x161BAE0 Offset: 0x161BBE1 VA: 0x161BAE0
	protected int MatchLength(int cap) { }
}

