[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

[Serializable]
public class Regex : ISerializable // TypeDefIndex: 1765
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0xBCE30 Offset: 0xBCF31 VA: 0xBCE30
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x171DBA0 Offset: 0x171DCA1 VA: 0x171DBA0
	protected void .ctor() { }

	// RVA: 0x171DC20 Offset: 0x171DD21 VA: 0x171DC20
	public void .ctor(string pattern) { }

	// RVA: 0x170BD20 Offset: 0x170BE21 VA: 0x170BD20
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x171DCB0 Offset: 0x171DDB1 VA: 0x171DCB0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x171EB50 Offset: 0x171EC51 VA: 0x171EB50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x171ED20 Offset: 0x171EE21 VA: 0x171ED20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x171E160 Offset: 0x171E261 VA: 0x171E160
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x171EE00 Offset: 0x171EF01 VA: 0x171EE00
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x171F050 Offset: 0x171F151 VA: 0x171F050
	public static string Escape(string str) { }

	// RVA: 0x171F100 Offset: 0x171F201 VA: 0x171F100
	public RegexOptions get_Options() { }

	// RVA: 0x171F110 Offset: 0x171F211 VA: 0x171F110
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x171F120 Offset: 0x171F221 VA: 0x171F120
	public bool get_RightToLeft() { }

	// RVA: 0x171F140 Offset: 0x171F241 VA: 0x171F140 Slot: 3
	public override string ToString() { }

	// RVA: 0x171C0E0 Offset: 0x171C1E1 VA: 0x171C0E0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x171F150 Offset: 0x171F251 VA: 0x171F150
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x171F230 Offset: 0x171F331 VA: 0x171F230
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x170BF40 Offset: 0x170C041 VA: 0x170BF40
	public bool IsMatch(string input) { }

	// RVA: 0x171F2D0 Offset: 0x171F3D1 VA: 0x171F2D0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x171F390 Offset: 0x171F491 VA: 0x171F390
	public static Match Match(string input, string pattern) { }

	// RVA: 0x171F470 Offset: 0x171F571 VA: 0x171F470
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F510 Offset: 0x171F611 VA: 0x171F510
	public Match Match(string input) { }

	// RVA: 0x171F600 Offset: 0x171F701 VA: 0x171F600
	public Match Match(string input, int startat) { }

	// RVA: 0x171F6B0 Offset: 0x171F7B1 VA: 0x171F6B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x171F740 Offset: 0x171F841 VA: 0x171F740
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171F860 Offset: 0x171F961 VA: 0x171F860
	public string Replace(string input, string replacement) { }

	// RVA: 0x171F920 Offset: 0x171FA21 VA: 0x171F920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x171FAC0 Offset: 0x171FBC1 VA: 0x171FAC0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x171FBA0 Offset: 0x171FCA1 VA: 0x171FBA0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x171FC40 Offset: 0x171FD41 VA: 0x171FC40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x171FD40 Offset: 0x171FE41 VA: 0x171FD40
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x171E540 Offset: 0x171E641 VA: 0x171E540
	protected void InitializeReferences() { }

	// RVA: 0x171C960 Offset: 0x171CA61 VA: 0x171C960
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x171E2D0 Offset: 0x171E3D1 VA: 0x171E2D0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x171E630 Offset: 0x171E731 VA: 0x171E630
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x171F130 Offset: 0x171F231 VA: 0x171F130
	protected bool UseOptionR() { }

	// RVA: 0x171FE00 Offset: 0x171FF01 VA: 0x171FE00
	internal bool UseOptionInvariant() { }

	// RVA: 0x171FE10 Offset: 0x171FF11 VA: 0x171FE10
	private static void .cctor() { }
}

